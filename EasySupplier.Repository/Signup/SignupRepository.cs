using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
   
    internal class SignupRepository : Repository<Signup>
    {
        public List<Signup> GetAllSignupData(Signup input)
        {
            ISelectionFactory<Signup> selectionFactory = new SignupSelectFactory();
            IDomainObjectFactory<Signup> objectFactory = new SignupObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }

        //26-7-2021
        public Signup InsertSignupDetails(Signup input)
        {
            ISelectionFactory<Signup> selectionFactory = new SignupSelectFactory();
            IDomainObjectFactory<Signup> objectFactory = new SignupObjectFactory();
            return base.GetValue(selectionFactory, objectFactory, input);
        }
    }
}
