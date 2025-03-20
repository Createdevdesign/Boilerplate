using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
   
    internal class PurchaseOrderSelectFactory : ISelectionFactory<PurchaseOrder>
    {
        public IDbCommand ConstructSelectCommand(PurchaseOrder idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            sqlCommand.Parameters.Add(Constants.PN_PO_ID, SqlDbType.Int, 4).Value = idObject.POId;
            sqlCommand.Parameters.Add(Constants.PS_PO_NUM, SqlDbType.VarChar, 10).Value = idObject.PONum;
            sqlCommand.Parameters.Add(Constants.PN_PO_QTN_ID, SqlDbType.Int, 4).Value = idObject.POQtnId;
            sqlCommand.Parameters.Add(Constants.PN_PO_STATUS, SqlDbType.Int, 4).Value = idObject.POStatus;
            sqlCommand.Parameters.Add(Constants.PN_PO_OVERALL_STATUS, SqlDbType.Int, 4).Value = idObject.POOverallStatus;
            sqlCommand.Parameters.Add(Constants.PS_IS_DELETED_YN, SqlDbType.Bit, 5).Value = idObject.IsDeleted;


            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_PURCHASE_ORDER;
            return sqlCommand;
        }
    }
}
