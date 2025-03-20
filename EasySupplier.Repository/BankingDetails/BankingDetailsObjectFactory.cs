using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   
    internal class BankingDetailsObjectFactory : IDomainObjectFactory<BankingDetail>
    {
        public BankingDetail Construct(IDataReader reader)
        {
            BankingDetail BankingDetail = new BankingDetail();

            BankingDetail.merchantid = null != reader[Constants.OUT_MERCHANT_ID] ? reader[Constants.OUT_MERCHANT_ID].ToString().Trim() : string.Empty;
            BankingDetail.accountnumber = null != reader[Constants.OUT_ACCOUNT_NUMBER] ? reader[Constants.OUT_ACCOUNT_NUMBER].ToString().Trim() : string.Empty;
            BankingDetail.acctype = null != reader[Constants.OUT_ACC_TYPE] ? reader[Constants.OUT_ACC_TYPE].ToString().Trim() : string.Empty;
            BankingDetail.ifsccode = null != reader[Constants.OUT_IFSC_CODE] ? reader[Constants.OUT_IFSC_CODE].ToString().Trim() : string.Empty;


            BankingDetail.bankid = null != reader[Constants.OUT_BANK_ID] ? Convert.ToDecimal(reader[Constants.OUT_BANK_ID].ToString().Trim()) : 0;

            BankingDetail.Validfrom = null != reader[Constants.OUT_VALID_FROM] ? Convert.ToDateTime(reader[Constants.OUT_VALID_FROM].ToString().Trim()) : DateTime.Today;
            BankingDetail.ValidTo = null != reader[Constants.OUT_VALID_TO] ? Convert.ToDateTime(reader[Constants.OUT_VALID_TO].ToString().Trim()) : DateTime.Today;

            BankingDetail.Isactive = DBNull.Value != reader[Constants.OUT_IS_ACTIVE_YN] ? Convert.ToBoolean(reader[Constants.OUT_IS_ACTIVE_YN].ToString().Trim()) : false;

            //BankingDetail.ChequeDetails = null != reader[Constants.OUT_PHONE_NUMBER_TYPE] ? reader[Constants.OUT_PHONE_NUMBER_TYPE].ToString().Trim() : Byte;

            BankingDetail.Createdby = null != reader[Constants.OUT_CREATED_BY] ? reader[Constants.OUT_CREATED_BY].ToString().Trim() : string.Empty;
            BankingDetail.CreatedDate = null != reader[Constants.OUT_CREATED_DATE] ? Convert.ToDateTime(reader[Constants.OUT_CREATED_DATE].ToString().Trim()) : DateTime.Today;

            BankingDetail.Updatedby = null != reader[Constants.OUT_UPDATED_BY] ? reader[Constants.OUT_UPDATED_BY].ToString().Trim() : string.Empty;
            BankingDetail.UpdatedDate = null != reader[Constants.OUT_UPDATED_DATE] ? Convert.ToDateTime(reader[Constants.OUT_UPDATED_DATE].ToString().Trim()) : DateTime.Today;

            BankingDetail.Entitytype = null != reader[Constants.OUT_ENTITY_TYPE] ? reader[Constants.OUT_ENTITY_TYPE].ToString().Trim() : string.Empty;



            return BankingDetail;
        }
    }
}
