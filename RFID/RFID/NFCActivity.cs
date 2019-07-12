
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Nfc;
using Android.OS;
using Android.Runtime;
using Xamarin.Forms;
using Android.Views;
using Android.Widget;
using Prism.Events;

namespace RFID.Droid
{
    [Activity(Label = "读取铅封", LaunchMode = LaunchMode.SingleTop,ScreenOrientation = ScreenOrientation.Portrait)]
    public class NFCActivity : Activity
    {

        /// <summary>
        /// 重写返回按钮
        /// </summary>
        /// <returns><c>true</c>, if options item selected was oned, <c>false</c> otherwise.</returns>
        /// <param name="item">Item.</param>
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    Finish();
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }

        }

        //IEventAggregator eventAggregator;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.nfc_layout);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeButtonEnabled(true);
            // Create your application here
        }
        NfcAdapter adapter;
        protected override void OnResume()
        {
            base.OnResume();
            adapter = NfcAdapter.GetDefaultAdapter(Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity);
            if (adapter is null)
            {
                // eventAggregator.GetEvent<UpdateTagEvent>()
                //              .Publish(new TagResponse { CanTakeTag = false, Message = RFID.Droid.AppResource.nonfc });
                MessagingCenter.Send<NFCActivity, TagResponse>(this,"tag", new TagResponse { CanTakeTag = false, Message = RFID.Droid.AppResource.nonfc });
                this.Finish();
            }
            else if (!adapter.IsEnabled)
            {
                //eventAggregator.GetEvent<UpdateTagEvent>()
                //             .Publish(new TagResponse { CanTakeTag = false, Message = RFID.Droid.AppResource.nfc_unable });
                MessagingCenter.Send<NFCActivity, TagResponse>(this, "tag", new TagResponse { CanTakeTag = false, Message = RFID.Droid.AppResource.nfc_unable });
           Finish();
                //Intent setNfc = new Intent(Android.Provider.Settings.ActionNfcSettings);
                //StartActivity(setNfc);
            }
            else
            {
                var tagDiscover = new IntentFilter(NfcAdapter.ActionTagDiscovered);
                var filters = new[] { tagDiscover };
                var intent = new Intent(this, GetType());
                var pendingIntent = PendingIntent.GetActivity(this, 0, intent, 0);
                adapter.EnableForegroundDispatch(this, pendingIntent, filters, null);
            }
        }

        protected override void OnPause()
        {
            base.OnPause();
            if (adapter !=null)
            {
                adapter.DisableForegroundDispatch(this);
            }
        }

        protected override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);
            try
            {
                var tag = intent.GetParcelableExtra(NfcAdapter.ExtraTag) as Tag;
                byte[] ids = tag.GetId();
                StringBuilder ret = new StringBuilder();
                foreach (byte b in ids)
                {
                    //{0:x2} 小写
                    ret.AppendFormat("{0:X2}", b);
                }
                var hex = ret.ToString();
                MessagingCenter.Send<NFCActivity, TagResponse>(this, "tag", new TagResponse { Tag = hex, CanTakeTag = true });
              
                //eventAggregator.GetEvent<UpdateTagEvent>()
                //             .Publish(new TagResponse { Tag = hex, CanTakeTag = true });
            }
            catch (Exception ex)
            {
                MessagingCenter.Send<NFCActivity, TagResponse>(this, "tag", new TagResponse { CanTakeTag = false, Message = AppResource.unknowntag + " " + ex.Message });
                   //eventAggregator.GetEvent<UpdateTagEvent>()
                //              .Publish(new TagResponse { CanTakeTag = false, Message = AppResource.unknowntag + " " + ex.Message });
            }
            Finish();
        }
    }

    public class TagResponse
    {
        public string Tag { set; get; }
        public bool CanTakeTag { set; get; }
        public bool FromD2 { set; get; }
        public string Message { set; get; }

    }

    public class UpdateTagEvent:PubSubEvent<TagResponse>
    {

    }
}
