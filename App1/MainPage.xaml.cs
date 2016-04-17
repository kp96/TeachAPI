using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Web.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void signup_Click(object sender, RoutedEventArgs e)
        {
            Uri signup_uri = new Uri("http://localhost/teachmysql/signup.php");
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs.Add("username", username.Text.ToString());
            pairs.Add("userpass", password.Text.ToString());
            HttpClient client = new HttpClient();
            //put form data
            HttpFormUrlEncodedContent content = new HttpFormUrlEncodedContent(pairs);
            try
            {
                HttpResponseMessage res = await client.PostAsync(signup_uri, content);
                if (res.IsSuccessStatusCode)
                {
                    responseText.Text = res.Content.ToString();
                }
            }
            catch (Exception ex)
            {
                responseText.Text = "NETWORK_ERROR";
            }

        }

        private async void signin_Click(object sender, RoutedEventArgs e)
        {
            Uri signup_uri = new Uri("http://localhost/teachmysql/signin.php");
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs.Add("username", username.Text.ToString());
            pairs.Add("userpass", password.Text.ToString());
            HttpClient client = new HttpClient();
            //put form data
            HttpFormUrlEncodedContent content = new HttpFormUrlEncodedContent(pairs);
            try
            {
                HttpResponseMessage res = await client.PostAsync(signup_uri, content);
                if (res.IsSuccessStatusCode)
                {
                    responseText.Text = res.Content.ToString();
                }
            }
            catch (Exception ex)
            {
                responseText.Text = "NETWORK_ERROR";
            }

        }
    }
}
