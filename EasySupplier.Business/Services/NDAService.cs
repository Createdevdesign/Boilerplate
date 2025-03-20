using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   


    internal class NDAService : INDAService
    {
        private IDataManger NDADataManger;

        public NDAService(DataManger dataManger)
        {
            this.NDADataManger = dataManger;
        }

        public IList<NDAApp> GetAllNDAData(NDAApp input)
        {
            var NDAData = NDADataManger.GetAllNDAData(input);
            return NDAData;
        }
    }
}
