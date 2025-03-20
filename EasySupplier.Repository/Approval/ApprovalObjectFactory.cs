using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    internal class ApprovalObjectFactory : IDomainObjectFactory<Approval>
    {
        public Approval Construct(IDataReader reader)
        {
            Approval Approval = new Approval();


            Approval.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            Approval.LoginEmailID = null != reader[Constants.OUT_LOGIN_EMAIL_ID] ? reader[Constants.OUT_LOGIN_EMAIL_ID].ToString().Trim() : string.Empty;
           
            return Approval;
        }
    }
}
