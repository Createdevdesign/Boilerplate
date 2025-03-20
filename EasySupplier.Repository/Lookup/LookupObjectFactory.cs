using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    internal class LookupObjectFactory : IDomainObjectFactory<Lookup>
    {
        public Lookup Construct(IDataReader reader)
        {
            Lookup lookup = new Lookup();
                          
            lookup.CodeType = null != reader[Constants.OUT_CODE_TYPE] ? Convert.ToInt32(reader[Constants.OUT_CODE_TYPE].ToString().Trim()) : 0;
            lookup.CodeTypeDesc = null != reader[Constants.OUT_CODE_TYPE_DESC] ? reader[Constants.OUT_CODE_TYPE_DESC].ToString().Trim() : string.Empty;
            lookup.CodeSec = DBNull.Value != reader[Constants.OUT_CODE_SEC_YN_ID] ? Convert.ToBoolean(reader[Constants.OUT_CODE_SEC_YN_ID].ToString().Trim()) : false;
            lookup.TypeOfLookup = null != reader[Constants.OUT_TYPE_OF_LOOKUP_MASTER_ID] ? reader[Constants.OUT_TYPE_OF_LOOKUP_MASTER_ID].ToString().Trim() : string.Empty;
            lookup.Remarks = null != reader[Constants.OUT_REMARKS] ? reader[Constants.OUT_REMARKS].ToString().Trim() : string.Empty;

            //master fields
            lookup.QLAND = null != reader[Constants.OUT_QLAND] ? reader[Constants.OUT_QLAND].ToString().Trim() : string.Empty;
            lookup.QLTXT = null != reader[Constants.OUT_QLTXT] ? reader[Constants.OUT_QLTXT].ToString().Trim() : string.Empty;

            lookup.TITLE = null != reader[Constants.OUT_TITLE] ? reader[Constants.OUT_TITLE].ToString().Trim() : string.Empty;
            lookup.TITLE_MEDI = null != reader[Constants.OUT_TITLE_MEDI] ? reader[Constants.OUT_TITLE_MEDI].ToString().Trim() : string.Empty;

            lookup.Org_Id = null != reader[Constants.OUT_ORG_ID] ? Convert.ToInt32(reader[Constants.OUT_ORG_ID].ToString().Trim()) : 0;
            lookup.Org_Type = null != reader[Constants.OUT_ORG_TYPE] ? reader[Constants.OUT_ORG_TYPE].ToString().Trim() : string.Empty;


            lookup.RegionId = null != reader[Constants.OUT_REGION_ID] ? Convert.ToInt32(reader[Constants.OUT_REGION_ID].ToString().Trim()) : 0;
            lookup.descr = null != reader[Constants.OUT_DESCR] ? reader[Constants.OUT_DESCR].ToString().Trim() : string.Empty;

            lookup.SupplierCatId = null != reader[Constants.OUT_SUPPLIER_CAT_ID] ? reader[Constants.OUT_SUPPLIER_CAT_ID].ToString().Trim() : string.Empty;
            lookup.SupplierCategory = null != reader[Constants.OUT_SUPPLIER_CATEGORY] ? reader[Constants.OUT_SUPPLIER_CATEGORY].ToString().Trim() : string.Empty;


            return lookup;
        }
    }

   
}
