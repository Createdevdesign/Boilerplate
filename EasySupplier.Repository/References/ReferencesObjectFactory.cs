using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   

    internal class ReferencesObjectFactory : IDomainObjectFactory<References>
    {
        public References Construct(IDataReader reader)
        {
            References References = new References();
            
            References.RefCustomersName = null != reader[Constants.OUT_REF_CUSTOMERS_NAME] ? reader[Constants.OUT_REF_CUSTOMERS_NAME].ToString().Trim() : string.Empty;
            References.RefContactPerson = null != reader[Constants.OUT_REF_CONTACT_PERSON] ? reader[Constants.OUT_REF_CONTACT_PERSON].ToString().Trim() : string.Empty;
            References.RefDesignation = null != reader[Constants.OUT_REF_DESIGNATION] ? reader[Constants.OUT_REF_DESIGNATION].ToString().Trim() : string.Empty;
            References.RefContactNo = null != reader[Constants.OUT_REF_CONTACT_NO] ? reader[Constants.OUT_REF_CONTACT_NO].ToString().Trim() : string.Empty;
            References.RefEmailID = null != reader[Constants.OUT_REF_EMAIL_ID] ? reader[Constants.OUT_REF_EMAIL_ID].ToString().Trim() : string.Empty;
           


            return References;
        }
    }
}
