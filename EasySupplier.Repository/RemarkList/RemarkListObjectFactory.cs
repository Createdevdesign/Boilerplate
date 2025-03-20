using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   

    internal class RemarkListObjectFactory : IDomainObjectFactory<Remark>
    {
        public Remark Construct(IDataReader reader)
        {
            Remark RemarkList = new Remark();

            RemarkList.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            RemarkList.FieldId = null != reader[Constants.OUT_FIELD_ID] ? reader[Constants.OUT_FIELD_ID].ToString().Trim() : string.Empty;
            RemarkList.Remarks = null != reader[Constants.OUT_REMARKS] ? reader[Constants.OUT_REMARKS].ToString().Trim() : string.Empty;
            RemarkList.Flag = DBNull.Value != reader[Constants.OUT_FLAG] ? Convert.ToBoolean(reader[Constants.OUT_FLAG].ToString().Trim()) : false;
            RemarkList.CreatedBy = null != reader[Constants.OUT_CREATED_BY] ? reader[Constants.OUT_CREATED_BY].ToString().Trim() : string.Empty;
            RemarkList.Status = null != reader[Constants.OUT_STATUS] ? reader[Constants.OUT_STATUS].ToString().Trim() : string.Empty;
           
            return RemarkList;
        }
    }
}
