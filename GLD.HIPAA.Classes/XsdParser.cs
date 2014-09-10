using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using GLD.HIPAA.Model;

namespace GLD.HIPAA.Classes
{
    public class XsdParser
    {
        private readonly XNamespace ns_Edi = "http://schemas.microsoft.com/BizTalk/EDI/X12/2006";
        private readonly XNamespace ns_b = "http://schemas.microsoft.com/BizTalk/2003";
        private readonly XNamespace ns_xs = "http://www.w3.org/2001/XMLSchema";
        public XElement EdiDocument = null; // filled in with CreateNodeTree()

        public Node EdiNodeTree;

        public XsdParser(string xsdFileName)
        {
            InputXsdFile(xsdFileName);
            var rootNodeName = GetRootNodeName();
            EdiNodeTree = new Node {Name = rootNodeName};
            EdiNodeTree = CreateNode(rootNodeName);
        }

        public void CreateClassFile(string filePath, string className)
        {
            File.WriteAllText(filePath + className + ".cs", Serializer.CreateClassFile(className, EdiNodeTree).ToString());
        }

        private void InputXsdFile(string xsdFileName)
        {
            // download xsd
            EdiDocument = null;
            EdiDocument = XElement.Load(xsdFileName);
        }

        private string GetRootNodeName()
        {
            return EdiDocument.Element(ns_xs + "annotation").Element(ns_xs + "appinfo").Element(ns_b + "schemaInfo").Attribute("root_reference").Value;
        }

        private Node CreateNode(string nodeName)
        {
            var node = new Node {Name = nodeName};
            // start from an element with rootName:
            // <xs:element name="X12_00501_835">
            //   <xs:complexType>
            //    <xs:sequence>
            //      <xs:element minOccurs="0" maxOccurs="1" name="ST">
            //...
            var element = EdiDocument.XPathSelectElement(@"//*[@name='" + nodeName + "']");
            if (IsNode(nodeName))
            {
                var nodeArr = new List<Node>();
                var elements = CreateChildElementCollection(element);
                foreach (var childElement in elements.Where(childElement => !IsSTorSEsubelements(childElement))) nodeArr.Add(CreateNode(GetElementName(childElement)));
                node.Nodes = nodeArr.ToArray();
            }
            else
                node.Segment = CreateSegment(element);
            return node;
        }

        // Becase the ST and SE segments are defined on plase, they subelements enumerated in the high level of segments. 
        // So, those subelements should not be processed as nodes. 
        private bool IsSTorSEsubelements(XElement element)
        {
            var name = GetElementName(element);
            return
                name == "ST01_TransactionSetIdentifierCode"
                || name == "ST02_TransactionSetControlNumber"
                || name == "ST03_ImplementationConventionReference"
                || name == "SE01_TransactionSegmentCount"
                || name == "SE02_TransactionSetControlNumber"
                ;
        }

        private string GetElementName(XElement element)
        {
            var name = (element.Attribute("ref") == null ? null : element.Attribute("ref").Value) ?? (element.Attribute("name") == null ? null : element.Attribute("name").Value);
            return name;
        }

        private IEnumerable<XElement> CreateChildElementCollection(XElement element)
        {
            return element.Descendants(ns_xs + "element");
        }

        private bool IsNode(string nodeName)
        {
            var nameParts = nodeName.Split(new[] {'_'}, StringSplitOptions.None);
            return nameParts[nameParts.Length - 1] == "Loop" || nameParts[nameParts.Length - 1] == "SubLoop" || nameParts[0] == "X12";
        }

        private Segment CreateSegment(XElement element)
        {
            var segment = new Segment();
            // xmlns:xs="http://www.w3.org/2001/XMLSchema" ...
            // xmlns:b="http://schemas.microsoft.com/BizTalk/2003" ...
            //<xs:element name="BPR_FinancialInformation">
            //    <xs:annotation>
            //        <xs:documentation>Financial Information</xs:documentation>
            //        <xs:appinfo>
            //            <b:recordInfo structure="delimited" field_order="prefix" tag_name="BPR" delimiter_type="inherit_field" count_ignore="no" xmlns:b="http://schemas.microsoft.com/BizTalk/2003">

            // /xs:schema/xs:element
            // /*[local-name()='X12_00501_835' and namespace-uri()='http://schemas.microsoft.com/BizTalk/EDI/X12/2006']/*[local-name()='BPR_FinancialInformation' and namespace-uri()='http://schemas.microsoft.com/BizTalk/EDI/X12/2006']
            ////XElement node = Doc.XPathSelectElement(@"//*[@name='" + segmentFullName + "']");

            if (element == null) return null; // null if there is no such element, do not proceeed with ref

            segment.Tag = NullIfNotExisted_tag_name(element);
            segment.Name = NullIfNotExisted_documentation(element);
            segment.Elements = GetEdiElements(element);
            //        <xs:element minOccurs="1" maxOccurs="1" ref="BPR_FinancialInformation" />

            var segmentName = element.Attribute("name").Value;
            var nodeRef = EdiDocument.XPathSelectElement(@"//*[@ref='" + segmentName + "']");
            if (nodeRef == null) return segment;
            segment.Min = OneIfNotExisted_minOccurs(nodeRef);
            segment.Max = OneIfNotExisted_maxOccurs(nodeRef);

            return segment;
        }

        private Element[] GetEdiElements(XElement segmentNode)
        {
            if (segmentNode == null) return null;
            var elements = NullIfNotExisted_element(segmentNode);
            if (elements == null) return null;

            var ediElements = new Element[elements.Count()];
            // set element parameters:
            var i = 0;
            foreach (var element in elements)
            {
                /*
                    <xs:element minOccurs="1" maxOccurs="1" name="BPR02_TotalActualProviderPaymentAmount">
                      <xs:annotation>
                        <xs:documentation>Monetary Amount_782</xs:documentation>
                        <xs:appinfo>
                          <b:fieldInfo ReferenceDesignator="782" edi_datatype="R" justification="right" xmlns:b="http://schemas.microsoft.com/BizTalk/2003" />
                        </xs:appinfo>
                      </xs:annotation>
                      <xs:simpleType>
                        <xs:restriction base="X12_R">
                          <xs:minLength value="1" />
                          <xs:maxLength value="18" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>    
                 * ...
                *       <xs:appinfo>
                            <b:fieldInfo ReferenceDesignator="305" edi_datatype="ID" codelist="305" justification="left" xmlns:b="http://schemas.microsoft.com/BizTalk/2003" />
                        </xs:appinfo>

                 */
                ediElements[i] = new Element();

                ediElements[i].Name = FormatName(NullIfNotExisted_documentation(element));
                ediElements[i].IsOptional = (element.Attribute("minOccurs").Value == "0");
                ediElements[i].Type = GetEdiElementType(NullIfNotExisted_edi_datatype(element));
                ediElements[i].CodeTable = GetEdiElementCodeTable(NullIfNotExisted_codelist(element));
                ediElements[i].LengthMin = ZeroIfNotExisted_minLength_value(element);
                ediElements[i].LengthMax = ZeroIfNotExisted_maxLength_value(element);

                i++;
            }
            return ediElements;
        }

        private string NullIfNotExisted_documentation(XElement element)
        {
            if (element.Element(ns_xs + "annotation") == null) return null;
            return element.Element(ns_xs + "annotation").Element(ns_xs + "documentation") == null
                ? null
                : element.Element(ns_xs + "annotation").Element(ns_xs + "documentation").Value;
        }

        private string NullIfNotExisted_tag_name(XElement element)
        {
            if (element.Element(ns_xs + "annotation") == null) return null;
            if (element.Element(ns_xs + "annotation").Element(ns_xs + "appinfo") == null) return null;
            if (element.Element(ns_xs + "annotation").Element(ns_xs + "appinfo").Element(ns_b + "recordInfo") == null) return null;
            return element.Element(ns_xs + "annotation").Element(ns_xs + "appinfo").Element(ns_b + "recordInfo").Attribute("tag_name") == null
                ? null
                : element.Element(ns_xs + "annotation").Element(ns_xs + "appinfo").Element(ns_b + "recordInfo").Attribute("tag_name").Value;
        }

        private int OneIfNotExisted_minOccurs(XElement element)
        {
            return element.Attribute("minOccurs") == null
                ? 1
                : Convert.ToInt32(element.Attribute("minOccurs").Value);
        }

        private int OneIfNotExisted_maxOccurs(XElement element)
        {
            if (element.Attribute("maxOccurs") == null) return 1;
            return element.Attribute("maxOccurs").Value == "unbounded" ? 10000 : Convert.ToInt32(element.Attribute("maxOccurs").Value);
        }

        private IEnumerable<XElement> NullIfNotExisted_element(XElement element)
        {
            if (element.Element(ns_xs + "complexType") == null) return null;
            if (element.Element(ns_xs + "complexType").Element(ns_xs + "sequence") == null) return null;
            return element.Element(ns_xs + "complexType").Element(ns_xs + "sequence").Elements(ns_xs + "element");
        }

        private string NullIfNotExisted_edi_datatype(XElement element)
        {
            if (element.Element(ns_xs + "annotation") == null) return null;
            if (element.Element(ns_xs + "annotation").Element(ns_xs + "appinfo") == null) return null;
            if (element.Element(ns_xs + "annotation").Element(ns_xs + "appinfo").Element(ns_b + "fieldInfo") == null) return null;
            return element.Element(ns_xs + "annotation").Element(ns_xs + "appinfo").Element(ns_b + "fieldInfo").Attribute("edi_datatype") == null
                ? null
                : element.Element(ns_xs + "annotation").Element(ns_xs + "appinfo").Element(ns_b + "fieldInfo").Attribute("edi_datatype").Value;
        }

        private string NullIfNotExisted_codelist(XElement element)
        {
            if (element.Element(ns_xs + "annotation") == null) return null;
            if (element.Element(ns_xs + "annotation").Element(ns_xs + "appinfo") == null) return null;
            if (element.Element(ns_xs + "annotation").Element(ns_xs + "appinfo").Element(ns_b + "fieldInfo") == null) return null;
            return element.Element(ns_xs + "annotation").Element(ns_xs + "appinfo").Element(ns_b + "fieldInfo").Attribute("codelist") == null
                ? null
                : element.Element(ns_xs + "annotation").Element(ns_xs + "appinfo").Element(ns_b + "fieldInfo").Attribute("codelist").Value;
        }

        private int ZeroIfNotExisted_minLength_value(XElement element)
        {
            if (element.Element(ns_xs + "simpleType") == null) return 0;
            if (element.Element(ns_xs + "simpleType").Element(ns_xs + "restriction") == null) return 0;
            if (element.Element(ns_xs + "simpleType").Element(ns_xs + "restriction").Element(ns_xs + "minLength") == null) return 0;
            return element.Element(ns_xs + "simpleType").Element(ns_xs + "restriction").Element(ns_xs + "minLength").Attribute("value") == null
                ? 0
                : Convert.ToInt32(element.Element(ns_xs + "simpleType").Element(ns_xs + "restriction").Element(ns_xs + "minLength").Attribute("value").Value);
        }

        private int ZeroIfNotExisted_maxLength_value(XElement element)
        {
            if (element.Element(ns_xs + "simpleType") == null) return 0;
            if (element.Element(ns_xs + "simpleType").Element(ns_xs + "restriction") == null) return 0;
            if (element.Element(ns_xs + "simpleType").Element(ns_xs + "restriction").Element(ns_xs + "maxLength") == null) return 0;
            return element.Element(ns_xs + "simpleType").Element(ns_xs + "restriction").Element(ns_xs + "maxLength").Attribute("value") == null
                ? 0
                : Convert.ToInt32(element.Element(ns_xs + "simpleType").Element(ns_xs + "restriction").Element(ns_xs + "maxLength").Attribute("value").Value);
        }

        private string FormatName(string elementName)
        {
            //name="Monetary Amount_782"
            // extract "Monetary Amount" 
            return elementName == null ? null : elementName.Split(new[] {'_'}, StringSplitOptions.None)[0];
        }

        private string GetEdiElementCodeTable(string codelist)
        {
            return String.IsNullOrEmpty(codelist) ? null : "Table_" + codelist;
        }

        private string GetEdiElementType(string ediDataType)
        {
            string primitiveType;
            switch (ediDataType)
            {
                case "ID":
                    primitiveType = "code";
                    break;
                case "R":
                    primitiveType = "decimal";
                    break;
                case "AN":
                    primitiveType = "string";
                    break;
                case "N0":
                    primitiveType = "int";
                    break;
                case "DT":
                    primitiveType = "date";
                    break;
                case "TM":
                    primitiveType = "time";
                    break;
                default:
                    primitiveType = "string";
                    break;
            }
            ;
            return primitiveType;
        }
    }
}