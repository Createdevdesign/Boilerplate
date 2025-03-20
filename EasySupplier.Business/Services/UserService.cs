using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    
    internal class UserService : IUserService
    {
        private IDataManger UserDataManger;

        public UserService(DataManger dataManger)
        {
            this.UserDataManger = dataManger;
        }

        public IList<User> GetAllUserData(User input)
        {
            var UserData = UserDataManger.GetAllUserData(input);
            return UserData;
        }
    }
}
