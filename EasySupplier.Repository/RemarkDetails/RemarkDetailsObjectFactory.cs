using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
  

    internal class RemarkDetailsObjectFactory : IDomainObjectFactory<Remark>
    {
        public Remark Construct(IDataReader reader)
        {
            Remark RemarkDetails = new Remark();

            RemarkDetails.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            RemarkDetails.FieldId = null != reader[Constants.OUT_FIELD_ID] ? reader[Constants.OUT_FIELD_ID].ToString().Trim() : string.Empty;
            RemarkDetails.Remarks = null != reader[Constants.OUT_REMARKS] ? reader[Constants.OUT_REMARKS].ToString().Trim() : string.Empty;
            RemarkDetails.Flag = DBNull.Value != reader[Constants.OUT_FLAG] ? Convert.ToBoolean(reader[Constants.OUT_FLAG].ToString().Trim()) : false;
            RemarkDetails.CreatedBy = null != reader[Constants.OUT_CREATED_BY] ? reader[Constants.OUT_CREATED_BY].ToString().Trim() : string.Empty;
            RemarkDetails.Status = null != reader[Constants.OUT_STATUS] ? reader[Constants.OUT_STATUS].ToString().Trim() : string.Empty;

            return RemarkDetails;
        }
    }
}
