using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   

    internal class TabfieldsObjectFactory : IDomainObjectFactory<Tabfields>
    {
        public Tabfields Construct(IDataReader reader)
        {
            Tabfields Tabfields = new Tabfields();

            Tabfields.RelationID = null != reader[Constants.OUT_RELATION_ID] ? Convert.ToInt32(reader[Constants.OUT_RELATION_ID].ToString().Trim()) : 0;
            Tabfields.OrganisationID = null != reader[Constants.OUT_ORGANISATION_ID] ? Convert.ToInt32(reader[Constants.OUT_ORGANISATION_ID].ToString().Trim()) : 0;
            Tabfields.TabID = null != reader[Constants.OUT_TAB_ID] ? Convert.ToInt32(reader[Constants.OUT_TAB_ID].ToString().Trim()) : 0;
            Tabfields.FieldID = null != reader[Constants.OUT_FIELD_ID] ? Convert.ToInt32(reader[Constants.OUT_FIELD_ID].ToString().Trim()) : 0;
            Tabfields.Label = null != reader[Constants.OUT_LABEL] ? reader[Constants.OUT_LABEL].ToString().Trim() : string.Empty;
            Tabfields.Required = DBNull.Value != reader[Constants.OUT_REQUIRED] ? Convert.ToBoolean(reader[Constants.OUT_REQUIRED].ToString().Trim()) : false;
            Tabfields.Placeholder = null != reader[Constants.OUT_PLACE_HOLDER] ? reader[Constants.OUT_PLACE_HOLDER].ToString().Trim() : string.Empty;
            Tabfields.Tooltip = null != reader[Constants.OUT_TOOL_TIP] ? reader[Constants.OUT_TOOL_TIP].ToString().Trim() : string.Empty;
            Tabfields.Status = DBNull.Value != reader[Constants.OUT_STATUS] ? Convert.ToBoolean(reader[Constants.OUT_STATUS].ToString().Trim()) : false;
            Tabfields.Enabled = DBNull.Value != reader[Constants.OUT_ENABLED] ? Convert.ToBoolean(reader[Constants.OUT_ENABLED].ToString().Trim()) : false;
            Tabfields.Ordering = null != reader[Constants.OUT_ORDERING] ? Convert.ToDecimal(reader[Constants.OUT_ORDERING].ToString().Trim()) : 0;
            Tabfields.ContainerCssClass = null != reader[Constants.OUT_CONTAINER_CSS_CLASS] ? reader[Constants.OUT_CONTAINER_CSS_CLASS].ToString().Trim() : string.Empty;
            Tabfields.Show = DBNull.Value != reader[Constants.OUT_SHOW] ? Convert.ToBoolean(reader[Constants.OUT_SHOW].ToString().Trim()) : false;
            Tabfields.Short = DBNull.Value != reader[Constants.OUT_SHORT] ? Convert.ToBoolean(reader[Constants.OUT_SHORT].ToString().Trim()) : false;


            return Tabfields;
        }
    }
}
