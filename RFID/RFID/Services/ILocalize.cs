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
    public interface ILocalize
    {
        // Token: 0x0600046D RID: 1133
        CultureInfo GetCurrentCultureInfo();

        // Token: 0x0600046E RID: 1134
        void SetLocale(CultureInfo ci);
    }
}