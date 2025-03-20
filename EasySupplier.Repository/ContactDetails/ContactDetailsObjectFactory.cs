using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    internal class ContactDetailsObjectFactory : IDomainObjectFactory<ContactDetail>
    {
        public ContactDetail Construct(IDataReader reader)
        {
            ContactDetail ContactDetails = new ContactDetail();

            ContactDetails.PhoneNumber = null != reader[Constants.OUT_PHONE_NUMBER] ? Convert.ToDecimal(reader[Constants.OUT_PHONE_NUMBER].ToString().Trim()) : 0;
            ContactDetails.PhoneNumberType = null != reader[Constants.OUT_PHONE_NUMBER_TYPE] ? reader[Constants.OUT_PHONE_NUMBER_TYPE].ToString().Trim() : string.Empty;
            ContactDetails.EmailAddress = null != reader[Constants.OUT_EMAIL_ADDRESS] ? reader[Constants.OUT_EMAIL_ADDRESS].ToString().Trim() : string.Empty;
            ContactDetails.UserCode = null != reader[Constants.OUT_USER_CODE] ? reader[Constants.OUT_USER_CODE].ToString().Trim() : string.Empty;
            ContactDetails.ModifiedDate = null != reader[Constants.OUT_MODIFIED_DATE] ? Convert.ToDateTime(reader[Constants.OUT_MODIFIED_DATE].ToString().Trim()) : DateTime.Today;
            ContactDetails.ModifiedUser = null != reader[Constants.OUT_MODIFIED_USER] ? reader[Constants.OUT_MODIFIED_USER].ToString().Trim() : string.Empty;
            ContactDetails.IsActive = DBNull.Value != reader[Constants.OUT_IS_ACTIVE_YN] ? Convert.ToBoolean(reader[Constants.OUT_IS_ACTIVE_YN].ToString().Trim()) : false;
            ContactDetails.Entitytype = null != reader[Constants.OUT_ENTITY_TYPE] ? reader[Constants.OUT_ENTITY_TYPE].ToString().Trim() : string.Empty;
            

            return ContactDetails;
        }
    }
}
