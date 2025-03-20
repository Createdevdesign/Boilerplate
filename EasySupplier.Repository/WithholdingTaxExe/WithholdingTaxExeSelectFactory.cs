using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
   

    internal class WithholdingTaxExeSelectFactory : ISelectionFactory<WithholdingTaxExe>
    {
        public IDbCommand ConstructSelectCommand(WithholdingTaxExe idObject)
        {


            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;


            sqlCommand.Parameters.Add(Constants.PS_VENDOR_CODE, SqlDbType.VarChar, 10).Value = idObject.VendorCode;
            sqlCommand.Parameters.Add(Constants.PS_EKORG, SqlDbType.VarChar, 10).Value = idObject.Ekorg;
            sqlCommand.Parameters.Add(Constants.PS_SECCODE, SqlDbType.VarChar, 10).Value = idObject.SECCODE;
            sqlCommand.Parameters.Add(Constants.PS_WT_EXNR, SqlDbType.VarChar, 25).Value = idObject.WT_EXNR;
            sqlCommand.Parameters.Add(Constants.PN_WT_EXRT, SqlDbType.Decimal, 18).Value = idObject.WT_EXRT;
            sqlCommand.Parameters.Add(Constants.PS_WT_EXDF, SqlDbType.DateTime, 100).Value = idObject.WT_EXDF;
            sqlCommand.Parameters.Add(Constants.PS_WT_EXDT, SqlDbType.DateTime, 100).Value = idObject.WT_EXDT;
            sqlCommand.Parameters.Add(Constants.PS_WT_WTEXRS, SqlDbType.VarChar, 2).Value = idObject.WT_WTEXRS;
            sqlCommand.Parameters.Add(Constants.PS_WITHT, SqlDbType.VarChar, 10).Value = idObject.WITHT;
            sqlCommand.Parameters.Add(Constants.PS_WT_WITHCD, SqlDbType.VarChar, 10).Value = idObject.WT_WITHCD;
            sqlCommand.Parameters.Add(Constants.PN_FIWTIN_EXEM_THR, SqlDbType.Money).Value = idObject.FIWTIN_EXEM_THR;
            sqlCommand.Parameters.Add(Constants.PS_WAERS, SqlDbType.VarChar, 10).Value = idObject.WAERS;

            sqlCommand.Parameters.Add(Constants.PS_CREATED_BY, SqlDbType.VarChar, 50).Value = idObject.CreatedBy;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_WITHHOLDING_TAX_EXE;
            return sqlCommand;
        }
    }
}
