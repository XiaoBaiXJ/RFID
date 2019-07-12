using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using FFImageLoading.Forms;
using RFID.Layout;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Views
{
    // Token: 0x02000069 RID: 105
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Views\\QueryLockPage.xaml")]
    public class QueryLockPage : ContentPage
    {
        // Token: 0x0600025F RID: 607 RVA: 0x00011B99 File Offset: 0x0000FD99
        public QueryLockPage()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000260 RID: 608 RVA: 0x00011BA8 File Offset: 0x0000FDA8
        private async Task TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Image image = sender as Image;
            if (image.Source != null)
            {
                ContentPage contentPage = new ContentPage
                {
                    BackgroundColor = Color.Black,
                    Title = "照片展示"
                };
                contentPage.Content = new CachedImage
                {
                    Source = image.Source
                };
                await App.CurNavigationPage.Navigation.PushAsync(contentPage);
            }
        }

        // Token: 0x06000261 RID: 609 RVA: 0x00011BF0 File Offset: 0x0000FDF0
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(QueryLockPage).GetTypeInfo().Assembly.GetName(), "Views/QueryLockPage.xaml") != null)
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
            ColumnDefinition columnDefinition = new ColumnDefinition();
            ColumnDefinition columnDefinition2 = new ColumnDefinition();
            RowDefinition rowDefinition = new RowDefinition();
            RowDefinition rowDefinition2 = new RowDefinition();
            Label label = new Label();
            BindingExtension bindingExtension2 = new BindingExtension();
            Label label2 = new Label();
            Label label3 = new Label();
            BindingExtension bindingExtension3 = new BindingExtension();
            Label label4 = new Label();
            Grid grid = new Grid();
            BindingExtension bindingExtension4 = new BindingExtension();
            DataTemplate dataTemplate = new DataTemplate();
            ListView listView = new ListView();
            StackLayout stackLayout = new StackLayout();
            BindingExtension bindingExtension5 = new BindingExtension();
            BindingExtension bindingExtension6 = new BindingExtension();
            ActivityIndicator activityIndicator = new ActivityIndicator();
            Grid grid2 = new Grid();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(grid2, nameScope);
            NameScope.SetNameScope(stackLayout, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(columnDefinition, nameScope);
            NameScope.SetNameScope(columnDefinition2, nameScope);
            NameScope.SetNameScope(rowDefinition, nameScope);
            NameScope.SetNameScope(rowDefinition2, nameScope);
            NameScope.SetNameScope(label, nameScope);
            NameScope.SetNameScope(label2, nameScope);
            NameScope.SetNameScope(label3, nameScope);
            NameScope.SetNameScope(label4, nameScope);
            NameScope.SetNameScope(listView, nameScope);
            ((INameScope)nameScope).RegisterName("listView", listView);
            if (listView.StyleId == null)
            {
                listView.StyleId = "listView";
            }
            NameScope.SetNameScope(activityIndicator, nameScope);
            this.listView = listView;
            bindingExtension.Path = "Title";
            BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue(null);
            this.SetBinding(Page.TitleProperty, binding);
            stackLayout.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(0.0));
            stackLayout.SetValue(StackLayout.SpacingProperty, 0.0);
            grid.SetValue(VisualElement.BackgroundColorProperty, Color.Silver);
            grid.SetValue(Grid.RowSpacingProperty, 5.0);
            grid.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(10.0, 5.0, 10.0, 5.0));
            columnDefinition.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition);
            columnDefinition2.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("3*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition2);
            rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition);
            rowDefinition2.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition2);
            label.SetValue(Grid.ColumnProperty, 0);
            label.SetValue(Label.TextProperty, "施封位置");
            label.SetValue(Label.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
            BindableObject bindableObject = label;
            BindableProperty fontSizeProperty = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter = new FontSizeConverter();
            string value = "Default";
            XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
            Type typeFromHandle = typeof(IProvideValueTarget);
            object[] array = new object[0 + 5];
            array[0] = label;
            array[1] = grid;
            array[2] = stackLayout;
            array[3] = grid2;
            array[4] = this;
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
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(QueryLockPage).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(17, 74)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider));
            label.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Start"));
            grid.Children.Add(label);
            label2.SetValue(Grid.ColumnProperty, 1);
            bindingExtension2.Path = "Place";
            BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue(null);
            label2.SetBinding(Label.TextProperty, binding2);
            BindableObject bindableObject2 = label2;
            BindableProperty fontSizeProperty2 = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter2 = new FontSizeConverter();
            string value2 = "Default";
            XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
            Type typeFromHandle3 = typeof(IProvideValueTarget);
            object[] array2 = new object[0 + 5];
            array2[0] = label2;
            array2[1] = grid;
            array2[2] = stackLayout;
            array2[3] = grid2;
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
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(QueryLockPage).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(18, 71)));
            bindableObject2.SetValue(fontSizeProperty2, extendedTypeConverter2.ConvertFromInvariantString(value2, xamlServiceProvider2));
            label2.SetValue(Label.TextColorProperty, Color.Black);
            label2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            grid.Children.Add(label2);
            label3.SetValue(Grid.RowProperty, 1);
            label3.SetValue(Grid.ColumnProperty, 0);
            label3.SetValue(Label.TextProperty, "目的地址");
            label3.SetValue(Label.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
            BindableObject bindableObject3 = label3;
            BindableProperty fontSizeProperty3 = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter3 = new FontSizeConverter();
            string value3 = "Default";
            XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider();
            Type typeFromHandle5 = typeof(IProvideValueTarget);
            object[] array3 = new object[0 + 5];
            array3[0] = label3;
            array3[1] = grid;
            array3[2] = stackLayout;
            array3[3] = grid2;
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
            xamlServiceProvider3.Add(typeFromHandle6, new XamlTypeResolver(xmlNamespaceResolver3, typeof(QueryLockPage).GetTypeInfo().Assembly));
            xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(19, 87)));
            bindableObject3.SetValue(fontSizeProperty3, extendedTypeConverter3.ConvertFromInvariantString(value3, xamlServiceProvider3));
            label3.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label3.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            label3.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Start"));
            grid.Children.Add(label3);
            label4.SetValue(Grid.RowProperty, 1);
            label4.SetValue(Grid.ColumnProperty, 1);
            bindingExtension3.Path = "Address";
            BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue(null);
            label4.SetBinding(Label.TextProperty, binding3);
            BindableObject bindableObject4 = label4;
            BindableProperty fontSizeProperty4 = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter4 = new FontSizeConverter();
            string value4 = "Default";
            XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider();
            Type typeFromHandle7 = typeof(IProvideValueTarget);
            object[] array4 = new object[0 + 5];
            array4[0] = label4;
            array4[1] = grid;
            array4[2] = stackLayout;
            array4[3] = grid2;
            array4[4] = this;
            xamlServiceProvider4.Add(typeFromHandle7, new SimpleValueTargetProvider(array4, Label.FontSizeProperty));
            xamlServiceProvider4.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle8 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver4 = new XmlNamespaceResolver();
            xmlNamespaceResolver4.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver4.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver4.Add("layout", "clr-namespace:RFID.Layout");
            xamlServiceProvider4.Add(typeFromHandle8, new XamlTypeResolver(xmlNamespaceResolver4, typeof(QueryLockPage).GetTypeInfo().Assembly));
            xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(20, 86)));
            bindableObject4.SetValue(fontSizeProperty4, extendedTypeConverter4.ConvertFromInvariantString(value4, xamlServiceProvider4));
            label4.SetValue(Label.TextColorProperty, Color.Black);
            label4.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label4.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            grid.Children.Add(label4);
            stackLayout.Children.Add(grid);
            listView.SetValue(ListView.SelectionModeProperty, ListViewSelectionMode.None);
            bindingExtension4.Path = "Queries";
            BindingBase binding4 = ((IMarkupExtension<BindingBase>)bindingExtension4).ProvideValue(null);
            listView.SetBinding(ItemsView<Cell>.ItemsSourceProperty, binding4);
            listView.SetValue(ListView.HasUnevenRowsProperty, true);
            IDataTemplate dataTemplate2 = dataTemplate;
            QueryLockPage.< InitializeComponent > _anonXamlCDataTemplate_2 < InitializeComponent > _anonXamlCDataTemplate_ = new QueryLockPage.< InitializeComponent > _anonXamlCDataTemplate_2();
            object[] array5 = new object[0 + 5];
            array5[0] = dataTemplate;
            array5[1] = listView;
            array5[2] = stackLayout;
            array5[3] = grid2;
            array5[4] = this;

            < InitializeComponent > _anonXamlCDataTemplate_.parentValues = array5;

            < InitializeComponent > _anonXamlCDataTemplate_.root = this;
            dataTemplate2.LoadTemplate = new Func<object>(< InitializeComponent > _anonXamlCDataTemplate_.LoadDataTemplate);
            listView.SetValue(ItemsView<Cell>.ItemTemplateProperty, dataTemplate);
            stackLayout.Children.Add(listView);
            grid2.Children.Add(stackLayout);
            bindingExtension5.Path = "IsBusy";
            BindingBase binding5 = ((IMarkupExtension<BindingBase>)bindingExtension5).ProvideValue(null);
            activityIndicator.SetBinding(ActivityIndicator.IsRunningProperty, binding5);
            bindingExtension6.Path = "IsBusy";
            BindingBase binding6 = ((IMarkupExtension<BindingBase>)bindingExtension6).ProvideValue(null);
            activityIndicator.SetBinding(VisualElement.IsVisibleProperty, binding6);
            activityIndicator.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            activityIndicator.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
            grid2.Children.Add(activityIndicator);
            this.SetValue(ContentPage.ContentProperty, grid2);
        }

        // Token: 0x06000262 RID: 610 RVA: 0x000126C2 File Offset: 0x000108C2
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(QueryLockPage));
            this.listView = this.FindByName("listView");
        }

        // Token: 0x04000144 RID: 324
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private ListView listView;

        // Token: 0x0200006B RID: 107
        [CompilerGenerated]
        private sealed class <InitializeComponent>_anonXamlCDataTemplate_2
		{
			// Token: 0x06000266 RID: 614 RVA: 0x00012810 File Offset: 0x00010A10
			internal object LoadDataTemplate()
        {
            RowDefinition rowDefinition = new RowDefinition();
            RowDefinition rowDefinition2 = new RowDefinition();
            ColumnDefinition columnDefinition = new ColumnDefinition();
            ColumnDefinition columnDefinition2 = new ColumnDefinition();
            BindingExtension bindingExtension = new BindingExtension();
            Label label = new Label();
            NoBorderEntry noBorderEntry = new NoBorderEntry();
            BindingExtension bindingExtension2 = new BindingExtension();
            Label label2 = new Label();
            BindingExtension bindingExtension3 = new BindingExtension();
            Label label3 = new Label();
            BindingExtension bindingExtension4 = new BindingExtension();
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            Image image = new Image();
            Grid grid = new Grid();
            Grid grid2 = new Grid();
            ViewCell viewCell = new ViewCell();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(viewCell, nameScope);
            NameScope.SetNameScope(grid2, nameScope);
            NameScope.SetNameScope(rowDefinition, nameScope);
            NameScope.SetNameScope(rowDefinition2, nameScope);
            NameScope.SetNameScope(columnDefinition, nameScope);
            NameScope.SetNameScope(columnDefinition2, nameScope);
            NameScope.SetNameScope(label, nameScope);
            NameScope.SetNameScope(noBorderEntry, nameScope);
            NameScope.SetNameScope(label2, nameScope);
            NameScope.SetNameScope(label3, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(image, nameScope);
            NameScope.SetNameScope(tapGestureRecognizer, nameScope);
            grid2.SetValue(Grid.RowSpacingProperty, 1.0);
            grid2.SetValue(VisualElement.BackgroundColorProperty, new Color(0.98039215803146362, 0.98039215803146362, 0.98039215803146362, 1.0));
            grid2.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(10.0, 5.0, 10.0, 5.0));
            rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid2.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition);
            rowDefinition2.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("90"));
            grid2.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition2);
            columnDefinition.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid2.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition);
            columnDefinition2.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("3*"));
            grid2.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition2);
            BindableObject bindableObject = label;
            BindableProperty fontSizeProperty = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter = new FontSizeConverter();
            string value = "Default";
            XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
            Type typeFromHandle = typeof(IProvideValueTarget);
            int length;
            object[] array = new object[(length = this.parentValues.Length) + 3];
            Array.Copy(this.parentValues, 0, array, 3, length);
            object[] array2 = array;
            array2[0] = label;
            array2[1] = grid2;
            array2[2] = viewCell;
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
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(QueryLockPage.< InitializeComponent > _anonXamlCDataTemplate_2).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(35, 22)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider));
            label.SetValue(Grid.RowProperty, 0);
            label.SetValue(Label.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
            bindingExtension.Path = "TimeTitle";
            BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue(null);
            label.SetBinding(Label.TextProperty, binding);
            label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            label.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Start"));
            label.SetValue(Grid.ColumnProperty, 0);
            grid2.Children.Add(label);
            noBorderEntry.SetValue(Grid.RowProperty, 0);
            noBorderEntry.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            noBorderEntry.SetValue(VisualElement.WidthRequestProperty, 1.0);
            BindableObject bindableObject2 = noBorderEntry;
            BindableProperty fontSizeProperty2 = Entry.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter2 = new FontSizeConverter();
            string value2 = "Default";
            XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
            Type typeFromHandle3 = typeof(IProvideValueTarget);
            int length2;
            object[] array3 = new object[(length2 = this.parentValues.Length) + 3];
            Array.Copy(this.parentValues, 0, array3, 3, length2);
            object[] array4 = array3;
            array4[0] = noBorderEntry;
            array4[1] = grid2;
            array4[2] = viewCell;
            xamlServiceProvider2.Add(typeFromHandle3, new SimpleValueTargetProvider(array4, Entry.FontSizeProperty));
            xamlServiceProvider2.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle4 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver2 = new XmlNamespaceResolver();
            xmlNamespaceResolver2.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver2.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver2.Add("layout", "clr-namespace:RFID.Layout");
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(QueryLockPage.< InitializeComponent > _anonXamlCDataTemplate_2).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(36, 91)));
            bindableObject2.SetValue(fontSizeProperty2, extendedTypeConverter2.ConvertFromInvariantString(value2, xamlServiceProvider2));
            noBorderEntry.SetValue(Grid.ColumnProperty, 1);
            noBorderEntry.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
            noBorderEntry.SetValue(VisualElement.IsEnabledProperty, false);
            grid2.Children.Add(noBorderEntry);
            BindableObject bindableObject3 = label2;
            BindableProperty fontSizeProperty3 = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter3 = new FontSizeConverter();
            string value3 = "Default";
            XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider();
            Type typeFromHandle5 = typeof(IProvideValueTarget);
            int length3;
            object[] array5 = new object[(length3 = this.parentValues.Length) + 3];
            Array.Copy(this.parentValues, 0, array5, 3, length3);
            object[] array6 = array5;
            array6[0] = label2;
            array6[1] = grid2;
            array6[2] = viewCell;
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
            xamlServiceProvider3.Add(typeFromHandle6, new XamlTypeResolver(xmlNamespaceResolver3, typeof(QueryLockPage.< InitializeComponent > _anonXamlCDataTemplate_2).GetTypeInfo().Assembly));
            xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(37, 20)));
            bindableObject3.SetValue(fontSizeProperty3, extendedTypeConverter3.ConvertFromInvariantString(value3, xamlServiceProvider3));
            label2.SetValue(Grid.RowProperty, 0);
            label2.SetValue(Label.TextColorProperty, Color.Black);
            bindingExtension2.Path = "time";
            BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue(null);
            label2.SetBinding(Label.TextProperty, binding2);
            label2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            label2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label2.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Start"));
            label2.SetValue(Grid.ColumnProperty, 1);
            grid2.Children.Add(label2);
            BindableObject bindableObject4 = label3;
            BindableProperty fontSizeProperty4 = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter4 = new FontSizeConverter();
            string value4 = "Default";
            XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider();
            Type typeFromHandle7 = typeof(IProvideValueTarget);
            int length4;
            object[] array7 = new object[(length4 = this.parentValues.Length) + 3];
            Array.Copy(this.parentValues, 0, array7, 3, length4);
            object[] array8 = array7;
            array8[0] = label3;
            array8[1] = grid2;
            array8[2] = viewCell;
            xamlServiceProvider4.Add(typeFromHandle7, new SimpleValueTargetProvider(array8, Label.FontSizeProperty));
            xamlServiceProvider4.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle8 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver4 = new XmlNamespaceResolver();
            xmlNamespaceResolver4.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver4.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver4.Add("layout", "clr-namespace:RFID.Layout");
            xamlServiceProvider4.Add(typeFromHandle8, new XamlTypeResolver(xmlNamespaceResolver4, typeof(QueryLockPage.< InitializeComponent > _anonXamlCDataTemplate_2).GetTypeInfo().Assembly));
            xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(43, 17)));
            bindableObject4.SetValue(fontSizeProperty4, extendedTypeConverter4.ConvertFromInvariantString(value4, xamlServiceProvider4));
            label3.SetValue(Grid.RowProperty, 1);
            label3.SetValue(Label.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
            bindingExtension3.Path = "PhotoTitle";
            BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue(null);
            label3.SetBinding(Label.TextProperty, binding3);
            label3.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
            label3.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label3.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Start"));
            label3.SetValue(Grid.ColumnProperty, 0);
            grid2.Children.Add(label3);
            grid.SetValue(Grid.ColumnProperty, 1);
            grid.SetValue(Grid.RowProperty, 1);
            image.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Start);
            image.SetValue(View.VerticalOptionsProperty, LayoutOptions.FillAndExpand);
            image.SetValue(VisualElement.HeightRequestProperty, 90.0);
            image.SetValue(Image.AspectProperty, Aspect.AspectFill);
            image.SetValue(VisualElement.WidthRequestProperty, 90.0);
            bindingExtension4.Path = "PhotoSource";
            BindingBase binding4 = ((IMarkupExtension<BindingBase>)bindingExtension4).ProvideValue(null);
            image.SetBinding(Image.SourceProperty, binding4);
            tapGestureRecognizer.Tapped += new EventHandler(this.root.TapGestureRecognizer_Tapped);
            image.GestureRecognizers.Add(tapGestureRecognizer);
            grid.Children.Add(image);
            grid2.Children.Add(grid);
            viewCell.View = grid2;
            return viewCell;
        }

        // Token: 0x04000149 RID: 329
        internal object[] parentValues;

        // Token: 0x0400014A RID: 330
        internal QueryLockPage root;
    }
}
}
