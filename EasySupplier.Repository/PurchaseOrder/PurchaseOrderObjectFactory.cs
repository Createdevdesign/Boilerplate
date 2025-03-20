using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
  
    internal class PurchaseOrderObjectFactory : IDomainObjectFactory<PurchaseOrder>
    {
        public PurchaseOrder Construct(IDataReader reader)
        {
            PurchaseOrder PurchaseOrder = new PurchaseOrder();

            PurchaseOrder.POId = null != reader[Constants.OUI_PO_ID] ? Convert.ToInt32(reader[Constants.OUI_PO_ID].ToString().Trim()) : 0;
            PurchaseOrder.PONum = null != reader[Constants.OUI_PO_NUM] ? reader[Constants.OUI_PO_NUM].ToString().Trim() : string.Empty;
            PurchaseOrder.POQtnId = null != reader[Constants.OUI_PO_QTN_ID] ? Convert.ToInt32(reader[Constants.OUI_PO_QTN_ID].ToString().Trim()) : 0;
            PurchaseOrder.POStatus = null != reader[Constants.OUI_PO_STATUS] ? Convert.ToInt32(reader[Constants.OUI_PO_STATUS].ToString().Trim()) : 0;
            PurchaseOrder.POOverallStatus = null != reader[Constants.OUI_PO_OVERALL_STATUS] ? Convert.ToInt32(reader[Constants.OUI_PO_OVERALL_STATUS].ToString().Trim()) : 0;
            PurchaseOrder.IsDeleted = DBNull.Value != reader[Constants.OUI_IS_DELETED_YN] ? Convert.ToBoolean(reader[Constants.OUI_IS_DELETED_YN].ToString().Trim()) : false;
            PurchaseOrder.CreatedBy = null != reader[Constants.OUI_CREATED_BY] ? Convert.ToInt32(reader[Constants.OUI_CREATED_BY].ToString().Trim()) : 0;
            PurchaseOrder.CreatedDtm = null != reader[Constants.OUI_CREATED_DTM] ? Convert.ToDateTime(reader[Constants.OUI_CREATED_DTM].ToString().Trim()) : DateTime.Today;
            PurchaseOrder.ModifyBy = null != reader[Constants.OUI_MODIFY_BY] ? Convert.ToInt32(reader[Constants.OUI_MODIFY_BY].ToString().Trim()) : 0;
            PurchaseOrder.ModifyDtm = null != reader[Constants.OUI_MODIFY_DTM] ? Convert.ToDateTime(reader[Constants.OUI_MODIFY_DTM].ToString().Trim()) : DateTime.Today;


            return PurchaseOrder;
        }
    }
}
