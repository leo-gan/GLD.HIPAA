using System.Collections.Generic;
using GLD.HIPAA.Model;

namespace GLD.HIPAA.Classes
{
public class X12_00501_278
    {
        public Node Root = 
        new Node
        {
            Name = "X12_00501_278",  IsOptional = false,
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
                    Name = "A1_BHT_Loop",  IsOptional = false,
                    Nodes = new Node[]
                    {
                        new Node
                        {
                            Name = "BHT_BeginningofHierarchicalTransaction_TS278A1",  IsOptional = false,
                            Segment = new Segment
                            {
                                Tag = "BHT",  Min = 0,  Max = 1,  Name = "Beginning of Hierarchical Transaction",
                                Elements = new[]
                                {
                                    new Element { Name = "Hierarchical Structure Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1005" },
                                    new Element { Name = "Transaction Set Purpose Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_353" },
                                    new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Time", IsOptional = false, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Transaction Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_640" },
                                }
                            } // end of "BHT"
                        }
                        ,
                        new Node
                        {
                            Name = "TS278A1_2000A_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "HL_UtilizationManagementOrganization_UMO_Level_TS278A1",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "HL",  Min = 1,  Max = 1,  Name = "Utilization Management Organization (UMO) Level",
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
                                    Name = "TS278A1_2010A_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "NM1_UtilizationManagementOrganization_UMO_Name_TS278A1",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Utilization Management Organization (UMO) Name",
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
                                    Name = "TS278A1_2000B_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "HL_RequesterLevel_TS278A1",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Requester Level",
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
                                            Name = "TS278A1_2010B_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "NM1_RequesterName_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "NM1",  Min = 1,  Max = 1,  Name = "Requester Name",
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
                                                new Node
                                                {
                                                    Name = "REF_RequesterSupplementalIdentification_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "REF",  Min = 0,  Max = 8,  Name = "Requester Supplemental Identification",
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
                                                    Name = "N3_RequesterAddress_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "N3",  Min = 0,  Max = 1,  Name = "Requester Address",
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
                                                    Name = "N4_RequesterCity_State_ZIPCode_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "N4",  Min = 0,  Max = 1,  Name = "Requester City, State, ZIP Code",
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
                                                    Name = "PER_RequesterContactInformation_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "PER",  Min = 0,  Max = 1,  Name = "Requester Contact Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Contact Function Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_366" },
                                                            new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Communication Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_365" },
                                                            new Element { Name = "Communication Number", IsOptional = true, LengthMin = 1, LengthMax = 256, Type = "string", Value = "null", CodeTable = "null" },
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
                                                    Name = "PRV_RequesterProviderInformation_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "PRV",  Min = 0,  Max = 1,  Name = "Requester Provider Information",
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
                                            Name = "TS278A1_2000C_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "HL_SubscriberLevel_TS278A1",  IsOptional = false,
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
                                                    Name = "TS278A1_2010C_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "NM1_SubscriberName_TS278A1",  IsOptional = false,
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
                                                            Name = "REF_SubscriberSupplementalIdentification_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "REF",  Min = 0,  Max = 9,  Name = "Subscriber Supplemental Identification",
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
                                                            Name = "N3_SubscriberAddress_TS278A1",  IsOptional = false,
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
                                                            Name = "N4_SubscriberCity_State_ZIPCode_TS278A1",  IsOptional = false,
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
                                                            Name = "DMG_SubscriberDemographicInformation_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "DMG",  Min = 0,  Max = 1,  Name = "Subscriber Demographic Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                    new Element { Name = "Date Time Period", IsOptional = false, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
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
                                                            Name = "INS_SubscriberRelationship_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "INS",  Min = 0,  Max = 1,  Name = "Subscriber Relationship",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Individual Relationship Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1069" },
                                                                    new Element { Name = "Maintenance Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_875" },
                                                                    new Element { Name = "Maintenance Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1203" },
                                                                    new Element { Name = "Benefit Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1216" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1219" },
                                                                    new Element { Name = "Employment Status Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_584" },
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
                                                    },
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "TS278A1_2000D_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "HL_DependentLevel_TS278A1",  IsOptional = false,
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
                                                            Name = "TS278A1_2010D_Loop",  IsOptional = false,
                                                            Nodes = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    Name = "NM1_DependentName_TS278A1",  IsOptional = false,
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
                                                                    Name = "REF_DependentSupplementalIdentification_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "REF",  Min = 0,  Max = 3,  Name = "Dependent Supplemental Identification",
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
                                                                    Name = "N3_DependentAddress_TS278A1",  IsOptional = false,
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
                                                                    Name = "N4_DependentCity_State_ZIPCode_TS278A1",  IsOptional = false,
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
                                                                    Name = "DMG_DependentDemographicInformation_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "DMG",  Min = 0,  Max = 1,  Name = "Dependent Demographic Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                            new Element { Name = "Date Time Period", IsOptional = false, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
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
                                                                    Name = "INS_DependentRelationship_TS278A1",  IsOptional = false,
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
                                                            },
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "TS278A1_2000E_Loop",  IsOptional = false,
                                                            Nodes = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    Name = "HL_PatientEventLevel_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HL",  Min = 1,  Max = 1,  Name = "Patient Event Level",
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
                                                                    Name = "TRN_PatientEventTrackingNumber_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "TRN",  Min = 0,  Max = 2,  Name = "Patient Event Tracking Number",
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
                                                                    Name = "UM_HealthCareServicesReviewInformation_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "UM",  Min = 1,  Max = 1,  Name = "Health Care Services Review Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Request Category Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                                            new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                            new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                                            new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                                            new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                            new Element { Name = "Release of Information Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                                            new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                                        }
                                                                    } // end of "UM"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "REF_SubLoop_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                    }
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "DTP_SubLoop_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                    }
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "HI_PatientDiagnosis_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HI",  Min = 0,  Max = 1,  Name = "Patient Diagnosis",
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
                                                                    Name = "HSD_HealthCareServicesDelivery_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HSD",  Min = 0,  Max = 1,  Name = "Health Care Services Delivery",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Quantity Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Sample Selection Modulus", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Time Period Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_615" },
                                                                            new Element { Name = "Number of Periods", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "int", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Ship/Delivery or Calendar Pattern Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_678" },
                                                                            new Element { Name = "Ship/Delivery Pattern Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_679" },
                                                                        }
                                                                    } // end of "HSD"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "CRC_SubLoop_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                    }
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "CL1_InstitutionalClaimCode_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "CL1",  Min = 0,  Max = 1,  Name = "Institutional Claim Code",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Admission Type Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11315" },
                                                                            new Element { Name = "Admission Source Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11314" },
                                                                            new Element { Name = "Patient Status Code", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_11352" },
                                                                            new Element { Name = "Nursing Home Residential Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1345" },
                                                                        }
                                                                    } // end of "CL1"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "CR1_AmbulanceTransportInformation_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "CR1",  Min = 0,  Max = 1,  Name = "Ambulance Transport Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Weight", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Ambulance Transport Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1316" },
                                                                            new Element { Name = "Ambulance Transport Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1317" },
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
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
                                                                    Name = "CR2_SpinalManipulationServiceInformation_TS278A1",  IsOptional = false,
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
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                        }
                                                                    } // end of "CR2"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "CR5_HomeOxygenTherapyInformation_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "CR5",  Min = 0,  Max = 1,  Name = "Home Oxygen Therapy Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Certification Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Oxygen Equipment Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                            new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Oxygen Test Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1349" },
                                                                            new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                            new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                            new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Oxygen Delivery System Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1382" },
                                                                            new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                        }
                                                                    } // end of "CR5"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "CR6_HomeHealthCareInformation_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "CR6",  Min = 0,  Max = 1,  Name = "Home Health Care Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Prognosis Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                            new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                            new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                            new Element { Name = "Medical Code Value", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                            new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Patient Location Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1384" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "CR6"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "PWK_AdditionalPatientInformation_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "PWK",  Min = 0,  Max = 10,  Name = "Additional Patient Information",
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
                                                                    Name = "MSG_MessageText_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "MSG",  Min = 0,  Max = 1,  Name = "Message Text",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Free-form Message Text", IsOptional = false, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Printer Carriage Control Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_934" },
                                                                            new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "MSG"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "NM1_SubLoop_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                    }
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "TS278A1_2000F_Loop",  IsOptional = false,
                                                                    Nodes = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            Name = "HL_ServiceLevel_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Service Level",
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
                                                                            Name = "TRN_ServiceTraceNumber_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "TRN",  Min = 0,  Max = 2,  Name = "Service Trace Number",
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
                                                                            Name = "UM_HealthCareServicesReviewInformation_2_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "UM",  Min = 0,  Max = 1,  Name = "Health Care Services Review Information",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "Request Category Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                                                    new Element { Name = "Certification Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                                    new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                                                    new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                                                    new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                                    new Element { Name = "Release of Information Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                                                    new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                                                }
                                                                            } // end of "UM"
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "REF_SubLoop_2_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                            }
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "DTP_ServiceDate_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "DTP",  Min = 0,  Max = 1,  Name = "Service Date",
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
                                                                            Name = "SV1_ProfessionalService_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "SV1",  Min = 0,  Max = 1,  Name = "Professional Service",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
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
                                                                            Name = "SV2_InstitutionalServiceLine_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "SV2",  Min = 0,  Max = 1,  Name = "Institutional Service Line",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Unit Rate", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                                    new Element { Name = "Nursing Home Residential Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1345" },
                                                                                    new Element { Name = "Level of Care Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1337" },
                                                                                }
                                                                            } // end of "SV2"
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "SV3_DentalService_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "SV3",  Min = 0,  Max = 1,  Name = "Dental Service",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Prosthesis, Crown or Inlay Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1358" },
                                                                                    new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Copay Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1327" },
                                                                                    new Element { Name = "Provider Agreement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1360" },
                                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                }
                                                                            } // end of "SV3"
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "TOO_ToothInformation_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "TOO",  Min = 0,  Max = 32,  Name = "Tooth Information",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "Code List Qualifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1270" },
                                                                                    new Element { Name = "Industry Code", IsOptional = false, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                }
                                                                            } // end of "TOO"
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "HSD_HealthCareServicesDelivery_2_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "HSD",  Min = 0,  Max = 1,  Name = "Health Care Services Delivery",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "Quantity Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                                    new Element { Name = "Sample Selection Modulus", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Time Period Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_615" },
                                                                                    new Element { Name = "Number of Periods", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "int", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Ship/Delivery or Calendar Pattern Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_678" },
                                                                                    new Element { Name = "Ship/Delivery Pattern Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_679" },
                                                                                }
                                                                            } // end of "HSD"
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "PWK_AdditionalServiceInformation_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "PWK",  Min = 0,  Max = 10,  Name = "Additional Service Information",
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
                                                                            Name = "MSG_MessageText_2_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "MSG",  Min = 0,  Max = 1,  Name = "Message Text",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "Free-form Message Text", IsOptional = false, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Printer Carriage Control Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_934" },
                                                                                    new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                                                }
                                                                            } // end of "MSG"
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "TS278A1_2010F_Loop",  IsOptional = false,
                                                                            Nodes = new Node[]
                                                                            {
                                                                                new Node
                                                                                {
                                                                                    Name = "NM1_ServiceProviderName_TS278A1",  IsOptional = false,
                                                                                    Segment = new Segment
                                                                                    {
                                                                                        Tag = "NM1",  Min = 1,  Max = 1,  Name = "Service Provider Name",
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
                                                                                    Name = "REF_ServiceProviderSupplementalIdentification_TS278A1",  IsOptional = false,
                                                                                    Segment = new Segment
                                                                                    {
                                                                                        Tag = "REF",  Min = 0,  Max = 8,  Name = "Service Provider Supplemental Identification",
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
                                                                                    Name = "N3_ServiceProviderAddress_TS278A1",  IsOptional = false,
                                                                                    Segment = new Segment
                                                                                    {
                                                                                        Tag = "N3",  Min = 0,  Max = 1,  Name = "Service Provider Address",
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
                                                                                    Name = "N4_ServiceProviderCity_State_ZIPCode_TS278A1",  IsOptional = false,
                                                                                    Segment = new Segment
                                                                                    {
                                                                                        Tag = "N4",  Min = 0,  Max = 1,  Name = "Service Provider City, State, ZIP Code",
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
                                                                                    Name = "PER_ServiceProviderContactInformation_TS278A1",  IsOptional = false,
                                                                                    Segment = new Segment
                                                                                    {
                                                                                        Tag = "PER",  Min = 0,  Max = 1,  Name = "Service Provider Contact Information",
                                                                                        Elements = new[]
                                                                                        {
                                                                                            new Element { Name = "Contact Function Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_366" },
                                                                                            new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                                                            new Element { Name = "Communication Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_365" },
                                                                                            new Element { Name = "Communication Number", IsOptional = true, LengthMin = 1, LengthMax = 256, Type = "string", Value = "null", CodeTable = "null" },
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
                                                                                    Name = "PRV_ServiceProviderInformation_TS278A1",  IsOptional = false,
                                                                                    Segment = new Segment
                                                                                    {
                                                                                        Tag = "PRV",  Min = 0,  Max = 1,  Name = "Service Provider Information",
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
                                                    Name = "TS278A1_2000E_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "HL_PatientEventLevel_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Patient Event Level",
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
                                                            Name = "TRN_PatientEventTrackingNumber_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "TRN",  Min = 0,  Max = 2,  Name = "Patient Event Tracking Number",
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
                                                            Name = "UM_HealthCareServicesReviewInformation_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "UM",  Min = 1,  Max = 1,  Name = "Health Care Services Review Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Request Category Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                                    new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                    new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                                    new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                                    new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                    new Element { Name = "Release of Information Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                                    new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                                }
                                                            } // end of "UM"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "REF_SubLoop_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "DTP_SubLoop_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "HI_PatientDiagnosis_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HI",  Min = 0,  Max = 1,  Name = "Patient Diagnosis",
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
                                                            Name = "HSD_HealthCareServicesDelivery_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HSD",  Min = 0,  Max = 1,  Name = "Health Care Services Delivery",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Quantity Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Sample Selection Modulus", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Time Period Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_615" },
                                                                    new Element { Name = "Number of Periods", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "int", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Ship/Delivery or Calendar Pattern Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_678" },
                                                                    new Element { Name = "Ship/Delivery Pattern Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_679" },
                                                                }
                                                            } // end of "HSD"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CRC_SubLoop_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CL1_InstitutionalClaimCode_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CL1",  Min = 0,  Max = 1,  Name = "Institutional Claim Code",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Admission Type Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11315" },
                                                                    new Element { Name = "Admission Source Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11314" },
                                                                    new Element { Name = "Patient Status Code", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_11352" },
                                                                    new Element { Name = "Nursing Home Residential Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1345" },
                                                                }
                                                            } // end of "CL1"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CR1_AmbulanceTransportInformation_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CR1",  Min = 0,  Max = 1,  Name = "Ambulance Transport Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Weight", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Ambulance Transport Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1316" },
                                                                    new Element { Name = "Ambulance Transport Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1317" },
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
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
                                                            Name = "CR2_SpinalManipulationServiceInformation_TS278A1",  IsOptional = false,
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
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                }
                                                            } // end of "CR2"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CR5_HomeOxygenTherapyInformation_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CR5",  Min = 0,  Max = 1,  Name = "Home Oxygen Therapy Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Certification Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Oxygen Equipment Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                    new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Oxygen Test Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1349" },
                                                                    new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                    new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                    new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Oxygen Delivery System Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1382" },
                                                                    new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                }
                                                            } // end of "CR5"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CR6_HomeHealthCareInformation_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CR6",  Min = 0,  Max = 1,  Name = "Home Health Care Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Prognosis Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                    new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                    new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Medical Code Value", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                    new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Patient Location Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1384" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "CR6"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "PWK_AdditionalPatientInformation_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "PWK",  Min = 0,  Max = 10,  Name = "Additional Patient Information",
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
                                                            Name = "MSG_MessageText_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "MSG",  Min = 0,  Max = 1,  Name = "Message Text",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Free-form Message Text", IsOptional = false, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Printer Carriage Control Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_934" },
                                                                    new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "MSG"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "NM1_SubLoop_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "TS278A1_2000F_Loop",  IsOptional = false,
                                                            Nodes = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    Name = "HL_ServiceLevel_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HL",  Min = 1,  Max = 1,  Name = "Service Level",
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
                                                                    Name = "TRN_ServiceTraceNumber_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "TRN",  Min = 0,  Max = 2,  Name = "Service Trace Number",
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
                                                                    Name = "UM_HealthCareServicesReviewInformation_2_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "UM",  Min = 0,  Max = 1,  Name = "Health Care Services Review Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Request Category Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                                            new Element { Name = "Certification Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                            new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                                            new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                                            new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                            new Element { Name = "Release of Information Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                                            new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                                        }
                                                                    } // end of "UM"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "REF_SubLoop_2_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                    }
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "DTP_ServiceDate_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Service Date",
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
                                                                    Name = "SV1_ProfessionalService_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "SV1",  Min = 0,  Max = 1,  Name = "Professional Service",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
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
                                                                    Name = "SV2_InstitutionalServiceLine_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "SV2",  Min = 0,  Max = 1,  Name = "Institutional Service Line",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit Rate", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "Nursing Home Residential Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1345" },
                                                                            new Element { Name = "Level of Care Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1337" },
                                                                        }
                                                                    } // end of "SV2"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "SV3_DentalService_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "SV3",  Min = 0,  Max = 1,  Name = "Dental Service",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Prosthesis, Crown or Inlay Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1358" },
                                                                            new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Copay Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1327" },
                                                                            new Element { Name = "Provider Agreement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1360" },
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "SV3"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "TOO_ToothInformation_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "TOO",  Min = 0,  Max = 32,  Name = "Tooth Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Code List Qualifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1270" },
                                                                            new Element { Name = "Industry Code", IsOptional = false, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "TOO"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "HSD_HealthCareServicesDelivery_2_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HSD",  Min = 0,  Max = 1,  Name = "Health Care Services Delivery",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Quantity Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Sample Selection Modulus", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Time Period Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_615" },
                                                                            new Element { Name = "Number of Periods", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "int", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Ship/Delivery or Calendar Pattern Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_678" },
                                                                            new Element { Name = "Ship/Delivery Pattern Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_679" },
                                                                        }
                                                                    } // end of "HSD"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "PWK_AdditionalServiceInformation_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "PWK",  Min = 0,  Max = 10,  Name = "Additional Service Information",
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
                                                                    Name = "MSG_MessageText_2_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "MSG",  Min = 0,  Max = 1,  Name = "Message Text",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Free-form Message Text", IsOptional = false, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Printer Carriage Control Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_934" },
                                                                            new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "MSG"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "TS278A1_2010F_Loop",  IsOptional = false,
                                                                    Nodes = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            Name = "NM1_ServiceProviderName_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Service Provider Name",
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
                                                                            Name = "REF_ServiceProviderSupplementalIdentification_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "REF",  Min = 0,  Max = 8,  Name = "Service Provider Supplemental Identification",
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
                                                                            Name = "N3_ServiceProviderAddress_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "N3",  Min = 0,  Max = 1,  Name = "Service Provider Address",
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
                                                                            Name = "N4_ServiceProviderCity_State_ZIPCode_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "N4",  Min = 0,  Max = 1,  Name = "Service Provider City, State, ZIP Code",
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
                                                                            Name = "PER_ServiceProviderContactInformation_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "PER",  Min = 0,  Max = 1,  Name = "Service Provider Contact Information",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "Contact Function Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_366" },
                                                                                    new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Communication Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_365" },
                                                                                    new Element { Name = "Communication Number", IsOptional = true, LengthMin = 1, LengthMax = 256, Type = "string", Value = "null", CodeTable = "null" },
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
                                                                            Name = "PRV_ServiceProviderInformation_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "PRV",  Min = 0,  Max = 1,  Name = "Service Provider Information",
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
                    Name = "BHT_BeginningofHierarchicalTransaction_TS278A1",  IsOptional = false,
                    Segment = new Segment
                    {
                        Tag = "BHT",  Min = 0,  Max = 1,  Name = "Beginning of Hierarchical Transaction",
                        Elements = new[]
                        {
                            new Element { Name = "Hierarchical Structure Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1005" },
                            new Element { Name = "Transaction Set Purpose Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_353" },
                            new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                            new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                            new Element { Name = "Time", IsOptional = false, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                            new Element { Name = "Transaction Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_640" },
                        }
                    } // end of "BHT"
                }
                ,
                new Node
                {
                    Name = "TS278A1_2000A_Loop",  IsOptional = false,
                    Nodes = new Node[]
                    {
                        new Node
                        {
                            Name = "HL_UtilizationManagementOrganization_UMO_Level_TS278A1",  IsOptional = false,
                            Segment = new Segment
                            {
                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Utilization Management Organization (UMO) Level",
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
                            Name = "TS278A1_2010A_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "NM1_UtilizationManagementOrganization_UMO_Name_TS278A1",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "NM1",  Min = 1,  Max = 1,  Name = "Utilization Management Organization (UMO) Name",
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
                            Name = "TS278A1_2000B_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "HL_RequesterLevel_TS278A1",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "HL",  Min = 1,  Max = 1,  Name = "Requester Level",
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
                                    Name = "TS278A1_2010B_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "NM1_RequesterName_TS278A1",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Requester Name",
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
                                        new Node
                                        {
                                            Name = "REF_RequesterSupplementalIdentification_TS278A1",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "REF",  Min = 0,  Max = 8,  Name = "Requester Supplemental Identification",
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
                                            Name = "N3_RequesterAddress_TS278A1",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N3",  Min = 0,  Max = 1,  Name = "Requester Address",
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
                                            Name = "N4_RequesterCity_State_ZIPCode_TS278A1",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "N4",  Min = 0,  Max = 1,  Name = "Requester City, State, ZIP Code",
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
                                            Name = "PER_RequesterContactInformation_TS278A1",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "PER",  Min = 0,  Max = 1,  Name = "Requester Contact Information",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Contact Function Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_366" },
                                                    new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Communication Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_365" },
                                                    new Element { Name = "Communication Number", IsOptional = true, LengthMin = 1, LengthMax = 256, Type = "string", Value = "null", CodeTable = "null" },
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
                                            Name = "PRV_RequesterProviderInformation_TS278A1",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "PRV",  Min = 0,  Max = 1,  Name = "Requester Provider Information",
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
                                    Name = "TS278A1_2000C_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "HL_SubscriberLevel_TS278A1",  IsOptional = false,
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
                                            Name = "TS278A1_2010C_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "NM1_SubscriberName_TS278A1",  IsOptional = false,
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
                                                    Name = "REF_SubscriberSupplementalIdentification_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "REF",  Min = 0,  Max = 9,  Name = "Subscriber Supplemental Identification",
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
                                                    Name = "N3_SubscriberAddress_TS278A1",  IsOptional = false,
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
                                                    Name = "N4_SubscriberCity_State_ZIPCode_TS278A1",  IsOptional = false,
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
                                                    Name = "DMG_SubscriberDemographicInformation_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DMG",  Min = 0,  Max = 1,  Name = "Subscriber Demographic Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                            new Element { Name = "Date Time Period", IsOptional = false, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
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
                                                    Name = "INS_SubscriberRelationship_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "INS",  Min = 0,  Max = 1,  Name = "Subscriber Relationship",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Individual Relationship Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1069" },
                                                            new Element { Name = "Maintenance Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_875" },
                                                            new Element { Name = "Maintenance Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1203" },
                                                            new Element { Name = "Benefit Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1216" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1219" },
                                                            new Element { Name = "Employment Status Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_584" },
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
                                            },
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "TS278A1_2000D_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "HL_DependentLevel_TS278A1",  IsOptional = false,
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
                                                    Name = "TS278A1_2010D_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "NM1_DependentName_TS278A1",  IsOptional = false,
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
                                                            Name = "REF_DependentSupplementalIdentification_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "REF",  Min = 0,  Max = 3,  Name = "Dependent Supplemental Identification",
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
                                                            Name = "N3_DependentAddress_TS278A1",  IsOptional = false,
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
                                                            Name = "N4_DependentCity_State_ZIPCode_TS278A1",  IsOptional = false,
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
                                                            Name = "DMG_DependentDemographicInformation_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "DMG",  Min = 0,  Max = 1,  Name = "Dependent Demographic Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                    new Element { Name = "Date Time Period", IsOptional = false, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
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
                                                            Name = "INS_DependentRelationship_TS278A1",  IsOptional = false,
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
                                                    },
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "TS278A1_2000E_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "HL_PatientEventLevel_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Patient Event Level",
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
                                                            Name = "TRN_PatientEventTrackingNumber_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "TRN",  Min = 0,  Max = 2,  Name = "Patient Event Tracking Number",
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
                                                            Name = "UM_HealthCareServicesReviewInformation_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "UM",  Min = 1,  Max = 1,  Name = "Health Care Services Review Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Request Category Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                                    new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                    new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                                    new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                                    new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                    new Element { Name = "Release of Information Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                                    new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                                }
                                                            } // end of "UM"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "REF_SubLoop_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "DTP_SubLoop_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "HI_PatientDiagnosis_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HI",  Min = 0,  Max = 1,  Name = "Patient Diagnosis",
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
                                                            Name = "HSD_HealthCareServicesDelivery_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HSD",  Min = 0,  Max = 1,  Name = "Health Care Services Delivery",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Quantity Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Sample Selection Modulus", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Time Period Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_615" },
                                                                    new Element { Name = "Number of Periods", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "int", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Ship/Delivery or Calendar Pattern Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_678" },
                                                                    new Element { Name = "Ship/Delivery Pattern Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_679" },
                                                                }
                                                            } // end of "HSD"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CRC_SubLoop_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CL1_InstitutionalClaimCode_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CL1",  Min = 0,  Max = 1,  Name = "Institutional Claim Code",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Admission Type Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11315" },
                                                                    new Element { Name = "Admission Source Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11314" },
                                                                    new Element { Name = "Patient Status Code", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_11352" },
                                                                    new Element { Name = "Nursing Home Residential Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1345" },
                                                                }
                                                            } // end of "CL1"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CR1_AmbulanceTransportInformation_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CR1",  Min = 0,  Max = 1,  Name = "Ambulance Transport Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Weight", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Ambulance Transport Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1316" },
                                                                    new Element { Name = "Ambulance Transport Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1317" },
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
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
                                                            Name = "CR2_SpinalManipulationServiceInformation_TS278A1",  IsOptional = false,
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
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                }
                                                            } // end of "CR2"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CR5_HomeOxygenTherapyInformation_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CR5",  Min = 0,  Max = 1,  Name = "Home Oxygen Therapy Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Certification Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Oxygen Equipment Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                    new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Oxygen Test Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1349" },
                                                                    new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                    new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                    new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Oxygen Delivery System Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1382" },
                                                                    new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                }
                                                            } // end of "CR5"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CR6_HomeHealthCareInformation_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CR6",  Min = 0,  Max = 1,  Name = "Home Health Care Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Prognosis Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                    new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                    new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Medical Code Value", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                    new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Patient Location Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1384" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "CR6"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "PWK_AdditionalPatientInformation_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "PWK",  Min = 0,  Max = 10,  Name = "Additional Patient Information",
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
                                                            Name = "MSG_MessageText_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "MSG",  Min = 0,  Max = 1,  Name = "Message Text",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Free-form Message Text", IsOptional = false, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Printer Carriage Control Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_934" },
                                                                    new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "MSG"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "NM1_SubLoop_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "TS278A1_2000F_Loop",  IsOptional = false,
                                                            Nodes = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    Name = "HL_ServiceLevel_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HL",  Min = 1,  Max = 1,  Name = "Service Level",
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
                                                                    Name = "TRN_ServiceTraceNumber_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "TRN",  Min = 0,  Max = 2,  Name = "Service Trace Number",
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
                                                                    Name = "UM_HealthCareServicesReviewInformation_2_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "UM",  Min = 0,  Max = 1,  Name = "Health Care Services Review Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Request Category Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                                            new Element { Name = "Certification Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                            new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                                            new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                                            new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                            new Element { Name = "Release of Information Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                                            new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                                        }
                                                                    } // end of "UM"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "REF_SubLoop_2_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                    }
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "DTP_ServiceDate_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "DTP",  Min = 0,  Max = 1,  Name = "Service Date",
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
                                                                    Name = "SV1_ProfessionalService_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "SV1",  Min = 0,  Max = 1,  Name = "Professional Service",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
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
                                                                    Name = "SV2_InstitutionalServiceLine_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "SV2",  Min = 0,  Max = 1,  Name = "Institutional Service Line",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit Rate", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "Nursing Home Residential Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1345" },
                                                                            new Element { Name = "Level of Care Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1337" },
                                                                        }
                                                                    } // end of "SV2"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "SV3_DentalService_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "SV3",  Min = 0,  Max = 1,  Name = "Dental Service",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Prosthesis, Crown or Inlay Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1358" },
                                                                            new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Copay Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1327" },
                                                                            new Element { Name = "Provider Agreement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1360" },
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "SV3"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "TOO_ToothInformation_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "TOO",  Min = 0,  Max = 32,  Name = "Tooth Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Code List Qualifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1270" },
                                                                            new Element { Name = "Industry Code", IsOptional = false, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "TOO"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "HSD_HealthCareServicesDelivery_2_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HSD",  Min = 0,  Max = 1,  Name = "Health Care Services Delivery",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Quantity Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Sample Selection Modulus", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Time Period Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_615" },
                                                                            new Element { Name = "Number of Periods", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "int", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Ship/Delivery or Calendar Pattern Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_678" },
                                                                            new Element { Name = "Ship/Delivery Pattern Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_679" },
                                                                        }
                                                                    } // end of "HSD"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "PWK_AdditionalServiceInformation_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "PWK",  Min = 0,  Max = 10,  Name = "Additional Service Information",
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
                                                                    Name = "MSG_MessageText_2_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "MSG",  Min = 0,  Max = 1,  Name = "Message Text",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Free-form Message Text", IsOptional = false, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Printer Carriage Control Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_934" },
                                                                            new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "MSG"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "TS278A1_2010F_Loop",  IsOptional = false,
                                                                    Nodes = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            Name = "NM1_ServiceProviderName_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Service Provider Name",
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
                                                                            Name = "REF_ServiceProviderSupplementalIdentification_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "REF",  Min = 0,  Max = 8,  Name = "Service Provider Supplemental Identification",
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
                                                                            Name = "N3_ServiceProviderAddress_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "N3",  Min = 0,  Max = 1,  Name = "Service Provider Address",
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
                                                                            Name = "N4_ServiceProviderCity_State_ZIPCode_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "N4",  Min = 0,  Max = 1,  Name = "Service Provider City, State, ZIP Code",
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
                                                                            Name = "PER_ServiceProviderContactInformation_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "PER",  Min = 0,  Max = 1,  Name = "Service Provider Contact Information",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "Contact Function Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_366" },
                                                                                    new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Communication Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_365" },
                                                                                    new Element { Name = "Communication Number", IsOptional = true, LengthMin = 1, LengthMax = 256, Type = "string", Value = "null", CodeTable = "null" },
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
                                                                            Name = "PRV_ServiceProviderInformation_TS278A1",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "PRV",  Min = 0,  Max = 1,  Name = "Service Provider Information",
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
                                            Name = "TS278A1_2000E_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "HL_PatientEventLevel_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "HL",  Min = 1,  Max = 1,  Name = "Patient Event Level",
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
                                                    Name = "TRN_PatientEventTrackingNumber_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "TRN",  Min = 0,  Max = 2,  Name = "Patient Event Tracking Number",
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
                                                    Name = "UM_HealthCareServicesReviewInformation_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "UM",  Min = 1,  Max = 1,  Name = "Health Care Services Review Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Request Category Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                            new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                            new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                            new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                            new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                            new Element { Name = "Release of Information Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                            new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                        }
                                                    } // end of "UM"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "REF_SubLoop_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                    }
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "DTP_SubLoop_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                    }
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "HI_PatientDiagnosis_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "HI",  Min = 0,  Max = 1,  Name = "Patient Diagnosis",
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
                                                    Name = "HSD_HealthCareServicesDelivery_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "HSD",  Min = 0,  Max = 1,  Name = "Health Care Services Delivery",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Quantity Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                            new Element { Name = "Sample Selection Modulus", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Time Period Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_615" },
                                                            new Element { Name = "Number of Periods", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "int", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Ship/Delivery or Calendar Pattern Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_678" },
                                                            new Element { Name = "Ship/Delivery Pattern Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_679" },
                                                        }
                                                    } // end of "HSD"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "CRC_SubLoop_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                    }
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "CL1_InstitutionalClaimCode_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "CL1",  Min = 0,  Max = 1,  Name = "Institutional Claim Code",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Admission Type Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11315" },
                                                            new Element { Name = "Admission Source Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11314" },
                                                            new Element { Name = "Patient Status Code", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_11352" },
                                                            new Element { Name = "Nursing Home Residential Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1345" },
                                                        }
                                                    } // end of "CL1"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "CR1_AmbulanceTransportInformation_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "CR1",  Min = 0,  Max = 1,  Name = "Ambulance Transport Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                            new Element { Name = "Weight", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Ambulance Transport Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1316" },
                                                            new Element { Name = "Ambulance Transport Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1317" },
                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
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
                                                    Name = "CR2_SpinalManipulationServiceInformation_TS278A1",  IsOptional = false,
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
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                        }
                                                    } // end of "CR2"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "CR5_HomeOxygenTherapyInformation_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "CR5",  Min = 0,  Max = 1,  Name = "Home Oxygen Therapy Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Certification Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Oxygen Equipment Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                            new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Oxygen Test Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1349" },
                                                            new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                            new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                            new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Oxygen Delivery System Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1382" },
                                                            new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                        }
                                                    } // end of "CR5"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "CR6_HomeHealthCareInformation_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "CR6",  Min = 0,  Max = 1,  Name = "Home Health Care Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Prognosis Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                            new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                            new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                            new Element { Name = "Medical Code Value", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                            new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Patient Location Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1384" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "CR6"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "PWK_AdditionalPatientInformation_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "PWK",  Min = 0,  Max = 10,  Name = "Additional Patient Information",
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
                                                    Name = "MSG_MessageText_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "MSG",  Min = 0,  Max = 1,  Name = "Message Text",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Free-form Message Text", IsOptional = false, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Printer Carriage Control Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_934" },
                                                            new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "MSG"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "NM1_SubLoop_TS278A1",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                    }
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "TS278A1_2000F_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "HL_ServiceLevel_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Service Level",
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
                                                            Name = "TRN_ServiceTraceNumber_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "TRN",  Min = 0,  Max = 2,  Name = "Service Trace Number",
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
                                                            Name = "UM_HealthCareServicesReviewInformation_2_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "UM",  Min = 0,  Max = 1,  Name = "Health Care Services Review Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Request Category Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                                    new Element { Name = "Certification Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                    new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                                    new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                                    new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                    new Element { Name = "Release of Information Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                                    new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                                }
                                                            } // end of "UM"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "REF_SubLoop_2_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "DTP_ServiceDate_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "DTP",  Min = 0,  Max = 1,  Name = "Service Date",
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
                                                            Name = "SV1_ProfessionalService_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "SV1",  Min = 0,  Max = 1,  Name = "Professional Service",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
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
                                                            Name = "SV2_InstitutionalServiceLine_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "SV2",  Min = 0,  Max = 1,  Name = "Institutional Service Line",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Unit Rate", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Nursing Home Residential Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1345" },
                                                                    new Element { Name = "Level of Care Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1337" },
                                                                }
                                                            } // end of "SV2"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "SV3_DentalService_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "SV3",  Min = 0,  Max = 1,  Name = "Dental Service",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Prosthesis, Crown or Inlay Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1358" },
                                                                    new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Copay Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1327" },
                                                                    new Element { Name = "Provider Agreement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1360" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "SV3"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "TOO_ToothInformation_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "TOO",  Min = 0,  Max = 32,  Name = "Tooth Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Code List Qualifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1270" },
                                                                    new Element { Name = "Industry Code", IsOptional = false, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "TOO"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "HSD_HealthCareServicesDelivery_2_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HSD",  Min = 0,  Max = 1,  Name = "Health Care Services Delivery",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Quantity Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Sample Selection Modulus", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Time Period Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_615" },
                                                                    new Element { Name = "Number of Periods", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "int", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Ship/Delivery or Calendar Pattern Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_678" },
                                                                    new Element { Name = "Ship/Delivery Pattern Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_679" },
                                                                }
                                                            } // end of "HSD"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "PWK_AdditionalServiceInformation_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "PWK",  Min = 0,  Max = 10,  Name = "Additional Service Information",
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
                                                            Name = "MSG_MessageText_2_TS278A1",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "MSG",  Min = 0,  Max = 1,  Name = "Message Text",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Free-form Message Text", IsOptional = false, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Printer Carriage Control Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_934" },
                                                                    new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "MSG"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "TS278A1_2010F_Loop",  IsOptional = false,
                                                            Nodes = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    Name = "NM1_ServiceProviderName_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "NM1",  Min = 1,  Max = 1,  Name = "Service Provider Name",
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
                                                                    Name = "REF_ServiceProviderSupplementalIdentification_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "REF",  Min = 0,  Max = 8,  Name = "Service Provider Supplemental Identification",
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
                                                                    Name = "N3_ServiceProviderAddress_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "N3",  Min = 0,  Max = 1,  Name = "Service Provider Address",
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
                                                                    Name = "N4_ServiceProviderCity_State_ZIPCode_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "N4",  Min = 0,  Max = 1,  Name = "Service Provider City, State, ZIP Code",
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
                                                                    Name = "PER_ServiceProviderContactInformation_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "PER",  Min = 0,  Max = 1,  Name = "Service Provider Contact Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Contact Function Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_366" },
                                                                            new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Communication Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_365" },
                                                                            new Element { Name = "Communication Number", IsOptional = true, LengthMin = 1, LengthMax = 256, Type = "string", Value = "null", CodeTable = "null" },
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
                                                                    Name = "PRV_ServiceProviderInformation_TS278A1",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "PRV",  Min = 0,  Max = 1,  Name = "Service Provider Information",
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
                    Name = "A3_BHT_Loop",  IsOptional = false,
                    Nodes = new Node[]
                    {
                        new Node
                        {
                            Name = "BHT_BeginningofHierarchicalTransaction_TS278A3",  IsOptional = false,
                            Segment = new Segment
                            {
                                Tag = "BHT",  Min = 0,  Max = 1,  Name = "Beginning of Hierarchical Transaction",
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
                            Name = "TS278A3_2000A_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "HL_UtilizationManagementOrganization_UMO_Level_TS278A3",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "HL",  Min = 1,  Max = 1,  Name = "Utilization Management Organization (UMO) Level",
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
                                    Name = "AAA_RequestValidation_TS278A3",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "AAA",  Min = 0,  Max = 9,  Name = "Request Validation",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                            new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                            new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                            new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                        }
                                    } // end of "AAA"
                                }
                                ,
                                new Node
                                {
                                    Name = "TS278A3_2010A_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "NM1_UtilizationManagementOrganization_UMO_Name_TS278A3",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Utilization Management Organization (UMO) Name",
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
                                        new Node
                                        {
                                            Name = "PER_UtilizationManagementOrganization_UMO_ContactInformation_TS278A3",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "PER",  Min = 0,  Max = 1,  Name = "Utilization Management Organization (UMO) Contact Information",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Contact Function Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_366" },
                                                    new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Communication Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_365" },
                                                    new Element { Name = "Communication Number", IsOptional = true, LengthMin = 1, LengthMax = 256, Type = "string", Value = "null", CodeTable = "null" },
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
                                            Name = "AAA_UtilizationManagementOrganization_UMO_RequestValidation_TS278A3",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "AAA",  Min = 0,  Max = 9,  Name = "Utilization Management Organization (UMO) Request Validation",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                    new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                                    new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                    new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                                }
                                            } // end of "AAA"
                                        }
                                        ,
                                    },
                                }
                                ,
                                new Node
                                {
                                    Name = "TS278A3_2000B_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "HL_RequesterLevel_TS278A3",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Requester Level",
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
                                            Name = "TS278A3_2010B_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "NM1_RequesterName_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "NM1",  Min = 1,  Max = 1,  Name = "Requester Name",
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
                                                new Node
                                                {
                                                    Name = "REF_RequesterSupplementalIdentification_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "REF",  Min = 0,  Max = 8,  Name = "Requester Supplemental Identification",
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
                                                    Name = "AAA_RequesterRequestValidation_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "AAA",  Min = 0,  Max = 9,  Name = "Requester Request Validation",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                                            new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                            new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                                        }
                                                    } // end of "AAA"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "PRV_RequesterProviderInformation_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "PRV",  Min = 0,  Max = 1,  Name = "Requester Provider Information",
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
                                            Name = "TS278A3_2000C_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "HL_SubscriberLevel_TS278A3",  IsOptional = false,
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
                                                    Name = "TS278A3_2010C_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "NM1_SubscriberName_TS278A3",  IsOptional = false,
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
                                                            Name = "REF_SubscriberSupplementalIdentification_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "REF",  Min = 0,  Max = 9,  Name = "Subscriber Supplemental Identification",
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
                                                            Name = "N3_SubscriberMailingAddress_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "N3",  Min = 0,  Max = 1,  Name = "Subscriber Mailing Address",
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
                                                            Name = "N4_SubscriberCity_State_ZIPCode_TS278A3",  IsOptional = false,
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
                                                            Name = "AAA_SubscriberRequestValidation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "AAA",  Min = 0,  Max = 9,  Name = "Subscriber Request Validation",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                                                    new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                                    new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                                                }
                                                            } // end of "AAA"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "DMG_SubscriberDemographicInformation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "DMG",  Min = 0,  Max = 1,  Name = "Subscriber Demographic Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                    new Element { Name = "Date Time Period", IsOptional = false, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
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
                                                            Name = "INS_SubscriberRelationship_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "INS",  Min = 0,  Max = 1,  Name = "Subscriber Relationship",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Individual Relationship Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1069" },
                                                                    new Element { Name = "Maintenance Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_875" },
                                                                    new Element { Name = "Maintenance Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1203" },
                                                                    new Element { Name = "Benefit Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1216" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1219" },
                                                                    new Element { Name = "Employment Status Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_584" },
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
                                                    },
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "TS278A3_2000E_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "HL_PatientEventLevel_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Patient Event Level",
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
                                                            Name = "TRN_PatientEventTrackingNumber_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "TRN",  Min = 0,  Max = 3,  Name = "Patient Event Tracking Number",
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
                                                            Name = "AAA_PatientEventRequestValidation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "AAA",  Min = 0,  Max = 9,  Name = "Patient Event Request Validation",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                                                    new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                                    new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                                                }
                                                            } // end of "AAA"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "UM_HealthCareServicesReviewInformation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "UM",  Min = 1,  Max = 1,  Name = "Health Care Services Review Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Request Category Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                                    new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                    new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                                    new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                                    new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                    new Element { Name = "Release of Information Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                                    new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                                }
                                                            } // end of "UM"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "HCR_HealthCareServicesReview_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HCR",  Min = 0,  Max = 1,  Name = "Health Care Services Review",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Industry Code", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                }
                                                            } // end of "HCR"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "REF_SubLoop_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "DTP_SubLoop_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "HI_PatientDiagnosis_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HI",  Min = 0,  Max = 1,  Name = "Patient Diagnosis",
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
                                                            Name = "HSD_HealthCareServicesDelivery_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HSD",  Min = 0,  Max = 1,  Name = "Health Care Services Delivery",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Quantity Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Sample Selection Modulus", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Time Period Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_615" },
                                                                    new Element { Name = "Number of Periods", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "int", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Ship/Delivery or Calendar Pattern Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_678" },
                                                                    new Element { Name = "Ship/Delivery Pattern Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_679" },
                                                                }
                                                            } // end of "HSD"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CL1_InstitutionalClaimCode_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CL1",  Min = 0,  Max = 1,  Name = "Institutional Claim Code",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Admission Type Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11315" },
                                                                    new Element { Name = "Admission Source Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11314" },
                                                                    new Element { Name = "Patient Status Code", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_11352" },
                                                                    new Element { Name = "Nursing Home Residential Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1345" },
                                                                }
                                                            } // end of "CL1"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CR1_AmbulanceTransportInformation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CR1",  Min = 0,  Max = 1,  Name = "Ambulance Transport Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Weight", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Ambulance Transport Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1316" },
                                                                    new Element { Name = "Ambulance Transport Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1317" },
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
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
                                                            Name = "CR2_SpinalManipulationServiceInformation_TS278A3",  IsOptional = false,
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
                                                                    new Element { Name = "Nature of Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1342" },
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
                                                            Name = "CR5_HomeOxygenTherapyInformation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CR5",  Min = 0,  Max = 1,  Name = "Home Oxygen Therapy Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Certification Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                    new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Oxygen Test Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1349" },
                                                                    new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                    new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                    new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Oxygen Delivery System Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1382" },
                                                                    new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                }
                                                            } // end of "CR5"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CR6_HomeHealthCareInformation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CR6",  Min = 0,  Max = 1,  Name = "Home Health Care Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Prognosis Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                    new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                    new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Medical Code Value", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                    new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Patient Location Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1384" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "CR6"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "PWK_AdditionalPatientInformation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "PWK",  Min = 0,  Max = 10,  Name = "Additional Patient Information",
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
                                                            Name = "MSG_MessageText_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "MSG",  Min = 0,  Max = 1,  Name = "Message Text",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Free-form Message Text", IsOptional = false, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Printer Carriage Control Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_934" },
                                                                    new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "MSG"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "NM1_SubLoop_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "TS278A3_2000F_Loop",  IsOptional = false,
                                                            Nodes = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    Name = "HL_ServiceLevel_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HL",  Min = 1,  Max = 1,  Name = "Service Level",
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
                                                                    Name = "TRN_ServiceTraceNumber_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "TRN",  Min = 0,  Max = 3,  Name = "Service Trace Number",
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
                                                                    Name = "AAA_ServiceRequestValidation_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "AAA",  Min = 0,  Max = 9,  Name = "Service Request Validation",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                                                            new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                                            new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                                                        }
                                                                    } // end of "AAA"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "UM_HealthCareServicesReviewInformation_2_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "UM",  Min = 0,  Max = 1,  Name = "Health Care Services Review Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Request Category Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                                            new Element { Name = "Certification Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                            new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                                            new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                                            new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                            new Element { Name = "Release of Information Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                                            new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                                        }
                                                                    } // end of "UM"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "HCR_HealthCareServicesReview_2_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HCR",  Min = 0,  Max = 1,  Name = "Health Care Services Review",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Industry Code", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                        }
                                                                    } // end of "HCR"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "REF_SubLoop_2_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                    }
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "DTP_SubLoop_2_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                    }
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "HI_RequestForAdditionalInformation_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HI",  Min = 0,  Max = 1,  Name = "Request For Additional Information",
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
                                                                    Name = "SV1_ProfessionalService_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "SV1",  Min = 0,  Max = 1,  Name = "Professional Service",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
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
                                                                    Name = "SV2_InstitutionalServiceLine_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "SV2",  Min = 0,  Max = 1,  Name = "Institutional Service Line",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit Rate", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "Nursing Home Residential Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1345" },
                                                                            new Element { Name = "Level of Care Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1337" },
                                                                        }
                                                                    } // end of "SV2"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "SV3_DentalService_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "SV3",  Min = 0,  Max = 1,  Name = "Dental Service",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Prosthesis, Crown or Inlay Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1358" },
                                                                            new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Copay Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1327" },
                                                                            new Element { Name = "Provider Agreement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1360" },
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "SV3"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "TOO_ToothInformation_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "TOO",  Min = 0,  Max = 32,  Name = "Tooth Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Code List Qualifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1270" },
                                                                            new Element { Name = "Industry Code", IsOptional = false, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "TOO"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "HSD_HealthCareServicesDelivery_2_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HSD",  Min = 0,  Max = 1,  Name = "Health Care Services Delivery",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Quantity Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Sample Selection Modulus", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Time Period Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_615" },
                                                                            new Element { Name = "Number of Periods", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "int", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Ship/Delivery or Calendar Pattern Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_678" },
                                                                            new Element { Name = "Ship/Delivery Pattern Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_679" },
                                                                        }
                                                                    } // end of "HSD"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "PWK_AdditionalServiceInformation_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "PWK",  Min = 0,  Max = 10,  Name = "Additional Service Information",
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
                                                                    Name = "MSG_MessageText_2_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "MSG",  Min = 0,  Max = 1,  Name = "Message Text",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Free-form Message Text", IsOptional = false, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Printer Carriage Control Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_934" },
                                                                            new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "MSG"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "NM1_SubLoop_2_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                    }
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
                                                    Name = "TS278A3_2000D_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "HL_DependentLevel_TS278A3",  IsOptional = false,
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
                                                            Name = "TS278A3_2010D_Loop",  IsOptional = false,
                                                            Nodes = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    Name = "NM1_DependentName_TS278A3",  IsOptional = false,
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
                                                                    Name = "REF_DependentSupplementalIdentification_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "REF",  Min = 0,  Max = 3,  Name = "Dependent Supplemental Identification",
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
                                                                    Name = "N3_DependentAddress_TS278A3",  IsOptional = false,
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
                                                                    Name = "N4_DependentCity_State_ZIPCode_TS278A3",  IsOptional = false,
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
                                                                    Name = "AAA_DependentRequestValidation_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "AAA",  Min = 0,  Max = 9,  Name = "Dependent Request Validation",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                                                            new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                                            new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                                                        }
                                                                    } // end of "AAA"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "DMG_DependentDemographicInformation_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "DMG",  Min = 0,  Max = 1,  Name = "Dependent Demographic Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                            new Element { Name = "Date Time Period", IsOptional = false, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
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
                                                                    Name = "INS_DependentRelationship_TS278A3",  IsOptional = false,
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
                                                            },
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "TS278A3_2000E_Loop",  IsOptional = false,
                                                            Nodes = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    Name = "HL_PatientEventLevel_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HL",  Min = 1,  Max = 1,  Name = "Patient Event Level",
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
                                                                    Name = "TRN_PatientEventTrackingNumber_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "TRN",  Min = 0,  Max = 3,  Name = "Patient Event Tracking Number",
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
                                                                    Name = "AAA_PatientEventRequestValidation_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "AAA",  Min = 0,  Max = 9,  Name = "Patient Event Request Validation",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                                                            new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                                            new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                                                        }
                                                                    } // end of "AAA"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "UM_HealthCareServicesReviewInformation_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "UM",  Min = 1,  Max = 1,  Name = "Health Care Services Review Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Request Category Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                                            new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                            new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                                            new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                                            new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                            new Element { Name = "Release of Information Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                                            new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                                        }
                                                                    } // end of "UM"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "HCR_HealthCareServicesReview_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HCR",  Min = 0,  Max = 1,  Name = "Health Care Services Review",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Industry Code", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                        }
                                                                    } // end of "HCR"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "REF_SubLoop_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                    }
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "DTP_SubLoop_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                    }
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "HI_PatientDiagnosis_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HI",  Min = 0,  Max = 1,  Name = "Patient Diagnosis",
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
                                                                    Name = "HSD_HealthCareServicesDelivery_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HSD",  Min = 0,  Max = 1,  Name = "Health Care Services Delivery",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Quantity Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Sample Selection Modulus", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Time Period Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_615" },
                                                                            new Element { Name = "Number of Periods", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "int", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Ship/Delivery or Calendar Pattern Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_678" },
                                                                            new Element { Name = "Ship/Delivery Pattern Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_679" },
                                                                        }
                                                                    } // end of "HSD"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "CL1_InstitutionalClaimCode_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "CL1",  Min = 0,  Max = 1,  Name = "Institutional Claim Code",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Admission Type Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11315" },
                                                                            new Element { Name = "Admission Source Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11314" },
                                                                            new Element { Name = "Patient Status Code", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_11352" },
                                                                            new Element { Name = "Nursing Home Residential Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1345" },
                                                                        }
                                                                    } // end of "CL1"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "CR1_AmbulanceTransportInformation_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "CR1",  Min = 0,  Max = 1,  Name = "Ambulance Transport Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Weight", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Ambulance Transport Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1316" },
                                                                            new Element { Name = "Ambulance Transport Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1317" },
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
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
                                                                    Name = "CR2_SpinalManipulationServiceInformation_TS278A3",  IsOptional = false,
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
                                                                            new Element { Name = "Nature of Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1342" },
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
                                                                    Name = "CR5_HomeOxygenTherapyInformation_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "CR5",  Min = 0,  Max = 1,  Name = "Home Oxygen Therapy Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Certification Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                            new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Oxygen Test Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1349" },
                                                                            new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                            new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                            new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Oxygen Delivery System Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1382" },
                                                                            new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                        }
                                                                    } // end of "CR5"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "CR6_HomeHealthCareInformation_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "CR6",  Min = 0,  Max = 1,  Name = "Home Health Care Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Prognosis Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                            new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                            new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                            new Element { Name = "Medical Code Value", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                            new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Patient Location Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1384" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "CR6"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "PWK_AdditionalPatientInformation_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "PWK",  Min = 0,  Max = 10,  Name = "Additional Patient Information",
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
                                                                    Name = "MSG_MessageText_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "MSG",  Min = 0,  Max = 1,  Name = "Message Text",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Free-form Message Text", IsOptional = false, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Printer Carriage Control Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_934" },
                                                                            new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "MSG"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "NM1_SubLoop_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                    }
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "TS278A3_2000F_Loop",  IsOptional = false,
                                                                    Nodes = new Node[]
                                                                    {
                                                                        new Node
                                                                        {
                                                                            Name = "HL_ServiceLevel_TS278A3",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Service Level",
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
                                                                            Name = "TRN_ServiceTraceNumber_TS278A3",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "TRN",  Min = 0,  Max = 3,  Name = "Service Trace Number",
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
                                                                            Name = "AAA_ServiceRequestValidation_TS278A3",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "AAA",  Min = 0,  Max = 9,  Name = "Service Request Validation",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                                    new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                                                                    new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                                                    new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                                                                }
                                                                            } // end of "AAA"
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "UM_HealthCareServicesReviewInformation_2_TS278A3",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "UM",  Min = 0,  Max = 1,  Name = "Health Care Services Review Information",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "Request Category Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                                                    new Element { Name = "Certification Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                                    new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                                                    new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                                                    new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                                    new Element { Name = "Release of Information Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                                                    new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                                                }
                                                                            } // end of "UM"
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "HCR_HealthCareServicesReview_2_TS278A3",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "HCR",  Min = 0,  Max = 1,  Name = "Health Care Services Review",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                                                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Industry Code", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                                }
                                                                            } // end of "HCR"
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "REF_SubLoop_2_TS278A3",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                            }
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "DTP_SubLoop_2_TS278A3",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                            }
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "HI_RequestForAdditionalInformation_TS278A3",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "HI",  Min = 0,  Max = 1,  Name = "Request For Additional Information",
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
                                                                            Name = "SV1_ProfessionalService_TS278A3",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "SV1",  Min = 0,  Max = 1,  Name = "Professional Service",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
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
                                                                            Name = "SV2_InstitutionalServiceLine_TS278A3",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "SV2",  Min = 0,  Max = 1,  Name = "Institutional Service Line",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Unit Rate", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                                    new Element { Name = "Nursing Home Residential Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1345" },
                                                                                    new Element { Name = "Level of Care Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1337" },
                                                                                }
                                                                            } // end of "SV2"
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "SV3_DentalService_TS278A3",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "SV3",  Min = 0,  Max = 1,  Name = "Dental Service",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Prosthesis, Crown or Inlay Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1358" },
                                                                                    new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Copay Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1327" },
                                                                                    new Element { Name = "Provider Agreement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1360" },
                                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                }
                                                                            } // end of "SV3"
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "TOO_ToothInformation_TS278A3",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "TOO",  Min = 0,  Max = 32,  Name = "Tooth Information",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "Code List Qualifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1270" },
                                                                                    new Element { Name = "Industry Code", IsOptional = false, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                                }
                                                                            } // end of "TOO"
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "HSD_HealthCareServicesDelivery_2_TS278A3",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "HSD",  Min = 0,  Max = 1,  Name = "Health Care Services Delivery",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "Quantity Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                                    new Element { Name = "Sample Selection Modulus", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Time Period Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_615" },
                                                                                    new Element { Name = "Number of Periods", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "int", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Ship/Delivery or Calendar Pattern Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_678" },
                                                                                    new Element { Name = "Ship/Delivery Pattern Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_679" },
                                                                                }
                                                                            } // end of "HSD"
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "PWK_AdditionalServiceInformation_TS278A3",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "PWK",  Min = 0,  Max = 10,  Name = "Additional Service Information",
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
                                                                            Name = "MSG_MessageText_2_TS278A3",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "MSG",  Min = 0,  Max = 1,  Name = "Message Text",
                                                                                Elements = new[]
                                                                                {
                                                                                    new Element { Name = "Free-form Message Text", IsOptional = false, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                                    new Element { Name = "Printer Carriage Control Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_934" },
                                                                                    new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                                                }
                                                                            } // end of "MSG"
                                                                        }
                                                                        ,
                                                                        new Node
                                                                        {
                                                                            Name = "NM1_SubLoop_2_TS278A3",  IsOptional = false,
                                                                            Segment = new Segment
                                                                            {
                                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
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
                    Name = "BHT_BeginningofHierarchicalTransaction_TS278A3",  IsOptional = false,
                    Segment = new Segment
                    {
                        Tag = "BHT",  Min = 0,  Max = 1,  Name = "Beginning of Hierarchical Transaction",
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
                    Name = "TS278A3_2000A_Loop",  IsOptional = false,
                    Nodes = new Node[]
                    {
                        new Node
                        {
                            Name = "HL_UtilizationManagementOrganization_UMO_Level_TS278A3",  IsOptional = false,
                            Segment = new Segment
                            {
                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Utilization Management Organization (UMO) Level",
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
                            Name = "AAA_RequestValidation_TS278A3",  IsOptional = false,
                            Segment = new Segment
                            {
                                Tag = "AAA",  Min = 0,  Max = 9,  Name = "Request Validation",
                                Elements = new[]
                                {
                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                    new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                    new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                    new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                }
                            } // end of "AAA"
                        }
                        ,
                        new Node
                        {
                            Name = "TS278A3_2010A_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "NM1_UtilizationManagementOrganization_UMO_Name_TS278A3",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "NM1",  Min = 1,  Max = 1,  Name = "Utilization Management Organization (UMO) Name",
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
                                new Node
                                {
                                    Name = "PER_UtilizationManagementOrganization_UMO_ContactInformation_TS278A3",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "PER",  Min = 0,  Max = 1,  Name = "Utilization Management Organization (UMO) Contact Information",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Contact Function Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_366" },
                                            new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Communication Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_365" },
                                            new Element { Name = "Communication Number", IsOptional = true, LengthMin = 1, LengthMax = 256, Type = "string", Value = "null", CodeTable = "null" },
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
                                    Name = "AAA_UtilizationManagementOrganization_UMO_RequestValidation_TS278A3",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "AAA",  Min = 0,  Max = 9,  Name = "Utilization Management Organization (UMO) Request Validation",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                            new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                            new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                            new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                        }
                                    } // end of "AAA"
                                }
                                ,
                            },
                        }
                        ,
                        new Node
                        {
                            Name = "TS278A3_2000B_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "HL_RequesterLevel_TS278A3",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "HL",  Min = 1,  Max = 1,  Name = "Requester Level",
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
                                    Name = "TS278A3_2010B_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "NM1_RequesterName_TS278A3",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Requester Name",
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
                                        new Node
                                        {
                                            Name = "REF_RequesterSupplementalIdentification_TS278A3",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "REF",  Min = 0,  Max = 8,  Name = "Requester Supplemental Identification",
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
                                            Name = "AAA_RequesterRequestValidation_TS278A3",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "AAA",  Min = 0,  Max = 9,  Name = "Requester Request Validation",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                    new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                                    new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                    new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                                }
                                            } // end of "AAA"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "PRV_RequesterProviderInformation_TS278A3",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "PRV",  Min = 0,  Max = 1,  Name = "Requester Provider Information",
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
                                    Name = "TS278A3_2000C_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "HL_SubscriberLevel_TS278A3",  IsOptional = false,
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
                                            Name = "TS278A3_2010C_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "NM1_SubscriberName_TS278A3",  IsOptional = false,
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
                                                    Name = "REF_SubscriberSupplementalIdentification_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "REF",  Min = 0,  Max = 9,  Name = "Subscriber Supplemental Identification",
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
                                                    Name = "N3_SubscriberMailingAddress_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "N3",  Min = 0,  Max = 1,  Name = "Subscriber Mailing Address",
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
                                                    Name = "N4_SubscriberCity_State_ZIPCode_TS278A3",  IsOptional = false,
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
                                                    Name = "AAA_SubscriberRequestValidation_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "AAA",  Min = 0,  Max = 9,  Name = "Subscriber Request Validation",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                                            new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                            new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                                        }
                                                    } // end of "AAA"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "DMG_SubscriberDemographicInformation_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "DMG",  Min = 0,  Max = 1,  Name = "Subscriber Demographic Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                            new Element { Name = "Date Time Period", IsOptional = false, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
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
                                                    Name = "INS_SubscriberRelationship_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "INS",  Min = 0,  Max = 1,  Name = "Subscriber Relationship",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Individual Relationship Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1069" },
                                                            new Element { Name = "Maintenance Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_875" },
                                                            new Element { Name = "Maintenance Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1203" },
                                                            new Element { Name = "Benefit Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1216" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1219" },
                                                            new Element { Name = "Employment Status Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_584" },
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
                                            },
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "TS278A3_2000E_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "HL_PatientEventLevel_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "HL",  Min = 1,  Max = 1,  Name = "Patient Event Level",
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
                                                    Name = "TRN_PatientEventTrackingNumber_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "TRN",  Min = 0,  Max = 3,  Name = "Patient Event Tracking Number",
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
                                                    Name = "AAA_PatientEventRequestValidation_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "AAA",  Min = 0,  Max = 9,  Name = "Patient Event Request Validation",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                                            new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                            new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                                        }
                                                    } // end of "AAA"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "UM_HealthCareServicesReviewInformation_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "UM",  Min = 1,  Max = 1,  Name = "Health Care Services Review Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Request Category Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                            new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                            new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                            new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                            new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                            new Element { Name = "Release of Information Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                            new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                        }
                                                    } // end of "UM"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "HCR_HealthCareServicesReview_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "HCR",  Min = 0,  Max = 1,  Name = "Health Care Services Review",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Industry Code", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                        }
                                                    } // end of "HCR"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "REF_SubLoop_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                    }
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "DTP_SubLoop_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                    }
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "HI_PatientDiagnosis_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "HI",  Min = 0,  Max = 1,  Name = "Patient Diagnosis",
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
                                                    Name = "HSD_HealthCareServicesDelivery_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "HSD",  Min = 0,  Max = 1,  Name = "Health Care Services Delivery",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Quantity Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                            new Element { Name = "Sample Selection Modulus", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Time Period Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_615" },
                                                            new Element { Name = "Number of Periods", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "int", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Ship/Delivery or Calendar Pattern Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_678" },
                                                            new Element { Name = "Ship/Delivery Pattern Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_679" },
                                                        }
                                                    } // end of "HSD"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "CL1_InstitutionalClaimCode_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "CL1",  Min = 0,  Max = 1,  Name = "Institutional Claim Code",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Admission Type Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11315" },
                                                            new Element { Name = "Admission Source Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11314" },
                                                            new Element { Name = "Patient Status Code", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_11352" },
                                                            new Element { Name = "Nursing Home Residential Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1345" },
                                                        }
                                                    } // end of "CL1"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "CR1_AmbulanceTransportInformation_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "CR1",  Min = 0,  Max = 1,  Name = "Ambulance Transport Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                            new Element { Name = "Weight", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Ambulance Transport Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1316" },
                                                            new Element { Name = "Ambulance Transport Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1317" },
                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
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
                                                    Name = "CR2_SpinalManipulationServiceInformation_TS278A3",  IsOptional = false,
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
                                                            new Element { Name = "Nature of Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1342" },
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
                                                    Name = "CR5_HomeOxygenTherapyInformation_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "CR5",  Min = 0,  Max = 1,  Name = "Home Oxygen Therapy Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Certification Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                            new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Oxygen Test Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1349" },
                                                            new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                            new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                            new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Oxygen Delivery System Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1382" },
                                                            new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                        }
                                                    } // end of "CR5"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "CR6_HomeHealthCareInformation_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "CR6",  Min = 0,  Max = 1,  Name = "Home Health Care Information",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Prognosis Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                            new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                            new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                            new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                            new Element { Name = "Medical Code Value", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                            new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Patient Location Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1384" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "CR6"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "PWK_AdditionalPatientInformation_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "PWK",  Min = 0,  Max = 10,  Name = "Additional Patient Information",
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
                                                    Name = "MSG_MessageText_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "MSG",  Min = 0,  Max = 1,  Name = "Message Text",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Free-form Message Text", IsOptional = false, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Printer Carriage Control Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_934" },
                                                            new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "MSG"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "NM1_SubLoop_TS278A3",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                    }
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "TS278A3_2000F_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "HL_ServiceLevel_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Service Level",
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
                                                            Name = "TRN_ServiceTraceNumber_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "TRN",  Min = 0,  Max = 3,  Name = "Service Trace Number",
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
                                                            Name = "AAA_ServiceRequestValidation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "AAA",  Min = 0,  Max = 9,  Name = "Service Request Validation",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                                                    new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                                    new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                                                }
                                                            } // end of "AAA"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "UM_HealthCareServicesReviewInformation_2_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "UM",  Min = 0,  Max = 1,  Name = "Health Care Services Review Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Request Category Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                                    new Element { Name = "Certification Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                    new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                                    new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                                    new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                    new Element { Name = "Release of Information Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                                    new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                                }
                                                            } // end of "UM"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "HCR_HealthCareServicesReview_2_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HCR",  Min = 0,  Max = 1,  Name = "Health Care Services Review",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Industry Code", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                }
                                                            } // end of "HCR"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "REF_SubLoop_2_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "DTP_SubLoop_2_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "HI_RequestForAdditionalInformation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HI",  Min = 0,  Max = 1,  Name = "Request For Additional Information",
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
                                                            Name = "SV1_ProfessionalService_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "SV1",  Min = 0,  Max = 1,  Name = "Professional Service",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
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
                                                            Name = "SV2_InstitutionalServiceLine_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "SV2",  Min = 0,  Max = 1,  Name = "Institutional Service Line",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Unit Rate", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Nursing Home Residential Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1345" },
                                                                    new Element { Name = "Level of Care Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1337" },
                                                                }
                                                            } // end of "SV2"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "SV3_DentalService_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "SV3",  Min = 0,  Max = 1,  Name = "Dental Service",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Prosthesis, Crown or Inlay Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1358" },
                                                                    new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Copay Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1327" },
                                                                    new Element { Name = "Provider Agreement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1360" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "SV3"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "TOO_ToothInformation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "TOO",  Min = 0,  Max = 32,  Name = "Tooth Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Code List Qualifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1270" },
                                                                    new Element { Name = "Industry Code", IsOptional = false, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "TOO"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "HSD_HealthCareServicesDelivery_2_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HSD",  Min = 0,  Max = 1,  Name = "Health Care Services Delivery",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Quantity Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Sample Selection Modulus", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Time Period Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_615" },
                                                                    new Element { Name = "Number of Periods", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "int", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Ship/Delivery or Calendar Pattern Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_678" },
                                                                    new Element { Name = "Ship/Delivery Pattern Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_679" },
                                                                }
                                                            } // end of "HSD"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "PWK_AdditionalServiceInformation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "PWK",  Min = 0,  Max = 10,  Name = "Additional Service Information",
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
                                                            Name = "MSG_MessageText_2_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "MSG",  Min = 0,  Max = 1,  Name = "Message Text",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Free-form Message Text", IsOptional = false, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Printer Carriage Control Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_934" },
                                                                    new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "MSG"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "NM1_SubLoop_2_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
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
                                            Name = "TS278A3_2000D_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "HL_DependentLevel_TS278A3",  IsOptional = false,
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
                                                    Name = "TS278A3_2010D_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "NM1_DependentName_TS278A3",  IsOptional = false,
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
                                                            Name = "REF_DependentSupplementalIdentification_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "REF",  Min = 0,  Max = 3,  Name = "Dependent Supplemental Identification",
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
                                                            Name = "N3_DependentAddress_TS278A3",  IsOptional = false,
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
                                                            Name = "N4_DependentCity_State_ZIPCode_TS278A3",  IsOptional = false,
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
                                                            Name = "AAA_DependentRequestValidation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "AAA",  Min = 0,  Max = 9,  Name = "Dependent Request Validation",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                                                    new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                                    new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                                                }
                                                            } // end of "AAA"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "DMG_DependentDemographicInformation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "DMG",  Min = 0,  Max = 1,  Name = "Dependent Demographic Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                    new Element { Name = "Date Time Period", IsOptional = false, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
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
                                                            Name = "INS_DependentRelationship_TS278A3",  IsOptional = false,
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
                                                    },
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "TS278A3_2000E_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "HL_PatientEventLevel_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HL",  Min = 1,  Max = 1,  Name = "Patient Event Level",
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
                                                            Name = "TRN_PatientEventTrackingNumber_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "TRN",  Min = 0,  Max = 3,  Name = "Patient Event Tracking Number",
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
                                                            Name = "AAA_PatientEventRequestValidation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "AAA",  Min = 0,  Max = 9,  Name = "Patient Event Request Validation",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                                                    new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                                    new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                                                }
                                                            } // end of "AAA"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "UM_HealthCareServicesReviewInformation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "UM",  Min = 1,  Max = 1,  Name = "Health Care Services Review Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Request Category Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                                    new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                    new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                                    new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                                    new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                    new Element { Name = "Release of Information Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                                    new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                                }
                                                            } // end of "UM"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "HCR_HealthCareServicesReview_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HCR",  Min = 0,  Max = 1,  Name = "Health Care Services Review",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Industry Code", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                }
                                                            } // end of "HCR"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "REF_SubLoop_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "DTP_SubLoop_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "HI_PatientDiagnosis_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HI",  Min = 0,  Max = 1,  Name = "Patient Diagnosis",
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
                                                            Name = "HSD_HealthCareServicesDelivery_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "HSD",  Min = 0,  Max = 1,  Name = "Health Care Services Delivery",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Quantity Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Sample Selection Modulus", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Time Period Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_615" },
                                                                    new Element { Name = "Number of Periods", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "int", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Ship/Delivery or Calendar Pattern Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_678" },
                                                                    new Element { Name = "Ship/Delivery Pattern Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_679" },
                                                                }
                                                            } // end of "HSD"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CL1_InstitutionalClaimCode_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CL1",  Min = 0,  Max = 1,  Name = "Institutional Claim Code",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Admission Type Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11315" },
                                                                    new Element { Name = "Admission Source Code", IsOptional = true, LengthMin = 1, LengthMax = 1, Type = "code", Value = "null", CodeTable = "Table_11314" },
                                                                    new Element { Name = "Patient Status Code", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "code", Value = "null", CodeTable = "Table_11352" },
                                                                    new Element { Name = "Nursing Home Residential Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1345" },
                                                                }
                                                            } // end of "CL1"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CR1_AmbulanceTransportInformation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CR1",  Min = 0,  Max = 1,  Name = "Ambulance Transport Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Weight", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Ambulance Transport Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1316" },
                                                                    new Element { Name = "Ambulance Transport Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1317" },
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
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
                                                            Name = "CR2_SpinalManipulationServiceInformation_TS278A3",  IsOptional = false,
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
                                                                    new Element { Name = "Nature of Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1342" },
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
                                                            Name = "CR5_HomeOxygenTherapyInformation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CR5",  Min = 0,  Max = 1,  Name = "Home Oxygen Therapy Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Certification Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                    new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Oxygen Test Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1349" },
                                                                    new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                    new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                    new Element { Name = "Oxygen Test Findings Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1350" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Oxygen Delivery System Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1382" },
                                                                    new Element { Name = "Oxygen Equipment Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1348" },
                                                                }
                                                            } // end of "CR5"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "CR6_HomeHealthCareInformation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "CR6",  Min = 0,  Max = 1,  Name = "Home Health Care Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Prognosis Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                    new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                    new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                    new Element { Name = "Certification Type Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Product/Service ID Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_235" },
                                                                    new Element { Name = "Medical Code Value", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                                    new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Patient Location Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1384" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "CR6"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "PWK_AdditionalPatientInformation_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "PWK",  Min = 0,  Max = 10,  Name = "Additional Patient Information",
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
                                                            Name = "MSG_MessageText_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "MSG",  Min = 0,  Max = 1,  Name = "Message Text",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Free-form Message Text", IsOptional = false, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Printer Carriage Control Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_934" },
                                                                    new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                                }
                                                            } // end of "MSG"
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "NM1_SubLoop_TS278A3",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                            }
                                                        }
                                                        ,
                                                        new Node
                                                        {
                                                            Name = "TS278A3_2000F_Loop",  IsOptional = false,
                                                            Nodes = new Node[]
                                                            {
                                                                new Node
                                                                {
                                                                    Name = "HL_ServiceLevel_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HL",  Min = 1,  Max = 1,  Name = "Service Level",
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
                                                                    Name = "TRN_ServiceTraceNumber_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "TRN",  Min = 0,  Max = 3,  Name = "Service Trace Number",
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
                                                                    Name = "AAA_ServiceRequestValidation_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "AAA",  Min = 0,  Max = 9,  Name = "Service Request Validation",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                                                            new Element { Name = "Reject Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_901" },
                                                                            new Element { Name = "Follow-up Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_889" },
                                                                        }
                                                                    } // end of "AAA"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "UM_HealthCareServicesReviewInformation_2_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "UM",  Min = 0,  Max = 1,  Name = "Health Care Services Review Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Request Category Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1525" },
                                                                            new Element { Name = "Certification Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1322" },
                                                                            new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Level of Service Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1338" },
                                                                            new Element { Name = "Current Health Condition Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1213" },
                                                                            new Element { Name = "Prognosis Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_923" },
                                                                            new Element { Name = "Release of Information Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1363" },
                                                                            new Element { Name = "Delay Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1514" },
                                                                        }
                                                                    } // end of "UM"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "HCR_HealthCareServicesReview_2_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HCR",  Min = 0,  Max = 1,  Name = "Health Care Services Review",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Action Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_306" },
                                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Industry Code", IsOptional = true, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                        }
                                                                    } // end of "HCR"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "REF_SubLoop_2_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                    }
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "DTP_SubLoop_2_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
                                                                    }
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "HI_RequestForAdditionalInformation_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HI",  Min = 0,  Max = 1,  Name = "Request For Additional Information",
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
                                                                    Name = "SV1_ProfessionalService_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "SV1",  Min = 0,  Max = 1,  Name = "Professional Service",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Service Type Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1365" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
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
                                                                    Name = "SV2_InstitutionalServiceLine_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "SV2",  Min = 0,  Max = 1,  Name = "Institutional Service Line",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Product/Service ID", IsOptional = true, LengthMin = 1, LengthMax = 48, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit Rate", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "Nursing Home Residential Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1345" },
                                                                            new Element { Name = "Level of Care Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1337" },
                                                                        }
                                                                    } // end of "SV2"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "SV3_DentalService_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "SV3",  Min = 0,  Max = 1,  Name = "Dental Service",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Facility Code Value", IsOptional = true, LengthMin = 1, LengthMax = 2, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Prosthesis, Crown or Inlay Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1358" },
                                                                            new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Copay Status Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1327" },
                                                                            new Element { Name = "Provider Agreement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1360" },
                                                                            new Element { Name = "Yes/No Condition or Response Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1073" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "SV3"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "TOO_ToothInformation_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "TOO",  Min = 0,  Max = 32,  Name = "Tooth Information",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Code List Qualifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1270" },
                                                                            new Element { Name = "Industry Code", IsOptional = false, LengthMin = 1, LengthMax = 30, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "TOO"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "HSD_HealthCareServicesDelivery_2_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "HSD",  Min = 0,  Max = 1,  Name = "Health Care Services Delivery",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Quantity Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_673" },
                                                                            new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                            new Element { Name = "Sample Selection Modulus", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Time Period Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_615" },
                                                                            new Element { Name = "Number of Periods", IsOptional = true, LengthMin = 1, LengthMax = 3, Type = "int", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Ship/Delivery or Calendar Pattern Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_678" },
                                                                            new Element { Name = "Ship/Delivery Pattern Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_679" },
                                                                        }
                                                                    } // end of "HSD"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "PWK_AdditionalServiceInformation_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "PWK",  Min = 0,  Max = 10,  Name = "Additional Service Information",
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
                                                                    Name = "MSG_MessageText_2_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "MSG",  Min = 0,  Max = 1,  Name = "Message Text",
                                                                        Elements = new[]
                                                                        {
                                                                            new Element { Name = "Free-form Message Text", IsOptional = false, LengthMin = 1, LengthMax = 264, Type = "string", Value = "null", CodeTable = "null" },
                                                                            new Element { Name = "Printer Carriage Control Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_934" },
                                                                            new Element { Name = "Number", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "int", Value = "null", CodeTable = "null" },
                                                                        }
                                                                    } // end of "MSG"
                                                                }
                                                                ,
                                                                new Node
                                                                {
                                                                    Name = "NM1_SubLoop_2_TS278A3",  IsOptional = false,
                                                                    Segment = new Segment
                                                                    {
                                                                        Tag = "",  Min = 0,  Max = 1,  Name = "",
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
    } // end of "X12_00501_278"
}
