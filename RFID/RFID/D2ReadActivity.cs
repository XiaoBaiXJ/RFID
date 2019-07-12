using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Com.Senter.Support.Openapi;
using Java.Lang;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using static Com.Senter.Support.Openapi.StUhf;
using Android.Support.V7.App;
using RFID.Services;
using Xamarin.Forms;

namespace RFID.Droid
{
    [Activity(Label = "读取RFID", Theme = "@style/Theme.AppCompat", ScreenOrientation = ScreenOrientation.Portrait)]
    public class D2ReadActivity : AppCompatActivity,IContinuousInventoryListener
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
        const string TAG = "D26CInventory";
        readonly AccompanimentService accompanimentService = new AccompanimentService(Android.App.Application.Context, RFID.Droid.Resource.Raw.tag_inventoried);
        protected Handler accompainimentsHandler;
        protected  Runnable accompainimentRunnable;
        ProgressDialog waitingDialog;
        bool isScaning;
        bool finishOnStop;
         ContinuousInventoryWorker worker;
        readonly PartialWakeLocker mPartialWakeLocker = new PartialWakeLocker(Android.App.Application.Context, TAG);
        StKeyManager.ShortcutKeyMonitor moitorScan = StKeyManager.ShortcutKeyMonitor.IsShortcutKeyAvailable(StKeyManager.ShortcutKey.Scan) ? StKeyManager.GetInstanceOfShortcutKeyMonitor(StKeyManager.ShortcutKey.Scan) : null;
        InventoryD26cListener listener;
        Android.Widget.Button button;
        /// <summary>
        /// 播放滴滴滴
        /// </summary>
        void StartAccompanitment()
        {
            accompanimentService.Play();
            accompainimentsHandler.RemoveCallbacks(accompainimentRunnable);
        }

        protected override void OnResume()
        {
            base.OnResume();
            if (moitorScan!=null)
            {
                moitorScan.StartMonitor();
            }
        }
        protected override void OnPause()
        {
            base.OnPause();
            if (moitorScan != null)
            {
                moitorScan.StopMonitor();
            }
            if (IsFinishing)
            {
                mPartialWakeLocker.WakeLockRelease();
            }
        }
        protected override void OnDestroy()
        {
            if (accompainimentsHandler != null)
            {
                accompainimentsHandler.Looper.Quit();
            }
            accompanimentService.Release();
            mPartialWakeLocker.WakeLockRelease(); 
            base.OnDestroy();
           
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var actionBar = SupportActionBar;
            if (actionBar != null)
            {
                actionBar.SetHomeButtonEnabled(true);
                actionBar.SetDisplayHomeAsUpEnabled(true);
            }
            SetContentView(Resource.Layout.rfid_layout);
            button = FindViewById<Android.Widget.Button>(Resource.Id.find);
            button.Click += Button_Click;

            accompainimentRunnable = new Runnable(StartAccompanitment);
            HandlerThread handlerThread = new HandlerThread("");
            handlerThread.Start();
            accompainimentsHandler = new Handler(handlerThread.Looper);
            listener = new InventoryD26cListener(ListenerOnKeyUp, ListenerOnKeyDown);
            worker = new ContinuousInventoryWorker(this);
            if (moitorScan != null)
            {
                moitorScan.Reset(Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity, listener, null);
            }
            waitingDialog = new ProgressDialog(this);
            waitingDialog.SetButton(AppResource.cancel, (object sender, DialogClickEventArgs e) =>
            {
                if (worker.IsInvertoring)
                {
                    RunOnUiThread(CancelDialogShow);
                    worker.StopInventory();
                }
            });
            waitingDialog.SetCancelable(false);
        }


        void ListenerOnKeyUp()
        {
            isScaning = false;
        }
        void ListenerOnKeyDown()
        {
            if (!isScaning)
            {
                Button_Click(null,null);
                isScaning = true;
            }
        }

        //bool isInventory = false;
        private void Button_Click(object sender, EventArgs e)
        {
            UIOnInverntryButton();
            #region easy inventory
            //if (isInventory == false)
            //{
            //Thread thread = new Thread(() =>
            //{
            //InterrogatorModelDs.InterrogatorModelD2 modelD2;
            //if ( AppManager.Instance.GetInterrogatorModelD2(out modelD2))
            //{
            //        modelD2.SetOutputPower(15);
            //        modelD2.Iso18k6cRealTimeInventory(1,new RealTimeInventory6c());
            //        isInventory = true;
            //}
            //});
            //thread.Start();
            //}
            //else
            //{
            //    isInventory = false;
            //    InterrogatorModelDs.InterrogatorModelD2 modelD2;
            //}
            #endregion
        }

        void UIOnInverntryButton()
        {
            if (worker.IsInvertoring)
            {
                RunOnUiThread(() => { CancelDialogShow(); });
                worker.StopInventory();
            }
            else
            {
                mPartialWakeLocker.WakeLockAcquire();
                //中间设置ui变化
                RunOnUiThread(() => {  WaitDialogShow(); });
                worker.StartInventory();
            }
        }

        #region waitDialog
        private void WaitDialogShow()
        {
            waitingDialog.SetMessage("正在读取...");
            if ( waitingDialog.IsShowing)
            {
                return;
            }
            waitingDialog.Show();
        }
        void CancelDialogShow()
        {
            waitingDialog.SetMessage("正在取消...");
            if (waitingDialog.IsShowing)
            {
                return;
            }
            waitingDialog.Show();
        }
        /**
         * dismiss waiting diaglog
         */
        private void WaitDialogDismiss()
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            {
                if (waitingDialog != null && waitingDialog.IsShowing)
                {
                    waitingDialog.Dismiss();
                }
            });


        }
        #endregion

        public override bool OnKeyDown([GeneratedEnum] Keycode keyCode, KeyEvent e)
        {
            switch (keyCode)
            {
                case Keycode.Break:
                    if (e.Action== KeyEventActions.Down)
                    {
                        if (worker.IsInvertoring)
                        {
                            finishOnStop = true;
                            CancelDialogShow();
                            worker.StopInventory();
                            Finish();
                        }
                        return true;
                    }
                    AppManager.Instance.ClearMaskSetting();
                    break;
                case Keycode.Back:
                    AppManager.Instance.UhfUninit();
                    Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
                    break;
                default:
                    break;
            }
            return base.OnKeyDown(keyCode, e);
        }

        public void onFinished()
        {
            if (finishOnStop)
            {
                AppManager.Instance.ClearMaskSetting();
                WaitDialogDismiss();
                //返回上一页

            }
            else
            {
                mPartialWakeLocker.WakeLockRelease();
                //toobar的按钮,保存与清空可以显示出来

            }
        }
        public void onTagInventory(UII uii, InterrogatorModelDs.UmdFrequencyPoint frequencyPoint, Integer antennaId, InterrogatorModelDs.UmdRssi rssi)
        {
            accompainimentsHandler.Post(accompainimentRunnable);
            try
            {
                var hex = GetHexUII(uii.Epc.GetBytes());
                if (!hex.Equals("null"))
                {
                    worker.StopInventory();
                    MessagingCenter.Send<D2ReadActivity, TagResponse>(this, "tag", new TagResponse { CanTakeTag = true, Tag = hex, FromD2 = true});
                    Finish();
                   
                }
               
            }
            catch (System.Exception)
            {
               
            }
            //在列表展示uii+....
           
        }
        string GetHexUII(byte[] bytes)
        {
            if (bytes != null)
            {
                StringBuffer sBuffer = new StringBuffer();
                foreach (byte item in bytes)
                {
                    sBuffer.Append(Java.Lang.String.Format("%02X",(Java.Lang.Byte)(sbyte)item));
                }
                return sBuffer.ToString();
            }
            return "null";
        }
    }

    public class InventoryD26cListener : StKeyManager.ShortcutKeyMonitor.ShortcutKeyListener
    {
        Action KeyUp;
        Action KeyDown;
        public InventoryD26cListener(Action keyup, Action keydown)
        {
            this.KeyUp = keyup;
            this.KeyDown = keydown;
        }
        public override void OnKeyUp(int p0, int p1, StKeyManager.ShortcutKeyMonitor.ShortcutKeyEvent p2)
        {
            KeyUp();
        }
        public override void OnKeyDown(int p0, int p1, StKeyManager.ShortcutKeyMonitor.ShortcutKeyEvent p2)
        {
            KeyDown();
        }
    }

    public sealed class PartialWakeLocker
    {
        const string TAG = "PartialWakeLocker";
        readonly Context context;
        readonly string tag;
        PowerManager powerManager;
        PowerManager.WakeLock mWakeLock;
        public PartialWakeLocker(Context context, string tag)
        {
            this.context = context;
            this.tag = tag;
        }
        public void WakeLockAcquire()
        {
            if (mWakeLock != null)
            {
                if (mWakeLock.IsHeld)
                {
                    return;
                }
                try
                {
                    mWakeLock.Release();
                    mWakeLock = null;
                }
                catch (System.Exception)
                {

                }
            }
            if (powerManager == null)
            {
                powerManager = (PowerManager)context.GetSystemService(Context.PowerService);
            }
            mWakeLock = powerManager.NewWakeLock(WakeLockFlags.Partial, tag);
            mWakeLock.Acquire();
        }

        public void WakeLockRelease()
        {
            if (mWakeLock != null)
            {
                try
                {
                    mWakeLock.Release();
                    mWakeLock = null;
                }
                catch (System.Exception)
                {

                }
            }
        }
    }

    /// <summary>
    ///go on inventoring after one inventory cycle finished.
    /// </summary>
    public class ContinuousInventoryWorker : StUhf.InterrogatorModelDs.UmdOnIso18k6cRealTimeInventory
    {
        bool goOnInventoring = true;
        bool isInvertoring = false;
        IContinuousInventoryListener mListener;
        ErrDetectorDialog errDetectorDialog= new ErrDetectorDialog();
        public bool IsInvertoring { get => isInvertoring; set => isInvertoring = value; }

        /// <summary>
        /// listener不能为null
        /// </summary>
        /// <param name="listener">Listener.</param>
        public ContinuousInventoryWorker(IContinuousInventoryListener listener)
        {
            this.mListener = listener;
        }

        public override void OnFinishedSuccessfully(Integer p0, int p1, int p2)
        {
            OnFinishedOnce();
        }

        public override void OnFinishedWithError(StUhf.InterrogatorModelDs.UmdErrorCode p0)
        {
            OnFinishedOnce();
        }

        public override void OnTagInventory(StUhf.UII p0, StUhf.InterrogatorModelDs.UmdFrequencyPoint p1, Integer p2, StUhf.InterrogatorModelDs.UmdRssi p3)
        {
            errDetectorDialog.RemoveMessages(0);
            errDetectorDialog.SendEmptyMessageDelayed(0, 1000 * 6);
            mListener.onTagInventory(p0, p1, p2, p3);
        }
        void OnFinishedOnce()
        {
            errDetectorDialog.RemoveMessages(0);
            if (goOnInventoring)
            {
                StartInventory();
            }
            else
            {
                isInvertoring = false;
                mListener.onFinished();
            }
        }
        public void StartInventory()
        {
            goOnInventoring = true;
            isInvertoring = true;
            StUhf.InterrogatorModelDs.InterrogatorModelD2 interrogatorModelD2;
            if (AppManager.Instance.GetInterrogatorModelD2(out interrogatorModelD2))
            {
                interrogatorModelD2.Iso18k6cRealTimeInventory(1, this);
                errDetectorDialog.RemoveMessages(0);
                errDetectorDialog.SendEmptyMessageDelayed(0, 1000 * 6);
            }
        }
        public void StopInventory()
        {
            errDetectorDialog.RemoveMessages(0);
            this.goOnInventoring = false;
        }
    }

    public interface IContinuousInventoryListener
    {
        /**
         * will be called on finished completely
         */
        void onFinished();

        void onTagInventory(StUhf.UII uii, StUhf.InterrogatorModelDs.UmdFrequencyPoint frequencyPoint, Integer antennaId, StUhf.InterrogatorModelDs.UmdRssi rssi);
    }


    public class ErrDetectorDialog : Handler
    {
        public override void HandleMessage(Message msg)
        {
            base.HandleMessage(msg);
            AppManager.Instance.Uhf.Uninit();
            //Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            //{//waitdialogDissmiss();
            //    Android.App.AlertDialog.Builder adb = new Android.App.AlertDialog.Builder(Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity);
            //    adb.SetCancelable(false);
            //    adb.SetTitle("警告");
            //    adb.SetMessage("发现错误,退出app并重试");
            //    adb.SetPositiveButton("确定", (object sender, DialogClickEventArgs e) =>
            //    {
            //        AppManager.Instance.Uhf.Uninit();
            //        Runtime.GetRuntime().Exit(0);
            //    });
            //    adb.Show();
            //});
        }
    }

    /// <summary>
    /// 简单的盘点
    /// </summary>
    public class RealTimeInventory6c : StUhf.InterrogatorModelDs.UmdOnIso18k6cRealTimeInventory
    {
        public override void OnFinishedSuccessfully(Integer p0, int p1, int p2)
        {

        }

        public override void OnFinishedWithError(InterrogatorModelDs.UmdErrorCode p0)
        {

        }

        public override void OnTagInventory(UII p0, InterrogatorModelDs.UmdFrequencyPoint p1, Integer p2, InterrogatorModelDs.UmdRssi p3)
        {
            
        }
    }
}