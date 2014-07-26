using System.Collections.Generic;
using GLD.HIPAA.Model;

namespace GLD.HIPAA.Classes
{
public class X12_00501_277
    {
        public Node Root = 
        new Node
        {
            Name = "X12_00501_277",  IsOptional = false,
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
                    Name = "ST03_Version_Release_orIndustryIdentifier",  IsOptional = false,
                    Segment = new Segment
                    {
                        Tag = "",  Min = 1,  Max = 1,  Name = "Implementation Convention Reference_1705",
                    }
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
                            new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                            new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                            new Element { Name = "Time", IsOptional = false, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                            new Element { Name = "Transaction Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_640" },
                        }
                    } // end of "BHT"
                }
                ,
                new Node
                {
                    Name = "TS277_2000A_Loop",  IsOptional = false,
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
                            Name = "TS277_2100A_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "NM1_PayerName",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "NM1",  Min = 1,  Max = 1,  Name = "Payer Name",
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
                                    Name = "PER_PayerContactInformation",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "PER",  Min = 0,  Max = 1,  Name = "Payer Contact Information",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Contact Function Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_366" },
                                            new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Communication Number Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_365" },
                                            new Element { Name = "Communication Number", IsOptional = false, LengthMin = 1, LengthMax = 256, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Communication Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_365" },
                                            new Element { Name = "Communication Number", IsOptional = true, LengthMin = 1, LengthMax = 256, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Communication Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_365" },
                                            new Element { Name = "Communication Number", IsOptional = true, LengthMin = 1, LengthMax = 256, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Contact Inquiry Reference", IsOptional = true, LengthMin = 1, LengthMax = 20, Type = "string", Value = "null", CodeTable = "null" },
                                        }
                                    } // end of "PER"
                                }
                                ,
                            },
                        }
                        ,
                        new Node
                        {
                            Name = "TS277_2000B_Loop",  IsOptional = false,
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
                                    Name = "TS277_2100B_Loop",  IsOptional = false,
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
                                                    new Element { Name = "Name Last or Organization Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
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
                                    Name = "TS277_2200B_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "TRN_InformationReceiverTraceIdentifier",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "TRN",  Min = 1,  Max = 1,  Name = "Information Receiver Trace Identifier",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Trace Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_481" },
                                                    new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Originating Company Identifier", IsOptional = true, LengthMin = 10, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "TRN"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "STC_InformationReceiverStatusInformation",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "STC",  Min = 1,  Max = 10000,  Name = "Information Receiver Status Information",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Action Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Payment Method Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_591" },
                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Check Number", IsOptional = true, LengthMin = 1, LengthMax = 16, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Free-form Message Text", IsOptional = true, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "STC"
                                        }
                                        ,
                                    },
                                }
                                ,
                                new Node
                                {
                                    Name = "TS277_2000C_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "HL_ServiceProviderLevel",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Service Provider Level",
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
                                            Name = "TS277_2100C_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "NM1_ProviderName",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "NM1",  Min = 1,  Max = 1,  Name = "Provider Name",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                                            new Element { Name = "Entity Type Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1065" },
                                                            new Element { Name = "Name Last or Organization Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
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
                                            Name = "TS277_2200C_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "TRN_ProviderofServiceTraceIdentifier",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "TRN",  Min = 1,  Max = 1,  Name = "Provider of Service Trace Identifier",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Trace Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_481" },
                                                            new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Originating Company Identifier", IsOptional = true, LengthMin = 10, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "TRN"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "STC_ProviderStatusInformation",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "STC",  Min = 1,  Max = 10000,  Name = "Provider Status Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Action Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Payment Method Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_591" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Check Number", IsOptional = true, LengthMin = 1, LengthMax = 16, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Free-form Message Text", IsOptional = true, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "STC"
                                                }
                                                ,
                                            },
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "TS277_2000D_Loop",  IsOptional = false,
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
                                                    Name = "TS277_2100D_Loop",  IsOptional = false,
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
                                                    Name = "TS277_2200D_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "TRN_ClaimStatusTrackingNumber",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "TRN",  Min = 1,  Max = 1,  Name = "Claim Status Tracking Number",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Trace Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_481" },
                                                                    new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Originating Company Identifier", IsOptional = true, LengthMin = 10, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "TRN"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "STC_ClaimLevelStatusInformation",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "STC",  Min = 1,  Max = 10000,  Name = "Claim Level Status Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Action Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Payment Method Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_591" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Check Number", IsOptional = true, LengthMin = 1, LengthMax = 16, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Free-form Message Text", IsOptional = true, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "STC"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "REF_SubLoop",  IsOptional = false,
                                                            Nodes = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    Name = "REF_PayerClaimControlNumber",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "REF",  Min = 0,  Max = 1,  Name = "Payer Claim Control Number",
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
                                                                    Name = "REF_InstitutionalBillTypeIdentification",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "REF",  Min = 0,  Max = 1,  Name = "Institutional Bill Type Identification",
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
                                                                    Name = "REF_PatientControlNumber",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "REF",  Min = 0,  Max = 1,  Name = "Patient Control Number",
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
                                                                    Name = "REF_PharmacyPrescriptionNumber",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "REF",  Min = 0,  Max = 1,  Name = "Pharmacy Prescription Number",
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
                                                                    Name = "REF_VoucherIdentifier",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "REF",  Min = 0,  Max = 1,  Name = "Voucher Identifier",
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
                                                                    Name = "REF_ClaimIdentificationNumberForClearinghousesandOtherTransmissonIntermediaries",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "REF",  Min = 0,  Max = 1,  Name = "Claim Identification Number For Clearinghouses and Other Transmisson Intermediaries",
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
                                                            },
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "DTP_ClaimServiceDate",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "DTP",  Min = 0,  Max = 1,  Name = "Claim Service Date",
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
                                                            Name = "TS277_2220D_Loop",  IsOptional = false,
                                                            Nodes = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    Name = "SVC_ServiceLineInformation",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "SVC",  Min = 1,  Max = 1,  Name = "Service Line Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "SVC"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "STC_ServiceLineStatusInformation",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "STC",  Min = 1,  Max = 10000,  Name = "Service Line Status Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Action Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Payment Method Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_591" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Check Number", IsOptional = true, LengthMin = 1, LengthMax = 16, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Free-form Message Text", IsOptional = true, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "STC"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "REF_ServiceLineItemIdentification",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "REF",  Min = 0,  Max = 1,  Name = "Service Line Item Identification",
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
                                                                    Name = "DTP_ServiceLineDate",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "DTP",  Min = 1,  Max = 1,  Name = "Service Line Date",
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
                                                    Name = "TS277_2000E_Loop",  IsOptional = false,
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
                                                                    new Element { Name = "Hierarchical Child Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_736" },
                                                                }
                                                            } // end of "HL"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "TS277_2100E_Loop",  IsOptional = false,
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
                                                                            new Element { Name = "Name Last or Organization Name", IsOptional = false, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
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
                                                            },
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "TS277_2200E_Loop",  IsOptional = false,
                                                            Nodes = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    Name = "TRN_ClaimStatusTrackingNumber_2",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "TRN",  Min = 1,  Max = 1,  Name = "Claim Status Tracking Number",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Trace Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_481" },
                                                                            new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Originating Company Identifier", IsOptional = true, LengthMin = 10, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "TRN"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "STC_ClaimLevelStatusInformation_2",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "STC",  Min = 1,  Max = 10000,  Name = "Claim Level Status Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Action Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Payment Method Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_591" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Check Number", IsOptional = true, LengthMin = 1, LengthMax = 16, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Free-form Message Text", IsOptional = true, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "STC"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "REF_SubLoop_2",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                    }
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "DTP_ClaimServiceDate_2",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Claim Service Date",
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
                                                                    Name = "TS277_2220E_Loop",  IsOptional = false,
                                                                    Nodes = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            Name = "SVC_ServiceLineInformation_2",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "SVC",  Min = 1,  Max = 1,  Name = "Service Line Information",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                }
                                                                            } // end of "SVC"
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "STC_ServiceLineStatusInformation_2",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "STC",  Min = 1,  Max = 10000,  Name = "Service Line Status Information",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Action Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Payment Method Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_591" },
                                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Check Number", IsOptional = true, LengthMin = 1, LengthMax = 16, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Free-form Message Text", IsOptional = true, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                                }
                                                                            } // end of "STC"
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "REF_ServiceLineItemIdentification_2",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "REF",  Min = 0,  Max = 1,  Name = "Service Line Item Identification",
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
                                                                            Name = "DTP_ServiceLineDate_2",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "DTP",  Min = 1,  Max = 1,  Name = "Service Line Date",
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
    } // end of "X12_00501_277"
}
