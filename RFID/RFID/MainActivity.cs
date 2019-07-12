using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ES.Dmoral.Toasty;
using Prism;
using Prism.Ioc;
using Xamarin.Forms.Platform.Android;
using Plugin.CurrentActivity;
using FFImageLoading.Forms.Platform;
using FFImageLoading;
using ZXing.Mobile;

namespace RFID.Droid
{
    [Activity(Label = "RFID", Icon = "@drawable/icon", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(savedInstanceState);
            // DevExpress.Mobile.Forms.Init();
            //Xamarin.FormsBaiduMaps.Init(null);
            CrossCurrentActivity.Current.Init(this, savedInstanceState);
            
            //this.Window.DecorView.WindowSystemUiVisibility. = SystemUiFlags.LayoutFullscreen | SystemUiFlags.LightStatusBar;6.0才可以使用这个更换statusbar 字体颜色

            var model= AppManager.Instance.AppCfgSavedModel();
            Common.BasicData.Power = 18;
            if(!(model is null))
            {
                AppManager.Instance.GetUhfAndSet(model);
            }
            else
            {
                AppManager.Instance.GetUhfWithDetectionAutomaticallyIfNeed();    
            }
            //AppManager.Instance.SetCurrentActivity(this);使用plugin.currentActivity了
            CachedImageRenderer.Init(true);

            var config = new FFImageLoading.Config.Configuration()
            {
                VerboseLogging = false,
                VerbosePerformanceLogging = false,
                VerboseMemoryCacheLogging = false,
                VerboseLoadingCancelledLogging = false,
                Logger = new CustomLogger(),
            };
            ImageService.Instance.Initialize(config);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            ZXing.Net.Mobile.Forms.Android.Platform.Init();
            //ZXing.Mobile.MobileBarcodeScanner.Initialize(this.Application);
            ImageCircle.Forms.Plugin.Droid.ImageCircleRenderer.Init();
            LoadApplication(new App(new AndroidInitializer()));

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            global::ZXing.Net.Mobile.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            Plugin.Permissions.PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public class AndroidInitializer : IPlatformInitializer
        {
            public void RegisterTypes(IContainerRegistry container)
            {
                // Register any platform specific implementations  containerRegistry.RegisterInstance<IService>(Service);
            }
        }
    }

    public class CustomLogger : FFImageLoading.Helpers.IMiniLogger
    {
        public void Debug(string message)
        {
            Console.WriteLine(message);
        }

        public void Error(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }

        public void Error(string errorMessage, Exception ex)
        {
            Error(errorMessage + System.Environment.NewLine + ex.ToString());
        }
    }
}