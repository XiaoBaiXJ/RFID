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
    // Token: 0x02000067 RID: 103
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Views\\UploadPage.xaml")]
    public class UploadPage : ContentPage
    {
        // Token: 0x0600025A RID: 602 RVA: 0x000111AA File Offset: 0x0000F3AA
        public UploadPage()
        {
            this.InitializeComponent();
        }

        // Token: 0x0600025B RID: 603 RVA: 0x000111B8 File Offset: 0x0000F3B8
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(UploadPage).GetTypeInfo().Assembly.GetName(), "Views/UploadPage.xaml") != null)
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
            BindingExtension bindingExtension2 = new BindingExtension();
            Label label = new Label();
            TranslateExtension translateExtension = new TranslateExtension();
            BindingExtension bindingExtension3 = new BindingExtension();
            TranslateExtension translateExtension2 = new TranslateExtension();
            NewEntryCell newEntryCell = new NewEntryCell();
            TranslateExtension translateExtension3 = new TranslateExtension();
            BindingExtension bindingExtension4 = new BindingExtension();
            PhotoCell photoCell = new PhotoCell();
            TableSection tableSection = new TableSection();
            TableRoot tableRoot = new TableRoot();
            TableView tableView = new TableView();
            TranslateExtension translateExtension4 = new TranslateExtension();
            BindingExtension bindingExtension5 = new BindingExtension();
            Button button = new Button();
            Grid grid = new Grid();
            ScrollView scrollView = new ScrollView();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(scrollView, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(rowDefinition, nameScope);
            NameScope.SetNameScope(rowDefinition2, nameScope);
            NameScope.SetNameScope(rowDefinition3, nameScope);
            NameScope.SetNameScope(label, nameScope);
            NameScope.SetNameScope(tableView, nameScope);
            NameScope.SetNameScope(tableRoot, nameScope);
            NameScope.SetNameScope(tableSection, nameScope);
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
            grid.SetValue(Grid.RowSpacingProperty, 0.0);
            rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition);
            rowDefinition2.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition2);
            rowDefinition3.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition3);
            label.SetValue(View.MarginProperty, new Thickness(10.0));
            label.SetValue(Label.TextColorProperty, Color.Black);
            label.SetValue(Grid.RowProperty, 0);
            bindingExtension2.Path = "Detail";
            BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue(null);
            label.SetBinding(Label.TextProperty, binding2);
            grid.Children.Add(label);
            tableView.Intent = TableIntent.Data;
            tableView.SetValue(Grid.RowProperty, 1);
            tableView.SetValue(TableView.HasUnevenRowsProperty, true);
            tableView.SetValue(VisualElement.BackgroundColorProperty, new Color(0.9843137264251709, 0.9843137264251709, 0.9843137264251709, 1.0));
            translateExtension.Text = "delivery";
            IMarkupExtension markupExtension = translateExtension;
            XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
            Type typeFromHandle = typeof(IProvideValueTarget);
            object[] array = new object[0 + 7];
            array[0] = newEntryCell;
            array[1] = tableSection;
            array[2] = tableRoot;
            array[3] = tableView;
            array[4] = grid;
            array[5] = scrollView;
            array[6] = this;
            xamlServiceProvider.Add(typeFromHandle, new SimpleValueTargetProvider(array, NewEntryCell.TitleProperty));
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
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(UploadPage).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(25, 50)));
            object title = markupExtension.ProvideValue(xamlServiceProvider);
            newEntryCell.Title = title;
            bindingExtension3.Path = "Delivery";
            BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue(null);
            newEntryCell.SetBinding(NewEntryCell.TextProperty, binding3);
            translateExtension2.Text = "please";
            IMarkupExtension markupExtension2 = translateExtension2;
            XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
            Type typeFromHandle3 = typeof(IProvideValueTarget);
            object[] array2 = new object[0 + 7];
            array2[0] = newEntryCell;
            array2[1] = tableSection;
            array2[2] = tableRoot;
            array2[3] = tableView;
            array2[4] = grid;
            array2[5] = scrollView;
            array2[6] = this;
            xamlServiceProvider2.Add(typeFromHandle3, new SimpleValueTargetProvider(array2, NewEntryCell.HintProperty));
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
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(UploadPage).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(25, 111)));
            object hint = markupExtension2.ProvideValue(xamlServiceProvider2);
            newEntryCell.Hint = hint;
            tableSection.Add(newEntryCell);
            translateExtension3.Text = "deliveryphoto";
            IMarkupExtension markupExtension3 = translateExtension3;
            XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider();
            Type typeFromHandle5 = typeof(IProvideValueTarget);
            object[] array3 = new object[0 + 7];
            array3[0] = photoCell;
            array3[1] = tableSection;
            array3[2] = tableRoot;
            array3[3] = tableView;
            array3[4] = grid;
            array3[5] = scrollView;
            array3[6] = this;
            xamlServiceProvider3.Add(typeFromHandle5, new SimpleValueTargetProvider(array3, PhotoCell.TitleProperty));
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
            xamlServiceProvider3.Add(typeFromHandle6, new XamlTypeResolver(xmlNamespaceResolver3, typeof(UploadPage).GetTypeInfo().Assembly));
            xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(26, 66)));
            object title2 = markupExtension3.ProvideValue(xamlServiceProvider3);
            photoCell.Title = title2;
            bindingExtension4.Path = "ImageFiles";
            BindingBase binding4 = ((IMarkupExtension<BindingBase>)bindingExtension4).ProvideValue(null);
            photoCell.SetBinding(PhotoCell.FilesProperty, binding4);
            photoCell.SetValue(PhotoCell.CanTakeMoreProperty, false);
            tableSection.Add(photoCell);
            tableRoot.Add(tableSection);
            tableView.Root = tableRoot;
            grid.Children.Add(tableView);
            button.SetValue(View.MarginProperty, new Thickness(20.0));
            translateExtension4.Text = "submit";
            IMarkupExtension markupExtension4 = translateExtension4;
            XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider();
            Type typeFromHandle7 = typeof(IProvideValueTarget);
            object[] array4 = new object[0 + 4];
            array4[0] = button;
            array4[1] = grid;
            array4[2] = scrollView;
            array4[3] = this;
            xamlServiceProvider4.Add(typeFromHandle7, new SimpleValueTargetProvider(array4, Button.TextProperty));
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
            xamlServiceProvider4.Add(typeFromHandle8, new XamlTypeResolver(xmlNamespaceResolver4, typeof(UploadPage).GetTypeInfo().Assembly));
            xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(30, 37)));
            object text = markupExtension4.ProvideValue(xamlServiceProvider4);
            button.Text = text;
            bindingExtension5.Path = "CommitCommand";
            BindingBase binding5 = ((IMarkupExtension<BindingBase>)bindingExtension5).ProvideValue(null);
            button.SetBinding(Button.CommandProperty, binding5);
            button.SetValue(Button.TextColorProperty, Color.White);
            button.SetValue(VisualElement.BackgroundColorProperty, new Color(0.050980392843484879, 0.27843138575553894, 0.63137257099151611, 1.0));
            button.SetValue(Grid.RowProperty, 2);
            button.SetValue(Button.BorderRadiusProperty, 10);
            button.SetValue(Button.BorderColorProperty, new Color(0.050980392843484879, 0.27843138575553894, 0.63137257099151611, 1.0));
            button.SetValue(Button.BorderWidthProperty, 1.0);
            grid.Children.Add(button);
            scrollView.Content = grid;
            this.SetValue(ContentPage.ContentProperty, scrollView);
        }

        // Token: 0x0600025C RID: 604 RVA: 0x00011B3F File Offset: 0x0000FD3F
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(UploadPage));
            this.photocell = this.FindByName("photocell");
        }

        // Token: 0x04000143 RID: 323
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private PhotoCell photocell;
    }
}
