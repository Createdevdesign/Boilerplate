using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
  

    internal class ReferencesListObjectFactory : IDomainObjectFactory<Vendor>
    {
        public Vendor Construct(IDataReader reader)
        {
            Vendor ReferencesList = new Vendor();

            //References
            ReferencesList.RefCustomersName = null != reader[Constants.OUT_REF_CUSTOMERS_NAME] ? reader[Constants.OUT_REF_CUSTOMERS_NAME].ToString().Trim() : string.Empty;
            ReferencesList.RefContactPerson = null != reader[Constants.OUT_REF_CONTACT_PERSON] ? reader[Constants.OUT_REF_CONTACT_PERSON].ToString().Trim() : string.Empty;
            ReferencesList.RefDesignation = null != reader[Constants.OUT_REF_DESIGNATION] ? reader[Constants.OUT_REF_DESIGNATION].ToString().Trim() : string.Empty;
            ReferencesList.RefContactNo = null != reader[Constants.OUT_REF_CONTACT_NO] ? reader[Constants.OUT_REF_CONTACT_NO].ToString().Trim() : string.Empty;
            ReferencesList.RefEmailID = null != reader[Constants.OUT_REF_EMAIL_ID] ? reader[Constants.OUT_REF_EMAIL_ID].ToString().Trim() : string.Empty;
           
               return ReferencesList;
        }
    }
}
