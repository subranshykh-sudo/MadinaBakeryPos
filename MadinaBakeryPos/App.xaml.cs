using ControlzEx.Theming;
using MadinaBakeryPos.Services;
using MadinaBakeryPos.Views;
using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.EntityFrameworkCore;

namespace MadinaBakeryPos
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return ContainerLocator.Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Navigation
            containerRegistry.RegisterForNavigation<DashboardView>();
            containerRegistry.RegisterForNavigation<InventoryView>();
            containerRegistry.RegisterForNavigation<ProductView>();
            containerRegistry.RegisterForNavigation<StocksView>();
            containerRegistry.RegisterForNavigation<StatsView>();
            containerRegistry.RegisterForNavigation<AudithView>();
            containerRegistry.RegisterForNavigation<ExpensesView>();
            containerRegistry.RegisterForNavigation<SettingView>();

            // DbContext (EF Core)
            containerRegistry.RegisterSingleton<PosDbContext>(() =>
            {
                var options = new DbContextOptionsBuilder<PosDbContext>()
                    .UseSqlServer("Server=DESKTOP-GEV7JE1\\SQLEXPRESS;Database=pos_db;Trusted_Connection=True;")
                    .Options;

                return new PosDbContext(options);
            });

            // Services
            containerRegistry.RegisterSingleton<SaleService>();
            containerRegistry.RegisterSingleton<InventoryService>();
            containerRegistry.RegisterSingleton<ExpenseService>();
        }


        protected override void OnInitialized()
        {
            base.OnInitialized();
            ThemeManager.Current.ChangeTheme(Application.Current, "Dark.Blue");
            var regionManager = ContainerLocator.Container.Resolve<IRegionManager>();
            regionManager.RequestNavigate("ContentRegion", "DashboardView");
            regionManager.RegisterViewWithRegion<SidebarView>("SidebarRegion");
        }

    }


}
