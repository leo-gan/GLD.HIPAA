using System.Collections.Generic;
using GLD.HIPAA.Model;

namespace GLD.HIPAA.Classes
{
public class X12_00501_270
    {
        public Node Root = 
        new Node
        {
            Name = "X12_00501_270",  IsOptional = false,
            Nodes = new Node[]
            {
                new Node
                {
                    Name = "ST",  IsOptional = false,
                    Segment = new Segment
                    {
                        Tag = "ST",  Min = 1,  Max = 1,  Name = "Transaction Set Header",
                        Elements = new[]
                        {
                            new Element { Name = "Transaction Set Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_143" },
                            new Element { Name = "Transaction Set Control Number", IsOptional = false, LengthMin = 4, LengthMax = 9, Type = "string", Value = "null", CodeTable = "null" },
                            new Element { Name = "Implementation Convention Reference", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1705" },
                        }
                    } // end of "ST"
                }
                ,
                new Node
                {
                    Name = "BHT_BeginningofHierarchicalTransaction",  IsOptional = false,
                    Segment = new Segment
                    {
                        Tag = "BHT",  Min = 1,  Max = 1,  Name = "Beginning of Hierarchical Transaction",
                        Elements = new[]
                        {
                            new Element { Name = "Hierarchical Structure Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1005" },
                            new Element { Name = "Transaction Set Purpose Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_353" },
                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                            new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                            new Element { Name = "Time", IsOptional = false, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                            new Element { Name = "Transaction Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_640" },
                        }
                    } // end of "BHT"
                }
                ,
                new Node
                {
                    Name = "TS270_2000A_Loop",  IsOptional = false,
                    Nodes = new Node[]
                    {
                        new Node
                        {
                            Name = "HL_InformationSourceLevel",  IsOptional = false,
                            Segment = new Segment
                            {
                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Information Source Level",
                                Elements = new[]
                                {
                                    new Element { Name = "Hierarchical ID Number", IsOptional = false, LengthMin = 1, LengthMax = 12, Type = "string", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Hierarchical Parent ID Number", IsOptional = true, LengthMin = 1, LengthMax = 12, Type = "string", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Hierarchical Level Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_735" },
                                    new Element { Name = "Hierarchical Child Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_736" },
                                }
                            } // end of "HL"
                        }
                        ,
                        new Node
                        {
                            Name = "TS270_2100A_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "NM1_InformationSourceName",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "NM1",  Min = 1,  Max = 1,  Name = "Information Source Name",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                            new Element { Name = "Entity Type Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1065" },
                                            new Element { Name = "Name Last or Organization Name", IsOptional = false, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Name First", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Name Middle", IsOptional = true, LengthMin = 1, LengthMax = 25, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Name Prefix", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Name Suffix", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Identification Code Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                            new Element { Name = "Identification Code", IsOptional = false, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Entity Relationship Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_706" },
                                            new Element { Name = "Entity Identifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                            new Element { Name = "Name Last or Organization Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                        }
                                    } // end of "NM1"
                                }
                                ,
                            },
                        }
                        ,
                        new Node
                        {
                            Name = "TS270_2000B_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "HL_InformationReceiverLevel",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "HL",  Min = 1,  Max = 1,  Name = "Information Receiver Level",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Hierarchical ID Number", IsOptional = false, LengthMin = 1, LengthMax = 12, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Hierarchical Parent ID Number", IsOptional = false, LengthMin = 1, LengthMax = 12, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Hierarchical Level Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_735" },
                                            new Element { Name = "Hierarchical Child Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_736" },
                                        }
                                    } // end of "HL"
                                }
                                ,
                                new Node
                                {
                                    Name = "TS270_2100B_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "NM1_InformationReceiverName",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Information Receiver Name",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                                    new Element { Name = "Entity Type Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1065" },
                                                    new Element { Name = "Name Last or Organization Name", IsOptional = false, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Name First", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Name Middle", IsOptional = true, LengthMin = 1, LengthMax = 25, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Name Prefix", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Name Suffix", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Identification Code Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                                    new Element { Name = "Identification Code", IsOptional = false, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Entity Relationship Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_706" },
                                                    new Element { Name = "Entity Identifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                                    new Element { Name = "Name Last or Organization Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "NM1"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "REF_InformationReceiverAdditionalIdentification",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "REF",  Min = 0,  Max = 9,  Name = "Information Receiver Additional Identification",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Reference Identification Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                                    new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "REF"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "N3_InformationReceiverAddress",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N3",  Min = 0,  Max = 1,  Name = "Information Receiver Address",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Address Information", IsOptional = false, LengthMin = 1, LengthMax = 55, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Address Information", IsOptional = true, LengthMin = 1, LengthMax = 55, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "N3"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "N4_InformationReceiverCity_State_ZIPCode",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N4",  Min = 0,  Max = 1,  Name = "Information Receiver City, State, ZIP Code",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "City Name", IsOptional = false, LengthMin = 2, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "State or Province Code", IsOptional = true, LengthMin = 2, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_10156" },
                                                    new Element { Name = "Postal Code", IsOptional = true, LengthMin = 3, LengthMax = 15, Type = "code", Value = "null", CodeTable = "Table_10116" },
                                                    new Element { Name = "Country Code", IsOptional = true, LengthMin = 2, LengthMax = 3, Type = "code", Value = "null", CodeTable = "Table_10026" },
                                                    new Element { Name = "Location Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_309" },
                                                    new Element { Name = "Location Identifier", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Country Subdivision Code", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "code", Value = "null", CodeTable = "Table_11715" },
                                                }
                                            } // end of "N4"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "PRV_InformationReceiverProviderInformation",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "PRV",  Min = 0,  Max = 1,  Name = "Information Receiver Provider Information",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Provider Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1221" },
                                                    new Element { Name = "Reference Identification Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "State or Province Code", IsOptional = true, LengthMin = 2, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_10156" },
                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Provider Organization Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1223" },
                                                }
                                            } // end of "PRV"
                                        }
                                        ,
                                    },
                                }
                                ,
                                new Node
                                {
                                    Name = "TS270_2000C_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "HL_SubscriberLevel",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Subscriber Level",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Hierarchical ID Number", IsOptional = false, LengthMin = 1, LengthMax = 12, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Hierarchical Parent ID Number", IsOptional = false, LengthMin = 1, LengthMax = 12, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Hierarchical Level Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_735" },
                                                    new Element { Name = "Hierarchical Child Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_736" },
                                                }
                                            } // end of "HL"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "TRN_SubscriberTraceNumber",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "TRN",  Min = 0,  Max = 2,  Name = "Subscriber Trace Number",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Trace Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_481" },
                                                    new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Originating Company Identifier", IsOptional = false, LengthMin = 10, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "TRN"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "TS270_2100C_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "NM1_SubscriberName",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "NM1",  Min = 1,  Max = 1,  Name = "Subscriber Name",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                                            new Element { Name = "Entity Type Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1065" },
                                                            new Element { Name = "Name Last or Organization Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Name First", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Name Middle", IsOptional = true, LengthMin = 1, LengthMax = 25, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Name Prefix", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Name Suffix", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Identification Code Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                                            new Element { Name = "Identification Code", IsOptional = true, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Entity Relationship Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_706" },
                                                            new Element { Name = "Entity Identifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                                            new Element { Name = "Name Last or Organization Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "NM1"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "REF_SubscriberAdditionalIdentification",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "REF",  Min = 0,  Max = 9,  Name = "Subscriber Additional Identification",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Reference Identification Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                                            new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "REF"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "N3_SubscriberAddress",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "N3",  Min = 0,  Max = 1,  Name = "Subscriber Address",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Address Information", IsOptional = false, LengthMin = 1, LengthMax = 55, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Address Information", IsOptional = true, LengthMin = 1, LengthMax = 55, Type = "string", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "N3"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "N4_SubscriberCity_State_ZIPCode",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "N4",  Min = 0,  Max = 1,  Name = "Subscriber City, State, ZIP Code",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "City Name", IsOptional = false, LengthMin = 2, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "State or Province Code", IsOptional = true, LengthMin = 2, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_10156" },
                                                            new Element { Name = "Postal Code", IsOptional = true, LengthMin = 3, LengthMax = 15, Type = "code", Value = "null", CodeTable = "Table_10116" },
                                                            new Element { Name = "Country Code", IsOptional = true, LengthMin = 2, LengthMax = 3, Type = "code", Value = "null", CodeTable = "Table_10026" },
                                                            new Element { Name = "Location Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_309" },
                                                            new Element { Name = "Location Identifier", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Country Subdivision Code", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "code", Value = "null", CodeTable = "Table_11715" },
                                                        }
                                                    } // end of "N4"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "PRV_ProviderInformation",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "PRV",  Min = 0,  Max = 1,  Name = "Provider Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Provider Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1221" },
                                                            new Element { Name = "Reference Identification Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "State or Province Code", IsOptional = true, LengthMin = 2, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_10156" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Provider Organization Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1223" },
                                                        }
                                                    } // end of "PRV"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "DMG_SubscriberDemographicInformation",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DMG",  Min = 0,  Max = 1,  Name = "Subscriber Demographic Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                            new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Gender Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1068" },
                                                            new Element { Name = "Marital Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1067" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Citizenship Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1066" },
                                                            new Element { Name = "Country Code", IsOptional = true, LengthMin = 2, LengthMax = 3, Type = "code", Value = "null", CodeTable = "Table_10026" },
                                                            new Element { Name = "Basis of Verification Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_659" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Code List Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1270" },
                                                            new Element { Name = "Industry Code", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "DMG"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "INS_MultipleBirthSequenceNumber",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "INS",  Min = 0,  Max = 1,  Name = "Multiple Birth Sequence Number",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Individual Relationship Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1069" },
                                                            new Element { Name = "Maintenance Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_875" },
                                                            new Element { Name = "Maintenance Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1203" },
                                                            new Element { Name = "Benefit Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1216" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1219" },
                                                            new Element { Name = "Employment Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_584" },
                                                            new Element { Name = "Student Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1220" },
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                            new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Confidentiality Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1165" },
                                                            new Element { Name = "City Name", IsOptional = true, LengthMin = 2, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "State or Province Code", IsOptional = true, LengthMin = 2, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_10156" },
                                                            new Element { Name = "Country Code", IsOptional = true, LengthMin = 2, LengthMax = 3, Type = "code", Value = "null", CodeTable = "Table_10026" },
                                                            new Element { Name = "Number", IsOptional = false, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "INS"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "HI_SubscriberHealthCareDiagnosisCode",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "HI",  Min = 0,  Max = 1,  Name = "Subscriber Health Care Diagnosis Code",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "HI"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "DTP_SubscriberDate",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 2,  Name = "Subscriber Date",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Date/Time Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_374" },
                                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                            new Element { Name = "Date Time Period", IsOptional = false, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "DTP"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "TS270_2110C_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "EQ_SubscriberEligibilityorBenefitInquiry",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "EQ",  Min = 1,  Max = 1,  Name = "Subscriber Eligibility or Benefit Inquiry",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Coverage Level Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1207" },
                                                                    new Element { Name = "Insurance Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1336" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "EQ"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "AMT_SubLoop",  IsOptional = false,
                                                            Nodes = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    Name = "AMT_SubscriberSpendDownAmount",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "AMT",  Min = 0,  Max = 1,  Name = "Subscriber Spend Down Amount",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Amount Qualifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_522" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Credit/Debit Flag Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_478" },
                                                                        }
                                                                    } // end of "AMT"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "AMT_SubscriberSpendDownTotalBilledAmount",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "AMT",  Min = 0,  Max = 1,  Name = "Subscriber Spend Down Total Billed Amount",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Amount Qualifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_522" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Credit/Debit Flag Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_478" },
                                                                        }
                                                                    } // end of "AMT"
                                                                }
                                                                ,
                                                            },
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "III_SubscriberEligibilityorBenefitAdditionalInquiryInformation",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "III",  Min = 0,  Max = 1,  Name = "Subscriber Eligibility or Benefit Additional Inquiry Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Code List Qualifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1270" },
                                                                    new Element { Name = "Industry Code", IsOptional = false, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Code Category", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1136" },
                                                                    new Element { Name = "Free-form Message Text", IsOptional = true, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Surface/Layer/Position Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_752" },
                                                                    new Element { Name = "Surface/Layer/Position Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_752" },
                                                                    new Element { Name = "Surface/Layer/Position Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_752" },
                                                                }
                                                            } // end of "III"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "REF_SubscriberAdditionalInformation",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "REF",  Min = 0,  Max = 1,  Name = "Subscriber Additional Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Reference Identification Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                                                    new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "REF"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "DTP_SubscriberEligibility_BenefitDate",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "DTP",  Min = 0,  Max = 1,  Name = "Subscriber Eligibility/Benefit Date",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Date/Time Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_374" },
                                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                    new Element { Name = "Date Time Period", IsOptional = false, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "DTP"
                                                        }
                                                        ,
                                                    },
                                                }
                                                ,
                                            },
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "TS270_2000D_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "HL_DependentLevel",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "HL",  Min = 1,  Max = 1,  Name = "Dependent Level",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Hierarchical ID Number", IsOptional = false, LengthMin = 1, LengthMax = 12, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Hierarchical Parent ID Number", IsOptional = false, LengthMin = 1, LengthMax = 12, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Hierarchical Level Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_735" },
                                                            new Element { Name = "Hierarchical Child Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_736" },
                                                        }
                                                    } // end of "HL"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "TRN_DependentTraceNumber",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "TRN",  Min = 0,  Max = 2,  Name = "Dependent Trace Number",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Trace Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_481" },
                                                            new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Originating Company Identifier", IsOptional = false, LengthMin = 10, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "TRN"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "TS270_2100D_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "NM1_DependentName",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Dependent Name",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                                                    new Element { Name = "Entity Type Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1065" },
                                                                    new Element { Name = "Name Last or Organization Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Name First", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Name Middle", IsOptional = true, LengthMin = 1, LengthMax = 25, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Name Prefix", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Name Suffix", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Identification Code Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                                                    new Element { Name = "Identification Code", IsOptional = true, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Entity Relationship Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_706" },
                                                                    new Element { Name = "Entity Identifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                                                    new Element { Name = "Name Last or Organization Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "NM1"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "REF_DependentAdditionalIdentification",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "REF",  Min = 0,  Max = 9,  Name = "Dependent Additional Identification",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Reference Identification Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                                                    new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "REF"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "N3_DependentAddress",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "N3",  Min = 0,  Max = 1,  Name = "Dependent Address",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Address Information", IsOptional = false, LengthMin = 1, LengthMax = 55, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Address Information", IsOptional = true, LengthMin = 1, LengthMax = 55, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "N3"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "N4_DependentCity_State_ZIPCode",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "N4",  Min = 0,  Max = 1,  Name = "Dependent City, State, ZIP Code",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "City Name", IsOptional = false, LengthMin = 2, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "State or Province Code", IsOptional = true, LengthMin = 2, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_10156" },
                                                                    new Element { Name = "Postal Code", IsOptional = true, LengthMin = 3, LengthMax = 15, Type = "code", Value = "null", CodeTable = "Table_10116" },
                                                                    new Element { Name = "Country Code", IsOptional = true, LengthMin = 2, LengthMax = 3, Type = "code", Value = "null", CodeTable = "Table_10026" },
                                                                    new Element { Name = "Location Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_309" },
                                                                    new Element { Name = "Location Identifier", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Country Subdivision Code", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "code", Value = "null", CodeTable = "Table_11715" },
                                                                }
                                                            } // end of "N4"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "PRV_ProviderInformation_2",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "PRV",  Min = 0,  Max = 1,  Name = "Provider Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Provider Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1221" },
                                                                    new Element { Name = "Reference Identification Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "State or Province Code", IsOptional = true, LengthMin = 2, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_10156" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Provider Organization Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1223" },
                                                                }
                                                            } // end of "PRV"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "DMG_DependentDemographicInformation",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "DMG",  Min = 0,  Max = 1,  Name = "Dependent Demographic Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                    new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Gender Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1068" },
                                                                    new Element { Name = "Marital Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1067" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Citizenship Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1066" },
                                                                    new Element { Name = "Country Code", IsOptional = true, LengthMin = 2, LengthMax = 3, Type = "code", Value = "null", CodeTable = "Table_10026" },
                                                                    new Element { Name = "Basis of Verification Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_659" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Code List Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1270" },
                                                                    new Element { Name = "Industry Code", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "DMG"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "INS_DependentRelationship",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "INS",  Min = 0,  Max = 1,  Name = "Dependent Relationship",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Individual Relationship Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1069" },
                                                                    new Element { Name = "Maintenance Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_875" },
                                                                    new Element { Name = "Maintenance Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1203" },
                                                                    new Element { Name = "Benefit Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1216" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1219" },
                                                                    new Element { Name = "Employment Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_584" },
                                                                    new Element { Name = "Student Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1220" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                    new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Confidentiality Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1165" },
                                                                    new Element { Name = "City Name", IsOptional = true, LengthMin = 2, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "State or Province Code", IsOptional = true, LengthMin = 2, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_10156" },
                                                                    new Element { Name = "Country Code", IsOptional = true, LengthMin = 2, LengthMax = 3, Type = "code", Value = "null", CodeTable = "Table_10026" },
                                                                    new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "INS"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "HI_DependentHealthCareDiagnosisCode",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HI",  Min = 0,  Max = 1,  Name = "Dependent Health Care Diagnosis Code",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "HI"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "DTP_DependentDate",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "DTP",  Min = 0,  Max = 2,  Name = "Dependent Date",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Date/Time Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_374" },
                                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                    new Element { Name = "Date Time Period", IsOptional = false, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "DTP"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "TS270_2110D_Loop",  IsOptional = false,
                                                            Nodes = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    Name = "EQ_DependentEligibilityorBenefitInquiry",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "EQ",  Min = 1,  Max = 1,  Name = "Dependent Eligibility or Benefit Inquiry",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Coverage Level Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1207" },
                                                                            new Element { Name = "Insurance Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1336" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "EQ"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "III_DependentEligibilityorBenefitAdditionalInquiryInformation",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "III",  Min = 0,  Max = 1,  Name = "Dependent Eligibility or Benefit Additional Inquiry Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Code List Qualifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1270" },
                                                                            new Element { Name = "Industry Code", IsOptional = false, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Code Category", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1136" },
                                                                            new Element { Name = "Free-form Message Text", IsOptional = true, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Surface/Layer/Position Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_752" },
                                                                            new Element { Name = "Surface/Layer/Position Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_752" },
                                                                            new Element { Name = "Surface/Layer/Position Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_752" },
                                                                        }
                                                                    } // end of "III"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "REF_DependentAdditionalInformation",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "REF",  Min = 0,  Max = 1,  Name = "Dependent Additional Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Reference Identification Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                                                            new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "REF"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "DTP_DependentEligibility_BenefitDate",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Dependent Eligibility/Benefit Date",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Date/Time Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_374" },
                                                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                            new Element { Name = "Date Time Period", IsOptional = false, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "DTP"
                                                                }
                                                                ,
                                                            },
                                                        }
                                                        ,
                                                    },
                                                }
                                                ,
                                            },
                                        }
                                        ,
                                    },
                                }
                                ,
                            },
                        }
                        ,
                    },
                }
                ,
                new Node
                {
                    Name = "SE",  IsOptional = false,
                    Segment = new Segment
                    {
                        Tag = "SE",  Min = 1,  Max = 1,  Name = "Transaction Set Trailer",
                        Elements = new[]
                        {
                            new Element { Name = "Number of Included Segments", IsOptional = false, LengthMin = 1, LengthMax = 10, Type = "int", Value = "null", CodeTable = "null" },
                            new Element { Name = "Transaction Set Control Number", IsOptional = false, LengthMin = 4, LengthMax = 9, Type = "string", Value = "null", CodeTable = "null" },
                        }
                    } // end of "SE"
                }
                ,
            },
        }
        ;
    } // end of "X12_00501_270"
}
