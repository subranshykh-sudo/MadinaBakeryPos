using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadinaBakeryPos.ViewModels
{
    public class SidebarViewModel:BindableBase
    {
        private readonly IRegionManager _regionManager;

        public DelegateCommand ShowDashboard { get; }
        public DelegateCommand ShowInventory { get; }
        public DelegateCommand ShowProduct { get; }
        public DelegateCommand ShowStock { get; }
        public DelegateCommand ShowExpense { get; }
        public DelegateCommand ShowStats { get; }
        public DelegateCommand ShowAudith { get; }
        public DelegateCommand ShowSettings { get; }

        public SidebarViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            ShowDashboard = new DelegateCommand(() =>
            {
                _regionManager.RequestNavigate("ContentRegion", "DashboardView");
            });
            ShowInventory = new DelegateCommand(() => {
                _regionManager.RequestNavigate("ContentRegion", "InventoryView");
            });

            ShowProduct = new DelegateCommand(() => {
                _regionManager.RequestNavigate("ContentRegion", "ProductView");
            });

            ShowStock = new DelegateCommand(() => {
                _regionManager.RequestNavigate("ContentRegion", "StocksView");
            });

            ShowStats = new DelegateCommand(() => {
                _regionManager.RequestNavigate("ContentRegion", "StatsView");
            });

            ShowExpense = new DelegateCommand(() => {
                _regionManager.RequestNavigate("ContentRegion", "ExpensesView");
            });

            ShowAudith = new DelegateCommand(() => {
                _regionManager.RequestNavigate("ContentRegion", "AudithView");
            });

            ShowSettings = new DelegateCommand(() => {
                _regionManager.RequestNavigate("ContentRegion", "SettingView");
            });

        }

    }
}
