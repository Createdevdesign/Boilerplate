using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;


namespace BoilerSupplier.Repository
{
   

    internal class TTLUseSelectFactory : ISelectionFactory<TTLUse>
    {
        public IDbCommand ConstructSelectCommand(TTLUse idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            sqlCommand.Parameters.Add(Constants.PS_VENDOR_CODE, SqlDbType.VarChar, 10).Value = idObject.VendorCode;
            sqlCommand.Parameters.Add(Constants.PS_EKORG, SqlDbType.VarChar, 10).Value = idObject.EKORG;
            sqlCommand.Parameters.Add(Constants.PS_BANKL, SqlDbType.VarChar, 15).Value = idObject.BANKL;
            sqlCommand.Parameters.Add(Constants.PS_BKONT, SqlDbType.VarChar, 10).Value = idObject.BKONT;
            sqlCommand.Parameters.Add(Constants.PS_BVTYP, SqlDbType.VarChar, 10).Value = idObject.BANKTYPE;
            sqlCommand.Parameters.Add(Constants.PS_SWIFT, SqlDbType.VarChar, 10).Value = idObject.SWIFT;
            sqlCommand.Parameters.Add(Constants.PS_AKONT, SqlDbType.VarChar, 10).Value = idObject.AKONT;
            sqlCommand.Parameters.Add(Constants.PS_ZTERM, SqlDbType.VarChar, 10).Value = idObject.ZTERM;
            sqlCommand.Parameters.Add(Constants.PS_ZWELS, SqlDbType.VarChar, 10).Value = idObject.ZWELS;
            sqlCommand.Parameters.Add(Constants.PS_ZAHLS, SqlDbType.VarChar, 10).Value = idObject.ZAHLS;
            sqlCommand.Parameters.Add(Constants.PS_HBKID, SqlDbType.VarChar, 10).Value = idObject.HBKID;
            sqlCommand.Parameters.Add(Constants.PS_KALSK, SqlDbType.VarChar, 10).Value = idObject.KALSK;
            sqlCommand.Parameters.Add(Constants.PS_ZTERMComp, SqlDbType.VarChar, 10).Value = idObject.ZTERMComp;
            sqlCommand.Parameters.Add(Constants.PS_IBAN, SqlDbType.VarChar, 50).Value = idObject.IBAN;
            sqlCommand.Parameters.Add(Constants.PS_J_1TPBUPL, SqlDbType.VarChar, 10).Value = idObject.J_1TPBUPL;
            sqlCommand.Parameters.Add(Constants.PS_CERDT, SqlDbType.DateTime, 100).Value = idObject.CERDT;
            sqlCommand.Parameters.Add(Constants.PS_QLAND, SqlDbType.VarChar, 10).Value = idObject.QLAND;
            sqlCommand.Parameters.Add(Constants.PS_VEN_CLASS, SqlDbType.VarChar, 10).Value = idObject.VEN_CLASS;
            sqlCommand.Parameters.Add(Constants.PS_REPRF, SqlDbType.VarChar, 10).Value = idObject.REPRF;
            sqlCommand.Parameters.Add(Constants.PS_WEBRE, SqlDbType.VarChar, 10).Value = idObject.WEBRE;
            sqlCommand.Parameters.Add(Constants.PS_XNBWY, SqlDbType.VarChar, 10).Value = idObject.XNBWY;
            sqlCommand.Parameters.Add(Constants.PS_LEBRE, SqlDbType.VarChar, 10).Value = idObject.LEBRE;

            sqlCommand.Parameters.Add(Constants.PS_CREATED_BY, SqlDbType.VarChar, 50).Value = idObject.CreatedBy;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_TTLUse;
            return sqlCommand;
        }
    }
}
