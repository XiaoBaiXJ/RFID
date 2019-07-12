using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Runtime.CompilerServices;
using ImageCircle.Forms.Plugin.Abstractions;
using RFID.Layout;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Views
{
    // Token: 0x02000062 RID: 98
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Views\\MinePage.xaml")]
    public class MinePage : ContentPage
    {
        // Token: 0x0600024B RID: 587 RVA: 0x0000D8DD File Offset: 0x0000BADD
        public MinePage()
        {
            this.InitializeComponent();
        }

        // Token: 0x0600024C RID: 588 RVA: 0x0000D8EB File Offset: 0x0000BAEB
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        // Token: 0x0600024D RID: 589 RVA: 0x0000D8F3 File Offset: 0x0000BAF3
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (this.listview.SelectedItem == null)
            {
                return;
            }
            this.listview.SelectedItem = null;
        }

        // Token: 0x0600024E RID: 590 RVA: 0x0000D910 File Offset: 0x0000BB10
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(MinePage).GetTypeInfo().Assembly.GetName(), "Views/MinePage.xaml") != null)
            {
                this.__InitComponentRuntime();
                return;
            }
            if (XamlLoader.XamlFileProvider != null && XamlLoader.XamlFileProvider(base.GetType()) != null)
            {
                this.__InitComponentRuntime();
                return;
            }
            RowDefinition rowDefinition = new RowDefinition();
            RowDefinition rowDefinition2 = new RowDefinition();
            RowDefinition rowDefinition3 = new RowDefinition();
            BindingExtension bindingExtension = new BindingExtension();
            Image image = new Image();
            BindingExtension bindingExtension2 = new BindingExtension();
            CircleImage circleImage = new CircleImage();
            BindingExtension bindingExtension3 = new BindingExtension();
            Label label = new Label();
            BindingExtension bindingExtension4 = new BindingExtension();
            Label label2 = new Label();
            StackLayout stackLayout = new StackLayout();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            Frame frame = new Frame();
            BindingExtension bindingExtension5 = new BindingExtension();
            DataTemplate dataTemplate = new DataTemplate();
            ListView listView = new ListView();
            Frame frame2 = new Frame();
            TranslateExtension translateExtension = new TranslateExtension();
            BindingExtension bindingExtension6 = new BindingExtension();
            Button button = new Button();
            Grid grid = new Grid();
            ScrollView scrollView = new ScrollView();
            BindingExtension bindingExtension7 = new BindingExtension();
            BindingExtension bindingExtension8 = new BindingExtension();
            ActivityIndicator activityIndicator = new ActivityIndicator();
            Grid grid2 = new Grid();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(grid2, nameScope);
            NameScope.SetNameScope(scrollView, nameScope);
            NameScope.SetNameScope(grid, nameScope);
            NameScope.SetNameScope(rowDefinition, nameScope);
            NameScope.SetNameScope(rowDefinition2, nameScope);
            NameScope.SetNameScope(rowDefinition3, nameScope);
            NameScope.SetNameScope(frame, nameScope);
            NameScope.SetNameScope(absoluteLayout, nameScope);
            NameScope.SetNameScope(image, nameScope);
            NameScope.SetNameScope(stackLayout, nameScope);
            NameScope.SetNameScope(circleImage, nameScope);
            NameScope.SetNameScope(label, nameScope);
            NameScope.SetNameScope(label2, nameScope);
            NameScope.SetNameScope(frame2, nameScope);
            NameScope.SetNameScope(listView, nameScope);
            ((INameScope)nameScope).RegisterName("listview", listView);
            if (listView.StyleId == null)
            {
                listView.StyleId = "listview";
            }
            NameScope.SetNameScope(button, nameScope);
            NameScope.SetNameScope(activityIndicator, nameScope);
            this.listview = listView;
            this.SetValue(NavigationPage.HasNavigationBarProperty, false);
            grid.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(10.0));
            grid.SetValue(Grid.RowSpacingProperty, 10.0);
            rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition);
            rowDefinition2.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition2);
            rowDefinition3.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("Auto"));
            grid.GetValue(Grid.RowDefinitionsProperty).Add(rowDefinition3);
            frame.SetValue(Grid.RowProperty, 0);
            frame.SetValue(Frame.HasShadowProperty, false);
            frame.SetValue(Frame.CornerRadiusProperty, 10f);
            frame.SetValue(VisualElement.BackgroundColorProperty, Color.Black);
            frame.SetValue(Frame.BorderColorProperty, Color.Black);
            frame.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(0.0));
            absoluteLayout.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(0.0));
            absoluteLayout.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
            absoluteLayout.SetValue(View.VerticalOptionsProperty, LayoutOptions.FillAndExpand);
            image.SetValue(Image.AspectProperty, Aspect.AspectFill);
            bindingExtension.Path = "Background";
            BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue(null);
            image.SetBinding(Image.SourceProperty, binding);
            image.SetValue(AbsoluteLayout.LayoutBoundsProperty, new Rectangle(0.0, 0.0, 1.0, 1.0));
            image.SetValue(AbsoluteLayout.LayoutFlagsProperty, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(image);
            stackLayout.SetValue(VisualElement.BackgroundColorProperty, Color.Transparent);
            stackLayout.SetValue(AbsoluteLayout.LayoutBoundsProperty, new Rectangle(0.5, 0.5, -1.0, -1.0));
            stackLayout.SetValue(AbsoluteLayout.LayoutFlagsProperty, AbsoluteLayoutFlags.PositionProportional);
            bindingExtension2.Path = "UserIcon";
            BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue(null);
            circleImage.SetBinding(Image.SourceProperty, binding2);
            circleImage.SetValue(VisualElement.HeightRequestProperty, 80.0);
            circleImage.SetValue(VisualElement.WidthRequestProperty, 80.0);
            circleImage.SetValue(Image.AspectProperty, Aspect.AspectFit);
            stackLayout.Children.Add(circleImage);
            label.SetValue(Label.TextColorProperty, Color.White);
            BindableObject bindableObject = label;
            BindableProperty fontSizeProperty = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter = new FontSizeConverter();
            string value = "Large";
            XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
            Type typeFromHandle = typeof(IProvideValueTarget);
            object[] array = new object[0 + 8];
            array[0] = label;
            array[1] = stackLayout;
            array[2] = absoluteLayout;
            array[3] = frame;
            array[4] = grid;
            array[5] = scrollView;
            array[6] = grid2;
            array[7] = this;
            xamlServiceProvider.Add(typeFromHandle, new SimpleValueTargetProvider(array, Label.FontSizeProperty));
            xamlServiceProvider.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle2 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver = new XmlNamespaceResolver();
            xmlNamespaceResolver.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver.Add("circle", "clr-namespace:ImageCircle.Forms.Plugin.Abstractions;assembly=ImageCircle.Forms.Plugin");
            xmlNamespaceResolver.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver.Add("local", "clr-namespace:RFID");
            xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(MinePage).GetTypeInfo().Assembly));
            xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(25, 62)));
            bindableObject.SetValue(fontSizeProperty, extendedTypeConverter.ConvertFromInvariantString(value, xamlServiceProvider));
            bindingExtension3.Path = "Name";
            BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue(null);
            label.SetBinding(Label.TextProperty, binding3);
            label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
            stackLayout.Children.Add(label);
            label2.SetValue(Label.TextColorProperty, Color.White);
            BindableObject bindableObject2 = label2;
            BindableProperty fontSizeProperty2 = Label.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter2 = new FontSizeConverter();
            string value2 = "Medium";
            XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
            Type typeFromHandle3 = typeof(IProvideValueTarget);
            object[] array2 = new object[0 + 8];
            array2[0] = label2;
            array2[1] = stackLayout;
            array2[2] = absoluteLayout;
            array2[3] = frame;
            array2[4] = grid;
            array2[5] = scrollView;
            array2[6] = grid2;
            array2[7] = this;
            xamlServiceProvider2.Add(typeFromHandle3, new SimpleValueTargetProvider(array2, Label.FontSizeProperty));
            xamlServiceProvider2.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle4 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver2 = new XmlNamespaceResolver();
            xmlNamespaceResolver2.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver2.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver2.Add("circle", "clr-namespace:ImageCircle.Forms.Plugin.Abstractions;assembly=ImageCircle.Forms.Plugin");
            xmlNamespaceResolver2.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver2.Add("local", "clr-namespace:RFID");
            xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(MinePage).GetTypeInfo().Assembly));
            xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(26, 62)));
            bindableObject2.SetValue(fontSizeProperty2, extendedTypeConverter2.ConvertFromInvariantString(value2, xamlServiceProvider2));
            bindingExtension4.Path = "Introduce";
            BindingBase binding4 = ((IMarkupExtension<BindingBase>)bindingExtension4).ProvideValue(null);
            label2.SetBinding(Label.TextProperty, binding4);
            label2.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
            stackLayout.Children.Add(label2);
            absoluteLayout.Children.Add(stackLayout);
            frame.SetValue(ContentView.ContentProperty, absoluteLayout);
            grid.Children.Add(frame);
            frame2.SetValue(Frame.OutlineColorProperty, Color.White);
            frame2.SetValue(Grid.RowProperty, 1);
            frame2.SetValue(Frame.CornerRadiusProperty, 5f);
            frame2.SetValue(VisualElement.BackgroundColorProperty, Color.White);
            frame2.SetValue(Frame.BorderColorProperty, new Color(0.87058824300765991, 0.87058824300765991, 0.87058824300765991, 1.0));
            frame2.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(0.0));
            listView.SetValue(ListView.RowHeightProperty, 50);
            listView.SetValue(VisualElement.HeightRequestProperty, 203.0);
            listView.SetValue(ListView.SeparatorColorProperty, new Color(0.87058824300765991, 0.87058824300765991, 0.87058824300765991, 1.0));
            listView.SetValue(ListView.SeparatorVisibilityProperty, SeparatorVisibility.Default);
            listView.ItemSelected += this.ListView_ItemSelected;
            bindingExtension5.Path = "MenuSource";
            BindingBase binding5 = ((IMarkupExtension<BindingBase>)bindingExtension5).ProvideValue(null);
            listView.SetBinding(ItemsView<Cell>.ItemsSourceProperty, binding5);
            IDataTemplate dataTemplate2 = dataTemplate;
            MinePage.< InitializeComponent > _anonXamlCDataTemplate_1 < InitializeComponent > _anonXamlCDataTemplate_ = new MinePage.< InitializeComponent > _anonXamlCDataTemplate_1();
            object[] array3 = new object[0 + 7];
            array3[0] = dataTemplate;
            array3[1] = listView;
            array3[2] = frame2;
            array3[3] = grid;
            array3[4] = scrollView;
            array3[5] = grid2;
            array3[6] = this;

            < InitializeComponent > _anonXamlCDataTemplate_.parentValues = array3;

            < InitializeComponent > _anonXamlCDataTemplate_.root = this;
            dataTemplate2.LoadTemplate = new Func<object>(< InitializeComponent > _anonXamlCDataTemplate_.LoadDataTemplate);
            listView.SetValue(ItemsView<Cell>.ItemTemplateProperty, dataTemplate);
            frame2.SetValue(ContentView.ContentProperty, listView);
            grid.Children.Add(frame2);
            button.SetValue(Grid.RowProperty, 2);
            BindableObject bindableObject3 = button;
            BindableProperty fontSizeProperty3 = Button.FontSizeProperty;
            IExtendedTypeConverter extendedTypeConverter3 = new FontSizeConverter();
            string value3 = "Default";
            XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider();
            Type typeFromHandle5 = typeof(IProvideValueTarget);
            object[] array4 = new object[0 + 5];
            array4[0] = button;
            array4[1] = grid;
            array4[2] = scrollView;
            array4[3] = grid2;
            array4[4] = this;
            xamlServiceProvider3.Add(typeFromHandle5, new SimpleValueTargetProvider(array4, Button.FontSizeProperty));
            xamlServiceProvider3.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle6 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver3 = new XmlNamespaceResolver();
            xmlNamespaceResolver3.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver3.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver3.Add("circle", "clr-namespace:ImageCircle.Forms.Plugin.Abstractions;assembly=ImageCircle.Forms.Plugin");
            xmlNamespaceResolver3.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver3.Add("local", "clr-namespace:RFID");
            xamlServiceProvider3.Add(typeFromHandle6, new XamlTypeResolver(xmlNamespaceResolver3, typeof(MinePage).GetTypeInfo().Assembly));
            xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(39, 46)));
            bindableObject3.SetValue(fontSizeProperty3, extendedTypeConverter3.ConvertFromInvariantString(value3, xamlServiceProvider3));
            button.SetValue(Button.TextColorProperty, Color.White);
            translateExtension.Text = "exit";
            IMarkupExtension markupExtension = translateExtension;
            XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider();
            Type typeFromHandle7 = typeof(IProvideValueTarget);
            object[] array5 = new object[0 + 5];
            array5[0] = button;
            array5[1] = grid;
            array5[2] = scrollView;
            array5[3] = grid2;
            array5[4] = this;
            xamlServiceProvider4.Add(typeFromHandle7, new SimpleValueTargetProvider(array5, Button.TextProperty));
            xamlServiceProvider4.Add(typeof(INameScopeProvider), new NameScopeProvider
            {
                NameScope = nameScope
            });
            Type typeFromHandle8 = typeof(IXamlTypeResolver);
            XmlNamespaceResolver xmlNamespaceResolver4 = new XmlNamespaceResolver();
            xmlNamespaceResolver4.Add("", "http://xamarin.com/schemas/2014/forms");
            xmlNamespaceResolver4.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
            xmlNamespaceResolver4.Add("circle", "clr-namespace:ImageCircle.Forms.Plugin.Abstractions;assembly=ImageCircle.Forms.Plugin");
            xmlNamespaceResolver4.Add("layout", "clr-namespace:RFID.Layout");
            xmlNamespaceResolver4.Add("local", "clr-namespace:RFID");
            xamlServiceProvider4.Add(typeFromHandle8, new XamlTypeResolver(xmlNamespaceResolver4, typeof(MinePage).GetTypeInfo().Assembly));
            xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(39, 83)));
            object text = markupExtension.ProvideValue(xamlServiceProvider4);
            button.Text = text;
            button.SetValue(VisualElement.BackgroundColorProperty, new Color(0.83529412746429443, 0.0, 0.0, 1.0));
            button.SetValue(Button.BorderColorProperty, new Color(0.83529412746429443, 0.0, 0.0, 1.0));
            button.SetValue(Button.BorderWidthProperty, 1.0);
            button.SetValue(Button.BorderRadiusProperty, 5);
            bindingExtension6.Path = "ExitCommand";
            BindingBase binding6 = ((IMarkupExtension<BindingBase>)bindingExtension6).ProvideValue(null);
            button.SetBinding(Button.CommandProperty, binding6);
            grid.Children.Add(button);
            scrollView.Content = grid;
            grid2.Children.Add(scrollView);
            bindingExtension7.Path = "IsBusy";
            BindingBase binding7 = ((IMarkupExtension<BindingBase>)bindingExtension7).ProvideValue(null);
            activityIndicator.SetBinding(ActivityIndicator.IsRunningProperty, binding7);
            bindingExtension8.Path = "IsBusy";
            BindingBase binding8 = ((IMarkupExtension<BindingBase>)bindingExtension8).ProvideValue(null);
            activityIndicator.SetBinding(VisualElement.IsVisibleProperty, binding8);
            activityIndicator.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
            activityIndicator.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
            grid2.Children.Add(activityIndicator);
            this.SetValue(ContentPage.ContentProperty, grid2);
        }

        // Token: 0x0600024F RID: 591 RVA: 0x0000E6E7 File Offset: 0x0000C8E7
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(MinePage));
            this.listview = this.FindByName("listview");
        }

        // Token: 0x04000136 RID: 310
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private ListView listview;

        // Token: 0x02000063 RID: 99
        [CompilerGenerated]
        private sealed class <InitializeComponent>_anonXamlCDataTemplate_1
		{
			// Token: 0x06000251 RID: 593 RVA: 0x0000E720 File Offset: 0x0000C920
			internal object LoadDataTemplate()
        {
            MineCell mineCell = new MineCell();
            NameScope value = new NameScope();
            NameScope.SetNameScope(mineCell, value);
            return mineCell;
        }

        // Token: 0x04000137 RID: 311
        internal object[] parentValues;

        // Token: 0x04000138 RID: 312
        internal MinePage root;
    }
}
}
