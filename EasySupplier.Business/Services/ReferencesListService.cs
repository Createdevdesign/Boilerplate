using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
  

    internal class ReferencesListService : IReferencesListService
    {
        private IDataManger ReferencesListDataManger;

        public ReferencesListService(DataManger dataManger)
        {
            this.ReferencesListDataManger = dataManger;
        }

        public IList<Vendor> GetAllReferencesListData(Vendor input)
        {
            var ReferencesListData = ReferencesListDataManger.GetAllReferencesListData(input);
            return ReferencesListData;
        }
    }
}
