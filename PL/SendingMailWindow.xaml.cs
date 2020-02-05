using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
    /// Interaction logic for SendingMailWindow.xaml
    /// </summary>
    public partial class SendingMailWindow : Window
    {
        BackgroundWorker bg;
        // Credentials
        NetworkCredential credentials;
        SmtpClient client;
        public SendingMailWindow()
        {
            InitializeComponent();
            credentials = new NetworkCredential("kuku@you-spam.com", "123");

            client = new SmtpClient()
            {
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.gmail.com",
                EnableSsl = true,
                Credentials = credentials
            };

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String email = txtsender.Text;
            TextRange textRange = new TextRange(msg.Document.ContentStart, msg.Document.ContentEnd);
            String message = textRange.Text;


            // Mail message
            var mail = new MailMessage()
            {
                From = new MailAddress(email),
                Subject = "Test email.",
                Body = message
            };

            mail.To.Add(new MailAddress("kuku4now@gmail.com"));
            bg = new BackgroundWorker();
            bg.DoWork += Bg_DoWork;
            bg.ProgressChanged += Bg_ProgressChanged;
            bg.RunWorkerCompleted += Bg_RunWorkerCompleted;
            bg.WorkerReportsProgress = true;
            bg.WorkerSupportsCancellation = true;
            bg.RunWorkerAsync(new List<Object> { client, mail });
        }

        private void Bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SentTxt.Text = "Email sccessfully sent";
            SentTxt.Visibility = Visibility.Visible;
        }

        private void Bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressbar.Value += e.ProgressPercentage;
        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Object> args = (List<Object>)e.Argument;
            SmtpClient client = args[0] as SmtpClient;
            MailMessage message = args[1] as MailMessage;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            try
            {

                client.Send(message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //don't know
                throw;
            }
            finally
            {
                sw.Stop();
            }
        }
    }
}
