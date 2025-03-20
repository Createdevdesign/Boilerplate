using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoilerSupplier.DataTransferObject
{
    public class Product
    {
       
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public bool isDisCountApplied { get; set; }
    }
}
