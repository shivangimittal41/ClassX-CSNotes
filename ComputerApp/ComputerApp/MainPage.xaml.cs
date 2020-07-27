using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ComputerApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void CSS_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CSSNotes());
        }
        async void CSS2_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TypesOfCSS());
        }
        async void HTMLForm_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HTMKForm());
        }
        async void HTML_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HTMLNotes());
        }
        async void Cyber_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CyberEthics());
        }
        async void Network_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Networking());
        }
    }
}
