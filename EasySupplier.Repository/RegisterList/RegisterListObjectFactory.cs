using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   

    internal class RegisterListObjectFactory : IDomainObjectFactory<RegisterList>
    {
        public RegisterList Construct(IDataReader reader)
        {
            RegisterList RegisterList = new RegisterList();

            RegisterList.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            RegisterList.EmpName = null != reader[Constants.OUT_EmpName] ? reader[Constants.OUT_EmpName].ToString().Trim() : string.Empty;
            RegisterList.PurchasingOrgDesc = null != reader[Constants.OUT_PurchasingOrgDesc] ? reader[Constants.OUT_PurchasingOrgDesc].ToString().Trim() : string.Empty;
           RegisterList.SAPVendorCode= null != reader[Constants.OUT_SAP_VENDOR_CODE] ? reader[Constants.OUT_SAP_VENDOR_CODE].ToString().Trim() : string.Empty;
            RegisterList.EstablishmentName = null != reader[Constants.OUT_EstablishmentName] ? reader[Constants.OUT_EstablishmentName].ToString().Trim() : string.Empty;
            RegisterList.CountryName = null != reader[Constants.OUT_CountryName] ? reader[Constants.OUT_CountryName].ToString().Trim() : string.Empty;
            RegisterList.ContactName = null != reader[Constants.OUT_ContactName] ? reader[Constants.OUT_ContactName].ToString().Trim() : string.Empty;
            RegisterList.ContactEmail = null != reader[Constants.OUT_ContactEmail] ? reader[Constants.OUT_ContactEmail].ToString().Trim() : string.Empty;
            RegisterList.ContactNo = null != reader[Constants.OUT_ContactNo] ? reader[Constants.OUT_ContactNo].ToString().Trim() : string.Empty;
            RegisterList.SubmitedDate = null != reader[Constants.OUT_SubmitedDate] ? Convert.ToDateTime(reader[Constants.OUT_SubmitedDate].ToString().Trim()) : DateTime.Today;
            RegisterList.Status = null != reader[Constants.OUT_Status] ? reader[Constants.OUT_Status].ToString().Trim() : string.Empty;
            RegisterList.WFStatusID = null != reader[Constants.OUT_WFStatusID] ? reader[Constants.OUT_WFStatusID].ToString().Trim() : string.Empty;
            RegisterList.ParentID = null != reader[Constants.OUT_ParentID] ? reader[Constants.OUT_ParentID].ToString().Trim() : string.Empty;
            RegisterList.SubmitFlag = null != reader[Constants.OUT_SubmitFlag] ? reader[Constants.OUT_SubmitFlag].ToString().Trim() : string.Empty;
            RegisterList.CompEmailId = null != reader[Constants.OUT_CompEmailId] ? reader[Constants.OUT_CompEmailId].ToString().Trim() : string.Empty;
            RegisterList.Visibility = null != reader[Constants.OUT_Visibility] ? reader[Constants.OUT_Visibility].ToString().Trim() : string.Empty;
            RegisterList.ShortName = null != reader[Constants.OUT_ShortName] ? reader[Constants.OUT_ShortName].ToString().Trim() : string.Empty;
            RegisterList.CreatedBy = null != reader[Constants.OUT_CreatedBy] ? reader[Constants.OUT_CreatedBy].ToString().Trim() : string.Empty;
            RegisterList.CreatedDate = null != reader[Constants.OUT_CreatedDate] ? Convert.ToDateTime(reader[Constants.OUT_CreatedDate].ToString().Trim()) : DateTime.Today;
            return RegisterList;
        }
    }
}
