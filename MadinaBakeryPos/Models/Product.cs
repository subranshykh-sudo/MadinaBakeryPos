using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadinaBakeryPos.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int? BrandId { get; set; }
        public int UnitTypeId { get; set; }

        public string ProductCode { get; set; } = "";
        public string ProductName { get; set; } = "";

        public decimal CostPrice { get; set; }
        public decimal RetailPrice { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public Category? Category { get; set; }
        public Brand? Brand { get; set; }
        public UnitType? UnitType { get; set; }
    }

}
