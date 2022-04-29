using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace easyprice
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            if (!Application.Current.Properties.ContainsKey("activation"))
            {
                activaApp();

            }
            if (Application.Current.Properties.ContainsKey("activation"))
            {
                var result = Application.Current.Properties["activation"].ToString();

                if (result == "true")
                {
                    MainPage = new NavigationPage(new MyTabbedPage());
                }
                else if (result == "false")
                {
                    MainPage = new NavigationPage(new InAppPurchase());
                }
            }
            else
            {
                MainPage = new NavigationPage(new MyTabbedPage());
            }

            //MainPage = new NavigationPage(new MainPage());

        }
        void activaApp()
        {
            Application.Current.Properties["activation1"] = "true";
            Application.Current.SavePropertiesAsync();
            Application.Current.Properties["activation"] = "true";
            Application.Current.SavePropertiesAsync();
            Application.Current.Properties["dateDays"] = DateTime.Now.ToString("dd");
            Application.Current.SavePropertiesAsync();
            Application.Current.Properties["dateMonth"] = DateTime.Now.ToString("MM");
            Application.Current.SavePropertiesAsync();
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
