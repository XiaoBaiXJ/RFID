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
    // Token: 0x02000053 RID: 83
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Views\\ChangePwdPage.xaml")]
    public class ChangePwdPage : ContentPage
    {
        // Token: 0x0600021C RID: 540 RVA: 0x0000424B File Offset: 0x0000244B
        public ChangePwdPage()
        {
            this.InitializeComponent();
        }

        // Token: 0x0600021D RID: 541 RVA: 0x0000425C File Offset: 0x0000245C
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(ChangePwdPage).GetTypeInfo().Assembly.GetName(), "Views/ChangePwdPage.xaml") != null)
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
            TranslateExtension translateExtension = new TranslateExtension();
            BindingExtension bindingExtension2 = new BindingExtension();
            ToolbarItem toolbarItem = new ToolbarItem();
            TranslateExtension translateExtension2 = new TranslateExtension();
            BindingExtension bindingExtension3 = new BindingExtension();
            PasswordEntryCell passwordEntryCell = new PasswordEntryCell();
            TranslateExtension translateExtension3 = new TranslateExtension();
            BindingExtension bindingExtension4 = new BindingExtension();
            PasswordEntryCell passwordEntryCell2 = new PasswordEntryCell();
            TranslateExtension translateExtension4 = new TranslateExtension();
            BindingExtension bindingExtension5 = new BindingExtension();
            PasswordEntryCell passwordEntryCell3 = new PasswordEntryCell();
            TableSection tableSection = new TableSection();
            TableRoot tableRoot = new TableRoot();
            TableView tableView = new TableView();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(toolbarItem, nameScope);
            NameScope.SetNameScope(tableView, nameScope);
            NameScope.SetNameScope(tableRoot, nameScope);
            NameScope.SetNameScope(tableSection, nameScope);
            NameScope.SetNameScope(passwordEntryCell, nameScope);
            NameScope.SetNameScope(passwordEntryCell2, nameScope);
            NameScope.SetNameScope(passwordEntryCell3, nameScope);
            this.SetValue(ViewModelLocator.AutowireViewModelProperty, new bool?(true));
            bindingExtension.Path = "Title";
            BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue(null);
            this.SetBinding(Page.TitleProperty, binding);
            translateExtension.Text = "confirm";
            IMarkupExtension markupExtension = translateExtension;
            XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
            Type typeFromHandle = typeof(IProvideValueTarget);
            object[] array = new object[0 + 2];
            array[0] = toolbarItem;
            array[1] = this;
            xamlServiceProvider.Add(typeFromHandle, new SimpleValueTargetProvider(array, MenuItem.TextProperty));
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
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(ChangePwdPage).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(11, 22)));
            object text = markupExtension.ProvideValue(xamlServiceProvider);
            toolbarItem.Text = text;
            toolbarItem.Order = ToolbarItemOrder.Primary;
            bindingExtension2.Path = "SaveCommand";
            BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue(null);
            toolbarItem.SetBinding(MenuItem.CommandProperty, binding2);
            this.ToolbarItems.Add(toolbarItem);
            tableView.Intent = TableIntent.Data;
            tableView.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            translateExtension2.Text = "oldpwd";
            IMarkupExtension markupExtension2 = translateExtension2;
            XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
            Type typeFromHandle3 = typeof(IProvideValueTarget);
            object[] array2 = new object[0 + 5];
            array2[0] = passwordEntryCell;
            array2[1] = tableSection;
            array2[2] = tableRoot;
            array2[3] = tableView;
            array2[4] = this;
            xamlServiceProvider2.Add(typeFromHandle3, new SimpleValueTargetProvider(array2, EntryCell.LabelProperty));
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
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(ChangePwdPage).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(16, 43)));
            object label = markupExtension2.ProvideValue(xamlServiceProvider2);
            passwordEntryCell.Label = label;
            bindingExtension3.Path = "OldPwd";
            BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue(null);
            passwordEntryCell.SetBinding(EntryCell.TextProperty, binding3);
            tableSection.Add(passwordEntryCell);
            translateExtension3.Text = "newpwd";
            IMarkupExtension markupExtension3 = translateExtension3;
            XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider();
            Type typeFromHandle5 = typeof(IProvideValueTarget);
            object[] array3 = new object[0 + 5];
            array3[0] = passwordEntryCell2;
            array3[1] = tableSection;
            array3[2] = tableRoot;
            array3[3] = tableView;
            array3[4] = this;
            xamlServiceProvider3.Add(typeFromHandle5, new SimpleValueTargetProvider(array3, EntryCell.LabelProperty));
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
            xamlServiceProvider3.Add(typeFromHandle6, new XamlTypeResolver(xmlNamespaceResolver3, typeof(ChangePwdPage).GetTypeInfo().Assembly));
            xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(17, 44)));
            object label2 = markupExtension3.ProvideValue(xamlServiceProvider3);
            passwordEntryCell2.Label = label2;
            bindingExtension4.Path = "NewPwd";
            BindingBase binding4 = ((IMarkupExtension<BindingBase>)bindingExtension4).ProvideValue(null);
            passwordEntryCell2.SetBinding(EntryCell.TextProperty, binding4);
            tableSection.Add(passwordEntryCell2);
            translateExtension4.Text = "repwd";
            IMarkupExtension markupExtension4 = translateExtension4;
            XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider();
            Type typeFromHandle7 = typeof(IProvideValueTarget);
            object[] array4 = new object[0 + 5];
            array4[0] = passwordEntryCell3;
            array4[1] = tableSection;
            array4[2] = tableRoot;
            array4[3] = tableView;
            array4[4] = this;
            xamlServiceProvider4.Add(typeFromHandle7, new SimpleValueTargetProvider(array4, EntryCell.LabelProperty));
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
            xamlServiceProvider4.Add(typeFromHandle8, new XamlTypeResolver(xmlNamespaceResolver4, typeof(ChangePwdPage).GetTypeInfo().Assembly));
            xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(18, 44)));
            object label3 = markupExtension4.ProvideValue(xamlServiceProvider4);
            passwordEntryCell3.Label = label3;
            bindingExtension5.Path = "RePwd";
            BindingBase binding5 = ((IMarkupExtension<BindingBase>)bindingExtension5).ProvideValue(null);
            passwordEntryCell3.SetBinding(EntryCell.TextProperty, binding5);
            tableSection.Add(passwordEntryCell3);
            tableRoot.Add(tableSection);
            tableView.Root = tableRoot;
            this.SetValue(ContentPage.ContentProperty, tableView);
        }

        // Token: 0x0600021E RID: 542 RVA: 0x000048FD File Offset: 0x00002AFD
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(ChangePwdPage));
        }
    }
}
