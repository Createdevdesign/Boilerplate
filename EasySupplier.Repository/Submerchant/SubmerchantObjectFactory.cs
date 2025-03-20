using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   
    internal class SubmerchantObjectFactory : IDomainObjectFactory<Submerchant>
    {
        public Submerchant Construct(IDataReader reader)
        {
            Submerchant Submerchant = new Submerchant();

            Submerchant.HeadMerchantID = null != reader[Constants.OUT_HEAD_MERCHANT_ID] ? reader[Constants.OUT_HEAD_MERCHANT_ID].ToString().Trim() : string.Empty;
            Submerchant.Submerchantid = null != reader[Constants.OUT_SUB_MERCHANT_ID] ? reader[Constants.OUT_SUB_MERCHANT_ID].ToString().Trim() : string.Empty;
            Submerchant.Submerchantshortid = null != reader[Constants.OUT_SUB_MERCHANT_SHORT_ID] ? reader[Constants.OUT_SUB_MERCHANT_SHORT_ID].ToString().Trim() : string.Empty;
            Submerchant.merchantid = null != reader[Constants.OUT_SUB_MERCHANT_ID] ? reader[Constants.OUT_SUB_MERCHANT_ID].ToString().Trim() : string.Empty;
            Submerchant.tollname = null != reader[Constants.OUT_TOLL_NAME] ? reader[Constants.OUT_TOLL_NAME].ToString().Trim() : string.Empty;       
           
            Submerchant.Submerchanttype = null != reader[Constants.OUT_SUB_MERCHANT_TYPE] ? reader[Constants.OUT_SUB_MERCHANT_TYPE].ToString().Trim() : string.Empty;
            Submerchant.pricemode = null != reader[Constants.OUT_PRICE_MODE] ? reader[Constants.OUT_PRICE_MODE].ToString().Trim() : string.Empty;
            Submerchant.settlementtype = null != reader[Constants.OUT_SETTLEMENT_TYPE] ? reader[Constants.OUT_SETTLEMENT_TYPE].ToString().Trim() : string.Empty;
            Submerchant.isactive = DBNull.Value != reader[Constants.OUT_IS_ACTIVE_YN] ? Convert.ToBoolean(reader[Constants.OUT_IS_ACTIVE_YN].ToString().Trim()) : false;           
            Submerchant.createdby = null != reader[Constants.OUT_CREATED_BY] ? reader[Constants.OUT_CREATED_BY].ToString().Trim() : string.Empty;           
            Submerchant.isdeleted = null != reader[Constants.OUT_IS_DELETED] ? reader[Constants.OUT_IS_DELETED].ToString().Trim() : string.Empty;

            return Submerchant;
        }
    }
}
