using System;
using System.CodeDom.Compiler;
using System.Reflection;
using FFImageLoading.Forms;
using FFImageLoading.Svg.Forms;
using RFID.Layout;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Views
{
    // Token: 0x0200005D RID: 93
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Views\\LoginPage.xaml")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class LoginPage : ContentPage
    {
        // Token: 0x0600023C RID: 572 RVA: 0x0000A187 File Offset: 0x00008387
        public LoginPage()
        {
            this.InitializeComponent();
        }

        // Token: 0x0600023D RID: 573 RVA: 0x0000A198 File Offset: 0x00008398
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(LoginPage).GetTypeInfo().Assembly.GetName(), "Views/LoginPage.xaml") != null)
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
            TranslateExtension translateExtension2 = new TranslateExtension();
            BindingExtension bindingExtension = new BindingExtension();
            ToolbarItem toolbarItem = new ToolbarItem();
            RowDefinition rowDefinition = new RowDefinition();
            RowDefinition rowDefinition2 = new RowDefinition();
            RowDefinition rowDefinition3 = new RowDefinition();
            ColumnDefinition columnDefinition = new ColumnDefinition();
            ColumnDefinition columnDefinition2 = new ColumnDefinition();
            SvgCachedImage svgCachedImage = new SvgCachedImage();
            TranslateExtension translateExtension3 = new TranslateExtension();
            BindingExtension bindingExtension2 = new BindingExtension();
            NoBorderEntry noBorderEntry = new NoBorderEntry();
            Grid grid = new Grid();
            Frame frame = new Frame();
            ColumnDefinition columnDefinition3 = new ColumnDefinition();
            ColumnDefinition columnDefinition4 = new ColumnDefinition();
            SvgCachedImage svgCachedImage2 = new SvgCachedImage();
            TranslateExtension translateExtension4 = new TranslateExtension();
            BindingExtension bindingExtension3 = new BindingExtension();
            NoBorderEntry noBorderEntry2 = new NoBorderEntry();
            Grid grid2 = new Grid();
            Frame frame2 = new Frame();
            StackLayout stackLayout = new StackLayout();
            TranslateExtension translateExtension5 = new TranslateExtension();
            BindingExtension bindingExtension4 = new BindingExtension();
            Button button = new Button();
            StackLayout stackLayout2 = new StackLayout();
            Grid grid3 = new Grid();
            BindingExtension bindingExtension5 = new BindingExtension();
            BindingExtension bindingExtension6 = new BindingExtension();
            ActivityIndicator activityIndicator = new ActivityIndicator();
            Grid grid4 = new Grid();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(toolbarItem, nameScope);
            NameScope.SetNameScope(grid4, nameScope);
            NameScope.SetNameScope(grid3, nameScope);
            NameScope.SetNameScope(rowDefinition, nameScope);
            NameScope.SetNameScope(rowDefinition2, nameScope);
            NameScope.SetNameScope(rowDefinition3, nameScope);
            NameScope.SetNameScope(stackLayout, nameScope);
            NameScope.SetNameScope(frame, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(columnDefinition, nameScope);
            NameScope.SetNameScope(columnDefinition2, nameScope);
            NameScope.SetNameScope(svgCachedImage, nameScope);
            NameScope.SetNameScope(noBorderEntry, nameScope);
            NameScope.SetNameScope(frame2, nameScope);
            NameScope.SetNameScope(grid2, nameScope);
            NameScope.SetNameScope(columnDefinition3, nameScope);
            NameScope.SetNameScope(columnDefinition4, nameScope);
            NameScope.SetNameScope(svgCachedImage2, nameScope);
            NameScope.SetNameScope(noBorderEntry2, nameScope);
            NameScope.SetNameScope(stackLayout2, nameScope);
            NameScope.SetNameScope(button, nameScope);
            NameScope.SetNameScope(activityIndicator, nameScope);
            this.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            this.SetValue(Page.BackgroundImageProperty, "main_bg.png");
            translateExtension.Text = "login";
            IMarkupExtension markupExtension = translateExtension;
            XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
            Type typeFromHandle = typeof(IProvideValueTarget);
            object[] array = new object[0 + 1];
            array[0] = this;
            xamlServiceProvider.Add(typeFromHandle, new SimpleValueTargetProvider(array, Page.TitleProperty));
            xamlServiceProvider.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle2 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver = new XmlNamespaceResolver();
            xmlNamespaceResolver.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver.Add("local", "clr-namespace:RFID");
            xmlNamespaceResolver.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(LoginPage).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(10, 5)));
            object title = markupExtension.ProvideValue(xamlServiceProvider);
            this.Title = title;
            translateExtension2.Text = "server";
            IMarkupExtension markupExtension2 = translateExtension2;
            XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
            Type typeFromHandle3 = typeof(IProvideValueTarget);
            object[] array2 = new object[0 + 2];
            array2[0] = toolbarItem;
            array2[1] = this;
            xamlServiceProvider2.Add(typeFromHandle3, new SimpleValueTargetProvider(array2, MenuItem.TextProperty));
            xamlServiceProvider2.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle4 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver2 = new XmlNamespaceResolver();
            xmlNamespaceResolver2.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver2.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver2.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver2.Add("local", "clr-namespace:RFID");
            xmlNamespaceResolver2.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(LoginPage).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(12, 22)));
            object text = markupExtension2.ProvideValue(xamlServiceProvider2);
            toolbarItem.Text = text;
            toolbarItem.Order = ToolbarItemOrder.Primary;
            bindingExtension.Path = "ServerCommand";
            BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue(null);
            toolbarItem.SetBinding(MenuItem.CommandProperty, binding);
            this.ToolbarItems.Add(toolbarItem);
            rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid3.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition);
            rowDefinition2.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid3.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition2);
            rowDefinition3.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid3.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition3);
            stackLayout.SetValue(Grid.RowProperty, 1);
            stackLayout.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            stackLayout.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
            stackLayout.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 0.0));
            frame.SetValue(Frame.BorderColorProperty, Color.Black);
            frame.SetValue(Frame.CornerRadiusProperty, 10f);
            frame.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            frame.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(10.0, 0.0, 10.0, 0.0));
            frame.SetValue(Frame.HasShadowProperty, false);
            grid.SetValue(Grid.ColumnSpacingProperty, 10.0);
            columnDefinition.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("30"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition);
            columnDefinition2.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition2);
            svgCachedImage.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
            svgCachedImage.SetValue(CachedImage.AspectProperty, Aspect.AspectFit);
            svgCachedImage.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            svgCachedImage.SetValue(Grid.ColumnProperty, 0);
            svgCachedImage.SetValue(VisualElement.WidthRequestProperty, 24.0);
            svgCachedImage.SetValue(VisualElement.HeightRequestProperty, 24.0);
            svgCachedImage.SetValue(CachedImage.SourceProperty, new FFImageLoading.Forms.ImageSourceConverter().ConvertFromInvariantString("user.svg"));
            grid.Children.Add(svgCachedImage);
            translateExtension3.Text = "user";
            IMarkupExtension markupExtension3 = translateExtension3;
            XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider();
            Type typeFromHandle5 = typeof(IProvideValueTarget);
            object[] array3 = new object[0 + 7];
            array3[0] = noBorderEntry;
            array3[1] = grid;
            array3[2] = frame;
            array3[3] = stackLayout;
            array3[4] = grid3;
            array3[5] = grid4;
            array3[6] = this;
            xamlServiceProvider3.Add(typeFromHandle5, new SimpleValueTargetProvider(array3, Entry.PlaceholderProperty));
            xamlServiceProvider3.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle6 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver3 = new XmlNamespaceResolver();
            xmlNamespaceResolver3.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver3.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver3.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver3.Add("local", "clr-namespace:RFID");
            xmlNamespaceResolver3.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xamlServiceProvider3.Add(typeFromHandle6, new XamlTypeResolver(xmlNamespaceResolver3, typeof(LoginPage).GetTypeInfo().Assembly));
            xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(34, 51)));
            object placeholder = markupExtension3.ProvideValue(xamlServiceProvider3);
            noBorderEntry.Placeholder = placeholder;
            bindingExtension2.Mode = BindingMode.TwoWay;
            bindingExtension2.Path = "Username";
            BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue(null);
            noBorderEntry.SetBinding(Entry.TextProperty, binding2);
            BindableObject bindableObject = noBorderEntry;
            BindableProperty fontSizeProperty = Entry.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter = new FontSizeConverter();
            string value = "Default";
            XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider();
            Type typeFromHandle7 = typeof(IProvideValueTarget);
            object[] array4 = new object[0 + 7];
            array4[0] = noBorderEntry;
            array4[1] = grid;
            array4[2] = frame;
            array4[3] = stackLayout;
            array4[4] = grid3;
            array4[5] = grid4;
            array4[6] = this;
            xamlServiceProvider4.Add(typeFromHandle7, new SimpleValueTargetProvider(array4, Entry.FontSizeProperty));
            xamlServiceProvider4.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle8 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver4 = new XmlNamespaceResolver();
            xmlNamespaceResolver4.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver4.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver4.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver4.Add("local", "clr-namespace:RFID");
            xmlNamespaceResolver4.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xamlServiceProvider4.Add(typeFromHandle8, new XamlTypeResolver(xmlNamespaceResolver4, typeof(LoginPage).GetTypeInfo().Assembly));
            xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(34, 126)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider4));
            noBorderEntry.SetValue(Grid.ColumnProperty, 1);
            noBorderEntry.SetValue(Entry.TextColorProperty, Color.Black);
            grid.Children.Add(noBorderEntry);
            frame.SetValue(ContentView.ContentProperty, grid);
            stackLayout.Children.Add(frame);
            frame2.SetValue(Frame.BorderColorProperty, Color.Black);
            frame2.SetValue(Frame.CornerRadiusProperty, 10f);
            frame2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            frame2.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(10.0, 0.0, 10.0, 0.0));
            frame2.SetValue(Frame.HasShadowProperty, false);
            grid2.SetValue(Grid.ColumnSpacingProperty, 10.0);
            columnDefinition3.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("30"));
            grid2.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition3);
            columnDefinition4.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid2.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition4);
            svgCachedImage2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
            svgCachedImage2.SetValue(CachedImage.AspectProperty, Aspect.AspectFit);
            svgCachedImage2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            svgCachedImage2.SetValue(Grid.ColumnProperty, 0);
            svgCachedImage2.SetValue(VisualElement.WidthRequestProperty, 24.0);
            svgCachedImage2.SetValue(VisualElement.HeightRequestProperty, 24.0);
            svgCachedImage2.SetValue(CachedImage.SourceProperty, new FFImageLoading.Forms.ImageSourceConverter().ConvertFromInvariantString("lock.svg"));
            grid2.Children.Add(svgCachedImage2);
            translateExtension4.Text = "password";
            IMarkupExtension markupExtension4 = translateExtension4;
            XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider();
            Type typeFromHandle9 = typeof(IProvideValueTarget);
            object[] array5 = new object[0 + 7];
            array5[0] = noBorderEntry2;
            array5[1] = grid2;
            array5[2] = frame2;
            array5[3] = stackLayout;
            array5[4] = grid3;
            array5[5] = grid4;
            array5[6] = this;
            xamlServiceProvider5.Add(typeFromHandle9, new SimpleValueTargetProvider(array5, Entry.PlaceholderProperty));
            xamlServiceProvider5.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle10 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver5 = new XmlNamespaceResolver();
            xmlNamespaceResolver5.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver5.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver5.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver5.Add("local", "clr-namespace:RFID");
            xmlNamespaceResolver5.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xamlServiceProvider5.Add(typeFromHandle10, new XamlTypeResolver(xmlNamespaceResolver5, typeof(LoginPage).GetTypeInfo().Assembly));
            xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(46, 51)));
            object placeholder2 = markupExtension4.ProvideValue(xamlServiceProvider5);
            noBorderEntry2.Placeholder = placeholder2;
            bindingExtension3.Mode = BindingMode.TwoWay;
            bindingExtension3.Path = "Password";
            BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue(null);
            noBorderEntry2.SetBinding(Entry.TextProperty, binding3);
            BindableObject bindableObject2 = noBorderEntry2;
            BindableProperty fontSizeProperty2 = Entry.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter2 = new FontSizeConverter();
            string value2 = "Default";
            XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider();
            Type typeFromHandle11 = typeof(IProvideValueTarget);
            object[] array6 = new object[0 + 7];
            array6[0] = noBorderEntry2;
            array6[1] = grid2;
            array6[2] = frame2;
            array6[3] = stackLayout;
            array6[4] = grid3;
            array6[5] = grid4;
            array6[6] = this;
            xamlServiceProvider6.Add(typeFromHandle11, new SimpleValueTargetProvider(array6, Entry.FontSizeProperty));
            xamlServiceProvider6.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle12 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver6 = new XmlNamespaceResolver();
            xmlNamespaceResolver6.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver6.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver6.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver6.Add("local", "clr-namespace:RFID");
            xmlNamespaceResolver6.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xamlServiceProvider6.Add(typeFromHandle12, new XamlTypeResolver(xmlNamespaceResolver6, typeof(LoginPage).GetTypeInfo().Assembly));
            xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(46, 130)));
            bindableObject2.SetValue(fontSizeProperty2, extendedTypeConverter2.ConvertFromInvariantString(value2, xamlServiceProvider6));
            noBorderEntry2.SetValue(Grid.ColumnProperty, 1);
            noBorderEntry2.SetValue(Entry.TextColorProperty, Color.Black);
            noBorderEntry2.SetValue(Entry.IsPasswordProperty, true);
            grid2.Children.Add(noBorderEntry2);
            frame2.SetValue(ContentView.ContentProperty, grid2);
            stackLayout.Children.Add(frame2);
            grid3.Children.Add(stackLayout);
            stackLayout2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
            stackLayout2.SetValue(Grid.RowProperty, 2);
            stackLayout2.SetValue(StackLayout.SpacingProperty, 15.0);
            stackLayout2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 40.0));
            BindableObject bindableObject3 = button;
            BindableProperty fontSizeProperty3 = Button.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter3 = new FontSizeConverter();
            string value3 = "Medium";
            XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider();
            Type typeFromHandle13 = typeof(IProvideValueTarget);
            object[] array7 = new object[0 + 5];
            array7[0] = button;
            array7[1] = stackLayout2;
            array7[2] = grid3;
            array7[3] = grid4;
            array7[4] = this;
            xamlServiceProvider7.Add(typeFromHandle13, new SimpleValueTargetProvider(array7, Button.FontSizeProperty));
            xamlServiceProvider7.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle14 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver7 = new XmlNamespaceResolver();
            xmlNamespaceResolver7.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver7.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver7.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver7.Add("local", "clr-namespace:RFID");
            xmlNamespaceResolver7.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xamlServiceProvider7.Add(typeFromHandle14, new XamlTypeResolver(xmlNamespaceResolver7, typeof(LoginPage).GetTypeInfo().Assembly));
            xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(75, 32)));
            bindableObject3.SetValue(fontSizeProperty3, extendedTypeConverter3.ConvertFromInvariantString(value3, xamlServiceProvider7));
            button.SetValue(VisualElement.BackgroundColorProperty, Color.Black);
            button.SetValue(Button.TextColorProperty, Color.White);
            button.SetValue(Button.BorderColorProperty, Color.Black);
            button.SetValue(Button.BorderWidthProperty, 1.0);
            button.SetValue(Button.BorderRadiusProperty, 5);
            translateExtension5.Text = "login";
            IMarkupExtension markupExtension5 = translateExtension5;
            XamlServiceProvider xamlServiceProvider8 = new XamlServiceProvider();
            Type typeFromHandle15 = typeof(IProvideValueTarget);
            object[] array8 = new object[0 + 5];
            array8[0] = button;
            array8[1] = stackLayout2;
            array8[2] = grid3;
            array8[3] = grid4;
            array8[4] = this;
            xamlServiceProvider8.Add(typeFromHandle15, new SimpleValueTargetProvider(array8, Button.TextProperty));
            xamlServiceProvider8.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle16 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver8 = new XmlNamespaceResolver();
            xmlNamespaceResolver8.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver8.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver8.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver8.Add("local", "clr-namespace:RFID");
            xmlNamespaceResolver8.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xamlServiceProvider8.Add(typeFromHandle16, new XamlTypeResolver(xmlNamespaceResolver8, typeof(LoginPage).GetTypeInfo().Assembly));
            xamlServiceProvider8.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(75, 145)));
            object text2 = markupExtension5.ProvideValue(xamlServiceProvider8);
            button.Text = text2;
            bindingExtension4.Path = "LoginCommand";
            BindingBase binding4 = ((IMarkupExtension<BindingBase>)bindingExtension4).ProvideValue(null);
            button.SetBinding(Button.CommandProperty, binding4);
            stackLayout2.Children.Add(button);
            grid3.Children.Add(stackLayout2);
            grid4.Children.Add(grid3);
            activityIndicator.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            activityIndicator.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
            bindingExtension5.Path = "IsBusy";
            BindingBase binding5 = ((IMarkupExtension<BindingBase>)bindingExtension5).ProvideValue(null);
            activityIndicator.SetBinding(ActivityIndicator.IsRunningProperty, binding5);
            bindingExtension6.Path = "IsBusy";
            BindingBase binding6 = ((IMarkupExtension<BindingBase>)bindingExtension6).ProvideValue(null);
            activityIndicator.SetBinding(VisualElement.IsVisibleProperty, binding6);
            grid4.Children.Add(activityIndicator);
            this.SetValue(ContentPage.ContentProperty, grid4);
        }

        // Token: 0x0600023E RID: 574 RVA: 0x0000B412 File Offset: 0x00009612
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(LoginPage));
        }
    }
}
