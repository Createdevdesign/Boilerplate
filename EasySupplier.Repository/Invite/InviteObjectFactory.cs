using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   
    internal class InviteObjectFactory : IDomainObjectFactory<Invite>
    {
        public Invite Construct(IDataReader reader)
        {
            Invite Invite = new Invite();

            Invite.YourName = null != reader[Constants.OUT_YOUR_NAME] ? reader[Constants.OUT_YOUR_NAME].ToString().Trim() : string.Empty;
            Invite.CompanyName = null != reader[Constants.OUT_COMPANY_NAME] ? reader[Constants.OUT_COMPANY_NAME].ToString().Trim() : string.Empty;
            Invite.EmailAddress = null != reader[Constants.OUT_EMAIL_ADDRESS] ? reader[Constants.OUT_EMAIL_ADDRESS].ToString().Trim() : string.Empty;
            Invite.PhoneNumber = null != reader[Constants.OUT_PHONE_NUMBER] ? reader[Constants.OUT_PHONE_NUMBER].ToString().Trim() : string.Empty;
            Invite.CompanyAddress = null != reader[Constants.OUT_COMPANY_ADDRESS] ? reader[Constants.OUT_COMPANY_ADDRESS].ToString().Trim() : string.Empty;

            Invite.ITEquipment = null != reader[Constants.OUT_IT_EQUIPMENT] ? reader[Constants.OUT_IT_EQUIPMENT].ToString().Trim() : string.Empty;
            Invite.Software = null != reader[Constants.OUT_SOFTWARE] ? reader[Constants.OUT_SOFTWARE].ToString().Trim() : string.Empty;
            Invite.Peripherals = null != reader[Constants.OUT_PERIPHERALS] ? reader[Constants.OUT_PERIPHERALS].ToString().Trim() : string.Empty;
            Invite.OfficeEquipment = null != reader[Constants.OUT_OFFICE_EQUIPMENT] ? reader[Constants.OUT_OFFICE_EQUIPMENT].ToString().Trim() : string.Empty;
            Invite.OfficeSupplies = null != reader[Constants.OUT_OFFICE_SUPPLIES] ? reader[Constants.OUT_OFFICE_SUPPLIES].ToString().Trim() : string.Empty;
            
            Invite.ManpowerServices = null != reader[Constants.OUT_MANPOWER_SERVICES] ? reader[Constants.OUT_MANPOWER_SERVICES].ToString().Trim() : string.Empty;
            Invite.OtherServices = null != reader[Constants.OUT_OTHER_SERVICES] ? reader[Constants.OUT_OTHER_SERVICES].ToString().Trim() : string.Empty;
            Invite.ProductsServicesforFacilityManagement = null != reader[Constants.OUT_PRODUCTS_SERVICES_FOR_FACILITY_MANAGEMENT] ? reader[Constants.OUT_PRODUCTS_SERVICES_FOR_FACILITY_MANAGEMENT].ToString().Trim() : string.Empty;
            Invite.ReasonForContact = null != reader[Constants.OUT_REASON_FOR_CONTACT] ? reader[Constants.OUT_REASON_FOR_CONTACT].ToString().Trim() : string.Empty;
           
            return Invite;
        }
    }
}
