using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
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
    /// Interaction logic for BankWindow.xaml
    /// </summary>
    public partial class BankWindow : Window
    {
        BackgroundWorker bg = new BackgroundWorker();
        HttpWebRequest httpRequest;

        public BankWindow()
        {
            InitializeComponent();
            bg.DoWork += Bg_DoWork;
            bg.RunWorkerCompleted += Bg_RunWorkerCompleted;
            bg.ProgressChanged += Bg_ProgressChanged;
            bg.WorkerReportsProgress = true;
        }

        private void Bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           this.progressBar.Value = e.ProgressPercentage;
        }

        private void Bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DataView dv = e.Result as DataView;
            this.banksDatagrid.DataContext = dv;
        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            bg.ReportProgress(10);
            // Construct HTTP request to get the file
            string uriString = (String)e.Argument;
            httpRequest = (HttpWebRequest)WebRequest.Create(uriString);
            httpRequest.Method = WebRequestMethods.Http.Get;

            bg.ReportProgress(20);
             // Get back the HTTP response for web server
            HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            Stream httpResponseStream = httpResponse.GetResponseStream();

            bg.ReportProgress(50);
            // Construct HTTP request to get the logo

            DataSet ds = new DataSet();
            ds.ReadXml(httpResponseStream);
            e.Result = ds.Tables[0].DefaultView;
            bg.ReportProgress(100);
        }

        private void populateBanksBtn_Click(object sender, RoutedEventArgs e)
        {
            bg.RunWorkerAsync(@"https://www.boi.org.il/en/BankingSupervision/BanksAndBranchLocations/Lists/BoiBankBranchesDocs/snifim_en.xml");
        }
    }
}
