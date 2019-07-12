using System;
using Xamarin.Forms;

namespace RFID.Views
{
    // Token: 0x02000064 RID: 100
    public class BlackTextNavigationPage : NavigationPage
    {
        // Token: 0x06000252 RID: 594 RVA: 0x0000E742 File Offset: 0x0000C942
        public BlackTextNavigationPage()
        {
            base.BarBackgroundColor = Color.FromRgba(0, 0, 0, 204);
            base.BarTextColor = Color.White;
            App.CurNavigationPage = this;
        }

        // Token: 0x06000253 RID: 595 RVA: 0x0000E76E File Offset: 0x0000C96E
        public BlackTextNavigationPage(Page page) : base(page)
        {
            base.BarBackgroundColor = Color.FromRgba(0, 0, 0, 204);
            base.BarTextColor = Color.White;
            App.CurNavigationPage = this;
        }
    }
}
