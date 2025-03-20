using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
  
    internal class AddressSelectFactory : ISelectionFactory<Address>
    {
        public IDbCommand ConstructSelectCommand(Address idObject)
        {          


            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            //sqlCommand.Parameters.Add(Constants.PN_ID, SqlDbType.Decimal, 18).Value = idObject.Id;
            sqlCommand.Parameters.Add(Constants.PS_ADDRESS_LINE1, SqlDbType.NVarChar, 200).Value = idObject.AddressLine1;
            sqlCommand.Parameters.Add(Constants.PS_ADDRESS_LINE2, SqlDbType.NVarChar, 200).Value = idObject.AddressLine2;
            sqlCommand.Parameters.Add(Constants.PN_TALUKA_ID, SqlDbType.Int, 4).Value = idObject.TalukaId;
            sqlCommand.Parameters.Add(Constants.PN_DISTRICT_ID, SqlDbType.Int, 4).Value = idObject.DistrictId;
            sqlCommand.Parameters.Add(Constants.PN_STATE_ID, SqlDbType.Int, 4).Value = idObject.StateId;

            sqlCommand.Parameters.Add(Constants.PN_COUNTRY_ID, SqlDbType.Int, 4).Value = idObject.CountryId;
            sqlCommand.Parameters.Add(Constants.PS_POSTAL_CODE, SqlDbType.VarChar, 15).Value = idObject.PostalCode;   
            sqlCommand.Parameters.Add(Constants.PS_USER_CODE, SqlDbType.NVarChar, 200).Value = idObject.UserCode;   
            sqlCommand.Parameters.Add(Constants.PS_USER, SqlDbType.NVarChar, 200).Value = idObject.ModifiedUser;
            sqlCommand.Parameters.Add(Constants.PS_IS_ACTIVE_YN, SqlDbType.Bit, 5).Value = idObject.IsActive;

            sqlCommand.Parameters.Add(Constants.PS_ENTITY_TYPE, SqlDbType.Char, 1).Value = idObject.Entitytype;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_ADDRESS;
            return sqlCommand;
        }
    }
}
