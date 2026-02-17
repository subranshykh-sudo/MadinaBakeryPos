using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadinaBakeryPos.Models
{
    public class Inventory
    {
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal StockLimit { get; set; }

        public Product? Product { get; set; }
    }

}
