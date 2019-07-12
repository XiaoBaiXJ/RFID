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
    // Token: 0x020000DB RID: 219
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Layout\\FuncView.xaml")]
    public class FuncView : ContentView
    {
        // Token: 0x060004B1 RID: 1201 RVA: 0x000204B4 File Offset: 0x0001E6B4
        public FuncView()
        {
            this.InitializeComponent();
        }

        // Token: 0x1700015B RID: 347
        // (get) Token: 0x060004B2 RID: 1202 RVA: 0x000204C2 File Offset: 0x0001E6C2
        // (set) Token: 0x060004B3 RID: 1203 RVA: 0x000204D4 File Offset: 0x0001E6D4
        public string Icon
        {
            get
            {
                return (string)base.GetValue(FuncView.IconProperty);
            }
            set
            {
                if (string.Equals(this.Icon, value, StringComparison.Ordinal))
                {
                    return;
                }
                base.SetValue(FuncView.IconProperty, value);
                this.OnPropertyChanged("Icon");
            }
        }

        // Token: 0x060004B4 RID: 1204 RVA: 0x0002050C File Offset: 0x0001E70C
        private static void OnIconChanged(BindableObject bindable, object oldValue, object newValue)
        {
            FuncView funcView = bindable as FuncView;
            if (!oldValue.Equals(newValue))
            {
                funcView.image.Source = SvgImageSource.FromFile(newValue.ToString(), 0, 0, true, null);
            }
        }

        // Token: 0x1700015C RID: 348
        // (get) Token: 0x060004B5 RID: 1205 RVA: 0x00020543 File Offset: 0x0001E743
        // (set) Token: 0x060004B6 RID: 1206 RVA: 0x00020558 File Offset: 0x0001E758
        public string Title
        {
            get
            {
                return (string)base.GetValue(FuncView.TitleProperty);
            }
            set
            {
                if (string.Equals(this.Title, value, StringComparison.Ordinal))
                {
                    return;
                }
                base.SetValue(FuncView.TitleProperty, value);
                this.OnPropertyChanged("Title");
            }
        }

        // Token: 0x060004B7 RID: 1207 RVA: 0x00020590 File Offset: 0x0001E790
        private static void OnTitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            FuncView funcView = bindable as FuncView;
            if (!oldValue.Equals(newValue))
            {
                funcView.label.Text = newValue.ToString();
            }
        }

        // Token: 0x1700015D RID: 349
        // (get) Token: 0x060004B8 RID: 1208 RVA: 0x000205BE File Offset: 0x0001E7BE
        // (set) Token: 0x060004B9 RID: 1209 RVA: 0x000205D0 File Offset: 0x0001E7D0
        public ICommand Command
        {
            get
            {
                return (ICommand)base.GetValue(FuncView.CommandProperty);
            }
            set
            {
                if (object.Equals(this.Command, value))
                {
                    return;
                }
                base.SetValue(FuncView.CommandProperty, value);
                this.OnPropertyChanged("Command");
            }
        }

        // Token: 0x060004BA RID: 1210 RVA: 0x00020605 File Offset: 0x0001E805
        private void Handle_Tapped(object sender, EventArgs e)
        {
            ICommand command = this.Command;
            if (command == null)
            {
                return;
            }
            command.Execute(null);
        }

        // Token: 0x060004BB RID: 1211 RVA: 0x00020618 File Offset: 0x0001E818
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(FuncView).GetTypeInfo().Assembly.GetName(), "Layout/FuncView.xaml") != null)
            {
                this.__InitComponentRuntime();
                return;
            }
            if (XamlLoader.XamlFileProvider != null && XamlLoader.XamlFileProvider(base.GetType()) != null)
            {
                this.__InitComponentRuntime();
                return;
            }
            RowDefinition rowDefinition = new RowDefinition();
            RowDefinition rowDefinition2 = new RowDefinition();
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            SvgCachedImage svgCachedImage = new SvgCachedImage();
            Label label = new Label();
            Grid grid = new Grid();
            Frame frame = new Frame();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(frame, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(rowDefinition, nameScope);
            NameScope.SetNameScope(rowDefinition2, nameScope);
            NameScope.SetNameScope(tapGestureRecognizer, nameScope);
            NameScope.SetNameScope(svgCachedImage, nameScope);
            ((INameScope)nameScope).RegisterName("image", svgCachedImage);
            if (svgCachedImage.StyleId == null)
            {
                svgCachedImage.StyleId = "image";
            }
            NameScope.SetNameScope(label, nameScope);
            ((INameScope)nameScope).RegisterName("label", label);
            if (label.StyleId == null)
            {
                label.StyleId = "label";
            }
            this.image = svgCachedImage;
            this.label = label;
            frame.SetValue(Frame.HasShadowProperty, false);
            frame.SetValue(Frame.CornerRadiusProperty, 5f);
            frame.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(0.0));
            grid.SetValue(Grid.RowSpacingProperty, 3.0);
            rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("3*"));
            grid.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition);
            rowDefinition2.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("2*"));
            grid.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition2);
            tapGestureRecognizer.Tapped += this.Handle_Tapped;
            grid.GestureRecognizers.Add(tapGestureRecognizer);
            svgCachedImage.SetValue(CachedImage.AspectProperty, Aspect.AspectFit);
            svgCachedImage.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
            svgCachedImage.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
            svgCachedImage.SetValue(VisualElement.WidthRequestProperty, 50.0);
            svgCachedImage.SetValue(VisualElement.HeightRequestProperty, 50.0);
            svgCachedImage.SetValue(Grid.RowProperty, 0);
            grid.Children.Add(svgCachedImage);
            label.SetValue(Label.TextColorProperty, Color.Black);
            BindableObject bindableObject = label;
            BindableProperty fontSizeProperty = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter = new FontSizeConverter();
            string value = "Medium";
            XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
            Type typeFromHandle = typeof(IProvideValueTarget);
            object[] array = new object[0 + 4];
            array[0] = label;
            array[1] = grid;
            array[2] = frame;
            array[3] = this;
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
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(FuncView).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(15, 53)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider));
            label.SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
            label.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
            label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
            label.SetValue(Grid.RowProperty, 1);
            grid.Children.Add(label);
            frame.SetValue(ContentView.ContentProperty, grid);
            this.SetValue(ContentView.ContentProperty, frame);
        }

        // Token: 0x060004BD RID: 1213 RVA: 0x00020AE5 File Offset: 0x0001ECE5
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(FuncView));
            this.image = this.FindByName("image");
            this.label = this.FindByName("label");
        }

        // Token: 0x04000345 RID: 837
        public static readonly BindableProperty IconProperty = BindableProperty.Create("Icon", typeof(string), typeof(FuncView), "", BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(FuncView.OnIconChanged), null, null, null);

        // Token: 0x04000346 RID: 838
        public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(FuncView), "设置", BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(FuncView.OnTitleChanged), null, null, null);

        // Token: 0x04000347 RID: 839
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(FuncView), null, BindingMode.OneWay, null, null, null, null, null);

        // Token: 0x04000348 RID: 840
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private SvgCachedImage image;

        // Token: 0x04000349 RID: 841
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private Label label;
    }
}
