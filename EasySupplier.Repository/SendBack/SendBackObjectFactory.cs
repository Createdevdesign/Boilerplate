
using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;
namespace BoilerSupplier.Repository
{
   
    internal class SendBackObjectFactory : IDomainObjectFactory<SendBack>
    {
        public SendBack Construct(IDataReader reader)
        {
            SendBack SendBack = new SendBack();


            SendBack.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            SendBack.LoginEmailID = null != reader[Constants.OUT_LOGIN_EMAIL_ID] ? reader[Constants.OUT_LOGIN_EMAIL_ID].ToString().Trim() : string.Empty;

            return SendBack;
        }
    }
}
