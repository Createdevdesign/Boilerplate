using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   
    internal class SignupObjectFactory : IDomainObjectFactory<Signup>
    {
        public Signup Construct(IDataReader reader)
        {
            Signup Signup = new Signup();


            Signup.FirstName = null != reader[Constants.OUT_FIRST_NAME] ? reader[Constants.OUT_FIRST_NAME].ToString().Trim() : string.Empty;
            Signup.LastName = null != reader[Constants.OUT_LAST_NAME] ? reader[Constants.OUT_LAST_NAME].ToString().Trim() : string.Empty;
            Signup.Designation = null != reader[Constants.OUT_DESIGNATION] ? reader[Constants.OUT_DESIGNATION].ToString().Trim() : string.Empty;
            Signup.MobileNo = null != reader[Constants.OUT_MOBILE_NO] ? reader[Constants.OUT_MOBILE_NO].ToString().Trim() : string.Empty;
            Signup.EmailAddress = null != reader[Constants.OUT_EMAIL_ADDRESS] ? reader[Constants.OUT_EMAIL_ADDRESS].ToString().Trim() : string.Empty;
            //Signup.OTP = null != reader[Constants.OUT_OTP] ? reader[Constants.OUT_OTP].ToString().Trim() : string.Empty;
            Signup.PreferredUserID = null != reader[Constants.OUT_PREFERRED_USER_ID] ? reader[Constants.OUT_PREFERRED_USER_ID].ToString().Trim() : string.Empty;
           // Signup.Password = null != reader[Constants.OUT_PASSWORD] ? Convert.ToByte(reader[Constants.OUT_PASSWORD].ToString().Trim()) : ;
            //Signup.ConfirmPassword = null != reader[Constants.OUT_CONFIRM_PASSWORD] ? Convert.ToByte(reader[Constants.OUT_CONFIRM_PASSWORD].ToString().Trim()) :;
           // Signup.Active = DBNull.Value != reader[Constants.OUT_ACTIVE] ? Convert.ToBoolean(reader[Constants.OUT_ACTIVE].ToString().Trim()) : false;

            return Signup;
        }
    }
}
