using System;
using System.CodeDom.Compiler;
using System.Reflection;
using RFID.Common;
using RFID.Layout;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Views
{
    // Token: 0x02000065 RID: 101
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Views\\LockPage.xaml")]
    public class LockPage : ContentPage
    {
        // Token: 0x06000254 RID: 596 RVA: 0x0000E79C File Offset: 0x0000C99C
        public LockPage()
        {
            this.InitializeComponent();
            if (!BasicData.AppConfiguration.eIsUseCarrier)
            {
                this.tableView.Root[0].Remove(this.driverCell);
            }
            if (!BasicData.AppConfiguration.eIsUseDestination)
            {
                this.tableView.Root[0].Remove(this.arrivalCell);
            }
        }

        // Token: 0x06000255 RID: 597 RVA: 0x0000E808 File Offset: 0x0000CA08
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(LockPage).GetTypeInfo().Assembly.GetName(), "Views/LockPage.xaml") != null)
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
            BindingExtension bindingExtension4 = new BindingExtension();
            SelectCell selectCell = new SelectCell();
            BindingExtension bindingExtension5 = new BindingExtension();
            TranslateExtension translateExtension3 = new TranslateExtension();
            BindingExtension bindingExtension6 = new BindingExtension();
            BindingExtension bindingExtension7 = new BindingExtension();
            SelectCell selectCell2 = new SelectCell();
            TranslateExtension translateExtension4 = new TranslateExtension();
            BindingExtension bindingExtension8 = new BindingExtension();
            BindingExtension bindingExtension9 = new BindingExtension();
            SelectCell selectCell3 = new SelectCell();
            BindingExtension bindingExtension10 = new BindingExtension();
            TranslateExtension translateExtension5 = new TranslateExtension();
            BindingExtension bindingExtension11 = new BindingExtension();
            TranslateExtension translateExtension6 = new TranslateExtension();
            NewEntryCell newEntryCell = new NewEntryCell();
            BindingExtension bindingExtension12 = new BindingExtension();
            TranslateExtension translateExtension7 = new TranslateExtension();
            TranslateExtension translateExtension8 = new TranslateExtension();
            QRCodeCell qrcodeCell = new QRCodeCell();
            TranslateExtension translateExtension9 = new TranslateExtension();
            BindingExtension bindingExtension13 = new BindingExtension();
            PhotoCell photoCell = new PhotoCell();
            TableSection tableSection = new TableSection();
            TableRoot tableRoot = new TableRoot();
            TableView tableView = new TableView();
            TranslateExtension translateExtension10 = new TranslateExtension();
            BindingExtension bindingExtension14 = new BindingExtension();
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
            ((INameScope)nameScope).RegisterName("tableView", tableView);
            if (tableView.StyleId == null)
            {
                tableView.StyleId = "tableView";
            }
            NameScope.SetNameScope(tableRoot, nameScope);
            NameScope.SetNameScope(tableSection, nameScope);
            NameScope.SetNameScope(selectCell, nameScope);
            ((INameScope)nameScope).RegisterName("carCell", selectCell);
            if (selectCell.StyleId == null)
            {
                selectCell.StyleId = "carCell";
            }
            NameScope.SetNameScope(selectCell2, nameScope);
            ((INameScope)nameScope).RegisterName("driverCell", selectCell2);
            if (selectCell2.StyleId == null)
            {
                selectCell2.StyleId = "driverCell";
            }
            NameScope.SetNameScope(selectCell3, nameScope);
            ((INameScope)nameScope).RegisterName("placeCell", selectCell3);
            if (selectCell3.StyleId == null)
            {
                selectCell3.StyleId = "placeCell";
            }
            NameScope.SetNameScope(newEntryCell, nameScope);
            ((INameScope)nameScope).RegisterName("arrivalCell", newEntryCell);
            if (newEntryCell.StyleId == null)
            {
                newEntryCell.StyleId = "arrivalCell";
            }
            NameScope.SetNameScope(qrcodeCell, nameScope);
            NameScope.SetNameScope(photoCell, nameScope);
            ((INameScope)nameScope).RegisterName("photocell", photoCell);
            if (photoCell.StyleId == null)
            {
                photoCell.StyleId = "photocell";
            }
            NameScope.SetNameScope(button, nameScope);
            this.tableView = tableView;
            this.carCell = selectCell;
            this.driverCell = selectCell2;
            this.placeCell = selectCell3;
            this.arrivalCell = newEntryCell;
            this.photocell = photoCell;
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
            xmlNamespaceResolver.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver.Add("local", "clr-namespace:RFID");
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(LockPage).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(19, 50)));
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
            xmlNamespaceResolver2.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver2.Add("local", "clr-namespace:RFID");
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(LockPage).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(19, 106)));
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
            xmlNamespaceResolver3.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver3.Add("local", "clr-namespace:RFID");
            xamlServiceProvider3.Add(typeFromHandle6, new XamlTypeResolver(xmlNamespaceResolver3, typeof(LockPage).GetTypeInfo().Assembly));
            xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(20, 77)));
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
            array4[0] = selectCell;
            array4[1] = tableSection;
            array4[2] = tableRoot;
            array4[3] = tableView;
            array4[4] = grid2;
            array4[5] = scrollView;
            array4[6] = this;
            xamlServiceProvider4.Add(typeFromHandle7, new SimpleValueTargetProvider(array4, SelectCell.TitleProperty));
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
            xamlServiceProvider4.Add(typeFromHandle8, new XamlTypeResolver(xmlNamespaceResolver4, typeof(LockPage).GetTypeInfo().Assembly));
            xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(26, 42)));
            object title = markupExtension2.ProvideValue(xamlServiceProvider4);
            selectCell.Title = title;
            bindingExtension3.Mode = BindingMode.TwoWay;
            bindingExtension3.Path = "CarNo";
            BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue(null);
            selectCell.SetBinding(SelectCell.TextProperty, binding3);
            bindingExtension4.Path = "CarCommand";
            BindingBase binding4 = ((IMarkupExtension<BindingBase>)bindingExtension4).ProvideValue(null);
            selectCell.SetBinding(SelectCell.CommandProperty, binding4);
            tableSection.Add(selectCell);
            bindingExtension5.Path = "UseCarrier";
            BindingBase binding5 = ((IMarkupExtension<BindingBase>)bindingExtension5).ProvideValue(null);
            selectCell2.SetBinding(Cell.IsEnabledProperty, binding5);
            translateExtension3.Text = "driver";
            IMarkupExtension markupExtension3 = translateExtension3;
            XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider();
            Type typeFromHandle9 = typeof(IProvideValueTarget);
            object[] array5 = new object[0 + 7];
            array5[0] = selectCell2;
            array5[1] = tableSection;
            array5[2] = tableRoot;
            array5[3] = tableView;
            array5[4] = grid2;
            array5[5] = scrollView;
            array5[6] = this;
            xamlServiceProvider5.Add(typeFromHandle9, new SimpleValueTargetProvider(array5, SelectCell.TitleProperty));
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
            xamlServiceProvider5.Add(typeFromHandle10, new XamlTypeResolver(xmlNamespaceResolver5, typeof(LockPage).GetTypeInfo().Assembly));
            xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(27, 103)));
            object title2 = markupExtension3.ProvideValue(xamlServiceProvider5);
            selectCell2.Title = title2;
            bindingExtension6.Mode = BindingMode.TwoWay;
            bindingExtension6.Path = "Driver";
            BindingBase binding6 = ((IMarkupExtension<BindingBase>)bindingExtension6).ProvideValue(null);
            selectCell2.SetBinding(SelectCell.TextProperty, binding6);
            bindingExtension7.Path = "DriverCommand";
            BindingBase binding7 = ((IMarkupExtension<BindingBase>)bindingExtension7).ProvideValue(null);
            selectCell2.SetBinding(SelectCell.CommandProperty, binding7);
            tableSection.Add(selectCell2);
            translateExtension4.Text = "place";
            IMarkupExtension markupExtension4 = translateExtension4;
            XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider();
            Type typeFromHandle11 = typeof(IProvideValueTarget);
            object[] array6 = new object[0 + 7];
            array6[0] = selectCell3;
            array6[1] = tableSection;
            array6[2] = tableRoot;
            array6[3] = tableView;
            array6[4] = grid2;
            array6[5] = scrollView;
            array6[6] = this;
            xamlServiceProvider6.Add(typeFromHandle11, new SimpleValueTargetProvider(array6, SelectCell.TitleProperty));
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
            xamlServiceProvider6.Add(typeFromHandle12, new XamlTypeResolver(xmlNamespaceResolver6, typeof(LockPage).GetTypeInfo().Assembly));
            xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(28, 71)));
            object title3 = markupExtension4.ProvideValue(xamlServiceProvider6);
            selectCell3.Title = title3;
            bindingExtension8.Mode = BindingMode.TwoWay;
            bindingExtension8.Path = "Place";
            BindingBase binding8 = ((IMarkupExtension<BindingBase>)bindingExtension8).ProvideValue(null);
            selectCell3.SetBinding(SelectCell.TextProperty, binding8);
            bindingExtension9.Path = "PlaceCommand";
            BindingBase binding9 = ((IMarkupExtension<BindingBase>)bindingExtension9).ProvideValue(null);
            selectCell3.SetBinding(SelectCell.CommandProperty, binding9);
            tableSection.Add(selectCell3);
            bindingExtension10.Path = "UseDestination";
            BindingBase binding10 = ((IMarkupExtension<BindingBase>)bindingExtension10).ProvideValue(null);
            newEntryCell.SetBinding(Cell.IsEnabledProperty, binding10);
            translateExtension5.Text = "arrival";
            IMarkupExtension markupExtension5 = translateExtension5;
            XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider();
            Type typeFromHandle13 = typeof(IProvideValueTarget);
            object[] array7 = new object[0 + 7];
            array7[0] = newEntryCell;
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
            xmlNamespaceResolver7.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver7.Add("local", "clr-namespace:RFID");
            xamlServiceProvider7.Add(typeFromHandle14, new XamlTypeResolver(xmlNamespaceResolver7, typeof(LockPage).GetTypeInfo().Assembly));
            xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(29, 112)));
            object title4 = markupExtension5.ProvideValue(xamlServiceProvider7);
            newEntryCell.Title = title4;
            bindingExtension11.Mode = BindingMode.TwoWay;
            bindingExtension11.Path = "Arrival";
            BindingBase binding11 = ((IMarkupExtension<BindingBase>)bindingExtension11).ProvideValue(null);
            newEntryCell.SetBinding(NewEntryCell.TextProperty, binding11);
            translateExtension6.Text = "arrivalhint";
            IMarkupExtension markupExtension6 = translateExtension6;
            XamlServiceProvider xamlServiceProvider8 = new XamlServiceProvider();
            Type typeFromHandle15 = typeof(IProvideValueTarget);
            object[] array8 = new object[0 + 7];
            array8[0] = newEntryCell;
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
            xmlNamespaceResolver8.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver8.Add("local", "clr-namespace:RFID");
            xamlServiceProvider8.Add(typeFromHandle16, new XamlTypeResolver(xmlNamespaceResolver8, typeof(LockPage).GetTypeInfo().Assembly));
            xamlServiceProvider8.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(29, 183)));
            object hint = markupExtension6.ProvideValue(xamlServiceProvider8);
            newEntryCell.Hint = hint;
            tableSection.Add(newEntryCell);
            bindingExtension12.Path = "QianfengNo";
            BindingBase binding12 = ((IMarkupExtension<BindingBase>)bindingExtension12).ProvideValue(null);
            qrcodeCell.SetBinding(QRCodeCell.TextProperty, binding12);
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
            xmlNamespaceResolver9.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver9.Add("local", "clr-namespace:RFID");
            xamlServiceProvider9.Add(typeFromHandle18, new XamlTypeResolver(xmlNamespaceResolver9, typeof(LockPage).GetTypeInfo().Assembly));
            xamlServiceProvider9.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(30, 81)));
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
            xmlNamespaceResolver10.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver10.Add("local", "clr-namespace:RFID");
            xamlServiceProvider10.Add(typeFromHandle20, new XamlTypeResolver(xmlNamespaceResolver10, typeof(LockPage).GetTypeInfo().Assembly));
            xamlServiceProvider10.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(30, 118)));
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
            xmlNamespaceResolver11.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver11.Add("local", "clr-namespace:RFID");
            xamlServiceProvider11.Add(typeFromHandle22, new XamlTypeResolver(xmlNamespaceResolver11, typeof(LockPage).GetTypeInfo().Assembly));
            xamlServiceProvider11.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(31, 70)));
            object title6 = markupExtension9.ProvideValue(xamlServiceProvider11);
            photoCell.Title = title6;
            bindingExtension13.Path = "ImageFiles";
            BindingBase binding13 = ((IMarkupExtension<BindingBase>)bindingExtension13).ProvideValue(null);
            photoCell.SetBinding(PhotoCell.FilesProperty, binding13);
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
            xmlNamespaceResolver12.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver12.Add("local", "clr-namespace:RFID");
            xamlServiceProvider12.Add(typeFromHandle24, new XamlTypeResolver(xmlNamespaceResolver12, typeof(LockPage).GetTypeInfo().Assembly));
            xamlServiceProvider12.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(36, 57)));
            object text2 = markupExtension10.ProvideValue(xamlServiceProvider12);
            button.Text = text2;
            bindingExtension14.Path = "CommitCommand";
            BindingBase binding14 = ((IMarkupExtension<BindingBase>)bindingExtension14).ProvideValue(null);
            button.SetBinding(Button.CommandProperty, binding14);
            button.SetValue(Button.TextColorProperty, Color.White);
            button.SetValue(VisualElement.BackgroundColorProperty, new Color(0.050980392843484879, 0.27843138575553894, 0.63137257099151611, 1.0));
            button.SetValue(Button.BorderRadiusProperty, 10);
            button.SetValue(Button.BorderColorProperty, new Color(0.050980392843484879, 0.27843138575553894, 0.63137257099151611, 1.0));
            button.SetValue(Button.BorderWidthProperty, 1.0);
            grid2.Children.Add(button);
            scrollView.Content = grid2;
            this.SetValue(ContentPage.ContentProperty, scrollView);
        }

        // Token: 0x06000256 RID: 598 RVA: 0x0000FE74 File Offset: 0x0000E074
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(LockPage));
            this.tableView = this.FindByName("tableView");
            this.carCell = this.FindByName("carCell");
            this.driverCell = this.FindByName("driverCell");
            this.placeCell = this.FindByName("placeCell");
            this.arrivalCell = this.FindByName("arrivalCell");
            this.photocell = this.FindByName("photocell");
        }

        // Token: 0x04000139 RID: 313
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private TableView tableView;

        // Token: 0x0400013A RID: 314
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private SelectCell carCell;

        // Token: 0x0400013B RID: 315
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private SelectCell driverCell;

        // Token: 0x0400013C RID: 316
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private SelectCell placeCell;

        // Token: 0x0400013D RID: 317
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private NewEntryCell arrivalCell;

        // Token: 0x0400013E RID: 318
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private PhotoCell photocell;
    }
}
