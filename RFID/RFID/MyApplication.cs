
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Plugin.CurrentActivity;
using static Android.App.Application;

namespace RFID.Droid
{

#if DEBUG
    [Application(Debuggable = true)]
#else
[Application(Debuggable = false)]
#endif
    public class MainApplication : Application
    {
        public MainApplication(IntPtr handle, JniHandleOwnership transer)
            : base(handle, transer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            CrossCurrentActivity.Current.Init(this);
        }
    }


#if DEBUG
    //[Application(Debuggable = true)]
#else
//[Application(Debuggable = false)]
#endif
    public class MyApplication : Application, IActivityLifecycleCallbacks
    {
        public MyApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }
        /// <summary>
        /// 自定义application必须要重写该方法,并且必须加特性[Application] 在mainifest加name
        /// </summary>
        public override void OnCreate()
        {
            base.OnCreate();
        }
        public void OnActivityCreated(Activity activity, Bundle savedInstanceState)
        {

        }

        public void OnActivityDestroyed(Activity activity)
        {
           
        }

        public void OnActivityPaused(Activity activity)
        {

        }

        public void OnActivityResumed(Activity activity)
        {
            //xamarin.forms使用的是fragment不是activity
            RFID.AppManager.Instance.SetCurrentActivity(activity);
        }

        public void OnActivitySaveInstanceState(Activity activity, Bundle outState)
        {
           
        }

        public void OnActivityStarted(Activity activity)
        {
           
        }

        public void OnActivityStopped(Activity activity)
        {

        }
    }
}
