using System;
using RFID.ViewModels;
using ZXing.Net.Mobile.Forms;

namespace RFID.Views
{
    // Token: 0x02000068 RID: 104
    public class ScanPage : ZXingScannerPage
    {
        // Token: 0x0600025D RID: 605 RVA: 0x00011B64 File Offset: 0x0000FD64
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ScanPageViewModel scanPageViewModel = base.BindingContext as ScanPageViewModel;
            base.OnScanResult += scanPageViewModel.OnResultScan;
        }

        // Token: 0x0600025E RID: 606 RVA: 0x00011B8F File Offset: 0x0000FD8F
        public ScanPage() : base(null, null)
        {
        }
    }
}
