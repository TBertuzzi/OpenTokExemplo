using System;
using Xamarin.Forms;
using Xamarin.Forms.OpenTok.Service;
using Xamarin.Forms.Xaml;

namespace OpenTokExemplo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CrossOpenTok.Current.ApiKey = "SUAAPIKEY";
            CrossOpenTok.Current.SessionId = "SEUSESSIONID";
            CrossOpenTok.Current.UserToken = "SEUTOKEN";

            MainPage = new NavigationPage( new IniciarPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
