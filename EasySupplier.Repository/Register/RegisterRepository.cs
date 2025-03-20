using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;



namespace BoilerSupplier.Repository
{
   

    internal class RegisterRepository : Repository<Register>
    {
        public Register InsertRegister(Register input)
        {
            ISelectionFactory<Register> selectionFactory = new RegisterSelectFactory();
            IDomainObjectFactory<Register> objectFactory = new RegisterObjectFactory();
            return base.GetValue(selectionFactory, objectFactory, input);
        }

        
    }
}
