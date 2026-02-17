using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadinaBakeryPos.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; } = "";
        public int? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public User? User { get; set; }
        public ICollection<SaleItem>? Items { get; set; }
    }

}
