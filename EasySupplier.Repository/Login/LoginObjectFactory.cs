using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    internal class LoginObjectFactory : IDomainObjectFactory<User>
    {
        public User Construct(IDataReader reader)
        {
            //User user = new User();
            //if (null != reader[Constants.OUT_USERLOCK])
            //    user.Active = reader[Constants.OUT_USERLOCK].ToString().Trim() == "1" ? true : false;
            //else
            //    user.Active = false;

            //user.UserName = null != reader[Constants.OUT_USERNAME] ? reader[Constants.OUT_USERNAME].ToString().Trim() : string.Empty;
            //user.PasswordHash = null != reader[Constants.OUT_USERPASSWORD] ? reader[Constants.OUT_USERPASSWORD].ToString().Trim() : string.Empty;

            /////----------------------Tabfields
            //user.RelationID = null != reader[Constants.OUT_RELATION_ID] ? Convert.ToInt32(reader[Constants.OUT_RELATION_ID].ToString().Trim()) : 0;
            //user.OrganisationID = null != reader[Constants.OUT_ORGANISATION_ID] ? Convert.ToInt32(reader[Constants.OUT_ORGANISATION_ID].ToString().Trim()) : 0;
            //user.TabID = null != reader[Constants.OUT_TAB_ID] ? Convert.ToInt32(reader[Constants.OUT_TAB_ID].ToString().Trim()) : 0;
            //user.FieldID = null != reader[Constants.OUT_FIELD_ID] ? Convert.ToInt32(reader[Constants.OUT_FIELD_ID].ToString().Trim()) : 0;
            //user.Label = null != reader[Constants.OUT_LABEL] ? reader[Constants.OUT_LABEL].ToString().Trim() : string.Empty;
            //user.Required = DBNull.Value != reader[Constants.OUT_REQUIRED] ? Convert.ToBoolean(reader[Constants.OUT_REQUIRED].ToString().Trim()) : false;
            //user.Placeholder = null != reader[Constants.OUT_PLACE_HOLDER] ? reader[Constants.OUT_PLACE_HOLDER].ToString().Trim() : string.Empty;
            //user.Tooltip = null != reader[Constants.OUT_TOOL_TIP] ? reader[Constants.OUT_TOOL_TIP].ToString().Trim() : string.Empty;
            //user.Status = DBNull.Value != reader[Constants.OUT_STATUS] ? Convert.ToBoolean(reader[Constants.OUT_STATUS].ToString().Trim()) : false;
            //user.Enabled = DBNull.Value != reader[Constants.OUT_ENABLED] ? Convert.ToBoolean(reader[Constants.OUT_ENABLED].ToString().Trim()) : false;
            //user.Ordering = null != reader[Constants.OUT_ORDERING] ? Convert.ToDecimal(reader[Constants.OUT_ORDERING].ToString().Trim()) : 0;
            //user.ContainerCssClass = null != reader[Constants.OUT_CONTAINER_CSS_CLASS] ? reader[Constants.OUT_CONTAINER_CSS_CLASS].ToString().Trim() : string.Empty;
            //user.Show = DBNull.Value != reader[Constants.OUT_SHOW] ? Convert.ToBoolean(reader[Constants.OUT_SHOW].ToString().Trim()) : false;
            //user.Short = DBNull.Value != reader[Constants.OUT_SHORT] ? Convert.ToBoolean(reader[Constants.OUT_SHORT].ToString().Trim()) : false;


            //if (null != reader[Constants.OUT_USEREXISTS])
            //    user.Exists = reader[Constants.OUT_USEREXISTS].ToString().Trim() == "1" ? true : false;
            //else
            //    user.Exists = false;

            //return user;

            //26-7-2021
            User user = new User();

            user.UserId = null != reader[Constants.OUT_USER_ID] ? reader[Constants.OUT_USER_ID].ToString().Trim() : string.Empty;
            user.InviteID = null != reader[Constants.OUT_INVITE_ID] ? reader[Constants.OUT_INVITE_ID].ToString().Trim() : string.Empty;
            user.Active = DBNull.Value != reader[Constants.OUT_ACTIVE] ? Convert.ToBoolean(reader[Constants.OUT_ACTIVE].ToString().Trim()) : false;
            user.SubmitFlag = null != reader[Constants.OUT_SUBMIT_FLAG] ? reader[Constants.OUT_SUBMIT_FLAG].ToString().Trim() : string.Empty;

            return user;
        }
    }
}
