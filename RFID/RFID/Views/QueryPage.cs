using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Runtime.CompilerServices;
using Android.Content;
using FFImageLoading.Forms;
using FFImageLoading.Svg.Forms;
using Plugin.CurrentActivity;
using RFID.Common;
using RFID.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Views
{
    // Token: 0x02000060 RID: 96
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Views\\QueryPage.xaml")]
    public class QueryPage : ContentPage
    {
        // Token: 0x06000245 RID: 581 RVA: 0x0000B964 File Offset: 0x00009B64
        public QueryPage()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000246 RID: 582 RVA: 0x0000B974 File Offset: 0x00009B74
        private void Handle_Tapped(object sender, EventArgs e)
        {
            Grid grid = sender as Grid;
            RFidInfo rfidInfo = (RFidInfo)grid.BindingContext;
            Intent intent = new Intent(CrossCurrentActivity.Current.Activity, typeof(AMapActivity));
            intent.PutExtra("StartLatitude", Convert.ToDouble(rfidInfo.BeginLatitude));
            intent.PutExtra("StartLongitude", Convert.ToDouble(rfidInfo.BeginLongitude));
            intent.PutExtra("startAddress", rfidInfo.BeginAddress);
            if (!string.IsNullOrEmpty(rfidInfo.EndAddress))
            {
                intent.PutExtra("isLine", true);
                intent.PutExtra("EndLatitude", Convert.ToDouble(rfidInfo.EndLatitude));
                intent.PutExtra("EndLongitude", Convert.ToDouble(rfidInfo.EndLongitude));
                intent.PutExtra("endAddress", rfidInfo.EndAddress);
            }
            CrossCurrentActivity.Current.Activity.StartActivity(intent);
        }

        // Token: 0x06000247 RID: 583 RVA: 0x0000BA58 File Offset: 0x00009C58
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(QueryPage).GetTypeInfo().Assembly.GetName(), "Views/QueryPage.xaml") != null)
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
            Label label = new Label();
            BindingExtension bindingExtension2 = new BindingExtension();
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            Label label2 = new Label();
            Grid grid = new Grid();
            BindingExtension bindingExtension3 = new BindingExtension();
            TapGestureRecognizer tapGestureRecognizer2 = new TapGestureRecognizer();
            BindingExtension bindingExtension4 = new BindingExtension();
            Label label3 = new Label();
            SvgCachedImage svgCachedImage = new SvgCachedImage();
            Grid grid2 = new Grid();
            BindingExtension bindingExtension5 = new BindingExtension();
            BindingExtension bindingExtension6 = new BindingExtension();
            BindingExtension bindingExtension7 = new BindingExtension();
            DataTemplate dataTemplate = new DataTemplate();
            ListView listView = new ListView(ListViewCachingStrategy.RecycleElement);
            StackLayout stackLayout = new StackLayout();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(stackLayout, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(label, nameScope);
            NameScope.SetNameScope(label2, nameScope);
            NameScope.SetNameScope(tapGestureRecognizer, nameScope);
            NameScope.SetNameScope(grid2, nameScope);
            NameScope.SetNameScope(tapGestureRecognizer2, nameScope);
            NameScope.SetNameScope(label3, nameScope);
            NameScope.SetNameScope(svgCachedImage, nameScope);
            NameScope.SetNameScope(listView, nameScope);
            ((INameScope)nameScope).RegisterName("listView", listView);
            if (listView.StyleId == null)
            {
                listView.StyleId = "listView";
            }
            this.listView = listView;
            stackLayout.SetValue(StackLayout.SpacingProperty, 0.0);
            stackLayout.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            grid.SetValue(VisualElement.HeightRequestProperty, 40.0);
            grid.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(10.0));
            grid.SetValue(VisualElement.BackgroundColorProperty, Color.Black);
            grid.SetValue(VisualElement.OpacityProperty, 0.8);
            bindingExtension.Path = "Title";
            BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue(null);
            label.SetBinding(Label.TextProperty, binding);
            label.SetValue(Label.TextColorProperty, Color.White);
            BindableObject bindableObject = label;
            BindableProperty fontSizeProperty = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter = new FontSizeConverter();
            string value = "Default";
            XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
            Type typeFromHandle = typeof(IProvideValueTarget);
            object[] array = new object[0 + 4];
            array[0] = label;
            array[1] = grid;
            array[2] = stackLayout;
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
            xmlNamespaceResolver.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver.Add("local", "clr-namespace:RFID");
            xmlNamespaceResolver.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xmlNamespaceResolver.Add("scroll", "clr-namespace:Xamarin.Forms.Extended;assembly=Xamarin.Forms.Extended.InfiniteScrolling");
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(QueryPage).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(11, 65)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider));
            label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
            label.SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
            label.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
            label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            grid.Children.Add(label);
            label2.SetValue(Label.TextProperty, "车辆筛选");
            label2.SetValue(Label.TextColorProperty, Color.White);
            BindableObject bindableObject2 = label2;
            BindableProperty fontSizeProperty2 = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter2 = new FontSizeConverter();
            string value2 = "Default";
            XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
            Type typeFromHandle3 = typeof(IProvideValueTarget);
            object[] array2 = new object[0 + 4];
            array2[0] = label2;
            array2[1] = grid;
            array2[2] = stackLayout;
            array2[3] = this;
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
            xmlNamespaceResolver2.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xmlNamespaceResolver2.Add("scroll", "clr-namespace:Xamarin.Forms.Extended;assembly=Xamarin.Forms.Extended.InfiniteScrolling");
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(QueryPage).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(12, 54)));
            bindableObject2.SetValue(fontSizeProperty2, extendedTypeConverter2.ConvertFromInvariantString(value2, xamlServiceProvider2));
            label2.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("End"));
            label2.SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
            label2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
            label2.SetValue(View.VerticalOptionsProperty, LayoutOptions.FillAndExpand);
            bindingExtension2.Path = "CarCommand";
            BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue(null);
            tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, binding2);
            label2.GestureRecognizers.Add(tapGestureRecognizer);
            grid.Children.Add(label2);
            stackLayout.Children.Add(grid);
            grid2.SetValue(VisualElement.BackgroundColorProperty, new Color(0.91764706373214722, 0.91764706373214722, 0.91764706373214722, 1.0));
            grid2.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(10.0, 10.0, 20.0, 10.0));
            bindingExtension3.Path = "DateCommand";
            BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue(null);
            tapGestureRecognizer2.SetBinding(TapGestureRecognizer.CommandProperty, binding3);
            grid2.GestureRecognizers.Add(tapGestureRecognizer2);
            bindingExtension4.Path = "DateText";
            BindingBase binding4 = ((IMarkupExtension<BindingBase>)bindingExtension4).ProvideValue(null);
            label3.SetBinding(Label.TextProperty, binding4);
            label3.SetValue(Label.TextColorProperty, new Color(0.4117647111415863, 0.4117647111415863, 0.4117647111415863, 1.0));
            BindableObject bindableObject3 = label3;
            BindableProperty fontSizeProperty3 = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter3 = new FontSizeConverter();
            string value3 = "Default";
            XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider();
            Type typeFromHandle5 = typeof(IProvideValueTarget);
            object[] array3 = new object[0 + 4];
            array3[0] = label3;
            array3[1] = grid2;
            array3[2] = stackLayout;
            array3[3] = this;
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
            xmlNamespaceResolver3.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xmlNamespaceResolver3.Add("scroll", "clr-namespace:Xamarin.Forms.Extended;assembly=Xamarin.Forms.Extended.InfiniteScrolling");
            xamlServiceProvider3.Add(typeFromHandle6, new XamlTypeResolver(xmlNamespaceResolver3, typeof(QueryPage).GetTypeInfo().Assembly));
            xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(19, 70)));
            bindableObject3.SetValue(fontSizeProperty3, extendedTypeConverter3.ConvertFromInvariantString(value3, xamlServiceProvider3));
            label3.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Start);
            label3.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            grid2.Children.Add(label3);
            svgCachedImage.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
            svgCachedImage.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            svgCachedImage.SetValue(CachedImage.SourceProperty, new FFImageLoading.Forms.ImageSourceConverter().ConvertFromInvariantString("calendar.svg"));
            svgCachedImage.SetValue(VisualElement.WidthRequestProperty, 24.0);
            svgCachedImage.SetValue(VisualElement.HeightRequestProperty, 24.0);
            grid2.Children.Add(svgCachedImage);
            stackLayout.Children.Add(grid2);
            listView.SetValue(ListView.HasUnevenRowsProperty, true);
            listView.SetValue(ListView.SelectionModeProperty, ListViewSelectionMode.None);
            listView.SetValue(ListView.SeparatorVisibilityProperty, SeparatorVisibility.None);
            listView.SetValue(ListView.IsPullToRefreshEnabledProperty, true);
            listView.RefreshAllowed = true;
            bindingExtension5.Path = "IsBusy";
            BindingBase binding5 = ((IMarkupExtension<BindingBase>)bindingExtension5).ProvideValue(null);
            listView.SetBinding(ListView.IsRefreshingProperty, binding5);
            bindingExtension6.Path = "RefreshCommand";
            BindingBase binding6 = ((IMarkupExtension<BindingBase>)bindingExtension6).ProvideValue(null);
            listView.SetBinding(ListView.RefreshCommandProperty, binding6);
            bindingExtension7.Path = "Items";
            BindingBase binding7 = ((IMarkupExtension<BindingBase>)bindingExtension7).ProvideValue(null);
            listView.SetBinding(ItemsView<Cell>.ItemsSourceProperty, binding7);
            IDataTemplate dataTemplate2 = dataTemplate;
            QueryPage.< InitializeComponent > _anonXamlCDataTemplate_0 < InitializeComponent > _anonXamlCDataTemplate_ = new QueryPage.< InitializeComponent > _anonXamlCDataTemplate_0();
            object[] array4 = new object[0 + 4];
            array4[0] = dataTemplate;
            array4[1] = listView;
            array4[2] = stackLayout;
            array4[3] = this;

            < InitializeComponent > _anonXamlCDataTemplate_.parentValues = array4;

            < InitializeComponent > _anonXamlCDataTemplate_.root = this;
            dataTemplate2.LoadTemplate = new Func<object>(< InitializeComponent > _anonXamlCDataTemplate_.LoadDataTemplate);
            listView.SetValue(ItemsView<Cell>.ItemTemplateProperty, dataTemplate);
            stackLayout.Children.Add(listView);
            this.SetValue(ContentPage.ContentProperty, stackLayout);
        }

        // Token: 0x06000248 RID: 584 RVA: 0x0000C436 File Offset: 0x0000A636
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(QueryPage));
            this.listView = this.FindByName("listView");
        }

        // Token: 0x04000133 RID: 307
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private ListView listView;

        // Token: 0x02000061 RID: 97
        [CompilerGenerated]
        private sealed class <InitializeComponent>_anonXamlCDataTemplate_0
		{
			// Token: 0x0600024A RID: 586 RVA: 0x0000C470 File Offset: 0x0000A670
			internal object LoadDataTemplate()
        {
            ColumnDefinition columnDefinition = new ColumnDefinition();
            ColumnDefinition columnDefinition2 = new ColumnDefinition();
            ColumnDefinition columnDefinition3 = new ColumnDefinition();
            BindingExtension bindingExtension = new BindingExtension();
            Label label = new Label();
            BoxView boxView = new BoxView();
            SvgCachedImage svgCachedImage = new SvgCachedImage();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            RowDefinition rowDefinition = new RowDefinition();
            RowDefinition rowDefinition2 = new RowDefinition();
            RowDefinition rowDefinition3 = new RowDefinition();
            RowDefinition rowDefinition4 = new RowDefinition();
            BindingExtension bindingExtension2 = new BindingExtension();
            Label label2 = new Label();
            BindingExtension bindingExtension3 = new BindingExtension();
            Label label3 = new Label();
            BindingExtension bindingExtension4 = new BindingExtension();
            Label label4 = new Label();
            Grid grid = new Grid();
            ColumnDefinition columnDefinition4 = new ColumnDefinition();
            ColumnDefinition columnDefinition5 = new ColumnDefinition();
            RowDefinition rowDefinition5 = new RowDefinition();
            RowDefinition rowDefinition6 = new RowDefinition();
            ColumnDefinition columnDefinition6 = new ColumnDefinition();
            ColumnDefinition columnDefinition7 = new ColumnDefinition();
            BindingExtension bindingExtension5 = new BindingExtension();
            BindingExtension bindingExtension6 = new BindingExtension();
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            SvgCachedImage svgCachedImage2 = new SvgCachedImage();
            Label label5 = new Label();
            Grid grid2 = new Grid();
            ColumnDefinition columnDefinition8 = new ColumnDefinition();
            ColumnDefinition columnDefinition9 = new ColumnDefinition();
            TapGestureRecognizer tapGestureRecognizer2 = new TapGestureRecognizer();
            SvgCachedImage svgCachedImage3 = new SvgCachedImage();
            Label label6 = new Label();
            Grid grid3 = new Grid();
            BindingExtension bindingExtension7 = new BindingExtension();
            ColumnDefinition columnDefinition10 = new ColumnDefinition();
            ColumnDefinition columnDefinition11 = new ColumnDefinition();
            BindingExtension bindingExtension8 = new BindingExtension();
            BindingExtension bindingExtension9 = new BindingExtension();
            TapGestureRecognizer tapGestureRecognizer3 = new TapGestureRecognizer();
            SvgCachedImage svgCachedImage4 = new SvgCachedImage();
            Label label7 = new Label();
            Grid grid4 = new Grid();
            Grid grid5 = new Grid();
            Grid grid6 = new Grid();
            Frame frame = new Frame();
            Grid grid7 = new Grid();
            Grid grid8 = new Grid();
            ViewCell viewCell = new ViewCell();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(viewCell, nameScope);
            NameScope.SetNameScope(grid8, nameScope);
            NameScope.SetNameScope(columnDefinition, nameScope);
            NameScope.SetNameScope(columnDefinition2, nameScope);
            NameScope.SetNameScope(columnDefinition3, nameScope);
            NameScope.SetNameScope(label, nameScope);
            NameScope.SetNameScope(absoluteLayout, nameScope);
            NameScope.SetNameScope(boxView, nameScope);
            NameScope.SetNameScope(svgCachedImage, nameScope);
            NameScope.SetNameScope(grid7, nameScope);
            NameScope.SetNameScope(frame, nameScope);
            NameScope.SetNameScope(grid6, nameScope);
            NameScope.SetNameScope(rowDefinition, nameScope);
            NameScope.SetNameScope(rowDefinition2, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(rowDefinition3, nameScope);
            NameScope.SetNameScope(rowDefinition4, nameScope);
            NameScope.SetNameScope(label2, nameScope);
            NameScope.SetNameScope(label3, nameScope);
            NameScope.SetNameScope(label4, nameScope);
            NameScope.SetNameScope(grid5, nameScope);
            NameScope.SetNameScope(columnDefinition4, nameScope);
            NameScope.SetNameScope(columnDefinition5, nameScope);
            NameScope.SetNameScope(rowDefinition5, nameScope);
            NameScope.SetNameScope(rowDefinition6, nameScope);
            NameScope.SetNameScope(grid2, nameScope);
            NameScope.SetNameScope(columnDefinition6, nameScope);
            NameScope.SetNameScope(columnDefinition7, nameScope);
            NameScope.SetNameScope(tapGestureRecognizer, nameScope);
            NameScope.SetNameScope(svgCachedImage2, nameScope);
            NameScope.SetNameScope(label5, nameScope);
            NameScope.SetNameScope(grid3, nameScope);
            NameScope.SetNameScope(columnDefinition8, nameScope);
            NameScope.SetNameScope(columnDefinition9, nameScope);
            NameScope.SetNameScope(tapGestureRecognizer2, nameScope);
            NameScope.SetNameScope(svgCachedImage3, nameScope);
            NameScope.SetNameScope(label6, nameScope);
            NameScope.SetNameScope(grid4, nameScope);
            NameScope.SetNameScope(columnDefinition10, nameScope);
            NameScope.SetNameScope(columnDefinition11, nameScope);
            NameScope.SetNameScope(tapGestureRecognizer3, nameScope);
            NameScope.SetNameScope(svgCachedImage4, nameScope);
            NameScope.SetNameScope(label7, nameScope);
            grid8.SetValue(VisualElement.BackgroundColorProperty, new Color(0.98039215803146362, 0.98039215803146362, 0.98039215803146362, 1.0));
            grid8.SetValue(Grid.ColumnSpacingProperty, 15.0);
            columnDefinition.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("40"));
            grid8.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition);
            columnDefinition2.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("24"));
            grid8.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition2);
            columnDefinition3.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid8.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition3);
            label.SetValue(Grid.ColumnProperty, 0);
            bindingExtension.Path = "DateDay";
            BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue(null);
            label.SetBinding(Label.TextProperty, binding);
            label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
            label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
            label.SetValue(Label.TextColorProperty, Color.Black);
            grid8.Children.Add(label);
            absoluteLayout.SetValue(Grid.ColumnProperty, 1);
            absoluteLayout.SetValue(VisualElement.BackgroundColorProperty, Color.Transparent);
            absoluteLayout.SetValue(View.VerticalOptionsProperty, LayoutOptions.FillAndExpand);
            boxView.SetValue(AbsoluteLayout.LayoutFlagsProperty, AbsoluteLayoutFlags.HeightProportional);
            boxView.SetValue(AbsoluteLayout.LayoutBoundsProperty, new Rectangle(3.0, 0.0, 18.0, 1.0));
            boxView.SetValue(VisualElement.BackgroundColorProperty, new Color(0.91764706373214722, 0.91764706373214722, 0.91764706373214722, 1.0));
            absoluteLayout.Children.Add(boxView);
            svgCachedImage.SetValue(CachedImage.SourceProperty, new FFImageLoading.Forms.ImageSourceConverter().ConvertFromInvariantString("target.svg"));
            svgCachedImage.SetValue(AbsoluteLayout.LayoutFlagsProperty, AbsoluteLayoutFlags.PositionProportional);
            svgCachedImage.SetValue(AbsoluteLayout.LayoutBoundsProperty, new Rectangle(0.0, 0.0, 24.0, 24.0));
            absoluteLayout.Children.Add(svgCachedImage);
            grid8.Children.Add(absoluteLayout);
            grid7.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(10.0, 10.0, 20.0, 10.0));
            grid7.SetValue(Grid.ColumnProperty, 2);
            grid7.SetValue(VisualElement.BackgroundColorProperty, new Color(0.98039215803146362, 0.98039215803146362, 0.98039215803146362, 1.0));
            frame.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(0.0));
            grid6.SetValue(Grid.RowSpacingProperty, 1.0);
            grid6.SetValue(VisualElement.BackgroundColorProperty, new Color(0.91764706373214722, 0.91764706373214722, 0.91764706373214722, 1.0));
            rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid6.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition);
            rowDefinition2.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid6.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition2);
            grid.SetValue(Grid.RowProperty, 0);
            grid.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            rowDefinition3.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition3);
            rowDefinition4.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition4);
            label2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 0.0, 0.0));
            label2.SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
            label2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Start);
            label2.SetValue(Label.TextColorProperty, Color.Black);
            label2.SetValue(Grid.RowProperty, 0);
            BindableObject bindableObject = label2;
            BindableProperty fontSizeProperty = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter = new FontSizeConverter();
            string value = "Default";
            XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
            Type typeFromHandle = typeof(IProvideValueTarget);
            int length;
            object[] array = new object[(length = this.parentValues.Length) + 7];
            Array.Copy(this.parentValues, 0, array, 7, length);
            object[] array2 = array;
            array2[0] = label2;
            array2[1] = grid;
            array2[2] = grid6;
            array2[3] = frame;
            array2[4] = grid7;
            array2[5] = grid8;
            array2[6] = viewCell;
            xamlServiceProvider.Add(typeFromHandle, new SimpleValueTargetProvider(array2, Label.FontSizeProperty));
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
            xmlNamespaceResolver.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xmlNamespaceResolver.Add("scroll", "clr-namespace:Xamarin.Forms.Extended;assembly=Xamarin.Forms.Extended.InfiniteScrolling");
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(QueryPage.< InitializeComponent > _anonXamlCDataTemplate_0).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(68, 158)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider));
            bindingExtension2.Path = "CarID";
            BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue(null);
            label2.SetBinding(Label.TextProperty, binding2);
            grid.Children.Add(label2);
            label3.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 20.0, 0.0));
            label3.SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
            label3.SetValue(View.HorizontalOptionsProperty, LayoutOptions.EndAndExpand);
            label3.SetValue(Label.TextColorProperty, Color.Red);
            label3.SetValue(Grid.RowProperty, 0);
            BindableObject bindableObject2 = label3;
            BindableProperty fontSizeProperty2 = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter2 = new FontSizeConverter();
            string value2 = "Default";
            XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
            Type typeFromHandle3 = typeof(IProvideValueTarget);
            int length2;
            object[] array3 = new object[(length2 = this.parentValues.Length) + 7];
            Array.Copy(this.parentValues, 0, array3, 7, length2);
            object[] array4 = array3;
            array4[0] = label3;
            array4[1] = grid;
            array4[2] = grid6;
            array4[3] = frame;
            array4[4] = grid7;
            array4[5] = grid8;
            array4[6] = viewCell;
            xamlServiceProvider2.Add(typeFromHandle3, new SimpleValueTargetProvider(array4, Label.FontSizeProperty));
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
            xmlNamespaceResolver2.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xmlNamespaceResolver2.Add("scroll", "clr-namespace:Xamarin.Forms.Extended;assembly=Xamarin.Forms.Extended.InfiniteScrolling");
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(QueryPage.< InitializeComponent > _anonXamlCDataTemplate_0).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(69, 167)));
            bindableObject2.SetValue(fontSizeProperty2, extendedTypeConverter2.ConvertFromInvariantString(value2, xamlServiceProvider2));
            bindingExtension3.Path = "EBillStatus";
            BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue(null);
            label3.SetBinding(Label.TextProperty, binding3);
            grid.Children.Add(label3);
            label4.SetValue(View.MarginProperty, new Thickness(10.0, 0.0, 0.0, 0.0));
            label4.SetValue(Label.TextColorProperty, new Color(0.4117647111415863, 0.4117647111415863, 0.4117647111415863, 1.0));
            label4.SetValue(Grid.RowProperty, 1);
            BindableObject bindableObject3 = label4;
            BindableProperty fontSizeProperty3 = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter3 = new FontSizeConverter();
            string value3 = "Default";
            XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider();
            Type typeFromHandle5 = typeof(IProvideValueTarget);
            int length3;
            object[] array5 = new object[(length3 = this.parentValues.Length) + 7];
            Array.Copy(this.parentValues, 0, array5, 7, length3);
            object[] array6 = array5;
            array6[0] = label4;
            array6[1] = grid;
            array6[2] = grid6;
            array6[3] = frame;
            array6[4] = grid7;
            array6[5] = grid8;
            array6[6] = viewCell;
            xamlServiceProvider3.Add(typeFromHandle5, new SimpleValueTargetProvider(array6, Label.FontSizeProperty));
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
            xmlNamespaceResolver3.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xmlNamespaceResolver3.Add("scroll", "clr-namespace:Xamarin.Forms.Extended;assembly=Xamarin.Forms.Extended.InfiniteScrolling");
            xamlServiceProvider3.Add(typeFromHandle6, new XamlTypeResolver(xmlNamespaceResolver3, typeof(QueryPage.< InitializeComponent > _anonXamlCDataTemplate_0).GetTypeInfo().Assembly));
            xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(70, 103)));
            bindableObject3.SetValue(fontSizeProperty3, extendedTypeConverter3.ConvertFromInvariantString(value3, xamlServiceProvider3));
            bindingExtension4.Path = "Detail";
            BindingBase binding4 = ((IMarkupExtension<BindingBase>)bindingExtension4).ProvideValue(null);
            label4.SetBinding(Label.TextProperty, binding4);
            grid.Children.Add(label4);
            grid6.Children.Add(grid);
            grid5.SetValue(VisualElement.BackgroundColorProperty, Color.Black);
            grid5.SetValue(Grid.RowProperty, 1);
            grid5.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            grid5.SetValue(View.VerticalOptionsProperty, LayoutOptions.FillAndExpand);
            columnDefinition4.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid5.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition4);
            columnDefinition5.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid5.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition5);
            rowDefinition5.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid5.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition5);
            rowDefinition6.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid5.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition6);
            grid2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
            grid2.SetValue(Grid.RowProperty, 0);
            grid2.SetValue(Grid.ColumnProperty, 0);
            columnDefinition6.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid2.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition6);
            columnDefinition7.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid2.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition7);
            bindingExtension5.Path = "LocationCommand";
            BindingBase binding5 = ((IMarkupExtension<BindingBase>)bindingExtension5).ProvideValue(null);
            tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, binding5);
            bindingExtension6.Path = "RFIDInfoOid";
            BindingBase binding6 = ((IMarkupExtension<BindingBase>)bindingExtension6).ProvideValue(null);
            tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandParameterProperty, binding6);
            grid2.GestureRecognizers.Add(tapGestureRecognizer);
            svgCachedImage2.SetValue(CachedImage.SourceProperty, new FFImageLoading.Forms.ImageSourceConverter().ConvertFromInvariantString("whitelock.svg"));
            svgCachedImage2.SetValue(Grid.ColumnProperty, 0);
            svgCachedImage2.SetValue(VisualElement.WidthRequestProperty, 24.0);
            svgCachedImage2.SetValue(VisualElement.HeightRequestProperty, 24.0);
            grid2.Children.Add(svgCachedImage2);
            label5.SetValue(Label.TextColorProperty, Color.White);
            label5.SetValue(Grid.ColumnProperty, 1);
            label5.SetValue(Label.TextProperty, "施封位置");
            label5.SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
            grid2.Children.Add(label5);
            grid5.Children.Add(grid2);
            grid3.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
            grid3.SetValue(Grid.RowProperty, 0);
            grid3.SetValue(Grid.ColumnProperty, 1);
            columnDefinition8.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid3.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition8);
            columnDefinition9.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid3.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition9);
            tapGestureRecognizer2.Tapped += this.root.Handle_Tapped;
            grid3.GestureRecognizers.Add(tapGestureRecognizer2);
            svgCachedImage3.SetValue(CachedImage.SourceProperty, new FFImageLoading.Forms.ImageSourceConverter().ConvertFromInvariantString("location.svg"));
            svgCachedImage3.SetValue(Grid.ColumnProperty, 0);
            svgCachedImage3.SetValue(VisualElement.WidthRequestProperty, 24.0);
            svgCachedImage3.SetValue(VisualElement.HeightRequestProperty, 24.0);
            grid3.Children.Add(svgCachedImage3);
            label6.SetValue(Label.TextColorProperty, Color.White);
            label6.SetValue(Grid.ColumnProperty, 1);
            label6.SetValue(Label.TextProperty, "地图展示");
            label6.SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
            grid3.Children.Add(label6);
            grid5.Children.Add(grid3);
            grid4.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
            grid4.SetValue(Grid.RowProperty, 1);
            grid4.SetValue(Grid.ColumnProperty, 0);
            bindingExtension7.Path = "HasWayBill";
            BindingBase binding7 = ((IMarkupExtension<BindingBase>)bindingExtension7).ProvideValue(null);
            grid4.SetBinding(VisualElement.IsVisibleProperty, binding7);
            columnDefinition10.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid4.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition10);
            columnDefinition11.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid4.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition11);
            bindingExtension8.Path = "WayBillCommand";
            BindingBase binding8 = ((IMarkupExtension<BindingBase>)bindingExtension8).ProvideValue(null);
            tapGestureRecognizer3.SetBinding(TapGestureRecognizer.CommandProperty, binding8);
            bindingExtension9.Path = "RFIDInfoOid";
            BindingBase binding9 = ((IMarkupExtension<BindingBase>)bindingExtension9).ProvideValue(null);
            tapGestureRecognizer3.SetBinding(TapGestureRecognizer.CommandParameterProperty, binding9);
            grid4.GestureRecognizers.Add(tapGestureRecognizer3);
            svgCachedImage4.SetValue(CachedImage.SourceProperty, new FFImageLoading.Forms.ImageSourceConverter().ConvertFromInvariantString("Picture.svg"));
            svgCachedImage4.SetValue(Grid.ColumnProperty, 0);
            svgCachedImage4.SetValue(VisualElement.WidthRequestProperty, 24.0);
            svgCachedImage4.SetValue(VisualElement.HeightRequestProperty, 24.0);
            grid4.Children.Add(svgCachedImage4);
            label7.SetValue(Label.TextColorProperty, Color.White);
            label7.SetValue(Grid.ColumnProperty, 1);
            label7.SetValue(Label.TextProperty, "运单照片");
            label7.SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
            grid4.Children.Add(label7);
            grid5.Children.Add(grid4);
            grid6.Children.Add(grid5);
            frame.SetValue(ContentView.ContentProperty, grid6);
            grid7.Children.Add(frame);
            grid8.Children.Add(grid7);
            viewCell.View = grid8;
            return viewCell;
        }

        // Token: 0x04000134 RID: 308
        internal object[] parentValues;

        // Token: 0x04000135 RID: 309
        internal QueryPage root;
    }
}
}
