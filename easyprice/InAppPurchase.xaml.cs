using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Plugin.InAppBilling;
using Xamarin.Forms;

namespace easyprice
{
    public partial class InAppPurchase : ContentPage
    {
        String productId = "in_app_purchase_price";
        public InAppPurchase()
        {
            InitializeComponent();
            validPurch.IsVisible = false;
        }

        public async void AchatButtonClicked(object sender, System.EventArgs e)
        {
            await PurchaseItem();
        }
        public async void RestaurButtonClicked(object sender, System.EventArgs e)
        {
            await ReataurPurchased();
        }

        public async Task<bool> ReataurPurchased()
        {
            var billing = CrossInAppBilling.Current;
            try
            {
                var connected = await billing.ConnectAsync();

                if (!connected)
                {
                    //Couldn't connect
                    return false;
                }

                //check purchases
                

                var purchases = await billing.GetPurchasesAsync(ItemType.InAppPurchase);

                //check for null just in case
                if (purchases?.Any(p => p.ProductId == productId) ?? false)
                {
                    //Purchase restored
                    // if on Android may be good to

                    await DisplayAlert("Bravo", " Achat restauré avec succès", "Ok");
                    validPurch.IsVisible = true;
                    return true;
                }
                else
                {
                    //no purchases found
                    await DisplayAlert("Dommage", " Vous n'avez pas encore acheté cet article", "Ok");
                    return false;
                }
            }
            catch (InAppBillingPurchaseException purchaseEx)
            {
                //Billing Exception handle this based on the type
                await DisplayAlert("Désolé", $"Méssage d'erreur Code: {purchaseEx.Message}", "Ok");
                Debug.WriteLine("Error: " + purchaseEx);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Désolé", $"Méssage d'erreur Code: {ex.Message}", "Ok");
                //Something has gone wrong
            }
            finally
            {
                await billing.DisconnectAsync();
            }

            return false;
        }



        public async Task PurchaseItem()
        {
            var billing = CrossInAppBilling.Current;
            try
            {
                var connected = await billing.ConnectAsync();
                if (!connected)
                {
                    await DisplayAlert("Désolé", " Pas de connexion","Ok");
                    return ;
                }

                //check purchases
                var purchase = await billing.PurchaseAsync(productId, ItemType.InAppPurchase);

                //possibility that a null came through.
                if (purchase == null)
                {
                    //did not purchase
                }
                else if (purchase.State == PurchaseState.Purchased)
                {
                    await DisplayAlert("Bravo", " Achat effectué avec succès", "Ok");
                    //purchased!
                    if (Device.RuntimePlatform == Device.Android)
                    {
                        // Must call AcknowledgePurchaseAsync else the purchase will be refunded
                        await CrossInAppBilling.Current.AcknowledgePurchaseAsync(purchase.PurchaseToken);
                    }
                    validPurch.IsVisible = true;
                }
            }
            catch (InAppBillingPurchaseException purchaseEx)
            {
                //Billing Exception handle this based on the type
                await DisplayAlert("Désolé", $"Méssage d'erreur Code: {purchaseEx.Message}", "Ok");
                Debug.WriteLine("Error: " + purchaseEx);
            }
            catch (Exception ex)
            {
                //Something else has gone wrong, log it
                await DisplayAlert("Désolé", $"Méssage d'erreur Code: {ex.Message}", "Ok");
                Debug.WriteLine("Issue connecting: " + ex);
            }
            finally
            {
                await billing.DisconnectAsync();
            }


        }
        public async void validPurchase(object sender, System.EventArgs e)
        {
            Application.Current.Properties["activation"] = "true";
            await Application.Current.SavePropertiesAsync();
            await this.Navigation.PushAsync(new MyTabbedPage());

            Navigation.RemovePage(this);

        }

        
    }
}
