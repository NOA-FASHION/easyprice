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
        String productId = "";
        public InAppPurchase()
        {
            InitializeComponent();
        }

        public async void AchatButtonClicked(object sender, System.EventArgs e)
        { }
        public async void RestaurButtonClicked(object sender, System.EventArgs e)
        { }

        public async Task<bool> WasItemPurchased(string productId)
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
                var idsToNotFinish = new List<string>(new[] { "myconsumable" });

                var purchases = await billing.GetPurchasesAsync(ItemType.InAppPurchase, idsToNotFinish);

                //check for null just in case
                if (purchases?.Any(p => p.ProductId == productId) ?? false)
                {
                    //Purchase restored
                    // if on Android may be good to 
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
                Debug.WriteLine("Error: " + purchaseEx);
            }
            catch (Exception ex)
            {
                //Something has gone wrong
            }
            finally
            {
                await billing.DisconnectAsync();
            }

            return false;
        }
        public async Task<bool> PurchaseItem(string productId)
        {
            var billing = CrossInAppBilling.Current;
            try
            {
                var connected = await billing.ConnectAsync();
                if (!connected)
                {
                    //we are offline or can't connect, don't try to purchase
                    return false;
                }

                //check purchases
                var purchase = await billing.PurchaseAsync(productId, ItemType.InAppPurchase, payload);

                //possibility that a null came through.
                if (purchase == null)
                {
                    //did not purchase
                }
                else if (purchase.State == PurchaseState.Purchased)
                {
                    //purchased!
                    if (Device.RuntimePlatform == Device.Android)
                    {
                        // Must call AcknowledgePurchaseAsync else the purchase will be refunded
                    }
                }
            }
            catch (InAppBillingPurchaseException purchaseEx)
            {
                //Billing Exception handle this based on the type
                Debug.WriteLine("Error: " + purchaseEx);
            }
            catch (Exception ex)
            {
                //Something else has gone wrong, log it
                Debug.WriteLine("Issue connecting: " + ex);
            }
            finally
            {
                await billing.DisconnectAsync();
            }


        }
    }
}
