// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class LOANS
{

    private LOANSLOAN lOANField;

    private LOANSLOAN_DETAIL lOAN_DETAILField;

    private LOANSORIGINATION_FUNDS oRIGINATION_FUNDSField;

    private LOANSPAYMENT pAYMENTField;

    private LOANSTERMS_OF_LOAN tERMS_OF_LOANField;

    /// <remarks/>
    public LOANSLOAN LOAN
    {
        get
        {
            return this.lOANField;
        }
        set
        {
            this.lOANField = value;
        }
    }

    /// <remarks/>
    public LOANSLOAN_DETAIL LOAN_DETAIL
    {
        get
        {
            return this.lOAN_DETAILField;
        }
        set
        {
            this.lOAN_DETAILField = value;
        }
    }

    /// <remarks/>
    public LOANSORIGINATION_FUNDS ORIGINATION_FUNDS
    {
        get
        {
            return this.oRIGINATION_FUNDSField;
        }
        set
        {
            this.oRIGINATION_FUNDSField = value;
        }
    }

    /// <remarks/>
    public LOANSPAYMENT PAYMENT
    {
        get
        {
            return this.pAYMENTField;
        }
        set
        {
            this.pAYMENTField = value;
        }
    }

    /// <remarks/>
    public LOANSTERMS_OF_LOAN TERMS_OF_LOAN
    {
        get
        {
            return this.tERMS_OF_LOANField;
        }
        set
        {
            this.tERMS_OF_LOANField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOAN
{

    private LOANSLOANADJUSTMENT aDJUSTMENTField;

    private LOANSLOANAMORTIZATION aMORTIZATIONField;

    private LOANSLOANDOCUMENT_SPECIFIC_DATA_SETS dOCUMENT_SPECIFIC_DATA_SETSField;

    private LOANSLOANGOVERNMENT_LOAN gOVERNMENT_LOANField;

    private LOANSLOANHOUSING_EXPENSES hOUSING_EXPENSESField;

    private LOANSLOANINVESTOR_LOAN_INFORMATION iNVESTOR_LOAN_INFORMATIONField;

    private LOANSLOANLOAN_DETAIL lOAN_DETAILField;

    private LOANSLOANTERMS_OF_LOAN tERMS_OF_LOANField;

    /// <remarks/>
    public LOANSLOANADJUSTMENT ADJUSTMENT
    {
        get
        {
            return this.aDJUSTMENTField;
        }
        set
        {
            this.aDJUSTMENTField = value;
        }
    }

    /// <remarks/>
    public LOANSLOANAMORTIZATION AMORTIZATION
    {
        get
        {
            return this.aMORTIZATIONField;
        }
        set
        {
            this.aMORTIZATIONField = value;
        }
    }

    /// <remarks/>
    public LOANSLOANDOCUMENT_SPECIFIC_DATA_SETS DOCUMENT_SPECIFIC_DATA_SETS
    {
        get
        {
            return this.dOCUMENT_SPECIFIC_DATA_SETSField;
        }
        set
        {
            this.dOCUMENT_SPECIFIC_DATA_SETSField = value;
        }
    }

    /// <remarks/>
    public LOANSLOANGOVERNMENT_LOAN GOVERNMENT_LOAN
    {
        get
        {
            return this.gOVERNMENT_LOANField;
        }
        set
        {
            this.gOVERNMENT_LOANField = value;
        }
    }

    /// <remarks/>
    public LOANSLOANHOUSING_EXPENSES HOUSING_EXPENSES
    {
        get
        {
            return this.hOUSING_EXPENSESField;
        }
        set
        {
            this.hOUSING_EXPENSESField = value;
        }
    }

    /// <remarks/>
    public LOANSLOANINVESTOR_LOAN_INFORMATION INVESTOR_LOAN_INFORMATION
    {
        get
        {
            return this.iNVESTOR_LOAN_INFORMATIONField;
        }
        set
        {
            this.iNVESTOR_LOAN_INFORMATIONField = value;
        }
    }

    /// <remarks/>
    public LOANSLOANLOAN_DETAIL LOAN_DETAIL
    {
        get
        {
            return this.lOAN_DETAILField;
        }
        set
        {
            this.lOAN_DETAILField = value;
        }
    }

    /// <remarks/>
    public LOANSLOANTERMS_OF_LOAN TERMS_OF_LOAN
    {
        get
        {
            return this.tERMS_OF_LOANField;
        }
        set
        {
            this.tERMS_OF_LOANField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOANADJUSTMENT
{

    private LOANSLOANADJUSTMENTINTEREST_RATE_ADJUSTMENT iNTEREST_RATE_ADJUSTMENTField;

    /// <remarks/>
    public LOANSLOANADJUSTMENTINTEREST_RATE_ADJUSTMENT INTEREST_RATE_ADJUSTMENT
    {
        get
        {
            return this.iNTEREST_RATE_ADJUSTMENTField;
        }
        set
        {
            this.iNTEREST_RATE_ADJUSTMENTField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOANADJUSTMENTINTEREST_RATE_ADJUSTMENT
{

    private LOANSLOANADJUSTMENTINTEREST_RATE_ADJUSTMENTINTEREST_RATE_LIFETIME_ADJUSTMENT_RULE iNTEREST_RATE_LIFETIME_ADJUSTMENT_RULEField;

    /// <remarks/>
    public LOANSLOANADJUSTMENTINTEREST_RATE_ADJUSTMENTINTEREST_RATE_LIFETIME_ADJUSTMENT_RULE INTEREST_RATE_LIFETIME_ADJUSTMENT_RULE
    {
        get
        {
            return this.iNTEREST_RATE_LIFETIME_ADJUSTMENT_RULEField;
        }
        set
        {
            this.iNTEREST_RATE_LIFETIME_ADJUSTMENT_RULEField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOANADJUSTMENTINTEREST_RATE_ADJUSTMENTINTEREST_RATE_LIFETIME_ADJUSTMENT_RULE
{

    private string interestRateAdjustmentCalculationMethodTypeField;

    private string interestRateLifetimeAdjustmentCeilingTypeField;

    private string interestRateLifetimeAdjustmentFloorTypeField;

    private string interestRateRoundingTypeField;

    private string loanMarginCalculationMethodTypeField;

    private decimal marginRatePercentField;

    /// <remarks/>
    public string InterestRateAdjustmentCalculationMethodType
    {
        get
        {
            return this.interestRateAdjustmentCalculationMethodTypeField;
        }
        set
        {
            this.interestRateAdjustmentCalculationMethodTypeField = value;
        }
    }

    /// <remarks/>
    public string InterestRateLifetimeAdjustmentCeilingType
    {
        get
        {
            return this.interestRateLifetimeAdjustmentCeilingTypeField;
        }
        set
        {
            this.interestRateLifetimeAdjustmentCeilingTypeField = value;
        }
    }

    /// <remarks/>
    public string InterestRateLifetimeAdjustmentFloorType
    {
        get
        {
            return this.interestRateLifetimeAdjustmentFloorTypeField;
        }
        set
        {
            this.interestRateLifetimeAdjustmentFloorTypeField = value;
        }
    }

    /// <remarks/>
    public string InterestRateRoundingType
    {
        get
        {
            return this.interestRateRoundingTypeField;
        }
        set
        {
            this.interestRateRoundingTypeField = value;
        }
    }

    /// <remarks/>
    public string LoanMarginCalculationMethodType
    {
        get
        {
            return this.loanMarginCalculationMethodTypeField;
        }
        set
        {
            this.loanMarginCalculationMethodTypeField = value;
        }
    }

    /// <remarks/>
    public decimal MarginRatePercent
    {
        get
        {
            return this.marginRatePercentField;
        }
        set
        {
            this.marginRatePercentField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOANAMORTIZATION
{

    private LOANSLOANAMORTIZATIONAMORTIZATION_RULE aMORTIZATION_RULEField;

    /// <remarks/>
    public LOANSLOANAMORTIZATIONAMORTIZATION_RULE AMORTIZATION_RULE
    {
        get
        {
            return this.aMORTIZATION_RULEField;
        }
        set
        {
            this.aMORTIZATION_RULEField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOANAMORTIZATIONAMORTIZATION_RULE
{

    private string amortizationTypeField;

    private ushort loanAmortizationPeriodCountField;

    private string loanAmortizationPeriodTypeField;

    private object eXTENSIONField;

    /// <remarks/>
    public string AmortizationType
    {
        get
        {
            return this.amortizationTypeField;
        }
        set
        {
            this.amortizationTypeField = value;
        }
    }

    /// <remarks/>
    public ushort LoanAmortizationPeriodCount
    {
        get
        {
            return this.loanAmortizationPeriodCountField;
        }
        set
        {
            this.loanAmortizationPeriodCountField = value;
        }
    }

    /// <remarks/>
    public string LoanAmortizationPeriodType
    {
        get
        {
            return this.loanAmortizationPeriodTypeField;
        }
        set
        {
            this.loanAmortizationPeriodTypeField = value;
        }
    }

    /// <remarks/>
    public object EXTENSION
    {
        get
        {
            return this.eXTENSIONField;
        }
        set
        {
            this.eXTENSIONField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOANDOCUMENT_SPECIFIC_DATA_SETS
{

    private LOANSLOANDOCUMENT_SPECIFIC_DATA_SETSDOCUMENT_SPECIFIC_DATA_SET dOCUMENT_SPECIFIC_DATA_SETField;

    /// <remarks/>
    public LOANSLOANDOCUMENT_SPECIFIC_DATA_SETSDOCUMENT_SPECIFIC_DATA_SET DOCUMENT_SPECIFIC_DATA_SET
    {
        get
        {
            return this.dOCUMENT_SPECIFIC_DATA_SETField;
        }
        set
        {
            this.dOCUMENT_SPECIFIC_DATA_SETField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOANDOCUMENT_SPECIFIC_DATA_SETSDOCUMENT_SPECIFIC_DATA_SET
{

    private LOANSLOANDOCUMENT_SPECIFIC_DATA_SETSDOCUMENT_SPECIFIC_DATA_SETURLA uRLAField;

    private object dOCUMENT_CLASSESField;

    /// <remarks/>
    public LOANSLOANDOCUMENT_SPECIFIC_DATA_SETSDOCUMENT_SPECIFIC_DATA_SETURLA URLA
    {
        get
        {
            return this.uRLAField;
        }
        set
        {
            this.uRLAField = value;
        }
    }

    /// <remarks/>
    public object DOCUMENT_CLASSES
    {
        get
        {
            return this.dOCUMENT_CLASSESField;
        }
        set
        {
            this.dOCUMENT_CLASSESField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOANDOCUMENT_SPECIFIC_DATA_SETSDOCUMENT_SPECIFIC_DATA_SETURLA
{

    private LOANSLOANDOCUMENT_SPECIFIC_DATA_SETSDOCUMENT_SPECIFIC_DATA_SETURLAURLA_DETAIL uRLA_DETAILField;

    private object uRLA_TOTALField;

    private object uRLA_TOTAL_HOUSING_EXPENSESField;

    /// <remarks/>
    public LOANSLOANDOCUMENT_SPECIFIC_DATA_SETSDOCUMENT_SPECIFIC_DATA_SETURLAURLA_DETAIL URLA_DETAIL
    {
        get
        {
            return this.uRLA_DETAILField;
        }
        set
        {
            this.uRLA_DETAILField = value;
        }
    }

    /// <remarks/>
    public object URLA_TOTAL
    {
        get
        {
            return this.uRLA_TOTALField;
        }
        set
        {
            this.uRLA_TOTALField = value;
        }
    }

    /// <remarks/>
    public object URLA_TOTAL_HOUSING_EXPENSES
    {
        get
        {
            return this.uRLA_TOTAL_HOUSING_EXPENSESField;
        }
        set
        {
            this.uRLA_TOTAL_HOUSING_EXPENSESField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOANDOCUMENT_SPECIFIC_DATA_SETSDOCUMENT_SPECIFIC_DATA_SETURLAURLA_DETAIL
{

    private System.DateTime applicationSignedByLoanOriginatorDateField;

    private decimal estimatedClosingCostsAmountField;

    private decimal mIAndFundingFeeFinancedAmountField;

    private decimal mIAndFundingFeeTotalAmountField;

    private decimal prepaidItemsEstimatedAmountField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ApplicationSignedByLoanOriginatorDate
    {
        get
        {
            return this.applicationSignedByLoanOriginatorDateField;
        }
        set
        {
            this.applicationSignedByLoanOriginatorDateField = value;
        }
    }

    /// <remarks/>
    public decimal EstimatedClosingCostsAmount
    {
        get
        {
            return this.estimatedClosingCostsAmountField;
        }
        set
        {
            this.estimatedClosingCostsAmountField = value;
        }
    }

    /// <remarks/>
    public decimal MIAndFundingFeeFinancedAmount
    {
        get
        {
            return this.mIAndFundingFeeFinancedAmountField;
        }
        set
        {
            this.mIAndFundingFeeFinancedAmountField = value;
        }
    }

    /// <remarks/>
    public decimal MIAndFundingFeeTotalAmount
    {
        get
        {
            return this.mIAndFundingFeeTotalAmountField;
        }
        set
        {
            this.mIAndFundingFeeTotalAmountField = value;
        }
    }

    /// <remarks/>
    public decimal PrepaidItemsEstimatedAmount
    {
        get
        {
            return this.prepaidItemsEstimatedAmountField;
        }
        set
        {
            this.prepaidItemsEstimatedAmountField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOANGOVERNMENT_LOAN
{

    private ulong fHALoanLenderIdentifierField;

    private decimal governmentMortgageCreditCertificateAmountField;

    private string sectionOfActTypeField;

    /// <remarks/>
    public ulong FHALoanLenderIdentifier
    {
        get
        {
            return this.fHALoanLenderIdentifierField;
        }
        set
        {
            this.fHALoanLenderIdentifierField = value;
        }
    }

    /// <remarks/>
    public decimal GovernmentMortgageCreditCertificateAmount
    {
        get
        {
            return this.governmentMortgageCreditCertificateAmountField;
        }
        set
        {
            this.governmentMortgageCreditCertificateAmountField = value;
        }
    }

    /// <remarks/>
    public string SectionOfActType
    {
        get
        {
            return this.sectionOfActTypeField;
        }
        set
        {
            this.sectionOfActTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOANHOUSING_EXPENSES
{

    private LOANSLOANHOUSING_EXPENSESHOUSING_EXPENSE[] hOUSING_EXPENSEField;

    private LOANSLOANHOUSING_EXPENSESHOUSING_EXPENSE_SUMMARY hOUSING_EXPENSE_SUMMARYField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("HOUSING_EXPENSE")]
    public LOANSLOANHOUSING_EXPENSESHOUSING_EXPENSE[] HOUSING_EXPENSE
    {
        get
        {
            return this.hOUSING_EXPENSEField;
        }
        set
        {
            this.hOUSING_EXPENSEField = value;
        }
    }

    /// <remarks/>
    public LOANSLOANHOUSING_EXPENSESHOUSING_EXPENSE_SUMMARY HOUSING_EXPENSE_SUMMARY
    {
        get
        {
            return this.hOUSING_EXPENSE_SUMMARYField;
        }
        set
        {
            this.hOUSING_EXPENSE_SUMMARYField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOANHOUSING_EXPENSESHOUSING_EXPENSE
{

    private decimal housingExpensePaymentAmountField;

    private string housingExpenseTimingTypeField;

    private string housingExpenseTypeField;

    private string housingExpenseTypeOtherDescriptionField;

    /// <remarks/>
    public decimal HousingExpensePaymentAmount
    {
        get
        {
            return this.housingExpensePaymentAmountField;
        }
        set
        {
            this.housingExpensePaymentAmountField = value;
        }
    }

    /// <remarks/>
    public string HousingExpenseTimingType
    {
        get
        {
            return this.housingExpenseTimingTypeField;
        }
        set
        {
            this.housingExpenseTimingTypeField = value;
        }
    }

    /// <remarks/>
    public string HousingExpenseType
    {
        get
        {
            return this.housingExpenseTypeField;
        }
        set
        {
            this.housingExpenseTypeField = value;
        }
    }

    /// <remarks/>
    public string HousingExpenseTypeOtherDescription
    {
        get
        {
            return this.housingExpenseTypeOtherDescriptionField;
        }
        set
        {
            this.housingExpenseTypeOtherDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOANHOUSING_EXPENSESHOUSING_EXPENSE_SUMMARY
{

    private decimal housingExpenseProposedTotalMonthlyPaymentAmountField;

    /// <remarks/>
    public decimal HousingExpenseProposedTotalMonthlyPaymentAmount
    {
        get
        {
            return this.housingExpenseProposedTotalMonthlyPaymentAmountField;
        }
        set
        {
            this.housingExpenseProposedTotalMonthlyPaymentAmountField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOANINVESTOR_LOAN_INFORMATION
{

    private string investorProductPlanIdentifierField;

    /// <remarks/>
    public string InvestorProductPlanIdentifier
    {
        get
        {
            return this.investorProductPlanIdentifierField;
        }
        set
        {
            this.investorProductPlanIdentifierField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOANLOAN_DETAIL
{

    private bool balloonIndicatorField;

    private bool buydownTemporarySubsidyFundingIndicatorField;

    private bool constructionLoanIndicatorField;

    private bool conversionOfContractForDeedIndicatorField;

    private bool energyRelatedImprovementsIndicatorField;

    private byte initialFixedPeriodEffectiveMonthsCountField;

    private bool interestOnlyIndicatorField;

    private bool negativeAmortizationIndicatorField;

    private bool prepaymentPenaltyIndicatorField;

    private byte totalMortgagedPropertiesCountField;

    private decimal totalSubordinateFinancingAmountField;

    /// <remarks/>
    public bool BalloonIndicator
    {
        get
        {
            return this.balloonIndicatorField;
        }
        set
        {
            this.balloonIndicatorField = value;
        }
    }

    /// <remarks/>
    public bool BuydownTemporarySubsidyFundingIndicator
    {
        get
        {
            return this.buydownTemporarySubsidyFundingIndicatorField;
        }
        set
        {
            this.buydownTemporarySubsidyFundingIndicatorField = value;
        }
    }

    /// <remarks/>
    public bool ConstructionLoanIndicator
    {
        get
        {
            return this.constructionLoanIndicatorField;
        }
        set
        {
            this.constructionLoanIndicatorField = value;
        }
    }

    /// <remarks/>
    public bool ConversionOfContractForDeedIndicator
    {
        get
        {
            return this.conversionOfContractForDeedIndicatorField;
        }
        set
        {
            this.conversionOfContractForDeedIndicatorField = value;
        }
    }

    /// <remarks/>
    public bool EnergyRelatedImprovementsIndicator
    {
        get
        {
            return this.energyRelatedImprovementsIndicatorField;
        }
        set
        {
            this.energyRelatedImprovementsIndicatorField = value;
        }
    }

    /// <remarks/>
    public byte InitialFixedPeriodEffectiveMonthsCount
    {
        get
        {
            return this.initialFixedPeriodEffectiveMonthsCountField;
        }
        set
        {
            this.initialFixedPeriodEffectiveMonthsCountField = value;
        }
    }

    /// <remarks/>
    public bool InterestOnlyIndicator
    {
        get
        {
            return this.interestOnlyIndicatorField;
        }
        set
        {
            this.interestOnlyIndicatorField = value;
        }
    }

    /// <remarks/>
    public bool NegativeAmortizationIndicator
    {
        get
        {
            return this.negativeAmortizationIndicatorField;
        }
        set
        {
            this.negativeAmortizationIndicatorField = value;
        }
    }

    /// <remarks/>
    public bool PrepaymentPenaltyIndicator
    {
        get
        {
            return this.prepaymentPenaltyIndicatorField;
        }
        set
        {
            this.prepaymentPenaltyIndicatorField = value;
        }
    }

    /// <remarks/>
    public byte TotalMortgagedPropertiesCount
    {
        get
        {
            return this.totalMortgagedPropertiesCountField;
        }
        set
        {
            this.totalMortgagedPropertiesCountField = value;
        }
    }

    /// <remarks/>
    public decimal TotalSubordinateFinancingAmount
    {
        get
        {
            return this.totalSubordinateFinancingAmountField;
        }
        set
        {
            this.totalSubordinateFinancingAmountField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOANTERMS_OF_LOAN
{

    private decimal baseLoanAmountField;

    private decimal disclosedIndexRatePercentField;

    private string lienPriorityTypeField;

    private string loanPurposeTypeField;

    private string mortgageTypeField;

    private decimal noteRatePercentField;

    /// <remarks/>
    public decimal BaseLoanAmount
    {
        get
        {
            return this.baseLoanAmountField;
        }
        set
        {
            this.baseLoanAmountField = value;
        }
    }

    /// <remarks/>
    public decimal DisclosedIndexRatePercent
    {
        get
        {
            return this.disclosedIndexRatePercentField;
        }
        set
        {
            this.disclosedIndexRatePercentField = value;
        }
    }

    /// <remarks/>
    public string LienPriorityType
    {
        get
        {
            return this.lienPriorityTypeField;
        }
        set
        {
            this.lienPriorityTypeField = value;
        }
    }

    /// <remarks/>
    public string LoanPurposeType
    {
        get
        {
            return this.loanPurposeTypeField;
        }
        set
        {
            this.loanPurposeTypeField = value;
        }
    }

    /// <remarks/>
    public string MortgageType
    {
        get
        {
            return this.mortgageTypeField;
        }
        set
        {
            this.mortgageTypeField = value;
        }
    }

    /// <remarks/>
    public decimal NoteRatePercent
    {
        get
        {
            return this.noteRatePercentField;
        }
        set
        {
            this.noteRatePercentField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSLOAN_DETAIL
{

    private bool balloonIndicatorField;

    private bool buydownTemporarySubsidyFundingIndicatorField;

    private bool constructionLoanIndicatorField;

    private bool conversionOfContractForDeedIndicatorField;

    private bool energyRelatedImprovementsIndicatorField;

    private bool interestOnlyIndicatorField;

    private bool negativeAmortizationIndicatorField;

    private bool prepaymentPenaltyIndicatorField;

    /// <remarks/>
    public bool BalloonIndicator
    {
        get
        {
            return this.balloonIndicatorField;
        }
        set
        {
            this.balloonIndicatorField = value;
        }
    }

    /// <remarks/>
    public bool BuydownTemporarySubsidyFundingIndicator
    {
        get
        {
            return this.buydownTemporarySubsidyFundingIndicatorField;
        }
        set
        {
            this.buydownTemporarySubsidyFundingIndicatorField = value;
        }
    }

    /// <remarks/>
    public bool ConstructionLoanIndicator
    {
        get
        {
            return this.constructionLoanIndicatorField;
        }
        set
        {
            this.constructionLoanIndicatorField = value;
        }
    }

    /// <remarks/>
    public bool ConversionOfContractForDeedIndicator
    {
        get
        {
            return this.conversionOfContractForDeedIndicatorField;
        }
        set
        {
            this.conversionOfContractForDeedIndicatorField = value;
        }
    }

    /// <remarks/>
    public bool EnergyRelatedImprovementsIndicator
    {
        get
        {
            return this.energyRelatedImprovementsIndicatorField;
        }
        set
        {
            this.energyRelatedImprovementsIndicatorField = value;
        }
    }

    /// <remarks/>
    public bool InterestOnlyIndicator
    {
        get
        {
            return this.interestOnlyIndicatorField;
        }
        set
        {
            this.interestOnlyIndicatorField = value;
        }
    }

    /// <remarks/>
    public bool NegativeAmortizationIndicator
    {
        get
        {
            return this.negativeAmortizationIndicatorField;
        }
        set
        {
            this.negativeAmortizationIndicatorField = value;
        }
    }

    /// <remarks/>
    public bool PrepaymentPenaltyIndicator
    {
        get
        {
            return this.prepaymentPenaltyIndicatorField;
        }
        set
        {
            this.prepaymentPenaltyIndicatorField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSORIGINATION_FUNDS
{

    private LOANSORIGINATION_FUNDSORIGINATION_FUND oRIGINATION_FUNDField;

    /// <remarks/>
    public LOANSORIGINATION_FUNDSORIGINATION_FUND ORIGINATION_FUND
    {
        get
        {
            return this.oRIGINATION_FUNDField;
        }
        set
        {
            this.oRIGINATION_FUNDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSORIGINATION_FUNDSORIGINATION_FUND
{

    private string fundsSourceTypeField;

    /// <remarks/>
    public string FundsSourceType
    {
        get
        {
            return this.fundsSourceTypeField;
        }
        set
        {
            this.fundsSourceTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSPAYMENT
{

    private LOANSPAYMENTPAYMENT_RULE pAYMENT_RULEField;

    /// <remarks/>
    public LOANSPAYMENTPAYMENT_RULE PAYMENT_RULE
    {
        get
        {
            return this.pAYMENT_RULEField;
        }
        set
        {
            this.pAYMENT_RULEField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSPAYMENTPAYMENT_RULE
{

    private decimal initialPrincipalAndInterestPaymentAmountField;

    /// <remarks/>
    public decimal InitialPrincipalAndInterestPaymentAmount
    {
        get
        {
            return this.initialPrincipalAndInterestPaymentAmountField;
        }
        set
        {
            this.initialPrincipalAndInterestPaymentAmountField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LOANSTERMS_OF_LOAN
{

    private string lienPriorityTypeField;

    private decimal noteAmountField;

    /// <remarks/>
    public string LienPriorityType
    {
        get
        {
            return this.lienPriorityTypeField;
        }
        set
        {
            this.lienPriorityTypeField = value;
        }
    }

    /// <remarks/>
    public decimal NoteAmount
    {
        get
        {
            return this.noteAmountField;
        }
        set
        {
            this.noteAmountField = value;
        }
    }
}

