using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;
namespace BoilerSupplier.Business
{
   

    internal class ApprovalService : IApprovalService
    {
        private IDataManger ApprovalDataManger;

        public ApprovalService(DataManger dataManger)
        {
            this.ApprovalDataManger = dataManger;
        }

        public Approval InsertApproval(Approval input)
        {
            return ApprovalDataManger.InsertApproval(input);
        }
    }
}
