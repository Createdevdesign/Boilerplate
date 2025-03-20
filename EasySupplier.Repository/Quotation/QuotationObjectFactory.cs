using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    

    internal class QuotationObjectFactory : IDomainObjectFactory<Quotation>
    {
        public Quotation Construct(IDataReader reader)
        {
            Quotation Quotation = new Quotation();

            //Quotation.QtnId = null != reader[Constants.OUI_QTN_ID] ? Convert.ToInt32(reader[Constants.OUI_QTN_ID].ToString().Trim()) : 0;
            //Quotation.QtnPindId = null != reader[Constants.OUI_QTN_PIND_ID] ? Convert.ToInt32(reader[Constants.OUI_QTN_PIND_ID].ToString().Trim()) : 0;
            //Quotation.QtnNum = null != reader[Constants.OUI_QTN_NUM] ? reader[Constants.OUI_QTN_NUM].ToString().Trim() : string.Empty;
            //Quotation.QtnStatus = null != reader[Constants.OUI_QTN_STATUS] ? Convert.ToInt32(reader[Constants.OUI_QTN_STATUS].ToString().Trim()) : 0;
            //Quotation.QtnVndId = null != reader[Constants.OUI_QTN_VND_ID] ? Convert.ToInt32(reader[Constants.OUI_QTN_VND_ID].ToString().Trim()) : 0;
            //Quotation.QtnOrgId = null != reader[Constants.OUI_QTN_ORG_ID] ? Convert.ToInt32(reader[Constants.OUI_QTN_ORG_ID].ToString().Trim()) : 0;
            //Quotation.QtnOverallStatus = null != reader[Constants.OUI_QTN_OVERALL_STATUS] ? Convert.ToInt32(reader[Constants.OUI_QTN_OVERALL_STATUS].ToString().Trim()) : 0;
            //Quotation.IsDeleted = DBNull.Value != reader[Constants.OUI_IS_DELETED_YN] ? Convert.ToBoolean(reader[Constants.OUI_IS_DELETED_YN].ToString().Trim()) : false;
            //Quotation.CreatedBy = null != reader[Constants.OUI_CREATED_BY] ? Convert.ToInt32(reader[Constants.OUI_CREATED_BY].ToString().Trim()) : 0;
            //Quotation.CreatedDtm = null != reader[Constants.OUI_CREATED_DTM] ? Convert.ToDateTime(reader[Constants.OUI_CREATED_DTM].ToString().Trim()) : DateTime.Today;
            //Quotation.ModifyBy = null != reader[Constants.OUI_MODIFY_BY] ? Convert.ToInt32(reader[Constants.OUI_MODIFY_BY].ToString().Trim()) : 0;
            //Quotation.ModifyDtm = null != reader[Constants.OUI_MODIFY_DTM] ? Convert.ToDateTime(reader[Constants.OUI_MODIFY_DTM].ToString().Trim()) : DateTime.Today;
            //Quotation.QtnFilenm = null != reader[Constants.OUI_QTN_FILENM] ? reader[Constants.OUI_QTN_FILENM].ToString().Trim() : string.Empty;
            //Quotation.QtnFilenmSaved = null != reader[Constants.OUI_QTN_FILENM_SAVED] ? reader[Constants.OUI_QTN_FILENM_SAVED].ToString().Trim() : string.Empty;

            Quotation.ContactPerson = null != reader[Constants.OUT_CONTACT_PERSON] ? reader[Constants.OUT_CONTACT_PERSON].ToString().Trim() : string.Empty;
            Quotation.QtnDate = null != reader[Constants.OUT_QTN_DATE] ? Convert.ToDateTime(reader[Constants.OUT_QTN_DATE].ToString().Trim()) : DateTime.Today;
            Quotation.QtnNumber = null != reader[Constants.OUT_QTN_NUMBER] ? Convert.ToInt32(reader[Constants.OUT_QTN_NUMBER].ToString().Trim()) : 0;
            Quotation.Remarks = null != reader[Constants.OUT_REMARKS] ? reader[Constants.OUT_REMARKS].ToString().Trim() : string.Empty;
            return Quotation;
        }
    }
}
