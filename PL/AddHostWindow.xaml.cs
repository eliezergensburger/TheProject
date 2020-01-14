using BE;
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

namespace PL
{
    /// <summary>
    /// Interaction logic for AddHostWindow.xaml
    /// </summary>
    public partial class AddHostWindow : Window
    {
        private Host host = null;

        public Host Host
        {
            get { return host; }
        }

        public AddHostWindow()
        {
            InitializeComponent();

            host = new Host();
            this.DataContext = host;
            collectionClearanceComboBox.ItemsSource = Enum.GetValues(typeof(BE.CollectionClearance));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            host.CollectionClearance = (BE.CollectionClearance)Enum.Parse(typeof(BE.CollectionClearance), collectionClearanceComboBox.SelectedItem.ToString());
            DialogResult = true;
            Close();
        }
    }
}
