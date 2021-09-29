using System;
using System.Collections.Generic;
using System.Net;
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
        string URL;
        string Key;
        double prixFournisseurFinal;
        double prixFinalDe = 0;
        string devise;
        string coeffMultArt;
        deviseClass Devises = new deviseClass();
        public Calculator()
        {
            InitializeComponent();
            dollars3.Text = "€";
            titelPicker = "€";
            url = "http://data.fixer.io/api/latest";
            Key = "9a66f3ad73018c9ac9308ebbfc882899";
            devise = "€";
            accesKey = "?access_key=" + Key;
            URL = url + accesKey;
            var Webclient = new WebClient();
            var json = Webclient.DownloadString(URL);
            Devises = JsonConvert.DeserializeObject<deviseClass>(json);
            devisesDollars = Devises.Rates["USD"];
            deviseEuros = Devises.Rates["EUR"];
            deviseCanadaDollars = Devises.Rates["CAD"];
            devisesCny = Devises.Rates["CNY"];
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
                    dollars3.Text = valeurPicker;
                    devise = valeurPicker;
                    titelPicker = "€";
                }
                else if (valeurPicker == "$" && titelPicker == "€")
                {
                    changDevisesEuros(valeurPicker, devisesDollars);
                    dollars3.Text = valeurPicker;
                    devise = valeurPicker;
                    titelPicker = "$";
                }
                else if (valeurPicker == "$C" && titelPicker == "€")
                {
                    changDevisesEuros(valeurPicker, deviseCanadaDollars);
                    dollars3.Text = valeurPicker;
                    devise = valeurPicker;
                    titelPicker = "$C";
                }
                else if (valeurPicker == "￥" && titelPicker == "€")
                {
                    changDevisesEuros(valeurPicker, devisesCny);
                    dollars3.Text = valeurPicker;
                    devise = valeurPicker;
                    titelPicker = "￥";
                }
                else if (valeurPicker == "€" && titelPicker == "$")
                {
                    changDevisesOriginDollars(valeurPicker, deviseEuros);
                    dollars3.Text = valeurPicker;
                    devise = valeurPicker;
                    titelPicker = "€";
                }
                else if (valeurPicker == "$" && titelPicker == "$")
                {
                    changDevisesOriginDollars(valeurPicker, devisesDollars);
                    dollars3.Text = valeurPicker;
                    devise = valeurPicker;
                    titelPicker = "$";
                }
                else if (valeurPicker == "$C" && titelPicker == "$")
                {
                    changDevisesOriginDollars(valeurPicker, deviseCanadaDollars);
                    dollars3.Text = valeurPicker;
                    devise = valeurPicker;
                    titelPicker = "$C";
                }
                else if (valeurPicker == "￥" && titelPicker == "$")
                {
                    changDevisesOriginDollars(valeurPicker, devisesCny);
                    dollars3.Text = valeurPicker;
                    devise = valeurPicker;
                    titelPicker = "￥";
                }
                else if (valeurPicker == "€" && titelPicker == "$C")
                {
                    changDevisesOriginDollarsCan(valeurPicker, deviseEuros);
                    dollars3.Text = valeurPicker;
                    devise = valeurPicker;
                    titelPicker = "€";
                }
                else if (valeurPicker == "$" && titelPicker == "$C")
                {
                    changDevisesOriginDollarsCan(valeurPicker, devisesDollars);
                    dollars3.Text = valeurPicker;
                    devise = valeurPicker;
                    titelPicker = "$";
                }
                else if (valeurPicker == "$C" && titelPicker == "$C")
                {
                    changDevisesOriginDollarsCan(valeurPicker, deviseCanadaDollars);
                    dollars3.Text = valeurPicker;
                    devise = valeurPicker;
                    titelPicker = "$C";

                }
                else if (valeurPicker == "￥" && titelPicker == "$C")
                {
                    changDevisesOriginDollarsCan(valeurPicker, devisesCny);
                    dollars3.Text = valeurPicker;
                    devise = valeurPicker;
                    titelPicker = "￥";
                }
                else if (valeurPicker == "€" && titelPicker == "￥")
                {
                    changDevisesOriginYuan(valeurPicker, deviseEuros);
                    dollars3.Text = valeurPicker;
                    devise = valeurPicker;
                    titelPicker = "€";
                }
                else if (valeurPicker == "$" && titelPicker == "￥")
                {
                    changDevisesOriginYuan(valeurPicker, devisesDollars);
                    dollars3.Text = valeurPicker;
                    devise = valeurPicker;
                    titelPicker = "$";
                }
                else if (valeurPicker == "$C" && titelPicker == "￥")
                {
                    changDevisesOriginYuan(valeurPicker, deviseCanadaDollars);
                    dollars3.Text = valeurPicker;
                    devise = valeurPicker;
                    titelPicker = "$C";
                }
                else if (valeurPicker == "￥" && titelPicker == "￥")
                {
                    changDevisesOriginYuan(valeurPicker, devisesCny);
                    dollars3.Text = valeurPicker;
                    devise = valeurPicker;
                    titelPicker = "￥";
                }
            }



        }
        private void animation()
        {
            resultaFinal.TranslationX = -250;
            resultaFinal.TranslationY = -150;
            resultaFinal.Rotation = 45;
            resultaFinal.Scale = 0.7;
            resultaFinal.Opacity = 0;
            uint lenght = 800;
            resultaFinal.FadeTo(1, 100);
            resultaFinal.TranslateTo(0, 0, lenght, Easing.SinOut);
            resultaFinal.RotateTo(0, lenght, Easing.SinOut);
            resultaFinal.ScaleTo(1, lenght, Easing.SinOut);
        }

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
        //private void AnimationView2_OnClick(object sender, System.EventArgs e)
        //{
        //    //NewProduitPage.coeffcientCalculer = double.Parse(coeffMultArt);
        //    Navigation.PopAsync(true);
        //}
        //private void AnimationClickedCommand5(object sender, System.EventArgs e)
        //{
        //    Navigation.PopAsync(true);

        //}



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
            prixFournisseurFinal = double.Parse(prixFourn);
            prixFinalDe = prixFournisseurFinal * coeffFinal;
            prixFinal.Text = prixFinalDe.ToString(".00") + devise;
            marge.Text = (prixFinalDe - prixFournisseurFinal).ToString(".00") + devise;
            tauxMarge.Text = (((prixFinalDe - prixFournisseurFinal) / prixFournisseurFinal) * 100).ToString(".00") + " %";
            tauxMarque.Text = (((prixFinalDe - prixFournisseurFinal) / prixFinalDe) * 100).ToString(".00") + " %";
            animation();
        }

        public void changDevisesEuros(string devise, double coeffDevise)
        {
            prixFournisseurFinal = prixFournisseurFinal * coeffDevise;
            prixFinalDe = prixFinalDe * coeffDevise;
            prixFinal.Text = prixFinalDe.ToString(".00") + devise;
            prixFournisseur.Text = prixFournisseurFinal.ToString(".00");
            marge.Text = (prixFinalDe - prixFournisseurFinal).ToString(".00") + devise;
            animation();

        }
        public void changDevisesOriginDollars(string devise, double coeffDevise)
        {
            prixFournisseurFinal = (prixFournisseurFinal / devisesDollars) * coeffDevise;
            prixFinalDe = (prixFinalDe / devisesDollars) * coeffDevise;
            prixFinal.Text = prixFinalDe.ToString(".00") + devise;
            prixFournisseur.Text = prixFournisseurFinal.ToString(".00");
            marge.Text = (prixFinalDe - prixFournisseurFinal).ToString(".00") + devise;
            animation();

        }
        public void changDevisesOriginDollarsCan(string devise, double coeffDevise)
        {
            prixFournisseurFinal = (prixFournisseurFinal / deviseCanadaDollars) * coeffDevise;
            prixFinalDe = (prixFinalDe / deviseCanadaDollars) * coeffDevise;
            prixFournisseur.Text = prixFournisseurFinal.ToString(".00");
            prixFinal.Text = prixFinalDe.ToString(".00") + devise;
            marge.Text = (prixFinalDe - prixFournisseurFinal).ToString(".00") + devise;
            animation();

        }
        public void changDevisesOriginYuan(string devise, double coeffDevise)
        {
            prixFournisseurFinal = (prixFournisseurFinal / devisesCny) * coeffDevise;
            prixFinalDe = (prixFinalDe / devisesCny) * coeffDevise;
            prixFournisseur.Text = prixFournisseurFinal.ToString(".00");
            prixFinal.Text = prixFinalDe.ToString(".00") + devise;
            marge.Text = (prixFinalDe - prixFournisseurFinal).ToString(".00") + devise;
            animation();

        }

    }

}
