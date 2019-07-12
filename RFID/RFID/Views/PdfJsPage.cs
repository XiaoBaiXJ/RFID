using System;
using System.CodeDom.Compiler;
using System.Reflection;
using Prism.Mvvm;
using RFID.Layout;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Views
{
    // Token: 0x0200006E RID: 110
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Views\\PdfJsPage.xaml")]
    public class PdfJsPage : ContentPage
    {
        // Token: 0x0600026C RID: 620 RVA: 0x000139E8 File Offset: 0x00011BE8
        public PdfJsPage()
        {
            this.InitializeComponent();
        }

        // Token: 0x0600026D RID: 621 RVA: 0x000139F8 File Offset: 0x00011BF8
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(PdfJsPage).GetTypeInfo().Assembly.GetName(), "Views/PdfJsPage.xaml") != null)
            {
                this.__InitComponentRuntime();
                return;
            }
            if (XamlLoader.XamlFileProvider != null && XamlLoader.XamlFileProvider(base.GetType()) != null)
            {
                this.__InitComponentRuntime();
                return;
            }
            BindingExtension bindingExtension = new BindingExtension();
            BindingExtension bindingExtension2 = new BindingExtension();
            PdfWebView pdfWebView = new PdfWebView();
            Grid grid = new Grid();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(pdfWebView, nameScope);
            ((INameScope)nameScope).RegisterName("PdfView", pdfWebView);
            if (pdfWebView.StyleId == null)
            {
                pdfWebView.StyleId = "PdfView";
            }
            this.PdfView = pdfWebView;
            this.SetValue(ViewModelLocator.AutowireViewModelProperty, new bool?(true));
            bindingExtension.Path = "Title";
            BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue(null);
            this.SetBinding(Page.TitleProperty, binding);
            bindingExtension2.Path = "PdfSource";
            BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue(null);
            pdfWebView.SetBinding(WebView.SourceProperty, binding2);
            grid.Children.Add(pdfWebView);
            this.SetValue(ContentPage.ContentProperty, grid);
        }

        // Token: 0x0600026E RID: 622 RVA: 0x00013B36 File Offset: 0x00011D36
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(PdfJsPage));
            this.PdfView = this.FindByName("PdfView");
        }

        // Token: 0x0400014D RID: 333
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private PdfWebView PdfView;
    }
}
