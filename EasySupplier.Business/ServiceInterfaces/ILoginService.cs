using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Business
{
    public interface ILoginService
    {
       User FindUserByIdAndPassword(User input);

        User LoginCheck(User input);
    }
}
