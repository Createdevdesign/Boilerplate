using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
  
    internal class vehiclemappingObjectFactory : IDomainObjectFactory<vehiclemapping>
    {
        public vehiclemapping Construct(IDataReader reader)
        {
            vehiclemapping vehiclemapping = new vehiclemapping();

            vehiclemapping.submerchantid = null != reader[Constants.OUT_SUB_MERCHANT_ID] ? reader[Constants.OUT_SUB_MERCHANT_ID].ToString().Trim() : string.Empty;
            vehiclemapping.Vehiclecategory = null != reader[Constants.OUT_VEHICLE_CATEGORY] ? reader[Constants.OUT_VEHICLE_CATEGORY].ToString().Trim() : string.Empty;
            vehiclemapping.vehiclevalue = null != reader[Constants.OUT_VEHICLE_VALUE] ? Convert.ToDecimal(reader[Constants.OUT_VEHICLE_VALUE].ToString().Trim()) : 0;
            vehiclemapping.isactive = DBNull.Value != reader[Constants.OUT_IS_ACTIVE_YN] ? Convert.ToBoolean(reader[Constants.OUT_IS_ACTIVE_YN].ToString().Trim()) : false;
            vehiclemapping.Updatedby = null != reader[Constants.OUT_UPDATED_BY] ? reader[Constants.OUT_UPDATED_BY].ToString().Trim() : string.Empty;



            return vehiclemapping;
        }
    }
}
