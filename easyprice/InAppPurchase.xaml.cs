﻿using System;
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
        String productId = "";
        public InAppPurchase()
        {
            InitializeComponent();
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

                    await DisplayAlert("Bravo", " Achat restauré avec succès", "Cancel");
                    return true;
                }
                else
                {
                    //no purchases found
                    return false;
                }
            }
            catch (InAppBillingPurchaseException purchaseEx)
            {
                //Billing Exception handle this based on the type
                await DisplayAlert("Désolé", $"Méssage d'erreur Code: {purchaseEx.Message}", "Cancel");
                Debug.WriteLine("Error: " + purchaseEx);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Désolé", $"Méssage d'erreur Code: {ex.Message}", "Cancel");
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
                    await DisplayAlert("Désolé", " Pas de connexion","Cancel");
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
                    await DisplayAlert("Bravo", " Achat effectué avec succès", "Cancel");
                    //purchased!
                    if (Device.RuntimePlatform == Device.Android)
                    {
                        // Must call AcknowledgePurchaseAsync else the purchase will be refunded
                        await CrossInAppBilling.Current.AcknowledgePurchaseAsync(purchase.PurchaseToken);
                    }
                }
            }
            catch (InAppBillingPurchaseException purchaseEx)
            {
                //Billing Exception handle this based on the type
                await DisplayAlert("Désolé", $"Méssage d'erreur Code: {purchaseEx.Message}", "Cancel");
                Debug.WriteLine("Error: " + purchaseEx);
            }
            catch (Exception ex)
            {
                //Something else has gone wrong, log it
                await DisplayAlert("Désolé", $"Méssage d'erreur Code: {ex.Message}", "Cancel");
                Debug.WriteLine("Issue connecting: " + ex);
            }
            finally
            {
                await billing.DisconnectAsync();
            }


        }
    }
}
