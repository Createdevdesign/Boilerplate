using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
    internal class LookupSelectFactory : ISelectionFactory<Lookup>
    {
        public IDbCommand ConstructSelectCommand(Lookup idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;
           
            sqlCommand.Parameters.Add(Constants.PN_JURIS_ORG_CODE, SqlDbType.Int, 4).Value = idObject.OrganisationId;
            sqlCommand.Parameters.Add(Constants.PN_CODE_TYPE, SqlDbType.Int, 4).Value = idObject.CodeType;
            sqlCommand.Parameters.Add(Constants.PS_CODE_TYPE_DESC, SqlDbType.VarChar, 35).Value = idObject.CodeTypeDesc;
            sqlCommand.Parameters.Add(Constants.PS_CODE_SEC_YN, SqlDbType.Bit, 4).Value = idObject.CodeSec;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_LOOKUP_MASTER;
            return sqlCommand;
        }
    }
}
