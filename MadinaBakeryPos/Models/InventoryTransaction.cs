using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadinaBakeryPos.Models
{
    public class InventoryTransaction
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal ChangeQty { get; set; }
        public string TransactionType { get; set; } = "";
        public int? ReferenceId { get; set; }
        public string? Note { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public Product? Product { get; set; }
        public User? User { get; set; }
    }

}
