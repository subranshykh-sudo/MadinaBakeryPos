using MadinaBakeryPos.Models;
using MadinaBakeryPos.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MadinaBakeryPos.ViewModels
{
    public class DashboardViewModel : BindableBase
    {

        private readonly SaleService _saleService;
        private readonly InventoryService _inventoryService;
        private readonly ExpenseService _expenseService;

        public DashboardViewModel(SaleService saleService,
                                  InventoryService inventoryService,
                                  ExpenseService expenseService)
        {
            _saleService = saleService;
            _inventoryService = inventoryService;
            _expenseService = expenseService;


            RefreshCommand = new DelegateCommand(LoadStats);
            RecentSales = new ObservableCollection<SaleItem>();
            LowStockItems = new ObservableCollection<Inventory>();
        }

        public string test => "CONNECTED";

        // Commands
        public DelegateCommand RefreshCommand { get; }

        // Properties
        private decimal _totalSales;
        public decimal TotalSales
        {
            get => _totalSales;
            set => SetProperty(ref _totalSales, value);
        }

        private decimal _totalExpenses;
        public decimal TotalExpenses
        {
            get => _totalExpenses;
            set => SetProperty(ref _totalExpenses, value);
        }

        private decimal _totalProfit;
        public decimal TotalProfit
        {
            get => _totalProfit;
            set => SetProperty(ref _totalProfit, value);
        }

        public ObservableCollection<SaleItem> RecentSales { get; set; }
        public ObservableCollection<Inventory> LowStockItems { get; set; }

        // Load all stats
        private void LoadStats()
        {
            TotalSales = _saleService.GetTotalSales();
            TotalExpenses = _expenseService.GetTotalExpenses();
            TotalProfit = TotalSales - TotalExpenses;

            RecentSales.Clear();
            foreach (var sale in _saleService.GetRecentSales())
                RecentSales.Add(sale);

            LowStockItems.Clear();
            foreach (var item in _inventoryService.GetLowStockProducts())
                LowStockItems.Add(item);
        }
    }



}
