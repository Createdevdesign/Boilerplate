using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    internal class InviteSupplierObjectFactory : IDomainObjectFactory<InviteSupplier>
    {
        public InviteSupplier Construct(IDataReader reader)
        {
            InviteSupplier InviteSupplier = new InviteSupplier();

            InviteSupplier.PurOrgCode = null != reader[Constants.OUT_PUR_ORG_CODE] ? reader[Constants.OUT_PUR_ORG_CODE].ToString().Trim() : string.Empty;
            InviteSupplier.FirstName = null != reader[Constants.OUT_FIRST_NAME] ? reader[Constants.OUT_FIRST_NAME].ToString().Trim() : string.Empty;
            InviteSupplier.LastName = null != reader[Constants.OUT_LAST_NAME] ? reader[Constants.OUT_LAST_NAME].ToString().Trim() : string.Empty;
            InviteSupplier.CompanyName = null != reader[Constants.OUT_COMPANY_NAME] ? reader[Constants.OUT_COMPANY_NAME].ToString().Trim() : string.Empty;
            InviteSupplier.ContactNo = null != reader[Constants.OUT_CONTACT_NO] ? reader[Constants.OUT_CONTACT_NO].ToString().Trim() : string.Empty;
            InviteSupplier.EmailAddress = null != reader[Constants.OUT_EMAIL_ADDRESS] ? reader[Constants.OUT_EMAIL_ADDRESS].ToString().Trim() : string.Empty;
            InviteSupplier.Invitedby = null != reader[Constants.OUT_INVITED_BY] ? reader[Constants.OUT_INVITED_BY].ToString().Trim() : string.Empty;
            return InviteSupplier;
        }
    }
}
