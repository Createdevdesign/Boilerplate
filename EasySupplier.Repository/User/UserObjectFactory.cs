using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   
    internal class UserObjectFactory : IDomainObjectFactory<User>
    {
        public User Construct(IDataReader reader)
        {
            User User = new User();

            User.UserRole = null != reader[Constants.OUT_USER_ROLE] ? Convert.ToDecimal(reader[Constants.OUT_USER_ROLE].ToString().Trim()) : 0;
            User.UserName = null != reader[Constants.OUT_USER_NAME] ? reader[Constants.OUT_USER_NAME].ToString().Trim() : string.Empty;
            User.MobileNo = null != reader[Constants.OUT_MOBILE_NO] ? Convert.ToDecimal(reader[Constants.OUT_MOBILE_NO].ToString().Trim()) : 0;
            User.EmailId = null != reader[Constants.OUT_EMAIL_ID] ? reader[Constants.OUT_EMAIL_ID].ToString().Trim() : string.Empty;
            User.Password = null != reader[Constants.OUT_PASSWORD] ? reader[Constants.OUT_PASSWORD].ToString().Trim() : string.Empty;
            User.UserId = null != reader[Constants.OUT_USER_ID] ? reader[Constants.OUT_USER_ID].ToString().Trim() : string.Empty;
            User.Active = DBNull.Value != reader[Constants.OUT_ACTIVE] ? Convert.ToBoolean(reader[Constants.OUT_ACTIVE].ToString().Trim()) : false;
            return User;
        }
    }
}
