using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadinaBakeryPos.Services
{
    public class ExpenseService
    {
        private readonly PosDbContext _context;
        public ExpenseService(PosDbContext context) => _context = context;

        public decimal GetTotalExpenses(DateTime? start = null, DateTime? end = null)
        {
            start ??= DateTime.Today;
            end ??= DateTime.Now;
            return _context.Expenses
                .Where(e => e.CreatedAt >= start && e.CreatedAt <= end)
                .Sum(e => e.Amount);
        }
    }

}
