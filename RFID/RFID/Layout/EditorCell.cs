using System;
using System.CodeDom.Compiler;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Layout
{
    // Token: 0x020000DA RID: 218
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Layout\\EditorCell.xaml")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class EditorCell : ViewCell
    {
        // Token: 0x060004AE RID: 1198 RVA: 0x00020076 File Offset: 0x0001E276
        public EditorCell()
        {
            this.InitializeComponent();
        }

        // Token: 0x060004AF RID: 1199 RVA: 0x00020084 File Offset: 0x0001E284
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(EditorCell).GetTypeInfo().Assembly.GetName(), "Layout/EditorCell.xaml") != null)
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
            Label label = new Label();
            NoBorderEntry noBorderEntry = new NoBorderEntry();
            Grid grid = new Grid();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(columnDefinition, nameScope);
            NameScope.SetNameScope(columnDefinition2, nameScope);
            NameScope.SetNameScope(label, nameScope);
            ((INameScope)nameScope).RegisterName("label", label);
            if (label.StyleId == null)
            {
                label.StyleId = "label";
            }
            NameScope.SetNameScope(noBorderEntry, nameScope);
            ((INameScope)nameScope).RegisterName("entry", noBorderEntry);
            if (noBorderEntry.StyleId == null)
            {
                noBorderEntry.StyleId = "entry";
            }
            this.label = label;
            this.entry = noBorderEntry;
            grid.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            grid.SetValue(Grid.RowSpacingProperty, 5.0);
            grid.SetValue(Layout.PaddingProperty, new Thickness(10.0, 5.0, 10.0, 5.0));
            columnDefinition.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition);
            columnDefinition2.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("3*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition2);
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
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(EditorCell).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(12, 20)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider));
            label.SetValue(Label.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
            label.SetValue(Grid.ColumnProperty, 0);
            grid.Children.Add(label);
            noBorderEntry.SetValue(VisualElement.BackgroundColorProperty, new Color(0.93725490570068359, 0.93725490570068359, 0.93725490570068359, 1.0));
            noBorderEntry.SetValue(Entry.PlaceholderColorProperty, new Color(0.63529413938522339, 0.63529413938522339, 0.63529413938522339, 1.0));
            noBorderEntry.SetValue(Grid.ColumnProperty, 1);
            noBorderEntry.SetValue(Entry.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
            noBorderEntry.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            grid.Children.Add(noBorderEntry);
            this.View = grid;
        }

        // Token: 0x060004B0 RID: 1200 RVA: 0x0002047F File Offset: 0x0001E67F
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(EditorCell));
            this.label = this.FindByName("label");
            this.entry = this.FindByName("entry");
        }

        // Token: 0x04000343 RID: 835
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private Label label;

        // Token: 0x04000344 RID: 836
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private NoBorderEntry entry;
    }
}
