using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;


namespace BoilerSupplier.Repository
{
    
    internal class SMSFormatObjectFactory : IDomainObjectFactory<SMSFormat>
    {
        public SMSFormat Construct(IDataReader reader)
        {
            SMSFormat SMSFormat = new SMSFormat();

            SMSFormat.Format_Name = null != reader[Constants.OUT_FORMAT_NAME] ? reader[Constants.OUT_FORMAT_NAME].ToString().Trim() : string.Empty;
            SMSFormat.Format_Text = null != reader[Constants.OUT_FORMAT_TEXT] ? reader[Constants.OUT_FORMAT_TEXT].ToString().Trim() : string.Empty;
            SMSFormat.Module = null != reader[Constants.OUT_MODULE] ? Convert.ToDecimal(reader[Constants.OUT_MODULE].ToString().Trim()) : 0;

            
            return SMSFormat;
        }
    }
}
