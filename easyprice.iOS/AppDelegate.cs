using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Lottie.Forms.Platforms.Ios;
using StoreKit;
using UIKit;

namespace easyprice.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init();
            //AnimationViewRenderer.Init();
            Plugin.InAppBilling.InAppBillingImplementation.OnShouldAddStorePayment = OnShouldAddStorePayment;
            var current = Plugin.InAppBilling.CrossInAppBilling.Current; //initializes
            return base.FinishedLaunching(app, options);
        }
        bool OnShouldAddStorePayment(SKPaymentQueue queue, SKPayment payment, SKProduct product)
        {
            //Process and check purchases
            return true;
        }
    }
}
