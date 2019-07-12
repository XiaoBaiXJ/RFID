using System;
using Xamarin.Forms;

namespace RFID.Views
{
    // Token: 0x0200005E RID: 94
    public class UhfPage : ContentPage
    {
        // Token: 0x0600023F RID: 575 RVA: 0x0000B425 File Offset: 0x00009625
        protected override bool OnBackButtonPressed()
        {
            AppManager.Instance.ClearMaskSetting();
            return base.OnBackButtonPressed();
        }
    }
}
