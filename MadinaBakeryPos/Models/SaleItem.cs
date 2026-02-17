using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadinaBakeryPos.Models
{
    public class SaleItem
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }

        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Subtotal { get; set; }

        public Sale? Sale { get; set; }
        public Product? Product { get; set; }
    }

}
