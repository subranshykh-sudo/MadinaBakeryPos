using MadinaBakeryPos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace MadinaBakeryPos.Services
{
    public class SaleService
    {
        private readonly PosDbContext _context;
        public SaleService(PosDbContext context) => _context = context;

        // Recent sales
        public List<SaleItem> GetRecentSales(int days = 7)
        {
            var cutoff = DateTime.Now.AddDays(-days);
            return _context.SaleItems
                .Where(si => si.Sale.CreatedAt >= cutoff)
                .OrderByDescending(si => si.Sale.CreatedAt)
                .Include(si => si.Product)
                .Include(si => si.Sale)
                .Take(50) // last 50 items
                .ToList();
        }

        // Total sales in given period
        public decimal GetTotalSales(DateTime? start = null, DateTime? end = null)
        {
            start ??= DateTime.Today;
            end ??= DateTime.Now;
            return _context.Sales
                .Where(s => s.CreatedAt >= start && s.CreatedAt <= end)
                .Sum(s => s.TotalAmount);
        }

        // Top selling products
        public List<Product> GetTopProducts(int top = 5)
        {
            return _context.SaleItems
                .GroupBy(si => si.ProductId)
                .Select(g => new { ProductId = g.Key, Qty = g.Sum(x => x.Qty) })
                .OrderByDescending(x => x.Qty)
                .Take(top)
                .Join(_context.Products, x => x.ProductId, p => p.Id, (x, p) => p)
                .ToList();
        }
    }

}
