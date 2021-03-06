﻿using System;
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
  
            GuestRequestWindow wnd = new GuestRequestWindow();
            wnd.ShowDialog();
            if (wnd.DialogResult== true)
            {
                MessageBox.Show(wnd.GuestRequest.ToString(), "kuku was here");
                instance.AddGuestRequest(wnd.GuestRequest);
                //TO DO
            }

        }

        private void btnAddHost_Click(object sender, RoutedEventArgs e)
        {
            AddHostWindow wnd = new AddHostWindow();
            wnd.ShowDialog();
            if(wnd.DialogResult==true)
            {               
                instance.AddHost(wnd.Host);
            }
        }

        private void HostingUnitsBtn_Click(object sender, RoutedEventArgs e)
        {
            HostingUnitWindow wnd = new HostingUnitWindow();
            wnd.Show();
        }

        private void BanksBtn_Click(object sender, RoutedEventArgs e)
        {
            BankWindow banksWindow = new BankWindow();
            banksWindow.Show();
        }
    }
}
