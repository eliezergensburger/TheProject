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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BL;
using BE;

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BL.Ibl instance;
        public MainWindow()
        {
            InitializeComponent();
            instance = FactorySingletonBL.getInstance();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order
            {
                CreateDate = DateTime.Now.AddDays(-3),
                GuestRequestKey = "imbecile heureux",
                HostingUnitKey = "12123",
                OrderDate = DateTime.Now,
                OrderKey = 23
            };
            instance.AddOrder(order);

        }
    }
}
