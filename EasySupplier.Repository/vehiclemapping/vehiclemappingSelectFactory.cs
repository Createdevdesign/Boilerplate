using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
   
    internal class vehiclemappingSelectFactory : ISelectionFactory<vehiclemapping>
    {
        public IDbCommand ConstructSelectCommand(vehiclemapping idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

           
            sqlCommand.Parameters.Add(Constants.PS_SUB_MERCHANT_ID, SqlDbType.NVarChar, 45).Value = idObject.submerchantid;
            sqlCommand.Parameters.Add(Constants.PS_VEHICLE_CATEGORY, SqlDbType.VarChar, 45).Value = idObject.Vehiclecategory;
            sqlCommand.Parameters.Add(Constants.PN_VEHICLE_VALUE, SqlDbType.Decimal, 18).Value = idObject.vehiclevalue;
            sqlCommand.Parameters.Add(Constants.PS_IS_ACTIVE_YN, SqlDbType.Bit, 5).Value = idObject.isactive;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_VEHICLE_MAPPING;
            return sqlCommand;
        }
    }
}
