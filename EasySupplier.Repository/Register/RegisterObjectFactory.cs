
using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
 

    internal class RegisterObjectFactory : IDomainObjectFactory<Register>
    {
        public Register Construct(IDataReader reader)
        {
            Register Register = new Register();


            Register.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            //Register.LoginEmailID = null != reader[Constants.OUT_LOGIN_EMAIL_ID] ? reader[Constants.OUT_LOGIN_EMAIL_ID].ToString().Trim() : string.Empty;

            return Register;
        }
    }
}
