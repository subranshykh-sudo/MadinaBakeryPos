using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadinaBakeryPos.Models
{
    public class StockTake
    {
        public int Id { get; set; }
        public int? CountedBy { get; set; }
        public string? Note { get; set; }
        public DateTime CreatedAt { get; set; }

        public User? User { get; set; }
        public ICollection<StockTakeItem>? Items { get; set; }
    }

}
