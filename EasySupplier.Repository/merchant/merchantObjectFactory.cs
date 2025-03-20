using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    internal class merchantObjectFactory : IDomainObjectFactory<merchant>
    {
        public merchant Construct(IDataReader reader)
        {
            merchant merchant = new merchant();

           
            merchant.merchantid = null != reader[Constants.OUT_MERCHANT_ID] ? reader[Constants.OUT_MERCHANT_ID].ToString().Trim() : string.Empty;
            merchant.merchantname = null != reader[Constants.OUT_MERCHANT_NAME] ? reader[Constants.OUT_MERCHANT_NAME].ToString().Trim() : string.Empty;
            //merchant.merchantlogo = null != reader[Constants.OUT_CODE_TYPE_DESC] ? Convert.ToByte(reader[Constants.OUT_CODE_TYPE_DESC].ToString().Trim()) : Byte;
            merchant.activactionkey = null != reader[Constants.OUT_ACTIV_ACTION_KEY] ? reader[Constants.OUT_ACTIV_ACTION_KEY].ToString().Trim() : string.Empty;
            merchant.createdon = null != reader[Constants.OUT_CREATED_ON] ? Convert.ToDateTime(reader[Constants.OUT_CREATED_ON].ToString().Trim()) : DateTime.Today;
            merchant.createdby = null != reader[Constants.OUT_CREATED_BY] ? reader[Constants.OUT_CREATED_BY].ToString().Trim() : string.Empty;
            merchant.updatedon = null != reader[Constants.OUT_UPDATED_ON] ? Convert.ToDateTime(reader[Constants.OUT_UPDATED_ON].ToString().Trim()) : DateTime.Today;
            merchant.updatedby = null != reader[Constants.OUT_UPDATED_BY] ? reader[Constants.OUT_UPDATED_BY].ToString().Trim() : string.Empty;
            merchant.isdeleted = null != reader[Constants.OUT_IS_DELETED] ? reader[Constants.OUT_IS_DELETED].ToString().Trim() : string.Empty;
            merchant.headmerchantid = null != reader[Constants.OUT_HEAD_MERCHANT_ID] ? reader[Constants.OUT_HEAD_MERCHANT_ID].ToString().Trim() : string.Empty;
            merchant.UserType = null != reader[Constants.OUT_USER_TYPE] ? reader[Constants.OUT_USER_TYPE].ToString().Trim() : string.Empty;


            return merchant;
        }
    }
}
