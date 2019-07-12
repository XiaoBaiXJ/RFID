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

namespace RFID.Services
{
    public abstract class InventoryService
    {
        // Token: 0x0600045F RID: 1119 RVA: 0x0001DCD8 File Offset: 0x0001BED8
        private void StartAccompanitment()
        {
            this.accompanimentService.Play();
            this.accompainimentsHandler.RemoveCallbacks(this.accompainimentRunnable);
        }

        // Token: 0x06000460 RID: 1120 RVA: 0x0001DCF8 File Offset: 0x0001BEF8
        public InventoryService()
        {
            this.accompainimentRunnable = new Runnable(new Action(this.StartAccompanitment));
            HandlerThread handlerThread = new HandlerThread("");
            handlerThread.Start();
            this.accompainimentsHandler = new Handler(handlerThread.Looper);
        }

        // Token: 0x06000461 RID: 1121 RVA: 0x0001DD59 File Offset: 0x0001BF59
        protected virtual void Destroy()
        {
            if (this.accompainimentsHandler != null)
            {
                this.accompainimentsHandler.Looper.Quit();
            }
            this.accompanimentService.Release();
        }

        // Token: 0x040002E9 RID: 745
        private readonly AccompanimentService accompanimentService = new AccompanimentService(Application.Context, 2131230720);

        // Token: 0x040002EA RID: 746
        protected Handler accompainimentsHandler;

        // Token: 0x040002EB RID: 747
        protected readonly Runnable accompainimentRunnable;
    }
}