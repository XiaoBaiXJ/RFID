using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using FFImageLoading.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Layout
{
    // Token: 0x020000DD RID: 221
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Layout\\NewImageCell.xaml")]
    public class NewImageCell : ViewCell
    {
        // Token: 0x060004CB RID: 1227 RVA: 0x0002126E File Offset: 0x0001F46E
        public NewImageCell()
        {
            this.InitializeComponent();
        }

        // Token: 0x17000161 RID: 353
        // (get) Token: 0x060004CC RID: 1228 RVA: 0x0002127C File Offset: 0x0001F47C
        // (set) Token: 0x060004CD RID: 1229 RVA: 0x00021290 File Offset: 0x0001F490
        public string Title
        {
            get
            {
                return (string)base.GetValue(NewImageCell.TitleProperty);
            }
            set
            {
                if (string.Equals(this.Title, value, StringComparison.Ordinal))
                {
                    return;
                }
                base.SetValue(NewImageCell.TitleProperty, value);
                this.OnPropertyChanged("Title");
            }
        }

        // Token: 0x060004CE RID: 1230 RVA: 0x000212C8 File Offset: 0x0001F4C8
        private static void OnTitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            NewImageCell newImageCell = bindable as NewImageCell;
            if (!newValue.Equals(oldValue))
            {
                newImageCell.label.Text = newValue.ToString();
            }
        }

        // Token: 0x17000162 RID: 354
        // (get) Token: 0x060004CF RID: 1231 RVA: 0x000212F6 File Offset: 0x0001F4F6
        // (set) Token: 0x060004D0 RID: 1232 RVA: 0x00021308 File Offset: 0x0001F508
        public string Photo
        {
            get
            {
                return (string)base.GetValue(NewImageCell.PhotoProperty);
            }
            set
            {
                if (string.Equals(this.Photo, value, StringComparison.Ordinal))
                {
                    return;
                }
                base.SetValue(NewImageCell.PhotoProperty, value);
                this.OnPropertyChanged("Photo");
            }
        }

        // Token: 0x060004D1 RID: 1233 RVA: 0x00021340 File Offset: 0x0001F540
        private static void OnPhotoChanged(BindableObject bindable, object oldValue, object newValue)
        {
            NewImageCell newImageCell = bindable as NewImageCell;
            if (newValue != null && !newValue.Equals(oldValue))
            {
                newImageCell.image.Source = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(newValue.ToString())));
            }
        }

        // Token: 0x060004D2 RID: 1234 RVA: 0x00021394 File Offset: 0x0001F594
        private async Task TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (this.image.Source != null)
            {
                ContentPage contentPage = new ContentPage
                {
                    BackgroundColor = Color.Black,
                    Title = "照片展示"
                };
                contentPage.Content = new CachedImage
                {
                    Source = this.image.Source
                };
                await App.CurNavigationPage.Navigation.PushAsync(contentPage);
            }
        }

        // Token: 0x060004D3 RID: 1235 RVA: 0x000213DC File Offset: 0x0001F5DC
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(NewImageCell).GetTypeInfo().Assembly.GetName(), "Layout/NewImageCell.xaml") != null)
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
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            Image image = new Image();
            Grid grid = new Grid();
            Grid grid2 = new Grid();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(grid2, nameScope);
            NameScope.SetNameScope(columnDefinition, nameScope);
            NameScope.SetNameScope(columnDefinition2, nameScope);
            NameScope.SetNameScope(rowDefinition, nameScope);
            NameScope.SetNameScope(label, nameScope);
            ((INameScope)nameScope).RegisterName("label", label);
            if (label.StyleId == null)
            {
                label.StyleId = "label";
            }
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(image, nameScope);
            ((INameScope)nameScope).RegisterName("image", image);
            if (image.StyleId == null)
            {
                image.StyleId = "image";
            }
            NameScope.SetNameScope(tapGestureRecognizer, nameScope);
            this.label = label;
            this.image = image;
            grid2.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            grid2.SetValue(Grid.RowSpacingProperty, 5.0);
            grid2.SetValue(Layout.PaddingProperty, new Thickness(10.0, 5.0, 10.0, 5.0));
            columnDefinition.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid2.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition);
            columnDefinition2.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("3*"));
            grid2.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition2);
            rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("90"));
            grid2.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition);
            BindableObject bindableObject = label;
            BindableProperty fontSizeProperty = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter = new FontSizeConverter();
            string value = "Default";
            XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
            Type typeFromHandle = typeof(IProvideValueTarget);
            object[] array = new object[0 + 3];
            array[0] = label;
            array[1] = grid2;
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
            xmlNamespaceResolver.Add("image", "clr-namespace:FFImageLoading.Forms;assembly=FFImageLoading.Forms");
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(NewImageCell).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(15, 20)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider));
            label.SetValue(Label.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
            label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
            label.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Start"));
            label.SetValue(Grid.ColumnProperty, 0);
            grid2.Children.Add(label);
            grid.SetValue(Grid.ColumnProperty, 1);
            image.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Start);
            image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            image.SetValue(VisualElement.HeightRequestProperty, 90.0);
            image.SetValue(VisualElement.WidthRequestProperty, 90.0);
            image.SetValue(Image.AspectProperty, Aspect.AspectFill);
            tapGestureRecognizer.Tapped += new EventHandler(this.TapGestureRecognizer_Tapped);
            image.GestureRecognizers.Add(tapGestureRecognizer);
            grid.Children.Add(image);
            grid2.Children.Add(grid);
            this.View = grid2;
        }

        // Token: 0x060004D5 RID: 1237 RVA: 0x000218DB File Offset: 0x0001FADB
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(NewImageCell));
            this.label = this.FindByName("label");
            this.image = this.FindByName("image");
        }

        // Token: 0x0400034F RID: 847
        public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(NewImageCell), "设置", BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(NewImageCell.OnTitleChanged), null, null, null);

        // Token: 0x04000350 RID: 848
        public static readonly BindableProperty PhotoProperty = BindableProperty.Create("Photo", typeof(string), typeof(NewImageCell), null, BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(NewImageCell.OnPhotoChanged), null, null, null);

        // Token: 0x04000351 RID: 849
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private Label label;

        // Token: 0x04000352 RID: 850
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private Image image;
    }
}
