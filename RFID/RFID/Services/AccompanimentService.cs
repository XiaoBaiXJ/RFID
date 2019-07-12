using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace RFID.Services
{
    // Token: 0x020000C7 RID: 199
    public class AccompanimentService
    {
        // Token: 0x06000458 RID: 1112 RVA: 0x000026F6 File Offset: 0x000008F6
        public AccompanimentService()
        {
        }

        // Token: 0x06000459 RID: 1113 RVA: 0x0001DBA0 File Offset: 0x0001BDA0
        public AccompanimentService(Context context, int resID)
        {
            this.owenrContext = context;
            this.resSoundID = resID;
        }

        // Token: 0x0600045A RID: 1114 RVA: 0x0001DBB6 File Offset: 0x0001BDB6
        public RingerMode GetRingerMode()
        {
            if (this.mAudioManager == null)
            {
                this.mAudioManager = (AudioManager)this.owenrContext.GetSystemService("audio");
            }
            return this.mAudioManager.RingerMode;
        }

        // Token: 0x0600045B RID: 1115 RVA: 0x0001DBE6 File Offset: 0x0001BDE6
        public bool Play()
        {
            return this.Start(false);
        }

        // Token: 0x0600045C RID: 1116 RVA: 0x0001DBEF File Offset: 0x0001BDEF
        public bool PlayForce()
        {
            return this.Start(true);
        }

        // Token: 0x0600045D RID: 1117 RVA: 0x0001DBF8 File Offset: 0x0001BDF8
        private bool Start(bool forceInSilence)
        {
            if (this.isReleased)
            {
                return false;
            }
            bool result;
            lock (this)
            {
                if (this.mBarcodeMediaPlayer == null)
                {
                    this.mBarcodeMediaPlayer = MediaPlayer.Create(this.owenrContext, this.resSoundID);
                    if (this.mBarcodeMediaPlayer == null)
                    {
                        return false;
                    }
                }
                if (!forceInSilence && this.GetRingerMode() != RingerMode.Normal)
                {
                    result = false;
                }
                else
                {
                    this.mBarcodeMediaPlayer.Start();
                    result = true;
                }
            }
            return result;
        }

        // Token: 0x0600045E RID: 1118 RVA: 0x0001DC80 File Offset: 0x0001BE80
        public void Release()
        {
            this.isReleased = true;
            lock (this)
            {
                if (this.mBarcodeMediaPlayer != null)
                {
                    this.mBarcodeMediaPlayer.Release();
                    this.mBarcodeMediaPlayer = null;
                }
            }
        }

        // Token: 0x040002E4 RID: 740
        private Context owenrContext;

        // Token: 0x040002E5 RID: 741
        public MediaPlayer mBarcodeMediaPlayer;

        // Token: 0x040002E6 RID: 742
        private AudioManager mAudioManager;

        // Token: 0x040002E7 RID: 743
        private readonly int resSoundID;

        // Token: 0x040002E8 RID: 744
        private bool isReleased;
    }
}