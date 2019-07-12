using System;
using System.CodeDom.Compiler;
using System.Reflection;
using Prism.Mvvm;
using RFID.Layout;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Views
{
    // Token: 0x02000058 RID: 88
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Views\\ExceptionPage.xaml")]
    public class ExceptionPage : ContentPage
    {
        // Token: 0x0600022B RID: 555 RVA: 0x0000796D File Offset: 0x00005B6D
        public ExceptionPage()
        {
            this.InitializeComponent();
        }

        // Token: 0x0600022C RID: 556 RVA: 0x0000797C File Offset: 0x00005B7C
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(ExceptionPage).GetTypeInfo().Assembly.GetName(), "Views/ExceptionPage.xaml") != null)
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
            TranslateExtension translateExtension = new TranslateExtension();
            Label label = new Label();
            BindingExtension bindingExtension2 = new BindingExtension();
            Label label2 = new Label();
            Grid grid = new Grid();
            TranslateExtension translateExtension2 = new TranslateExtension();
            BindingExtension bindingExtension3 = new BindingExtension();
            SelectCell selectCell = new SelectCell();
            TranslateExtension translateExtension3 = new TranslateExtension();
            BindingExtension bindingExtension4 = new BindingExtension();
            SelectCell selectCell2 = new SelectCell();
            TranslateExtension translateExtension4 = new TranslateExtension();
            BindingExtension bindingExtension5 = new BindingExtension();
            TranslateExtension translateExtension5 = new TranslateExtension();
            NewEntryCell newEntryCell = new NewEntryCell();
            TranslateExtension translateExtension6 = new TranslateExtension();
            BindingExtension bindingExtension6 = new BindingExtension();
            PhotoCell photoCell = new PhotoCell();
            TableSection tableSection = new TableSection();
            TableRoot tableRoot = new TableRoot();
            TableView tableView = new TableView();
            TranslateExtension translateExtension7 = new TranslateExtension();
            BindingExtension bindingExtension7 = new BindingExtension();
            Button button = new Button();
            Grid grid2 = new Grid();
            ScrollView scrollView = new ScrollView();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(scrollView, nameScope);
            NameScope.SetNameScope(grid2, nameScope);
            NameScope.SetNameScope(rowDefinition, nameScope);
            NameScope.SetNameScope(rowDefinition2, nameScope);
            NameScope.SetNameScope(rowDefinition3, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(columnDefinition, nameScope);
            NameScope.SetNameScope(columnDefinition2, nameScope);
            NameScope.SetNameScope(label, nameScope);
            NameScope.SetNameScope(label2, nameScope);
            NameScope.SetNameScope(tableView, nameScope);
            NameScope.SetNameScope(tableRoot, nameScope);
            NameScope.SetNameScope(tableSection, nameScope);
            NameScope.SetNameScope(selectCell, nameScope);
            NameScope.SetNameScope(selectCell2, nameScope);
            NameScope.SetNameScope(newEntryCell, nameScope);
            NameScope.SetNameScope(photoCell, nameScope);
            ((INameScope)nameScope).RegisterName("photocell", photoCell);
            if (photoCell.StyleId == null)
            {
                photoCell.StyleId = "photocell";
            }
            NameScope.SetNameScope(button, nameScope);
            this.photocell = photoCell;
            this.SetValue(ViewModelLocator.AutowireViewModelProperty, new bool?(true));
            bindingExtension.Path = "Title";
            BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue(null);
            this.SetBinding(Page.TitleProperty, binding);
            grid2.SetValue(Grid.RowSpacingProperty, 0.0);
            rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid2.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition);
            rowDefinition2.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid2.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition2);
            rowDefinition3.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid2.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition3);
            grid.SetValue(VisualElement.BackgroundColorProperty, new Color(0.92156863212585449, 0.92156863212585449, 0.92156863212585449, 1.0));
            grid.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(10.0, 10.0, 10.0, 10.0));
            columnDefinition.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition);
            columnDefinition2.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("3*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition2);
            label.SetValue(Grid.ColumnProperty, 0);
            translateExtension.Text = "curaddress";
            IMarkupExtension markupExtension = translateExtension;
            XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
            Type typeFromHandle = typeof(IProvideValueTarget);
            object[] array = new object[0 + 5];
            array[0] = label;
            array[1] = grid;
            array[2] = grid2;
            array[3] = scrollView;
            array[4] = this;
            xamlServiceProvider.Add(typeFromHandle, new SimpleValueTargetProvider(array, Label.TextProperty));
            xamlServiceProvider.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle2 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver = new XmlNamespaceResolver();
            xmlNamespaceResolver.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver.Add("local", "clr-namespace:RFID");
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(ExceptionPage).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(42, 50)));
            object text = markupExtension.ProvideValue(xamlServiceProvider);
            label.Text = text;
            label.SetValue(Label.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
            BindableObject bindableObject = label;
            BindableProperty fontSizeProperty = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter = new FontSizeConverter();
            string value = "Default";
            XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
            Type typeFromHandle3 = typeof(IProvideValueTarget);
            object[] array2 = new object[0 + 5];
            array2[0] = label;
            array2[1] = grid;
            array2[2] = grid2;
            array2[3] = scrollView;
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
            xmlNamespaceResolver2.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver2.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver2.Add("local", "clr-namespace:RFID");
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(ExceptionPage).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(42, 106)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider2));
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
            XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider();
            Type typeFromHandle5 = typeof(IProvideValueTarget);
            object[] array3 = new object[0 + 5];
            array3[0] = label2;
            array3[1] = grid;
            array3[2] = grid2;
            array3[3] = scrollView;
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
            xmlNamespaceResolver3.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver3.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver3.Add("local", "clr-namespace:RFID");
            xamlServiceProvider3.Add(typeFromHandle6, new XamlTypeResolver(xmlNamespaceResolver3, typeof(ExceptionPage).GetTypeInfo().Assembly));
            xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(43, 77)));
            bindableObject2.SetValue(fontSizeProperty2, extendedTypeConverter2.ConvertFromInvariantString(value2, xamlServiceProvider3));
            label2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            label2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            grid.Children.Add(label2);
            grid2.Children.Add(grid);
            tableView.Intent = TableIntent.Data;
            tableView.SetValue(Grid.RowProperty, 1);
            tableView.SetValue(TableView.HasUnevenRowsProperty, true);
            tableView.SetValue(VisualElement.BackgroundColorProperty, new Color(0.9843137264251709, 0.9843137264251709, 0.9843137264251709, 1.0));
            translateExtension2.Text = "explace";
            IMarkupExtension markupExtension2 = translateExtension2;
            XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider();
            Type typeFromHandle7 = typeof(IProvideValueTarget);
            object[] array4 = new object[0 + 7];
            array4[0] = selectCell;
            array4[1] = tableSection;
            array4[2] = tableRoot;
            array4[3] = tableView;
            array4[4] = grid2;
            array4[5] = scrollView;
            array4[6] = this;
            xamlServiceProvider4.Add(typeFromHandle7, new SimpleValueTargetProvider(array4, SelectCell.TitleProperty));
            xamlServiceProvider4.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle8 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver4 = new XmlNamespaceResolver();
            xmlNamespaceResolver4.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver4.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver4.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver4.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver4.Add("local", "clr-namespace:RFID");
            xamlServiceProvider4.Add(typeFromHandle8, new XamlTypeResolver(xmlNamespaceResolver4, typeof(ExceptionPage).GetTypeInfo().Assembly));
            xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(49, 52)));
            object title = markupExtension2.ProvideValue(xamlServiceProvider4);
            selectCell.Title = title;
            bindingExtension3.Mode = BindingMode.TwoWay;
            bindingExtension3.Path = "ExPlace";
            BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue(null);
            selectCell.SetBinding(SelectCell.TextProperty, binding3);
            selectCell.SetValue(SelectCell.CanSelectProperty, false);
            tableSection.Add(selectCell);
            translateExtension3.Text = "starttime";
            IMarkupExtension markupExtension3 = translateExtension3;
            XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider();
            Type typeFromHandle9 = typeof(IProvideValueTarget);
            object[] array5 = new object[0 + 7];
            array5[0] = selectCell2;
            array5[1] = tableSection;
            array5[2] = tableRoot;
            array5[3] = tableView;
            array5[4] = grid2;
            array5[5] = scrollView;
            array5[6] = this;
            xamlServiceProvider5.Add(typeFromHandle9, new SimpleValueTargetProvider(array5, SelectCell.TitleProperty));
            xamlServiceProvider5.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle10 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver5 = new XmlNamespaceResolver();
            xmlNamespaceResolver5.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver5.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver5.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver5.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver5.Add("local", "clr-namespace:RFID");
            xamlServiceProvider5.Add(typeFromHandle10, new XamlTypeResolver(xmlNamespaceResolver5, typeof(ExceptionPage).GetTypeInfo().Assembly));
            xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(50, 53)));
            object title2 = markupExtension3.ProvideValue(xamlServiceProvider5);
            selectCell2.Title = title2;
            selectCell2.SetValue(SelectCell.CanSelectProperty, false);
            bindingExtension4.Mode = BindingMode.TwoWay;
            bindingExtension4.Path = "StartTime";
            BindingBase binding4 = ((IMarkupExtension<BindingBase>)bindingExtension4).ProvideValue(null);
            selectCell2.SetBinding(SelectCell.TextProperty, binding4);
            tableSection.Add(selectCell2);
            translateExtension4.Text = "exinfo";
            IMarkupExtension markupExtension4 = translateExtension4;
            XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider();
            Type typeFromHandle11 = typeof(IProvideValueTarget);
            object[] array6 = new object[0 + 7];
            array6[0] = newEntryCell;
            array6[1] = tableSection;
            array6[2] = tableRoot;
            array6[3] = tableView;
            array6[4] = grid2;
            array6[5] = scrollView;
            array6[6] = this;
            xamlServiceProvider6.Add(typeFromHandle11, new SimpleValueTargetProvider(array6, NewEntryCell.TitleProperty));
            xamlServiceProvider6.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle12 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver6 = new XmlNamespaceResolver();
            xmlNamespaceResolver6.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver6.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver6.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver6.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver6.Add("local", "clr-namespace:RFID");
            xamlServiceProvider6.Add(typeFromHandle12, new XamlTypeResolver(xmlNamespaceResolver6, typeof(ExceptionPage).GetTypeInfo().Assembly));
            xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(51, 53)));
            object title3 = markupExtension4.ProvideValue(xamlServiceProvider6);
            newEntryCell.Title = title3;
            bindingExtension5.Path = "ExInfo";
            BindingBase binding5 = ((IMarkupExtension<BindingBase>)bindingExtension5).ProvideValue(null);
            newEntryCell.SetBinding(NewEntryCell.TextProperty, binding5);
            translateExtension5.Text = "explease";
            IMarkupExtension markupExtension5 = translateExtension5;
            XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider();
            Type typeFromHandle13 = typeof(IProvideValueTarget);
            object[] array7 = new object[0 + 7];
            array7[0] = newEntryCell;
            array7[1] = tableSection;
            array7[2] = tableRoot;
            array7[3] = tableView;
            array7[4] = grid2;
            array7[5] = scrollView;
            array7[6] = this;
            xamlServiceProvider7.Add(typeFromHandle13, new SimpleValueTargetProvider(array7, NewEntryCell.HintProperty));
            xamlServiceProvider7.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle14 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver7 = new XmlNamespaceResolver();
            xmlNamespaceResolver7.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver7.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver7.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver7.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver7.Add("local", "clr-namespace:RFID");
            xamlServiceProvider7.Add(typeFromHandle14, new XamlTypeResolver(xmlNamespaceResolver7, typeof(ExceptionPage).GetTypeInfo().Assembly));
            xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(51, 110)));
            object hint = markupExtension5.ProvideValue(xamlServiceProvider7);
            newEntryCell.Hint = hint;
            tableSection.Add(newEntryCell);
            translateExtension6.Text = "checkphoto";
            IMarkupExtension markupExtension6 = translateExtension6;
            XamlServiceProvider xamlServiceProvider8 = new XamlServiceProvider();
            Type typeFromHandle15 = typeof(IProvideValueTarget);
            object[] array8 = new object[0 + 7];
            array8[0] = photoCell;
            array8[1] = tableSection;
            array8[2] = tableRoot;
            array8[3] = tableView;
            array8[4] = grid2;
            array8[5] = scrollView;
            array8[6] = this;
            xamlServiceProvider8.Add(typeFromHandle15, new SimpleValueTargetProvider(array8, PhotoCell.TitleProperty));
            xamlServiceProvider8.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle16 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver8 = new XmlNamespaceResolver();
            xmlNamespaceResolver8.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver8.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver8.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver8.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver8.Add("local", "clr-namespace:RFID");
            xamlServiceProvider8.Add(typeFromHandle16, new XamlTypeResolver(xmlNamespaceResolver8, typeof(ExceptionPage).GetTypeInfo().Assembly));
            xamlServiceProvider8.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(52, 70)));
            object title4 = markupExtension6.ProvideValue(xamlServiceProvider8);
            photoCell.Title = title4;
            bindingExtension6.Path = "ImageFiles";
            BindingBase binding6 = ((IMarkupExtension<BindingBase>)bindingExtension6).ProvideValue(null);
            photoCell.SetBinding(PhotoCell.FilesProperty, binding6);
            photoCell.SetValue(PhotoCell.CanTakeMoreProperty, false);
            tableSection.Add(photoCell);
            tableRoot.Add(tableSection);
            tableView.Root = tableRoot;
            grid2.Children.Add(tableView);
            button.SetValue(View.MarginProperty, new Thickness(20.0));
            translateExtension7.Text = "exsubmit";
            IMarkupExtension markupExtension7 = translateExtension7;
            XamlServiceProvider xamlServiceProvider9 = new XamlServiceProvider();
            Type typeFromHandle17 = typeof(IProvideValueTarget);
            object[] array9 = new object[0 + 4];
            array9[0] = button;
            array9[1] = grid2;
            array9[2] = scrollView;
            array9[3] = this;
            xamlServiceProvider9.Add(typeFromHandle17, new SimpleValueTargetProvider(array9, Button.TextProperty));
            xamlServiceProvider9.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle18 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver9 = new XmlNamespaceResolver();
            xmlNamespaceResolver9.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver9.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver9.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver9.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver9.Add("local", "clr-namespace:RFID");
            xamlServiceProvider9.Add(typeFromHandle18, new XamlTypeResolver(xmlNamespaceResolver9, typeof(ExceptionPage).GetTypeInfo().Assembly));
            xamlServiceProvider9.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(57, 41)));
            object text2 = markupExtension7.ProvideValue(xamlServiceProvider9);
            button.Text = text2;
            bindingExtension7.Path = "CommitCommand";
            BindingBase binding7 = ((IMarkupExtension<BindingBase>)bindingExtension7).ProvideValue(null);
            button.SetBinding(Button.CommandProperty, binding7);
            button.SetValue(Button.TextColorProperty, Color.White);
            button.SetValue(VisualElement.BackgroundColorProperty, new Color(0.050980392843484879, 0.27843138575553894, 0.63137257099151611, 1.0));
            button.SetValue(Grid.RowProperty, 2);
            button.SetValue(Button.BorderRadiusProperty, 10);
            button.SetValue(Button.BorderColorProperty, new Color(0.050980392843484879, 0.27843138575553894, 0.63137257099151611, 1.0));
            button.SetValue(Button.BorderWidthProperty, 1.0);
            grid2.Children.Add(button);
            scrollView.Content = grid2;
            this.SetValue(ContentPage.ContentProperty, scrollView);
        }

        // Token: 0x0600022D RID: 557 RVA: 0x00008B0B File Offset: 0x00006D0B
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(ExceptionPage));
            this.photocell = this.FindByName("photocell");
        }

        // Token: 0x0400012F RID: 303
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private PhotoCell photocell;
    }
}
