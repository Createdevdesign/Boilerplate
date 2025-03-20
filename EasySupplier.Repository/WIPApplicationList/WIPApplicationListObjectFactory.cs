using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    


    internal class WIPApplicationListObjectFactory : IDomainObjectFactory<WIPApplicationList>
    {
        public WIPApplicationList Construct(IDataReader reader)
        {
            WIPApplicationList WIPApplicationList = new WIPApplicationList();

            WIPApplicationList.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            WIPApplicationList.EmpName = null != reader[Constants.OUT_EmpName] ? reader[Constants.OUT_EmpName].ToString().Trim() : string.Empty;
            WIPApplicationList.PurchasingOrgDesc = null != reader[Constants.OUT_PurchasingOrgDesc] ? reader[Constants.OUT_PurchasingOrgDesc].ToString().Trim() : string.Empty;
            WIPApplicationList.EstablishmentName = null != reader[Constants.OUT_EstablishmentName] ? reader[Constants.OUT_EstablishmentName].ToString().Trim() : string.Empty;
            WIPApplicationList.CountryName = null != reader[Constants.OUT_CountryName] ? reader[Constants.OUT_CountryName].ToString().Trim() : string.Empty;
            WIPApplicationList.ContactName = null != reader[Constants.OUT_ContactName] ? reader[Constants.OUT_ContactName].ToString().Trim() : string.Empty;
            WIPApplicationList.ContactEmail = null != reader[Constants.OUT_ContactEmail] ? reader[Constants.OUT_ContactEmail].ToString().Trim() : string.Empty;
            WIPApplicationList.ContactNo = null != reader[Constants.OUT_ContactNo] ? reader[Constants.OUT_ContactNo].ToString().Trim() : string.Empty;
            WIPApplicationList.SubmitedDate = null != reader[Constants.OUT_SubmitedDate] ? Convert.ToDateTime(reader[Constants.OUT_SubmitedDate].ToString().Trim()) : DateTime.Today;       
            WIPApplicationList.Status = null != reader[Constants.OUT_Status] ? reader[Constants.OUT_Status].ToString().Trim() : string.Empty;
            WIPApplicationList.WFStatusID = null != reader[Constants.OUT_WFStatusID] ? reader[Constants.OUT_WFStatusID].ToString().Trim() : string.Empty;
            WIPApplicationList.ParentID = null != reader[Constants.OUT_ParentID] ? reader[Constants.OUT_ParentID].ToString().Trim() : string.Empty;
            WIPApplicationList.SubmitFlag = null != reader[Constants.OUT_SubmitFlag] ? reader[Constants.OUT_SubmitFlag].ToString().Trim() : string.Empty;
            WIPApplicationList.CompEmailId = null != reader[Constants.OUT_CompEmailId] ? reader[Constants.OUT_CompEmailId].ToString().Trim() : string.Empty;
            WIPApplicationList.Visibility = null != reader[Constants.OUT_Visibility] ? reader[Constants.OUT_Visibility].ToString().Trim() : string.Empty;
            WIPApplicationList.ShortName = null != reader[Constants.OUT_ShortName] ? reader[Constants.OUT_ShortName].ToString().Trim() : string.Empty;
            WIPApplicationList.CreatedBy = null != reader[Constants.OUT_CreatedBy] ? reader[Constants.OUT_CreatedBy].ToString().Trim() : string.Empty;          
            WIPApplicationList.CreatedDate = null != reader[Constants.OUT_CreatedDate] ? Convert.ToDateTime(reader[Constants.OUT_CreatedDate].ToString().Trim()) : DateTime.Today;
            return WIPApplicationList;
        }
    }
}
