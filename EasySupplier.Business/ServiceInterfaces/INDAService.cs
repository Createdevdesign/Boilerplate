using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    

    public interface INDAService
    {
        
        IList<NDAApp> GetAllNDAData(NDAApp input);
    }
}
