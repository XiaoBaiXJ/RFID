using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
using FFImageLoading.Forms;
using FFImageLoading.Svg.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Layout
{
    // Token: 0x020000DC RID: 220
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Layout\\MineCell.xaml")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class MineCell : ViewCell
    {
        // Token: 0x060004BE RID: 1214 RVA: 0x00020B1A File Offset: 0x0001ED1A
        public MineCell()
        {
            this.InitializeComponent();
        }

        // Token: 0x1700015E RID: 350
        // (get) Token: 0x060004BF RID: 1215 RVA: 0x00020B28 File Offset: 0x0001ED28
        // (set) Token: 0x060004C0 RID: 1216 RVA: 0x00020B3C File Offset: 0x0001ED3C
        public string Icon
        {
            get
            {
                return (string)base.GetValue(MineCell.IconProperty);
            }
            set
            {
                base.SetValue(MineCell.IconProperty, value);
                this.OnPropertyChanged("Icon");
            }
        }

        // Token: 0x060004C1 RID: 1217 RVA: 0x00020B64 File Offset: 0x0001ED64
        private static void OnIconChanged(BindableObject bindable, object oldValue, object newValue)
        {
            MineCell mineCell = bindable as MineCell;
            if (!oldValue.Equals(newValue))
            {
                mineCell.icon.Source = SvgImageSource.FromFile(newValue.ToString(), 0, 0, true, null);
            }
        }

        // Token: 0x1700015F RID: 351
        // (get) Token: 0x060004C2 RID: 1218 RVA: 0x00020B9B File Offset: 0x0001ED9B
        // (set) Token: 0x060004C3 RID: 1219 RVA: 0x00020BB0 File Offset: 0x0001EDB0
        public string Title
        {
            get
            {
                return (string)base.GetValue(MineCell.TitleProperty);
            }
            set
            {
                if (string.Equals(this.Title, value, StringComparison.Ordinal))
                {
                    return;
                }
                base.SetValue(MineCell.TitleProperty, value);
                this.OnPropertyChanged("Title");
            }
        }

        // Token: 0x060004C4 RID: 1220 RVA: 0x00020BE8 File Offset: 0x0001EDE8
        private static void OnTitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            MineCell mineCell = bindable as MineCell;
            if (!oldValue.Equals(newValue))
            {
                mineCell.label.Text = newValue.ToString();
            }
        }

        // Token: 0x17000160 RID: 352
        // (get) Token: 0x060004C5 RID: 1221 RVA: 0x00020C16 File Offset: 0x0001EE16
        // (set) Token: 0x060004C6 RID: 1222 RVA: 0x00020C28 File Offset: 0x0001EE28
        public ICommand Command
        {
            get
            {
                return (ICommand)base.GetValue(MineCell.CommandProperty);
            }
            set
            {
                if (object.Equals(this.Command, value))
                {
                    return;
                }
                base.SetValue(MineCell.CommandProperty, value);
                this.OnPropertyChanged("Command");
            }
        }

        // Token: 0x060004C7 RID: 1223 RVA: 0x00020C5D File Offset: 0x0001EE5D
        private void Handle_Tapped(object sender, EventArgs e)
        {
            ICommand command = this.Command;
            if (command == null)
            {
                return;
            }
            command.Execute(null);
        }

        // Token: 0x060004C8 RID: 1224 RVA: 0x00020C70 File Offset: 0x0001EE70
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(MineCell).GetTypeInfo().Assembly.GetName(), "Layout/MineCell.xaml") != null)
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
            BindingExtension bindingExtension = new BindingExtension();
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            BindingExtension bindingExtension2 = new BindingExtension();
            SvgCachedImage svgCachedImage = new SvgCachedImage();
            BindingExtension bindingExtension3 = new BindingExtension();
            Label label = new Label();
            SvgCachedImage svgCachedImage2 = new SvgCachedImage();
            Grid grid = new Grid();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(columnDefinition, nameScope);
            NameScope.SetNameScope(columnDefinition2, nameScope);
            NameScope.SetNameScope(columnDefinition3, nameScope);
            NameScope.SetNameScope(tapGestureRecognizer, nameScope);
            NameScope.SetNameScope(svgCachedImage, nameScope);
            ((INameScope)nameScope).RegisterName("icon", svgCachedImage);
            if (svgCachedImage.StyleId == null)
            {
                svgCachedImage.StyleId = "icon";
            }
            NameScope.SetNameScope(label, nameScope);
            ((INameScope)nameScope).RegisterName("label", label);
            if (label.StyleId == null)
            {
                label.StyleId = "label";
            }
            NameScope.SetNameScope(svgCachedImage2, nameScope);
            this.icon = svgCachedImage;
            this.label = label;
            grid.SetValue(Grid.ColumnSpacingProperty, 10.0);
            grid.SetValue(Layout.PaddingProperty, new Thickness(20.0, 0.0, 15.0, 0.0));
            columnDefinition.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("24"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition);
            columnDefinition2.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition2);
            columnDefinition3.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("15"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition3);
            bindingExtension.Path = "SelectCommand";
            BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue(null);
            tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, binding);
            grid.GestureRecognizers.Add(tapGestureRecognizer);
            svgCachedImage.SetValue(Grid.ColumnProperty, 0);
            svgCachedImage.SetValue(VisualElement.WidthRequestProperty, 24.0);
            svgCachedImage.SetValue(VisualElement.HeightRequestProperty, 24.0);
            svgCachedImage.SetValue(CachedImage.AspectProperty, Aspect.AspectFit);
            bindingExtension2.Path = "Icon";
            BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue(null);
            svgCachedImage.SetBinding(CachedImage.SourceProperty, binding2);
            svgCachedImage.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            grid.Children.Add(svgCachedImage);
            label.SetValue(Grid.ColumnProperty, 1);
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
            xmlNamespaceResolver.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(MineCell).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(14, 36)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider));
            label.SetValue(Label.TextColorProperty, Color.Black);
            bindingExtension3.Path = "Title";
            BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue(null);
            label.SetBinding(Label.TextProperty, binding3);
            label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Start"));
            grid.Children.Add(label);
            svgCachedImage2.SetValue(Grid.ColumnProperty, 2);
            svgCachedImage2.SetValue(VisualElement.WidthRequestProperty, 15.0);
            svgCachedImage2.SetValue(VisualElement.HeightRequestProperty, 15.0);
            svgCachedImage2.SetValue(CachedImage.AspectProperty, Aspect.AspectFit);
            svgCachedImage2.SetValue(CachedImage.SourceProperty, new FFImageLoading.Forms.ImageSourceConverter().ConvertFromInvariantString("rightarrow.svg"));
            svgCachedImage2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            grid.Children.Add(svgCachedImage2);
            this.View = grid;
        }

        // Token: 0x060004CA RID: 1226 RVA: 0x00021239 File Offset: 0x0001F439
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(MineCell));
            this.icon = this.FindByName("icon");
            this.label = this.FindByName("label");
        }

        // Token: 0x0400034A RID: 842
        public static readonly BindableProperty IconProperty = BindableProperty.Create("Icon", typeof(string), typeof(MineCell), "help.png", BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(MineCell.OnIconChanged), null, null, null);

        // Token: 0x0400034B RID: 843
        public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(MineCell), "设置", BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(MineCell.OnTitleChanged), null, null, null);

        // Token: 0x0400034C RID: 844
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(MineCell), null, BindingMode.OneWay, null, null, null, null, null);

        // Token: 0x0400034D RID: 845
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private SvgCachedImage icon;

        // Token: 0x0400034E RID: 846
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private Label label;
    }
}
