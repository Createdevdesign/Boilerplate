using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{

    internal class LookupValueSelectFactory : ISelectionFactory<LookupValue>
    {
        public IDbCommand ConstructSelectCommand(LookupValue idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            //sqlCommand.Parameters.Add(Constants.PN_ORGANISATION_ID, SqlDbType.Int, 4).Value = idObject.OrganisationID;
            //sqlCommand.Parameters.Add(Constants.PN_LOOKUP_MASTER_CODE, SqlDbType.Int, 4).Value = idObject.CodeType;
            ////sqlCommand.Parameters.Add(Constants.PS_LOOKUP_MASTER_NAME, SqlDbType.NVarChar, 100).Value = idObject.CodeDesc;
            //sqlCommand.Parameters.Add(Constants.PS_LOOKUP_VALUE_CODE, SqlDbType.Int, 4).Value = idObject.Code;
            //sqlCommand.Parameters.Add(Constants.PS_LOOKUP_VALUE_DESC, SqlDbType.NVarChar, 100).Value = idObject.CodeDesc;
            //sqlCommand.Parameters.Add(Constants.PS_REF_CODE, SqlDbType.NVarChar, 100).Value = idObject.RefCode;
            //sqlCommand.Parameters.Add(Constants.PS_REMARKS, SqlDbType.NVarChar, 100).Value = idObject.Remarks;           
            //sqlCommand.Parameters.Add(Constants.PS_USER, SqlDbType.NVarChar, 200).Value = idObject.LastModifiedUser;

            //sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;


            sqlCommand.Parameters.Add(Constants.PS_MODE_FLAG, SqlDbType.VarChar, 10).Value = idObject.ModeFlag;
            sqlCommand.Parameters.Add(Constants.PS_LOGIN_EMAIL_ID, SqlDbType.NVarChar, 100).Value = idObject.LoginEmailId;
            sqlCommand.Parameters.Add(Constants.PS_COUNTRY, SqlDbType.VarChar, 10).Value = idObject.Country;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;

            //sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_LOOKUP_VALUE_MASTER;
            sqlCommand.CommandText = Constants.USP_GET_SupplierDDL;
            return sqlCommand;
        }
    }
}
