using System;
using System.CodeDom.Compiler;
using System.Reflection;
using Prism.Mvvm;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Views
{
    // Token: 0x0200006F RID: 111
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Views\\ReLockPage.xaml")]
    public class ReLockPage : ContentPage
    {
        // Token: 0x0600026F RID: 623 RVA: 0x00013B5A File Offset: 0x00011D5A
        public ReLockPage()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000270 RID: 624 RVA: 0x00013B68 File Offset: 0x00011D68
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(ReLockPage).GetTypeInfo().Assembly.GetName(), "Views/ReLockPage.xaml") != null)
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
            RowDefinition rowDefinition = new RowDefinition();
            RowDefinition rowDefinition2 = new RowDefinition();
            RowDefinition rowDefinition3 = new RowDefinition();
            ColumnDefinition columnDefinition = new ColumnDefinition();
            ColumnDefinition columnDefinition2 = new ColumnDefinition();
            Label label = new Label();
            BindingExtension bindingExtension2 = new BindingExtension();
            Label label2 = new Label();
            Grid grid = new Grid();
            BindingExtension bindingExtension3 = new BindingExtension();
            TextCell textCell = new TextCell();
            BindingExtension bindingExtension4 = new BindingExtension();
            TextCell textCell2 = new TextCell();
            BindingExtension bindingExtension5 = new BindingExtension();
            TextCell textCell3 = new TextCell();
            BindingExtension bindingExtension6 = new BindingExtension();
            TextCell textCell4 = new TextCell();
            TableSection tableSection = new TableSection();
            TableRoot tableRoot = new TableRoot();
            TableView tableView = new TableView();
            ColumnDefinition columnDefinition3 = new ColumnDefinition();
            ColumnDefinition columnDefinition4 = new ColumnDefinition();
            ColumnDefinition columnDefinition5 = new ColumnDefinition();
            BindingExtension bindingExtension7 = new BindingExtension();
            Button button = new Button();
            BindingExtension bindingExtension8 = new BindingExtension();
            Button button2 = new Button();
            Grid grid2 = new Grid();
            Grid grid3 = new Grid();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(grid3, nameScope);
            NameScope.SetNameScope(rowDefinition, nameScope);
            NameScope.SetNameScope(rowDefinition2, nameScope);
            NameScope.SetNameScope(rowDefinition3, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(columnDefinition, nameScope);
            NameScope.SetNameScope(columnDefinition2, nameScope);
            NameScope.SetNameScope(label, nameScope);
            NameScope.SetNameScope(label2, nameScope);
            NameScope.SetNameScope(tableView, nameScope);
            ((INameScope)nameScope).RegisterName("tableView", tableView);
            if (tableView.StyleId == null)
            {
                tableView.StyleId = "tableView";
            }
            NameScope.SetNameScope(tableRoot, nameScope);
            NameScope.SetNameScope(tableSection, nameScope);
            NameScope.SetNameScope(textCell, nameScope);
            NameScope.SetNameScope(textCell2, nameScope);
            NameScope.SetNameScope(textCell3, nameScope);
            NameScope.SetNameScope(textCell4, nameScope);
            NameScope.SetNameScope(grid2, nameScope);
            NameScope.SetNameScope(columnDefinition3, nameScope);
            NameScope.SetNameScope(columnDefinition4, nameScope);
            NameScope.SetNameScope(columnDefinition5, nameScope);
            NameScope.SetNameScope(button, nameScope);
            NameScope.SetNameScope(button2, nameScope);
            this.tableView = tableView;
            this.SetValue(ViewModelLocator.AutowireViewModelProperty, new bool?(true));
            bindingExtension.Path = "Title";
            BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue(null);
            this.SetBinding(Page.TitleProperty, binding);
            grid3.SetValue(Grid.RowSpacingProperty, 0.0);
            rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid3.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition);
            rowDefinition2.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid3.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition2);
            rowDefinition3.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid3.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition3);
            grid.SetValue(VisualElement.BackgroundColorProperty, new Color(0.92156863212585449, 0.92156863212585449, 0.92156863212585449, 1.0));
            grid.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(10.0, 10.0, 10.0, 10.0));
            columnDefinition.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition);
            columnDefinition2.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("3*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition2);
            label.SetValue(Grid.ColumnProperty, 0);
            label.SetValue(Label.TextProperty, "当前地址");
            label.SetValue(Label.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
            BindableObject bindableObject = label;
            BindableProperty fontSizeProperty = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter = new FontSizeConverter();
            string value = "Default";
            XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
            Type typeFromHandle = typeof(IProvideValueTarget);
            object[] array = new object[0 + 4];
            array[0] = label;
            array[1] = grid;
            array[2] = grid3;
            array[3] = this;
            xamlServiceProvider.Add(typeFromHandle, new SimpleValueTargetProvider(array, Label.FontSizeProperty));
            xamlServiceProvider.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle2 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver = new XmlNamespaceResolver();
            xmlNamespaceResolver.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(ReLockPage).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(20, 82)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider));
            label.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
            grid.Children.Add(label);
            label2.SetValue(Grid.ColumnProperty, 1);
            bindingExtension2.Path = "CurLocation";
            BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue(null);
            label2.SetBinding(Label.TextProperty, binding2);
            BindableObject bindableObject2 = label2;
            BindableProperty fontSizeProperty2 = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter2 = new FontSizeConverter();
            string value2 = "Default";
            XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
            Type typeFromHandle3 = typeof(IProvideValueTarget);
            object[] array2 = new object[0 + 4];
            array2[0] = label2;
            array2[1] = grid;
            array2[2] = grid3;
            array2[3] = this;
            xamlServiceProvider2.Add(typeFromHandle3, new SimpleValueTargetProvider(array2, Label.FontSizeProperty));
            xamlServiceProvider2.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle4 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver2 = new XmlNamespaceResolver();
            xmlNamespaceResolver2.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver2.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver2.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(ReLockPage).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(21, 77)));
            bindableObject2.SetValue(fontSizeProperty2, extendedTypeConverter2.ConvertFromInvariantString(value2, xamlServiceProvider2));
            label2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            grid.Children.Add(label2);
            grid3.Children.Add(grid);
            tableView.Intent = TableIntent.Form;
            tableView.SetValue(Grid.RowProperty, 1);
            tableView.SetValue(TableView.HasUnevenRowsProperty, true);
            tableView.SetValue(VisualElement.BackgroundColorProperty, new Color(0.9843137264251709, 0.9843137264251709, 0.9843137264251709, 1.0));
            textCell.SetValue(TextCell.TextProperty, "起始时间");
            bindingExtension3.Path = "Begintime";
            BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue(null);
            textCell.SetBinding(TextCell.DetailProperty, binding3);
            textCell.SetValue(TextCell.DetailColorProperty, Color.Black);
            tableSection.Add(textCell);
            textCell2.SetValue(TextCell.TextProperty, "目的地址");
            bindingExtension4.Path = "Address";
            BindingBase binding4 = ((IMarkupExtension<BindingBase>)bindingExtension4).ProvideValue(null);
            textCell2.SetBinding(TextCell.DetailProperty, binding4);
            textCell2.SetValue(TextCell.DetailColorProperty, Color.Black);
            tableSection.Add(textCell2);
            textCell3.SetValue(TextCell.TextProperty, "运输状态");
            bindingExtension5.Path = "Status";
            BindingBase binding5 = ((IMarkupExtension<BindingBase>)bindingExtension5).ProvideValue(null);
            textCell3.SetBinding(TextCell.DetailProperty, binding5);
            textCell3.SetValue(TextCell.DetailColorProperty, Color.Black);
            tableSection.Add(textCell3);
            textCell4.SetValue(TextCell.TextProperty, "施封位置");
            bindingExtension6.Path = "LockLocation";
            BindingBase binding6 = ((IMarkupExtension<BindingBase>)bindingExtension6).ProvideValue(null);
            textCell4.SetBinding(TextCell.DetailProperty, binding6);
            textCell4.SetValue(TextCell.DetailColorProperty, Color.Black);
            tableSection.Add(textCell4);
            tableRoot.Add(tableSection);
            tableView.Root = tableRoot;
            grid3.Children.Add(tableView);
            grid2.SetValue(Grid.RowProperty, 2);
            grid2.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(20.0, 5.0, 20.0, 5.0));
            grid2.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            columnDefinition3.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid2.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition3);
            columnDefinition4.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("50"));
            grid2.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition4);
            columnDefinition5.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid2.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition5);
            button.SetValue(Grid.ColumnProperty, 0);
            button.SetValue(Button.TextProperty, "新建运输");
            bindingExtension7.Path = "NewCommand";
            BindingBase binding7 = ((IMarkupExtension<BindingBase>)bindingExtension7).ProvideValue(null);
            button.SetBinding(Button.CommandProperty, binding7);
            button.SetValue(Button.TextColorProperty, new Color(0.050980392843484879, 0.27843138575553894, 0.63137257099151611, 1.0));
            button.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            button.SetValue(Button.BorderRadiusProperty, 10);
            button.SetValue(Button.BorderColorProperty, new Color(0.050980392843484879, 0.27843138575553894, 0.63137257099151611, 1.0));
            button.SetValue(Button.BorderWidthProperty, 1.0);
            grid2.Children.Add(button);
            button2.SetValue(Grid.ColumnProperty, 2);
            button2.SetValue(Button.TextProperty, "继续施封");
            bindingExtension8.Path = "ContinueCommand";
            BindingBase binding8 = ((IMarkupExtension<BindingBase>)bindingExtension8).ProvideValue(null);
            button2.SetBinding(Button.CommandProperty, binding8);
            button2.SetValue(Button.TextColorProperty, Color.White);
            button2.SetValue(VisualElement.BackgroundColorProperty, new Color(0.050980392843484879, 0.27843138575553894, 0.63137257099151611, 1.0));
            button2.SetValue(Button.BorderRadiusProperty, 10);
            button2.SetValue(Button.BorderColorProperty, new Color(0.050980392843484879, 0.27843138575553894, 0.63137257099151611, 1.0));
            button2.SetValue(Button.BorderWidthProperty, 1.0);
            grid2.Children.Add(button2);
            grid3.Children.Add(grid2);
            this.SetValue(ContentPage.ContentProperty, grid3);
        }

        // Token: 0x06000271 RID: 625 RVA: 0x0001474B File Offset: 0x0001294B
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(ReLockPage));
            this.tableView = this.FindByName("tableView");
        }

        // Token: 0x0400014E RID: 334
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private TableView tableView;
    }
}
