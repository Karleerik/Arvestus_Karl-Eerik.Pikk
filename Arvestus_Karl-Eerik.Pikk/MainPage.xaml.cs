using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Arvestus_Karl_Eerik.Pikk
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int tries = 0;
        int attempt = 3;
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {

            if (attempt > 1)
            {
                attempt--;
            }
            else
            {
                textblock2.Text = "Sisselogimiskatsed on otsas!";
                return;
            }

            string vastus;
            string kasutajanimi = textbox1.Text;
            string password = textbox2.Text;
            bool success = false;
            if (this.textbox1.Text == "user")
            {
                if (this.textbox2.Text == "SecretPassword")
                {
                    success = true;
                    vastus = "Sisselogimine õnnestus!";
                    this.Frame.Navigate(typeof(Content));
                }
                else
                {
                    vastus = "Vale parool,";
                }
            }
            else
            {
                vastus = "Vale kasutaja,";
            }
            if (!success && attempt > 1)
            {
                vastus += " Teil on veel " + Convert.ToString(attempt) + " katset järel!";
            }
            else if (!success && attempt == 1)
            {
                vastus += " Teil on viimane katse jäänud!";

            }


            textblock2.Text = vastus;
        }
    }
}