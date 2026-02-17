using MadinaBakeryPos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace MadinaBakeryPos.Services
{
    public class InventoryService
    {
        private readonly PosDbContext _context;
        public InventoryService(PosDbContext context) => _context = context;

        public List<Inventory> GetLowStockProducts(decimal threshold = 5)
        {
            return _context.Inventories
                .Include(i => i.Product)
                .Where(i => i.Quantity <= threshold)
                .OrderBy(i => i.Quantity)
                .ToList();
        }
    }

}
