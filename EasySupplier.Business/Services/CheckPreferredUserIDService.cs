using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    

    internal class CheckPreferredUserIDService : ICheckPreferredUserIDService
    {
        private IDataManger CheckPreferredUserIDDataManger;

        public CheckPreferredUserIDService(DataManger dataManger)
        {
            this.CheckPreferredUserIDDataManger = dataManger;
        }

        public IList<Signup> CheckPreferredUserID(Signup input)
        {
            var CheckPreferredUserIDData = CheckPreferredUserIDDataManger.CheckPreferredUserID(input);
            return CheckPreferredUserIDData;
        }
    }
}
