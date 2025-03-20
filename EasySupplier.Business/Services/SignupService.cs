using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   
    internal class SignupService : ISignupService
    {
        private IDataManger SignupDataManger;

        public SignupService(DataManger dataManger)
        {
            this.SignupDataManger = dataManger;
        }

        public IList<Signup> GetAllSignupData(Signup input)
        {
            var SignupData = SignupDataManger.GetAllSignupData(input);
            return SignupData;
        }

        public Signup InsertSignupDetails(Signup input)
        {
            return SignupDataManger.InsertSignupDetails(input);
        }
    }
}
