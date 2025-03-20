using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   

    internal class RegisterListService : IRegisterListService
    {
        private IDataManger RegisterListDataManger;

        public RegisterListService(DataManger dataManger)
        {
            this.RegisterListDataManger = dataManger;
        }

        public IList<RegisterList> GetAllRegisterListData(RegisterList input)
        {
            var RegisterListData = RegisterListDataManger.GetAllRegisterListData(input);
            return RegisterListData;
        }
    }
}
