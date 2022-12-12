using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax.Entities
{
    public class Basket
    {
        public List<Item> Items { get; set; }
        public decimal TotalSalesTax { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
