﻿using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
   

    internal class SupplierDetailsSelectFactory : ISelectionFactory<Vendor>
    {
        public IDbCommand ConstructSelectCommand(Vendor idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;




            //sqlCommand.Parameters.Add(Constants.PS_vendorcode, SqlDbType.VarChar, 10).Value = idObject.VendorCode;
            sqlCommand.Parameters.Add(Constants.PS_LOGIN_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.LoginEmailID;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;


            sqlCommand.CommandText = Constants.USP_GET_SUPPLIER_DETAILS;
            return sqlCommand;
        }
    }
}
