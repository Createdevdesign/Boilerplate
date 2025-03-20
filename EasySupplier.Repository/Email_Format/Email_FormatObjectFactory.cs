using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    internal class Email_FormatObjectFactory : IDomainObjectFactory<Email_Format>
    {
        public Email_Format Construct(IDataReader reader)
        {
            Email_Format Email_Format = new Email_Format();

            Email_Format.Format_Name = null != reader[Constants.OUT_FORMAT_NAME] ? reader[Constants.OUT_FORMAT_NAME].ToString().Trim() : string.Empty;
            Email_Format.Format_Text = null != reader[Constants.OUT_FORMAT_TEXT] ? reader[Constants.OUT_FORMAT_TEXT].ToString().Trim() : string.Empty;
            Email_Format.Module = null != reader[Constants.OUT_MODULE] ? Convert.ToDecimal(reader[Constants.OUT_MODULE].ToString().Trim()) : 0;
           
            return Email_Format;
        }
    }
}
