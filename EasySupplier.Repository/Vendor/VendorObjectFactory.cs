using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;


namespace BoilerSupplier.Repository
{
  
    internal class VendorObjectFactory : IDomainObjectFactory<Vendor>
    {
        public Vendor Construct(IDataReader reader)
        {
            Vendor Vendor = new Vendor();
            //Vendor Info
            //Vendor.GSTIN = null != reader[Constants.OUT_GST_IN] ? reader[Constants.OUT_GST_IN].ToString().Trim() : string.Empty;
            //Vendor.PANNo = null != reader[Constants.OUT_PAN_NO] ? reader[Constants.OUT_PAN_NO].ToString().Trim() : string.Empty;
            //Vendor.VATRegistration = null != reader[Constants.OUT_VAT_REGISTRATION] ? reader[Constants.OUT_VAT_REGISTRATION].ToString().Trim() : string.Empty;
            //Vendor.TaxNumber = null != reader[Constants.OUT_TAX_NUMBER] ? reader[Constants.OUT_TAX_NUMBER].ToString().Trim() : string.Empty;
            //Vendor.Country = null != reader[Constants.OUT_COUNTRY] ? reader[Constants.OUT_COUNTRY].ToString().Trim() : string.Empty;
           
            //Vendor.Title = null != reader[Constants.OUT_TITLE] ? reader[Constants.OUT_TITLE].ToString().Trim() : string.Empty;
            //Vendor.OrganisationType = null != reader[Constants.OUT_ORGANISATION_TYPE] ? reader[Constants.OUT_ORGANISATION_TYPE].ToString().Trim() : string.Empty;
            //Vendor.EstablishmentName = null != reader[Constants.OUT_Establishment_Name] ? reader[Constants.OUT_Establishment_Name].ToString().Trim() : string.Empty;
            //Vendor.ShortName = null != reader[Constants.OUT_SHORT_NAME] ? reader[Constants.OUT_SHORT_NAME].ToString().Trim() : string.Empty;
            //Vendor.NoofEmployees = null != reader[Constants.OUT_NO_OF_EMPLOYEES] ? reader[Constants.OUT_NO_OF_EMPLOYEES].ToString().Trim() : string.Empty;
           
            //Vendor.CompUrl = null != reader[Constants.OUT_COMP_URL] ? reader[Constants.OUT_COMP_URL].ToString().Trim() : string.Empty;
            //Vendor.CompEmailID = null != reader[Constants.OUT_EMAIL_ID] ? reader[Constants.OUT_EMAIL_ID].ToString().Trim() : string.Empty;
            //Vendor.HouseNo = null != reader[Constants.OUT_HOUSE_NO] ? reader[Constants.OUT_HOUSE_NO].ToString().Trim() : string.Empty;
            //Vendor.OfficeAddress = null != reader[Constants.OUT_OFFICE_ADDRESS] ? reader[Constants.OUT_OFFICE_ADDRESS].ToString().Trim() : string.Empty;
            //Vendor.Street2 = null != reader[Constants.OUT_STREET2] ? reader[Constants.OUT_STREET2].ToString().Trim() : string.Empty;
           
            //Vendor.Street3 = null != reader[Constants.OUT_STREET3] ? reader[Constants.OUT_STREET3].ToString().Trim() : string.Empty;
            //Vendor.RegState = null != reader[Constants.OUT_REG_STATE] ? reader[Constants.OUT_REG_STATE].ToString().Trim() : string.Empty;
            //Vendor.RegCity = null != reader[Constants.OUT_REG_CITY] ? reader[Constants.OUT_REG_CITY].ToString().Trim() : string.Empty;
            //Vendor.RegPostalCode = null != reader[Constants.OUT_POSTAL_CODE] ? reader[Constants.OUT_POSTAL_CODE].ToString().Trim() : string.Empty;
            //Vendor.CompTelephoneNo = null != reader[Constants.OUT_COMP_TELEPHONE_NO] ? reader[Constants.OUT_COMP_TELEPHONE_NO].ToString().Trim() : string.Empty;
           
            //Vendor.CompMobileNo = null != reader[Constants.OUT_COMP_MOBILE_NO] ? reader[Constants.OUT_COMP_MOBILE_NO].ToString().Trim() : string.Empty;
            //Vendor.FaxNo = null != reader[Constants.OUT_FAX_NO] ? reader[Constants.OUT_FAX_NO].ToString().Trim() : string.Empty;
            //Vendor.SupplierType = null != reader[Constants.OUT_SUPPLIER_TYPE] ? reader[Constants.OUT_SUPPLIER_TYPE].ToString().Trim() : string.Empty;
            ////Bank Info
            //Vendor.BankCountry = null != reader[Constants.OUT_BANK_COUNTRY] ? reader[Constants.OUT_BANK_COUNTRY].ToString().Trim() : string.Empty;
            //Vendor.Currency = null != reader[Constants.OUT_CURRENCY] ? reader[Constants.OUT_CURRENCY].ToString().Trim() : string.Empty;
            //Vendor.BeneficiaryName = null != reader[Constants.OUT_BENEFICIARY_NAME] ? reader[Constants.OUT_BENEFICIARY_NAME].ToString().Trim() : string.Empty;
            //Vendor.BeneficiaryAccountNo = null != reader[Constants.OUT_BENEFICIARY_ACCOUNT_NO] ? reader[Constants.OUT_BENEFICIARY_ACCOUNT_NO].ToString().Trim() : string.Empty;
            //Vendor.BankName = null != reader[Constants.OUT_BANK_NAME] ? reader[Constants.OUT_BANK_NAME].ToString().Trim() : string.Empty;

            //Vendor.BeneficiaryBranch = null != reader[Constants.OUT_BENEFICIARY_BRANCH] ? reader[Constants.OUT_BENEFICIARY_BRANCH].ToString().Trim() : string.Empty;
            //Vendor.BeneficiaryAddress = null != reader[Constants.OUT_BENEFICIARY_ADDRESS] ? reader[Constants.OUT_BENEFICIARY_ADDRESS].ToString().Trim() : string.Empty;
            //Vendor.AccountType = null != reader[Constants.OUT_ACCOUNT_TYPE] ? reader[Constants.OUT_ACCOUNT_TYPE].ToString().Trim() : string.Empty;
            //Vendor.IFSCCode = null != reader[Constants.OUT_IFSC_CODE] ? reader[Constants.OUT_IFSC_CODE].ToString().Trim() : string.Empty;
            //Vendor.SWIFTBICCode = null != reader[Constants.OUT_SWIFTBIC_CODE] ? reader[Constants.OUT_SWIFTBIC_CODE].ToString().Trim() : string.Empty;
            ////Fin Info
            //Vendor.RegistrationDate = null != reader[Constants.OUT_REGISTRATION_DATE] ? Convert.ToDateTime(reader[Constants.OUT_REGISTRATION_DATE].ToString().Trim()) : DateTime.Today;
            //Vendor.FinancialYear1 = null != reader[Constants.OUT_FINANCIAL_YEAR1] ? reader[Constants.OUT_FINANCIAL_YEAR1].ToString().Trim() : string.Empty;
            //Vendor.FinancialYear2 = null != reader[Constants.OUT_FINANCIAL_YEAR2] ? reader[Constants.OUT_FINANCIAL_YEAR2].ToString().Trim() : string.Empty;
            //Vendor.FinancialYear3 = null != reader[Constants.OUT_FINANCIAL_YEAR3] ? reader[Constants.OUT_FINANCIAL_YEAR3].ToString().Trim() : string.Empty;
            //Vendor.Profit1 = null != reader[Constants.OUT_PROFIT1] ? Convert.ToDecimal(reader[Constants.OUT_PROFIT1].ToString().Trim()) : 0;

            //Vendor.Profit2 = null != reader[Constants.OUT_PROFIT2] ? Convert.ToDecimal(reader[Constants.OUT_PROFIT2].ToString().Trim()) : 0;
            //Vendor.Profit3 = null != reader[Constants.OUT_PROFIT3] ? Convert.ToDecimal(reader[Constants.OUT_PROFIT3].ToString().Trim()) : 0;
            //Vendor.Turnover1 = null != reader[Constants.OUT_TURNOVER1] ? Convert.ToDecimal(reader[Constants.OUT_TURNOVER1].ToString().Trim()) : 0;
            //Vendor.Turnover2 = null != reader[Constants.OUT_TURNOVER2] ? Convert.ToDecimal(reader[Constants.OUT_TURNOVER2].ToString().Trim()) : 0;
            //Vendor.Turnover3 = null != reader[Constants.OUT_TURNOVER3] ? Convert.ToDecimal(reader[Constants.OUT_TURNOVER3].ToString().Trim()) : 0;

            //Vendor.OnlineCatalog = null != reader[Constants.OUT_ONLINE_CATALOG] ? reader[Constants.OUT_ONLINE_CATALOG].ToString().Trim() : string.Empty;
            //Vendor.OnlineOrdering = null != reader[Constants.OUT_ONLINE_ORDERING] ? reader[Constants.OUT_ONLINE_ORDERING].ToString().Trim() : string.Empty;
            //Vendor.OnlineOrderTracking = null != reader[Constants.OUT_ONLINE_ORDER_TRACKING] ? reader[Constants.OUT_ONLINE_ORDER_TRACKING].ToString().Trim() : string.Empty;
            //Vendor.OnlineEauctions = null != reader[Constants.OUT_ONLINE_EAUCTIONS] ? reader[Constants.OUT_ONLINE_EAUCTIONS].ToString().Trim() : string.Empty;
            //Vendor.MinorityIndicatorName = null != reader[Constants.OUT_MINORITY_INDICATOR_NAME] ? reader[Constants.OUT_MINORITY_INDICATOR_NAME].ToString().Trim() : string.Empty;

            //Vendor.MinorityIndicatorDate = null != reader[Constants.OUT_WT_EXDF] ? Convert.ToDateTime(reader[Constants.OUT_WT_EXDF].ToString().Trim()) : DateTime.Today;

            ////Certification
            //Vendor.ISO9001 = null != reader[Constants.OUT_ISO_9001] ? reader[Constants.OUT_ISO_9001].ToString().Trim() : string.Empty;
            //Vendor.DateISO9001 = null != reader[Constants.OUT_DATE_ISO_9001] ? Convert.ToDateTime(reader[Constants.OUT_DATE_ISO_9001].ToString().Trim()) : DateTime.Today;
            //Vendor.ISO27001 = null != reader[Constants.OUT_ISO_27001] ? reader[Constants.OUT_ISO_27001].ToString().Trim() : string.Empty;
            //Vendor.DateISO27001 = null != reader[Constants.OUT_DATE_ISO_27001] ? Convert.ToDateTime(reader[Constants.OUT_DATE_ISO_27001].ToString().Trim()) : DateTime.Today;
            //Vendor.C9100 = null != reader[Constants.OUT_C_9100] ? reader[Constants.OUT_C_9100].ToString().Trim() : string.Empty;

            //Vendor.DateC9100 = null != reader[Constants.OUT_DATE_C_9100] ? Convert.ToDateTime(reader[Constants.OUT_DATE_C_9100].ToString().Trim()) : DateTime.Today;
            //Vendor.QMSAvailableAtTheSuppliersSite = null != reader[Constants.OUT_QMS_AVAILABLE_AT_THE_SUPPLIERS_SITE] ? reader[Constants.OUT_QMS_AVAILABLE_AT_THE_SUPPLIERS_SITE].ToString().Trim() : string.Empty;
            //Vendor.EnvironmentManagementSystem = null != reader[Constants.OUT_ENVIRONMENT_MANAGEMENT_SYSTEM] ? reader[Constants.OUT_ENVIRONMENT_MANAGEMENT_SYSTEM].ToString().Trim() : string.Empty;
            //Vendor.WorkersCompensationInsurancePolicy = null != reader[Constants.OUT_WORKERS_COMPENSATION_INSURANCE_POLICY] ? reader[Constants.OUT_WORKERS_COMPENSATION_INSURANCE_POLICY].ToString().Trim() : string.Empty;
            //Vendor.OwnSuppliersAndSubContractors = null != reader[Constants.OUT_OWN_SUPPLIERS_AND_SUB_CONTRACTORS] ? reader[Constants.OUT_OWN_SUPPLIERS_AND_SUB_CONTRACTORS].ToString().Trim() : string.Empty;

            //Vendor.PublicLiabilityInsurancePolicy = null != reader[Constants.OUT_PUBLIC_LIABILITY_INSURANCE_POLICY] ? reader[Constants.OUT_PUBLIC_LIABILITY_INSURANCE_POLICY].ToString().Trim() : string.Empty;
            //Vendor.SupplierDueDiligenceRequirements = null != reader[Constants.OUT_SUPPLIER_DUE_DILIGENCE_REQUIREMENTS] ? reader[Constants.OUT_SUPPLIER_DUE_DILIGENCE_REQUIREMENTS].ToString().Trim() : string.Empty;
            //Vendor.IndemnityInsurancePolicy = null != reader[Constants.OUT_INDEMNITY_INSURANCE_POLICY] ? reader[Constants.OUT_INDEMNITY_INSURANCE_POLICY].ToString().Trim() : string.Empty;
            //Vendor.QualityEnvironmentalStandards = null != reader[Constants.OUT_QUALITY_ENVIRONMENTAL_STANDARDS] ? reader[Constants.OUT_QUALITY_ENVIRONMENTAL_STANDARDS].ToString().Trim() : string.Empty;
            ////References
            //Vendor.RefCustomersName = null != reader[Constants.OUT_REF_CUSTOMERS_NAME] ? reader[Constants.OUT_REF_CUSTOMERS_NAME].ToString().Trim() : string.Empty;
            //Vendor.RefContactPerson = null != reader[Constants.OUT_REF_CONTACT_PERSON] ? reader[Constants.OUT_REF_CONTACT_PERSON].ToString().Trim() : string.Empty;
            //Vendor.RefDesignation = null != reader[Constants.OUT_REF_DESIGNATION] ? reader[Constants.OUT_REF_DESIGNATION].ToString().Trim() : string.Empty;
            //Vendor.RefContactNo = null != reader[Constants.OUT_REF_CONTACT_NO] ? reader[Constants.OUT_REF_CONTACT_NO].ToString().Trim() : string.Empty;
            //Vendor.RefEmailID = null != reader[Constants.OUT_REF_EMAIL_ID] ? reader[Constants.OUT_REF_EMAIL_ID].ToString().Trim() : string.Empty;
            ////Additional
            //Vendor.MOB = null != reader[Constants.OUT_MOB] ? reader[Constants.OUT_MOB].ToString().Trim() : string.Empty;
            //Vendor.WOB = null != reader[Constants.OUT_WOB] ? reader[Constants.OUT_WOB].ToString().Trim() : string.Empty;
            //Vendor.VOB = null != reader[Constants.OUT_VOB] ? reader[Constants.OUT_VOB].ToString().Trim() : string.Empty;
            //Vendor.LGBTOB = null != reader[Constants.OUT_LGBTOB] ? reader[Constants.OUT_LGBTOB].ToString().Trim() : string.Empty;
            //Vendor.SDVOB = null != reader[Constants.OUT_SDVOB] ? reader[Constants.OUT_SDVOB].ToString().Trim() : string.Empty;

            //Vendor.SB = null != reader[Constants.OUT_SB] ? reader[Constants.OUT_SB].ToString().Trim() : string.Empty;
            //Vendor.SDB = null != reader[Constants.OUT_SDB] ? reader[Constants.OUT_SDB].ToString().Trim() : string.Empty;
            //Vendor.WOSB = null != reader[Constants.OUT_WOSB] ? reader[Constants.OUT_WOSB].ToString().Trim() : string.Empty;
            //Vendor.HUSB = null != reader[Constants.OUT_HUSB] ? reader[Constants.OUT_HUSB].ToString().Trim() : string.Empty;
            //Vendor.VOSB = null != reader[Constants.OUT_VOSB] ? reader[Constants.OUT_VOSB].ToString().Trim() : string.Empty;

            //Vendor.SDVOSB = null != reader[Constants.OUT_SDVOSB] ? reader[Constants.OUT_SDVOSB].ToString().Trim() : string.Empty;
            //Vendor.EDWOSB = null != reader[Constants.OUT_EDWOSB] ? reader[Constants.OUT_EDWOSB].ToString().Trim() : string.Empty;
            //Vendor.MBE = null != reader[Constants.OUT_MBE] ? reader[Constants.OUT_MBE].ToString().Trim() : string.Empty;
            //Vendor.DBE = null != reader[Constants.OUT_DBE] ? reader[Constants.OUT_DBE].ToString().Trim() : string.Empty;
            //Vendor.SBE = null != reader[Constants.OUT_SBE] ? reader[Constants.OUT_SBE].ToString().Trim() : string.Empty;

            //Vendor.SWAM = null != reader[Constants.OUT_SWAM] ? reader[Constants.OUT_SWAM].ToString().Trim() : string.Empty;
            //Vendor.LGBT = null != reader[Constants.OUT_LGBT] ? reader[Constants.OUT_LGBT].ToString().Trim() : string.Empty;
            //Vendor.SupplyAnyOtherTTL = null != reader[Constants.OUT_SUPPLY_ANY_OTHER_TTL] ? reader[Constants.OUT_SUPPLY_ANY_OTHER_TTL].ToString().Trim() : string.Empty;
            //Vendor.NameofCompanies = null != reader[Constants.OUT_NAME_OF_COMPANIES] ? reader[Constants.OUT_NAME_OF_COMPANIES].ToString().Trim() : string.Empty;
            //Vendor.TypeofWorkDone = null != reader[Constants.OUT_TYPE_OF_WORK_DONE] ? reader[Constants.OUT_TYPE_OF_WORK_DONE].ToString().Trim() : string.Empty;




            return Vendor;
        }
    }
}
