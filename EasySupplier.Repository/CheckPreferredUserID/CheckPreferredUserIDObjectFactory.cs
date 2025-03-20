using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    

    internal class CheckPreferredUserIDObjectFactory : IDomainObjectFactory<Signup>
    {
        public Signup Construct(IDataReader reader)
        {
            Signup CheckPreferredUserID = new Signup();

            CheckPreferredUserID.InviteID = null != reader[Constants.OUT_INVITE_ID] ? reader[Constants.OUT_INVITE_ID].ToString().Trim() : string.Empty;
            CheckPreferredUserID.PreferredUserID = null != reader[Constants.OUT_PREFERRED_USER_ID] ? reader[Constants.OUT_PREFERRED_USER_ID].ToString().Trim() : string.Empty;
          
            return CheckPreferredUserID;
        }
    }
}
