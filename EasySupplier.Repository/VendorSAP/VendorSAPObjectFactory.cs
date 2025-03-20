using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;


namespace BoilerSupplier.Repository
{
    
    internal class VendorSAPObjectFactory : IDomainObjectFactory<VendorSAP>
    {
        public VendorSAP Construct(IDataReader reader)
        {
            VendorSAP VendorSAP = new VendorSAP();
            //54 field
            VendorSAP.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            
            //vendorsapjson = "{\r\n\"Ekorg\":\"" + objSap.Ekorg + "\" ,\r\n\"Lifnr\":\"" + objSap.Lifnr + "\" ,
            //     \r\n\"Land1\":\"" + objSap.Land1 + "\" ,\r\n\"Name1\":\"" + objSap.Name1 + "\" ," +
            //    "\r\n\"Ort01\":\"" + objSap.Ort01 + "\" ,\r\n\"Pstlz\":\"" + objSap.Pstlz + "\" ," +
            //    "\r\n\"Regio\":\"" + objSap.Regio + "\" ,\r\n\"Sort1\":\"" + objSap.Sort1 + "\" ," +
            //    "\r\n\"Stras\":\"" + objSap.Stras + "\" ,\r\n\"HouseNum1\":\"" + objSap.HouseNum1 + "\" ," +
            //    "\r\n\"Anred\":\"" + objSap.Anred + "\" ,\r\n\"StrSuppl1\":\"" + objSap.StrSuppl1 + "\" ," +
            //    "\r\n\"StrSuppl2\":\"" + objSap.StrSuppl2 + "\",\r\n\"StrSuppl3\":\"" + objSap.StrSuppl3 + "\"," +
            //    "\r\n\"Stcd1\":\"" + objSap.Stcd1 + "\" ,\r\n\"Telf2\":\"" + objSap.Telf2 + "\" ," +
            //    "\r\n\"Stcd3\":\"" + objSap.Stcd3 + "\" ,\r\n\"Stceg\":\"" + objSap.Stceg + "\" ," +
            //    "\r\n\"Stenr\":\"" + objSap.Stenr + "\" ,\r\n\"Banks\":\"" + objSap.Banks + "\" ," +
            //    "\r\n\"Bankl\":\"" + objSap.Bankl + "\" ,\r\n\"Bankn\":\"" + objSap.Bankn + "\" ," +
            //    "\r\n\"Bkont\":\"" + objSap.Bkont + "\" ,\r\n\"Bkref\":\"" + objSap.Bkref + "\" ," +
            //    "\r\n\"Koinh\":\"" + objSap.Koinh + "\" ,\r\n\"SmtpAddr1\":\"" + objSap.SmtpAddr1 + "\" ," +
            //    "\r\n\"SmtpAddr2\":\"" + objSap.SmtpAddr2 + "\" ,\r\n\"SmtpAddr3\":\"" + objSap.SmtpAddr3 + "\" ," +
            //    "\r\n\"SmtpAddr4\":\"" + objSap.SmtpAddr4 + "\" ,\r\n\"SmtpAddr5\":\"" + objSap.SmtpAddr5 + "\" ," +
            //    "\r\n\"Akont\":\"" + objSap.Akont + "\",\r\n\"Mindk\":\"" + objSap.Mindk + "\" ," +
            //    "\r\n\"Cerdt\":\"" + objSap.Cerdt + "\",\r\n\"Zterm\":\"" + objSap.Zterm + "\" ," +
            //    "\r\n\"Reprf\":\"" + objSap.Reprf + "\" ,\r\n\"Zsabe\":\"" + objSap.Zsabe + "\" ," +
            //    "\r\n\"Waers\":\"" + objSap.Waers + "\" ,\r\n\"Kalsk\":\"" + objSap.Kalsk + "\" ," +
            //    "\r\n\"Webre\":\"" + objSap.Webre + "\" ,\r\n\"Xnbwy\":\"" + objSap.Xnbwy + "\" ," +
            //    "\r\n\"Lebre\":\"" + objSap.Lebre + "\" ,\r\n\"ZtermComp\":\"" + objSap.ZtermComp + "\" ," +
            //    "\r\n\"VenClass\":\"" + objSap.VenClass + "\" ,\r\n\"J1tpbupl\":\"" + objSap.J1tpbupl + "\" ," +
            //    "\r\n\"Name2\":\"" + objSap.Name2 + "\" ,\r\n\"TelNumber\":\"" + objSap.TelNumber + "\" ," +
            //    "\r\n\"FaxNumber\":\"" + objSap.FaxNumber + "\" ,\r\n\"Iban\":\"" + objSap.Iban + "\" ," +
            //    "\r\n\"BankType\":\"" + objSap.BankType + "\" ,\r\n\"Swift\":\"" + objSap.Swift + "\" ," +
            //    "\r\n\"Zuawa\":\"" + objSap.Zuawa + "\" ,\r\n\"Zwels\":\"" + objSap.Zwels + "\" ," +
            //    "\r\n\"Zahls\":\"" + objSap.Zahls + "\" ,\r\n\"Hbkid\":\"" + objSap.Hbkid + "\" ," +
            //    "\r\n\"Qland\":\"" + objSap.Qland + "\"";

            VendorSAP.Ekorg = null != reader[Constants.OUT_EKORG] ? reader[Constants.OUT_EKORG].ToString().Trim() : string.Empty;
            VendorSAP.Lifnr = null != reader[Constants.OUT_LIFNR] ? reader[Constants.OUT_LIFNR].ToString().Trim() : string.Empty;
            VendorSAP.Land1 = null != reader[Constants.OUT_LAND1] ? reader[Constants.OUT_LAND1].ToString().Trim() : string.Empty;
            VendorSAP.Name1 = null != reader[Constants.OUT_NAME1] ? reader[Constants.OUT_NAME1].ToString().Trim() : string.Empty;
            VendorSAP.Ort01 = null != reader[Constants.OUT_ORT01] ? reader[Constants.OUT_ORT01].ToString().Trim() : string.Empty;
            VendorSAP.Pstlz = null != reader[Constants.OUT_PSTLZ] ? reader[Constants.OUT_PSTLZ].ToString().Trim() : string.Empty;
            VendorSAP.Regio = null != reader[Constants.OUT_REGIO] ? reader[Constants.OUT_REGIO].ToString().Trim() : string.Empty;
            VendorSAP.Sort1 = null != reader[Constants.OUT_SORT1] ? reader[Constants.OUT_SORT1].ToString().Trim() : string.Empty;
            VendorSAP.Stras = null != reader[Constants.OUT_STRAS] ? reader[Constants.OUT_STRAS].ToString().Trim() : string.Empty;
            VendorSAP.HouseNum1 = null != reader[Constants.OUT_HouseNum1] ? reader[Constants.OUT_HouseNum1].ToString().Trim() : string.Empty;

            VendorSAP.Anred = null != reader[Constants.OUT_ANRED] ? reader[Constants.OUT_ANRED].ToString().Trim() : string.Empty;
            VendorSAP.StrSuppl1 = null != reader[Constants.OUT_STR_SUPPL1] ? reader[Constants.OUT_STR_SUPPL1].ToString().Trim() : string.Empty;
            VendorSAP.StrSuppl2 = null != reader[Constants.OUT_STR_SUPPL2] ? reader[Constants.OUT_STR_SUPPL2].ToString().Trim() : string.Empty;
            VendorSAP.StrSuppl3 = null != reader[Constants.OUT_STR_SUPPL3] ? reader[Constants.OUT_STR_SUPPL3].ToString().Trim() : string.Empty;
            VendorSAP.Stcd1 = null != reader[Constants.OUT_STCD1] ? reader[Constants.OUT_STCD1].ToString().Trim() : string.Empty;
            VendorSAP.Telf2 = null != reader[Constants.OUT_TELF2] ? reader[Constants.OUT_TELF2].ToString().Trim() : string.Empty;
            VendorSAP.Stcd3 = null != reader[Constants.OUT_STCD3] ? reader[Constants.OUT_STCD3].ToString().Trim() : string.Empty;
            VendorSAP.Stceg = null != reader[Constants.OUT_STCEG] ? reader[Constants.OUT_STCEG].ToString().Trim() : string.Empty;
            VendorSAP.Stenr = null != reader[Constants.OUT_STENR] ? reader[Constants.OUT_STENR].ToString().Trim() : string.Empty;
            VendorSAP.Banks = null != reader[Constants.OUT_BANKS] ? reader[Constants.OUT_BANKS].ToString().Trim() : string.Empty;

            VendorSAP.Bankl = null != reader[Constants.OUT_BANKL] ? reader[Constants.OUT_BANKL].ToString().Trim() : string.Empty;
            VendorSAP.Bankn = null != reader[Constants.OUT_BANKN] ? reader[Constants.OUT_BANKN].ToString().Trim() : string.Empty;
            VendorSAP.Bkont = null != reader[Constants.OUT_BKONT] ? reader[Constants.OUT_BKONT].ToString().Trim() : string.Empty;
            VendorSAP.Bkref = null != reader[Constants.OUT_BKREF] ? reader[Constants.OUT_BKREF].ToString().Trim() : string.Empty;
            VendorSAP.Koinh = null != reader[Constants.OUT_KOINH] ? reader[Constants.OUT_KOINH].ToString().Trim() : string.Empty;
            VendorSAP.SmtpAddr1 = null != reader[Constants.OUT_SMTP_ADDR1] ? reader[Constants.OUT_SMTP_ADDR1].ToString().Trim() : string.Empty;
            VendorSAP.SmtpAddr2 = null != reader[Constants.OUT_SMTP_ADDR2] ? reader[Constants.OUT_SMTP_ADDR2].ToString().Trim() : string.Empty;
            VendorSAP.SmtpAddr3 = null != reader[Constants.OUT_SMTP_ADDR3] ? reader[Constants.OUT_SMTP_ADDR3].ToString().Trim() : string.Empty;
            VendorSAP.SmtpAddr4 = null != reader[Constants.OUT_SMTP_ADDR4] ? reader[Constants.OUT_SMTP_ADDR4].ToString().Trim() : string.Empty;
            VendorSAP.SmtpAddr5 = null != reader[Constants.OUT_SMTP_ADDR5] ? reader[Constants.OUT_SMTP_ADDR5].ToString().Trim() : string.Empty;

            VendorSAP.Akont = null != reader[Constants.OUT_AKONT] ? reader[Constants.OUT_AKONT].ToString().Trim() : string.Empty;
            VendorSAP.Mindk = null != reader[Constants.OUT_MINDK] ? reader[Constants.OUT_MINDK].ToString().Trim() : string.Empty;
            VendorSAP.Cerdt = null != reader[Constants.OUT_CERDT] ? reader[Constants.OUT_CERDT].ToString().Trim() : string.Empty;
            VendorSAP.Zterm = null != reader[Constants.OUT_ZTERM] ? reader[Constants.OUT_ZTERM].ToString().Trim() : string.Empty;
            VendorSAP.Reprf = null != reader[Constants.OUT_REPRF] ? reader[Constants.OUT_REPRF].ToString().Trim() : string.Empty;
            VendorSAP.Zsabe = null != reader[Constants.OUT_ZSABE] ? reader[Constants.OUT_ZSABE].ToString().Trim() : string.Empty;
            VendorSAP.Waers = null != reader[Constants.OUT_WAERS] ? reader[Constants.OUT_WAERS].ToString().Trim() : string.Empty;
            VendorSAP.Xnbwy = null != reader[Constants.OUT_XNBWY] ? reader[Constants.OUT_XNBWY].ToString().Trim() : string.Empty;
            VendorSAP.Lebre = null != reader[Constants.OUT_LEBRE] ? reader[Constants.OUT_LEBRE].ToString().Trim() : string.Empty;
            VendorSAP.ZtermComp = null != reader[Constants.OUT_ZTERMComp] ? reader[Constants.OUT_ZTERMComp].ToString().Trim() : string.Empty;

            VendorSAP.VenClass = null != reader[Constants.OUT_VEN_CLASS] ? reader[Constants.OUT_VEN_CLASS].ToString().Trim() : string.Empty;
            VendorSAP.J1tpbupl = null != reader[Constants.OUT_J_1TPBUPL] ? reader[Constants.OUT_J_1TPBUPL].ToString().Trim() : string.Empty;
            VendorSAP.Name2 = null != reader[Constants.OUT_NAME2] ? reader[Constants.OUT_NAME2].ToString().Trim() : string.Empty;
            VendorSAP.TelNumber = null != reader[Constants.OUT_TELNUMBER] ? reader[Constants.OUT_TELNUMBER].ToString().Trim() : string.Empty;
            VendorSAP.FaxNumber = null != reader[Constants.OUT_FAXNUMBER] ? reader[Constants.OUT_FAXNUMBER].ToString().Trim() : string.Empty;
            VendorSAP.Iban = null != reader[Constants.OUT_IBAN] ? reader[Constants.OUT_IBAN].ToString().Trim() : string.Empty;
            VendorSAP.BankType = null != reader[Constants.OUT_BANKTYPE] ? reader[Constants.OUT_BANKTYPE].ToString().Trim() : string.Empty;
            VendorSAP.Swift = null != reader[Constants.OUT_SWIFT] ? reader[Constants.OUT_SWIFT].ToString().Trim() : string.Empty;
            VendorSAP.Zuawa = null != reader[Constants.OUT_ZUAWA] ? reader[Constants.OUT_ZUAWA].ToString().Trim() : string.Empty;
            VendorSAP.Zwels = null != reader[Constants.OUT_ZWELS] ? reader[Constants.OUT_ZWELS].ToString().Trim() : string.Empty;

            VendorSAP.Zahls = null != reader[Constants.OUT_ZAHLS] ? reader[Constants.OUT_ZAHLS].ToString().Trim() : string.Empty;
            VendorSAP.Hbkid = null != reader[Constants.OUT_HBKID] ? reader[Constants.OUT_HBKID].ToString().Trim() : string.Empty;
            VendorSAP.Qland = null != reader[Constants.OUT_QLAND] ? reader[Constants.OUT_QLAND].ToString().Trim() : string.Empty;
           
            return VendorSAP;
        }
    }
}
