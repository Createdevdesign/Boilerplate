using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
    internal class WithholdingTaxCodeSelectFactory : ISelectionFactory<SAPMaster>
    {
        public IDbCommand ConstructSelectCommand(SAPMaster idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;



            sqlCommand.Parameters.Add(Constants.PS_MODE_FLAG, SqlDbType.VarChar, 10).Value = idObject.ModeFlag;
            sqlCommand.Parameters.Add(Constants.PS_BANKS, SqlDbType.VarChar, 10).Value = idObject.BANKS;
            sqlCommand.Parameters.Add(Constants.PS_EKORG, SqlDbType.VarChar, 10).Value = idObject.EKORG;
            sqlCommand.Parameters.Add(Constants.PS_QLAND1, SqlDbType.VarChar, 10).Value = idObject.QLAND1;
            sqlCommand.Parameters.Add(Constants.PS_QLAND, SqlDbType.VarChar, 10).Value = idObject.QLAND;
            sqlCommand.Parameters.Add(Constants.PS_WITHT, SqlDbType.VarChar, 10).Value = idObject.WITHT;
            sqlCommand.Parameters.Add(Constants.PS_WITHTExemption, SqlDbType.VarChar, 10).Value = idObject.WITHTExemption;
            sqlCommand.Parameters.Add(Constants.PS_vendorcode, SqlDbType.VarChar, 10).Value = idObject.vendorcode;


            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;


            sqlCommand.CommandText = Constants.USP_GET_SAP_MASTER;
            return sqlCommand;
        }
    }
}
