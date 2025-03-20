using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    

    internal class PurchasingOrganisationObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster PurchasingOrganisation = new SAPMaster();

            PurchasingOrganisation.BUKRS = null != reader[Constants.OUT_BUKRS] ? Convert.ToInt32(reader[Constants.OUT_BUKRS].ToString().Trim()) : 0;
            PurchasingOrganisation.EKORG = null != reader[Constants.OUT_EKORG] ? reader[Constants.OUT_EKORG].ToString().Trim() : string.Empty;
            PurchasingOrganisation.EKOTX = null != reader[Constants.OUT_EKOTX] ? reader[Constants.OUT_EKOTX].ToString().Trim() : string.Empty;
           
            return PurchasingOrganisation;
        }
    }
}
