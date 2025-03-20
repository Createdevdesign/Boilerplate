using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    
    internal class SectionCodeService : ISectionCodeService
    {
        private IDataManger SectionCodeDataManger;

        public SectionCodeService(DataManger dataManger)
        {
            this.SectionCodeDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllSectionCodeData(SAPMaster input)
        {
            var SectionCodeData = SectionCodeDataManger.GetAllSectionCodeData(input);
            return SectionCodeData;
        }
    }
}
