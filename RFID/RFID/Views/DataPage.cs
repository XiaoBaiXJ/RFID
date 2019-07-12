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
    // Token: 0x02000054 RID: 84
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Views\\DataPage.xaml")]
    public class DataPage : ContentPage
    {
        // Token: 0x0600021F RID: 543 RVA: 0x00004910 File Offset: 0x00002B10
        public DataPage()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000220 RID: 544 RVA: 0x00004920 File Offset: 0x00002B20
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(DataPage).GetTypeInfo().Assembly.GetName(), "Views/DataPage.xaml") != null)
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
            RowDefinition rowDefinition = new RowDefinition();
            RowDefinition rowDefinition2 = new RowDefinition();
            RowDefinition rowDefinition3 = new RowDefinition();
            ColumnDefinition columnDefinition = new ColumnDefinition();
            ColumnDefinition columnDefinition2 = new ColumnDefinition();
            TranslateExtension translateExtension = new TranslateExtension();
            Label label = new Label();
            BindingExtension bindingExtension2 = new BindingExtension();
            Label label2 = new Label();
            Grid grid = new Grid();
            TranslateExtension translateExtension2 = new TranslateExtension();
            BindingExtension bindingExtension3 = new BindingExtension();
            NewEntryCell newEntryCell = new NewEntryCell();
            TranslateExtension translateExtension3 = new TranslateExtension();
            BindingExtension bindingExtension4 = new BindingExtension();
            NewEntryCell newEntryCell2 = new NewEntryCell();
            TranslateExtension translateExtension4 = new TranslateExtension();
            BindingExtension bindingExtension5 = new BindingExtension();
            NewEntryCell newEntryCell3 = new NewEntryCell();
            TranslateExtension translateExtension5 = new TranslateExtension();
            BindingExtension bindingExtension6 = new BindingExtension();
            TranslateExtension translateExtension6 = new TranslateExtension();
            NewEntryCell newEntryCell4 = new NewEntryCell();
            BindingExtension bindingExtension7 = new BindingExtension();
            TranslateExtension translateExtension7 = new TranslateExtension();
            TranslateExtension translateExtension8 = new TranslateExtension();
            QRCodeCell qrcodeCell = new QRCodeCell();
            TranslateExtension translateExtension9 = new TranslateExtension();
            BindingExtension bindingExtension8 = new BindingExtension();
            PhotoCell photoCell = new PhotoCell();
            TableSection tableSection = new TableSection();
            TableRoot tableRoot = new TableRoot();
            TableView tableView = new TableView();
            TranslateExtension translateExtension10 = new TranslateExtension();
            BindingExtension bindingExtension9 = new BindingExtension();
            Button button = new Button();
            Grid grid2 = new Grid();
            ScrollView scrollView = new ScrollView();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(scrollView, nameScope);
            NameScope.SetNameScope(grid2, nameScope);
            NameScope.SetNameScope(rowDefinition, nameScope);
            NameScope.SetNameScope(rowDefinition2, nameScope);
            NameScope.SetNameScope(rowDefinition3, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(columnDefinition, nameScope);
            NameScope.SetNameScope(columnDefinition2, nameScope);
            NameScope.SetNameScope(label, nameScope);
            NameScope.SetNameScope(label2, nameScope);
            NameScope.SetNameScope(tableView, nameScope);
            NameScope.SetNameScope(tableRoot, nameScope);
            NameScope.SetNameScope(tableSection, nameScope);
            NameScope.SetNameScope(newEntryCell, nameScope);
            NameScope.SetNameScope(newEntryCell2, nameScope);
            NameScope.SetNameScope(newEntryCell3, nameScope);
            NameScope.SetNameScope(newEntryCell4, nameScope);
            NameScope.SetNameScope(qrcodeCell, nameScope);
            NameScope.SetNameScope(photoCell, nameScope);
            ((INameScope)nameScope).RegisterName("photocell", photoCell);
            if (photoCell.StyleId == null)
            {
                photoCell.StyleId = "photocell";
            }
            NameScope.SetNameScope(button, nameScope);
            this.photocell = photoCell;
            this.SetValue(ViewModelLocator.AutowireViewModelProperty, new bool?(true));
            bindingExtension.Path = "Title";
            BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue(null);
            this.SetBinding(Page.TitleProperty, binding);
            grid2.SetValue(Grid.RowSpacingProperty, 0.0);
            rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid2.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition);
            rowDefinition2.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("480"));
            grid2.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition2);
            rowDefinition3.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid2.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition3);
            grid.SetValue(VisualElement.BackgroundColorProperty, new Color(0.92156863212585449, 0.92156863212585449, 0.92156863212585449, 1.0));
            grid.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(10.0, 10.0, 10.0, 10.0));
            columnDefinition.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition);
            columnDefinition2.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("3*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition2);
            label.SetValue(Grid.ColumnProperty, 0);
            translateExtension.Text = "curaddress";
            IMarkupExtension markupExtension = translateExtension;
            XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
            Type typeFromHandle = typeof(IProvideValueTarget);
            object[] array = new object[0 + 5];
            array[0] = label;
            array[1] = grid;
            array[2] = grid2;
            array[3] = scrollView;
            array[4] = this;
            xamlServiceProvider.Add(typeFromHandle, new SimpleValueTargetProvider(array, Label.TextProperty));
            xamlServiceProvider.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle2 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver = new XmlNamespaceResolver();
            xmlNamespaceResolver.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver.Add("local", "clr-namespace:RFID");
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(DataPage).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(22, 50)));
            object text = markupExtension.ProvideValue(xamlServiceProvider);
            label.Text = text;
            label.SetValue(Label.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
            BindableObject bindableObject = label;
            BindableProperty fontSizeProperty = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter = new FontSizeConverter();
            string value = "Default";
            XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
            Type typeFromHandle3 = typeof(IProvideValueTarget);
            object[] array2 = new object[0 + 5];
            array2[0] = label;
            array2[1] = grid;
            array2[2] = grid2;
            array2[3] = scrollView;
            array2[4] = this;
            xamlServiceProvider2.Add(typeFromHandle3, new SimpleValueTargetProvider(array2, Label.FontSizeProperty));
            xamlServiceProvider2.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle4 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver2 = new XmlNamespaceResolver();
            xmlNamespaceResolver2.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver2.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver2.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver2.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver2.Add("local", "clr-namespace:RFID");
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(DataPage).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(22, 106)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider2));
            label.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
            grid.Children.Add(label);
            label2.SetValue(Grid.ColumnProperty, 1);
            bindingExtension2.Path = "CurLocation";
            BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue(null);
            label2.SetBinding(Label.TextProperty, binding2);
            BindableObject bindableObject2 = label2;
            BindableProperty fontSizeProperty2 = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter2 = new FontSizeConverter();
            string value2 = "Default";
            XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider();
            Type typeFromHandle5 = typeof(IProvideValueTarget);
            object[] array3 = new object[0 + 5];
            array3[0] = label2;
            array3[1] = grid;
            array3[2] = grid2;
            array3[3] = scrollView;
            array3[4] = this;
            xamlServiceProvider3.Add(typeFromHandle5, new SimpleValueTargetProvider(array3, Label.FontSizeProperty));
            xamlServiceProvider3.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle6 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver3 = new XmlNamespaceResolver();
            xmlNamespaceResolver3.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver3.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver3.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver3.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver3.Add("local", "clr-namespace:RFID");
            xamlServiceProvider3.Add(typeFromHandle6, new XamlTypeResolver(xmlNamespaceResolver3, typeof(DataPage).GetTypeInfo().Assembly));
            xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(23, 77)));
            bindableObject2.SetValue(fontSizeProperty2, extendedTypeConverter2.ConvertFromInvariantString(value2, xamlServiceProvider3));
            label2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            grid.Children.Add(label2);
            grid2.Children.Add(grid);
            tableView.Intent = TableIntent.Form;
            tableView.SetValue(Grid.RowProperty, 1);
            tableView.SetValue(TableView.HasUnevenRowsProperty, true);
            tableView.SetValue(VisualElement.BackgroundColorProperty, new Color(0.9843137264251709, 0.9843137264251709, 0.9843137264251709, 1.0));
            translateExtension2.Text = "acar";
            IMarkupExtension markupExtension2 = translateExtension2;
            XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider();
            Type typeFromHandle7 = typeof(IProvideValueTarget);
            object[] array4 = new object[0 + 7];
            array4[0] = newEntryCell;
            array4[1] = tableSection;
            array4[2] = tableRoot;
            array4[3] = tableView;
            array4[4] = grid2;
            array4[5] = scrollView;
            array4[6] = this;
            xamlServiceProvider4.Add(typeFromHandle7, new SimpleValueTargetProvider(array4, NewEntryCell.TitleProperty));
            xamlServiceProvider4.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle8 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver4 = new XmlNamespaceResolver();
            xmlNamespaceResolver4.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver4.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver4.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver4.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver4.Add("local", "clr-namespace:RFID");
            xamlServiceProvider4.Add(typeFromHandle8, new XamlTypeResolver(xmlNamespaceResolver4, typeof(DataPage).GetTypeInfo().Assembly));
            xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(29, 52)));
            object title = markupExtension2.ProvideValue(xamlServiceProvider4);
            newEntryCell.Title = title;
            bindingExtension3.Path = "CarNo";
            BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue(null);
            newEntryCell.SetBinding(NewEntryCell.TextProperty, binding3);
            tableSection.Add(newEntryCell);
            translateExtension3.Text = "driver";
            IMarkupExtension markupExtension3 = translateExtension3;
            XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider();
            Type typeFromHandle9 = typeof(IProvideValueTarget);
            object[] array5 = new object[0 + 7];
            array5[0] = newEntryCell2;
            array5[1] = tableSection;
            array5[2] = tableRoot;
            array5[3] = tableView;
            array5[4] = grid2;
            array5[5] = scrollView;
            array5[6] = this;
            xamlServiceProvider5.Add(typeFromHandle9, new SimpleValueTargetProvider(array5, NewEntryCell.TitleProperty));
            xamlServiceProvider5.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle10 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver5 = new XmlNamespaceResolver();
            xmlNamespaceResolver5.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver5.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver5.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver5.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver5.Add("local", "clr-namespace:RFID");
            xamlServiceProvider5.Add(typeFromHandle10, new XamlTypeResolver(xmlNamespaceResolver5, typeof(DataPage).GetTypeInfo().Assembly));
            xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(30, 51)));
            object title2 = markupExtension3.ProvideValue(xamlServiceProvider5);
            newEntryCell2.Title = title2;
            bindingExtension4.Path = "Driver";
            BindingBase binding4 = ((IMarkupExtension<BindingBase>)bindingExtension4).ProvideValue(null);
            newEntryCell2.SetBinding(NewEntryCell.TextProperty, binding4);
            tableSection.Add(newEntryCell2);
            translateExtension4.Text = "place";
            IMarkupExtension markupExtension4 = translateExtension4;
            XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider();
            Type typeFromHandle11 = typeof(IProvideValueTarget);
            object[] array6 = new object[0 + 7];
            array6[0] = newEntryCell3;
            array6[1] = tableSection;
            array6[2] = tableRoot;
            array6[3] = tableView;
            array6[4] = grid2;
            array6[5] = scrollView;
            array6[6] = this;
            xamlServiceProvider6.Add(typeFromHandle11, new SimpleValueTargetProvider(array6, NewEntryCell.TitleProperty));
            xamlServiceProvider6.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle12 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver6 = new XmlNamespaceResolver();
            xmlNamespaceResolver6.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver6.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver6.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver6.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver6.Add("local", "clr-namespace:RFID");
            xamlServiceProvider6.Add(typeFromHandle12, new XamlTypeResolver(xmlNamespaceResolver6, typeof(DataPage).GetTypeInfo().Assembly));
            xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(31, 52)));
            object title3 = markupExtension4.ProvideValue(xamlServiceProvider6);
            newEntryCell3.Title = title3;
            bindingExtension5.Path = "Place";
            BindingBase binding5 = ((IMarkupExtension<BindingBase>)bindingExtension5).ProvideValue(null);
            newEntryCell3.SetBinding(NewEntryCell.TextProperty, binding5);
            tableSection.Add(newEntryCell3);
            translateExtension5.Text = "arrival";
            IMarkupExtension markupExtension5 = translateExtension5;
            XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider();
            Type typeFromHandle13 = typeof(IProvideValueTarget);
            object[] array7 = new object[0 + 7];
            array7[0] = newEntryCell4;
            array7[1] = tableSection;
            array7[2] = tableRoot;
            array7[3] = tableView;
            array7[4] = grid2;
            array7[5] = scrollView;
            array7[6] = this;
            xamlServiceProvider7.Add(typeFromHandle13, new SimpleValueTargetProvider(array7, NewEntryCell.TitleProperty));
            xamlServiceProvider7.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle14 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver7 = new XmlNamespaceResolver();
            xmlNamespaceResolver7.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver7.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver7.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver7.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver7.Add("local", "clr-namespace:RFID");
            xamlServiceProvider7.Add(typeFromHandle14, new XamlTypeResolver(xmlNamespaceResolver7, typeof(DataPage).GetTypeInfo().Assembly));
            xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(32, 54)));
            object title4 = markupExtension5.ProvideValue(xamlServiceProvider7);
            newEntryCell4.Title = title4;
            bindingExtension6.Path = "Arrival";
            BindingBase binding6 = ((IMarkupExtension<BindingBase>)bindingExtension6).ProvideValue(null);
            newEntryCell4.SetBinding(NewEntryCell.TextProperty, binding6);
            translateExtension6.Text = "arrivalhint";
            IMarkupExtension markupExtension6 = translateExtension6;
            XamlServiceProvider xamlServiceProvider8 = new XamlServiceProvider();
            Type typeFromHandle15 = typeof(IProvideValueTarget);
            object[] array8 = new object[0 + 7];
            array8[0] = newEntryCell4;
            array8[1] = tableSection;
            array8[2] = tableRoot;
            array8[3] = tableView;
            array8[4] = grid2;
            array8[5] = scrollView;
            array8[6] = this;
            xamlServiceProvider8.Add(typeFromHandle15, new SimpleValueTargetProvider(array8, NewEntryCell.HintProperty));
            xamlServiceProvider8.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle16 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver8 = new XmlNamespaceResolver();
            xmlNamespaceResolver8.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver8.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver8.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver8.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver8.Add("local", "clr-namespace:RFID");
            xamlServiceProvider8.Add(typeFromHandle16, new XamlTypeResolver(xmlNamespaceResolver8, typeof(DataPage).GetTypeInfo().Assembly));
            xamlServiceProvider8.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(32, 113)));
            object hint = markupExtension6.ProvideValue(xamlServiceProvider8);
            newEntryCell4.Hint = hint;
            tableSection.Add(newEntryCell4);
            bindingExtension7.Path = "QianfengNo";
            BindingBase binding7 = ((IMarkupExtension<BindingBase>)bindingExtension7).ProvideValue(null);
            qrcodeCell.SetBinding(QRCodeCell.TextProperty, binding7);
            translateExtension7.Text = "qianfengno";
            IMarkupExtension markupExtension7 = translateExtension7;
            XamlServiceProvider xamlServiceProvider9 = new XamlServiceProvider();
            Type typeFromHandle17 = typeof(IProvideValueTarget);
            object[] array9 = new object[0 + 7];
            array9[0] = qrcodeCell;
            array9[1] = tableSection;
            array9[2] = tableRoot;
            array9[3] = tableView;
            array9[4] = grid2;
            array9[5] = scrollView;
            array9[6] = this;
            xamlServiceProvider9.Add(typeFromHandle17, new SimpleValueTargetProvider(array9, QRCodeCell.TitleProperty));
            xamlServiceProvider9.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle18 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver9 = new XmlNamespaceResolver();
            xmlNamespaceResolver9.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver9.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver9.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver9.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver9.Add("local", "clr-namespace:RFID");
            xamlServiceProvider9.Add(typeFromHandle18, new XamlTypeResolver(xmlNamespaceResolver9, typeof(DataPage).GetTypeInfo().Assembly));
            xamlServiceProvider9.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(33, 80)));
            object title5 = markupExtension7.ProvideValue(xamlServiceProvider9);
            qrcodeCell.Title = title5;
            translateExtension8.Text = "qrcodehint";
            IMarkupExtension markupExtension8 = translateExtension8;
            XamlServiceProvider xamlServiceProvider10 = new XamlServiceProvider();
            Type typeFromHandle19 = typeof(IProvideValueTarget);
            object[] array10 = new object[0 + 7];
            array10[0] = qrcodeCell;
            array10[1] = tableSection;
            array10[2] = tableRoot;
            array10[3] = tableView;
            array10[4] = grid2;
            array10[5] = scrollView;
            array10[6] = this;
            xamlServiceProvider10.Add(typeFromHandle19, new SimpleValueTargetProvider(array10, QRCodeCell.HintProperty));
            xamlServiceProvider10.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle20 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver10 = new XmlNamespaceResolver();
            xmlNamespaceResolver10.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver10.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver10.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver10.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver10.Add("local", "clr-namespace:RFID");
            xamlServiceProvider10.Add(typeFromHandle20, new XamlTypeResolver(xmlNamespaceResolver10, typeof(DataPage).GetTypeInfo().Assembly));
            xamlServiceProvider10.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(33, 117)));
            object hint2 = markupExtension8.ProvideValue(xamlServiceProvider10);
            qrcodeCell.Hint = hint2;
            qrcodeCell.SetValue(Cell.IsEnabledProperty, true);
            tableSection.Add(qrcodeCell);
            translateExtension9.Text = "qianfengphoto";
            IMarkupExtension markupExtension9 = translateExtension9;
            XamlServiceProvider xamlServiceProvider11 = new XamlServiceProvider();
            Type typeFromHandle21 = typeof(IProvideValueTarget);
            object[] array11 = new object[0 + 7];
            array11[0] = photoCell;
            array11[1] = tableSection;
            array11[2] = tableRoot;
            array11[3] = tableView;
            array11[4] = grid2;
            array11[5] = scrollView;
            array11[6] = this;
            xamlServiceProvider11.Add(typeFromHandle21, new SimpleValueTargetProvider(array11, PhotoCell.TitleProperty));
            xamlServiceProvider11.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle22 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver11 = new XmlNamespaceResolver();
            xmlNamespaceResolver11.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver11.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver11.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver11.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver11.Add("local", "clr-namespace:RFID");
            xamlServiceProvider11.Add(typeFromHandle22, new XamlTypeResolver(xmlNamespaceResolver11, typeof(DataPage).GetTypeInfo().Assembly));
            xamlServiceProvider11.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(34, 70)));
            object title6 = markupExtension9.ProvideValue(xamlServiceProvider11);
            photoCell.Title = title6;
            bindingExtension8.Path = "ImageFiles";
            BindingBase binding8 = ((IMarkupExtension<BindingBase>)bindingExtension8).ProvideValue(null);
            photoCell.SetBinding(PhotoCell.FilesProperty, binding8);
            photoCell.SetValue(PhotoCell.CanTakeMoreProperty, false);
            tableSection.Add(photoCell);
            tableRoot.Add(tableSection);
            tableView.Root = tableRoot;
            grid2.Children.Add(tableView);
            button.SetValue(View.MarginProperty, new Thickness(20.0));
            button.SetValue(Grid.RowProperty, 2);
            translateExtension10.Text = "shifeng";
            IMarkupExtension markupExtension10 = translateExtension10;
            XamlServiceProvider xamlServiceProvider12 = new XamlServiceProvider();
            Type typeFromHandle23 = typeof(IProvideValueTarget);
            object[] array12 = new object[0 + 4];
            array12[0] = button;
            array12[1] = grid2;
            array12[2] = scrollView;
            array12[3] = this;
            xamlServiceProvider12.Add(typeFromHandle23, new SimpleValueTargetProvider(array12, Button.TextProperty));
            xamlServiceProvider12.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle24 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver12 = new XmlNamespaceResolver();
            xmlNamespaceResolver12.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver12.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver12.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver12.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver12.Add("local", "clr-namespace:RFID");
            xamlServiceProvider12.Add(typeFromHandle24, new XamlTypeResolver(xmlNamespaceResolver12, typeof(DataPage).GetTypeInfo().Assembly));
            xamlServiceProvider12.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(40, 51)));
            object text2 = markupExtension10.ProvideValue(xamlServiceProvider12);
            button.Text = text2;
            bindingExtension9.Path = "CommitCommand";
            BindingBase binding9 = ((IMarkupExtension<BindingBase>)bindingExtension9).ProvideValue(null);
            button.SetBinding(Button.CommandProperty, binding9);
            button.SetValue(Button.TextColorProperty, Color.White);
            button.SetValue(VisualElement.BackgroundColorProperty, new Color(0.050980392843484879, 0.27843138575553894, 0.63137257099151611, 1.0));
            button.SetValue(Button.BorderRadiusProperty, 10);
            button.SetValue(Button.BorderColorProperty, new Color(0.050980392843484879, 0.27843138575553894, 0.63137257099151611, 1.0));
            button.SetValue(Button.BorderWidthProperty, 1.0);
            grid2.Children.Add(button);
            scrollView.Content = grid2;
            this.SetValue(ContentPage.ContentProperty, scrollView);
        }

        // Token: 0x06000221 RID: 545 RVA: 0x00005E8D File Offset: 0x0000408D
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(DataPage));
            this.photocell = this.FindByName("photocell");
        }

        // Token: 0x04000128 RID: 296
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private PhotoCell photocell;
    }
}
