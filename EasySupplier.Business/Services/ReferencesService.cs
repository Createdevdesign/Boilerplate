using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    

    internal class ReferencesService : IReferencesService
    {
        private IDataManger ReferencesDataManger;

        public ReferencesService(DataManger dataManger)
        {
            this.ReferencesDataManger = dataManger;
        }

        public IList<References> GetAllReferencesData(References input)
        {
            var ReferencesData = ReferencesDataManger.GetAllReferencesData(input);
            return ReferencesData;
        }


    }
}
