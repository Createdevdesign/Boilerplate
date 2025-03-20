using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class LookupRepository : Repository<Lookup>
    {
        public List<Lookup> GetAllLookupMasterData(Lookup input)
        {
            ISelectionFactory<Lookup> selectionFactory = new LookupSelectFactory();
            IDomainObjectFactory<Lookup> objectFactory = new LookupObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }


        //public List<Lookup> GetAllCountryMasterData(Lookup input)
        //{
        //    ISelectionFactory<Lookup> selectionFactory = new LookupSelectFactory();
        //    IDomainObjectFactory<Lookup> objectFactory = new LookupObjectFactory();
        //    return base.GetAll(selectionFactory, objectFactory, input);
        //}
    }
}
