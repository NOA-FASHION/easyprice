using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;

namespace easyprice
{
    public partial class Simulator : ContentPage
    {
        string Pourcentage;
        //string titelPicker;
        //string accesKey;
        //string url;
        //double devisesDollars;
        //double deviseEuros;
        //double deviseCanadaDollars;
        //double devisesCny;
        //string URL;
        //string Key;
        //double prixFournisseurFinal;
        //double prixFinalDe = 0;
        //string devise;
        string coeffMultArt;
        //deviseClass Devises = new deviseClass();
        
            ObservableCollection<ChartEntry> entries3;
            ObservableCollection<ChartEntry> entries4;
            string ValeurStockHorsFrais = "0";
        float NoteDeFrais;
            float ValeurStockTotal = 0;
            //string coeffMultArt1;
            //string Pourcentage1;
            bool avecPourcentage;
            float tauxDeMarque = 0;
            float tauxDeMarge = 0;
            //string imageUrl;
            //int NumCommande2;
            float fraisDePort1;
            //string NumCollection;
            float valeurStockHorsFrais2;
            string EntryButtonCout = " ";
            float entryFraisDePort;
            float microshartFraisDePort;
            float budgetCollection = 0;
            bool coefficentOk;
            //string resultLabel;
            float budgetCollection1;
        //FirebaseClient firebase = new FirebaseClient("https://fir-01-7395c.firebaseio.com");
        //public System.Collections.ObjectModel.ObservableCollection<photoUrlClass> photoUrlListes1 = new ObservableCollection<photoUrlClass>();

        public Simulator()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

            fraisDePort1 = 0;
            //pourcentageOk = false;
            entryFraisDePort = 0;
            coefficentOk = false;
            
            isvisible6.IsVisible = false;
            valeurStockTotal.Text = "Valeur du";
            valeurStockTotalLabel.Text = "Chiffre d'affaire";
            valeurStockHorsFrais1.Text = "Valeur ";
            valeurStockHorsFrais.Text = "Marge";
            valeurStockTotalLayout1.BackgroundColor = Color.FromHex("#AAD0E1");
            valeurStockTotalFrame.BackgroundColor = Color.FromHex("#AAD0E1");
            valeurStockHorsFraisLayout1.BackgroundColor = Color.FromHex("#AAD0E1");
            valeurStockHorsFraisFrame.BackgroundColor = Color.FromHex("#AAD0E1");
            avecPourcentage = false;
          
        }
     
        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            if (includeSwitch.IsToggled)
            {
                EntryFraisDePort.IsVisible = false;
                picker2.IsVisible = true;
                TotalFraisDePort.IsVisible = true;
                avecPourcentage = true;
            }
            else
            {
                picker2.IsVisible = false;
                TotalFraisDePort.IsVisible = false;
                EntryFraisDePort.IsVisible = true;
                avecPourcentage = false;
            }
        }
      

        void OnPickerSelectedIndexChanged1(object sender, EventArgs e)
        {
            var picker1 = (Picker)sender;
            int selectedIndex = picker1.SelectedIndex;

            if (selectedIndex != -1)
            {
                coeffMultArt = (string)picker1.ItemsSource[selectedIndex];
                coefficentOk = true;
            }
        }

        void OnPickerSelectedIndexChanged2(object sender, EventArgs e)
        {
            var picker2 = (Picker)sender;
            int selectedIndex = picker2.SelectedIndex;

            if (selectedIndex != -1)
            {
                //pourcentageOk = true;
                Pourcentage = (string)picker2.ItemsSource[selectedIndex];
                EntryButtonCout = EntryCoutcollecion.Text;
                fraisDePort1 = (int.Parse(EntryButtonCout) * (int.Parse(Pourcentage))) / 100;
                TotalFraisDePort.Text = fraisDePort1.ToString();
            }
        }


        public void CreateData3()
        {
            entries3 = new ObservableCollection<ChartEntry>
     {
    new ChartEntry(float.Parse(ValeurStockHorsFrais))
     {TextColor=SKColor.Parse("#00FF00"),
    ValueLabelColor=SKColor.Parse("#00FF00"),
    Label = "Marge",
     ValueLabel = "",
    Color = SKColor.Parse("#00FF00")
    },
    new ChartEntry(microshartFraisDePort)
      {TextColor=SKColor.Parse("#68B9C0"),
    ValueLabelColor=SKColor.Parse("#68B9C0"),
    Label = "Port",
     ValueLabel = "",
    Color = SKColor.Parse("#68B9C0")
    },
    new ChartEntry(NoteDeFrais)
    {TextColor=SKColor.Parse("#03224C"),
    ValueLabelColor=SKColor.Parse("#03224C"),
    Label = "Frais",
     ValueLabel = "",
    Color = SKColor.Parse("#03224C")
    },
    new ChartEntry(float.Parse(EntryButtonCout))
    {TextColor=SKColor.Parse("#FF0000"),
    ValueLabelColor=SKColor.Parse("#FF0000"),
    Label = "articles",
     ValueLabel = "",
    Color = SKColor.Parse("#FF0000")
      }
    };
        }
        public void CreateData4()
        {
            entries4 = new ObservableCollection<ChartEntry>
      {
    new ChartEntry(tauxDeMarge)
      {TextColor=SKColor.Parse("#266489"),
    ValueLabelColor=SKColor.Parse("#266489"),
        Label = "Marge",
        ValueLabel = tauxDeMarge.ToString(".0")+ "%",
    Color = SKColor.Parse("#266489")
      },
     new ChartEntry(tauxDeMarque)
     {TextColor=SKColor.Parse("#AAD0E1"),
    ValueLabelColor=SKColor.Parse("#AAD0E1"),
        Label = "Marque",
        ValueLabel = tauxDeMarque.ToString(".0")+ "%",
    Color = SKColor.Parse("#AAD0E1")
      },

     };
        }

        public async void SimulerrCollection1ButtonClicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntryCoutcollecion.Text))
            {
                await DisplayAlert("Ooops", "vous devez rentrer un montant d'achat pour la marchandise", "Ok");
                return;
            }

            if (coefficentOk == false)
            {
                await DisplayAlert("Ooops", "Vous devez choisir un coefficient de vente", "Ok");
                return;
            }
            if (string.IsNullOrWhiteSpace(EntryNoteDeFrais.Text))
            {
                await DisplayAlert("Ooops", "vous devez rentrer un montant pour les frais divers", "Ok");
                return;
            }
            //string entryFraisDePortString = EntryFraisDePort.Text.Replace("€", "").Trim();

            entryFraisDePort = float.Parse(EntryFraisDePort.Text.Replace("€", "").Trim());
            EntryButtonCout = EntryCoutcollecion.Text.Replace("€", "").Trim();
            NoteDeFrais = float.Parse(EntryNoteDeFrais.Text.Replace("€", "").Trim());
           

            ValeurStockTotal = float.Parse(EntryButtonCout) * float.Parse(coeffMultArt);
            budgetCollection = float.Parse(EntryButtonCout) + NoteDeFrais + fraisDePort1;
            budgetCollection1 = float.Parse(EntryButtonCout) + NoteDeFrais + entryFraisDePort;
         
            if (string.IsNullOrWhiteSpace(EntryFraisDePort.Text))
            {
                await DisplayAlert("Ooops", "vous devez rentrer un montant pour les frais divers", "Ok");
                return;
            }
            if (fraisDePort1 == 0 && avecPourcentage == true)

            {
                await DisplayAlert("Ooops", "Vous devez choisir le pourcentage de frais de port", "Ok");
                return;
            }

            if (avecPourcentage == true)
            {
                //BudgetCollectionArticleLable.Text = budgetCollection.ToString();
                valeurStockHorsFrais2 = ValeurStockTotal - budgetCollection;
                ValeurStockHorsFrais = valeurStockHorsFrais2.ToString();
                microshartFraisDePort = fraisDePort1;
                tauxDeMarque = ((ValeurStockTotal - budgetCollection) / ValeurStockTotal) * 100;
                tauxDeMarge = ((ValeurStockTotal - budgetCollection) / budgetCollection) * 100;
            }
            else
            {
                //BudgetCollectionArticleLable.Text = budgetCollection1.ToString();
                valeurStockHorsFrais2 = ValeurStockTotal - budgetCollection1;
                ValeurStockHorsFrais = valeurStockHorsFrais2.ToString();
                microshartFraisDePort = entryFraisDePort;
                tauxDeMarque = ((ValeurStockTotal - budgetCollection1) / ValeurStockTotal) * 100;
                tauxDeMarge = ((ValeurStockTotal - budgetCollection1) / budgetCollection1) * 100;
            }
            _ = valeurStockTotalLayout.TranslateTo(100, 0, 400);
            await valeurStockTotalLayout.RotateYTo(-90, 200);
            valeurStockTotalLayout.RotationY = -270;
            _ = valeurStockTotalLayout.RotateYTo(-360, 200);
            await valeurStockTotalLayout.TranslateTo(0, 0, 220);
            valeurStockTotalLayout.RotationY = 0;
            valeurStockTotalLayout1.BackgroundColor = Color.White;
            valeurStockTotalFrame.BackgroundColor = Color.White;
            valeurStockTotalBoxview.HeightRequest = 2;
            valeurStockTotal.Text = "Chiffre d'affaire";
            valeurStockTotalLabel.Text = ValeurStockTotal.ToString();

            _ = valeurStockHorsFraisLayout.TranslateTo(100, 0, 400);
            await valeurStockHorsFraisLayout.RotateYTo(-90, 200);
            valeurStockHorsFraisLayout.RotationY = -270;
            _ = valeurStockHorsFraisLayout.RotateYTo(-360, 200);
            await valeurStockHorsFraisLayout.TranslateTo(0, 0, 220);
            valeurStockHorsFraisLayout.RotationY = 0;
            valeurStockHorsFraisLayout1.BackgroundColor = Color.White;
            valeurStockHorsFraisFrame.BackgroundColor = Color.White;
            valeurStockHorsFraisBoxview.HeightRequest = 2;
            valeurStockHorsFrais1.Text = "Marge";
            valeurStockHorsFrais.Text = ValeurStockHorsFrais;
            CreateData3();
            CreateData4();
            myCharts4.Chart = new DonutChart() { Entries = entries3, LabelTextSize = 40f };
            myCharts5.Chart = new RadialGaugeChart() { Entries = entries4, LabelTextSize = 40f };
            isvisible6.IsVisible = true;
            await isvisible6.FadeTo(0.5, 1000, Easing.SinInOut);
            await isvisible6.FadeTo(1, 1000, Easing.SinInOut);
        }

      
    }
}
