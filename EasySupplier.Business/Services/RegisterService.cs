using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    
    internal class RegisterService : IRegisterService
    {
        private IDataManger RegisterDataManger;

        public RegisterService(DataManger dataManger)
        {
            this.RegisterDataManger = dataManger;
        }

        public Register InsertRegister(Register input)
        {
            return RegisterDataManger.InsertRegister(input);
        }

       

    }
}
