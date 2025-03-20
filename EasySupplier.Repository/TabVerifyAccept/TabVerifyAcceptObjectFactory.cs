using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
  
    internal class TabVerifyAcceptObjectFactory : IDomainObjectFactory<TabVerifyAccept>
    {
        public TabVerifyAccept Construct(IDataReader reader)
        {
            TabVerifyAccept TabVerifyAccept = new TabVerifyAccept();

          
            TabVerifyAccept.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
           return TabVerifyAccept;
        }
    }
}
