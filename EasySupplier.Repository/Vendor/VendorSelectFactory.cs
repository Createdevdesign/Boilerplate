using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
   
    internal class VendorSelectFactory : ISelectionFactory<Vendor>
    {
        public IDbCommand ConstructSelectCommand(Vendor idObject)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            if (idObject.TabIndex == 0)
            {
                sqlCommand.Parameters.Add(Constants.PN_TAB_INDEX, SqlDbType.Int, 4).Value = idObject.TabIndex;
                sqlCommand.Parameters.Add(Constants.PS_LOGIN_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.LoginEmailID;
                //Info
                sqlCommand.Parameters.Add(Constants.PS_GST_IN, SqlDbType.VarChar, 50).Value = idObject.GSTIN;
                sqlCommand.Parameters.Add(Constants.PS_PAN_NO, SqlDbType.VarChar, 20).Value = idObject.PANNo;
                sqlCommand.Parameters.Add(Constants.PS_VAT_REGISTRATION, SqlDbType.NVarChar, 255).Value = idObject.VATRegistration;
                sqlCommand.Parameters.Add(Constants.PS_TAX_NUMBER, SqlDbType.VarChar, 50).Value = idObject.TaxNumber;
                sqlCommand.Parameters.Add(Constants.PS_COUNTRY, SqlDbType.VarChar, 50).Value = idObject.Country;

                sqlCommand.Parameters.Add(Constants.PS_TITLE, SqlDbType.VarChar, 20).Value = idObject.Title;
                sqlCommand.Parameters.Add(Constants.PS_ORGANISATION_TYPE, SqlDbType.VarChar, 200).Value = idObject.OrganisationType;
                sqlCommand.Parameters.Add(Constants.PS_Establishment_Name, SqlDbType.VarChar, 50).Value = idObject.EstablishmentName;
                sqlCommand.Parameters.Add(Constants.PS_SHORT_NAME, SqlDbType.NVarChar, 30).Value = idObject.ShortName;
                sqlCommand.Parameters.Add(Constants.PS_NO_OF_EMPLOYEES, SqlDbType.VarChar, 50).Value = idObject.NoofEmployees;

                sqlCommand.Parameters.Add(Constants.PS_COMP_URL, SqlDbType.NVarChar, 50).Value = idObject.CompUrl;
                sqlCommand.Parameters.Add(Constants.PS_COMP_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.CompEmailID;
                sqlCommand.Parameters.Add(Constants.PS_HOUSE_NO, SqlDbType.VarChar, 10).Value = idObject.HouseNo;
                sqlCommand.Parameters.Add(Constants.PS_OFFICE_ADDRESS, SqlDbType.NVarChar, 60).Value = idObject.OfficeAddress;
                sqlCommand.Parameters.Add(Constants.PS_STREET2, SqlDbType.NVarChar, 40).Value = idObject.Street2;

                sqlCommand.Parameters.Add(Constants.PS_STREET3, SqlDbType.NVarChar, 40).Value = idObject.Street3;
                sqlCommand.Parameters.Add(Constants.PS_REG_STATE, SqlDbType.VarChar, 30).Value = idObject.RegState;
                sqlCommand.Parameters.Add(Constants.PS_REG_CITY, SqlDbType.VarChar, 40).Value = idObject.RegCity;
                sqlCommand.Parameters.Add(Constants.PS_REG_POSTAL_CODE, SqlDbType.VarChar, 10).Value = idObject.RegPostalCode;
                sqlCommand.Parameters.Add(Constants.PS_COMP_TELEPHONE_NO, SqlDbType.VarChar, 50).Value = idObject.CompTelephoneNo;

                sqlCommand.Parameters.Add(Constants.PS_COMP_MOBILE_NO, SqlDbType.VarChar, 50).Value = idObject.CompMobileNo;
                sqlCommand.Parameters.Add(Constants.PS_FAX_NO, SqlDbType.VarChar, 50).Value = idObject.FaxNo;
                sqlCommand.Parameters.Add(Constants.PS_SUPPLIER_TYPE, SqlDbType.NVarChar, 500).Value = idObject.SupplierType;

                sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
                sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
                sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_VENDOR_ALL;
                return sqlCommand;


            }
            else if (idObject.TabIndex == 1)
            {
                sqlCommand.Parameters.Add(Constants.PN_TAB_INDEX, SqlDbType.Int, 4).Value = idObject.TabIndex;
                sqlCommand.Parameters.Add(Constants.PS_LOGIN_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.LoginEmailID;

                //Bank Info
                sqlCommand.Parameters.Add(Constants.PS_BANK_COUNTRY, SqlDbType.VarChar, 50).Value = idObject.BankCountry;
                sqlCommand.Parameters.Add(Constants.PS_CURRENCY, SqlDbType.VarChar, 50).Value = idObject.Currency;
                sqlCommand.Parameters.Add(Constants.PS_BENEFICIARY_NAME, SqlDbType.NVarChar, 50).Value = idObject.BeneficiaryName;
                sqlCommand.Parameters.Add(Constants.PS_BENEFICIARY_ACCOUNT_NO, SqlDbType.VarChar, 30).Value = idObject.BeneficiaryAccountNo;
                sqlCommand.Parameters.Add(Constants.PS_BANK_NAME, SqlDbType.NVarChar, 30).Value = idObject.BankName;

                sqlCommand.Parameters.Add(Constants.PS_BENEFICIARY_BRANCH, SqlDbType.NVarChar, 30).Value = idObject.BeneficiaryBranch;
                sqlCommand.Parameters.Add(Constants.PS_BENEFICIARY_ADDRESS, SqlDbType.NVarChar, 50).Value = idObject.BeneficiaryAddress;
                sqlCommand.Parameters.Add(Constants.PS_ACCOUNT_TYPE, SqlDbType.VarChar, 20).Value = idObject.AccountType;
                sqlCommand.Parameters.Add(Constants.PS_IFSC_CODE, SqlDbType.NVarChar, 50).Value = idObject.IFSCCode;
                sqlCommand.Parameters.Add(Constants.PS_SWIFTBIC_CODE, SqlDbType.NVarChar, 30).Value = idObject.SWIFTBICCode;

                sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
                sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
                sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_VENDOR_ALL;
                return sqlCommand;
            }
            else if (idObject.TabIndex == 2)
            {
                sqlCommand.Parameters.Add(Constants.PN_TAB_INDEX, SqlDbType.Int, 4).Value = idObject.TabIndex;
                sqlCommand.Parameters.Add(Constants.PS_LOGIN_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.LoginEmailID;

                //Fin Info
                sqlCommand.Parameters.Add(Constants.PS_REGISTRATION_DATE, SqlDbType.DateTime, 50).Value = idObject.RegistrationDate;
                sqlCommand.Parameters.Add(Constants.PS_FINANCIAL_YEAR1, SqlDbType.VarChar, 50).Value = idObject.FinancialYear1;
                sqlCommand.Parameters.Add(Constants.PS_FINANCIAL_YEAR2, SqlDbType.VarChar, 50).Value = idObject.FinancialYear2;
                sqlCommand.Parameters.Add(Constants.PS_FINANCIAL_YEAR3, SqlDbType.VarChar, 50).Value = idObject.FinancialYear3;
                sqlCommand.Parameters.Add(Constants.PN_PROFIT1, SqlDbType.Decimal, 18).Value = idObject.Profit1;

                sqlCommand.Parameters.Add(Constants.PN_PROFIT2, SqlDbType.Decimal, 18).Value = idObject.Profit2;
                sqlCommand.Parameters.Add(Constants.PN_PROFIT3, SqlDbType.Decimal, 18).Value = idObject.Profit3;
                sqlCommand.Parameters.Add(Constants.PN_TURNOVER1, SqlDbType.Decimal, 18).Value = idObject.Turnover1;
                sqlCommand.Parameters.Add(Constants.PN_TURNOVER2, SqlDbType.Decimal, 18).Value = idObject.Turnover2;
                sqlCommand.Parameters.Add(Constants.PN_TURNOVER3, SqlDbType.Decimal, 18).Value = idObject.Turnover3;

                sqlCommand.Parameters.Add(Constants.PS_ONLINE_CATALOG, SqlDbType.VarChar, 50).Value = idObject.OnlineCatalog;
                sqlCommand.Parameters.Add(Constants.PS_ONLINE_ORDERING, SqlDbType.VarChar, 50).Value = idObject.OnlineOrdering;
                sqlCommand.Parameters.Add(Constants.PS_ONLINE_ORDER_TRACKING, SqlDbType.VarChar, 50).Value = idObject.OnlineOrderTracking;
                sqlCommand.Parameters.Add(Constants.PS_ONLINE_EAUCTIONS, SqlDbType.VarChar, 50).Value = idObject.OnlineEauctions;
                sqlCommand.Parameters.Add(Constants.PS_MINORITY_INDICATOR_NAME, SqlDbType.VarChar, 100).Value = idObject.MinorityIndicatorName;

                sqlCommand.Parameters.Add(Constants.PS_MINORITY_INDICATOR_DATE, SqlDbType.DateTime, 50).Value = idObject.MinorityIndicatorDate;

                sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
                sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
                sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_VENDOR_ALL;
                return sqlCommand;
            }
            else if (idObject.TabIndex == 3)
            {
                sqlCommand.Parameters.Add(Constants.PN_TAB_INDEX, SqlDbType.Int, 4).Value = idObject.TabIndex;
                sqlCommand.Parameters.Add(Constants.PS_LOGIN_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.LoginEmailID;

                //Certification
                sqlCommand.Parameters.Add(Constants.PS_ISO_9001, SqlDbType.VarChar, 10).Value = idObject.ISO9001;
                sqlCommand.Parameters.Add(Constants.PS_DATE_ISO_9001, SqlDbType.DateTime, 50).Value = idObject.DateISO9001;
                sqlCommand.Parameters.Add(Constants.PS_ISO_27001, SqlDbType.VarChar, 10).Value = idObject.ISO27001;
                sqlCommand.Parameters.Add(Constants.PS_DATE_ISO_27001, SqlDbType.DateTime, 50).Value = idObject.DateISO27001;
                sqlCommand.Parameters.Add(Constants.PS_C_9100, SqlDbType.VarChar, 10).Value = idObject.C9100;

                sqlCommand.Parameters.Add(Constants.PS_DATE_C_9100, SqlDbType.DateTime, 50).Value = idObject.DateC9100;
                sqlCommand.Parameters.Add(Constants.PS_QMS_AVAILABLE_AT_THE_SUPPLIERS_SITE, SqlDbType.VarChar, 10).Value = idObject.QMSAvailableAtTheSuppliersSite;
                sqlCommand.Parameters.Add(Constants.PS_ENVIRONMENT_MANAGEMENT_SYSTEM, SqlDbType.VarChar, 10).Value = idObject.EnvironmentManagementSystem;
                sqlCommand.Parameters.Add(Constants.PS_WORKERS_COMPENSATION_INSURANCE_POLICY, SqlDbType.VarChar, 10).Value = idObject.WorkersCompensationInsurancePolicy;
                sqlCommand.Parameters.Add(Constants.PS_OWN_SUPPLIERS_AND_SUB_CONTRACTORS, SqlDbType.VarChar, 10).Value = idObject.OwnSuppliersAndSubContractors;

                sqlCommand.Parameters.Add(Constants.PS_PUBLIC_LIABILITY_INSURANCE_POLICY, SqlDbType.VarChar, 10).Value = idObject.PublicLiabilityInsurancePolicy;
                sqlCommand.Parameters.Add(Constants.PS_SUPPLIER_DUE_DILIGENCE_REQUIREMENTS, SqlDbType.VarChar, 10).Value = idObject.SupplierDueDiligenceRequirements;
                sqlCommand.Parameters.Add(Constants.PS_INDEMNITY_INSURANCE_POLICY, SqlDbType.VarChar, 10).Value = idObject.IndemnityInsurancePolicy;
                sqlCommand.Parameters.Add(Constants.PS_QUALITY_ENVIRONMENTAL_STANDARDS, SqlDbType.VarChar, 10).Value = idObject.QualityEnvironmentalStandards;

                sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
                sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
                sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_VENDOR_ALL;
                return sqlCommand;
            }
            else if (idObject.TabIndex == 4)
            {
                sqlCommand.Parameters.Add(Constants.PN_TAB_INDEX, SqlDbType.Int, 4).Value = idObject.TabIndex;
                sqlCommand.Parameters.Add(Constants.PS_LOGIN_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.LoginEmailID;

                //References
                sqlCommand.Parameters.Add(Constants.PS_REF_CUSTOMERS_NAME, SqlDbType.VarChar, 50).Value = idObject.RefCustomersName;
                sqlCommand.Parameters.Add(Constants.PS_REF_CONTACT_PERSON, SqlDbType.VarChar, 50).Value = idObject.RefContactPerson;
                sqlCommand.Parameters.Add(Constants.PS_REF_DESIGNATION, SqlDbType.VarChar, 50).Value = idObject.RefDesignation;
                sqlCommand.Parameters.Add(Constants.PS_REF_CONTACT_NO, SqlDbType.VarChar, 50).Value = idObject.RefContactNo;
                sqlCommand.Parameters.Add(Constants.PS_REF_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.RefEmailID;

                sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
                sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
                sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_VENDOR_ALL;
                return sqlCommand;

            }
            else if (idObject.TabIndex == 5)
            {
                sqlCommand.Parameters.Add(Constants.PN_TAB_INDEX, SqlDbType.Int, 4).Value = idObject.TabIndex;
                sqlCommand.Parameters.Add(Constants.PS_LOGIN_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.LoginEmailID;
                //Additional
                sqlCommand.Parameters.Add(Constants.PS_MOB, SqlDbType.VarChar, 10).Value = idObject.MOB;
                sqlCommand.Parameters.Add(Constants.PS_WOB, SqlDbType.VarChar, 10).Value = idObject.WOB;
                sqlCommand.Parameters.Add(Constants.PS_VOB, SqlDbType.VarChar, 10).Value = idObject.VOB;
                sqlCommand.Parameters.Add(Constants.PS_LGBTOB, SqlDbType.VarChar, 10).Value = idObject.LGBTOB;
                sqlCommand.Parameters.Add(Constants.PS_SDVOB, SqlDbType.VarChar, 10).Value = idObject.SDVOB;

                sqlCommand.Parameters.Add(Constants.PS_SB, SqlDbType.VarChar, 10).Value = idObject.SB;
                sqlCommand.Parameters.Add(Constants.PS_SDB, SqlDbType.VarChar, 10).Value = idObject.SDB;
                sqlCommand.Parameters.Add(Constants.PS_WOSB, SqlDbType.VarChar, 10).Value = idObject.WOSB;
                sqlCommand.Parameters.Add(Constants.PS_HUSB, SqlDbType.VarChar, 10).Value = idObject.HUSB;
                sqlCommand.Parameters.Add(Constants.PS_VOSB, SqlDbType.VarChar, 10).Value = idObject.VOSB;

                sqlCommand.Parameters.Add(Constants.PS_SDVOSB, SqlDbType.VarChar, 10).Value = idObject.SDVOSB;
                sqlCommand.Parameters.Add(Constants.PS_EDWOSB, SqlDbType.VarChar, 10).Value = idObject.EDWOSB;
                sqlCommand.Parameters.Add(Constants.PS_MBE, SqlDbType.VarChar, 10).Value = idObject.MBE;
                sqlCommand.Parameters.Add(Constants.PS_DBE, SqlDbType.VarChar, 10).Value = idObject.DBE;
                sqlCommand.Parameters.Add(Constants.PS_SBE, SqlDbType.VarChar, 10).Value = idObject.SBE;

                sqlCommand.Parameters.Add(Constants.PS_SWAM, SqlDbType.VarChar, 10).Value = idObject.SWAM;
                sqlCommand.Parameters.Add(Constants.PS_LGBT, SqlDbType.VarChar, 10).Value = idObject.LGBT;
                sqlCommand.Parameters.Add(Constants.PS_SUPPLY_ANY_OTHER_TTL, SqlDbType.VarChar, 10).Value = idObject.SupplyAnyOtherTTL;
                sqlCommand.Parameters.Add(Constants.PS_NAME_OF_COMPANIES, SqlDbType.VarChar, 50).Value = idObject.NameofCompanies;
                sqlCommand.Parameters.Add(Constants.PS_TYPE_OF_WORK_DONE, SqlDbType.VarChar, 50).Value = idObject.TypeofWorkDone;

                sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
                sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
                sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_VENDOR_ALL;
                return sqlCommand;
            }
            //1-6-2021 
            else if (idObject.TabIndex == 6)
            {
                sqlCommand.Parameters.Add(Constants.PN_TAB_INDEX, SqlDbType.Int, 4).Value = idObject.TabIndex;
                sqlCommand.Parameters.Add(Constants.PS_LOGIN_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.LoginEmailID;
                
                sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
                sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
                sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_VENDOR_ALL;
                return sqlCommand;
            }
            else if (idObject.TabIndex == 7)
            {
                sqlCommand.Parameters.Add(Constants.PN_TAB_INDEX, SqlDbType.Int, 4).Value = idObject.TabIndex;
                sqlCommand.Parameters.Add(Constants.PS_LOGIN_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.LoginEmailID;

                sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
                sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
                sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_VENDOR_ALL;
                return sqlCommand;
            }

            //28-8-2021 Submit flag update 
            else if (idObject.TabIndex == 9)
            {
                sqlCommand.Parameters.Add(Constants.PN_TAB_INDEX, SqlDbType.Int, 4).Value = idObject.TabIndex;
                sqlCommand.Parameters.Add(Constants.PS_LOGIN_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.LoginEmailID;

                sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
                sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
                sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_VENDOR_ALL;
                return sqlCommand;
            }

            else
            {
                //sqlCommand.Parameters.Add(Constants.PN_TAB_INDEX, SqlDbType.Int, 4).Value = idObject.TabIndex;
                //sqlCommand.Parameters.Add(Constants.PS_LOGIN_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.LoginEmailID;

                //sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
                //sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
                //sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                //sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_VENDOR_ALL;
                return sqlCommand;

                //sqlCommand.Parameters.Add(Constants.PN_TAB_INDEX, SqlDbType.Int, 4).Value = idObject.TabIndex;
                //sqlCommand.Parameters.Add(Constants.PS_LOGIN_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.LoginEmailID;
                ////Info
                //sqlCommand.Parameters.Add(Constants.PS_GST_IN, SqlDbType.VarChar, 50).Value = idObject.GSTIN;
                //sqlCommand.Parameters.Add(Constants.PS_PAN_NO, SqlDbType.VarChar, 20).Value = idObject.PANNo;
                //sqlCommand.Parameters.Add(Constants.PS_VAT_REGISTRATION, SqlDbType.NVarChar, 255).Value = idObject.VATRegistration;
                //sqlCommand.Parameters.Add(Constants.PS_TAX_NUMBER, SqlDbType.VarChar, 50).Value = idObject.TaxNumber;
                //sqlCommand.Parameters.Add(Constants.PS_COUNTRY, SqlDbType.VarChar, 50).Value = idObject.Country;

                //sqlCommand.Parameters.Add(Constants.PS_TITLE, SqlDbType.VarChar, 20).Value = idObject.Title;
                //sqlCommand.Parameters.Add(Constants.PS_ORGANISATION_TYPE, SqlDbType.VarChar, 200).Value = idObject.OrganisationType;
                //    //sqlCommand.Parameters.Add(Constants.PS_ORG_TYPE_NAME, SqlDbType.VarChar, 50).Value = idObject.OrgTypeName;
                //    sqlCommand.Parameters.Add(Constants.PS_Establishment_Name, SqlDbType.VarChar, 50).Value = idObject.EstablishmentName;
                //    sqlCommand.Parameters.Add(Constants.PS_SHORT_NAME, SqlDbType.NVarChar, 30).Value = idObject.ShortName;
                //sqlCommand.Parameters.Add(Constants.PS_NO_OF_EMPLOYEES, SqlDbType.VarChar, 50).Value = idObject.NoofEmployees;

                //sqlCommand.Parameters.Add(Constants.PS_COMP_URL, SqlDbType.NVarChar, 50).Value = idObject.CompUrl;
                //sqlCommand.Parameters.Add(Constants.PS_COMP_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.CompEmailID;
                //sqlCommand.Parameters.Add(Constants.PS_HOUSE_NO, SqlDbType.VarChar, 10).Value = idObject.HouseNo;
                //sqlCommand.Parameters.Add(Constants.PS_OFFICE_ADDRESS, SqlDbType.NVarChar, 60).Value = idObject.OfficeAddress;
                //sqlCommand.Parameters.Add(Constants.PS_STREET2, SqlDbType.NVarChar, 40).Value = idObject.Street2;

                //sqlCommand.Parameters.Add(Constants.PS_STREET3, SqlDbType.NVarChar, 40).Value = idObject.Street3;
                //sqlCommand.Parameters.Add(Constants.PS_REG_STATE, SqlDbType.VarChar, 30).Value = idObject.RegState;
                //sqlCommand.Parameters.Add(Constants.PS_REG_CITY, SqlDbType.VarChar, 40).Value = idObject.RegCity;
                //sqlCommand.Parameters.Add(Constants.PS_REG_POSTAL_CODE, SqlDbType.VarChar, 10).Value = idObject.RegPostalCode;
                //sqlCommand.Parameters.Add(Constants.PS_COMP_TELEPHONE_NO, SqlDbType.VarChar, 50).Value = idObject.CompTelephoneNo;

                //sqlCommand.Parameters.Add(Constants.PS_COMP_MOBILE_NO, SqlDbType.VarChar, 50).Value = idObject.CompMobileNo;
                //sqlCommand.Parameters.Add(Constants.PS_FAX_NO, SqlDbType.VarChar, 50).Value = idObject.FaxNo;
                //sqlCommand.Parameters.Add(Constants.PS_SUPPLIER_TYPE, SqlDbType.NVarChar, 500).Value = idObject.SupplierType;
                ////Bank Info
                //sqlCommand.Parameters.Add(Constants.PS_BANK_COUNTRY, SqlDbType.VarChar, 50).Value = idObject.BankCountry;
                //sqlCommand.Parameters.Add(Constants.PS_CURRENCY, SqlDbType.VarChar, 50).Value = idObject.Currency;
                //sqlCommand.Parameters.Add(Constants.PS_BENEFICIARY_NAME, SqlDbType.NVarChar, 50).Value = idObject.BeneficiaryName;
                //sqlCommand.Parameters.Add(Constants.PS_BENEFICIARY_ACCOUNT_NO, SqlDbType.VarChar, 30).Value = idObject.BeneficiaryAccountNo;
                //sqlCommand.Parameters.Add(Constants.PS_BANK_NAME, SqlDbType.NVarChar, 30).Value = idObject.BankName;

                //sqlCommand.Parameters.Add(Constants.PS_BENEFICIARY_BRANCH, SqlDbType.NVarChar, 30).Value = idObject.BeneficiaryBranch;
                //sqlCommand.Parameters.Add(Constants.PS_BENEFICIARY_ADDRESS, SqlDbType.NVarChar, 50).Value = idObject.BeneficiaryAddress;
                //sqlCommand.Parameters.Add(Constants.PS_ACCOUNT_TYPE, SqlDbType.VarChar, 20).Value = idObject.AccountType;
                //sqlCommand.Parameters.Add(Constants.PS_IFSC_CODE, SqlDbType.NVarChar, 50).Value = idObject.IFSCCode;
                //sqlCommand.Parameters.Add(Constants.PS_SWIFTBIC_CODE, SqlDbType.NVarChar, 30).Value = idObject.SWIFTBICCode;
                ////Fin Info
                //sqlCommand.Parameters.Add(Constants.PS_REGISTRATION_DATE, SqlDbType.DateTime, 50).Value = idObject.RegistrationDate;
                //sqlCommand.Parameters.Add(Constants.PS_FINANCIAL_YEAR1, SqlDbType.VarChar, 50).Value = idObject.FinancialYear1;
                //sqlCommand.Parameters.Add(Constants.PS_FINANCIAL_YEAR2, SqlDbType.VarChar, 50).Value = idObject.FinancialYear2;
                //sqlCommand.Parameters.Add(Constants.PS_FINANCIAL_YEAR3, SqlDbType.VarChar, 50).Value = idObject.FinancialYear3;
                //sqlCommand.Parameters.Add(Constants.PN_PROFIT1, SqlDbType.Decimal, 18).Value = idObject.Profit1;

                //sqlCommand.Parameters.Add(Constants.PN_PROFIT2, SqlDbType.Decimal, 18).Value = idObject.Profit2;
                //sqlCommand.Parameters.Add(Constants.PN_PROFIT3, SqlDbType.Decimal, 18).Value = idObject.Profit3;
                //sqlCommand.Parameters.Add(Constants.PN_TURNOVER1, SqlDbType.Decimal, 18).Value = idObject.Turnover1;
                //sqlCommand.Parameters.Add(Constants.PN_TURNOVER2, SqlDbType.Decimal, 18).Value = idObject.Turnover2;
                //sqlCommand.Parameters.Add(Constants.PN_TURNOVER3, SqlDbType.Decimal, 18).Value = idObject.Turnover3;

                //sqlCommand.Parameters.Add(Constants.PS_ONLINE_CATALOG, SqlDbType.VarChar, 50).Value = idObject.OnlineCatalog;
                //sqlCommand.Parameters.Add(Constants.PS_ONLINE_ORDERING, SqlDbType.VarChar, 50).Value = idObject.OnlineOrdering;
                //sqlCommand.Parameters.Add(Constants.PS_ONLINE_ORDER_TRACKING, SqlDbType.VarChar, 50).Value = idObject.OnlineOrderTracking;
                //sqlCommand.Parameters.Add(Constants.PS_ONLINE_EAUCTIONS, SqlDbType.VarChar, 50).Value = idObject.OnlineEauctions;
                //sqlCommand.Parameters.Add(Constants.PS_MINORITY_INDICATOR_NAME, SqlDbType.VarChar, 100).Value = idObject.MinorityIndicatorName;

                //sqlCommand.Parameters.Add(Constants.PS_MINORITY_INDICATOR_DATE, SqlDbType.DateTime, 50).Value = idObject.MinorityIndicatorDate;

                ////Certification
                //sqlCommand.Parameters.Add(Constants.PS_ISO_9001, SqlDbType.VarChar, 10).Value = idObject.ISO9001;
                //sqlCommand.Parameters.Add(Constants.PS_DATE_ISO_9001, SqlDbType.DateTime, 50).Value = idObject.DateISO9001;
                //sqlCommand.Parameters.Add(Constants.PS_ISO_27001, SqlDbType.VarChar, 10).Value = idObject.ISO27001;
                //sqlCommand.Parameters.Add(Constants.PS_DATE_ISO_27001, SqlDbType.DateTime, 50).Value = idObject.DateISO27001;
                //sqlCommand.Parameters.Add(Constants.PS_C_9100, SqlDbType.VarChar, 10).Value = idObject.C9100;

                //sqlCommand.Parameters.Add(Constants.PS_DATE_C_9100, SqlDbType.DateTime, 50).Value = idObject.DateC9100;
                //sqlCommand.Parameters.Add(Constants.PS_QMS_AVAILABLE_AT_THE_SUPPLIERS_SITE, SqlDbType.VarChar, 10).Value = idObject.QMSAvailableAtTheSuppliersSite;
                //sqlCommand.Parameters.Add(Constants.PS_ENVIRONMENT_MANAGEMENT_SYSTEM, SqlDbType.VarChar, 10).Value = idObject.EnvironmentManagementSystem;
                //sqlCommand.Parameters.Add(Constants.PS_WORKERS_COMPENSATION_INSURANCE_POLICY, SqlDbType.VarChar, 10).Value = idObject.WorkersCompensationInsurancePolicy;
                //sqlCommand.Parameters.Add(Constants.PS_OWN_SUPPLIERS_AND_SUB_CONTRACTORS, SqlDbType.VarChar, 10).Value = idObject.OwnSuppliersAndSubContractors;

                //sqlCommand.Parameters.Add(Constants.PS_PUBLIC_LIABILITY_INSURANCE_POLICY, SqlDbType.VarChar, 10).Value = idObject.PublicLiabilityInsurancePolicy;
                //sqlCommand.Parameters.Add(Constants.PS_SUPPLIER_DUE_DILIGENCE_REQUIREMENTS, SqlDbType.VarChar, 10).Value = idObject.SupplierDueDiligenceRequirements;
                //sqlCommand.Parameters.Add(Constants.PS_INDEMNITY_INSURANCE_POLICY, SqlDbType.VarChar, 10).Value = idObject.IndemnityInsurancePolicy;
                //sqlCommand.Parameters.Add(Constants.PS_QUALITY_ENVIRONMENTAL_STANDARDS, SqlDbType.VarChar, 10).Value = idObject.QualityEnvironmentalStandards;

                ////References
                //sqlCommand.Parameters.Add(Constants.PS_REF_CUSTOMERS_NAME, SqlDbType.VarChar, 50).Value = idObject.RefCustomersName;
                //sqlCommand.Parameters.Add(Constants.PS_REF_CONTACT_PERSON, SqlDbType.VarChar, 50).Value = idObject.RefContactPerson;
                //sqlCommand.Parameters.Add(Constants.PS_REF_DESIGNATION, SqlDbType.VarChar, 50).Value = idObject.RefDesignation;
                //sqlCommand.Parameters.Add(Constants.PS_REF_CONTACT_NO, SqlDbType.VarChar, 50).Value = idObject.RefContactNo;
                //sqlCommand.Parameters.Add(Constants.PS_REF_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.RefEmailID;

                ////Additional
                //sqlCommand.Parameters.Add(Constants.PS_MOB, SqlDbType.VarChar, 10).Value = idObject.MOB;
                //sqlCommand.Parameters.Add(Constants.PS_WOB, SqlDbType.VarChar, 10).Value = idObject.WOB;
                //sqlCommand.Parameters.Add(Constants.PS_VOB, SqlDbType.VarChar, 10).Value = idObject.VOB;
                //sqlCommand.Parameters.Add(Constants.PS_LGBTOB, SqlDbType.VarChar, 10).Value = idObject.LGBTOB;
                //sqlCommand.Parameters.Add(Constants.PS_SDVOB, SqlDbType.VarChar, 10).Value = idObject.SDVOB;

                //sqlCommand.Parameters.Add(Constants.PS_SB, SqlDbType.VarChar, 10).Value = idObject.SB;
                //sqlCommand.Parameters.Add(Constants.PS_SDB, SqlDbType.VarChar, 10).Value = idObject.SDB;
                //sqlCommand.Parameters.Add(Constants.PS_WOSB, SqlDbType.VarChar, 10).Value = idObject.WOSB;
                //sqlCommand.Parameters.Add(Constants.PS_HUSB, SqlDbType.VarChar, 10).Value = idObject.HUSB;
                //sqlCommand.Parameters.Add(Constants.PS_VOSB, SqlDbType.VarChar, 10).Value = idObject.VOSB;

                //sqlCommand.Parameters.Add(Constants.PS_SDVOSB, SqlDbType.VarChar, 10).Value = idObject.SDVOSB;
                //sqlCommand.Parameters.Add(Constants.PS_EDWOSB, SqlDbType.VarChar, 10).Value = idObject.EDWOSB;
                //sqlCommand.Parameters.Add(Constants.PS_MBE, SqlDbType.VarChar, 10).Value = idObject.MBE;
                //sqlCommand.Parameters.Add(Constants.PS_DBE, SqlDbType.VarChar, 10).Value = idObject.DBE;
                //sqlCommand.Parameters.Add(Constants.PS_SBE, SqlDbType.VarChar, 10).Value = idObject.SBE;

                //sqlCommand.Parameters.Add(Constants.PS_SWAM, SqlDbType.VarChar, 10).Value = idObject.SWAM;
                //sqlCommand.Parameters.Add(Constants.PS_LGBT, SqlDbType.VarChar, 10).Value = idObject.LGBT;
                //sqlCommand.Parameters.Add(Constants.PS_SUPPLY_ANY_OTHER_TTL, SqlDbType.VarChar, 10).Value = idObject.SupplyAnyOtherTTL;
                //sqlCommand.Parameters.Add(Constants.PS_NAME_OF_COMPANIES, SqlDbType.VarChar, 50).Value = idObject.NameofCompanies;
                //sqlCommand.Parameters.Add(Constants.PS_TYPE_OF_WORK_DONE, SqlDbType.VarChar, 50).Value = idObject.TypeofWorkDone;

                //sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
                //sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
                //sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                //sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;

                //sqlCommand.CommandType = CommandType.StoredProcedure;
                //sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_VENDOR_ALL;
                //return sqlCommand;
            }
        }
    }
}
