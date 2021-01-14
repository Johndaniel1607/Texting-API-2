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

namespace Daniel.Texting_API
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtmessage_TextChanged(object sender, TextChangedEventArgs e)
        {
            charCount();
            txtmessage.MaxLength = 100;
        }

        private void charCount()
        {
            int j = txtmessage.Text.Length;
            string charcount = j.ToString() + " " + "/" + " " + "100";
            CharCount.Text = charcount;
        }

        private void btnsend_Click(object sender, RoutedEventArgs e)
        {
            char client = new RestSharp.RestClient("https://www.itexmo.com/php_api/api.php");

            var request = new RestSharp.RestRequest(RestSharp.Method.POST);
                request.AddParameter("1", "09632511471");
                request.AddParameter("2", "I LOVE YOU ");
                request.AddParameter("3", "TR-JOHND731707_N7RDR");
                request.AddParameter("passwd", "l4&qg4]km)");

            client.Execute(request);

        }
    }
}
