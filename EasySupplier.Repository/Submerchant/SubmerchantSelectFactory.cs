using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
    
    internal class SubmerchantSelectFactory : ISelectionFactory<Submerchant>
    {
        public IDbCommand ConstructSelectCommand(Submerchant idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            //sqlCommand.Parameters.Add(Constants.PN_ID, SqlDbType.Decimal, 18).Value = idObject.Id;
            sqlCommand.Parameters.Add(Constants.PS_HEAD_MERCHANT_ID, SqlDbType.NVarChar, 45).Value = idObject.HeadMerchantID;
            sqlCommand.Parameters.Add(Constants.PS_SUB_MERCHANT_ID, SqlDbType.NVarChar, 50).Value = idObject.Submerchantid;
            sqlCommand.Parameters.Add(Constants.PS_SUB_MERCHANT_SHORT_ID, SqlDbType.NVarChar, 50).Value = idObject.Submerchantshortid;
            sqlCommand.Parameters.Add(Constants.PS_MERCHANT_ID, SqlDbType.NVarChar, 45).Value = idObject.merchantid;
            sqlCommand.Parameters.Add(Constants.PS_TOLL_NAME, SqlDbType.NVarChar, 45).Value = idObject.tollname;
            
            sqlCommand.Parameters.Add(Constants.PS_SUB_MERCHANT_TYPE, SqlDbType.NVarChar, 30).Value = idObject.Submerchanttype;
            sqlCommand.Parameters.Add(Constants.PS_PRICE_MODE, SqlDbType.NVarChar, 5).Value = idObject.pricemode;
            sqlCommand.Parameters.Add(Constants.PS_SETTLEMENT_TYPE, SqlDbType.NVarChar, 20).Value = idObject.settlementtype;
            sqlCommand.Parameters.Add(Constants.PS_IS_ACTIVE_YN, SqlDbType.Bit, 5).Value = idObject.isactive;
            sqlCommand.Parameters.Add(Constants.PS_IS_DELETED, SqlDbType.NVarChar, 20).Value = idObject.isdeleted;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_SUB_MERCHANT;
            return sqlCommand;
        }
    }
}
