using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    
    internal class BankingDetailsRepository : Repository<BankingDetail>
    {
        public List<BankingDetail> GetAllBankingDetailsData(BankingDetail input)
        {
            ISelectionFactory<BankingDetail> selectionFactory = new BankingDetailsSelectFactory();
            IDomainObjectFactory<BankingDetail> objectFactory = new BankingDetailsObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}
