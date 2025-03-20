using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   
    internal class AddressObjectFactory : IDomainObjectFactory<Address>
    {
        public Address Construct(IDataReader reader)
        {
            Address Address = new Address();
     
            Address.AddressLine1 = null != reader[Constants.OUT_ADDRESS_LINE1] ? reader[Constants.OUT_ADDRESS_LINE1].ToString().Trim() : string.Empty;
            Address.AddressLine2 = null != reader[Constants.OUT_ADDRESS_LINE2] ? reader[Constants.OUT_ADDRESS_LINE2].ToString().Trim() : string.Empty;
            Address.TalukaId = null != reader[Constants.OUT_TALUKA_ID] ? Convert.ToInt32(reader[Constants.OUT_TALUKA_ID].ToString().Trim()) : 0;
            Address.DistrictId = null != reader[Constants.OUT_DISTRICT_ID] ? Convert.ToInt32(reader[Constants.OUT_DISTRICT_ID].ToString().Trim()) : 0;
            Address.StateId = null != reader[Constants.OUT_STATE_ID] ? Convert.ToInt32(reader[Constants.OUT_STATE_ID].ToString().Trim()) : 0;
            Address.CountryId = null != reader[Constants.OUT_COUNTRY_ID] ? Convert.ToInt32(reader[Constants.OUT_COUNTRY_ID].ToString().Trim()) : 0;
            Address.PostalCode = null != reader[Constants.OUT_POSTAL_CODE] ? reader[Constants.OUT_POSTAL_CODE].ToString().Trim() : string.Empty;
            Address.UserCode = null != reader[Constants.OUT_USER_CODE] ? reader[Constants.OUT_USER_CODE].ToString().Trim() : string.Empty;
            Address.ModifiedDate = null != reader[Constants.OUT_MODIFIED_DATE] ? Convert.ToDateTime(reader[Constants.OUT_MODIFIED_DATE].ToString().Trim()):DateTime.Today;
            Address.ModifiedUser = null != reader[Constants.OUT_MODIFIED_USER] ? reader[Constants.OUT_MODIFIED_USER].ToString().Trim() : string.Empty;
            Address.IsActive = DBNull.Value != reader[Constants.OUT_IS_ACTIVE_YN] ? Convert.ToBoolean(reader[Constants.OUT_IS_ACTIVE_YN].ToString().Trim()) : false;
            Address.Entitytype = null != reader[Constants.OUT_ENTITY_TYPE] ? reader[Constants.OUT_ENTITY_TYPE].ToString().Trim() : string.Empty;
            
            return Address;
        }
    }
}
