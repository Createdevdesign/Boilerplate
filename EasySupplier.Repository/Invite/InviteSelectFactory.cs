using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
    

    internal class InviteSelectFactory : ISelectionFactory<Invite>
    {
        public IDbCommand ConstructSelectCommand(Invite idObject)
        {


            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            sqlCommand.Parameters.Add(Constants.PS_YOUR_NAME, SqlDbType.VarChar, 50).Value = idObject.YourName;
            sqlCommand.Parameters.Add(Constants.PS_COMPANY_NAME, SqlDbType.VarChar, 50).Value = idObject.CompanyName;
            sqlCommand.Parameters.Add(Constants.PS_EMAIL_ADDRESS, SqlDbType.NVarChar, 50).Value = idObject.EmailAddress;
            sqlCommand.Parameters.Add(Constants.PS_PHONE_NUMBER, SqlDbType.VarChar, 20).Value = idObject.PhoneNumber;
            sqlCommand.Parameters.Add(Constants.PS_COMPANY_ADDRESS, SqlDbType.NVarChar, 50).Value = idObject.CompanyAddress;

            sqlCommand.Parameters.Add(Constants.PS_IT_EQUIPMENT, SqlDbType.VarChar, 10).Value = idObject.ITEquipment;
            sqlCommand.Parameters.Add(Constants.PS_SOFTWARE, SqlDbType.VarChar, 10).Value = idObject.Software;
            sqlCommand.Parameters.Add(Constants.PS_PERIPHERALS, SqlDbType.VarChar, 10).Value = idObject.Peripherals;
            sqlCommand.Parameters.Add(Constants.PS_OFFICE_EQUIPMENT, SqlDbType.VarChar, 10).Value = idObject.OfficeEquipment;
            sqlCommand.Parameters.Add(Constants.PS_OFFICE_SUPPLIES, SqlDbType.VarChar, 10).Value = idObject.OfficeSupplies;

            sqlCommand.Parameters.Add(Constants.PS_MANPOWER_SERVICES, SqlDbType.VarChar, 10).Value = idObject.ManpowerServices;
            sqlCommand.Parameters.Add(Constants.PS_OTHER_SERVICES, SqlDbType.VarChar, 10).Value = idObject.OtherServices;
            sqlCommand.Parameters.Add(Constants.PS_PRODUCTS_SERVICES_FOR_FACILITY_MANAGEMENT, SqlDbType.VarChar, 10).Value = idObject.ProductsServicesforFacilityManagement;
            sqlCommand.Parameters.Add(Constants.PS_REASON_FOR_CONTACT, SqlDbType.VarChar, 100).Value = idObject.ReasonForContact;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_INVITE;
            return sqlCommand;
        }
    }
}
