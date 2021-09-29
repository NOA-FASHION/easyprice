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
        
            ObservableCollection<ChartEntry> entries3;
            ObservableCollection<ChartEntry> entries4;
            string ValeurStockHorsFrais = "0";
            int NoteDeFrais;
            float ValeurStockTotal = 0;
            string coeffMultArt1;
            string Pourcentage1;
            bool avecPourcentage;
            float tauxDeMarque = 0;
            float tauxDeMarge = 0;
            string imageUrl;
            int NumCommande2;
            float fraisDePort1;
            string NumCollection;
            float valeurStockHorsFrais2;
            string EntryButtonCout = " ";
            float entryFraisDePort;
            float microshartFraisDePort;
            float budgetCollection = 0;
            bool coefficentOk;
            string resultLabel;
            float budgetCollection1;
        //FirebaseClient firebase = new FirebaseClient("https://fir-01-7395c.firebaseio.com");
        //public System.Collections.ObjectModel.ObservableCollection<photoUrlClass> photoUrlListes1 = new ObservableCollection<photoUrlClass>();

        public Simulator()
        {
            InitializeComponent();
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/04/21/18/49/tropical-5074304_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/21/16/04/turkey-5201498_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/25/08/59/iceland-5217702_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/22/11/53/clematis-5205114_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/04/03/07/26/eye-4997724_960_720.png" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/29/05/47/barley-5233734_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/27/11/45/virgin-in-the-green-5226865_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/28/15/15/smartphone-5231499_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/28/22/23/balloon-hot-air-5232909_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/27/16/04/forget-me-not-5227806_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/22/06/51/poppy-5204048_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/27/21/16/margarite-5228896_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/30/14/29/landscape-5239128_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/19/19/27/swan-5192350_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/18/12/41/landscape-5186058_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/30/15/04/mint-5239190_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/26/18/10/purple-geranium-5224146_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/23/12/45/rock-5209413_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/18/12/41/landscape-5186058_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2020/05/26/19/32/mountains-5224483_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2018/03/12/12/32/woman-3219507_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2015/01/15/13/06/model-600238_960_720.jpg" });
        //    photoUrlListes1.Add(new photoUrlClass { UrlImages = "https://cdn.pixabay.com/photo/2015/10/13/03/39/fashion-985556_960_720.jpg" });


        fraisDePort1 = 0;
            //pourcentageOk = false;
            entryFraisDePort = 0;
            coefficentOk = false;
            EntryFraisDePort.Text = "0";
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
            EntryNoteDeFrais.Text = "0";
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            //var ListesCollection1 = await firebaseCollection.GetAllPersons();
            //if (ListesCollection1.Count > 0)
            //{
            //    NumCollection = ListesCollection1[ListesCollection1.Count - 1].NumDeCollection;
            //    NumCommande2 = int.Parse(NumCollection);
            //    NumCommande2++;
            //}
            //else
            //{
            //    NumCommande2 = 0;
            //}

            //LabelNumCollection.Text = "#" + NumCommande2.ToString();
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
        //public async void visible13()
        //{
        //    collectionViewNoteDeFrais.ItemsSource = photoUrlListes1;
        //    MaLayaoutNewCollection.IsVisible = true;
        //    await MaLayaoutNewCollection.TranslateTo(100, 0, 500, Easing.SpringOut);
        //    await MaLayaoutNewCollection.TranslateTo(-100, 0, 500, Easing.SpringOut);
        //    await MaLayaoutNewCollection.TranslateTo(0, 0);
        //}

        //void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var current = (e.CurrentSelection.FirstOrDefault() as photoUrlClass)?.UrlImages;
        //    imageUrl = current;
        //    imageurl.Source = ImageSource.FromUri(new Uri(imageUrl));
        //    MaLayaoutNewCollection.IsVisible = false;
        //    isvisible1.IsVisible = true;
        //}

        //public void LayoutVISIBLE()
        //{
        //    if (MaLayaoutNewCollection.IsVisible == true)
        //    {
        //        MaLayaoutNewCollection.IsVisible = false;
        //    }
        //}

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

            entryFraisDePort = float.Parse(EntryFraisDePort.Text);
            EntryButtonCout = EntryCoutcollecion.Text;
            NoteDeFrais = int.Parse(EntryNoteDeFrais.Text);
            ValeurStockTotal = float.Parse(EntryButtonCout) * float.Parse(coeffMultArt);
            budgetCollection = int.Parse(EntryButtonCout) + NoteDeFrais + fraisDePort1;
            budgetCollection1 = int.Parse(EntryButtonCout) + NoteDeFrais + entryFraisDePort;
            //if (entryFraisDePort == 0 && avecPourcentage == false)

            //{
            //    await DisplayAlert("Ooops", "Vous devez rentrer un montant pour les frais de port", "Ok");
            //    return;
            //}
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

        //public async void OnTapGestureRecognizerTapped7(object sender, System.EventArgs e)
        //{
        //    if (totalBugetGeneral.IsVisible == true && budgetCollection == 0)
        //    {
        //        await budgetTotalLayaout.FadeTo(0.5, 1000, Easing.SinInOut);
        //        await budgetTotalLayaout.FadeTo(1, 1000, Easing.SinInOut);
        //        totalBugetGeneral.IsVisible = false;
        //        budgetTotalButtom.IsVisible = false;
        //        BudgetCollectionArticleLable.IsVisible = false;
        //        totalBugetGeneral1.IsVisible = true;
        //    }
        //    else if (totalBugetGeneral.IsVisible == false && budgetCollection == 0)
        //    {
        //        await budgetTotalLayaout.FadeTo(0.5, 1000, Easing.SinInOut);
        //        await budgetTotalLayaout.FadeTo(1, 1000, Easing.SinInOut);
        //        totalBugetGeneral1.IsVisible = false;
        //        totalBugetGeneral.IsVisible = true;
        //        budgetTotalButtom.IsVisible = true;
        //        BudgetCollectionArticleLable.IsVisible = true;
        //    }

        //}
        //public void OnTapGestureRecognizerTapped17(object sender, System.EventArgs e)
        //{
        //    TapGesture();
        //    LayoutVISIBLE();
        //}
        //public void OnTapGestureRecognizerTapped18(object sender, System.EventArgs e)
        //{
        //    TapGesture();
        //    LayoutVISIBLE();
        //}

        //public void OnTapGestureRecognizerTapped19(object sender, System.EventArgs e)
        //{
        //    TapGesture();
        //    LayoutVISIBLE();
        //}
        //public async void CreerCollection1ButtonClicked(object sender, System.EventArgs e)
        //{
        //    if (budgetCollection == 0)
        //    {
        //        await DisplayAlert("Ooops", "Vous devez rentez un budget de collection", "Ok");
        //        return;
        //    }
        //    _ = budgetTotalButtom.TranslateTo(100, 0, 400);
        //    await budgetTotalButtom.RotateYTo(-90, 200);
        //    budgetTotalButtom.RotationY = -270;
        //    _ = budgetTotalButtom.RotateYTo(-360, 200);
        //    await budgetTotalButtom.TranslateTo(0, 0, 220);
        //    budgetTotalButtom.RotationY = 0;
        //    budgetTotalButtom.IsVisible = false;
        //    budgetTotalButtom1.IsVisible = true;
        //    isvisible10.IsVisible = true;
        //    await isvisible10.FadeTo(0.5, 1000, Easing.SinInOut);
        //    await isvisible10.FadeTo(1, 1000, Easing.SinInOut);
        //}


        //public void CreerCollection2ButtonClicked(object sender, System.EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(EntryNomDeCollection.Text))
        //    {
        //        DisplayAlert("Ooops", "Vous devez rentez un nom de collection", "Ok");
        //        return;
        //    }
        //    if (string.IsNullOrWhiteSpace(imageUrl))
        //    {
        //        DisplayAlert("Ooops", "Vous devez choisir une image de collection", "Ok");
        //        return;
        //    }

            //AddDatabase();

            //this.Navigation.PushAsync(new ListeNewCollectionPage(false));

        //}
        //private async void AddDatabase()
        //{
        //    await AddPerson(imageUrl, EntryNomDeCollection.Text, "#" + NumCommande2, budgetCollection.ToString(),
        //      startDatePicker.Date, endDatePicker.Date, resultLabel);
        //    //txtId.Text = string.Empty;
        //    //txtName.Text = string.Empty;
        //    await DisplayAlert("Success", "Person Added Successfully", "OK");
        //}
        //private async void AddDatabase()
        //{
        //    await firebaseCollection.AddPerson(imageUrl, EntryNomDeCollection.Text, NumCommande2.ToString(), budgetCollection.ToString(),
        //      startDatePicker.Date, endDatePicker.Date, resultLabel);

        //}
        //async Task StartCharge()
        //{
        //    var ListesCollection1 = await firebaseCollection.GetAllPersons();


        //    NumCollection = ListesCollection1[ListesCollection1.Count - 1].NumDeCollection;

        //}


        //public void IncrementnumCommand()
        //{
        //    NumCommande2 = int.Parse(NumCollection);
        //    NumCommande2++;
        //}
        //void OnDateSelected(object sender, DateChangedEventArgs args)
        //{
        //    Recalculate();
        //}

        //void Recalculate()
        //{
        //    TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date;

        //    resultLabel = String.Format("{0} day{1}",
        //    timeSpan.Days, timeSpan.Days == 1 ? "" : "s");
        //}

        //public async void TapGesture()
        //{
        //    await isvisible10.FadeTo(0.5, 1000, Easing.SinInOut);
        //    await isvisible10.FadeTo(1, 1000, Easing.SinInOut);
        //    isvisible10.IsVisible = false;
        //    _ = budgetTotalButtom1.TranslateTo(100, 0, 400);
        //    await budgetTotalButtom1.RotateYTo(-90, 200);
        //    budgetTotalButtom1.RotationY = -270;
        //    _ = budgetTotalButtom1.RotateYTo(-360, 200);
        //    await budgetTotalButtom1.TranslateTo(0, 0, 220);
        //    budgetTotalButtom1.RotationY = 0;
        //    budgetTotalButtom1.IsVisible = false;
        //    budgetTotalButtom.IsVisible = true;
        //}

        //void OnTapGestureRecognizerTapped6(object sender, System.EventArgs e)
        //{
        //    visible13();
        //}
    }
}
