using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace easyprice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyTabbedPage : TabbedPage
    {
        deviseclassCurrencyFreacks Devises = new deviseclassCurrencyFreacks();
        //string accesKey;
        //string url;
        //string devise;
        //string URL;
        //string Key;
        public MyTabbedPage()
        {
            InitializeComponent();
            //activaAppAsync();
            activaApp();

        }
        void activaApp()
        {
            if (Application.Current.Properties.ContainsKey("activation1"))
            {

                String activation1 = Application.Current.Properties["activation1"].ToString();
                if (activation1 == "true")
                {

                    if (Application.Current.Properties.ContainsKey("dateDays") && Application.Current.Properties.ContainsKey("dateMonth"))
                    {
                        String dateActivation1 = Application.Current.Properties["dateMonth"].ToString();
                        String dateActivation = Application.Current.Properties["dateDays"].ToString();
                        String dayNow = DateTime.Now.ToString("dd");
                        String monthNow = DateTime.Now.ToString("MM");
                        if ((int.Parse(dayNow) > (int.Parse(dateActivation) + 1)) && (int.Parse(monthNow) > (int.Parse(dateActivation1))))
                        {
                            Application.Current.Properties["activation"] = "false";
                            Application.Current.SavePropertiesAsync();
                            Application.Current.Properties["activation1"] = "false";
                            Application.Current.SavePropertiesAsync();
                        }
                    }
                }
            }

        }

      
        

    }
}
