using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Microsoft.Azure.Mobile;


namespace XamarinDistributeSample.iOS
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

            //MobileCenter.Configure("386a2d2e-9fd5-4929-b5b8-6bb5f305bc25");
            //MobileCenter.Configure("c5d5226f-8048-4f75-954a-21b50f15b92a");
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();

#if ENABLE_TEST_CLOUD
Xamarin.Calabash.Start();
#endif
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
