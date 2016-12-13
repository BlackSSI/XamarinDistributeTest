using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using HockeyApp.Android;
using HockeyApp.Android.Metrics;

namespace XamarinDistributeSample.Droid
{
    [Activity(Label = "XamarinDistributeSample.Droid", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            var AppId = "c7e7e0cf37a74265a0a89cf8045065db";
            CrashManager.Register(this, AppId);
            MetricsManager.Register(Application, AppId);
            MetricsManager.EnableUserMetrics();

            LoadApplication(new App());
        }
    }
}
