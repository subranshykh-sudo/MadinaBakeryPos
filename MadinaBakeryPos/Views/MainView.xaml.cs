using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MadinaBakeryPos.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView
    {
        public MainView()
        {
            InitializeComponent();

        }
        private void MenuToggle_Click(object sender, RoutedEventArgs e)
        {
            if (SidebarColumn.Width.Value == 220)
                SidebarColumn.Width = new GridLength(60);
            else
                SidebarColumn.Width = new GridLength(220);
        }
    }
}
