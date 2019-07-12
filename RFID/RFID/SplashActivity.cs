
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace RFID.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true, ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class SplashActivity : AppCompatActivity
    {
        //ProgressDialog ProgressDialog;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //SetContentView(Resource.Layout.SplashScreen);
            //ProgressDialog = new ProgressDialog(this);
            //ProgressDialog.SetTitle("...");
            //ProgressDialog.SetProgressStyle(ProgressDialogStyle.Horizontal);
        }
        // Launches the startup task
        protected override  void OnResume()
        {
            base.OnResume();        
            StartActivity(new Intent(Application.Context, typeof(MainActivity))); 
        }

    }
}
