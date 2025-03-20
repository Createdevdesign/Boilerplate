using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{

    internal class TTLUseObjectFactory : IDomainObjectFactory<TTLUse>
    {
        public TTLUse Construct(IDataReader reader)
        {
            TTLUse TTLUse = new TTLUse();

            TTLUse.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            TTLUse.EKORG = null != reader[Constants.OUT_EKORG] ? reader[Constants.OUT_EKORG].ToString().Trim() : string.Empty;
            TTLUse.BANKL = null != reader[Constants.OUT_BANKL] ? reader[Constants.OUT_BANKL].ToString().Trim() : string.Empty;
            TTLUse.BKONT = null != reader[Constants.OUT_BKONT] ? reader[Constants.OUT_BKONT].ToString().Trim() : string.Empty;
            TTLUse.BANKTYPE = null != reader[Constants.OUT_BANKTYPE] ? reader[Constants.OUT_BANKTYPE].ToString().Trim() : string.Empty;
            TTLUse.SWIFT = null != reader[Constants.OUT_SWIFT] ? reader[Constants.OUT_SWIFT].ToString().Trim() : string.Empty;
            TTLUse.AKONT = null != reader[Constants.OUT_AKONT] ? reader[Constants.OUT_AKONT].ToString().Trim() : string.Empty;
            TTLUse.ZTERM = null != reader[Constants.OUT_ZTERM] ? reader[Constants.OUT_ZTERM].ToString().Trim() : string.Empty;
            TTLUse.ZWELS = null != reader[Constants.OUT_ZWELS] ? reader[Constants.OUT_ZWELS].ToString().Trim() : string.Empty;
            TTLUse.ZAHLS = null != reader[Constants.OUT_ZAHLS] ? reader[Constants.OUT_ZAHLS].ToString().Trim() : string.Empty;
            TTLUse.HBKID = null != reader[Constants.OUT_HBKID] ? reader[Constants.OUT_HBKID].ToString().Trim() : string.Empty;
            TTLUse.KALSK = null != reader[Constants.OUT_KALSK] ? reader[Constants.OUT_KALSK].ToString().Trim() : string.Empty;
            TTLUse.ZTERMComp = null != reader[Constants.OUT_ZTERMComp] ? reader[Constants.OUT_ZTERMComp].ToString().Trim() : string.Empty;
            TTLUse.IBAN = null != reader[Constants.OUT_IBAN] ? reader[Constants.OUT_IBAN].ToString().Trim() : string.Empty;
            TTLUse.J_1TPBUPL = null != reader[Constants.OUT_J_1TPBUPL] ? reader[Constants.OUT_J_1TPBUPL].ToString().Trim() : string.Empty;
            TTLUse.CERDT = null != reader[Constants.OUT_CERDT] ? Convert.ToDateTime(reader[Constants.OUT_CERDT].ToString().Trim()) : DateTime.Today;
            TTLUse.QLAND = null != reader[Constants.OUT_QLAND] ? reader[Constants.OUT_QLAND].ToString().Trim() : string.Empty;
            TTLUse.VEN_CLASS = null != reader[Constants.OUT_VEN_CLASS] ? reader[Constants.OUT_VEN_CLASS].ToString().Trim() : string.Empty;

            return TTLUse;
        }
    }

}
