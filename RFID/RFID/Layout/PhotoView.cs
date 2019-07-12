using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using ES.Dmoral.Toasty;
using FFImageLoading.Forms;
using FFImageLoading.Svg.Forms;
using Plugin.CurrentActivity;
using Plugin.Media;
using Plugin.Media.Abstractions;
using RFID.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace RFID.Layout
{
    // Token: 0x020000EC RID: 236
    [XamlFilePath("G:\\RFIDDome\\RFID\\RFID\\Layout\\PhotoView.xaml")]
    public class PhotoView : ContentView
    {
        // Token: 0x06000531 RID: 1329 RVA: 0x0002466F File Offset: 0x0002286F
        public PhotoView()
        {
            this.InitializeComponent();
        }

        // Token: 0x14000004 RID: 4
        // (add) Token: 0x06000532 RID: 1330 RVA: 0x00024680 File Offset: 0x00022880
        // (remove) Token: 0x06000533 RID: 1331 RVA: 0x000246B8 File Offset: 0x000228B8
        public event TakePhotoHandler Closed;

        // Token: 0x14000005 RID: 5
        // (add) Token: 0x06000534 RID: 1332 RVA: 0x000246F0 File Offset: 0x000228F0
        // (remove) Token: 0x06000535 RID: 1333 RVA: 0x00024728 File Offset: 0x00022928
        public event TakePhotoHandler Finished;

        // Token: 0x17000175 RID: 373
        // (get) Token: 0x06000536 RID: 1334 RVA: 0x0002475D File Offset: 0x0002295D
        // (set) Token: 0x06000537 RID: 1335 RVA: 0x00024770 File Offset: 0x00022970
        public bool HasPhoto
        {
            get
            {
                return (bool)base.GetValue(PhotoView.HasPhotoProperty);
            }
            set
            {
                if (this.HasPhoto == value)
                {
                    return;
                }
                base.SetValue(PhotoView.HasPhotoProperty, value);
                this.OnPropertyChanged("HasPhoto");
            }
        }

        // Token: 0x17000176 RID: 374
        // (get) Token: 0x06000538 RID: 1336 RVA: 0x000247A7 File Offset: 0x000229A7
        // (set) Token: 0x06000539 RID: 1337 RVA: 0x000247BC File Offset: 0x000229BC
        public byte[] File
        {
            get
            {
                return (byte[])base.GetValue(PhotoView.FileProperty);
            }
            set
            {
                if (object.Equals(this.File, value))
                {
                    return;
                }
                base.SetValue(PhotoView.FileProperty, value);
                this.OnPropertyChanged("File");
            }
        }

        // Token: 0x0600053A RID: 1338 RVA: 0x000247F4 File Offset: 0x000229F4
        private static void OnFileChanged(BindableObject bindable, object oldValue, object newValue)
        {
            PhotoView photoView = bindable as PhotoView;
            if (newValue != null)
            {
                TakePhotoHandler finished = photoView.Finished;
                if (finished == null)
                {
                    return;
                }
                finished(new TakePhotoEventArgs
                {
                    File = photoView.File
                });
            }
        }

        // Token: 0x0600053B RID: 1339 RVA: 0x0002482C File Offset: 0x00022A2C
        private async void Handle_Tapped(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, AppResource.nophoto);
            }
            else if (App.CurNavigationPage != null)
            {
                PhotoView.<> c__DisplayClass16_0 CS$<> 8__locals1 = new PhotoView.<> c__DisplayClass16_0();
                if (this.photo.Source != null)
                {
                    ContentPage contentPage = new ContentPage
                    {
                        BackgroundColor = Color.Black,
                        Title = AppResource.qianfengphoto
                    };
                    contentPage.Content = new Image
                    {
                        Source = ImageSource.FromStream(() => new MemoryStream(this.File))
                    };
                    await App.CurNavigationPage.Navigation.PushAsync(contentPage);
                }
                else if (!CrossMedia.Current.IsTakePhotoSupported)
                {
                    Toasty.Error(CrossCurrentActivity.Current.Activity, "当前相机不允许使用,请检查权限或手机没有摄像头");
                }
                else
                {
                    CS$<> 8__locals1.meida = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                    {
                        SaveToAlbum = true,
                        Directory = "RFID",
                        CompressionQuality = 75,
                        PhotoSize = PhotoSize.Medium,
                        DefaultCamera = CameraDevice.Rear
                    });
                    if (CS$<> 8__locals1.meida != null)
					{
                        this.photo.Source = ImageSource.FromStream(() => CS$<> 8__locals1.meida.GetStream());
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            CS$<> 8__locals1.meida.GetStream().CopyTo(memoryStream);
                            this.File = memoryStream.ToArray();
                        }
                        CS$<> 8__locals1.meida.Dispose();
                        VisualElement visualElement = this.closeIcon;
                        int num = 1;
                        visualElement.IsVisible = (num != 0);
                        this.HasPhoto = (num != 0);
                        CS$<> 8__locals1 = null;
                    }
                }
            }
        }

        // Token: 0x0600053C RID: 1340 RVA: 0x00024865 File Offset: 0x00022A65
        private void Handle_Tapped_1(object sender, EventArgs e)
        {
            this.photo.Source = null;
            this.closeIcon.IsVisible = false;
            TakePhotoHandler closed = this.Closed;
            if (closed == null)
            {
                return;
            }
            closed(new TakePhotoEventArgs
            {
                File = this.File
            });
        }

        // Token: 0x0600053D RID: 1341 RVA: 0x000248A0 File Offset: 0x00022AA0
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            if (ResourceLoader.ResourceProvider != null && ResourceLoader.ResourceProvider(typeof(PhotoView).GetTypeInfo().Assembly.GetName(), "Layout/PhotoView.xaml") != null)
            {
                this.__InitComponentRuntime();
                return;
            }
            if (XamlLoader.XamlFileProvider != null && XamlLoader.XamlFileProvider(base.GetType()) != null)
            {
                this.__InitComponentRuntime();
                return;
            }
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            SvgCachedImage svgCachedImage = new SvgCachedImage();
            TapGestureRecognizer tapGestureRecognizer2 = new TapGestureRecognizer();
            Image image = new Image();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            Frame frame = new Frame();
            TapGestureRecognizer tapGestureRecognizer3 = new TapGestureRecognizer();
            SvgCachedImage svgCachedImage2 = new SvgCachedImage();
            AbsoluteLayout absoluteLayout2 = new AbsoluteLayout();
            NameScope nameScope = new NameScope();
            NameScope.SetNameScope(this, nameScope);
            NameScope.SetNameScope(absoluteLayout2, nameScope);
            NameScope.SetNameScope(frame, nameScope);
            NameScope.SetNameScope(absoluteLayout, nameScope);
            NameScope.SetNameScope(svgCachedImage, nameScope);
            NameScope.SetNameScope(tapGestureRecognizer, nameScope);
            NameScope.SetNameScope(image, nameScope);
            ((INameScope)nameScope).RegisterName("photo", image);
            if (image.StyleId == null)
            {
                image.StyleId = "photo";
            }
            NameScope.SetNameScope(tapGestureRecognizer2, nameScope);
            NameScope.SetNameScope(svgCachedImage2, nameScope);
            ((INameScope)nameScope).RegisterName("closeIcon", svgCachedImage2);
            if (svgCachedImage2.StyleId == null)
            {
                svgCachedImage2.StyleId = "closeIcon";
            }
            NameScope.SetNameScope(tapGestureRecognizer3, nameScope);
            this.photo = image;
            this.closeIcon = svgCachedImage2;
            absoluteLayout2.SetValue(VisualElement.BackgroundColorProperty, Color.Transparent);
            absoluteLayout2.SetValue(VisualElement.HeightRequestProperty, 90.0);
            absoluteLayout2.SetValue(VisualElement.WidthRequestProperty, 90.0);
            frame.SetValue(Grid.RowProperty, 0);
            frame.SetValue(Frame.HasShadowProperty, false);
            frame.SetValue(Frame.CornerRadiusProperty, 10f);
            frame.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(0.0));
            frame.SetValue(VisualElement.BackgroundColorProperty, Color.Silver);
            frame.SetValue(AbsoluteLayout.LayoutBoundsProperty, new Rectangle(0.0, 0.0, 1.0, 1.0));
            frame.SetValue(AbsoluteLayout.LayoutFlagsProperty, AbsoluteLayoutFlags.All);
            svgCachedImage.SetValue(CachedImage.SourceProperty, new FFImageLoading.Forms.ImageSourceConverter().ConvertFromInvariantString("Camera.svg"));
            svgCachedImage.SetValue(VisualElement.HeightRequestProperty, 55.0);
            svgCachedImage.SetValue(VisualElement.WidthRequestProperty, 55.0);
            svgCachedImage.SetValue(AbsoluteLayout.LayoutBoundsProperty, new Rectangle(0.5, 0.5, -1.0, -1.0));
            svgCachedImage.SetValue(AbsoluteLayout.LayoutFlagsProperty, AbsoluteLayoutFlags.PositionProportional);
            tapGestureRecognizer.Tapped += this.Handle_Tapped;
            svgCachedImage.GestureRecognizers.Add(tapGestureRecognizer);
            absoluteLayout.Children.Add(svgCachedImage);
            image.SetValue(Image.AspectProperty, Aspect.AspectFill);
            image.SetValue(AbsoluteLayout.LayoutBoundsProperty, new Rectangle(0.0, 0.0, 1.0, 1.0));
            image.SetValue(AbsoluteLayout.LayoutFlagsProperty, AbsoluteLayoutFlags.All);
            tapGestureRecognizer2.Tapped += this.Handle_Tapped;
            image.GestureRecognizers.Add(tapGestureRecognizer2);
            absoluteLayout.Children.Add(image);
            frame.SetValue(ContentView.ContentProperty, absoluteLayout);
            absoluteLayout2.Children.Add(frame);
            svgCachedImage2.SetValue(VisualElement.IsVisibleProperty, new VisualElement.VisibilityConverter().ConvertFromInvariantString("false"));
            svgCachedImage2.SetValue(CachedImage.SourceProperty, new FFImageLoading.Forms.ImageSourceConverter().ConvertFromInvariantString("error.svg"));
            svgCachedImage2.SetValue(VisualElement.HeightRequestProperty, 40.0);
            svgCachedImage2.SetValue(VisualElement.WidthRequestProperty, 40.0);
            svgCachedImage2.SetValue(AbsoluteLayout.LayoutBoundsProperty, new Rectangle(53.0, -3.0, -1.0, -1.0));
            svgCachedImage2.SetValue(AbsoluteLayout.LayoutFlagsProperty, AbsoluteLayoutFlags.None);
            tapGestureRecognizer3.Tapped += this.Handle_Tapped_1;
            svgCachedImage2.GestureRecognizers.Add(tapGestureRecognizer3);
            absoluteLayout2.Children.Add(svgCachedImage2);
            this.SetValue(ContentView.ContentProperty, absoluteLayout2);
        }

        // Token: 0x06000540 RID: 1344 RVA: 0x00024DE6 File Offset: 0x00022FE6
        private void __InitComponentRuntime()
        {
            this.LoadFromXaml(typeof(PhotoView));
            this.photo = this.FindByName("photo");
            this.closeIcon = this.FindByName("closeIcon");
        }

        // Token: 0x04000384 RID: 900
        public static readonly BindableProperty HasPhotoProperty = BindableProperty.Create("HasPhoto", typeof(bool), typeof(PhotoView), false, BindingMode.OneWay, null, null, null, null, null);

        // Token: 0x04000385 RID: 901
        public static readonly BindableProperty FileProperty = BindableProperty.Create("File", typeof(byte[]), typeof(PhotoView), null, BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(PhotoView.OnFileChanged), null, null, null);

        // Token: 0x04000386 RID: 902
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private Image photo;

        // Token: 0x04000387 RID: 903
        [GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private SvgCachedImage closeIcon;
    }
}
