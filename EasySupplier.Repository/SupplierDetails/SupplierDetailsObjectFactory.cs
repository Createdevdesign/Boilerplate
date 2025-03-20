using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{

    internal class SupplierDetailsObjectFactory : IDomainObjectFactory<Vendor>
    {
        public Vendor Construct(IDataReader reader)
        {
            Vendor SupplierDetails = new Vendor();

            SupplierDetails.GSTIN = null != reader[Constants.OUT_GST_IN] ? reader[Constants.OUT_GST_IN].ToString().Trim() : string.Empty;
            SupplierDetails.PANNo = null != reader[Constants.OUT_PAN_NO] ? reader[Constants.OUT_PAN_NO].ToString().Trim() : string.Empty;
            SupplierDetails.VATRegistration = null != reader[Constants.OUT_VAT_REGISTRATION] ? reader[Constants.OUT_VAT_REGISTRATION].ToString().Trim() : string.Empty;
            SupplierDetails.TaxNumber = null != reader[Constants.OUT_TAX_NUMBER] ? reader[Constants.OUT_TAX_NUMBER].ToString().Trim() : string.Empty;
            SupplierDetails.Country = null != reader[Constants.OUT_COUNTRY] ? reader[Constants.OUT_COUNTRY].ToString().Trim() : string.Empty;

            SupplierDetails.Title = null != reader[Constants.OUT_TITLE] ? reader[Constants.OUT_TITLE].ToString().Trim() : string.Empty;
            SupplierDetails.OrganisationType = null != reader[Constants.OUT_ORGANISATION_TYPE] ? reader[Constants.OUT_ORGANISATION_TYPE].ToString().Trim() : string.Empty;
            SupplierDetails.EstablishmentName = null != reader[Constants.OUT_Establishment_Name] ? reader[Constants.OUT_Establishment_Name].ToString().Trim() : string.Empty;
            SupplierDetails.ShortName = null != reader[Constants.OUT_SHORT_NAME] ? reader[Constants.OUT_SHORT_NAME].ToString().Trim() : string.Empty;
            SupplierDetails.NoofEmployees = null != reader[Constants.OUT_NO_OF_EMPLOYEES] ? reader[Constants.OUT_NO_OF_EMPLOYEES].ToString().Trim() : string.Empty;

            SupplierDetails.CompUrl = null != reader[Constants.OUT_COMP_URL] ? reader[Constants.OUT_COMP_URL].ToString().Trim() : string.Empty;
            SupplierDetails.CompEmailID = null != reader[Constants.OUT_CompEmailId] ? reader[Constants.OUT_CompEmailId].ToString().Trim() : string.Empty;
            SupplierDetails.HouseNo = null != reader[Constants.OUT_HOUSE_NO] ? reader[Constants.OUT_HOUSE_NO].ToString().Trim() : string.Empty;
            SupplierDetails.OfficeAddress = null != reader[Constants.OUT_OFFICE_ADDRESS] ? reader[Constants.OUT_OFFICE_ADDRESS].ToString().Trim() : string.Empty;
            SupplierDetails.Street2 = null != reader[Constants.OUT_STREET2] ? reader[Constants.OUT_STREET2].ToString().Trim() : string.Empty;

            SupplierDetails.Street3 = null != reader[Constants.OUT_STREET3] ? reader[Constants.OUT_STREET3].ToString().Trim() : string.Empty;
            SupplierDetails.RegState = null != reader[Constants.OUT_REG_STATE] ? reader[Constants.OUT_REG_STATE].ToString().Trim() : string.Empty;
            SupplierDetails.RegCity = null != reader[Constants.OUT_REG_CITY] ? reader[Constants.OUT_REG_CITY].ToString().Trim() : string.Empty;
            SupplierDetails.RegPostalCode = null != reader[Constants.OUT_REG_POSTAL_CODE] ? reader[Constants.OUT_REG_POSTAL_CODE].ToString().Trim() : string.Empty;
            SupplierDetails.CompTelephoneNo = null != reader[Constants.OUT_COMP_TELEPHONE_NO] ? reader[Constants.OUT_COMP_TELEPHONE_NO].ToString().Trim() : string.Empty;

            SupplierDetails.CompMobileNo = null != reader[Constants.OUT_COMP_MOBILE_NO] ? reader[Constants.OUT_COMP_MOBILE_NO].ToString().Trim() : string.Empty;
            SupplierDetails.FaxNo = null != reader[Constants.OUT_FAX_NO] ? reader[Constants.OUT_FAX_NO].ToString().Trim() : string.Empty;
            SupplierDetails.SupplierType = null != reader[Constants.OUT_SUPPLIER_TYPE] ? reader[Constants.OUT_SUPPLIER_TYPE].ToString().Trim() : string.Empty;
            //Bank Info
            SupplierDetails.BankCountry = null != reader[Constants.OUT_BANK_COUNTRY] ? reader[Constants.OUT_BANK_COUNTRY].ToString().Trim() : string.Empty;
            SupplierDetails.Currency = null != reader[Constants.OUT_CURRENCY] ? reader[Constants.OUT_CURRENCY].ToString().Trim() : string.Empty;
            SupplierDetails.BeneficiaryName = null != reader[Constants.OUT_BENEFICIARY_NAME] ? reader[Constants.OUT_BENEFICIARY_NAME].ToString().Trim() : string.Empty;
            SupplierDetails.BeneficiaryAccountNo = null != reader[Constants.OUT_BENEFICIARY_ACCOUNT_NO] ? reader[Constants.OUT_BENEFICIARY_ACCOUNT_NO].ToString().Trim() : string.Empty;
            SupplierDetails.BankName = null != reader[Constants.OUT_BANK_NAME] ? reader[Constants.OUT_BANK_NAME].ToString().Trim() : string.Empty;

            SupplierDetails.BeneficiaryBranch = null != reader[Constants.OUT_BENEFICIARY_BRANCH] ? reader[Constants.OUT_BENEFICIARY_BRANCH].ToString().Trim() : string.Empty;
            SupplierDetails.BeneficiaryAddress = null != reader[Constants.OUT_BENEFICIARY_ADDRESS] ? reader[Constants.OUT_BENEFICIARY_ADDRESS].ToString().Trim() : string.Empty;
            SupplierDetails.AccountType = null != reader[Constants.OUT_ACCOUNT_TYPE] ? reader[Constants.OUT_ACCOUNT_TYPE].ToString().Trim() : string.Empty;
            SupplierDetails.IFSCCode = null != reader[Constants.OUT_IFSC_CODE] ? reader[Constants.OUT_IFSC_CODE].ToString().Trim() : string.Empty;
            SupplierDetails.SWIFTBICCode = null != reader[Constants.OUT_SWIFTBIC_CODE] ? reader[Constants.OUT_SWIFTBIC_CODE].ToString().Trim() : string.Empty;
            //Fin Info
            SupplierDetails.RegistrationDate = null != reader[Constants.OUT_REGISTRATION_DATE] ? Convert.ToDateTime(reader[Constants.OUT_REGISTRATION_DATE].ToString().Trim()) : DateTime.Today;
            SupplierDetails.FinancialYear1 = null != reader[Constants.OUT_FINANCIAL_YEAR1] ? reader[Constants.OUT_FINANCIAL_YEAR1].ToString().Trim() : string.Empty;
            SupplierDetails.FinancialYear2 = null != reader[Constants.OUT_FINANCIAL_YEAR2] ? reader[Constants.OUT_FINANCIAL_YEAR2].ToString().Trim() : string.Empty;
            SupplierDetails.FinancialYear3 = null != reader[Constants.OUT_FINANCIAL_YEAR3] ? reader[Constants.OUT_FINANCIAL_YEAR3].ToString().Trim() : string.Empty;
            SupplierDetails.Profit1 = null != reader[Constants.OUT_PROFIT1] ? Convert.ToDecimal(reader[Constants.OUT_PROFIT1].ToString().Trim()) : 0;

            SupplierDetails.Profit2 = null != reader[Constants.OUT_PROFIT2] ? Convert.ToDecimal(reader[Constants.OUT_PROFIT2].ToString().Trim()) : 0;
            SupplierDetails.Profit3 = null != reader[Constants.OUT_PROFIT3] ? Convert.ToDecimal(reader[Constants.OUT_PROFIT3].ToString().Trim()) : 0;
            SupplierDetails.Turnover1 = null != reader[Constants.OUT_TURNOVER1] ? Convert.ToDecimal(reader[Constants.OUT_TURNOVER1].ToString().Trim()) : 0;
            SupplierDetails.Turnover2 = null != reader[Constants.OUT_TURNOVER2] ? Convert.ToDecimal(reader[Constants.OUT_TURNOVER2].ToString().Trim()) : 0;
            SupplierDetails.Turnover3 = null != reader[Constants.OUT_TURNOVER3] ? Convert.ToDecimal(reader[Constants.OUT_TURNOVER3].ToString().Trim()) : 0;

            SupplierDetails.OnlineCatalog = null != reader[Constants.OUT_ONLINE_CATALOG] ? reader[Constants.OUT_ONLINE_CATALOG].ToString().Trim() : string.Empty;
            SupplierDetails.OnlineOrdering = null != reader[Constants.OUT_ONLINE_ORDERING] ? reader[Constants.OUT_ONLINE_ORDERING].ToString().Trim() : string.Empty;
            SupplierDetails.OnlineOrderTracking = null != reader[Constants.OUT_ONLINE_ORDER_TRACKING] ? reader[Constants.OUT_ONLINE_ORDER_TRACKING].ToString().Trim() : string.Empty;
            SupplierDetails.OnlineEauctions = null != reader[Constants.OUT_ONLINE_EAUCTIONS] ? reader[Constants.OUT_ONLINE_EAUCTIONS].ToString().Trim() : string.Empty;
            SupplierDetails.MINDK = null != reader[Constants.OUT_MINDK] ? reader[Constants.OUT_MINDK].ToString().Trim() : string.Empty;

            SupplierDetails.MinorityIndicatorDate = null != reader[Constants.OUT_MINORITY_INDICATOR_DATE] ? Convert.ToDateTime(reader[Constants.OUT_MINORITY_INDICATOR_DATE].ToString().Trim()) : DateTime.Today;

            //Certification
            SupplierDetails.ISO9001 = null != reader[Constants.OUT_ISO_9001] ? reader[Constants.OUT_ISO_9001].ToString().Trim() : string.Empty;
            SupplierDetails.DateISO9001 = null != reader[Constants.OUT_DATE_ISO_9001] ? Convert.ToDateTime(reader[Constants.OUT_DATE_ISO_9001].ToString().Trim()) : DateTime.Today;
            SupplierDetails.ISO27001 = null != reader[Constants.OUT_ISO_27001] ? reader[Constants.OUT_ISO_27001].ToString().Trim() : string.Empty;
            SupplierDetails.DateISO27001 = null != reader[Constants.OUT_DATE_ISO_27001] ? Convert.ToDateTime(reader[Constants.OUT_DATE_ISO_27001].ToString().Trim()) : DateTime.Today;
            SupplierDetails.C9100 = null != reader[Constants.OUT_C_9100] ? reader[Constants.OUT_C_9100].ToString().Trim() : string.Empty;

            SupplierDetails.DateC9100 = null != reader[Constants.OUT_DATE_C_9100] ? Convert.ToDateTime(reader[Constants.OUT_DATE_C_9100].ToString().Trim()) : DateTime.Today;
            SupplierDetails.QMSAvailableAtTheSuppliersSite = null != reader[Constants.OUT_QMS_AVAILABLE_AT_THE_SUPPLIERS_SITE] ? reader[Constants.OUT_QMS_AVAILABLE_AT_THE_SUPPLIERS_SITE].ToString().Trim() : string.Empty;
            SupplierDetails.EnvironmentManagementSystem = null != reader[Constants.OUT_ENVIRONMENT_MANAGEMENT_SYSTEM] ? reader[Constants.OUT_ENVIRONMENT_MANAGEMENT_SYSTEM].ToString().Trim() : string.Empty;
            SupplierDetails.WorkersCompensationInsurancePolicy = null != reader[Constants.OUT_WORKERS_COMPENSATION_INSURANCE_POLICY] ? reader[Constants.OUT_WORKERS_COMPENSATION_INSURANCE_POLICY].ToString().Trim() : string.Empty;
            SupplierDetails.OwnSuppliersAndSubContractors = null != reader[Constants.OUT_OWN_SUPPLIERS_AND_SUB_CONTRACTORS] ? reader[Constants.OUT_OWN_SUPPLIERS_AND_SUB_CONTRACTORS].ToString().Trim() : string.Empty;

            SupplierDetails.PublicLiabilityInsurancePolicy = null != reader[Constants.OUT_PUBLIC_LIABILITY_INSURANCE_POLICY] ? reader[Constants.OUT_PUBLIC_LIABILITY_INSURANCE_POLICY].ToString().Trim() : string.Empty;
            SupplierDetails.SupplierDueDiligenceRequirements = null != reader[Constants.OUT_SUPPLIER_DUE_DILIGENCE_REQUIREMENTS] ? reader[Constants.OUT_SUPPLIER_DUE_DILIGENCE_REQUIREMENTS].ToString().Trim() : string.Empty;
            SupplierDetails.IndemnityInsurancePolicy = null != reader[Constants.OUT_INDEMNITY_INSURANCE_POLICY] ? reader[Constants.OUT_INDEMNITY_INSURANCE_POLICY].ToString().Trim() : string.Empty;
            SupplierDetails.QualityEnvironmentalStandards = null != reader[Constants.OUT_QUALITY_ENVIRONMENTAL_STANDARDS] ? reader[Constants.OUT_QUALITY_ENVIRONMENTAL_STANDARDS].ToString().Trim() : string.Empty;
            //References
            //SupplierDetails.RefCustomersName = null != reader[Constants.OUT_REF_CUSTOMERS_NAME] ? reader[Constants.OUT_REF_CUSTOMERS_NAME].ToString().Trim() : string.Empty;
            //SupplierDetails.RefContactPerson = null != reader[Constants.OUT_REF_CONTACT_PERSON] ? reader[Constants.OUT_REF_CONTACT_PERSON].ToString().Trim() : string.Empty;
            //SupplierDetails.RefDesignation = null != reader[Constants.OUT_REF_DESIGNATION] ? reader[Constants.OUT_REF_DESIGNATION].ToString().Trim() : string.Empty;
            //SupplierDetails.RefContactNo = null != reader[Constants.OUT_REF_CONTACT_NO] ? reader[Constants.OUT_REF_CONTACT_NO].ToString().Trim() : string.Empty;
            //SupplierDetails.RefEmailID = null != reader[Constants.OUT_REF_EMAIL_ID] ? reader[Constants.OUT_REF_EMAIL_ID].ToString().Trim() : string.Empty;
            //Additional
            SupplierDetails.MOB = null != reader[Constants.OUT_MOB] ? reader[Constants.OUT_MOB].ToString().Trim() : string.Empty;
            SupplierDetails.WOB = null != reader[Constants.OUT_WOB] ? reader[Constants.OUT_WOB].ToString().Trim() : string.Empty;
            SupplierDetails.VOB = null != reader[Constants.OUT_VOB] ? reader[Constants.OUT_VOB].ToString().Trim() : string.Empty;
            SupplierDetails.LGBTOB = null != reader[Constants.OUT_LGBTOB] ? reader[Constants.OUT_LGBTOB].ToString().Trim() : string.Empty;
            SupplierDetails.SDVOB = null != reader[Constants.OUT_SDVOB] ? reader[Constants.OUT_SDVOB].ToString().Trim() : string.Empty;

            SupplierDetails.SB = null != reader[Constants.OUT_SB] ? reader[Constants.OUT_SB].ToString().Trim() : string.Empty;
            SupplierDetails.SDB = null != reader[Constants.OUT_SDB] ? reader[Constants.OUT_SDB].ToString().Trim() : string.Empty;
            SupplierDetails.WOSB = null != reader[Constants.OUT_WOSB] ? reader[Constants.OUT_WOSB].ToString().Trim() : string.Empty;
            SupplierDetails.HUSB = null != reader[Constants.OUT_HUSB] ? reader[Constants.OUT_HUSB].ToString().Trim() : string.Empty;
            SupplierDetails.VOSB = null != reader[Constants.OUT_VOSB] ? reader[Constants.OUT_VOSB].ToString().Trim() : string.Empty;

            SupplierDetails.SDVOSB = null != reader[Constants.OUT_SDVOSB] ? reader[Constants.OUT_SDVOSB].ToString().Trim() : string.Empty;
            SupplierDetails.EDWOSB = null != reader[Constants.OUT_EDWOSB] ? reader[Constants.OUT_EDWOSB].ToString().Trim() : string.Empty;
            SupplierDetails.MBE = null != reader[Constants.OUT_MBE] ? reader[Constants.OUT_MBE].ToString().Trim() : string.Empty;
            SupplierDetails.DBE = null != reader[Constants.OUT_DBE] ? reader[Constants.OUT_DBE].ToString().Trim() : string.Empty;
            SupplierDetails.SBE = null != reader[Constants.OUT_SBE] ? reader[Constants.OUT_SBE].ToString().Trim() : string.Empty;

            SupplierDetails.SWAM = null != reader[Constants.OUT_SWAM] ? reader[Constants.OUT_SWAM].ToString().Trim() : string.Empty;
            SupplierDetails.LGBT = null != reader[Constants.OUT_LGBT] ? reader[Constants.OUT_LGBT].ToString().Trim() : string.Empty;
            SupplierDetails.SupplyAnyOtherTTL = null != reader[Constants.OUT_SUPPLY_ANY_OTHER_TTL] ? reader[Constants.OUT_SUPPLY_ANY_OTHER_TTL].ToString().Trim() : string.Empty;
            SupplierDetails.NameofCompanies = null != reader[Constants.OUT_NAME_OF_COMPANIES] ? reader[Constants.OUT_NAME_OF_COMPANIES].ToString().Trim() : string.Empty;
            SupplierDetails.TypeofWorkDone = null != reader[Constants.OUT_TYPE_OF_WORK_DONE] ? reader[Constants.OUT_TYPE_OF_WORK_DONE].ToString().Trim() : string.Empty;

            //ddl
            SupplierDetails.CountryName = null != reader[Constants.OUT_COUNTRY_NAME] ? reader[Constants.OUT_COUNTRY_NAME].ToString().Trim() : string.Empty;
            SupplierDetails.TitleName = null != reader[Constants.OUT_TITLE_NAME] ? reader[Constants.OUT_TITLE_NAME].ToString().Trim() : string.Empty;
            SupplierDetails.OrganisationTypeName = null != reader[Constants.OUT_ORGANISATION_TYPE_NAME] ? reader[Constants.OUT_ORGANISATION_TYPE_NAME].ToString().Trim() : string.Empty;
            SupplierDetails.RegStateName = null != reader[Constants.OUT_REG_STATE_NAME] ? reader[Constants.OUT_REG_STATE_NAME].ToString().Trim() : string.Empty;
            SupplierDetails.BankCountryName = null != reader[Constants.OUT_BANK_COUNTRY_NAME] ? reader[Constants.OUT_BANK_COUNTRY_NAME].ToString().Trim() : string.Empty;
            SupplierDetails.CurrencyName = null != reader[Constants.OUT_CURRENCY_NAME] ? reader[Constants.OUT_CURRENCY_NAME].ToString().Trim() : string.Empty;
            SupplierDetails.AccountTypeName = null != reader[Constants.OUT_ACCOUNT_TYPE_NAME] ? reader[Constants.OUT_ACCOUNT_TYPE_NAME].ToString().Trim() : string.Empty;
            SupplierDetails.MinorityIndicatorName= null != reader[Constants.OUT_MINORITY_INDICATOR_NAME] ? reader[Constants.OUT_MINORITY_INDICATOR_NAME].ToString().Trim() : string.Empty;

            return SupplierDetails;
        }
    }
   
}
