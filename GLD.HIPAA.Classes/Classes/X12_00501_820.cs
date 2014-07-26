using System.Collections.Generic;
using GLD.HIPAA.Model;

namespace GLD.HIPAA.Classes
{
public class X12_00501_820
    {
        public Node Root = 
        new Node
        {
            Name = "X12_00501_820",  IsOptional = false,
            Nodes = new Node[]
            {
                new Node
                {
                    Name = "ST",  IsOptional = false,
                    Segment = new Segment
                    {
                        Tag = "ST",  Min = 1,  Max = 1,  Name = "820 Header",
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
                    Name = "BPR_FinancialInformation",  IsOptional = false,
                    Segment = new Segment
                    {
                        Tag = "BPR",  Min = 1,  Max = 1,  Name = "Financial Information",
                        Elements = new[]
                        {
                            new Element { Name = "Transaction Handling Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_305" },
                            new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                            new Element { Name = "Credit/Debit Flag Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_478" },
                            new Element { Name = "Payment Method Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_591" },
                            new Element { Name = "Payment Format Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_812" },
                            new Element { Name = "(DFI) ID Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_506" },
                            new Element { Name = "(DFI) Identification Number", IsOptional = true, LengthMin = 3, LengthMax = 12, Type = "string", Value = "null", CodeTable = "null" },
                            new Element { Name = "Account Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_569" },
                            new Element { Name = "Account Number", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                            new Element { Name = "Originating Company Identifier", IsOptional = false, LengthMin = 10, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                            new Element { Name = "Originating Company Supplemental Code", IsOptional = true, LengthMin = 9, LengthMax = 9, Type = "string", Value = "null", CodeTable = "null" },
                            new Element { Name = "(DFI) ID Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_506" },
                            new Element { Name = "(DFI) Identification Number", IsOptional = true, LengthMin = 3, LengthMax = 12, Type = "string", Value = "null", CodeTable = "null" },
                            new Element { Name = "Account Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_569" },
                            new Element { Name = "Account Number", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                            new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                            new Element { Name = "Business Function Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1048" },
                            new Element { Name = "(DFI) ID Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_506" },
                            new Element { Name = "(DFI) Identification Number", IsOptional = true, LengthMin = 3, LengthMax = 12, Type = "string", Value = "null", CodeTable = "null" },
                            new Element { Name = "Account Number Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_569" },
                            new Element { Name = "Account Number", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                        }
                    } // end of "BPR"
                }
                ,
                new Node
                {
                    Name = "TRN_ReassociationTraceNumber",  IsOptional = false,
                    Segment = new Segment
                    {
                        Tag = "TRN",  Min = 1,  Max = 1,  Name = "Reassociation Trace Number",
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
                    Name = "REF_PremiumReceiversIdentificationKey",  IsOptional = false,
                    Segment = new Segment
                    {
                        Tag = "REF",  Min = 0,  Max = 10000,  Name = "Premium Receivers Identification Key",
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
                    Name = "DTM_SubLoop",  IsOptional = false,
                    Nodes = new Node[]
                    {
                        new Node
                        {
                            Name = "DTM_ProcessDate",  IsOptional = false,
                            Segment = new Segment
                            {
                                Tag = "DTM",  Min = 0,  Max = 1,  Name = "Process Date",
                                Elements = new[]
                                {
                                    new Element { Name = "Date/Time Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_374" },
                                    new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Time", IsOptional = true, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_623" },
                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                    new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                }
                            } // end of "DTM"
                        }
                        ,
                        new Node
                        {
                            Name = "DTM_DeliveryDate",  IsOptional = false,
                            Segment = new Segment
                            {
                                Tag = "DTM",  Min = 0,  Max = 1,  Name = "Delivery Date",
                                Elements = new[]
                                {
                                    new Element { Name = "Date/Time Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_374" },
                                    new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Time", IsOptional = true, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_623" },
                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                    new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                }
                            } // end of "DTM"
                        }
                        ,
                        new Node
                        {
                            Name = "DTM_CoveragePeriod",  IsOptional = false,
                            Segment = new Segment
                            {
                                Tag = "DTM",  Min = 0,  Max = 1,  Name = "Coverage Period",
                                Elements = new[]
                                {
                                    new Element { Name = "Date/Time Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_374" },
                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Time", IsOptional = true, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_623" },
                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                    new Element { Name = "Date Time Period", IsOptional = false, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                }
                            } // end of "DTM"
                        }
                        ,
                        new Node
                        {
                            Name = "DTM_CreationDate",  IsOptional = false,
                            Segment = new Segment
                            {
                                Tag = "DTM",  Min = 0,  Max = 1,  Name = "Creation Date",
                                Elements = new[]
                                {
                                    new Element { Name = "Date/Time Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_374" },
                                    new Element { Name = "Date", IsOptional = false, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Time", IsOptional = true, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                                    new Element { Name = "Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_623" },
                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                    new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                }
                            } // end of "DTM"
                        }
                        ,
                    },
                }
                ,
                new Node
                {
                    Name = "N1_SubLoop",  IsOptional = false,
                    Nodes = new Node[]
                    {
                        new Node
                        {
                            Name = "TS820_1000A_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "N1_PremiumReceiver_sName",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "N1",  Min = 1,  Max = 1,  Name = "Premium Receiver's Name",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                            new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
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
                                    Name = "N2_PremiumReceiverAdditionalName",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "N2",  Min = 0,  Max = 1,  Name = "Premium Receiver Additional Name",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Name", IsOptional = false, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                        }
                                    } // end of "N2"
                                }
                                ,
                                new Node
                                {
                                    Name = "N3_PremiumReceiver_sAddress",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "N3",  Min = 0,  Max = 1,  Name = "Premium Receiver's Address",
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
                                    Name = "N4_PremiumReceiver_sCity_State_andZIPCode",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "N4",  Min = 0,  Max = 1,  Name = "Premium Receiver's City, State, and ZIP Code",
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
                                    Name = "RDM_PremiumReceiver_sRemittanceDeliveryMethod",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "RDM",  Min = 0,  Max = 1,  Name = "Premium Receiver's Remittance Delivery Method",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Report Transmission Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_756" },
                                            new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Communication Number", IsOptional = true, LengthMin = 1, LengthMax = 256, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                        }
                                    } // end of "RDM"
                                }
                                ,
                            },
                        }
                        ,
                        new Node
                        {
                            Name = "TS820_1000B_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "N1_PremiumPayer_sName",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "N1",  Min = 1,  Max = 1,  Name = "Premium Payer's Name",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                            new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
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
                                    Name = "N2_PremiumPayerAdditionalName",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "N2",  Min = 0,  Max = 1,  Name = "Premium Payer Additional Name",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Name", IsOptional = false, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                        }
                                    } // end of "N2"
                                }
                                ,
                                new Node
                                {
                                    Name = "N3_PremiumPayer_sAddress",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "N3",  Min = 0,  Max = 1,  Name = "Premium Payer's Address",
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
                                    Name = "N4_PremiumPayer_sCity_State_ZIPCode",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "N4",  Min = 0,  Max = 1,  Name = "Premium Payer’s City, State, ZIP Code",
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
                                    Name = "PER_PremiumPayer_sAdministrativeContact",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "PER",  Min = 0,  Max = 10000,  Name = "Premium Payer's Administrative Contact",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Contact Function Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_366" },
                                            new Element { Name = "Name", IsOptional = false, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
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
                            Name = "TS820_1000C_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "N1_IntermediaryBankInformation",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "N1",  Min = 1,  Max = 1,  Name = "Intermediary Bank Information",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                            new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
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
                                    Name = "N2_IntermediaryBankAdditionalName",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "N2",  Min = 0,  Max = 1,  Name = "Intermediary Bank Additional Name",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Name", IsOptional = false, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Name", IsOptional = true, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
                                        }
                                    } // end of "N2"
                                }
                                ,
                                new Node
                                {
                                    Name = "N3_IntermediaryBank_sAddress",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "N3",  Min = 0,  Max = 1,  Name = "Intermediary Bank's Address",
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
                                    Name = "N4_IntermediaryBank_sCity_State_ZIPCode",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "N4",  Min = 0,  Max = 1,  Name = "Intermediary Bank's City, State, ZIP Code",
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
                                    Name = "PER_IntermediaryBank_sAdministrativeContact",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "PER",  Min = 0,  Max = 10000,  Name = "Intermediary Bank's Administrative Contact",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Contact Function Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_366" },
                                            new Element { Name = "Name", IsOptional = false, LengthMin = 1, LengthMax = 60, Type = "string", Value = "null", CodeTable = "null" },
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
                new Node
                {
                    Name = "ENT_SubLoop",  IsOptional = false,
                    Nodes = new Node[]
                    {
                        new Node
                        {
                            Name = "TS820_2000A_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "ENT_OrganizationSummaryRemittance",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "ENT",  Min = 1,  Max = 1,  Name = "Organization Summary Remittance",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Assigned Number", IsOptional = false, LengthMin = 1, LengthMax = 6, Type = "int", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                            new Element { Name = "Identification Code Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                            new Element { Name = "Identification Code", IsOptional = false, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Entity Identifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                            new Element { Name = "Identification Code Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                            new Element { Name = "Identification Code", IsOptional = true, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Reference Identification Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                        }
                                    } // end of "ENT"
                                }
                                ,
                                new Node
                                {
                                    Name = "TS820_2200A_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "ADX_OrganizationSummaryRemittanceLevelAdjustmentforPreviousPayment",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "ADX",  Min = 1,  Max = 1,  Name = "Organization Summary Remittance Level Adjustment for Previous Payment",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Adjustment Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_426" },
                                                    new Element { Name = "Reference Identification Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "ADX"
                                        }
                                        ,
                                    },
                                }
                                ,
                                new Node
                                {
                                    Name = "TS820_2300A_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "RMR_OrganizationSummaryRemittanceDetail",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "RMR",  Min = 1,  Max = 1,  Name = "Organization Summary Remittance Detail",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Reference Identification Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                                    new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Payment Action Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_482" },
                                                    new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Adjustment Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_426" },
                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "RMR"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "REF_ReferenceInformation",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "REF",  Min = 0,  Max = 10000,  Name = "Reference Information",
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
                                            Name = "DTM_OrganizationalCoveragePeriod",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "DTM",  Min = 0,  Max = 1,  Name = "Organizational Coverage Period",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Date/Time Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_374" },
                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Time", IsOptional = true, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_623" },
                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                    new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "DTM"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "TS820_2310A_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "IT1_SummaryLineItem",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "IT1",  Min = 1,  Max = 1,  Name = "Summary Line Item",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Assigned Identification", IsOptional = false, LengthMin = 1, LengthMax = 20, Type = "string", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Quantity Invoiced", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                            new Element { Name = "Unit Price", IsOptional = true, LengthMin = 1, LengthMax = 17, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Basis of Unit Price Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_639" },
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
                                                    } // end of "IT1"
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "TS820_2312A_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "SAC_Service_Promotion_Allowance_orChargeInformation",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "SAC",  Min = 1,  Max = 1,  Name = "Service, Promotion, Allowance, or Charge Information",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Allowance or Charge Indicator", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_248" },
                                                                    new Element { Name = "Service, Promotion, Allowance, or Charge Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1300" },
                                                                    new Element { Name = "Agency Qualifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_559" },
                                                                    new Element { Name = "Agency Service, Promotion, Allowance, or Charge Code", IsOptional = true, LengthMin = 1, LengthMax = 10, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Amount", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Allowance/Charge Percent Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_378" },
                                                                    new Element { Name = "Percent, Decimal Format", IsOptional = true, LengthMin = 1, LengthMax = 6, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Rate", IsOptional = true, LengthMin = 1, LengthMax = 9, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Unit or Basis for Measurement Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_355" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Quantity", IsOptional = true, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Allowance or Charge Method of Handling Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_331" },
                                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Option Number", IsOptional = true, LengthMin = 1, LengthMax = 20, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Description", IsOptional = true, LengthMin = 1, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Language Code", IsOptional = true, LengthMin = 2, LengthMax = 3, Type = "code", Value = "null", CodeTable = "Table_10819" },
                                                                }
                                                            } // end of "SAC"
                                                        }
                                                        ,
                                                    },
                                                }
                                                ,
                                                new Node
                                                {
                                                    Name = "TS820_2315A_Loop",  IsOptional = false,
                                                    Nodes = new Node[]
                                                    {
                                                        new Node
                                                        {
                                                            Name = "SLN_MemberCount",  IsOptional = false,
                                                            Segment = new Segment
                                                            {
                                                                Tag = "SLN",  Min = 1,  Max = 1,  Name = "Member Count",
                                                                Elements = new[]
                                                                {
                                                                    new Element { Name = "Assigned Identification", IsOptional = false, LengthMin = 1, LengthMax = 20, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Assigned Identification", IsOptional = true, LengthMin = 1, LengthMax = 20, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Relationship Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_662" },
                                                                    new Element { Name = "Quantity", IsOptional = false, LengthMin = 1, LengthMax = 15, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "string", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Unit Price", IsOptional = true, LengthMin = 1, LengthMax = 17, Type = "decimal", Value = "null", CodeTable = "null" },
                                                                    new Element { Name = "Basis of Unit Price Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_639" },
                                                                    new Element { Name = "Relationship Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_662" },
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
                                                            } // end of "SLN"
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
                                            Name = "TS820_2320A_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "ADX_OrganizationSummaryRemittanceLevelAdjustmentforCurrentPayment",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "ADX",  Min = 1,  Max = 1,  Name = "Organization Summary Remittance Level Adjustment for Current Payment",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Adjustment Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_426" },
                                                            new Element { Name = "Reference Identification Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "ADX"
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
                            Name = "TS820_2000B_Loop",  IsOptional = false,
                            Nodes = new Node[]
                            {
                                new Node
                                {
                                    Name = "ENT_IndividualRemittance",  IsOptional = false,
                                    Segment = new Segment
                                    {
                                        Tag = "ENT",  Min = 1,  Max = 1,  Name = "Individual Remittance",
                                        Elements = new[]
                                        {
                                            new Element { Name = "Assigned Number", IsOptional = false, LengthMin = 1, LengthMax = 6, Type = "int", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Entity Identifier Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                            new Element { Name = "Identification Code Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                            new Element { Name = "Identification Code", IsOptional = false, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Entity Identifier Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_98" },
                                            new Element { Name = "Identification Code Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_66" },
                                            new Element { Name = "Identification Code", IsOptional = true, LengthMin = 2, LengthMax = 80, Type = "string", Value = "null", CodeTable = "null" },
                                            new Element { Name = "Reference Identification Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                        }
                                    } // end of "ENT"
                                }
                                ,
                                new Node
                                {
                                    Name = "TS820_2100B_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "NM1_IndividualName",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "NM1",  Min = 1,  Max = 1,  Name = "Individual Name",
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
                                    },
                                }
                                ,
                                new Node
                                {
                                    Name = "TS820_2200B_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "ADX_IndividualPremiumAdjustmentforPreviousPayment",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "ADX",  Min = 1,  Max = 1,  Name = "Individual Premium Adjustment for Previous Payment",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Adjustment Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_426" },
                                                    new Element { Name = "Reference Identification Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                                    new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "ADX"
                                        }
                                        ,
                                    },
                                }
                                ,
                                new Node
                                {
                                    Name = "TS820_2300B_Loop",  IsOptional = false,
                                    Nodes = new Node[]
                                    {
                                        new Node
                                        {
                                            Name = "RMR_IndividualPremiumRemittanceDetail",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "RMR",  Min = 1,  Max = 1,  Name = "Individual Premium Remittance Detail",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Reference Identification Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                                    new Element { Name = "Reference Identification", IsOptional = false, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Payment Action Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_482" },
                                                    new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Adjustment Reason Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_426" },
                                                    new Element { Name = "Monetary Amount", IsOptional = true, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "RMR"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "REF_ReferenceInformation_2",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "REF",  Min = 0,  Max = 10000,  Name = "Reference Information",
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
                                            Name = "DTM_IndividualCoveragePeriod",  IsOptional = false,
                                            Segment = new Segment
                                            {
                                                Tag = "DTM",  Min = 0,  Max = 1,  Name = "Individual Coverage Period",
                                                Elements = new[]
                                                {
                                                    new Element { Name = "Date/Time Qualifier", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_374" },
                                                    new Element { Name = "Date", IsOptional = true, LengthMin = 8, LengthMax = 8, Type = "date", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Time", IsOptional = true, LengthMin = 4, LengthMax = 8, Type = "time", Value = "null", CodeTable = "null" },
                                                    new Element { Name = "Time Code", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_623" },
                                                    new Element { Name = "Date Time Period Format Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_1250" },
                                                    new Element { Name = "Date Time Period", IsOptional = true, LengthMin = 1, LengthMax = 35, Type = "string", Value = "null", CodeTable = "null" },
                                                }
                                            } // end of "DTM"
                                        }
                                        ,
                                        new Node
                                        {
                                            Name = "TS820_2320B_Loop",  IsOptional = false,
                                            Nodes = new Node[]
                                            {
                                                new Node
                                                {
                                                    Name = "ADX_IndividualPremiumAdjustmentforCurrentPayment",  IsOptional = false,
                                                    Segment = new Segment
                                                    {
                                                        Tag = "ADX",  Min = 1,  Max = 1,  Name = "Individual Premium Adjustment for Current Payment",
                                                        Elements = new[]
                                                        {
                                                            new Element { Name = "Monetary Amount", IsOptional = false, LengthMin = 1, LengthMax = 18, Type = "decimal", Value = "null", CodeTable = "null" },
                                                            new Element { Name = "Adjustment Reason Code", IsOptional = false, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_426" },
                                                            new Element { Name = "Reference Identification Qualifier", IsOptional = true, LengthMin = 0, LengthMax = 0, Type = "code", Value = "null", CodeTable = "Table_128" },
                                                            new Element { Name = "Reference Identification", IsOptional = true, LengthMin = 1, LengthMax = 50, Type = "string", Value = "null", CodeTable = "null" },
                                                        }
                                                    } // end of "ADX"
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
    } // end of "X12_00501_820"
}
