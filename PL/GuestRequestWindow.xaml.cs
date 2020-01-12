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
    /// Interaction logic for GuestRequestWindow.xaml
    /// </summary>
    public partial class GuestRequestWindow : Window
    {
        GuestRequest guestRequest;
        public GuestRequest GuestRequest { get => guestRequest; }

        public GuestRequestWindow()
        {
            InitializeComponent();
            guestRequest = new GuestRequest();

          //constants from enum declaration
            areaComboBox.ItemsSource = Enum.GetValues(typeof(BE.Area));
            gardenComboBox.ItemsSource = Enum.GetValues(typeof(BE.Requirements));
            poolComboBox.ItemsSource = Enum.GetValues(typeof(BE.Requirements));
            childrensAttractionsComboBox.ItemsSource = Enum.GetValues(typeof(BE.Requirements));
            gardenComboBox.ItemsSource = Enum.GetValues(typeof(BE.Requirements));
            jacuzziComboBox.ItemsSource = Enum.GetValues(typeof(BE.Requirements));
            hostingTypeComboBox.ItemsSource = Enum.GetValues(typeof(BE.HostingType));

            guestRequest.EntryDate = DateTime.Now;
            guestRequest.ReleaseDate = DateTime.Now.AddDays(2);

            this.DataContext = guestRequest;
        }

        private void ConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            guestRequest.Area = (BE.Area) Enum.Parse(typeof(BE.Area),areaComboBox.SelectedItem.ToString());
            DialogResult = true;
            Close();
        }
    }
}
