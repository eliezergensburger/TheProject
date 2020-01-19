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
using BE;

namespace PL
{
    /// <summary>
    /// Interaction logic for HostingUnitWindow.xaml
    /// </summary>
    public partial class HostingUnitWindow : Window
    {
        HostingUnit hostingUnit;
        public HostingUnit HostingUnit { get => hostingUnit; }
        public HostingUnitWindow()
        {
            InitializeComponent();
            hostingUnit = new HostingUnit();
            gridAddHostingUnit.DataContext = hostingUnit;

        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            BL.FactorySingletonBL.getInstance().AddHostingUnit(hostingUnit);
        }
    }
}
