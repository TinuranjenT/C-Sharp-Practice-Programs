using System.Xml.Serialization;

namespace XmlSerializationAndDeSerialization1
{
    public class Convert
    {
        public static void ObjectToXML(Loans loans, string filePath)
        {
            XmlAttributeOverrides overrides = new XmlAttributeOverrides();
            XmlAttributes xmlAttributes = new XmlAttributes();
            xmlAttributes.XmlIgnore = true;
            overrides.Add(typeof(AmortizationRule), "AmortizationType", xmlAttributes);
            overrides.Add(typeof(UrlaDetail), "EstimatedClosingCostsAmount", xmlAttributes);

            XmlSerializer serializer = new XmlSerializer(typeof(Loans), overrides);

            FileStream fileStream = new FileStream(filePath, FileMode.Create);
            serializer.Serialize(fileStream, loans);
            fileStream.Close();

        }

        public static Loans XMLToObject(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Loans));
            FileStream fileStream = new FileStream(filePath, FileMode.Open);
            return (Loans)serializer.Deserialize(fileStream);

        }
    }
     public class Program
    {
        static void Main(string[] args)
        {
            Loans loans = new Loans
            {
                Loan = new[]
                 {
                    new Loan
                    {
                        Adjustment = new Adjustment
                        {
                            InterestRateAdjustment = new InterestRateAdjustment
                            {
                                InterestRateLifetimeAdjustmentRule = new InterestRateLifetimeAdjustmentRule
                                {
                                    InterestRateAdjustmentCalculationMethodType = "AddFixedPercentageToCurrentInterestRate",
                                    InterestRateLifetimeAdjustmentCeilingType = "AbsoluteRequiredCeiling",
                                    InterestRateLifetimeAdjustmentFloorType = "AbsoluteMinimumNetInterestRate",
                                    InterestRateRoundingType = "Down",
                                    LoanMarginCalculationMethodType = "BasedOnProduct",
                                    MarginRatePercent = 1.000m
                                }
                            }
                        },
                        Amortization = new Amortization
                        {
                            AmortizationRule = new AmortizationRule
                            {
                                AmortizationType = "AdjustableRate",
                                LoanAmortizationPeriodCount = 360,
                                LoanAmortizationPeriodType = "Month",
                                Extension = null
                            }
                        },
                        DocumentSpecificDataSets = new[]
                        {
                            new DocumentSpecificDataSet
                            {
                                Urla = new Urla
                                {
                                    UrlaDetail = new UrlaDetail
                                    {
                                        ApplicationSignedByLoanOriginatorDate = DateTime.Parse("2023-04-07"),
                                        EstimatedClosingCostsAmount = 1800.00m,
                                        MIAndFundingFeeFinancedAmount = 2493.00m,
                                        MIAndFundingFeeTotalAmount = 2493.00m,
                                        PrepaidItemsEstimatedAmount = 799.00m
                                    }
                                },
                                DocumentClasses = new string[]{}
                            }
                        },
                        GovernmentLoan = new GovernmentLoan
                        {
                            FHALoanLenderIdentifier = 9999999999,
                            GovernmentMortgageCreditCertificateAmount = 150.00m,
                            SectionOfActType = "203B251"
                        },
                        HousingExpenses = new[]
                        {
                            new HousingExpense
                            {
                                ExpenseNumber = "1",
                                HousingExpensePaymentAmount = 631.02m,
                                HousingExpenseTimingType = "Proposed",
                                HousingExpenseType = "FirstMortgagePrincipalAndInterest",
                                HousingExpenseTypeOtherDescription = null,
                            },
                            new HousingExpense
                            {
                                ExpenseNumber = "2",
                                HousingExpensePaymentAmount = 35.00m,
                                HousingExpenseTimingType = "Proposed",
                                HousingExpenseType = "HomeownersAssociationDuesAndCondominiumFees",
                                HousingExpenseTypeOtherDescription = null,
                            },
                            new HousingExpense
                            {
                                ExpenseNumber = "3",
                                HousingExpensePaymentAmount = 86.00m,
                                HousingExpenseTimingType = "Proposed",
                                HousingExpenseType = "RealEstateTax",
                                HousingExpenseTypeOtherDescription = null,
                            },
                            new HousingExpense
                            {
                                ExpenseNumber = "4",
                                HousingExpensePaymentAmount = 27.00m,
                                HousingExpenseTimingType = "Proposed",
                                HousingExpenseType = "OtherMortgageLoanPrincipalAndInterest",
                                HousingExpenseTypeOtherDescription = null,
                            },
                             new HousingExpense
                            {
                                ExpenseNumber = "5",
                                HousingExpensePaymentAmount = 50.00m,
                                HousingExpenseTimingType = "Proposed",
                                HousingExpenseType = "Other",
                                HousingExpenseTypeOtherDescription = "OTHER",
                            },
                            new HousingExpense
                            {
                                ExpenseNumber = "6",
                                HousingExpensePaymentAmount = 53.00m,
                                HousingExpenseTimingType = "Proposed",
                                HousingExpenseType = "HomeownersInsurance",
                                HousingExpenseTypeOtherDescription = null,
                            },
                             new HousingExpense
                            {
                                ExpenseNumber = "7",
                                HousingExpensePaymentAmount = 46.00m,
                                HousingExpenseTimingType = "Proposed",
                                HousingExpenseType = "MIPremium",
                                HousingExpenseTypeOtherDescription = null,
                            },

                        },
                        InvestorLoanInformation = new InvestorLoanInformation
                        {
                            InvestorProductPlanIdentifier = "FHAHY"
                        },
                        LoanDetail = new LoanDetail
                        {
                            BalloonIndicator = false,
                            BuydownTemporarySubsidyFundingIndicator = false,
                            ConstructionLoanIndicator = false,
                            ConversionOfContractForDeedIndicator = false,
                            EnergyRelatedImprovementsIndicator = false,
                            InterestOnlyIndicator = false,
                            NegativeAmortizationIndicator = false,
                            PrepaymentPenaltyIndicator = false,
                            TotalMortgagedPropertiesCount = 1,
                            TotalSubordinateFinancingAmount = 4500.00m
                        },
                        TermsOfLoan = new TermsOfLoan
                        {
                            BaseLoanAmount = 142500.00m,
                            DisclosedIndexRatePercent = 2.500m,
                            LienPriorityType = "FirstLien",
                            LoanPurposeType = "Purchase",
                            MortgageType = "FHA",
                            NoteRatePercent = 3.250m
                        }
                    }
                }
            };

            string filePath = @"C:\\Users\\tinu\\Documents\\Loan.XML";

            Convert.ObjectToXML(loans, filePath);
            Console.WriteLine("Serialization Completed");

            Loans deSerializedLoans = Convert.XMLToObject(filePath);

            foreach(var loan in deSerializedLoans.Loan)
            {
                Console.WriteLine("Loan");
                Console.WriteLine($"MarginRatePercent: {loan.Adjustment.InterestRateAdjustment.InterestRateLifetimeAdjustmentRule.MarginRatePercent}");
                Console.WriteLine($"AmortizationType:, {loan.Amortization.AmortizationRule.AmortizationType}");
                Console.WriteLine($"EstimatedClosingCostsAmount:, {loan.DocumentSpecificDataSets[0].Urla.UrlaDetail.EstimatedClosingCostsAmount}");
              

            }
            
           
        }
    }
}