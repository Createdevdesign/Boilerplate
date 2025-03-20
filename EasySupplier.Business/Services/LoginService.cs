using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System.Collections.Generic;

namespace BoilerSupplier.Business
{
    internal class LoginService : ILoginService
    {
        private IDataManger loginDataManger;

        public LoginService(DataManger dataManger)
        {
            this.loginDataManger = dataManger;
        }
        public User FindUserByIdAndPassword(User input)
        {
            return loginDataManger.FindUserByIdAndPassword(input);
        }

        public User LoginCheck(User input)
        {
            return loginDataManger.LoginCheck(input);
        }
    }
}
