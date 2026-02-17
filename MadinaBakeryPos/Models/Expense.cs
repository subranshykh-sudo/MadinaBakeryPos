using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadinaBakeryPos.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public decimal Amount { get; set; }
        public string? Note { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public ExpenseCategory? Category { get; set; }
        public User? User { get; set; }
    }

}
