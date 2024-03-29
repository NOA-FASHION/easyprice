﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace easyprice
{
    public partial class Calculator : ContentPage
    {
        string Pourcentage;
        string titelPicker;
        string accesKey;
        string url;
        double devisesDollars;
        double deviseEuros;
        double deviseCanadaDollars;
        double devisesCny;
        double devisesGbp;
        double devisesAUD;
        double devisesCHF;
        //double devisesCNH;
        double devisesJPY;
        double devisesSEK;
        double devisesNZD;
        string URL;
        string Key;
        double prixFournisseurFinal;
        double prixFinalDe = 0;
        string devise = "€";
        string coeffMultArt;

        deviseclassCurrencyFreacks Devises = new deviseclassCurrencyFreacks();
        devises2Class Devises1 = new devises2Class();
        public Calculator()
        {
            InitializeComponent();
            BindingContext = new MainPageModel();
            activeDeviseAsync();
           
            activaAppAsync();


            //dollars3.Text = "devise: "+"€";
            titelPicker = "€";

            //url = "http://data.fixer.io/api/latest";
            //Key = "9a66f3ad73018c9ac9308ebbfc882899";
            //devise = "€";
            //accesKey = "?access_key=" + Key;
            //URL = url + accesKey;


            ////url = "https://api.currencyapi.com/v3/latest";
            ////Key = "79900380-4d99-11ec-8414-356a4b7a335b&base_currency=EUR";
            ////devise = "€";
            ////accesKey = "?apikey=" + Key;
            ////URL = url + accesKey;
            ////leubon
            ///
            //url = "https://api.currencyfreaks.com/latest";
            //Key = "7fd3f6d0a0e34a6899cb5c32b08cbdad";
            //devise = "€";
            //accesKey = "?apikey=" + Key;
            //URL = url + accesKey;

            //var Webclient = new WebClient();

            //var json = Webclient.DownloadString(URL);
            //Devises = JsonConvert.DeserializeObject<deviseclassCurrencyFreacks>(json);

            //var Webclient = new WebClient();
            //url = "http://api.exchangeratesapi.io/v1/latest";
            //Key = "af3ec8193ff38a0758849154aa1593cf";
            //devise = "€";
            //accesKey = "?access_key=" + Key;
            //URL = url + accesKey;
            //var json = Webclient.DownloadString(URL);
            //Devises = JsonConvert.DeserializeObject<deviseclassCurrencyFreacks>(json);

            //devisesDollars = Devises.Rates["USD"];
            //deviseEuros = Devises.Rates["EUR"];
            //deviseCanadaDollars = Devises.Rates["CAD"];
            //devisesCny = Devises.Rates["CNY"];
            //devisesGbp = Devises.Rates["GBP"];

            //devisesAUD = Devises.Rates["AUD"];
            //devisesCHF = Devises.Rates["CHF"];
            //devisesJPY = Devises.Rates["JPY"];
            //devisesSEK = Devises.Rates["SEK"];
            //devisesNZD = Devises.Rates["NZD"];

        }

       
        void activaAppAsync()
        {

            if (!Application.Current.Properties.ContainsKey("dateDaysDevise"))
            {
                var Webclient = new WebClient();
                url = "http://api.exchangeratesapi.io/v1/latest";
                Key = "af3ec8193ff38a0758849154aa1593cf";
                devise = "€";
                accesKey = "?access_key=" + Key;
                URL = url + accesKey;
                var json = Webclient.DownloadString(URL);
                Devises = JsonConvert.DeserializeObject<deviseclassCurrencyFreacks>(json);
                Application.Current.Properties["dateMonthDevise"] = DateTime.Now.ToString("MM");
                 //Application.Current.SavePropertiesAsync();

                Application.Current.Properties["dateDaysDevise"] = DateTime.Now.ToString("dd");
                 //Application.Current.SavePropertiesAsync();

                Application.Current.Properties["devisesDollars"] = Devises.Rates["USD"].ToString();
                 //Application.Current.SavePropertiesAsync();

                Application.Current.Properties["deviseEuros"] = Devises.Rates["EUR"].ToString();
                 //Application.Current.SavePropertiesAsync();
                Application.Current.Properties["deviseCanadaDollars"] = Devises.Rates["CAD"].ToString();
                 //Application.Current.SavePropertiesAsync();

                Application.Current.Properties["devisesCny"] = Devises.Rates["CNY"].ToString();
                 //Application.Current.SavePropertiesAsync();

                Application.Current.Properties["devisesGbp"] = Devises.Rates["GBP"].ToString();
                 //Application.Current.SavePropertiesAsync();

                Application.Current.Properties["devisesAUD"] = Devises.Rates["AUD"].ToString();
                 //Application.Current.SavePropertiesAsync();

                Application.Current.Properties["devisesCHF"] = Devises.Rates["CHF"].ToString();
                 //Application.Current.SavePropertiesAsync();

                Application.Current.Properties["devisesJPY"] = Devises.Rates["JPY"].ToString();
                 //Application.Current.SavePropertiesAsync();

                Application.Current.Properties["devisesSEK"] = Devises.Rates["SEK"].ToString();
                 //Application.Current.SavePropertiesAsync();

                Application.Current.Properties["devisesNZD"] = Devises.Rates["NZD"].ToString();
                 Application.Current.SavePropertiesAsync();


                validDevise();
            }
         

        }


        void validDevise()
        {

            if (Application.Current.Properties.ContainsKey("devisesDollars"))
            {
                var result = Application.Current.Properties["devisesDollars"].ToString();

                devisesDollars = double.Parse(result);
            }
            if (Application.Current.Properties.ContainsKey("deviseEuros"))
            {
                var result = Application.Current.Properties["deviseEuros"].ToString();
                deviseEuros = double.Parse(result);
            }
            if (Application.Current.Properties.ContainsKey("deviseCanadaDollars"))
            {
                var result = Application.Current.Properties["deviseCanadaDollars"].ToString();
                deviseCanadaDollars = double.Parse(result);
            }
            if (Application.Current.Properties.ContainsKey("devisesCny"))
            {
                var result = Application.Current.Properties["devisesCny"].ToString();
                devisesCny = double.Parse(result);
            }
            if (Application.Current.Properties.ContainsKey("devisesGbp"))
            {
                var result = Application.Current.Properties["devisesGbp"].ToString();
                devisesGbp = double.Parse(result);
            }
            if (Application.Current.Properties.ContainsKey("devisesAUD"))
            {
                var result = Application.Current.Properties["devisesAUD"].ToString();
                devisesAUD = double.Parse(result);
            }
            if (Application.Current.Properties.ContainsKey("devisesCHF"))
            {
                var result = Application.Current.Properties["devisesCHF"].ToString();
                devisesCHF = double.Parse(result);
            }
            if (Application.Current.Properties.ContainsKey("devisesJPY"))
            {
                var result = Application.Current.Properties["devisesJPY"].ToString();
                devisesJPY = double.Parse(result);
            }
            if (Application.Current.Properties.ContainsKey("devisesSEK"))
            {
                var result = Application.Current.Properties["devisesSEK"].ToString();
                devisesSEK = double.Parse(result);
            }
            if (Application.Current.Properties.ContainsKey("devisesNZD"))
            {
                var result = Application.Current.Properties["devisesNZD"].ToString();
                devisesNZD = double.Parse(result);
            }

        }

        void activeDeviseAsync()
        {
            if (Application.Current.Properties.ContainsKey("dateDaysDevise") || Application.Current.Properties.ContainsKey("dateMonthDevise"))
            {
                String dayNow = DateTime.Now.ToString("dd");
                String monthNow = DateTime.Now.ToString("MM");

                var result = Application.Current.Properties["dateDaysDevise"].ToString();
                var result2 = Application.Current.Properties["dateMonthDevise"].ToString();
                if ((int.Parse(dayNow) != (int.Parse(result))) || (int.Parse(monthNow) != (int.Parse(result2))))
                {
                    var Webclient = new WebClient();
                    url = "http://api.exchangeratesapi.io/v1/latest";
                    Key = "af3ec8193ff38a0758849154aa1593cf";
                    devise = "€";
                    accesKey = "?access_key=" + Key;
                    URL = url + accesKey;
                    var json = Webclient.DownloadString(URL);
                    Devises = JsonConvert.DeserializeObject<deviseclassCurrencyFreacks>(json);
                    Application.Current.Properties["dateMonthDevise"] = DateTime.Now.ToString("MM");
                     //Application.Current.SavePropertiesAsync();

                    Application.Current.Properties["dateDaysDevise"] = DateTime.Now.ToString("dd");
                     //Application.Current.SavePropertiesAsync();

                    Application.Current.Properties["devisesDollars"] = Devises.Rates["USD"].ToString();
                     //Application.Current.SavePropertiesAsync();

                    Application.Current.Properties["deviseEuros"] = Devises.Rates["EUR"].ToString();
                     //Application.Current.SavePropertiesAsync();
                    Application.Current.Properties["deviseCanadaDollars"] = Devises.Rates["CAD"].ToString();
                     //Application.Current.SavePropertiesAsync();

                    Application.Current.Properties["devisesCny"] = Devises.Rates["CNY"].ToString();
                     //Application.Current.SavePropertiesAsync();

                    Application.Current.Properties["devisesGbp"] = Devises.Rates["GBP"].ToString();
                     //Application.Current.SavePropertiesAsync();

                    Application.Current.Properties["devisesAUD"] = Devises.Rates["AUD"].ToString();
                     //Application.Current.SavePropertiesAsync();

                    Application.Current.Properties["devisesCHF"] = Devises.Rates["CHF"].ToString();
                     //Application.Current.SavePropertiesAsync();

                    Application.Current.Properties["devisesJPY"] = Devises.Rates["JPY"].ToString();
                     //Application.Current.SavePropertiesAsync();

                    Application.Current.Properties["devisesSEK"] = Devises.Rates["SEK"].ToString();
                     //Application.Current.SavePropertiesAsync();

                    Application.Current.Properties["devisesNZD"] = Devises.Rates["NZD"].ToString();
                     Application.Current.SavePropertiesAsync();
                    validDevise();

                }
                else
                {
                    validDevise();
                }
            }


        }


        void OnPickerSelectedIndexChanged2(object sender, EventArgs e)
        {
            var picker2 = (Picker)sender;
            int selectedIndex = picker2.SelectedIndex;
            var valeurPicker = "";


            if (selectedIndex != -1)
            {
                valeurPicker = (string)picker2.ItemsSource[selectedIndex];
                if (valeurPicker == "€" && titelPicker == "€")
                {
                    changDevisesEuros(valeurPicker, deviseEuros);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "€";
                }
                else if (valeurPicker == "$" && titelPicker == "€")
                {
                    changDevisesEuros(valeurPicker, devisesDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$";
                }
                else if (valeurPicker == "$C" && titelPicker == "€")
                {
                    changDevisesEuros(valeurPicker, deviseCanadaDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$C";
                }
                else if (valeurPicker == "£" && titelPicker == "€")
                {
                    changDevisesEuros(valeurPicker, devisesGbp);
                    //dollars3.Text = "Devise: " + "GBP";
                    devise = valeurPicker;
                    titelPicker = "£";
                }
                else if (valeurPicker == "￥" && titelPicker == "€")
                {
                    changDevisesEuros(valeurPicker, devisesCny);
                    //dollars3.Text = "Devise: " + "CNY";
                    devise = valeurPicker;
                    titelPicker = "￥";
                }


                else if (valeurPicker == "$A" && titelPicker == "€")
                {
                    changDevisesEuros(valeurPicker, devisesAUD);
                    //dollars3.Text = "Devise: " + "AUD";
                    devise = valeurPicker;
                    titelPicker = "$A";
                }
                else if (valeurPicker == "FrS" && titelPicker == "€")
                {
                    changDevisesEuros(valeurPicker, devisesCHF);
                    //dollars3.Text = "Devise: " + "CHF";
                    devise = valeurPicker;
                    titelPicker = "FrS";
                }

                else if (valeurPicker == "kr" && titelPicker == "€")
                {
                    changDevisesEuros(valeurPicker, devisesSEK);
                    //dollars3.Text = "Devise: " + "SEK";
                    devise = valeurPicker;
                    titelPicker = "kr";
                }
                else if (valeurPicker == "JP¥" && titelPicker == "€")
                {
                    changDevisesEuros(valeurPicker, devisesJPY);
                    //dollars3.Text = "JPY";
                    devise = valeurPicker;
                    titelPicker = "Devise: " + "JP¥";
                }
                else if (valeurPicker == "$N" && titelPicker == "€")
                {
                    changDevisesEuros(valeurPicker, devisesNZD);
                    //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$N";
                }






                else if (valeurPicker == "€" && titelPicker == "$")
                {
                    changDevisesOriginDollars(valeurPicker, deviseEuros);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "€";
                }
                else if (valeurPicker == "$" && titelPicker == "$")
                {
                    changDevisesOriginDollars(valeurPicker, devisesDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$";
                }
                else if (valeurPicker == "$C" && titelPicker == "$")
                {
                    changDevisesOriginDollars(valeurPicker, deviseCanadaDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$C";
                }
                else if (valeurPicker == "£" && titelPicker == "$")
                {
                    changDevisesOriginDollars(valeurPicker, devisesGbp);
                    //dollars3.Text = "Devise: " + "GBP";
                    devise = valeurPicker;
                    titelPicker = "£";
                }
                else if (valeurPicker == "￥" && titelPicker == "$")
                {
                    changDevisesOriginDollars(valeurPicker, devisesCny);
                    //dollars3.Text = "Devise: " + "CNY";
                    devise = valeurPicker;
                    titelPicker = "￥";
                }
                else if (valeurPicker == "$A" && titelPicker == "$")
                {
                    changDevisesOriginDollars(valeurPicker, devisesAUD);
                    //dollars3.Text = "Devise: " + "AUD";
                    devise = valeurPicker;
                    titelPicker = "$A";
                }
                else if (valeurPicker == "FrS" && titelPicker == "$")
                {
                    changDevisesOriginDollars(valeurPicker, devisesCHF);
                    //dollars3.Text = "Devise: " + "CHF";
                    devise = valeurPicker;
                    titelPicker = "FrS";
                }

                else if (valeurPicker == "kr" && titelPicker == "$")
                {
                    changDevisesOriginDollars(valeurPicker, devisesSEK);
                    //dollars3.Text = "Devise: " + "SEK";
                    devise = valeurPicker;
                    titelPicker = "kr";
                }
                else if (valeurPicker == "JP¥" && titelPicker == "$")
                {
                    changDevisesOriginDollars(valeurPicker, devisesJPY);
                    //dollars3.Text = "Devise: " + "JPY";
                    devise = valeurPicker;
                    titelPicker = "JP¥";
                }
                else if (valeurPicker == "$N" && titelPicker == "$")
                {
                    changDevisesOriginDollars(valeurPicker, devisesNZD);
                    //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$N";
                }


                else if (valeurPicker == "€" && titelPicker == "$C")
                {
                    changDevisesOriginDollarsCan(valeurPicker, deviseEuros);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "€";
                }
                else if (valeurPicker == "$" && titelPicker == "$C")
                {
                    changDevisesOriginDollarsCan(valeurPicker, devisesDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$";
                }
                else if (valeurPicker == "$C" && titelPicker == "$C")
                {
                    changDevisesOriginDollarsCan(valeurPicker, deviseCanadaDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$C";

                }
                else if (valeurPicker == "£" && titelPicker == "$C")
                {
                    changDevisesOriginDollars(valeurPicker, devisesGbp);
                    //dollars3.Text = "Devise: " + "GBP";
                    devise = valeurPicker;
                    titelPicker = "£";
                }
                else if (valeurPicker == "￥" && titelPicker == "$C")
                {
                    changDevisesOriginDollarsCan(valeurPicker, devisesCny);
                    //dollars3.Text = "Devise: " + "CNY";
                    devise = valeurPicker;
                    titelPicker = "￥";
                }

                else if (valeurPicker == "$A" && titelPicker == "$C")
                {
                    changDevisesOriginDollarsCan(valeurPicker, devisesAUD);
                    //dollars3.Text = "Devise: " + "AUD";
                    devise = valeurPicker;
                    titelPicker = "$A";
                }
                else if (valeurPicker == "FrS" && titelPicker == "$C")
                {
                    changDevisesOriginDollarsCan(valeurPicker, devisesCHF);
                    //dollars3.Text = "Devise: " + "CHF";
                    devise = valeurPicker;
                    titelPicker = "FrS";
                }

                else if (valeurPicker == "kr" && titelPicker == "$C")
                {
                    changDevisesOriginDollarsCan(valeurPicker, devisesSEK);
                    //dollars3.Text = "Devise: " + "SEK";
                    devise = valeurPicker;
                    titelPicker = "kr";
                }
                else if (valeurPicker == "JP¥" && titelPicker == "$C")
                {
                    changDevisesOriginDollarsCan(valeurPicker, devisesJPY);
                    //dollars3.Text = "Devise: " + "JPY";
                    devise = valeurPicker;
                    titelPicker = "JP¥";
                }
                else if (valeurPicker == "$N" && titelPicker == "$C")
                {
                    changDevisesOriginDollarsCan(valeurPicker, devisesNZD);
                    //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$N";
                }









                else if (valeurPicker == "€" && titelPicker == "￥")
                {
                    changDevisesOriginYuan(valeurPicker, deviseEuros);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "€";
                }
                else if (valeurPicker == "$" && titelPicker == "￥")
                {
                    changDevisesOriginYuan(valeurPicker, devisesDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$";
                }
                else if (valeurPicker == "$C" && titelPicker == "￥")
                {
                    changDevisesOriginYuan(valeurPicker, deviseCanadaDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$C";
                }
                else if (valeurPicker == "£" && titelPicker == "￥")
                {
                    changDevisesOriginYuan(valeurPicker, devisesGbp);
                    //dollars3.Text = "Devise: " + "GBP";
                    devise = valeurPicker;
                    titelPicker = "£";
                }
                else if (valeurPicker == "￥" && titelPicker == "￥")
                {
                    changDevisesOriginYuan(valeurPicker, devisesCny);
                    //dollars3.Text = "Devise: " + "CNY";
                    devise = valeurPicker;
                    titelPicker = "￥";
                }

                else if (valeurPicker == "$A" && titelPicker == "￥")
                {
                    changDevisesOriginYuan(valeurPicker, devisesAUD);
                    //dollars3.Text = "Devise: " + "AUD";
                    devise = valeurPicker;
                    titelPicker = "$A";
                }
                else if (valeurPicker == "FrS" && titelPicker == "￥")
                {
                    changDevisesOriginYuan(valeurPicker, devisesCHF);
                    //dollars3.Text = "Devise: " + "CHF";
                    devise = valeurPicker;
                    titelPicker = "FrS";
                }

                else if (valeurPicker == "kr" && titelPicker == "￥")
                {
                    changDevisesOriginYuan(valeurPicker, devisesSEK);
                    //dollars3.Text = "Devise: " + "SEK";
                    devise = valeurPicker;
                    titelPicker = "kr";
                }
                else if (valeurPicker == "JP¥" && titelPicker == "￥")
                {
                    changDevisesOriginYuan(valeurPicker, devisesJPY);
                    //dollars3.Text = "Devise: " + "JPY";
                    devise = valeurPicker;
                    titelPicker = "JP¥";
                }
                else if (valeurPicker == "$N" && titelPicker == "￥")
                {
                    changDevisesOriginYuan(valeurPicker, devisesNZD);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$N";
                }






                else if (valeurPicker == "€" && titelPicker == "£")
                {
                    changDevisesOriginGBP(valeurPicker, deviseEuros);
                      //  //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "€";
                }
                else if (valeurPicker == "$" && titelPicker == "£")
                {
                    changDevisesOriginGBP(valeurPicker, devisesDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$";
                }
                else if (valeurPicker == "$C" && titelPicker == "£")
                {
                    changDevisesOriginGBP(valeurPicker, deviseCanadaDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$C";
                }
                else if (valeurPicker == "￥" && titelPicker == "£")
                {
                    changDevisesOriginGBP(valeurPicker, devisesCny);
                    //dollars3.Text = "Devise: " + "CNY";
                    devise = valeurPicker;
                    titelPicker = "￥";
                }
                else if (valeurPicker == "£" && titelPicker == "£")
                {
                    changDevisesOriginGBP(valeurPicker, devisesGbp);
                    //dollars3.Text = "Devise: " + "GBP";
                    devise = valeurPicker;
                    titelPicker = "£";
                }
                else if (valeurPicker == "$A" && titelPicker == "£")
                {
                    changDevisesOriginGBP(valeurPicker, devisesAUD);
                    //dollars3.Text = "Devise: " + "AUD";
                    devise = valeurPicker;
                    titelPicker = "$A";
                }
                else if (valeurPicker == "FrS" && titelPicker == "£")
                {
                    changDevisesOriginGBP(valeurPicker, devisesCHF);
                    //dollars3.Text = "Devise: " + "CHF";
                    devise = valeurPicker;
                    titelPicker = "FrS";
                }

                else if (valeurPicker == "kr" && titelPicker == "£")
                {
                    changDevisesOriginGBP(valeurPicker, devisesSEK);
                    //dollars3.Text = "Devise: " + "SEK";
                    devise = valeurPicker;
                    titelPicker = "kr";
                }
                else if (valeurPicker == "JP¥" && titelPicker == "£")
                {
                    changDevisesOriginGBP(valeurPicker, devisesJPY);
                    //dollars3.Text = "Devise: " + "JPY";
                    devise = valeurPicker;
                    titelPicker = "JP¥";
                }
                else if (valeurPicker == "$N" && titelPicker == "£")
                {
                    changDevisesOriginGBP(valeurPicker, devisesNZD);
                    //  //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$N";
                }





                else if (valeurPicker == "€" && titelPicker == "$A")
                {
                    changDevisesOriginAUD(valeurPicker, deviseEuros);
                      //  //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "€";
                }
                else if (valeurPicker == "$" && titelPicker == "$A")
                {
                    changDevisesOriginAUD(valeurPicker, devisesDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$";
                }
                else if (valeurPicker == "$C" && titelPicker == "$A")
                {
                    changDevisesOriginAUD(valeurPicker, deviseCanadaDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$C";
                }
                else if (valeurPicker == "￥" && titelPicker == "$A")
                {
                    changDevisesOriginAUD(valeurPicker, devisesCny);
                    //dollars3.Text = "Devise: " + "CNY";
                    devise = valeurPicker;
                    titelPicker = "￥";
                }
                else if (valeurPicker == "£" && titelPicker == "$A")
                {
                    changDevisesOriginAUD(valeurPicker, devisesGbp);
                    //dollars3.Text = "Devise: " + "GBP";
                    devise = valeurPicker;
                    titelPicker = "£";
                }
                else if (valeurPicker == "$A" && titelPicker == "$A")
                {
                    changDevisesOriginAUD(valeurPicker, devisesAUD);
                    //dollars3.Text = "Devise: " + "AUD";
                    devise = valeurPicker;
                    titelPicker = "$A";
                }
                else if (valeurPicker == "FrS" && titelPicker == "$A")
                {
                    changDevisesOriginAUD(valeurPicker, devisesCHF);
                    //dollars3.Text = "Devise: " + "CHF";
                    devise = valeurPicker;
                    titelPicker = "FrS";
                }

                else if (valeurPicker == "kr" && titelPicker == "$A")
                {
                    changDevisesOriginAUD(valeurPicker, devisesSEK);
                    //dollars3.Text = "Devise: " + "SEK";
                    devise = valeurPicker;
                    titelPicker = "kr";
                }
                else if (valeurPicker == "JP¥" && titelPicker == "$A")
                {
                    changDevisesOriginAUD(valeurPicker, devisesJPY);
                    //dollars3.Text = "Devise: " + "JPY";
                    devise = valeurPicker;
                    titelPicker = "JP¥";
                }
                else if (valeurPicker == "$N" && titelPicker == "$A")
                {
                    changDevisesOriginAUD(valeurPicker, devisesNZD);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$N";
                }






                else if (valeurPicker == "€" && titelPicker == "FrS")
                {
                    changDevisesOriginCHF(valeurPicker, deviseEuros);
                      //  //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "€";
                }
                else if (valeurPicker == "$" && titelPicker == "FrS")
                {
                    changDevisesOriginCHF(valeurPicker, devisesDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$";
                }
                else if (valeurPicker == "$C" && titelPicker == "FrS")
                {
                    changDevisesOriginCHF(valeurPicker, deviseCanadaDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$C";
                }
                else if (valeurPicker == "￥" && titelPicker == "FrS")
                {
                    changDevisesOriginCHF(valeurPicker, devisesCny);
                    //dollars3.Text = "Devise: " + "CNY";
                    devise = valeurPicker;
                    titelPicker = "￥";
                }
                else if (valeurPicker == "£" && titelPicker == "FrS")
                {
                    changDevisesOriginCHF(valeurPicker, devisesGbp);
                    //dollars3.Text = "Devise: " + "GBP";
                    devise = valeurPicker;
                    titelPicker = "£";
                }
                else if (valeurPicker == "$A" && titelPicker == "FrS")
                {
                    changDevisesOriginCHF(valeurPicker, devisesAUD);
                    //dollars3.Text = "Devise: " + "AUD";
                    devise = valeurPicker;
                    titelPicker = "$A";
                }
                else if (valeurPicker == "FrS" && titelPicker == "FrS")
                {
                    changDevisesOriginCHF(valeurPicker, devisesCHF);
                    //dollars3.Text = "Devise: " + "CHF";
                    devise = valeurPicker;
                    titelPicker = "FrS";
                }

                else if (valeurPicker == "kr" && titelPicker == "FrS")
                {
                    changDevisesOriginCHF(valeurPicker, devisesSEK);
                    //dollars3.Text = "Devise: " + "SEK";
                    devise = valeurPicker;
                    titelPicker = "kr";
                }
                else if (valeurPicker == "JP¥" && titelPicker == "FrS")
                {
                    changDevisesOriginCHF(valeurPicker, devisesJPY);
                    //dollars3.Text = "Devise: " + "JPY";
                    devise = valeurPicker;
                    titelPicker = "JP¥";
                }
                else if (valeurPicker == "$N" && titelPicker == "FrS")
                {
                    changDevisesOriginCHF(valeurPicker, devisesNZD);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$N";
                }









                else if (valeurPicker == "€" && titelPicker == "kr")
                {
                    changDevisesOriginSEK(valeurPicker, deviseEuros);
                      //  //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "€";
                }
                else if (valeurPicker == "$" && titelPicker == "kr")
                {
                    changDevisesOriginSEK(valeurPicker, devisesDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$";
                }
                else if (valeurPicker == "$C" && titelPicker == "kr")
                {
                    changDevisesOriginSEK(valeurPicker, deviseCanadaDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$C";
                }
                else if (valeurPicker == "￥" && titelPicker == "kr")
                {
                    changDevisesOriginSEK(valeurPicker, devisesCny);
                    //dollars3.Text = "Devise: " + "CNY";
                    devise = valeurPicker;
                    titelPicker = "￥";
                }
                else if (valeurPicker == "£" && titelPicker == "kr")
                {
                    changDevisesOriginSEK(valeurPicker, devisesGbp);
                    //dollars3.Text = "Devise: " + "GBP";
                    devise = valeurPicker;
                    titelPicker = "£";
                }
                else if (valeurPicker == "$A" && titelPicker == "kr")
                {
                    changDevisesOriginSEK(valeurPicker, devisesAUD);
                    //dollars3.Text = "Devise: " + "AUD";
                    devise = valeurPicker;
                    titelPicker = "$A";
                }
                else if (valeurPicker == "FrS" && titelPicker == "kr")
                {
                    changDevisesOriginSEK(valeurPicker, devisesCHF);
                    //dollars3.Text = "Devise: " + "CHF";
                    devise = valeurPicker;
                    titelPicker = "FrS";
                }
      
                else if (valeurPicker == "kr" && titelPicker == "kr")
                {
                    changDevisesOriginSEK(valeurPicker, devisesSEK);
                    //dollars3.Text = "Devise: " + "SEK";
                    devise = valeurPicker;
                    titelPicker = "kr";
                }
                else if (valeurPicker == "JP¥" && titelPicker == "kr")
                {
                    changDevisesOriginSEK(valeurPicker, devisesJPY);
                    //dollars3.Text = "Devise: " + "JPY";
                    devise = valeurPicker;
                    titelPicker = "JP¥";
                }
                else if (valeurPicker == "$N" && titelPicker == "kr")
                {
                    changDevisesOriginSEK(valeurPicker, devisesNZD);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$N";
                }







                else if (valeurPicker == "€" && titelPicker == "JP¥")
                {
                    changDevisesOriginJPY(valeurPicker, deviseEuros);
                      //  //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "€";
                }
                else if (valeurPicker == "$" && titelPicker == "JP¥")
                {
                    changDevisesOriginJPY(valeurPicker, devisesDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$";
                }
                else if (valeurPicker == "$C" && titelPicker == "JP¥")
                {
                    changDevisesOriginJPY(valeurPicker, deviseCanadaDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$C";
                }
                else if (valeurPicker == "￥" && titelPicker == "JP¥")
                {
                    changDevisesOriginJPY(valeurPicker, devisesCny);
                    //dollars3.Text = "Devise: " + "CNY";
                    devise = valeurPicker;
                    titelPicker = "￥";
                }
                else if (valeurPicker == "£" && titelPicker == "JP¥")
                {
                    changDevisesOriginJPY(valeurPicker, devisesGbp);
                    //dollars3.Text = "Devise: " + "GBP";
                    devise = valeurPicker;
                    titelPicker = "£";
                }
                else if (valeurPicker == "$A" && titelPicker == "JP¥")
                {
                    changDevisesOriginJPY(valeurPicker, devisesAUD);
                    //dollars3.Text = "Devise: " + "AUD";
                    devise = valeurPicker;
                    titelPicker = "$A";
                }
                else if (valeurPicker == "FrS" && titelPicker == "JP¥")
                {
                    changDevisesOriginJPY(valeurPicker, devisesCHF);
                    //dollars3.Text = "Devise: " + "Devise: " + "CHF";
                    devise = valeurPicker;
                    titelPicker = "FrS";
                }
    
                else if (valeurPicker == "kr" && titelPicker == "JP¥")
                {
                    changDevisesOriginJPY(valeurPicker, devisesSEK);
                    //dollars3.Text = "Devise: " + "SEK";
                    devise = valeurPicker;
                    titelPicker = "kr";
                }
                else if (valeurPicker == "JP¥" && titelPicker == "JP¥")
                {
                    changDevisesOriginJPY(valeurPicker, devisesJPY);
                    //dollars3.Text = "Devise: " + "JPY";
                    devise = valeurPicker;
                    titelPicker = "JP¥";
                }
                else if (valeurPicker == "$N" && titelPicker == "JP¥")
                {
                    changDevisesOriginJPY(valeurPicker, devisesNZD);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$N";
                }









                else if (valeurPicker == "€" && titelPicker == "$N")
                {
                    changDevisesOriginNZD(valeurPicker, deviseEuros);
                      //  //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "€";
                }
                else if (valeurPicker == "$" && titelPicker == "$N")
                {
                    changDevisesOriginNZD(valeurPicker, devisesDollars);
                    //dollars3.Text = "Devise: "+"USD";
                    devise = valeurPicker;
                    titelPicker = "$";
                }
                else if (valeurPicker == "$C" && titelPicker == "$N")
                {
                    changDevisesOriginNZD(valeurPicker, deviseCanadaDollars);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$C";
                }
                else if (valeurPicker == "￥" && titelPicker == "$N")
                {
                    changDevisesOriginNZD(valeurPicker, devisesCny);
                    //dollars3.Text = "Devise: " + "CNY";
                    devise = valeurPicker;
                    titelPicker = "￥";
                }
                else if (valeurPicker == "£" && titelPicker == "$N")
                {
                    changDevisesOriginNZD(valeurPicker, devisesGbp);
                    //dollars3.Text = "Devise: " + "GBP";
                    devise = valeurPicker;
                    titelPicker = "£";
                }
                else if (valeurPicker == "$A" && titelPicker == "$N")
                {
                    changDevisesOriginNZD(valeurPicker, devisesAUD);
                    //dollars3.Text = "Devise: " + "AUD";
                    devise = valeurPicker;
                    titelPicker = "$A";
                }
                else if (valeurPicker == "FrS" && titelPicker == "$N")
                {
                    changDevisesOriginNZD(valeurPicker, devisesCHF);
                    //dollars3.Text = "Devise: " + "CHF";
                    devise = valeurPicker;
                    titelPicker = "FrS";
                }
  
                else if (valeurPicker == "kr" && titelPicker == "$N")
                {
                    changDevisesOriginNZD(valeurPicker, devisesSEK);
                    //dollars3.Text = "Devise: " + "SEK";
                    devise = valeurPicker;
                    titelPicker = "kr";
                }
                else if (valeurPicker == "JP¥" && titelPicker == "$N")
                {
                    changDevisesOriginNZD(valeurPicker, devisesJPY);
                    //dollars3.Text = "Devise: " + "JPY";
                    devise = valeurPicker;
                    titelPicker = "JP¥";
                }
                else if (valeurPicker == "$N" && titelPicker == "$N")
                {
                    changDevisesOriginNZD(valeurPicker, devisesNZD);
                      //dollars3.Text = "Devise: " + "NZD";
                    devise = valeurPicker;
                    titelPicker = "$N";
                }

            }



        }
        //private void animation()
        //{
        //    resultaFinal.TranslationX = -250;
        //    resultaFinal.TranslationY = -150;
        //    resultaFinal.Rotation = 45;
        //    resultaFinal.Scale = 0.7;
        //    resultaFinal.Opacity = 0;
        //    uint lenght = 800;
        //    resultaFinal.FadeTo(1, 100);
        //    resultaFinal.TranslateTo(0, 0, lenght, Easing.SinOut);
        //    resultaFinal.RotateTo(0, lenght, Easing.SinOut);
        //    resultaFinal.ScaleTo(1, lenght, Easing.SinOut);
        //}

        void OnPickerSelectedIndexChanged1(object sender, EventArgs e)
        {
            var picker1 = (Picker)sender;
            int selectedIndex = picker1.SelectedIndex;

            if (selectedIndex != -1)
            {
                coeffMultArt = (string)picker1.ItemsSource[selectedIndex];

            }
        }
        void OnPickerSelectedIndexChanged3(object sender, EventArgs e)
        {
            var picker2 = (Picker)sender;
            int selectedIndex = picker2.SelectedIndex;

            if (selectedIndex != -1)
            {

                Pourcentage = (string)picker2.ItemsSource[selectedIndex];

            }
        }
   



        private async void FinalButtonClick(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(prixFournisseur.Text))
            {
                await DisplayAlert("Ooops", "vous devez rentrer un prix fournisseur", "Ok");
                return;
            }
            if (string.IsNullOrWhiteSpace(coeffMultArt))
            {
                await DisplayAlert("Ooops", "vous devez rentrer un coefficient ", "Ok");
                return;
            }
            string prixFourn = prixFournisseur.Text;
            double coeffFinal = double.Parse(coeffMultArt);
            //prixAchat.Text = "prix d'achat: "+prixFourn;
            //Marge1.Text = "prix d'achat: " + prixFourn;
            //tauxMarque1.Text = "prix d'achat: " + prixFourn;
            //tauxMarge1.Text = "prix d'achat: " + prixFourn;
            coeff0.Text = coeffMultArt;
            coeff1.Text = coeffMultArt;
            coeff2.Text = coeffMultArt;
            coeff3.Text = coeffMultArt;
            coeff4.Text = coeffMultArt;
            prixFournisseurFinal = double.Parse(prixFourn);
            prixFinalDe = prixFournisseurFinal * coeffFinal;
            prixFinal.Text = prixFinalDe.ToString(".00") + devise;
            marge.Text = (prixFinalDe - prixFournisseurFinal).ToString(".00") + devise;
            tauxMarge.Text = (((prixFinalDe - prixFournisseurFinal) / prixFournisseurFinal) * 100).ToString(".00") + " %";
            tauxMarque.Text = (((prixFinalDe - prixFournisseurFinal) / prixFinalDe) * 100).ToString(".00") + " %";
            //animation();
        }

        public void changDevisesEuros(string devise, double coeffDevise)
        {
            prixFournisseurFinal = prixFournisseurFinal * coeffDevise;
            prixFinalDe = prixFinalDe * coeffDevise;
            prixFinal.Text = prixFinalDe.ToString(".00") + devise;
            if (prixFournisseurFinal==0)
            {
                prixFournisseur1.Text = "";
            }
            else { prixFournisseur1.Text = prixFournisseurFinal.ToString(".00"); }
          
            marge.Text = (prixFinalDe - prixFournisseurFinal).ToString(".00") + devise;
            //animation();

        }
        public void changDevisesOriginDollars(string devise, double coeffDevise)
        {
            prixFournisseurFinal = (prixFournisseurFinal / devisesDollars) * coeffDevise;
            prixFinalDe = (prixFinalDe / devisesDollars) * coeffDevise;
            prixFinal.Text = prixFinalDe.ToString(".00") + devise;
            if (prixFournisseurFinal == 0)
            {
                prixFournisseur1.Text = "";
            }
            else { prixFournisseur1.Text = prixFournisseurFinal.ToString(".00"); }
            marge.Text = (prixFinalDe - prixFournisseurFinal).ToString(".00") + devise;
            //animation();

        }
        public void changDevisesOriginDollarsCan(string devise, double coeffDevise)
        {
            prixFournisseurFinal = (prixFournisseurFinal / deviseCanadaDollars) * coeffDevise;
            prixFinalDe = (prixFinalDe / deviseCanadaDollars) * coeffDevise;
            if (prixFournisseurFinal == 0)
            {
                prixFournisseur1.Text = "";
            }
            else { prixFournisseur1.Text = prixFournisseurFinal.ToString(".00"); }
            prixFinal.Text = prixFinalDe.ToString(".00") + devise;
            marge.Text = (prixFinalDe - prixFournisseurFinal).ToString(".00") + devise;
            //animation();

        }
        public void changDevisesOriginYuan(string devise, double coeffDevise)
        {
            prixFournisseurFinal = (prixFournisseurFinal / devisesCny) * coeffDevise;
            prixFinalDe = (prixFinalDe / devisesCny) * coeffDevise;
            if (prixFournisseurFinal == 0)
            {
                prixFournisseur1.Text = "";
            }
            else { prixFournisseur1.Text = prixFournisseurFinal.ToString(".00"); }
            prixFinal.Text = prixFinalDe.ToString(".00") + devise;
            marge.Text = (prixFinalDe - prixFournisseurFinal).ToString(".00") + devise;
            //animation();

        }










        public void changDevisesOriginGBP(string devise, double coeffDevise)
        {
            prixFournisseurFinal = (prixFournisseurFinal / devisesGbp) * coeffDevise;
            prixFinalDe = (prixFinalDe / devisesGbp) * coeffDevise;
            if (prixFournisseurFinal == 0)
            {
                prixFournisseur1.Text = "";
            }
            else { prixFournisseur1.Text = prixFournisseurFinal.ToString(".00"); }
            prixFinal.Text = prixFinalDe.ToString(".00") + devise;
            marge.Text = (prixFinalDe - prixFournisseurFinal).ToString(".00") + devise;
            //animation();

        }


        public void changDevisesOriginAUD(string devise, double coeffDevise)
        {
            prixFournisseurFinal = (prixFournisseurFinal / devisesAUD) * coeffDevise;
            prixFinalDe = (prixFinalDe / devisesAUD) * coeffDevise;
            if (prixFournisseurFinal == 0)
            {
                prixFournisseur1.Text = "";
            }
            else { prixFournisseur1.Text = prixFournisseurFinal.ToString(".00"); }
            prixFinal.Text = prixFinalDe.ToString(".00") + devise;
            marge.Text = (prixFinalDe - prixFournisseurFinal).ToString(".00") + devise;
            //animation();

        }
        public void changDevisesOriginCHF(string devise, double coeffDevise)
        {
            prixFournisseurFinal = (prixFournisseurFinal / devisesCHF) * coeffDevise;
            prixFinalDe = (prixFinalDe / devisesCHF) * coeffDevise;
            if (prixFournisseurFinal == 0)
            {
                prixFournisseur1.Text = "";
            }
            else { prixFournisseur1.Text = prixFournisseurFinal.ToString(".00"); }
            prixFinal.Text = prixFinalDe.ToString(".00") + devise;
            marge.Text = (prixFinalDe - prixFournisseurFinal).ToString(".00") + devise;
            //animation();

        }


        public void changDevisesOriginJPY(string devise, double coeffDevise)
        {
            prixFournisseurFinal = (prixFournisseurFinal / devisesJPY) * coeffDevise;
            prixFinalDe = (prixFinalDe / devisesJPY) * coeffDevise;
            if (prixFournisseurFinal == 0)
            {
                prixFournisseur1.Text = "";
            }
            else { prixFournisseur1.Text = prixFournisseurFinal.ToString(".00"); }
            prixFinal.Text = prixFinalDe.ToString(".00") + devise;
            marge.Text = (prixFinalDe - prixFournisseurFinal).ToString(".00") + devise;
            //animation();

        }

        public void changDevisesOriginSEK(string devise, double coeffDevise)
        {
            prixFournisseurFinal = (prixFournisseurFinal / devisesSEK) * coeffDevise;
            prixFinalDe = (prixFinalDe / devisesSEK) * coeffDevise;
            if (prixFournisseurFinal == 0)
            {
                prixFournisseur1.Text = "";
            }
            else { prixFournisseur1.Text = prixFournisseurFinal.ToString(".00"); }
            prixFinal.Text = prixFinalDe.ToString(".00") + devise;
            marge.Text = (prixFinalDe - prixFournisseurFinal).ToString(".00") + devise;
            //animation();

        }

        public void changDevisesOriginNZD(string devise, double coeffDevise)
        {
            prixFournisseurFinal = (prixFournisseurFinal / devisesNZD) * coeffDevise;
            prixFinalDe = (prixFinalDe / devisesNZD) * coeffDevise;
            if (prixFournisseurFinal == 0)
            {
                prixFournisseur1.Text = "";
            }
            else { prixFournisseur1.Text = prixFournisseurFinal.ToString(".00"); }
            prixFinal.Text = prixFinalDe.ToString(".00") + devise;
            marge.Text = (prixFinalDe - prixFournisseurFinal).ToString(".00") + devise;
            //animation();

        }

        void WheelPicker_SelectedItemIndexChanged(System.Object sender, Vapolia.WheelPickerCore.WheelChangedEventArgs e)
        {
            var pickerTest = (Picker)sender;
            int selectedIndex = pickerTest.SelectedIndex;

            if (selectedIndex != -1)
            {

               var Pourcentage = (string)pickerTest.ItemsSource[selectedIndex];

                DisplayAlert("Ooops", Pourcentage, "Ok");
            }
            
        }


     
    }

}




public class MainPageModel
{
    public List<string> Days { get; } = new List<string>
    {
        "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday",
    };

    public Command ItemSelectedCommand { get; }

    public MainPageModel()
    {
        ItemSelectedCommand = new Command<(int, int, IList<int>)>(tuple =>
        {
            var (selectedWheelIndex, indexOfItemChangedInSelectedWheel, selectedItemsIndexes) = tuple;
            //...
        });
    }
}