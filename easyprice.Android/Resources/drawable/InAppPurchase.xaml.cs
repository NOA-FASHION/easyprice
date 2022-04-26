using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plugin.InAppBilling;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace easyprice
{
    public partial class InAppPurchase : ContentPage
    {
        public InAppPurchase()
        {
            InitializeComponent();
        }


        async Task PurchaseSubscription()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            try
            {

                // check internet first with Essentials
                if (Connectivity.NetworkAccess != NetworkAccess.Internet)
                    return;

                // connect to the app store api
                var connected = await CrossInAppBilling.Current.ConnectAsync();
                if (!connected)
                    return;


                var productIdSub = "mysubscriptionid";

                //try to make purchase, this will return a purchase, empty, or throw an exception
                var purchase = await CrossInAppBilling.Current.PurchaseAsync(productIdSub, ItemType.InAppPurchase);

                if (purchase == null)
                {
                    //nothing was purchased
                    return;
                }

                if (purchase.State == PurchaseState.Purchased)
                {
                  

                    try
                    {
                        // It is required to acknowledge the purchase, else it will be refunded
                        if (DeviceInfo.Platform == DevicePlatform.Android)
                            await CrossInAppBilling.Current.AcknowledgePurchaseAsync(purchase.PurchaseToken);
                    }
                    catch (Exception ex)
                    {
                       
                    }
                }
                else
                {
                    throw new InAppBillingPurchaseException(PurchaseError.GeneralError);
                }
            }
            catch (InAppBillingPurchaseException purchaseEx)
            {
                // Handle all the different error codes that can occure and do a pop up
            }
            catch (Exception ex)
            {
                // Handle a generic exception as something really went wrong
            }
            finally
            {
                await CrossInAppBilling.Current.DisconnectAsync();
                IsBusy = false;

            }
        }

        async Task restaurPurchase()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            try
            {

                // check internet first with Essentials
                if (Connectivity.NetworkAccess != NetworkAccess.Internet)
                    return;

                // connect to the app store api
                var connected = await CrossInAppBilling.Current.ConnectAsync();
                if (!connected)
                    return;


                var productIdSub = "mysubscriptionid";

                //try to make purchase, this will return a purchase, empty, or throw an exception
                var purchase = await CrossInAppBilling.Current.GetPurchasesAsync(ItemType.InAppPurchase);

                if (purchase == null)
                {
                    //nothing was purchased
                    return;
                }

                if (purchase?.Any(p => p.ProductId == productIdSub) ?? false)
                {

                    await DisplayAlert("Unable to Connect", "Unable to connect to the app store, check your internet connectivity and try again.","Cancel");
                }

                //    if (purchase.State == PurchaseState.Purchased)
                //{


                //    try
                //    {
                //        // It is required to acknowledge the purchase, else it will be refunded
                //        if (DeviceInfo.Platform == DevicePlatform.Android)
                //            await CrossInAppBilling.Current.AcknowledgePurchaseAsync(purchase.PurchaseToken);
                //    }
                //    catch (Exception ex)
                //    {

                //    }
                //}
                //else
                //{
                //    throw new InAppBillingPurchaseException(PurchaseError.GeneralError);
                //}
            }
            catch (InAppBillingPurchaseException purchaseEx)
            {
                // Handle all the different error codes that can occure and do a pop up
            }
            catch (Exception ex)
            {
                // Handle a generic exception as something really went wrong
            }
            finally
            {
                await CrossInAppBilling.Current.DisconnectAsync();
                IsBusy = false;

            }
        }
        private  void FinalButtonClick(object sender, System.EventArgs e)
        { }







        }
}
