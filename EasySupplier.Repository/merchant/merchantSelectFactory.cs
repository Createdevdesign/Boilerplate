using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
   
    internal class merchantSelectFactory : ISelectionFactory<merchant>
    {
        public IDbCommand ConstructSelectCommand(merchant idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

           

            sqlCommand.Parameters.Add(Constants.PS_MERCHANT_ID, SqlDbType.NVarChar, 45).Value = idObject.merchantid;
            sqlCommand.Parameters.Add(Constants.PS_MERCHANT_NAME, SqlDbType.NVarChar, 500).Value = idObject.merchantname;
            sqlCommand.Parameters.Add(Constants.PS_MERCHANT_LOGO, SqlDbType.Image, 2000).Value = idObject.merchantlogo;
            sqlCommand.Parameters.Add(Constants.PS_ACTIV_ACTION_KEY, SqlDbType.NVarChar, 45).Value = idObject.activactionkey;
            sqlCommand.Parameters.Add(Constants.PS_IS_DELETED, SqlDbType.NVarChar, 2).Value = idObject.isdeleted;
            
            sqlCommand.Parameters.Add(Constants.PS_HEAD_MERCHANT_ID, SqlDbType.NVarChar, 45).Value = idObject.headmerchantid;
            sqlCommand.Parameters.Add(Constants.PS_USER_TYPE, SqlDbType.NVarChar, 45).Value = idObject.UserType;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_MERCHANT;
            return sqlCommand;
        }
    }
}
