using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using FFImageLoading.Forms;
using FFImageLoading.Svg.Forms;
using Prism.Behaviors;
using Prism.Mvvm;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Views
{
    // Token: 0x02000055 RID: 85
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Views\\DriverPage.xaml")]
    public class DriverPage : ContentPage
    {
        // Token: 0x06000222 RID: 546 RVA: 0x00005EB1 File Offset: 0x000040B1
        public DriverPage()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000223 RID: 547 RVA: 0x00005EBF File Offset: 0x000040BF
        private void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (this.listview.SelectedItem == null)
            {
                return;
            }
            this.listview.SelectedItem = null;
        }

        // Token: 0x06000224 RID: 548 RVA: 0x00005EDC File Offset: 0x000040DC
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(DriverPage).GetTypeInfo().Assembly.GetName(), "Views/DriverPage.xaml") != null)
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
            ColumnDefinition columnDefinition = new ColumnDefinition();
            ColumnDefinition columnDefinition2 = new ColumnDefinition();
            BindingExtension bindingExtension2 = new BindingExtension();
            TranslateExtension translateExtension = new TranslateExtension();
            BindingExtension bindingExtension3 = new BindingExtension();
            BindingExtension bindingExtension4 = new BindingExtension();
            EventToCommandBehavior eventToCommandBehavior = new EventToCommandBehavior();
            SearchBar searchBar = new SearchBar();
            BindingExtension bindingExtension5 = new BindingExtension();
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            SvgCachedImage svgCachedImage = new SvgCachedImage();
            Grid grid = new Grid();
            BindingExtension bindingExtension6 = new BindingExtension();
            BindingExtension bindingExtension7 = new BindingExtension();
            EventToCommandBehavior eventToCommandBehavior2 = new EventToCommandBehavior();
            DataTemplate dataTemplate = new DataTemplate();
            ListView listView = new ListView();
            Grid grid2 = new Grid();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(grid2, nameScope);
            NameScope.SetNameScope(rowDefinition, nameScope);
            NameScope.SetNameScope(rowDefinition2, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(columnDefinition, nameScope);
            NameScope.SetNameScope(columnDefinition2, nameScope);
            NameScope.SetNameScope(searchBar, nameScope);
            NameScope.SetNameScope(eventToCommandBehavior, nameScope);
            NameScope.SetNameScope(svgCachedImage, nameScope);
            NameScope.SetNameScope(tapGestureRecognizer, nameScope);
            NameScope.SetNameScope(listView, nameScope);
            ((INameScope)nameScope).RegisterName("listview", listView);
            if (listView.StyleId == null)
            {
                listView.StyleId = "listview";
            }
            NameScope.SetNameScope(eventToCommandBehavior2, nameScope);
            this.listview = listView;
            this.SetValue(ViewModelLocator.AutowireViewModelProperty, new bool?(true));
            bindingExtension.Path = "Title";
            BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue(null);
            this.SetBinding(Page.TitleProperty, binding);
            rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid2.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition);
            rowDefinition2.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid2.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition2);
            grid.SetValue(Grid.RowProperty, 0);
            grid.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            grid.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(10.0));
            grid.SetValue(Grid.ColumnSpacingProperty, 10.0);
            columnDefinition.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition);
            columnDefinition2.SetValue(ColumnDefinition.WidthProperty, new GridLengthTypeConverter().ConvertFromInvariantString("24"));
            grid.GetValue(Grid.ColumnDefinitionsProperty).Add(columnDefinition2);
            searchBar.SetValue(Grid.ColumnProperty, 0);
            bindingExtension2.Path = "SearchText";
            BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue(null);
            searchBar.SetBinding(SearchBar.TextProperty, binding2);
            translateExtension.Text = "search";
            IMarkupExtension markupExtension = translateExtension;
            XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
            Type typeFromHandle = typeof(IProvideValueTarget);
            object[] array = new object[0 + 4];
            array[0] = searchBar;
            array[1] = grid;
            array[2] = grid2;
            array[3] = this;
            xamlServiceProvider.Add(typeFromHandle, new SimpleValueTargetProvider(array, SearchBar.PlaceholderProperty));
            xamlServiceProvider.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle2 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver = new XmlNamespaceResolver();
            xmlNamespaceResolver.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver.Add("prism", "clr-namespace:Prism.Mvvm;assembly=Prism.Forms");
            xmlNamespaceResolver.Add("local", "clr-namespace:RFID");
            xmlNamespaceResolver.Add("b", "clr-namespace:Prism.Behaviors;assembly=Prism.Forms");
            xmlNamespaceResolver.Add("svg", "clr-namespace:FFImageLoading.Svg.Forms;assembly=FFImageLoading.Svg.Forms");
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(DriverPage).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(21, 65)));
            object placeholder = markupExtension.ProvideValue(xamlServiceProvider);
            searchBar.Placeholder = placeholder;
            searchBar.SetValue(SearchBar.TextColorProperty, new Color(0.501960813999176, 0.501960813999176, 0.501960813999176, 1.0));
            bindingExtension3.Path = "SearchCommand";
            BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue(null);
            searchBar.SetBinding(SearchBar.SearchCommandProperty, binding3);
            searchBar.SetValue(VisualElement.BackgroundColorProperty, new Color(0.93725490570068359, 0.93725490570068359, 0.93725490570068359, 1.0));
            eventToCommandBehavior.SetValue(EventToCommandBehavior.EventNameProperty, "TextChanged");
            bindingExtension4.Path = "SearchCommand";
            BindingBase binding4 = ((IMarkupExtension<BindingBase>)bindingExtension4).ProvideValue(null);
            eventToCommandBehavior.SetBinding(EventToCommandBehavior.CommandProperty, binding4);
            ((ICollection<Behavior>)searchBar.GetValue(VisualElement.BehaviorsProperty)).Add(eventToCommandBehavior);
            grid.Children.Add(searchBar);
            svgCachedImage.SetValue(Grid.ColumnProperty, 1);
            svgCachedImage.SetValue(VisualElement.WidthRequestProperty, 24.0);
            svgCachedImage.SetValue(VisualElement.HeightRequestProperty, 24.0);
            svgCachedImage.SetValue(CachedImage.SourceProperty, new FFImageLoading.Forms.ImageSourceConverter().ConvertFromInvariantString("plus.svg"));
            bindingExtension5.Path = "AddCommand";
            BindingBase binding5 = ((IMarkupExtension<BindingBase>)bindingExtension5).ProvideValue(null);
            tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, binding5);
            svgCachedImage.GestureRecognizers.Add(tapGestureRecognizer);
            grid.Children.Add(svgCachedImage);
            grid2.Children.Add(grid);
            listView.SetValue(Grid.RowProperty, 1);
            listView.SetValue(VisualElement.BackgroundColorProperty, new Color(0.98039215803146362, 0.98039215803146362, 0.98039215803146362, 1.0));
            bindingExtension6.Path = "SearchSource";
            BindingBase binding6 = ((IMarkupExtension<BindingBase>)bindingExtension6).ProvideValue(null);
            listView.SetBinding(ItemsView<Cell>.ItemsSourceProperty, binding6);
            listView.ItemSelected += this.Handle_ItemSelected;
            eventToCommandBehavior2.SetValue(EventToCommandBehavior.EventNameProperty, "ItemTapped");
            bindingExtension7.Path = "SelectCommand";
            BindingBase binding7 = ((IMarkupExtension<BindingBase>)bindingExtension7).ProvideValue(null);
            eventToCommandBehavior2.SetBinding(EventToCommandBehavior.CommandProperty, binding7);
            eventToCommandBehavior2.SetValue(EventToCommandBehavior.EventArgsParameterPathProperty, "Item");
            ((ICollection<Behavior>)listView.GetValue(VisualElement.BehaviorsProperty)).Add(eventToCommandBehavior2);
            IDataTemplate dataTemplate2 = dataTemplate;
            DriverPage.< InitializeComponent > _anonXamlCDataTemplate_6 < InitializeComponent > _anonXamlCDataTemplate_ = new DriverPage.< InitializeComponent > _anonXamlCDataTemplate_6();
            object[] array2 = new object[0 + 4];
            array2[0] = dataTemplate;
            array2[1] = listView;
            array2[2] = grid2;
            array2[3] = this;

            < InitializeComponent > _anonXamlCDataTemplate_.parentValues = array2;

            < InitializeComponent > _anonXamlCDataTemplate_.root = this;
            dataTemplate2.LoadTemplate = new Func<object>(< InitializeComponent > _anonXamlCDataTemplate_.LoadDataTemplate);
            listView.SetValue(ItemsView<Cell>.ItemTemplateProperty, dataTemplate);
            grid2.Children.Add(listView);
            this.SetValue(ContentPage.ContentProperty, grid2);
        }

        // Token: 0x06000225 RID: 549 RVA: 0x00006604 File Offset: 0x00004804
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(DriverPage));
            this.listview = this.FindByName("listview");
        }

        // Token: 0x04000129 RID: 297
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private ListView listview;

        // Token: 0x02000056 RID: 86
        [CompilerGenerated]
        private sealed class <InitializeComponent>_anonXamlCDataTemplate_6
		{
			// Token: 0x06000227 RID: 551 RVA: 0x0000663C File Offset: 0x0000483C
			internal object LoadDataTemplate()
        {
            BindingExtension bindingExtension = new BindingExtension();
            TextCell textCell = new TextCell();
            NameScope value = new NameScope();
            NameScope.SetNameScope(textCell, value);
            bindingExtension.Path = "Name";
            BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue(null);
            textCell.SetBinding(TextCell.TextProperty, binding);
            return textCell;
        }

        // Token: 0x0400012A RID: 298
        internal object[] parentValues;

        // Token: 0x0400012B RID: 299
        internal DriverPage root;
    }
}
}
