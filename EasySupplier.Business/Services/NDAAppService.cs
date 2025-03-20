using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   


    internal class NDAAppService : INDAAppService
    {
        private IDataManger NDAAppDataManger;

        public NDAAppService(DataManger dataManger)
        {
            this.NDAAppDataManger = dataManger;
        }

        public IList<NDAApp> GetAllNDAAppData(NDAApp input)
        {
            var NDAAppData = NDAAppDataManger.GetAllNDAAppData(input);
            return NDAAppData;
        }
    }
}
