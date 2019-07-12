using System;
using System.CodeDom.Compiler;
using System.Reflection;
using Prism.Mvvm;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Views
{
    // Token: 0x02000059 RID: 89
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Views\\HelpPage.xaml")]
    public class HelpPage : ContentPage
    {
        // Token: 0x0600022E RID: 558 RVA: 0x00008B2F File Offset: 0x00006D2F
        public HelpPage()
        {
            this.InitializeComponent();
        }

        // Token: 0x0600022F RID: 559 RVA: 0x00008B40 File Offset: 0x00006D40
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(HelpPage).GetTypeInfo().Assembly.GetName(), "Views/HelpPage.xaml") != null)
            {
                this.__InitComponentRuntime();
                return;
            }
            if (XamlLoader.XamlFileProvider != null && XamlLoader.XamlFileProvider(base.GetType()) != null)
            {
                this.__InitComponentRuntime();
                return;
            }
            NameScope value = new NameScope();
            NameScope.SetNameScope(this, value);
            this.SetValue(ViewModelLocator.AutowireViewModelProperty, new bool?(true));
        }

        // Token: 0x06000230 RID: 560 RVA: 0x00008BCD File Offset: 0x00006DCD
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(HelpPage));
        }
    }
}
