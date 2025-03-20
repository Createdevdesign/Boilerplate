using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    
    public interface ICheckPreferredUserIDService
    {
        
        IList<Signup> CheckPreferredUserID(Signup input);
    }
}
