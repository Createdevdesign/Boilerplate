using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
  

    internal class TTLUseDetailObjectFactory : IDomainObjectFactory<TTLUse>
    {
        public TTLUse Construct(IDataReader reader)
        {
            TTLUse TTLUseDetail = new TTLUse();

            TTLUseDetail.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            TTLUseDetail.EKORG = null != reader[Constants.OUT_EKORG] ? reader[Constants.OUT_EKORG].ToString().Trim() : string.Empty;
            TTLUseDetail.BANKL = null != reader[Constants.OUT_BANKL] ? reader[Constants.OUT_BANKL].ToString().Trim() : string.Empty;
            TTLUseDetail.BKONT = null != reader[Constants.OUT_BKONT] ? reader[Constants.OUT_BKONT].ToString().Trim() : string.Empty;
            TTLUseDetail.BANKTYPE = null != reader[Constants.OUT_BANKTYPE] ? reader[Constants.OUT_BANKTYPE].ToString().Trim() : string.Empty;
            TTLUseDetail.SWIFT = null != reader[Constants.OUT_SWIFT] ? reader[Constants.OUT_SWIFT].ToString().Trim() : string.Empty;
            TTLUseDetail.AKONT = null != reader[Constants.OUT_AKONT] ? reader[Constants.OUT_AKONT].ToString().Trim() : string.Empty;
            TTLUseDetail.ZTERM = null != reader[Constants.OUT_ZTERM] ? reader[Constants.OUT_ZTERM].ToString().Trim() : string.Empty;
            TTLUseDetail.ZWELS = null != reader[Constants.OUT_ZWELS] ? reader[Constants.OUT_ZWELS].ToString().Trim() : string.Empty;
            TTLUseDetail.ZAHLS = null != reader[Constants.OUT_ZAHLS] ? reader[Constants.OUT_ZAHLS].ToString().Trim() : string.Empty;
            TTLUseDetail.HBKID = null != reader[Constants.OUT_HBKID] ? reader[Constants.OUT_HBKID].ToString().Trim() : string.Empty;
            TTLUseDetail.KALSK = null != reader[Constants.OUT_KALSK] ? reader[Constants.OUT_KALSK].ToString().Trim() : string.Empty;
            TTLUseDetail.ZTERMComp = null != reader[Constants.OUT_ZTERMComp] ? reader[Constants.OUT_ZTERMComp].ToString().Trim() : string.Empty;
            TTLUseDetail.IBAN = null != reader[Constants.OUT_IBAN] ? reader[Constants.OUT_IBAN].ToString().Trim() : string.Empty;
            TTLUseDetail.J_1TPBUPL = null != reader[Constants.OUT_J_1TPBUPL] ? reader[Constants.OUT_J_1TPBUPL].ToString().Trim() : string.Empty;
            TTLUseDetail.CERDT = null != reader[Constants.OUT_CERDT] ? Convert.ToDateTime(reader[Constants.OUT_CERDT].ToString().Trim()) : DateTime.Today;
            TTLUseDetail.QLAND = null != reader[Constants.OUT_QLAND] ? reader[Constants.OUT_QLAND].ToString().Trim() : string.Empty;
            TTLUseDetail.VEN_CLASS = null != reader[Constants.OUT_VEN_CLASS] ? reader[Constants.OUT_VEN_CLASS].ToString().Trim() : string.Empty;


            return TTLUseDetail;
        }
    }
}
