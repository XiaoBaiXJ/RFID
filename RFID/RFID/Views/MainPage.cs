using System;
using System.CodeDom.Compiler;
using System.Reflection;
using RFID.Layout;
using RFID.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Views
{
    // Token: 0x0200005C RID: 92
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Views\\MainPage.xaml")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class MainPage : ContentPage
    {
        // Token: 0x06000237 RID: 567 RVA: 0x000093B3 File Offset: 0x000075B3
        public MainPage()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000238 RID: 568 RVA: 0x000093C4 File Offset: 0x000075C4
        protected override void OnAppearing()
        {
            base.OnAppearing();
            IPageAppearing pageAppearing = base.BindingContext as IPageAppearing;
            pageAppearing.OnAppearing();
        }

        // Token: 0x06000239 RID: 569 RVA: 0x000093EC File Offset: 0x000075EC
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            IPageAppearing pageAppearing = base.BindingContext as IPageAppearing;
            pageAppearing.OnDisappearing();
        }

        // Token: 0x0600023A RID: 570 RVA: 0x00009414 File Offset: 0x00007614
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(MainPage).GetTypeInfo().Assembly.GetName(), "Views/MainPage.xaml") != null)
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
            RowDefinition rowDefinition = new RowDefinition();
            RowDefinition rowDefinition2 = new RowDefinition();
            RowDefinition rowDefinition3 = new RowDefinition();
            RowDefinition rowDefinition4 = new RowDefinition();
            ColumnDefinition columnDefinition = new ColumnDefinition();
            ColumnDefinition columnDefinition2 = new ColumnDefinition();
            Image image = new Image();
            TranslateExtension translateExtension = new TranslateExtension();
            BindingExtension bindingExtension3 = new BindingExtension();
            FuncView funcView = new FuncView();
            TranslateExtension translateExtension2 = new TranslateExtension();
            BindingExtension bindingExtension4 = new BindingExtension();
            FuncView funcView2 = new FuncView();
            TranslateExtension translateExtension3 = new TranslateExtension();
            BindingExtension bindingExtension5 = new BindingExtension();
            FuncView funcView3 = new FuncView();
            TranslateExtension translateExtension4 = new TranslateExtension();
            BindingExtension bindingExtension6 = new BindingExtension();
            FuncView funcView4 = new FuncView();
            BindingExtension bindingExtension7 = new BindingExtension();
            BindingExtension bindingExtension8 = new BindingExtension();
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            Label label = new Label();
            Grid grid = new Grid();
            Grid grid2 = new Grid();
            BindingExtension bindingExtension9 = new BindingExtension();
            BindingExtension bindingExtension10 = new BindingExtension();
            ActivityIndicator activityIndicator = new ActivityIndicator();
            Grid grid3 = new Grid();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(grid3, nameScope);
            NameScope.SetNameScope(grid2, nameScope);
            NameScope.SetNameScope(rowDefinition, nameScope);
            NameScope.SetNameScope(rowDefinition2, nameScope);
            NameScope.SetNameScope(rowDefinition3, nameScope);
            NameScope.SetNameScope(rowDefinition4, nameScope);
            NameScope.SetNameScope(columnDefinition, nameScope);
            NameScope.SetNameScope(columnDefinition2, nameScope);
            NameScope.SetNameScope(image, nameScope);
            NameScope.SetNameScope(funcView, nameScope);
            NameScope.SetNameScope(funcView2, nameScope);
            NameScope.SetNameScope(funcView3, nameScope);
            NameScope.SetNameScope(funcView4, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(label, nameScope);
            NameScope.SetNameScope(tapGestureRecognizer, nameScope);
            NameScope.SetNameScope(activityIndicator, nameScope);
            bindingExtension.Path = "Title";
            BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue(null);
            this.SetBinding(Page.TitleProperty, binding);
            bindingExtension2.Path = "HasTitle";
            BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue(null);
            this.SetBinding(NavigationPage.HasNavigationBarProperty, binding2);
            grid3.SetValue(VisualElement.BackgroundColorProperty, new Color(0.98039215803146362, 0.98039215803146362, 0.98039215803146362, 1.0));
            grid2.SetValue(Grid.RowSpacingProperty, 1.0);
            grid2.SetValue(Grid.ColumnSpacingProperty, 1.0);
            rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid2.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition);
            rowDefinition2.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid2.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition2);
            rowDefinition3.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid2.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition3);
            rowDefinition4.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid2.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition4);
            columnDefinition.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid2.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition);
            columnDefinition2.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid2.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition2);
            image.SetValue(Image.SourceProperty, new ImageSourceConverter().ConvertFromInvariantString("login_bg2.png"));
            image.SetValue(Grid.RowProperty, 0);
            image.SetValue(Grid.ColumnProperty, 0);
            image.SetValue(Grid.ColumnSpanProperty, 2);
            image.SetValue(Image.AspectProperty, Aspect.AspectFill);
            image.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            grid2.Children.Add(image);
            funcView.SetValue(Grid.RowProperty, 1);
            funcView.SetValue(Grid.ColumnProperty, 0);
            funcView.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            translateExtension.Text = "read";
            IMarkupExtension markupExtension = translateExtension;
            XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
            Type typeFromHandle = typeof(IProvideValueTarget);
            object[] array = new object[0 + 4];
            array[0] = funcView;
            array[1] = grid2;
            array[2] = grid3;
            array[3] = this;
            xamlServiceProvider.Add(typeFromHandle, new SimpleValueTargetProvider(array, FuncView.TitleProperty));
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
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(MainPage).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(43, 87)));
            object title = markupExtension.ProvideValue(xamlServiceProvider);
            funcView.Title = title;
            funcView.SetValue(FuncView.IconProperty, "read.svg");
            bindingExtension3.Path = "ReadCommand";
            BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue(null);
            funcView.SetBinding(FuncView.CommandProperty, binding3);
            grid2.Children.Add(funcView);
            funcView2.SetValue(Grid.RowProperty, 1);
            funcView2.SetValue(Grid.ColumnProperty, 1);
            funcView2.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            translateExtension2.Text = "upload";
            IMarkupExtension markupExtension2 = translateExtension2;
            XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
            Type typeFromHandle3 = typeof(IProvideValueTarget);
            object[] array2 = new object[0 + 4];
            array2[0] = funcView2;
            array2[1] = grid2;
            array2[2] = grid3;
            array2[3] = this;
            xamlServiceProvider2.Add(typeFromHandle3, new SimpleValueTargetProvider(array2, FuncView.TitleProperty));
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
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(MainPage).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(44, 88)));
            object title2 = markupExtension2.ProvideValue(xamlServiceProvider2);
            funcView2.Title = title2;
            funcView2.SetValue(FuncView.IconProperty, "upload.svg");
            bindingExtension4.Path = "UploadCommand";
            BindingBase binding4 = ((IMarkupExtension<BindingBase>)bindingExtension4).ProvideValue(null);
            funcView2.SetBinding(FuncView.CommandProperty, binding4);
            grid2.Children.Add(funcView2);
            funcView3.SetValue(Grid.RowProperty, 2);
            funcView3.SetValue(Grid.ColumnProperty, 0);
            funcView3.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            translateExtension3.Text = "delete";
            IMarkupExtension markupExtension3 = translateExtension3;
            XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider();
            Type typeFromHandle5 = typeof(IProvideValueTarget);
            object[] array3 = new object[0 + 4];
            array3[0] = funcView3;
            array3[1] = grid2;
            array3[2] = grid3;
            array3[3] = this;
            xamlServiceProvider3.Add(typeFromHandle5, new SimpleValueTargetProvider(array3, FuncView.TitleProperty));
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
            xamlServiceProvider3.Add(typeFromHandle6, new XamlTypeResolver(xmlNamespaceResolver3, typeof(MainPage).GetTypeInfo().Assembly));
            xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(45, 88)));
            object title3 = markupExtension3.ProvideValue(xamlServiceProvider3);
            funcView3.Title = title3;
            funcView3.SetValue(FuncView.IconProperty, "delete.svg");
            bindingExtension5.Path = "DeleteCommand";
            BindingBase binding5 = ((IMarkupExtension<BindingBase>)bindingExtension5).ProvideValue(null);
            funcView3.SetBinding(FuncView.CommandProperty, binding5);
            grid2.Children.Add(funcView3);
            funcView4.SetValue(Grid.RowProperty, 2);
            funcView4.SetValue(Grid.ColumnProperty, 1);
            funcView4.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            translateExtension4.Text = "exception";
            IMarkupExtension markupExtension4 = translateExtension4;
            XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider();
            Type typeFromHandle7 = typeof(IProvideValueTarget);
            object[] array4 = new object[0 + 4];
            array4[0] = funcView4;
            array4[1] = grid2;
            array4[2] = grid3;
            array4[3] = this;
            xamlServiceProvider4.Add(typeFromHandle7, new SimpleValueTargetProvider(array4, FuncView.TitleProperty));
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
            xamlServiceProvider4.Add(typeFromHandle8, new XamlTypeResolver(xmlNamespaceResolver4, typeof(MainPage).GetTypeInfo().Assembly));
            xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(46, 88)));
            object title4 = markupExtension4.ProvideValue(xamlServiceProvider4);
            funcView4.Title = title4;
            funcView4.SetValue(FuncView.IconProperty, "exception.svg");
            bindingExtension6.Path = "ExceptionCommand";
            BindingBase binding6 = ((IMarkupExtension<BindingBase>)bindingExtension6).ProvideValue(null);
            funcView4.SetBinding(FuncView.CommandProperty, binding6);
            grid2.Children.Add(funcView4);
            grid.SetValue(Grid.RowProperty, 3);
            grid.SetValue(Grid.ColumnProperty, 0);
            grid.SetValue(Grid.ColumnSpanProperty, 2);
            grid.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            grid.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            grid.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
            label.SetValue(VisualElement.HeightRequestProperty, 80.0);
            label.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            label.SetValue(Label.TextColorProperty, Color.Black);
            BindableObject bindableObject = label;
            BindableProperty fontSizeProperty = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter = new FontSizeConverter();
            string value = "Default";
            XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider();
            Type typeFromHandle9 = typeof(IProvideValueTarget);
            object[] array5 = new object[0 + 5];
            array5[0] = label;
            array5[1] = grid;
            array5[2] = grid2;
            array5[3] = grid3;
            array5[4] = this;
            xamlServiceProvider5.Add(typeFromHandle9, new SimpleValueTargetProvider(array5, Label.FontSizeProperty));
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
            xamlServiceProvider5.Add(typeFromHandle10, new XamlTypeResolver(xmlNamespaceResolver5, typeof(MainPage).GetTypeInfo().Assembly));
            xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(48, 89)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider5));
            label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
            label.SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
            label.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
            label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            bindingExtension7.Path = "ScanModeText";
            BindingBase binding7 = ((IMarkupExtension<BindingBase>)bindingExtension7).ProvideValue(null);
            label.SetBinding(Label.TextProperty, binding7);
            bindingExtension8.Path = "ScanModeCommand";
            BindingBase binding8 = ((IMarkupExtension<BindingBase>)bindingExtension8).ProvideValue(null);
            tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, binding8);
            label.GestureRecognizers.Add(tapGestureRecognizer);
            grid.Children.Add(label);
            grid2.Children.Add(grid);
            grid3.Children.Add(grid2);
            bindingExtension9.Path = "IsBusy";
            BindingBase binding9 = ((IMarkupExtension<BindingBase>)bindingExtension9).ProvideValue(null);
            activityIndicator.SetBinding(ActivityIndicator.IsRunningProperty, binding9);
            bindingExtension10.Path = "IsBusy";
            BindingBase binding10 = ((IMarkupExtension<BindingBase>)bindingExtension10).ProvideValue(null);
            activityIndicator.SetBinding(VisualElement.IsVisibleProperty, binding10);
            activityIndicator.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            activityIndicator.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
            grid3.Children.Add(activityIndicator);
            this.SetValue(ContentPage.ContentProperty, grid3);
        }

        // Token: 0x0600023B RID: 571 RVA: 0x0000A174 File Offset: 0x00008374
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(MainPage));
        }
    }
}
    