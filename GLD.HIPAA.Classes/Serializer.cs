using System;
using System.Text;
using GLD.HIPAA.Model;

namespace GLD.HIPAA.Classes
{
    internal class Serializer
    {
        private const int IndentLength = 4;

        // cs. file Whole: ==============================================================================
        public static StringBuilder CreateClassFile(string className, Node rootNode)
        {
            var sb = new StringBuilder();
            int indent = 0;

            FileHeader(ref sb, ref indent);
            Header(ref sb, ref indent);
            ClassHeader(ref sb, ref indent, className);
            Header(ref sb, ref indent);

            NodeVariableHeader(ref sb, ref indent);

            Node(ref sb, ref indent, rootNode);

            Semicolon(ref sb, ref indent);

            Footer(ref sb, ref indent, className);
            Footer(ref sb, ref indent, null);
            return sb;
        }

        // cs. file and class header: ==============================================================================

        private static void FileHeader(ref StringBuilder sb, ref int indent)
        {
            sb.Append(
                "using System.Collections.Generic;"
                + Environment.NewLine
                + "using GLD.HIPAA.Model;"
                + Environment.NewLine
                + Environment.NewLine
                + "namespace GLD.HIPAA.Classes"
                + Environment.NewLine
                );
        }

        private static void ClassHeader(ref StringBuilder sb, ref int indent, string className)
        {
            sb.Append(
                "public class " + className
                + Environment.NewLine
                );
        }

        // Node Variable: ==============================================================================
        private static void NodeVariableHeader(ref StringBuilder sb, ref int indent)
        {
            sb.AppendFormat(
                "{0}public Node Root = " // new Node
                + Environment.NewLine
                , new String(' ', indent*IndentLength)
                );
        }

        // Node Collection: ==============================================================================
        private static void NodeCollectionHeader(ref StringBuilder sb, ref int indent)
        {
            sb.AppendFormat(
                "{0}Nodes = new Node[]"
                + Environment.NewLine
                , new String(' ', indent*IndentLength)
                );
        }

        //Node: ==============================================================================
        private static void Node(ref StringBuilder sb, ref int indent, Node node)
        {
            NodeHeader(ref sb, ref indent);
            Header(ref sb, ref indent);
            NodeParameters(ref sb, ref indent, node);
            if (node.Nodes != null)
            {
                NodeCollectionHeader(ref sb, ref indent);
                Header(ref sb, ref indent);
                foreach (Node subnode in node.Nodes)
                {
                    Node(ref sb, ref indent, subnode);
                    Comma(ref sb, ref indent);
                }
                FooterWithComma(ref sb, ref indent);
            }
            if (node.Segment != null)
                Segment(ref sb, ref indent, node.Segment);
            Footer(ref sb, ref indent, null);
        }

        private static void NodeHeader(ref StringBuilder sb, ref int indent)
        {
            sb.AppendFormat(
                "{0}new Node"
                + Environment.NewLine
                , new String(' ', indent*IndentLength)
                );
        }

        private static void NodeParameters(ref StringBuilder sb, ref int indent, Node node)
        {
            sb.AppendFormat(
                "{0}Name = \"{1}\",  IsOptional = {2},"
                + Environment.NewLine
                , new String(' ', indent*IndentLength), node.Name, (node.IsOptional ? "true" : "false")
                );
        }

        //Segment: ==============================================================================

        private static void Segment(ref StringBuilder sb, ref int indent, Segment segment)
        {
            SegmentHeader(ref sb, ref indent);
            Header(ref sb, ref indent);
            SegmentProperties(ref sb, ref indent, segment);
            if (segment.Elements != null)
            {
                ElementCollection(ref sb, ref indent);
                Header(ref sb, ref indent);
                foreach (Element element in segment.Elements)
                    Element(ref sb, ref indent, element);
                Footer(ref sb, ref indent, null);
            }
            Footer(ref sb, ref indent, segment.Tag);
        }

        private static void SegmentHeader(ref StringBuilder sb, ref int indent)
        {
            sb.AppendFormat(
                "{0}Segment = new Segment"
                + Environment.NewLine
                , new String(' ', indent*IndentLength)
                );
        }

        private static void SegmentProperties(ref StringBuilder sb, ref int indent, Segment segment)
        {
            sb.AppendFormat(
                "{0}Tag = \"{1}\",  Min = {2},  Max = {3},  Name = \"{4}\","
                + Environment.NewLine
                , new String(' ', indent*IndentLength), segment.Tag, segment.Min, segment.Max, segment.Name
                );
        }

        //Element: ==============================================================================

        private static void ElementCollection(ref StringBuilder sb, ref int indent)
        {
            sb.AppendFormat(
                "{0}Elements = new[]"
                + Environment.NewLine
                , new String(' ', indent*IndentLength)
                );
        }

        private static void Element(ref StringBuilder sb, ref int indent, Element element)
        {
            sb.AppendFormat(
                "{0}new Element {{ Name = \"{1}\", IsOptional = {2}, LengthMin = {3}, LengthMax = {4}, Type = \"{5}\", Value = \"{6}\", CodeTable = \"{7}\" }},"
                + Environment.NewLine
                , new String(' ', indent*IndentLength), element.Name, (element.IsOptional ? "true" : "false"), element.LengthMin, element.LengthMax, element.Type,
                (element.Value ?? "null"), (element.CodeTable ?? "null")
                );
        }

        // Generic: ==============================================================================
        private static void Header(ref StringBuilder sb, ref int indent)
        {
            sb.AppendFormat(
                "{0}{{"
                + Environment.NewLine
                , new String(' ', indent*IndentLength)
                );
            indent++;
        }

        private static void Footer(ref StringBuilder sb, ref int indent, string endMember)
        {
            indent--;
            sb.AppendFormat(
                (String.IsNullOrEmpty(endMember)
                    ? "{0}}}"
                    : "{0}}} // end of \"{1}\"")
                + Environment.NewLine
                , new String(' ', indent*IndentLength), endMember
                );
        }

        private static void FooterWithComma(ref StringBuilder sb, ref int indent)
        {
            indent--;
            sb.AppendFormat("{0}}},"
                            + Environment.NewLine
                , new String(' ', indent*IndentLength)
                );
        }

        private static void Comma(ref StringBuilder sb, ref int indent)
        {
            sb.AppendFormat("{0},"
                            + Environment.NewLine
                , new String(' ', indent*IndentLength)
                );
        }

        private static void Semicolon(ref StringBuilder sb, ref int indent)
        {
            sb.AppendFormat("{0};"
                            + Environment.NewLine
                , new String(' ', indent*IndentLength)
                );
        }
    }
}