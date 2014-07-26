using System.Collections.Generic;
using GLD.HIPAA.Model;

namespace GLD.HIPAA.Classes
{
public class X12_00501_834
    {
        public Node Root = 
        new Node
        {
            Name = "X12_00501_834",  IsOptional = false,
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
                    Name = "BGN_BeginningSegment",  IsOptional = false,
                    Segment = new Segment
                    {
                        Tag = "BGN",  Min = 1,  Max = 1,  Name = "Beginning Segment",
                        Elements = new[]
                        {
                            new Element { Name = "Transaction Set Purpose Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_353" },
                            new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                            new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                            new Element { Name = "Time", IsOptional = false, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                            new Element { Name = "Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_623" },
                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                            new Element { Name = "Transaction Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_640" },
                            new Element { Name = "Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                            new Element { Name = "Security Level Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_786" },
                        }
                    } // end of "BGN"
                }
                ,
                new Node
                {
                    Name = "REF_TransactionSetPolicyNumber",  IsOptional = false,
                    Segment = new Segment
                    {
                        Tag = "REF",  Min = 0,  Max = 1,  Name = "Transaction Set Policy Number",
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
                    Name = "DTP_FileEffectiveDate",  IsOptional = false,
                    Segment = new Segment
                    {
                        Tag = "DTP",  Min = 0,  Max = 10000,  Name = "File Effective Date",
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
                    Name = "QTY_TransactionSetControlTotals",  IsOptional = false,
                    Segment = new Segment
                    {
                        Tag = "QTY",  Min = 0,  Max = 3,  Name = "Transaction Set Control Totals",
                        Elements = new[]
                        {
                            new Element { Name = "Quantity Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                            new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                            new Element { Name = "Free-form Information", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                        }
                    } // end of "QTY"
                }
                ,
                new Node
                {
                    Name = "N1_SubLoop",  IsOptional = false,
                    Nodes = new Node[]
                    {
                        new Node
                        {
                            Name = "TS834_1000A_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "N1_SponsorName",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "N1",  Min = 1,  Max = 1,  Name = "Sponsor Name",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                            new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Identification Code Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                            new Element { Name = "Identification Code", IsOptional = false, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Entity Relationship Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_706" },
                                            new Element { Name = "Entity Identifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                        }
                                    } // end of "N1"
                                }
                                ,
                            },
                        }
                        ,
                        new Node
                        {
                            Name = "TS834_1000B_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "N1_Payer",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "N1",  Min = 1,  Max = 1,  Name = "Payer",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                            new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Identification Code Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                            new Element { Name = "Identification Code", IsOptional = false, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Entity Relationship Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_706" },
                                            new Element { Name = "Entity Identifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                        }
                                    } // end of "N1"
                                }
                                ,
                            },
                        }
                        ,
                        new Node
                        {
                            Name = "TS834_1000C_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "N1_TPA_BrokerName",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "N1",  Min = 1,  Max = 1,  Name = "TPA/Broker Name",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                            new Element { Name = "Name", IsOptional = false, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Identification Code Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                            new Element { Name = "Identification Code", IsOptional = false, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Entity Relationship Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_706" },
                                            new Element { Name = "Entity Identifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                        }
                                    } // end of "N1"
                                }
                                ,
                                new Node
                                {
                                    Name = "TS834_1100C_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "ACT_TPA_BrokerAccountInformation",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "ACT",  Min = 1,  Max = 1,  Name = "TPA/Broker Account Information",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Account Number", IsOptional = false, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Identification Code Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                                    new Element { Name = "Identification Code", IsOptional = true, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Account Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_569" },
                                                    new Element { Name = "Account Number", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Payment Method Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_107" },
                                                    new Element { Name = "Benefit Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1216" },
                                                }
                                            } // end of "ACT"
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
                    Name = "TS834_2000_Loop",  IsOptional = false,
                    Nodes = new Node[]
                    {
                        new Node
                        {
                            Name = "INS_MemberLevelDetail",  IsOptional = false,
                            Segment = new Segment
                            {
                                Tag = "INS",  Min = 1,  Max = 1,  Name = "Member Level Detail",
                                Elements = new[]
                                {
                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                    new Element { Name = "Individual Relationship Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1069" },
                                    new Element { Name = "Maintenance Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_875" },
                                    new Element { Name = "Maintenance Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1203" },
                                    new Element { Name = "Benefit Status Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1216" },
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
                            Name = "REF_SubLoop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "REF_SubscriberIdentifier",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "REF",  Min = 1,  Max = 1,  Name = "Subscriber Identifier",
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
                                    Name = "REF_MemberPolicyNumber",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "REF",  Min = 0,  Max = 1,  Name = "Member Policy Number",
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
                                    Name = "REF_MemberSupplementalIdentifier_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "REF_MemberSupplementalIdentifier",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "REF",  Min = 0,  Max = 13,  Name = "Member Supplemental Identifier",
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
                            },
                        }
                        ,
                        new Node
                        {
                            Name = "DTP_MemberLevelDates",  IsOptional = false,
                            Segment = new Segment
                            {
                                Tag = "DTP",  Min = 0,  Max = 24,  Name = "Member Level Dates",
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
                            Name = "NM1_SubLoop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "TS834_2100A_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "NM1_MemberName",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Member Name",
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
                                        new Node
                                        {
                                            Name = "PER_MemberCommunicationsNumbers",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "PER",  Min = 0,  Max = 1,  Name = "Member Communications Numbers",
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
                                        new Node
                                        {
                                            Name = "N3_MemberResidenceStreetAddress",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N3",  Min = 0,  Max = 1,  Name = "Member Residence Street Address",
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
                                            Name = "N4_MemberCity_State_ZIPCode",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N4",  Min = 1,  Max = 1,  Name = "Member City, State, ZIP Code",
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
                                            Name = "DMG_MemberDemographics",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "DMG",  Min = 0,  Max = 1,  Name = "Member Demographics",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                    new Element { Name = "Date Time Period", IsOptional = false, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Gender Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1068" },
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
                                            Name = "EC_EmploymentClass",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "EC",  Min = 0,  Max = 10000,  Name = "Employment Class",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Employment Class Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1176" },
                                                    new Element { Name = "Employment Class Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1176" },
                                                    new Element { Name = "Employment Class Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1176" },
                                                    new Element { Name = "Percentage as Decimal", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Information Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1201" },
                                                    new Element { Name = "Occupation Code", IsOptional = true, LengthMin = 4, LengthMax = 6, Type = "code", Value = "null", CodeTable = "Table_11149" },
                                                }
                                            } // end of "EC"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "ICM_MemberIncome",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "ICM",  Min = 0,  Max = 1,  Name = "Member Income",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Frequency Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_594" },
                                                    new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Location Identifier", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Salary Grade", IsOptional = true, LengthMin = 1, LengthMax = 5, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Currency Code", IsOptional = true, LengthMin = 3, LengthMax = 3, Type = "code", Value = "null", CodeTable = "Table_10100" },
                                                }
                                            } // end of "ICM"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "AMT_MemberPolicyAmounts",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "AMT",  Min = 0,  Max = 7,  Name = "Member Policy Amounts",
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
                                            Name = "HLH_MemberHealthInformation",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "HLH",  Min = 0,  Max = 1,  Name = "Member Health Information",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Health-Related Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1212" },
                                                    new Element { Name = "Height", IsOptional = true, LengthMin = 1, LengthMax = 8, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Weight", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Weight", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "HLH"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "LUI_MemberLanguage",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "LUI",  Min = 0,  Max = 10000,  Name = "Member Language",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Identification Code Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                                    new Element { Name = "Identification Code", IsOptional = true, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Use of Language Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1303" },
                                                    new Element { Name = "Language Proficiency Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1476" },
                                                }
                                            } // end of "LUI"
                                        }
                                        ,
                                    },
                                }
                                ,
                                new Node
                                {
                                    Name = "TS834_2100B_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "NM1_IncorrectMemberName",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Incorrect Member Name",
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
                                        new Node
                                        {
                                            Name = "DMG_IncorrectMemberDemographics",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "DMG",  Min = 0,  Max = 1,  Name = "Incorrect Member Demographics",
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
                                    },
                                }
                                ,
                                new Node
                                {
                                    Name = "TS834_2100C_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "NM1_MemberMailingAddress",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Member Mailing Address",
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
                                            Name = "N3_MemberMailStreetAddress",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N3",  Min = 1,  Max = 1,  Name = "Member Mail Street Address",
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
                                            Name = "N4_MemberMailCity_State_ZIPCode",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N4",  Min = 1,  Max = 1,  Name = "Member Mail City, State, ZIP Code",
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
                                    },
                                }
                                ,
                                new Node
                                {
                                    Name = "TS834_2100D_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "NM1_MemberEmployer",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Member Employer",
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
                                            Name = "PER_MemberEmployerCommunicationsNumbers",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "PER",  Min = 0,  Max = 1,  Name = "Member Employer Communications Numbers",
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
                                        new Node
                                        {
                                            Name = "N3_MemberEmployerStreetAddress",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N3",  Min = 0,  Max = 1,  Name = "Member Employer Street Address",
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
                                            Name = "N4_MemberEmployerCity_State_ZIPCode",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N4",  Min = 1,  Max = 1,  Name = "Member Employer City, State, ZIP Code",
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
                                    },
                                }
                                ,
                                new Node
                                {
                                    Name = "TS834_2100E_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "NM1_MemberSchool",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Member School",
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
                                        new Node
                                        {
                                            Name = "PER_MemberSchoolCommmunicationsNumbers",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "PER",  Min = 0,  Max = 1,  Name = "Member School Commmunications Numbers",
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
                                        new Node
                                        {
                                            Name = "N3_MemberSchoolStreetAddress",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N3",  Min = 0,  Max = 1,  Name = "Member School Street Address",
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
                                            Name = "N4_MemberSchoolCity_State_ZIPCode",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N4",  Min = 1,  Max = 1,  Name = "Member School City, State, ZIP Code",
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
                                    },
                                }
                                ,
                                new Node
                                {
                                    Name = "TS834_2100F_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "NM1_CustodialParent",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Custodial Parent",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                                    new Element { Name = "Entity Type Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1065" },
                                                    new Element { Name = "Name Last or Organization Name", IsOptional = false, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Name First", IsOptional = false, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
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
                                            Name = "PER_CustodialParentCommunicationsNumbers",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "PER",  Min = 0,  Max = 1,  Name = "Custodial Parent Communications Numbers",
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
                                        new Node
                                        {
                                            Name = "N3_CustodialParentStreetAddress",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N3",  Min = 0,  Max = 1,  Name = "Custodial Parent Street Address",
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
                                            Name = "N4_CustodialParentCity_State_ZIPCode",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N4",  Min = 1,  Max = 1,  Name = "Custodial Parent City, State, ZIP Code",
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
                                    },
                                }
                                ,
                                new Node
                                {
                                    Name = "TS834_2100G_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "NM1_ResponsiblePerson",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Responsible Person",
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
                                        new Node
                                        {
                                            Name = "PER_ResponsiblePersonCommunicationsNumbers",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "PER",  Min = 0,  Max = 1,  Name = "Responsible Person Communications Numbers",
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
                                        new Node
                                        {
                                            Name = "N3_ResponsiblePersonStreetAddress",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N3",  Min = 0,  Max = 1,  Name = "Responsible Person Street Address",
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
                                            Name = "N4_ResponsiblePersonCity_State_ZIPCode",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N4",  Min = 1,  Max = 1,  Name = "Responsible Person City, State, ZIP Code",
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
                                    },
                                }
                                ,
                                new Node
                                {
                                    Name = "TS834_2100H_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "NM1_DropOffLocation",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Drop Off Location",
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
                                            Name = "N3_DropOffLocationStreetAddress",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N3",  Min = 0,  Max = 1,  Name = "Drop Off Location Street Address",
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
                                            Name = "N4_DropOffLocationCity_State_ZIPCode",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N4",  Min = 1,  Max = 1,  Name = "Drop Off Location City, State, ZIP Code",
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
                                    },
                                }
                                ,
                            },
                        }
                        ,
                        new Node
                        {
                            Name = "TS834_2200_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "DSB_DisabilityInformation",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "DSB",  Min = 1,  Max = 1,  Name = "Disability Information",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Disability Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1146" },
                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Occupation Code", IsOptional = true, LengthMin = 4, LengthMax = 6, Type = "code", Value = "null", CodeTable = "Table_11149" },
                                            new Element { Name = "Work Intensity Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1154" },
                                            new Element { Name = "Product Option Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1161" },
                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                            new Element { Name = "Medical Code Value", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "string", Value = "null", CodeTable = "null" },
                                        }
                                    } // end of "DSB"
                                }
                                ,
                                new Node
                                {
                                    Name = "DTP_DisabilityEligibilityDates",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "DTP",  Min = 0,  Max = 2,  Name = "Disability Eligibility Dates",
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
                        new Node
                        {
                            Name = "TS834_2300_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "HD_HealthCoverage",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "HD",  Min = 1,  Max = 1,  Name = "Health Coverage",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Maintenance Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_875" },
                                            new Element { Name = "Maintenance Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1203" },
                                            new Element { Name = "Insurance Line Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1205" },
                                            new Element { Name = "Plan Coverage Description", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Coverage Level Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1207" },
                                            new Element { Name = "Count", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Count", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Underwriting Decision Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1209" },
                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                            new Element { Name = "Drug House Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1211" },
                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                        }
                                    } // end of "HD"
                                }
                                ,
                                new Node
                                {
                                    Name = "DTP_HealthCoverageDates",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "DTP",  Min = 1,  Max = 6,  Name = "Health Coverage Dates",
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
                                    Name = "AMT_HealthCoveragePolicy",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "AMT",  Min = 0,  Max = 9,  Name = "Health Coverage Policy",
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
                                    Name = "REF_SubLoop_2",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                    }
                                }
                                ,
                                new Node
                                {
                                    Name = "IDC_IdentificationCard",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "IDC",  Min = 0,  Max = 3,  Name = "Identification Card",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Plan Coverage Description", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Identification Card Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1215" },
                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Action Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                                        }
                                    } // end of "IDC"
                                }
                                ,
                                new Node
                                {
                                    Name = "TS834_2310_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "LX_ProviderInformation",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "LX",  Min = 1,  Max = 1,  Name = "Provider Information",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Assigned Number", IsOptional = false, LengthMin = 1, LengthMax = 6, Type = "int", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "LX"
                                        }
                                        ,
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
                                                    new Element { Name = "Identification Code Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                                    new Element { Name = "Identification Code", IsOptional = true, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Entity Relationship Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_706" },
                                                    new Element { Name = "Entity Identifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                                    new Element { Name = "Name Last or Organization Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "NM1"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "N3_ProviderAddress",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N3",  Min = 0,  Max = 2,  Name = "Provider Address",
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
                                            Name = "N4_ProviderCity_State_ZIPCode",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N4",  Min = 1,  Max = 1,  Name = "Provider City, State, ZIP Code",
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
                                            Name = "PER_ProviderCommunicationsNumbers",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "PER",  Min = 0,  Max = 2,  Name = "Provider Communications Numbers",
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
                                        new Node
                                        {
                                            Name = "PLA_ProviderChangeReason",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "PLA",  Min = 0,  Max = 1,  Name = "Provider Change Reason",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                                                    new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                                    new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Time", IsOptional = true, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Maintenance Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1203" },
                                                }
                                            } // end of "PLA"
                                        }
                                        ,
                                    },
                                }
                                ,
                                new Node
                                {
                                    Name = "TS834_2320_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "COB_CoordinationofBenefits",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "COB",  Min = 1,  Max = 1,  Name = "Coordination of Benefits",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Payer Responsibility Sequence Number Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1138" },
                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Coordination of Benefits Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1143" },
                                                    new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                }
                                            } // end of "COB"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "REF_AdditionalCoordinationofBenefitsIdentifiers",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "REF",  Min = 0,  Max = 4,  Name = "Additional Coordination of Benefits Identifiers",
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
                                            Name = "DTP_CoordinationofBenefitsEligibilityDates",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "DTP",  Min = 0,  Max = 2,  Name = "Coordination of Benefits Eligibility Dates",
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
                                            Name = "TS834_2330_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "NM1_CoordinationofBenefitsRelatedEntity",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "NM1",  Min = 1,  Max = 1,  Name = "Coordination of Benefits Related Entity",
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
                                                    Name = "N3_CoordinationofBenefitsRelatedEntityAddress",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "N3",  Min = 0,  Max = 1,  Name = "Coordination of Benefits Related Entity Address",
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
                                                    Name = "N4_CoordinationofBenefitsOtherInsuranceCompanyCity_State_ZIPCode",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "N4",  Min = 1,  Max = 1,  Name = "Coordination of Benefits Other Insurance Company City, State, ZIP Code",
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
                                                    Name = "PER_AdministrativeCommunicationsContact",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "PER",  Min = 0,  Max = 1,  Name = "Administrative Communications Contact",
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
                                    },
                                }
                                ,
                            },
                        }
                        ,
                        new Node
                        {
                            Name = "TS834_LS_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "LS_AdditionalReportingCategories",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "LS",  Min = 1,  Max = 1,  Name = "Additional Reporting Categories",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Loop Identifier Code", IsOptional = false, LengthMin = 1, LengthMax = 4, Type = "string", Value = "null", CodeTable = "null" },
                                        }
                                    } // end of "LS"
                                }
                                ,
                                new Node
                                {
                                    Name = "TS834_2700_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "LX_MemberReportingCategories",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "LX",  Min = 1,  Max = 1,  Name = "Member Reporting Categories",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Assigned Number", IsOptional = false, LengthMin = 1, LengthMax = 6, Type = "int", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "LX"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "TS834_2750_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "N1_ReportingCategory",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "N1",  Min = 1,  Max = 1,  Name = "Reporting Category",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                                            new Element { Name = "Name", IsOptional = false, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Identification Code Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                                            new Element { Name = "Identification Code", IsOptional = true, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Entity Relationship Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_706" },
                                                            new Element { Name = "Entity Identifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                                        }
                                                    } // end of "N1"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "REF_ReportingCategoryReference",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "REF",  Min = 0,  Max = 16,  Name = "Reporting Category Reference",
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
                                                    Name = "DTP_ReportingCategoryDate",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Reporting Category Date",
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
                                    Name = "LE_AdditionalReportingCategoriesTermination",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "LE",  Min = 1,  Max = 1,  Name = "Additional Reporting Categories Termination",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Loop Identifier Code", IsOptional = false, LengthMin = 1, LengthMax = 4, Type = "string", Value = "null", CodeTable = "null" },
                                        }
                                    } // end of "LE"
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
    } // end of "X12_00501_834"
}
