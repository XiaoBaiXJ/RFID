using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Layout
{
    // Token: 0x020000E1 RID: 225
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Layout\\PhotoCell.xaml")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class PhotoCell : ViewCell
    {
        // Token: 0x060004DE RID: 1246 RVA: 0x00021AD0 File Offset: 0x0001FCD0
        public PhotoCell()
        {
            this.InitializeComponent();
        }

        // Token: 0x17000164 RID: 356
        // (get) Token: 0x060004DF RID: 1247 RVA: 0x00021ADE File Offset: 0x0001FCDE
        // (set) Token: 0x060004E0 RID: 1248 RVA: 0x00021AF0 File Offset: 0x0001FCF0
        public string Title
        {
            get
            {
                return (string)base.GetValue(PhotoCell.TitleProperty);
            }
            set
            {
                if (string.Equals(this.Title, value, StringComparison.Ordinal))
                {
                    return;
                }
                base.SetValue(PhotoCell.TitleProperty, value);
                this.OnPropertyChanged("Title");
            }
        }

        // Token: 0x060004E1 RID: 1249 RVA: 0x00021B28 File Offset: 0x0001FD28
        private static void OnTitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            PhotoCell photoCell = bindable as PhotoCell;
            if (!newValue.Equals(oldValue))
            {
                photoCell.label.Text = newValue.ToString();
            }
        }

        // Token: 0x17000165 RID: 357
        // (get) Token: 0x060004E2 RID: 1250 RVA: 0x00021B56 File Offset: 0x0001FD56
        // (set) Token: 0x060004E3 RID: 1251 RVA: 0x00021B68 File Offset: 0x0001FD68
        public bool CanTakeMore
        {
            get
            {
                return (bool)base.GetValue(PhotoCell.CanTakeMoreProperty);
            }
            set
            {
                if (this.CanTakeMore == value)
                {
                    return;
                }
                base.SetValue(PhotoCell.CanTakeMoreProperty, value);
                this.OnPropertyChanged("CanTakeMore");
            }
        }

        // Token: 0x17000166 RID: 358
        // (get) Token: 0x060004E4 RID: 1252 RVA: 0x00021B9F File Offset: 0x0001FD9F
        // (set) Token: 0x060004E5 RID: 1253 RVA: 0x00021BB4 File Offset: 0x0001FDB4
        public List<byte[]> Files
        {
            get
            {
                return (List<byte[]>)base.GetValue(PhotoCell.FilesProperty);
            }
            set
            {
                if (object.Equals(this.Files, value))
                {
                    return;
                }
                base.SetValue(PhotoCell.FilesProperty, value);
                this.OnPropertyChanged("Files");
            }
        }

        // Token: 0x060004E6 RID: 1254 RVA: 0x00021BEC File Offset: 0x0001FDEC
        private void Handle_Finished(TakePhotoEventArgs args)
        {
            this.Files.Add(args.File);
            if (this.CanTakeMore)
            {
                PhotoView photoView = new PhotoView();
                photoView.Finished += this.Handle_Finished;
                photoView.Closed += this.Handle_Closed;
                this.photoSL.Children.Add(photoView);
            }
        }

        // Token: 0x060004E7 RID: 1255 RVA: 0x00021C50 File Offset: 0x0001FE50
        private void Handle_Closed(TakePhotoEventArgs args)
        {
            this.Files.Remove(args.File);
            if (this.photoSL.Children.Count == 0 || (this.photoSL.Children.Count == 1 && !this.firstPhoto.HasPhoto))
            {
                return;
            }
            if (this.CanTakeMore || this.photoSL.Children.Count > 1)
            {
                this.photoSL.Children.RemoveAt(this.photoSL.Children.Count - 1);
            }
        }

        // Token: 0x060004E8 RID: 1256 RVA: 0x00021CE0 File Offset: 0x0001FEE0
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(PhotoCell).GetTypeInfo().Assembly.GetName(), "Layout/PhotoCell.xaml") != null)
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
            PhotoView photoView = new PhotoView();
            StackLayout stackLayout = new StackLayout();
            StackLayout stackLayout2 = new StackLayout();
            ScrollView scrollView = new ScrollView();
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
            NameScope.SetNameScope(scrollView, nameScope);
            NameScope.SetNameScope(stackLayout2, nameScope);
            NameScope.SetNameScope(photoView, nameScope);
            ((INameScope)nameScope).RegisterName("firstPhoto", photoView);
            if (photoView.StyleId == null)
            {
                photoView.StyleId = "firstPhoto";
            }
            NameScope.SetNameScope(stackLayout, nameScope);
            ((INameScope)nameScope).RegisterName("photoSL", stackLayout);
            if (stackLayout.StyleId == null)
            {
                stackLayout.StyleId = "photoSL";
            }
            this.label = label;
            this.firstPhoto = photoView;
            this.photoSL = stackLayout;
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
            xmlNamespaceResolver.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(PhotoCell).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(16, 20)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider));
            label.SetValue(Label.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
            label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            label.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Start"));
            label.SetValue(Grid.ColumnProperty, 0);
            grid.Children.Add(label);
            scrollView.SetValue(Grid.ColumnProperty, 1);
            scrollView.SetValue(ScrollView.OrientationProperty, ScrollOrientation.Horizontal);
            scrollView.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            stackLayout2.SetValue(StackLayout.OrientationProperty, StackOrientation.Horizontal);
            photoView.Finished += this.Handle_Finished;
            photoView.Closed += this.Handle_Closed;
            stackLayout2.Children.Add(photoView);
            stackLayout.SetValue(StackLayout.OrientationProperty, StackOrientation.Horizontal);
            stackLayout2.Children.Add(stackLayout);
            scrollView.Content = stackLayout2;
            grid.Children.Add(scrollView);
            this.View = grid;
        }

        // Token: 0x060004EA RID: 1258 RVA: 0x0002224C File Offset: 0x0002044C
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(PhotoCell));
            this.label = this.FindByName("label");
            this.firstPhoto = this.FindByName("firstPhoto");
            this.photoSL = this.FindByName("photoSL");
        }

        // Token: 0x04000359 RID: 857
        public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(PhotoCell), "设置", BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(PhotoCell.OnTitleChanged), null, null, null);

        // Token: 0x0400035A RID: 858
        public static readonly BindableProperty CanTakeMoreProperty = BindableProperty.Create("CanTakeMore", typeof(bool), typeof(PhotoCell), false, BindingMode.OneWay, null, null, null, null, null);

        // Token: 0x0400035B RID: 859
        public static readonly BindableProperty FilesProperty = BindableProperty.Create("Files", typeof(List<byte[]>), typeof(PhotoCell), new List<byte[]>(), BindingMode.OneWay, null, null, null, null, null);

        // Token: 0x0400035C RID: 860
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private Label label;

        // Token: 0x0400035D RID: 861
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private PhotoView firstPhoto;

        // Token: 0x0400035E RID: 862
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private StackLayout photoSL;
    }
}
    