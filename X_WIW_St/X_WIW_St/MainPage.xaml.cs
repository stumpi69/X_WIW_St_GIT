using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace X_WIW_St
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Location location1 = await Geolocation.GetLastKnownLocationAsync();
                var location = location1;
                if (location != null) X_WIW_St.App.GEOdata = location;
                await Navigation.PushAsync(new pgeCurrentLocation());
            }
            catch {  }
        }
    }
}
