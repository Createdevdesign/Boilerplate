using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   
    internal class SMSFormatMappingObjectFactory : IDomainObjectFactory<SMSFormatMapping>
    {
        public SMSFormatMapping Construct(IDataReader reader)
        {
            SMSFormatMapping SMSFormatMapping = new SMSFormatMapping();

            SMSFormatMapping.ACQ_id = null != reader[Constants.OUT_ACQ_ID] ? Convert.ToDecimal(reader[Constants.OUT_ACQ_ID].ToString().Trim()) : 0;
            SMSFormatMapping.Format = null != reader[Constants.OUT_FORMAT] ? Convert.ToDecimal(reader[Constants.OUT_FORMAT].ToString().Trim()) : 0;
            SMSFormatMapping.Format_Text = null != reader[Constants.OUT_FORMAT_TEXT] ? reader[Constants.OUT_FORMAT_TEXT].ToString().Trim() : string.Empty;
          
            return SMSFormatMapping;
        }
    }
}
