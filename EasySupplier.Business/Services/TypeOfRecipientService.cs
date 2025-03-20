using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;
namespace BoilerSupplier.Business
{
   
    internal class TypeOfRecipientService : ITypeOfRecipientService
    {
        private IDataManger TypeOfRecipientDataManger;

        public TypeOfRecipientService(DataManger dataManger)
        {
            this.TypeOfRecipientDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllTypeOfRecipientData(SAPMaster input)
        {
            var TypeOfRecipientData = TypeOfRecipientDataManger.GetAllTypeOfRecipientData(input);
            return TypeOfRecipientData;
        }
    }
}
