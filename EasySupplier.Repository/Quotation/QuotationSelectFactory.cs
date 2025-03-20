using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
   

    internal class QuotationSelectFactory : ISelectionFactory<Quotation>
    {
        public IDbCommand ConstructSelectCommand(Quotation idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            //sqlCommand.Parameters.Add(Constants.PN_QTN_ID, SqlDbType.Int,4).Value = idObject.QtnId;
            //sqlCommand.Parameters.Add(Constants.PN_QTN_PIND_ID, SqlDbType.Int, 4).Value = idObject.QtnPindId;
            //sqlCommand.Parameters.Add(Constants.PS_QTN_NUM, SqlDbType.VarChar, 10).Value = idObject.QtnNum;
            //sqlCommand.Parameters.Add(Constants.PN_QTN_STATUS, SqlDbType.Int, 4).Value = idObject.QtnStatus;
            //sqlCommand.Parameters.Add(Constants.PN_QTN_VND_ID, SqlDbType.Int, 4).Value = idObject.QtnVndId;
            //sqlCommand.Parameters.Add(Constants.PN_QTN_ORG_ID, SqlDbType.Int, 4).Value = idObject.QtnOrgId;
            //sqlCommand.Parameters.Add(Constants.PN_QTN_OVERALL_STATUS, SqlDbType.Int, 4).Value = idObject.QtnOverallStatus;
            //sqlCommand.Parameters.Add(Constants.PS_IS_DELETED_YN, SqlDbType.Bit, 5).Value = idObject.IsDeleted;
            //sqlCommand.Parameters.Add(Constants.PS_QTN_FILENM, SqlDbType.VarChar, 100).Value = idObject.QtnFilenm;
            //sqlCommand.Parameters.Add(Constants.PS_QTN_FILENM_SAVED, SqlDbType.VarChar, 100).Value = idObject.QtnFilenmSaved;

            sqlCommand.Parameters.Add(Constants.PS_LOGIN_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.LoginEmailID;
            sqlCommand.Parameters.Add(Constants.PS_CONTACT_PERSON, SqlDbType.VarChar, 50).Value = idObject.ContactPerson;
            sqlCommand.Parameters.Add(Constants.PS_QTN_DATE, SqlDbType.DateTime, 50).Value = idObject.QtnDate;
            sqlCommand.Parameters.Add(Constants.PN_QTN_NUMBER, SqlDbType.Int, 4).Value = idObject.QtnNumber;
            sqlCommand.Parameters.Add(Constants.PS_REMARKS, SqlDbType.VarChar, 50).Value = idObject.Remarks;


            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_QUOTATION;
            return sqlCommand;
        }
    }
}
