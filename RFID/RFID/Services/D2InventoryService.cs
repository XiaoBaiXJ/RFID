using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RFID.Droid;

namespace RFID.Services
{
    // Token: 0x020000C9 RID: 201
    public class D2InventoryService : InventoryService, IContinuousInventoryListener
    {
        // Token: 0x06000462 RID: 1122 RVA: 0x0001DD80 File Offset: 0x0001BF80
        public D2InventoryService()
        {
            this.listener = new InventoryD26cListener(new Action(this.ListenerOnKeyUp), new Action(this.ListenerOnKeyDown));
            this.worker = new ContinuousInventoryWorker(this);
            if (this.moitorScan != null)
            {
                this.moitorScan.Reset(CrossCurrentActivity.Current.Activity, this.listener, null);
            }
        }

        // Token: 0x06000463 RID: 1123 RVA: 0x0001DE1A File Offset: 0x0001C01A
        public void Inverntry()
        {
            if (this.worker.IsInvertoring)
            {
                this.worker.StopInventory();
                return;
            }
            this.mPartialWakeLocker.WakeLockAcquire();
            this.worker.StartInventory();
        }

        // Token: 0x06000464 RID: 1124 RVA: 0x0001DE4B File Offset: 0x0001C04B
        private void ListenerOnKeyUp()
        {
            this.isScanning = false;
        }

        // Token: 0x06000465 RID: 1125 RVA: 0x0001DE54 File Offset: 0x0001C054
        private void ListenerOnKeyDown()
        {
            if (!this.isScanning)
            {
                this.Inverntry();
                this.isScanning = true;
            }
        }

        // Token: 0x14000002 RID: 2
        // (add) Token: 0x06000466 RID: 1126 RVA: 0x0001DE6C File Offset: 0x0001C06C
        // (remove) Token: 0x06000467 RID: 1127 RVA: 0x0001DEA4 File Offset: 0x0001C0A4
        public event EventHandler TagInventoryOnUi;

        // Token: 0x06000468 RID: 1128 RVA: 0x0001DED9 File Offset: 0x0001C0D9
        public void onFinished()
        {
            if (this.finishOnStop)
            {
                AppManager.Instance.ClearMaskSetting();
                this.WaitDialogDismiss();
                return;
            }
            this.mPartialWakeLocker.WakeLockRelease();
        }

        // Token: 0x06000469 RID: 1129 RVA: 0x0001DEFF File Offset: 0x0001C0FF
        public void onTagInventory(StUhf.UII uii, StUhf.InterrogatorModelDs.UmdFrequencyPoint frequencyPoint, Integer antennaId, StUhf.InterrogatorModelDs.UmdRssi rssi)
        {
            this.accompainimentsHandler.Post(this.accompainimentRunnable);
            EventHandler tagInventoryOnUi = this.TagInventoryOnUi;
            if (tagInventoryOnUi == null)
            {
                return;
            }
            tagInventoryOnUi(null, null);
        }

        // Token: 0x0600046A RID: 1130 RVA: 0x0001DF28 File Offset: 0x0001C128
        private void WaitDialogShow()
        {
            if (this.waitingDialog != null && this.waitingDialog.IsShowing)
            {
                return;
            }
            this.waitingDialog = new ProgressDialog(CrossCurrentActivity.Current.Activity);
            this.waitingDialog.SetCancelable(false);
            this.waitingDialog.SetMessage("等待关闭");
            this.waitingDialog.Show();
        }

        // Token: 0x0600046B RID: 1131 RVA: 0x0001DF87 File Offset: 0x0001C187
        private void WaitDialogDismiss()
        {
            Device.BeginInvokeOnMainThread(delegate
            {
                if (this.waitingDialog != null && this.waitingDialog.IsShowing)
                {
                    this.waitingDialog.Dismiss();
                }
            });
        }

        // Token: 0x040002EC RID: 748
        private const string TAG = "D26CInventory";

        // Token: 0x040002ED RID: 749
        private readonly PartialWakeLocker mPartialWakeLocker = new PartialWakeLocker(Android.App.Application.Context, "D26CInventory");

        // Token: 0x040002EE RID: 750
        private StKeyManager.ShortcutKeyMonitor moitorScan = StKeyManager.ShortcutKeyMonitor.IsShortcutKeyAvailable(StKeyManager.ShortcutKey.Scan) ? StKeyManager.GetInstanceOfShortcutKeyMonitor(StKeyManager.ShortcutKey.Scan) : null;

        // Token: 0x040002EF RID: 751
        private bool finishOnStop;

        // Token: 0x040002F0 RID: 752
        private ProgressDialog waitingDialog;

        // Token: 0x040002F1 RID: 753
        private bool isScanning;

        // Token: 0x040002F2 RID: 754
        private readonly ContinuousInventoryWorker worker;

        // Token: 0x040002F3 RID: 755
        private InventoryD26cListener listener;
    }
}