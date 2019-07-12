using System;
using System.CodeDom.Compiler;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Layout
{
    // Token: 0x020000E4 RID: 228
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Layout\\NewEntryCell.xaml")]
    public class NewEntryCell : ViewCell
    {
        // Token: 0x06000502 RID: 1282 RVA: 0x00022F47 File Offset: 0x00021147
        public NewEntryCell()
        {
            this.InitializeComponent();
            this.entry.TextChanged += this.Entry_TextChanged;
        }

        // Token: 0x06000503 RID: 1283 RVA: 0x00022F6C File Offset: 0x0002116C
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Text = e.NewTextValue;
        }

        // Token: 0x1700016D RID: 365
        // (get) Token: 0x06000504 RID: 1284 RVA: 0x00022F7A File Offset: 0x0002117A
        // (set) Token: 0x06000505 RID: 1285 RVA: 0x00022F8C File Offset: 0x0002118C
        public string Title
        {
            get
            {
                return (string)base.GetValue(NewEntryCell.TitleProperty);
            }
            set
            {
                if (string.Equals(this.Title, value, StringComparison.Ordinal))
                {
                    return;
                }
                base.SetValue(NewEntryCell.TitleProperty, value);
                this.OnPropertyChanged("Title");
            }
        }

        // Token: 0x06000506 RID: 1286 RVA: 0x00022FC4 File Offset: 0x000211C4
        private static void OnTitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            NewEntryCell newEntryCell = bindable as NewEntryCell;
            if (!newValue.Equals(oldValue))
            {
                newEntryCell.label.Text = newValue.ToString();
            }
        }

        // Token: 0x1700016E RID: 366
        // (get) Token: 0x06000507 RID: 1287 RVA: 0x00022FF2 File Offset: 0x000211F2
        // (set) Token: 0x06000508 RID: 1288 RVA: 0x00023004 File Offset: 0x00021204
        public string Text
        {
            get
            {
                return (string)base.GetValue(NewEntryCell.TextProperty);
            }
            set
            {
                if (string.Equals(this.Text, value, StringComparison.Ordinal))
                {
                    return;
                }
                base.SetValue(NewEntryCell.TextProperty, value);
                this.OnPropertyChanged("Text");
            }
        }

        // Token: 0x06000509 RID: 1289 RVA: 0x0002303C File Offset: 0x0002123C
        private static void OnTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue == null)
            {
                return;
            }
            NewEntryCell newEntryCell = bindable as NewEntryCell;
            if (!newValue.Equals(oldValue))
            {
                newEntryCell.entry.Text = newValue.ToString();
            }
        }

        // Token: 0x1700016F RID: 367
        // (get) Token: 0x0600050A RID: 1290 RVA: 0x0002306E File Offset: 0x0002126E
        // (set) Token: 0x0600050B RID: 1291 RVA: 0x00023080 File Offset: 0x00021280
        public string Hint
        {
            get
            {
                return (string)base.GetValue(NewEntryCell.HintProperty);
            }
            set
            {
                if (string.Equals(this.Hint, value, StringComparison.Ordinal))
                {
                    return;
                }
                base.SetValue(NewEntryCell.HintProperty, value);
                this.OnPropertyChanged("Hint");
            }
        }

        // Token: 0x0600050C RID: 1292 RVA: 0x000230B8 File Offset: 0x000212B8
        private static void OnHintChanged(BindableObject bindable, object oldValue, object newValue)
        {
            NewEntryCell newEntryCell = bindable as NewEntryCell;
            if (!newValue.Equals(oldValue))
            {
                newEntryCell.entry.Placeholder = newValue.ToString();
            }
        }

        // Token: 0x17000170 RID: 368
        // (get) Token: 0x0600050D RID: 1293 RVA: 0x000230E6 File Offset: 0x000212E6
        // (set) Token: 0x0600050E RID: 1294 RVA: 0x000230F8 File Offset: 0x000212F8
        public bool CanInput
        {
            get
            {
                return (bool)base.GetValue(NewEntryCell.CanInputProperty);
            }
            set
            {
                if (this.CanInput == value)
                {
                    return;
                }
                base.SetValue(NewEntryCell.CanInputProperty, value);
                this.OnPropertyChanged("CanInput");
            }
        }

        // Token: 0x0600050F RID: 1295 RVA: 0x00023130 File Offset: 0x00021330
        private static void OnCanInputChanged(BindableObject bindable, object oldValue, object newValue)
        {
            NewEntryCell newEntryCell = bindable as NewEntryCell;
            if (!newValue.Equals(oldValue))
            {
                newEntryCell.entry.IsEnabled = (bool)newValue;
            }
        }

        // Token: 0x06000510 RID: 1296 RVA: 0x00023160 File Offset: 0x00021360
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(NewEntryCell).GetTypeInfo().Assembly.GetName(), "Layout/NewEntryCell.xaml") != null)
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
            Label label = new Label();
            NoBorderEntry noBorderEntry = new NoBorderEntry();
            Grid grid = new Grid();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(columnDefinition, nameScope);
            NameScope.SetNameScope(columnDefinition2, nameScope);
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
            this.label = label;
            this.entry = noBorderEntry;
            grid.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            grid.SetValue(Grid.RowSpacingProperty, 5.0);
            grid.SetValue(Layout.PaddingProperty, new Thickness(10.0, 5.0, 10.0, 5.0));
            columnDefinition.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition);
            columnDefinition2.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("3*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition2);
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
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(NewEntryCell).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(16, 20)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider));
            label.SetValue(Label.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
            label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            label.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Start"));
            label.SetValue(Grid.ColumnProperty, 0);
            grid.Children.Add(label);
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
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(NewEntryCell).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(17, 79)));
            bindableObject2.SetValue(fontSizeProperty2, extendedTypeConverter2.ConvertFromInvariantString(value2, xamlServiceProvider2));
            noBorderEntry.SetValue(Entry.PlaceholderColorProperty, new Color(0.63529413938522339, 0.63529413938522339, 0.63529413938522339, 1.0));
            noBorderEntry.SetValue(Grid.ColumnProperty, 1);
            noBorderEntry.SetValue(Entry.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
            noBorderEntry.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            grid.Children.Add(noBorderEntry);
            this.View = grid;
        }

        // Token: 0x06000512 RID: 1298 RVA: 0x000237C2 File Offset: 0x000219C2
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(NewEntryCell));
            this.label = this.FindByName("label");
            this.entry = this.FindByName("entry");
        }

        // Token: 0x0400036A RID: 874
        public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(NewEntryCell), "设置", BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(NewEntryCell.OnTitleChanged), null, null, null);

        // Token: 0x0400036B RID: 875
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(NewEntryCell), "", BindingMode.TwoWay, null, new BindableProperty.BindingPropertyChangedDelegate(NewEntryCell.OnTextChanged), null, null, null);

        // Token: 0x0400036C RID: 876
        public static readonly BindableProperty HintProperty = BindableProperty.Create("Hint", typeof(string), typeof(NewEntryCell), "", BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(NewEntryCell.OnHintChanged), null, null, null);

        // Token: 0x0400036D RID: 877
        public static readonly BindableProperty CanInputProperty = BindableProperty.Create("CanInput", typeof(bool), typeof(NewEntryCell), true, BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(NewEntryCell.OnCanInputChanged), null, null, null);

        // Token: 0x0400036E RID: 878
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private Label label;

        // Token: 0x0400036F RID: 879
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private NoBorderEntry entry;
    }
}
