using System;

namespace RFID.Layout
{
    // Token: 0x020000EA RID: 234
    public class TakePhotoEventArgs : EventArgs
    {
        // Token: 0x17000174 RID: 372
        // (get) Token: 0x0600052B RID: 1323 RVA: 0x0002465F File Offset: 0x0002285F
        // (set) Token: 0x0600052A RID: 1322 RVA: 0x00024656 File Offset: 0x00022856
        public byte[] File { get; set; }
    }
}
