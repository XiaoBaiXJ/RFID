using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Runtime.CompilerServices;
using RFID.Layout;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Views
{
    // Token: 0x0200006C RID: 108
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Views\\QueryUploadPage.xaml")]
    public class QueryUploadPage : ContentPage
    {
        // Token: 0x06000267 RID: 615 RVA: 0x0001325D File Offset: 0x0001145D
        public QueryUploadPage()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000268 RID: 616 RVA: 0x0001326C File Offset: 0x0001146C
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(QueryUploadPage).GetTypeInfo().Assembly.GetName(), "Views/QueryUploadPage.xaml") != null)
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
            Label label = new Label();
            Label label2 = new Label();
            Grid grid = new Grid();
            BindingExtension bindingExtension2 = new BindingExtension();
            DataTemplate dataTemplate = new DataTemplate();
            ListView listView = new ListView();
            StackLayout stackLayout = new StackLayout();
            BindingExtension bindingExtension3 = new BindingExtension();
            BindingExtension bindingExtension4 = new BindingExtension();
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
            NameScope.SetNameScope(label, nameScope);
            NameScope.SetNameScope(label2, nameScope);
            NameScope.SetNameScope(listView, nameScope);
            NameScope.SetNameScope(activityIndicator, nameScope);
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
            rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("40"));
            grid.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition);
            label.SetValue(Grid.ColumnProperty, 0);
            label.SetValue(Label.TextProperty, "运单描述");
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
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(QueryUploadPage).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(16, 75)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider));
            label.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Start"));
            grid.Children.Add(label);
            label2.SetValue(Grid.ColumnProperty, 1);
            label2.SetValue(Label.TextProperty, "运单照片");
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
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(QueryUploadPage).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(17, 61)));
            bindableObject2.SetValue(fontSizeProperty2, extendedTypeConverter2.ConvertFromInvariantString(value2, xamlServiceProvider2));
            label2.SetValue(Label.TextColorProperty, Color.Black);
            label2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            grid.Children.Add(label2);
            stackLayout.Children.Add(grid);
            listView.SetValue(ListView.SelectionModeProperty, ListViewSelectionMode.None);
            listView.SetValue(ListView.RowHeightProperty, 90);
            bindingExtension2.Path = "QueryWaybills";
            BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue(null);
            listView.SetBinding(ItemsView<Cell>.ItemsSourceProperty, binding2);
            IDataTemplate dataTemplate2 = dataTemplate;
            QueryUploadPage.< InitializeComponent > _anonXamlCDataTemplate_3 < InitializeComponent > _anonXamlCDataTemplate_ = new QueryUploadPage.< InitializeComponent > _anonXamlCDataTemplate_3();
            object[] array3 = new object[0 + 5];
            array3[0] = dataTemplate;
            array3[1] = listView;
            array3[2] = stackLayout;
            array3[3] = grid2;
            array3[4] = this;

            < InitializeComponent > _anonXamlCDataTemplate_.parentValues = array3;

            < InitializeComponent > _anonXamlCDataTemplate_.root = this;
            dataTemplate2.LoadTemplate = new Func<object>(< InitializeComponent > _anonXamlCDataTemplate_.LoadDataTemplate);
            listView.SetValue(ItemsView<Cell>.ItemTemplateProperty, dataTemplate);
            stackLayout.Children.Add(listView);
            grid2.Children.Add(stackLayout);
            bindingExtension3.Path = "IsBusy";
            BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue(null);
            activityIndicator.SetBinding(ActivityIndicator.IsRunningProperty, binding3);
            bindingExtension4.Path = "IsBusy";
            BindingBase binding4 = ((IMarkupExtension<BindingBase>)bindingExtension4).ProvideValue(null);
            activityIndicator.SetBinding(VisualElement.IsVisibleProperty, binding4);
            activityIndicator.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            activityIndicator.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
            grid2.Children.Add(activityIndicator);
            this.SetValue(ContentPage.ContentProperty, grid2);
        }

        // Token: 0x06000269 RID: 617 RVA: 0x00013950 File Offset: 0x00011B50
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(QueryUploadPage));
        }

        // Token: 0x0200006D RID: 109
        [CompilerGenerated]
        private sealed class <InitializeComponent>_anonXamlCDataTemplate_3
		{
			// Token: 0x0600026B RID: 619 RVA: 0x00013978 File Offset: 0x00011B78
			internal object LoadDataTemplate()
        {
            BindingExtension bindingExtension = new BindingExtension();
            BindingExtension bindingExtension2 = new BindingExtension();
            NewImageCell newImageCell = new NewImageCell();
            NameScope value = new NameScope();
            NameScope.SetNameScope(newImageCell, value);
            bindingExtension.Path = "ImageDataStrings";
            BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue(null);
            newImageCell.SetBinding(NewImageCell.PhotoProperty, binding);
            bindingExtension2.Path = "Description";
            BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue(null);
            newImageCell.SetBinding(NewImageCell.TitleProperty, binding2);
            return newImageCell;
        }

        // Token: 0x0400014B RID: 331
        internal object[] parentValues;

        // Token: 0x0400014C RID: 332
        internal QueryUploadPage root;
    }
}
}
