using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    

    internal class TabVerifyAcceptDetailsObjectFactory : IDomainObjectFactory<TabVerifyAccept>
    {
        public TabVerifyAccept Construct(IDataReader reader)
        {
            TabVerifyAccept TabVerifyAcceptDetails = new TabVerifyAccept();


            TabVerifyAcceptDetails.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            TabVerifyAcceptDetails.Info = null != reader[Constants.OUT_INFO] ? Convert.ToInt32(reader[Constants.OUT_INFO].ToString().Trim()) : 0;
            TabVerifyAcceptDetails.Bank = null != reader[Constants.OUT_BANK] ? Convert.ToInt32(reader[Constants.OUT_BANK].ToString().Trim()) : 0;
            TabVerifyAcceptDetails.Financial = null != reader[Constants.OUT_FINANCIAL] ? Convert.ToInt32(reader[Constants.OUT_FINANCIAL].ToString().Trim()) : 0;
            TabVerifyAcceptDetails.Certificates = null != reader[Constants.OUT_CERTIFICATES] ? Convert.ToInt32(reader[Constants.OUT_CERTIFICATES].ToString().Trim()) : 0;
            TabVerifyAcceptDetails.Reference = null != reader[Constants.OUT_REFERENCE] ? Convert.ToInt32(reader[Constants.OUT_REFERENCE].ToString().Trim()) : 0;
            TabVerifyAcceptDetails.Additional = null != reader[Constants.OUT_ADDITIONAL] ? Convert.ToInt32(reader[Constants.OUT_ADDITIONAL].ToString().Trim()) : 0;
            TabVerifyAcceptDetails.NDA = null != reader[Constants.OUT_NDA] ? Convert.ToInt32(reader[Constants.OUT_NDA].ToString().Trim()) : 0;
            TabVerifyAcceptDetails.Documents = null != reader[Constants.OUT_DOCUMENTS] ? Convert.ToInt32(reader[Constants.OUT_DOCUMENTS].ToString().Trim()) : 0;
            TabVerifyAcceptDetails.TTLUse = null != reader[Constants.OUT_TTLUSE] ? Convert.ToInt32(reader[Constants.OUT_TTLUSE].ToString().Trim()) : 0;


            return TabVerifyAcceptDetails;
        }
    }
}
