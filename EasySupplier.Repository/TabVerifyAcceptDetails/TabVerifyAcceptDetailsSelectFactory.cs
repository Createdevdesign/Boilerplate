﻿using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;


namespace BoilerSupplier.Repository
{
   

    internal class TabVerifyAcceptDetailsSelectFactory : ISelectionFactory<TabVerifyAccept>
    {
        public IDbCommand ConstructSelectCommand(TabVerifyAccept idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;
            sqlCommand.Parameters.Add(Constants.PS_VENDOR_CODE, SqlDbType.VarChar, 10).Value = idObject.VendorCode;

           

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_TAB_VERIFY_ACCEPT_DETAILS;
            return sqlCommand;
        }
    }
}
