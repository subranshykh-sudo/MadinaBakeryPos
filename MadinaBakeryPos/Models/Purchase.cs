using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadinaBakeryPos.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int? SupplierId { get; set; }
        public decimal? TotalCost { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public Supplier? Supplier { get; set; }
        public User? User { get; set; }
        public ICollection<PurchaseItem>? Items { get; set; }
    }

}
