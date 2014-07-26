using System.Collections.Generic;
using GLD.HIPAA.Model;

namespace GLD.HIPAA.Classes
{
public class X12_00501_837_P
    {
        public Node Root = 
        new Node
        {
            Name = "X12_00501_837_P",  IsOptional = false,
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
                    Name = "ST03_ImplementationGuideVersionName",  IsOptional = false,
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
                    Name = "NM1_SubLoop",  IsOptional = false,
                    Nodes = new Node[]
                    {
                        new Node
                        {
                            Name = "TS837_1000A_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "NM1_SubmitterName",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "NM1",  Min = 1,  Max = 1,  Name = "Submitter Name",
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
                                    Name = "PER_SubmitterEDIContactInformation",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "PER",  Min = 1,  Max = 2,  Name = "Submitter EDI Contact Information",
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
                            Name = "TS837_1000B_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "NM1_ReceiverName",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "NM1",  Min = 1,  Max = 1,  Name = "Receiver Name",
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
                    },
                }
                ,
                new Node
                {
                    Name = "TS837_2000A_Loop",  IsOptional = false,
                    Nodes = new Node[]
                    {
                        new Node
                        {
                            Name = "HL_BillingProviderHierarchicalLevel",  IsOptional = false,
                            Segment = new Segment
                            {
                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Billing Provider Hierarchical Level",
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
                            Name = "PRV_BillingProviderSpecialtyInformation",  IsOptional = false,
                            Segment = new Segment
                            {
                                Tag = "PRV",  Min = 0,  Max = 1,  Name = "Billing Provider Specialty Information",
                                Elements = new[]
                                {
                                    new Element { Name = "Provider Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1221" },
                                    new Element { Name = "Reference Identification Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                    new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                    new Element { Name = "State or Province Code", IsOptional = true, LengthMin = 2, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_10156" },
                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Provider Organization Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1223" },
                                }
                            } // end of "PRV"
                        }
                        ,
                        new Node
                        {
                            Name = "CUR_ForeignCurrencyInformation",  IsOptional = false,
                            Segment = new Segment
                            {
                                Tag = "CUR",  Min = 0,  Max = 1,  Name = "Foreign Currency Information",
                                Elements = new[]
                                {
                                    new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                    new Element { Name = "Currency Code", IsOptional = false, LengthMin = 3, LengthMax = 3, Type = "code", Value = "null", CodeTable = "Table_10100" },
                                    new Element { Name = "Exchange Rate", IsOptional = true, LengthMin = 4, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Entity Identifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                    new Element { Name = "Currency Code", IsOptional = true, LengthMin = 3, LengthMax = 3, Type = "code", Value = "null", CodeTable = "Table_10100" },
                                    new Element { Name = "Currency Market/Exchange Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_669" },
                                    new Element { Name = "Date/Time Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_374" },
                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Time", IsOptional = true, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Date/Time Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_374" },
                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Time", IsOptional = true, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Date/Time Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_374" },
                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Time", IsOptional = true, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Date/Time Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_374" },
                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Time", IsOptional = true, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Date/Time Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_374" },
                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Time", IsOptional = true, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                                }
                            } // end of "CUR"
                        }
                        ,
                        new Node
                        {
                            Name = "NM1_SubLoop_2",  IsOptional = false,
                            Segment = new Segment
                            {
                                Tag = "",  Min = 1,  Max = 1,  Name = "",
                            }
                        }
                        ,
                        new Node
                        {
                            Name = "TS837_2000B_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "HL_SubscriberHierarchicalLevel",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "HL",  Min = 1,  Max = 1,  Name = "Subscriber Hierarchical Level",
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
                                    Name = "SBR_SubscriberInformation",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "SBR",  Min = 1,  Max = 1,  Name = "Subscriber Information",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Payer Responsibility Sequence Number Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1138" },
                                            new Element { Name = "Individual Relationship Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1069" },
                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Insurance Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1336" },
                                            new Element { Name = "Coordination of Benefits Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1143" },
                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                            new Element { Name = "Employment Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_584" },
                                            new Element { Name = "Claim Filing Indicator Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1032" },
                                        }
                                    } // end of "SBR"
                                }
                                ,
                                new Node
                                {
                                    Name = "PAT_PatientInformation",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "PAT",  Min = 0,  Max = 1,  Name = "Patient Information",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Individual Relationship Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1069" },
                                            new Element { Name = "Patient Location Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1384" },
                                            new Element { Name = "Employment Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_584" },
                                            new Element { Name = "Student Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1220" },
                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                            new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                            new Element { Name = "Weight", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                        }
                                    } // end of "PAT"
                                }
                                ,
                                new Node
                                {
                                    Name = "NM1_SubLoop_3",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "",  Min = 1,  Max = 1,  Name = "",
                                    }
                                }
                                ,
                                new Node
                                {
                                    Name = "TS837_2300_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "CLM_ClaimInformation",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "CLM",  Min = 1,  Max = 1,  Name = "Claim Information",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Claim Submitter's Identifier", IsOptional = false, LengthMin = 1, LengthMax = 38, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Claim Filing Indicator Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1032" },
                                                    new Element { Name = "Non-Institutional Claim Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1343" },
                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                    new Element { Name = "Provider Accept Assignment Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1359" },
                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                    new Element { Name = "Release of Information Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                    new Element { Name = "Patient Signature Source Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1351" },
                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Special Program Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1366" },
                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                    new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                    new Element { Name = "Provider Agreement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1360" },
                                                    new Element { Name = "Claim Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1029" },
                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                    new Element { Name = "Claim Submission Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1383" },
                                                    new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                }
                                            } // end of "CLM"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "DTP_SubLoop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "DTP_Date_OnsetofCurrentIllnessorSymptom",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Date - Onset of Current Illness or Symptom",
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
                                                    Name = "DTP_Date_InitialTreatmentDate",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Date - Initial Treatment Date",
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
                                                    Name = "DTP_Date_LastSeenDate",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Date - Last Seen Date",
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
                                                    Name = "DTP_Date_AcuteManifestation",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Date - Acute Manifestation",
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
                                                    Name = "DTP_Date_Accident",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Date - Accident",
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
                                                    Name = "DTP_Date_LastMenstrualPeriod",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Date - Last Menstrual Period",
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
                                                    Name = "DTP_Date_LastX_rayDate",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Date - Last X-ray Date",
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
                                                    Name = "DTP_Date_HearingandVisionPrescriptionDate",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Date - Hearing and Vision Prescription Date",
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
                                                    Name = "DTP_Date_DisabilityDates",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Date - Disability Dates",
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
                                                    Name = "DTP_Date_LastWorked",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Date - Last Worked",
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
                                                    Name = "DTP_Date_AuthorizedReturntoWork",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Date - Authorized Return to Work",
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
                                                    Name = "DTP_Date_Admission",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Date - Admission",
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
                                                    Name = "DTP_Date_Discharge",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Date - Discharge",
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
                                                    Name = "DTP_Date_AssumedandRelinquishedCareDates_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "DTP_Date_AssumedandRelinquishedCareDates",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "DTP",  Min = 0,  Max = 2,  Name = "Date - Assumed and Relinquished Care Dates",
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
                                                    Name = "DTP_PropertyandCasualtyDateofFirstContact",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Property and Casualty Date of First Contact",
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
                                                    Name = "DTP_Date_RepricerReceivedDate",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Date - Repricer Received Date",
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
                                            Name = "PWK_ClaimSupplementalInformation",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "PWK",  Min = 0,  Max = 10,  Name = "Claim Supplemental Information",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Report Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_755" },
                                                    new Element { Name = "Report Transmission Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_756" },
                                                    new Element { Name = "Report Copies Needed", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "int", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Entity Identifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                                    new Element { Name = "Identification Code Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                                    new Element { Name = "Identification Code", IsOptional = true, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Request Category Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                }
                                            } // end of "PWK"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "CN1_ContractInformation",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "CN1",  Min = 0,  Max = 1,  Name = "Contract Information",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Contract Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1166" },
                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Percent, Decimal Format", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Terms Discount Percent", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Version Identifier", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "CN1"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "AMT_PatientAmountPaid",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "AMT",  Min = 0,  Max = 1,  Name = "Patient Amount Paid",
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
                                            Name = "REF_SubLoop_5",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                            }
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "K3_FileInformation",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "K3",  Min = 0,  Max = 10,  Name = "File Information",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Fixed Format Information", IsOptional = false, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Record Format Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1333" },
                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "K3"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "NTE_ClaimNote",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "NTE",  Min = 0,  Max = 1,  Name = "Claim Note",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Note Reference Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_363" },
                                                    new Element { Name = "Description", IsOptional = false, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "NTE"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "CR1_AmbulanceTransportInformation",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "CR1",  Min = 0,  Max = 1,  Name = "Ambulance Transport Information",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                    new Element { Name = "Weight", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Ambulance Transport Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1316" },
                                                    new Element { Name = "Ambulance Transport Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1317" },
                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                    new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Address Information", IsOptional = true, LengthMin = 1, LengthMax = 55, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Address Information", IsOptional = true, LengthMin = 1, LengthMax = 55, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "CR1"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "CR2_SpinalManipulationServiceInformation",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "CR2",  Min = 0,  Max = 1,  Name = "Spinal Manipulation Service Information",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Count", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Subluxation Level Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1367" },
                                                    new Element { Name = "Subluxation Level Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1367" },
                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Nature of Condition Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1342" },
                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                }
                                            } // end of "CR2"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "CRC_SubLoop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "CRC_AmbulanceCertification_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "CRC_AmbulanceCertification",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CRC",  Min = 0,  Max = 3,  Name = "Ambulance Certification",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Code Category", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1136" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Condition Indicator", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                                    new Element { Name = "Condition Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                                    new Element { Name = "Condition Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                                    new Element { Name = "Condition Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                                    new Element { Name = "Condition Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                                }
                                                            } // end of "CRC"
                                                        }
                                                        ,
                                                    },
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "CRC_PatientConditionInformation_Vision_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "CRC_PatientConditionInformation_Vision",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CRC",  Min = 0,  Max = 3,  Name = "Patient Condition Information: Vision",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Code Category", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1136" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Condition Indicator", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                                    new Element { Name = "Condition Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                                    new Element { Name = "Condition Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                                    new Element { Name = "Condition Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                                    new Element { Name = "Condition Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                                }
                                                            } // end of "CRC"
                                                        }
                                                        ,
                                                    },
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "CRC_HomeboundIndicator",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "CRC",  Min = 0,  Max = 1,  Name = "Homebound Indicator",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Code Category", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1136" },
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Condition Indicator", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                            new Element { Name = "Condition Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                            new Element { Name = "Condition Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                            new Element { Name = "Condition Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                            new Element { Name = "Condition Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                        }
                                                    } // end of "CRC"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "CRC_EPSDTReferral",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "CRC",  Min = 0,  Max = 1,  Name = "EPSDT Referral",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Code Category", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1136" },
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Condition Indicator", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                            new Element { Name = "Condition Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                            new Element { Name = "Condition Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                            new Element { Name = "Condition Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                            new Element { Name = "Condition Indicator", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1321" },
                                                        }
                                                    } // end of "CRC"
                                                }
                                                ,
                                            },
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "HI_SubLoop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "HI_HealthCareDiagnosisCode",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "HI",  Min = 1,  Max = 1,  Name = "Health Care Diagnosis Code",
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
                                                    Name = "HI_AnesthesiaRelatedProcedure",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "HI",  Min = 0,  Max = 1,  Name = "Anesthesia Related Procedure",
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
                                                    Name = "HI_ConditionInformation_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "HI_ConditionInformation",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HI",  Min = 0,  Max = 2,  Name = "Condition Information",
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
                                                    },
                                                }
                                                ,
                                            },
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "HCP_ClaimPricing_RepricingInformation",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "HCP",  Min = 0,  Max = 1,  Name = "Claim Pricing/Repricing Information",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Pricing Methodology", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1473" },
                                                    new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Rate", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Reject Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                    new Element { Name = "Policy Compliance Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1526" },
                                                    new Element { Name = "Exception Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1527" },
                                                }
                                            } // end of "HCP"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "NM1_SubLoop_4",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                            }
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "TS837_2320_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "SBR_OtherSubscriberInformation",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "SBR",  Min = 1,  Max = 1,  Name = "Other Subscriber Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Payer Responsibility Sequence Number Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1138" },
                                                            new Element { Name = "Individual Relationship Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1069" },
                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Insurance Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1336" },
                                                            new Element { Name = "Coordination of Benefits Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1143" },
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Employment Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_584" },
                                                            new Element { Name = "Claim Filing Indicator Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1032" },
                                                        }
                                                    } // end of "SBR"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "CAS_ClaimLevelAdjustments",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "CAS",  Min = 0,  Max = 5,  Name = "Claim Level Adjustments",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Claim Adjustment Group Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1033" },
                                                            new Element { Name = "Claim Adjustment Reason Code", IsOptional = false, LengthMin = 1, LengthMax = 5, Type = "code", Value = "null", CodeTable = "Table_11034" },
                                                            new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Claim Adjustment Reason Code", IsOptional = true, LengthMin = 1, LengthMax = 5, Type = "code", Value = "null", CodeTable = "Table_11034" },
                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Claim Adjustment Reason Code", IsOptional = true, LengthMin = 1, LengthMax = 5, Type = "code", Value = "null", CodeTable = "Table_11034" },
                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Claim Adjustment Reason Code", IsOptional = true, LengthMin = 1, LengthMax = 5, Type = "code", Value = "null", CodeTable = "Table_11034" },
                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Claim Adjustment Reason Code", IsOptional = true, LengthMin = 1, LengthMax = 5, Type = "code", Value = "null", CodeTable = "Table_11034" },
                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Claim Adjustment Reason Code", IsOptional = true, LengthMin = 1, LengthMax = 5, Type = "code", Value = "null", CodeTable = "Table_11034" },
                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "CAS"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "AMT_SubLoop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "AMT_CoordinationofBenefits_COB_PayerPaidAmount",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "AMT",  Min = 0,  Max = 1,  Name = "Coordination of Benefits (COB) Payer Paid Amount",
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
                                                            Name = "AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "AMT",  Min = 0,  Max = 1,  Name = "Coordination of Benefits (COB) Total Non-covered Amount",
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
                                                            Name = "AMT_RemainingPatientLiability",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "AMT",  Min = 0,  Max = 1,  Name = "Remaining Patient Liability",
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
                                                    Name = "OI_OtherInsuranceCoverageInformation",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "OI",  Min = 1,  Max = 1,  Name = "Other Insurance Coverage Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Claim Filing Indicator Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1032" },
                                                            new Element { Name = "Claim Submission Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1383" },
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Patient Signature Source Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1351" },
                                                            new Element { Name = "Provider Agreement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1360" },
                                                            new Element { Name = "Release of Information Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                        }
                                                    } // end of "OI"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "MOA_OutpatientAdjudicationInformation",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "MOA",  Min = 0,  Max = 1,  Name = "Outpatient Adjudication Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Percentage as Decimal", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "MOA"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "NM1_SubLoop_5",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "",  Min = 1,  Max = 1,  Name = "",
                                                    }
                                                }
                                                ,
                                            },
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "TS837_2400_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "LX_ServiceLineNumber",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "LX",  Min = 1,  Max = 1,  Name = "Service Line Number",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Assigned Number", IsOptional = false, LengthMin = 1, LengthMax = 6, Type = "int", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "LX"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "SV1_ProfessionalService",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "SV1",  Min = 1,  Max = 1,  Name = "Professional Service",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                            new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                            new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Multiple Procedure Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1340" },
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Review Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1364" },
                                                            new Element { Name = "National or Local Assigned Review Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Copay Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1327" },
                                                            new Element { Name = "Health Care Professional Shortage Area Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11334" },
                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Postal Code", IsOptional = true, LengthMin = 3, LengthMax = 15, Type = "code", Value = "null", CodeTable = "Table_10116" },
                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Level of Care Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1337" },
                                                            new Element { Name = "Provider Agreement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1360" },
                                                        }
                                                    } // end of "SV1"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "SV5_DurableMedicalEquipmentService",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "SV5",  Min = 0,  Max = 1,  Name = "Durable Medical Equipment Service",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                            new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Frequency Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_594" },
                                                            new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                        }
                                                    } // end of "SV5"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "PWK_SubLoop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "PWK_LineSupplementalInformation_Loop",  IsOptional = false,
                                                            Nodes = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    Name = "PWK_LineSupplementalInformation",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "PWK",  Min = 0,  Max = 10,  Name = "Line Supplemental Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Report Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_755" },
                                                                            new Element { Name = "Report Transmission Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_756" },
                                                                            new Element { Name = "Report Copies Needed", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "int", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Entity Identifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                                                            new Element { Name = "Identification Code Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                                                            new Element { Name = "Identification Code", IsOptional = true, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Request Category Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                                        }
                                                                    } // end of "PWK"
                                                                }
                                                                ,
                                                            },
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "PWK",  Min = 0,  Max = 1,  Name = "Durable Medical Equipment Certificate of Medical Necessity Indicator",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Report Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_755" },
                                                                    new Element { Name = "Report Transmission Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_756" },
                                                                    new Element { Name = "Report Copies Needed", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "int", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Entity Identifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                                                    new Element { Name = "Identification Code Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                                                    new Element { Name = "Identification Code", IsOptional = true, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Request Category Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                                }
                                                            } // end of "PWK"
                                                        }
                                                        ,
                                                    },
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "CR1_AmbulanceTransportInformation_2",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "CR1",  Min = 0,  Max = 1,  Name = "Ambulance Transport Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                            new Element { Name = "Weight", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Ambulance Transport Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1316" },
                                                            new Element { Name = "Ambulance Transport Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1317" },
                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                            new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Address Information", IsOptional = true, LengthMin = 1, LengthMax = 55, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Address Information", IsOptional = true, LengthMin = 1, LengthMax = 55, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "CR1"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "CR3_DurableMedicalEquipmentCertification",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "CR3",  Min = 0,  Max = 1,  Name = "Durable Medical Equipment Certification",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                            new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Insulin Dependent Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1335" },
                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "CR3"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "CRC_SubLoop_2",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                    }
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "DTP_SubLoop_2",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "",  Min = 1,  Max = 1,  Name = "",
                                                    }
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "QTY_SubLoop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "QTY_AmbulancePatientCount",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "QTY",  Min = 0,  Max = 1,  Name = "Ambulance Patient Count",
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
                                                            Name = "QTY_ObstetricAnesthesiaAdditionalUnits",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "QTY",  Min = 0,  Max = 1,  Name = "Obstetric Anesthesia Additional Units",
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
                                                    },
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "MEA_TestResult",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "MEA",  Min = 0,  Max = 5,  Name = "Test Result",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Measurement Reference ID Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_737" },
                                                            new Element { Name = "Measurement Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_738" },
                                                            new Element { Name = "Measurement Value", IsOptional = false, LengthMin = 1, LengthMax = 20, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Range Minimum", IsOptional = true, LengthMin = 1, LengthMax = 20, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Range Maximum", IsOptional = true, LengthMin = 1, LengthMax = 20, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Measurement Significance Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_935" },
                                                            new Element { Name = "Measurement Attribute Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_936" },
                                                            new Element { Name = "Surface/Layer/Position Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_752" },
                                                            new Element { Name = "Measurement Method or Device", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1373" },
                                                            new Element { Name = "Code List Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1270" },
                                                            new Element { Name = "Industry Code", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "MEA"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "CN1_ContractInformation_2",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "CN1",  Min = 0,  Max = 1,  Name = "Contract Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Contract Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1166" },
                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Percent, Decimal Format", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Terms Discount Percent", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Version Identifier", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "CN1"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "REF_SubLoop_7",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                    }
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "AMT_SubLoop_2",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                    }
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "K3_FileInformation_2",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "K3",  Min = 0,  Max = 10,  Name = "File Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Fixed Format Information", IsOptional = false, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Record Format Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1333" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "K3"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "NTE_SubLoop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "NTE_LineNote",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "NTE",  Min = 0,  Max = 1,  Name = "Line Note",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Note Reference Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_363" },
                                                                    new Element { Name = "Description", IsOptional = false, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "NTE"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "NTE_ThirdPartyOrganizationNotes",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "NTE",  Min = 0,  Max = 1,  Name = "Third Party Organization Notes",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Note Reference Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_363" },
                                                                    new Element { Name = "Description", IsOptional = false, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "NTE"
                                                        }
                                                        ,
                                                    },
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "PS1_PurchasedServiceInformation",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "PS1",  Min = 0,  Max = 1,  Name = "Purchased Service Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "State or Province Code", IsOptional = true, LengthMin = 2, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_10156" },
                                                        }
                                                    } // end of "PS1"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "HCP_LinePricing_RepricingInformation",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "HCP",  Min = 0,  Max = 1,  Name = "Line Pricing/Repricing Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Pricing Methodology", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1473" },
                                                            new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Rate", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                            new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Reject Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                            new Element { Name = "Policy Compliance Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1526" },
                                                            new Element { Name = "Exception Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1527" },
                                                        }
                                                    } // end of "HCP"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "TS837_2410_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "LIN_DrugIdentification",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "LIN",  Min = 1,  Max = 1,  Name = "Drug Identification",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Assigned Identification", IsOptional = true, LengthMin = 1, LengthMax = 20, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Product/Service ID", IsOptional = false, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "LIN"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CTP_DrugQuantity",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CTP",  Min = 1,  Max = 1,  Name = "Drug Quantity",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Class of Trade Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_687" },
                                                                    new Element { Name = "Price Identifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_236" },
                                                                    new Element { Name = "Unit Price", IsOptional = true, LengthMin = 1, LengthMax = 17, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Price Multiplier Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_648" },
                                                                    new Element { Name = "Multiplier", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Basis of Unit Price Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_639" },
                                                                    new Element { Name = "Condition Value", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Multiple Price Quantity", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "int", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "CTP"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "REF_PrescriptionorCompoundDrugAssociationNumber",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "REF",  Min = 0,  Max = 1,  Name = "Prescription or Compound Drug Association Number",
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
                                                    Name = "NM1_SubLoop_6",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                    }
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "TS837_2430_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "SVD_LineAdjudicationInformation",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "SVD",  Min = 1,  Max = 1,  Name = "Line Adjudication Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Identification Code", IsOptional = false, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Assigned Number", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "int", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "SVD"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CAS_LineAdjustment",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CAS",  Min = 0,  Max = 5,  Name = "Line Adjustment",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Claim Adjustment Group Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1033" },
                                                                    new Element { Name = "Claim Adjustment Reason Code", IsOptional = false, LengthMin = 1, LengthMax = 5, Type = "code", Value = "null", CodeTable = "Table_11034" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Claim Adjustment Reason Code", IsOptional = true, LengthMin = 1, LengthMax = 5, Type = "code", Value = "null", CodeTable = "Table_11034" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Claim Adjustment Reason Code", IsOptional = true, LengthMin = 1, LengthMax = 5, Type = "code", Value = "null", CodeTable = "Table_11034" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Claim Adjustment Reason Code", IsOptional = true, LengthMin = 1, LengthMax = 5, Type = "code", Value = "null", CodeTable = "Table_11034" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Claim Adjustment Reason Code", IsOptional = true, LengthMin = 1, LengthMax = 5, Type = "code", Value = "null", CodeTable = "Table_11034" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Claim Adjustment Reason Code", IsOptional = true, LengthMin = 1, LengthMax = 5, Type = "code", Value = "null", CodeTable = "Table_11034" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "CAS"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "DTP_LineCheckorRemittanceDate",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "DTP",  Min = 1,  Max = 1,  Name = "Line Check or Remittance Date",
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
                                                            Name = "AMT_RemainingPatientLiability_2",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "AMT",  Min = 0,  Max = 1,  Name = "Remaining Patient Liability",
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
                                                    Name = "TS837_2440_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "LQ_FormIdentificationCode",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "LQ",  Min = 1,  Max = 1,  Name = "Form Identification Code",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Code List Qualifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1270" },
                                                                    new Element { Name = "Industry Code", IsOptional = false, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "LQ"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "FRM_SupportingDocumentation",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "FRM",  Min = 1,  Max = 99,  Name = "Supporting Documentation",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Assigned Identification", IsOptional = false, LengthMin = 1, LengthMax = 20, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Percent, Decimal Format", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "FRM"
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
                                    Name = "TS837_2000C_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "HL_PatientHierarchicalLevel",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Patient Hierarchical Level",
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
                                            Name = "PAT_PatientInformation_2",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "PAT",  Min = 1,  Max = 1,  Name = "Patient Information",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Individual Relationship Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1069" },
                                                    new Element { Name = "Patient Location Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1384" },
                                                    new Element { Name = "Employment Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_584" },
                                                    new Element { Name = "Student Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1220" },
                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                    new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                    new Element { Name = "Weight", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                }
                                            } // end of "PAT"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "TS837_2010CA_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "NM1_PatientName",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "NM1",  Min = 1,  Max = 1,  Name = "Patient Name",
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
                                                    Name = "N3_PatientAddress",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "N3",  Min = 1,  Max = 1,  Name = "Patient Address",
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
                                                    Name = "N4_PatientCity_State_ZIPCode",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "N4",  Min = 1,  Max = 1,  Name = "Patient City, State, ZIP Code",
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
                                                    Name = "DMG_PatientDemographicInformation",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DMG",  Min = 1,  Max = 1,  Name = "Patient Demographic Information",
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
                                                    Name = "REF_PropertyandCasualtyClaimNumber_2",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "REF",  Min = 0,  Max = 1,  Name = "Property and Casualty Claim Number",
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
                                                    Name = "PER_PropertyandCasualtyPatientContactInformation",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "PER",  Min = 0,  Max = 1,  Name = "Property and Casualty Patient Contact Information",
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
                                            Name = "TS837_2300_Loop1",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "",  Min = 1,  Max = 100,  Name = "Loop for Claim Information",
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
                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            }
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
    } // end of "X12_00501_837_P"
}
