using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   

    internal class RemarkObjectFactory : IDomainObjectFactory<Remark>
    {
        public Remark Construct(IDataReader reader)
        {
            Remark Remark = new Remark();

            Remark.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            Remark.FieldId = null != reader[Constants.OUT_FIELD_ID] ? reader[Constants.OUT_FIELD_ID].ToString().Trim() : string.Empty;
            Remark.Remarks = null != reader[Constants.OUT_REMARKS] ? reader[Constants.OUT_REMARKS].ToString().Trim() : string.Empty;
             return Remark;
        }
    }
}
