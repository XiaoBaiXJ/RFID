using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace RFID.Layout
{
    // Token: 0x020000E5 RID: 229
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Layout\\QRCodeCell.xaml")]
    public class QRCodeCell : ViewCell
    {
        // Token: 0x06000513 RID: 1299 RVA: 0x000237F7 File Offset: 0x000219F7
        public QRCodeCell()
        {
            this.InitializeComponent();
            this.entry.TextChanged += this.Entry_TextChanged;
        }

        // Token: 0x06000514 RID: 1300 RVA: 0x0002381C File Offset: 0x00021A1C
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Text = e.NewTextValue;
        }

        // Token: 0x17000171 RID: 369
        // (get) Token: 0x06000515 RID: 1301 RVA: 0x0002382A File Offset: 0x00021A2A
        // (set) Token: 0x06000516 RID: 1302 RVA: 0x0002383C File Offset: 0x00021A3C
        public string Title
        {
            get
            {
                return (string)base.GetValue(QRCodeCell.TitleProperty);
            }
            set
            {
                if (string.Equals(this.Title, value, StringComparison.Ordinal))
                {
                    return;
                }
                base.SetValue(QRCodeCell.TitleProperty, value);
                this.OnPropertyChanged("Title");
            }
        }

        // Token: 0x06000517 RID: 1303 RVA: 0x00023874 File Offset: 0x00021A74
        private static void OnTitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            QRCodeCell qrcodeCell = bindable as QRCodeCell;
            if (!newValue.Equals(oldValue))
            {
                qrcodeCell.label.Text = newValue.ToString();
            }
        }

        // Token: 0x17000172 RID: 370
        // (get) Token: 0x06000518 RID: 1304 RVA: 0x000238A2 File Offset: 0x00021AA2
        // (set) Token: 0x06000519 RID: 1305 RVA: 0x000238B4 File Offset: 0x00021AB4
        public string Text
        {
            get
            {
                return (string)base.GetValue(QRCodeCell.TextProperty);
            }
            set
            {
                if (string.Equals(this.Text, value, StringComparison.Ordinal))
                {
                    return;
                }
                base.SetValue(QRCodeCell.TextProperty, value);
                this.OnPropertyChanged("Text");
            }
        }

        // Token: 0x0600051A RID: 1306 RVA: 0x000238EC File Offset: 0x00021AEC
        private static void OnTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue == null)
            {
                return;
            }
            QRCodeCell qrcodeCell = bindable as QRCodeCell;
            if (!newValue.Equals(oldValue))
            {
                qrcodeCell.entry.Text = newValue.ToString();
            }
        }

        // Token: 0x17000173 RID: 371
        // (get) Token: 0x0600051B RID: 1307 RVA: 0x0002391E File Offset: 0x00021B1E
        // (set) Token: 0x0600051C RID: 1308 RVA: 0x00023930 File Offset: 0x00021B30
        public string Hint
        {
            get
            {
                return (string)base.GetValue(QRCodeCell.HintProperty);
            }
            set
            {
                if (string.Equals(this.Hint, value, StringComparison.Ordinal))
                {
                    return;
                }
                base.SetValue(QRCodeCell.HintProperty, value);
                this.OnPropertyChanged("Hint");
            }
        }

        // Token: 0x0600051D RID: 1309 RVA: 0x00023968 File Offset: 0x00021B68
        private static void OnHintChanged(BindableObject bindable, object oldValue, object newValue)
        {
            QRCodeCell qrcodeCell = bindable as QRCodeCell;
            if (!newValue.Equals(oldValue))
            {
                qrcodeCell.entry.Placeholder = newValue.ToString();
            }
        }

        // Token: 0x0600051E RID: 1310 RVA: 0x00023998 File Offset: 0x00021B98
        private async void Handle_Clicked(object sender, EventArgs e)
        {
            QRCodeCell.<> c__DisplayClass17_0 CS$<> 8__locals1 = new QRCodeCell.<> c__DisplayClass17_0();
            CS$<> 8__locals1.<> 4__this = this;
            CS$<> 8__locals1.scanPage = new ZXingScannerPage(null, null)
            {
                Title = "条形码二维码扫描"
            };
            CS$<> 8__locals1.scanPage.OnScanResult += delegate (Result result)
            {
                QRCodeCell.<> c__DisplayClass17_1 CS$<> 8__locals2 = new QRCodeCell.<> c__DisplayClass17_1();
                CS$<> 8__locals2.CS$<> 8__locals1 = CS$<> 8__locals1;
                CS$<> 8__locals2.result = result;
                CS$<> 8__locals1.scanPage.IsScanning = false;
                Device.BeginInvokeOnMainThread(delegate
                {
                QRCodeCell.<> c__DisplayClass17_1.<< Handle_Clicked > b__1 > d << Handle_Clicked > b__1 > d;

                    << Handle_Clicked > b__1 > d.<> 4__this = CS$<> 8__locals2;

                    << Handle_Clicked > b__1 > d.<> t__builder = AsyncVoidMethodBuilder.Create();

                    << Handle_Clicked > b__1 > d.<> 1__state = -1;
                AsyncVoidMethodBuilder<> t__builder = << Handle_Clicked > b__1 > d.<> t__builder;

                    <> t__builder.Start < QRCodeCell.<> c__DisplayClass17_1.<< Handle_Clicked > b__1 > d > (ref << Handle_Clicked > b__1 > d);
            });
        };
        await App.CurNavigationPage.CurrentPage.Navigation.PushAsync(CS$<>8__locals1.scanPage);
    }

    // Token: 0x0600051F RID: 1311 RVA: 0x000239D4 File Offset: 0x00021BD4
    [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
    private void InitializeComponent()
    {
        if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(QRCodeCell).GetTypeInfo().Assembly.GetName(), "Layout/QRCodeCell.xaml") != null)
        {
            this.__InitComponentRuntime();
            return;
        }
        if (XamlLoader.XamlFileProvider != null && XamlLoader.XamlFileProvider(base.GetType()) != null)
        {
            this.__InitComponentRuntime();
            return;
        }
        ColumnDefinition columnDefinition = new ColumnDefinition();
        ColumnDefinition columnDefinition2 = new ColumnDefinition();
        ColumnDefinition columnDefinition3 = new ColumnDefinition();
        RowDefinition rowDefinition = new RowDefinition();
        Label label = new Label();
        NoBorderEntry noBorderEntry = new NoBorderEntry();
        TranslateExtension translateExtension = new TranslateExtension();
        Button button = new Button();
        Grid grid = new Grid();
        NameScope nameScope = new NameScope();
        NameScope.SetNameScope(this, nameScope);
        NameScope.SetNameScope(grid, nameScope);
        NameScope.SetNameScope(columnDefinition, nameScope);
        NameScope.SetNameScope(columnDefinition2, nameScope);
        NameScope.SetNameScope(columnDefinition3, nameScope);
        NameScope.SetNameScope(rowDefinition, nameScope);
        NameScope.SetNameScope(label, nameScope);
        ((INameScope)nameScope).RegisterName("label", label);
        if (label.StyleId == null)
        {
            label.StyleId = "label";
        }
        NameScope.SetNameScope(noBorderEntry, nameScope);
        ((INameScope)nameScope).RegisterName("entry", noBorderEntry);
        if (noBorderEntry.StyleId == null)
        {
            noBorderEntry.StyleId = "entry";
        }
        NameScope.SetNameScope(button, nameScope);
        this.label = label;
        this.entry = noBorderEntry;
        grid.SetValue(VisualElement.BackgroundColorProperty, Color.White);
        grid.SetValue(Grid.RowSpacingProperty, 5.0);
        grid.SetValue(Layout.PaddingProperty, new Thickness(10.0, 5.0, 10.0, 5.0));
        columnDefinition.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
        grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition);
        columnDefinition2.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("2*"));
        grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition2);
        columnDefinition3.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
        grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition3);
        rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
        grid.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition);
        BindableObject bindableObject = label;
        BindableProperty fontSizeProperty = Label.FontSizeProperty;
        IExtendedTypeConverter extendedTypeConverter = new FontSizeConverter();
        string value = "Default";
        XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
        Type typeFromHandle = typeof(IProvideValueTarget);
        object[] array = new object[0 + 3];
        array[0] = label;
        array[1] = grid;
        array[2] = this;
        xamlServiceProvider.Add(typeFromHandle, new SimpleValueTargetProvider(array, Label.FontSizeProperty));
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
        xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(QRCodeCell).GetTypeInfo().Assembly));
        xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(19, 20)));
        bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider));
        label.SetValue(Label.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
        label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
        label.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
        label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Start"));
        label.SetValue(Grid.ColumnProperty, 0);
        grid.Children.Add(label);
        noBorderEntry.SetValue(InputView.KeyboardProperty, new KeyboardTypeConverter().ConvertFromInvariantString("Numeric"));
        noBorderEntry.SetValue(VisualElement.BackgroundColorProperty, new Color(0.93725490570068359, 0.93725490570068359, 0.93725490570068359, 1.0));
        BindableObject bindableObject2 = noBorderEntry;
        BindableProperty fontSizeProperty2 = Entry.FontSizeProperty;
        IExtendedTypeConverter extendedTypeConverter2 = new FontSizeConverter();
        string value2 = "Default";
        XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
        Type typeFromHandle3 = typeof(IProvideValueTarget);
        object[] array2 = new object[0 + 3];
        array2[0] = noBorderEntry;
        array2[1] = grid;
        array2[2] = this;
        xamlServiceProvider2.Add(typeFromHandle3, new SimpleValueTargetProvider(array2, Entry.FontSizeProperty));
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
        xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(QRCodeCell).GetTypeInfo().Assembly));
        xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(20, 82)));
        bindableObject2.SetValue(fontSizeProperty2, extendedTypeConverter2.ConvertFromInvariantString(value2, xamlServiceProvider2));
        noBorderEntry.SetValue(Entry.PlaceholderColorProperty, new Color(0.63529413938522339, 0.63529413938522339, 0.63529413938522339, 1.0));
        noBorderEntry.SetValue(Grid.ColumnProperty, 1);
        noBorderEntry.SetValue(Entry.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
        noBorderEntry.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
        grid.Children.Add(noBorderEntry);
        translateExtension.Text = "scan";
        IMarkupExtension markupExtension = translateExtension;
        XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider();
        Type typeFromHandle5 = typeof(IProvideValueTarget);
        object[] array3 = new object[0 + 3];
        array3[0] = button;
        array3[1] = grid;
        array3[2] = this;
        xamlServiceProvider3.Add(typeFromHandle5, new SimpleValueTargetProvider(array3, Button.TextProperty));
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
        xamlServiceProvider3.Add(typeFromHandle6, new XamlTypeResolver(xmlNamespaceResolver3, typeof(QRCodeCell).GetTypeInfo().Assembly));
        xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(21, 21)));
        object text = markupExtension.ProvideValue(xamlServiceProvider3);
        button.Text = text;
        button.SetValue(Button.TextColorProperty, Color.White);
        button.SetValue(VisualElement.BackgroundColorProperty, new Color(0.050980392843484879, 0.27843138575553894, 0.63137257099151611, 1.0));
        BindableObject bindableObject3 = button;
        BindableProperty fontSizeProperty3 = Button.FontSizeProperty;
        IExtendedTypeConverter extendedTypeConverter3 = new FontSizeConverter();
        string value3 = "Default";
        XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider();
        Type typeFromHandle7 = typeof(IProvideValueTarget);
        object[] array4 = new object[0 + 3];
        array4[0] = button;
        array4[1] = grid;
        array4[2] = this;
        xamlServiceProvider4.Add(typeFromHandle7, new SimpleValueTargetProvider(array4, Button.FontSizeProperty));
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
        xamlServiceProvider4.Add(typeFromHandle8, new XamlTypeResolver(xmlNamespaceResolver4, typeof(QRCodeCell).GetTypeInfo().Assembly));
        xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(21, 96)));
        bindableObject3.SetValue(fontSizeProperty3, extendedTypeConverter3.ConvertFromInvariantString(value3, xamlServiceProvider4));
        button.SetValue(Button.BorderColorProperty, new Color(0.050980392843484879, 0.27843138575553894, 0.63137257099151611, 1.0));
        button.SetValue(Button.BorderWidthProperty, 1.0);
        button.SetValue(Button.BorderRadiusProperty, 10);
        button.SetValue(Grid.ColumnProperty, 2);
        button.Clicked += this.Handle_Clicked;
        grid.Children.Add(button);
        this.View = grid;
    }

    // Token: 0x06000521 RID: 1313 RVA: 0x0002436D File Offset: 0x0002256D
    private void __InitComponentRuntime()
    {
        this.LoadFromXaml(typeof(QRCodeCell));
        this.label = this.FindByName("label");
        this.entry = this.FindByName("entry");
    }

    // Token: 0x04000370 RID: 880
    public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(QRCodeCell), "设置", BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(QRCodeCell.OnTitleChanged), null, null, null);

    // Token: 0x04000371 RID: 881
    public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(QRCodeCell), "", BindingMode.OneWayToSource, null, null, null, null, null);

    // Token: 0x04000372 RID: 882
    public static readonly BindableProperty HintProperty = BindableProperty.Create("Hint", typeof(string), typeof(QRCodeCell), "", BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(QRCodeCell.OnHintChanged), null, null, null);

    // Token: 0x04000373 RID: 883
    [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
    private Label label;

    // Token: 0x04000374 RID: 884
    [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
    private NoBorderEntry entry;
}
}
