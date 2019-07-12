using System;
using System.CodeDom.Compiler;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Views
{
    // Token: 0x0200005F RID: 95
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Views\\HomePage.xaml")]
    public class HomePage : Xamarin.Forms.TabbedPage
    {
        // Token: 0x06000241 RID: 577 RVA: 0x0000B43F File Offset: 0x0000963F
        public HomePage()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000242 RID: 578 RVA: 0x0000B44D File Offset: 0x0000964D
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        // Token: 0x06000243 RID: 579 RVA: 0x0000B450 File Offset: 0x00009650
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(HomePage).GetTypeInfo().Assembly.GetName(), "Views/HomePage.xaml") != null)
            {
                this.__InitComponentRuntime();
                return;
            }
            if (XamlLoader.XamlFileProvider != null && XamlLoader.XamlFileProvider(base.GetType()) != null)
            {
                this.__InitComponentRuntime();
                return;
            }
            TranslateExtension translateExtension = new TranslateExtension();
            MainPage mainPage = new MainPage();
            TranslateExtension translateExtension2 = new TranslateExtension();
            QueryPage queryPage = new QueryPage();
            TranslateExtension translateExtension3 = new TranslateExtension();
            MinePage minePage = new MinePage();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(mainPage, nameScope);
            NameScope.SetNameScope(queryPage, nameScope);
            NameScope.SetNameScope(minePage, nameScope);
            this.SetValue(Xamarin.Forms.TabbedPage.BarBackgroundColorProperty, Color.White);
            this.SetValue(NavigationPage.HasNavigationBarProperty, false);
            this.SetValue(NavigationPage.HasBackButtonProperty, false);
            this.SetValue(Xamarin.Forms.PlatformConfiguration.AndroidSpecific.TabbedPage.ToolbarPlacementProperty, ToolbarPlacement.Bottom);
            this.SetValue(Xamarin.Forms.PlatformConfiguration.AndroidSpecific.TabbedPage.BarItemColorProperty, new Color(0.572549045085907, 0.572549045085907, 0.572549045085907, 1.0));
            this.SetValue(Xamarin.Forms.PlatformConfiguration.AndroidSpecific.TabbedPage.BarSelectedItemColorProperty, new Color(0.0, 0.0, 0.0, 1.0));
            mainPage.SetValue(Page.IconProperty, new FileImageSourceConverter().ConvertFromInvariantString("home.png"));
            translateExtension.Text = "home";
            IMarkupExtension markupExtension = translateExtension;
            XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
            Type typeFromHandle = typeof(IProvideValueTarget);
            object[] array = new object[0 + 2];
            array[0] = mainPage;
            array[1] = this;
            xamlServiceProvider.Add(typeFromHandle, new SimpleValueTargetProvider(array, Page.TitleProperty));
            xamlServiceProvider.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle2 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver = new XmlNamespaceResolver();
            xmlNamespaceResolver.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver.Add("views", "clr-namespace:RFID.Views");
            xmlNamespaceResolver.Add("local", "clr-namespace:RFID");
            xmlNamespaceResolver.Add("android", "clr-namespace:Xamarin.Forms.PlatformConfiguration.AndroidSpecific;assembly=Xamarin.Forms.Core");
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(HomePage).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(31, 43)));
            object title = markupExtension.ProvideValue(xamlServiceProvider);
            mainPage.Title = title;
            this.Children.Add(mainPage);
            queryPage.SetValue(Page.IconProperty, new FileImageSourceConverter().ConvertFromInvariantString("query.png"));
            translateExtension2.Text = "query";
            IMarkupExtension markupExtension2 = translateExtension2;
            XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
            Type typeFromHandle3 = typeof(IProvideValueTarget);
            object[] array2 = new object[0 + 2];
            array2[0] = queryPage;
            array2[1] = this;
            xamlServiceProvider2.Add(typeFromHandle3, new SimpleValueTargetProvider(array2, Page.TitleProperty));
            xamlServiceProvider2.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle4 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver2 = new XmlNamespaceResolver();
            xmlNamespaceResolver2.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver2.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver2.Add("views", "clr-namespace:RFID.Views");
            xmlNamespaceResolver2.Add("local", "clr-namespace:RFID");
            xmlNamespaceResolver2.Add("android", "clr-namespace:Xamarin.Forms.PlatformConfiguration.AndroidSpecific;assembly=Xamarin.Forms.Core");
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(HomePage).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(32, 43)));
            object title2 = markupExtension2.ProvideValue(xamlServiceProvider2);
            queryPage.Title = title2;
            this.Children.Add(queryPage);
            minePage.SetValue(Page.IconProperty, new FileImageSourceConverter().ConvertFromInvariantString("mine.png"));
            translateExtension3.Text = "mine";
            IMarkupExtension markupExtension3 = translateExtension3;
            XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider();
            Type typeFromHandle5 = typeof(IProvideValueTarget);
            object[] array3 = new object[0 + 2];
            array3[0] = minePage;
            array3[1] = this;
            xamlServiceProvider3.Add(typeFromHandle5, new SimpleValueTargetProvider(array3, Page.TitleProperty));
            xamlServiceProvider3.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle6 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver3 = new XmlNamespaceResolver();
            xmlNamespaceResolver3.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver3.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver3.Add("views", "clr-namespace:RFID.Views");
            xmlNamespaceResolver3.Add("local", "clr-namespace:RFID");
            xmlNamespaceResolver3.Add("android", "clr-namespace:Xamarin.Forms.PlatformConfiguration.AndroidSpecific;assembly=Xamarin.Forms.Core");
            xamlServiceProvider3.Add(typeFromHandle6, new XamlTypeResolver(xmlNamespaceResolver3, typeof(HomePage).GetTypeInfo().Assembly));
            xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(33, 41)));
            object title3 = markupExtension3.ProvideValue(xamlServiceProvider3);
            minePage.Title = title3;
            this.Children.Add(minePage);
        }

        // Token: 0x06000244 RID: 580 RVA: 0x0000B951 File Offset: 0x00009B51
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(HomePage));
        }
    }
}
