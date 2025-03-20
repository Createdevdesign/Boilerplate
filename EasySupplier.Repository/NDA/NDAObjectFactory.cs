using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
  

    internal class NDAObjectFactory : IDomainObjectFactory<NDAApp>
    {
        public NDAApp Construct(IDataReader reader)
        {
            NDAApp NDAApp = new NDAApp();

            NDAApp.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            NDAApp.EstablishmentName = null != reader[Constants.OUT_EstablishmentName] ? reader[Constants.OUT_EstablishmentName].ToString().Trim() : string.Empty;
            NDAApp.OfficeAddress = null != reader[Constants.OUT_OFFICE_ADDRESS] ? reader[Constants.OUT_OFFICE_ADDRESS].ToString().Trim() : string.Empty;
            NDAApp.Name = null != reader[Constants.OUT_NAME] ? reader[Constants.OUT_NAME].ToString().Trim() : string.Empty;
            NDAApp.Designation = null != reader[Constants.OUT_DESIGNATION] ? reader[Constants.OUT_DESIGNATION].ToString().Trim() : string.Empty;
            NDAApp.PurchasingOrgName = null != reader[Constants.OUT_PURCHASING_ORG_NAME] ? reader[Constants.OUT_PURCHASING_ORG_NAME].ToString().Trim() : string.Empty;
            NDAApp.PurchasingOrgCode = null != reader[Constants.OUT_PURCHASING_ORG_CODE] ? reader[Constants.OUT_PURCHASING_ORG_CODE].ToString().Trim() : string.Empty;
           
            return NDAApp;
        }
    }
}
