using System;
using System.CodeDom.Compiler;
using System.Reflection;
using FFImageLoading.Forms;
using FFImageLoading.Svg.Forms;
using Prism.Commands;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Layout
{
    // Token: 0x020000E2 RID: 226
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Layout\\SelectCell.xaml")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class SelectCell : ViewCell
    {
        // Token: 0x060004EB RID: 1259 RVA: 0x0002229D File Offset: 0x0002049D
        public SelectCell()
        {
            this.InitializeComponent();
        }

        // Token: 0x060004EC RID: 1260 RVA: 0x000222AB File Offset: 0x000204AB
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            DelegateCommand command = this.Command;
            if (command == null)
            {
                return;
            }
            command.Execute();
        }

        // Token: 0x17000167 RID: 359
        // (get) Token: 0x060004ED RID: 1261 RVA: 0x000222BD File Offset: 0x000204BD
        // (set) Token: 0x060004EE RID: 1262 RVA: 0x000222D0 File Offset: 0x000204D0
        public string Title
        {
            get
            {
                return (string)base.GetValue(SelectCell.TitleProperty);
            }
            set
            {
                if (string.Equals(this.Title, value, StringComparison.Ordinal))
                {
                    return;
                }
                base.SetValue(SelectCell.TitleProperty, value);
                this.OnPropertyChanged("Title");
            }
        }

        // Token: 0x060004EF RID: 1263 RVA: 0x00022308 File Offset: 0x00020508
        private static void OnTitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            SelectCell selectCell = bindable as SelectCell;
            if (!newValue.Equals(oldValue))
            {
                selectCell.label.Text = newValue.ToString();
            }
        }

        // Token: 0x17000168 RID: 360
        // (get) Token: 0x060004F0 RID: 1264 RVA: 0x00022336 File Offset: 0x00020536
        // (set) Token: 0x060004F1 RID: 1265 RVA: 0x00022348 File Offset: 0x00020548
        public string Text
        {
            get
            {
                return (string)base.GetValue(SelectCell.TextProperty);
            }
            set
            {
                if (string.Equals(this.Text, value, StringComparison.Ordinal))
                {
                    return;
                }
                base.SetValue(SelectCell.TextProperty, value);
                this.OnPropertyChanged("Text");
            }
        }

        // Token: 0x060004F2 RID: 1266 RVA: 0x00022380 File Offset: 0x00020580
        private static void OnTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue == null)
            {
                return;
            }
            SelectCell selectCell = bindable as SelectCell;
            if (!newValue.Equals(oldValue))
            {
                selectCell.placeLabel.Text = newValue.ToString();
            }
        }

        // Token: 0x17000169 RID: 361
        // (get) Token: 0x060004F3 RID: 1267 RVA: 0x000223B2 File Offset: 0x000205B2
        // (set) Token: 0x060004F4 RID: 1268 RVA: 0x000223C4 File Offset: 0x000205C4
        public bool CanSelect
        {
            get
            {
                return (bool)base.GetValue(SelectCell.CanSelectProperty);
            }
            set
            {
                if (this.CanSelect == value)
                {
                    return;
                }
                base.SetValue(SelectCell.CanSelectProperty, value);
                this.OnPropertyChanged("CanSelect");
            }
        }

        // Token: 0x060004F5 RID: 1269 RVA: 0x000223FC File Offset: 0x000205FC
        private static void OnCanSelectChanged(BindableObject bindable, object oldValue, object newValue)
        {
            SelectCell selectCell = bindable as SelectCell;
            selectCell.arrow.IsVisible = (bool)newValue;
        }

        // Token: 0x1700016A RID: 362
        // (get) Token: 0x060004F6 RID: 1270 RVA: 0x00022421 File Offset: 0x00020621
        // (set) Token: 0x060004F7 RID: 1271 RVA: 0x00022434 File Offset: 0x00020634
        public DelegateCommand Command
        {
            get
            {
                return (DelegateCommand)base.GetValue(SelectCell.CommandProperty);
            }
            set
            {
                if (object.Equals(this.Command, value))
                {
                    return;
                }
                base.SetValue(SelectCell.CommandProperty, value);
                this.OnPropertyChanged("Command");
            }
        }

        // Token: 0x1700016B RID: 363
        // (get) Token: 0x060004F8 RID: 1272 RVA: 0x00022469 File Offset: 0x00020669
        // (set) Token: 0x060004F9 RID: 1273 RVA: 0x0002247C File Offset: 0x0002067C
        public bool CanInput
        {
            get
            {
                return (bool)base.GetValue(SelectCell.CanInputProperty);
            }
            set
            {
                if (this.CanInput == value)
                {
                    return;
                }
                base.SetValue(SelectCell.CanInputProperty, value);
                this.OnPropertyChanged("CanInput");
            }
        }

        // Token: 0x060004FA RID: 1274 RVA: 0x000224B4 File Offset: 0x000206B4
        private static void OnCanInputChanged(BindableObject bindable, object oldValue, object newValue)
        {
            SelectCell selectCell = bindable as SelectCell;
            if (!newValue.Equals(oldValue))
            {
                selectCell.entry.IsEnabled = (bool)newValue;
            }
        }

        // Token: 0x1700016C RID: 364
        // (get) Token: 0x060004FB RID: 1275 RVA: 0x000224E2 File Offset: 0x000206E2
        // (set) Token: 0x060004FC RID: 1276 RVA: 0x000224F4 File Offset: 0x000206F4
        public bool IsVisalbe
        {
            get
            {
                return (bool)base.GetValue(SelectCell.IsVisalbeProperty);
            }
            set
            {
                if (this.IsVisalbe == value)
                {
                    return;
                }
                base.SetValue(SelectCell.IsVisalbeProperty, value);
                this.OnPropertyChanged("IsVisalbe");
            }
        }

        // Token: 0x060004FD RID: 1277 RVA: 0x0002252C File Offset: 0x0002072C
        private static void OnIsVisalbePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            SelectCell selectCell = bindable as SelectCell;
            if (!newValue.Equals(oldValue))
            {
                selectCell.view.IsVisible = (bool)newValue;
            }
        }

        // Token: 0x060004FE RID: 1278 RVA: 0x0002255C File Offset: 0x0002075C
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(SelectCell).GetTypeInfo().Assembly.GetName(), "Layout/SelectCell.xaml") != null)
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
            RowDefinition rowDefinition = new RowDefinition();
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            Label label = new Label();
            NoBorderEntry noBorderEntry = new NoBorderEntry();
            Label label2 = new Label();
            SvgCachedImage svgCachedImage = new SvgCachedImage();
            Grid grid = new Grid();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            ((INameScope)nameScope).RegisterName("view", grid);
            if (grid.StyleId == null)
            {
                grid.StyleId = "view";
            }
            NameScope.SetNameScope(columnDefinition, nameScope);
            NameScope.SetNameScope(columnDefinition2, nameScope);
            NameScope.SetNameScope(rowDefinition, nameScope);
            NameScope.SetNameScope(tapGestureRecognizer, nameScope);
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
            NameScope.SetNameScope(label2, nameScope);
            ((INameScope)nameScope).RegisterName("placeLabel", label2);
            if (label2.StyleId == null)
            {
                label2.StyleId = "placeLabel";
            }
            NameScope.SetNameScope(svgCachedImage, nameScope);
            ((INameScope)nameScope).RegisterName("arrow", svgCachedImage);
            if (svgCachedImage.StyleId == null)
            {
                svgCachedImage.StyleId = "arrow";
            }
            this.view = grid;
            this.label = label;
            this.entry = noBorderEntry;
            this.placeLabel = label2;
            this.arrow = svgCachedImage;
            grid.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            grid.SetValue(Grid.RowSpacingProperty, 5.0);
            grid.SetValue(Layout.PaddingProperty, new Thickness(10.0, 5.0, 10.0, 5.0));
            columnDefinition.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition);
            columnDefinition2.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("3*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition2);
            rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition);
            tapGestureRecognizer.Tapped += this.TapGestureRecognizer_Tapped;
            grid.GestureRecognizers.Add(tapGestureRecognizer);
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
            xmlNamespaceResolver.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(SelectCell).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(19, 20)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider));
            label.SetValue(Label.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
            label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            label.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Start"));
            label.SetValue(Grid.ColumnProperty, 0);
            grid.Children.Add(label);
            noBorderEntry.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            noBorderEntry.SetValue(VisualElement.WidthRequestProperty, 1.0);
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
            xmlNamespaceResolver2.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(SelectCell).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(20, 92)));
            bindableObject2.SetValue(fontSizeProperty2, extendedTypeConverter2.ConvertFromInvariantString(value2, xamlServiceProvider2));
            noBorderEntry.SetValue(Grid.ColumnProperty, 1);
            noBorderEntry.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
            noBorderEntry.SetValue(VisualElement.IsEnabledProperty, false);
            grid.Children.Add(noBorderEntry);
            BindableObject bindableObject3 = label2;
            BindableProperty fontSizeProperty3 = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter3 = new FontSizeConverter();
            string value3 = "Default";
            XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider();
            Type typeFromHandle5 = typeof(IProvideValueTarget);
            object[] array3 = new object[0 + 3];
            array3[0] = label2;
            array3[1] = grid;
            array3[2] = this;
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
            xmlNamespaceResolver3.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xamlServiceProvider3.Add(typeFromHandle6, new XamlTypeResolver(xmlNamespaceResolver3, typeof(SelectCell).GetTypeInfo().Assembly));
            xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(21, 20)));
            bindableObject3.SetValue(fontSizeProperty3, extendedTypeConverter3.ConvertFromInvariantString(value3, xamlServiceProvider3));
            label2.SetValue(Label.TextColorProperty, Color.Black);
            label2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            label2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label2.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Start"));
            label2.SetValue(Grid.ColumnProperty, 1);
            grid.Children.Add(label2);
            svgCachedImage.SetValue(CachedImage.SourceProperty, new FFImageLoading.Forms.ImageSourceConverter().ConvertFromInvariantString("rightarrow.svg"));
            svgCachedImage.SetValue(Grid.ColumnProperty, 1);
            svgCachedImage.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
            svgCachedImage.SetValue(VisualElement.WidthRequestProperty, 15.0);
            svgCachedImage.SetValue(VisualElement.HeightRequestProperty, 15.0);
            svgCachedImage.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            grid.Children.Add(svgCachedImage);
            this.View = grid;
        }

        // Token: 0x06000500 RID: 1280 RVA: 0x00022ECC File Offset: 0x000210CC
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(SelectCell));
            this.view = this.FindByName("view");
            this.label = this.FindByName("label");
            this.entry = this.FindByName("entry");
            this.placeLabel = this.FindByName("placeLabel");
            this.arrow = this.FindByName("arrow");
        }

        // Token: 0x0400035F RID: 863
        public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(SelectCell), "设置", BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(SelectCell.OnTitleChanged), null, null, null);

        // Token: 0x04000360 RID: 864
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(SelectCell), "", BindingMode.TwoWay, null, new BindableProperty.BindingPropertyChangedDelegate(SelectCell.OnTextChanged), null, null, null);

        // Token: 0x04000361 RID: 865
        public static readonly BindableProperty CanSelectProperty = BindableProperty.Create("CanSelect", typeof(bool), typeof(SelectCell), true, BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(SelectCell.OnCanSelectChanged), null, null, null);

        // Token: 0x04000362 RID: 866
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(DelegateCommand), typeof(SelectCell), null, BindingMode.OneWay, null, null, null, null, null);

        // Token: 0x04000363 RID: 867
        public static readonly BindableProperty CanInputProperty = BindableProperty.Create("CanInput", typeof(bool), typeof(SelectCell), false, BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(SelectCell.OnCanInputChanged), null, null, null);

        // Token: 0x04000364 RID: 868
        public static readonly BindableProperty IsVisalbeProperty = BindableProperty.Create("IsVisalbe", typeof(bool), typeof(SelectCell), true, BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(SelectCell.OnIsVisalbePropertyChanged), null, null, null);

        // Token: 0x04000365 RID: 869
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private Grid view;

        // Token: 0x04000366 RID: 870
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private Label label;

        // Token: 0x04000367 RID: 871
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private NoBorderEntry entry;

        // Token: 0x04000368 RID: 872
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private Label placeLabel;

        // Token: 0x04000369 RID: 873
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private SvgCachedImage arrow;
    }
}
