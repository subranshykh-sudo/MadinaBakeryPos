using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadinaBakeryPos.Models
{
    public class StockTakeItem
    {
        public int Id { get; set; }
        public int StockTakeId { get; set; }
        public int ProductId { get; set; }

        public decimal SystemQty { get; set; }
        public decimal PhysicalQty { get; set; }
        public decimal Difference { get; set; }

        public StockTake? StockTake { get; set; }
        public Product? Product { get; set; }
    }

}
