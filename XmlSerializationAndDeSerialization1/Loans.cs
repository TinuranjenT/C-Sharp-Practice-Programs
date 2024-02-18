using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializationAndDeSerialization1
{ 

        [XmlRoot("LOANS")]
        public class Loans
        {
            [XmlElement("LOAN")]
            public Loan[] Loan { get; set; }
        }

        public class Loan
        {
            public Adjustment Adjustment { get; set; }
            public Amortization Amortization { get; set; }

            [XmlElement("DOCUMENT_SPECIFIC_DATA_SETS")]
            public DocumentSpecificDataSet[] DocumentSpecificDataSets { get; set; }
            public GovernmentLoan GovernmentLoan { get; set; }

            [XmlArray("HOUSING_EXPENSES")]
            [XmlArrayItem("HOUSING_EXPENSE")]
            public HousingExpense[] HousingExpenses { get; set; }
            public InvestorLoanInformation InvestorLoanInformation { get; set; }
            public LoanDetail LoanDetail { get; set; }
            public TermsOfLoan TermsOfLoan { get; set; }
        }

        public class Adjustment
        {
        [XmlElement("INTEREST_RATE_ADJUSTMENT")]
        public InterestRateAdjustment InterestRateAdjustment { get; set; }
        }

        public class InterestRateAdjustment
        {
            public InterestRateLifetimeAdjustmentRule InterestRateLifetimeAdjustmentRule { get; set; }
        }
   
    public class InterestRateLifetimeAdjustmentRule
    { 
            public string InterestRateAdjustmentCalculationMethodType { get; set; }
            public string InterestRateLifetimeAdjustmentCeilingType { get; set; }
            public string InterestRateLifetimeAdjustmentFloorType { get; set; }
            public string InterestRateRoundingType { get; set; }
            public string LoanMarginCalculationMethodType { get; set; }
            public decimal MarginRatePercent { get; set; }
        }

        public class Amortization
        {
            [XmlElement("AMORTIZATION_RULE")]
            public AmortizationRule AmortizationRule { get; set; }
        }

        public class AmortizationRule
        {
            //[XmlIgnore]
            public string AmortizationType { get; set; }
            public int LoanAmortizationPeriodCount { get; set; }
            public string LoanAmortizationPeriodType { get; set; }
            public string Extension { get; set; }


    }

        public class DocumentSpecificDataSet
        {
            public Urla Urla { get; set; }
            public string[] DocumentClasses { get; set; }
        }

        public class Urla
        {
            [XmlElement("URLA_DETAIL")]
            public UrlaDetail UrlaDetail { get; set; }
            public string UrlaTotal { get; set; }
            public string UrlaTotalHousingExpenses { get; set; }
        }

    public class UrlaDetail
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        public DateTime ApplicationSignedByLoanOriginatorDate { get; set; }
        //[XmlIgnore]
        public decimal EstimatedClosingCostsAmount { get; set; }
        public decimal MIAndFundingFeeFinancedAmount { get; set; }
        public decimal MIAndFundingFeeTotalAmount { get; set; }
        public decimal PrepaidItemsEstimatedAmount { get; set; }
     }
        
        public class GovernmentLoan
        {
            public long FHALoanLenderIdentifier { get; set; }
            public decimal GovernmentMortgageCreditCertificateAmount { get; set; }
            public string SectionOfActType { get; set; }
        }

        public class HousingExpense
        {
            [XmlAttribute("expense_number")]
            public string ExpenseNumber {  get; set; } 
            public decimal HousingExpensePaymentAmount { get; set; }
            public string HousingExpenseTimingType { get; set; }
            public string HousingExpenseType { get; set; }
            public string HousingExpenseTypeOtherDescription { get; set; }
        }

        public class InvestorLoanInformation
        {
            public string InvestorProductPlanIdentifier { get; set; }
        }

        public class LoanDetail
        {
            public bool BalloonIndicator { get; set; }
            public bool BuydownTemporarySubsidyFundingIndicator { get; set; }
            public bool ConstructionLoanIndicator { get; set; }
            public bool ConversionOfContractForDeedIndicator { get; set; }
            public bool EnergyRelatedImprovementsIndicator { get; set; }
            public bool InterestOnlyIndicator { get; set; }
            public bool NegativeAmortizationIndicator { get; set; }
            public bool PrepaymentPenaltyIndicator { get; set; }
            public int TotalMortgagedPropertiesCount { get; set; }
            public decimal TotalSubordinateFinancingAmount { get; set; }
        }

        public class TermsOfLoan
        {
            public decimal BaseLoanAmount { get; set; }
            public decimal DisclosedIndexRatePercent { get; set; }
            public string LienPriorityType { get; set; }
            public string LoanPurposeType { get; set; }
            public string MortgageType { get; set; }
            public decimal NoteRatePercent { get; set; }
        }
    public class OriginationFunds
    {
        public OriginationFund OriginationFund { get; set; }
    }

    public class OriginationFund
    {
        public string FundsSourceType { get; set; }
    }

    public class Payment
    {
        public PaymentRule PaymentRule { get; set; }
    }

    public class PaymentRule
    {
        public decimal InitialPrincipalAndInterestPaymentAmount { get; set; }
    }

}
