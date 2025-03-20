using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
   

    internal class WithholdingTaxSelectFactory : ISelectionFactory<WithholdingTax>
    {
        public IDbCommand ConstructSelectCommand(WithholdingTax idObject)
        {


            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

         
            sqlCommand.Parameters.Add(Constants.PS_VENDOR_CODE, SqlDbType.VarChar, 10).Value = idObject.VendorCode;
            sqlCommand.Parameters.Add(Constants.PS_EKORG, SqlDbType.VarChar, 10).Value = idObject.Ekorg;
            sqlCommand.Parameters.Add(Constants.PS_WITHT, SqlDbType.VarChar, 10).Value = idObject.WITHT;
            sqlCommand.Parameters.Add(Constants.PS_WT_WITHCD, SqlDbType.VarChar, 10).Value = idObject.WT_WITHCD;
            sqlCommand.Parameters.Add(Constants.PS_QSREC, SqlDbType.VarChar, 10).Value = idObject.QSREC;

            sqlCommand.Parameters.Add(Constants.PS_CREATED_BY, SqlDbType.VarChar, 50).Value = idObject.CreatedBy;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_WITHHOLDING_TAX;
            return sqlCommand;
        }
    }
}
