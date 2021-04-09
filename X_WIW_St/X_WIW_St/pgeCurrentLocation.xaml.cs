using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace X_WIW_St
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pgeCurrentLocation : ContentPage
    {
        private static string URL = "https://maps.googleapis.com/maps/api/staticmap?center={0}&zoom=15&size=640x6400&markers={0}&key=AIzaSyAPDR5aEkSIb0Y3zZlpeGo6Vkcacm2LKTw";
        public pgeCurrentLocation()
        {
            InitializeComponent();
            var url = String.Format(URL, X_WIW_St.App.GEOdata.Latitude.ToString() + "," + X_WIW_St.App.GEOdata.Longitude.ToString());
            var byteArray = new System.Net.WebClient().DownloadData(url);
            this.image.Source = ImageSource.FromStream(() => new MemoryStream(byteArray));
        }
    }
}