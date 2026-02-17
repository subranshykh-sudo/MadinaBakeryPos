using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadinaBakeryPos.Models
{
    public class PurchaseItem
    {
        public int Id { get; set; }
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }

        public decimal Qty { get; set; }
        public decimal CostPrice { get; set; }
        public decimal Subtotal { get; set; }

        public Purchase? Purchase { get; set; }
        public Product? Product { get; set; }
    }

}
