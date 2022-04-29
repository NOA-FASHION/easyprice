using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace easyprice
{
    
       
    public partial class MainPage : ContentPage
    {
        deviseclassCurrencyFreacks devises = new deviseclassCurrencyFreacks();
        string accesKey;
        string url;
        string devise;
        string URL;
        string Key;
        public MainPage()
        {
           

            InitializeComponent();
            var Webclient = new WebClient();
            url = "http://api.exchangeratesapi.io/v1/latest";
            Key = "af3ec8193ff38a0758849154aa1593cf";
            devise = "€";
            accesKey = "?access_key=" + Key;
            URL = url + accesKey;
            var json = Webclient.DownloadString(URL);
            devises = JsonConvert.DeserializeObject<deviseclassCurrencyFreacks>(json);
            test.Text = devises.Rates["USD"].ToString();



        }

   
    }
}
