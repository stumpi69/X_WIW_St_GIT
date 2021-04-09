using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace X_WIW_St
{
    public partial class App : Application
    {
        public static Xamarin.Essentials.Location GEOdata;
        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
