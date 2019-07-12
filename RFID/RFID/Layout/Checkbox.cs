using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace RFID.Layout
{
    // Token: 0x020000D5 RID: 213
    [Browsable(true)]
    public class Checkbox : ContentView, IDisposable
    {
        // Token: 0x06000489 RID: 1161 RVA: 0x0001F11C File Offset: 0x0001D31C
        public Checkbox()
        {
            this.InitializeCanvas();
            base.WidthRequest = (base.HeightRequest = Checkbox.DEFAULT_SIZE);
            LayoutOptions layoutOptions = new LayoutOptions(LayoutAlignment.Center, false);
            base.VerticalOptions = layoutOptions;
            base.HorizontalOptions = layoutOptions;
            base.Content = this._skiaView;
            base.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = this._toggleCommand
            });
        }

        // Token: 0x1700014F RID: 335
        // (get) Token: 0x0600048A RID: 1162 RVA: 0x0001F188 File Offset: 0x0001D388
        private static Design DEFAULT_DESIGN
        {
            get
            {
                return Design.Unified;
            }
        }

        // Token: 0x17000150 RID: 336
        // (get) Token: 0x0600048B RID: 1163 RVA: 0x0001F18C File Offset: 0x0001D38C
        private static Shape DEFAULT_SHAPE
        {
            get
            {
                string runtimePlatform = Device.RuntimePlatform;
                Shape result;
                if (!(runtimePlatform == "Android") && !(runtimePlatform == "UWP"))
                {
                    if (!(runtimePlatform == "iOS"))
                    {
                    }
                    result = Shape.Circle;
                }
                else
                {
                    result = Shape.Rectangle;
                }
                return result;
            }
        }

        // Token: 0x17000151 RID: 337
        // (get) Token: 0x0600048C RID: 1164 RVA: 0x0001F1D0 File Offset: 0x0001D3D0
        private static float DEFAULT_OUTLINE_WIDTH
        {
            get
            {
                string runtimePlatform = Device.RuntimePlatform;
                float result;
                if (!(runtimePlatform == "iOS"))
                {
                    if (!(runtimePlatform == "UWP"))
                    {
                        if (!(runtimePlatform == "Android"))
                        {
                        }
                        result = 6f;
                    }
                    else
                    {
                        result = 2.5f;
                    }
                }
                else
                {
                    result = 4f;
                }
                return result;
            }
        }

        // Token: 0x17000152 RID: 338
        // (get) Token: 0x0600048D RID: 1165 RVA: 0x0001F224 File Offset: 0x0001D424
        private static double DEFAULT_SIZE
        {
            get
            {
                string runtimePlatform = Device.RuntimePlatform;
                double result;
                if (!(runtimePlatform == "UWP"))
                {
                    if (!(runtimePlatform == "iOS") && !(runtimePlatform == "Android"))
                    {
                    }
                    result = 24.0;
                }
                else
                {
                    result = 20.0;
                }
                return result;
            }
        }

        // Token: 0x0600048E RID: 1166 RVA: 0x0001F278 File Offset: 0x0001D478
        private void InitializeCanvas()
        {
            this._toggleCommand = new Command(new Action<object>(this.OnTappedCommand));
            this._skiaView = new SKCanvasView();
            this._skiaView.PaintSurface += this.Handle_PaintSurface;
            this._skiaView.WidthRequest = (this._skiaView.HeightRequest = Checkbox.DEFAULT_SIZE);
        }

        // Token: 0x0600048F RID: 1167 RVA: 0x0001F2DC File Offset: 0x0001D4DC
        private void OnTappedCommand(object obj)
        {
            if (this._isAnimating)
            {
                return;
            }
            this.IsChecked = !this.IsChecked;
        }

        // Token: 0x06000490 RID: 1168 RVA: 0x0001F2F8 File Offset: 0x0001D4F8
        private async Task AnimateToggle()
        {
            this._isAnimating = true;
            await this._skiaView.ScaleTo(0.85, 100u, null);
            this._skiaView.InvalidateSurface();
            await this._skiaView.ScaleTo(1.0, 100u, Easing.BounceOut);
            this._isAnimating = false;
        }

        // Token: 0x06000491 RID: 1169 RVA: 0x0001F33D File Offset: 0x0001D53D
        private void Handle_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            if (e != null)
            {
                SKSurface surface = e.Surface;
                if (surface != null)
                {
                    SKCanvas canvas = surface.Canvas;
                    if (canvas != null)
                    {
                        canvas.Clear();
                    }
                }
            }
            this.DrawOutline(e);
            if (this.IsChecked)
            {
                this.DrawCheckFilled(e);
            }
        }

        // Token: 0x06000492 RID: 1170 RVA: 0x0001F374 File Offset: 0x0001D574
        private void DrawCheckFilled(SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKCanvas skcanvas;
            if (e == null)
            {
                skcanvas = null;
            }
            else
            {
                SKSurface surface = e.Surface;
                skcanvas = ((surface != null) ? surface.Canvas : null);
            }
            SKCanvas skcanvas2 = skcanvas;
            using (SKPaint skpaint = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = this.FillColor.ToSKColor(),
                StrokeJoin = SKStrokeJoin.Round,
                IsAntialias = true
            })
            {
                if (((this.Design == Design.Unified) ? this.Shape : Checkbox.DEFAULT_SHAPE) == Shape.Circle)
                {
                    skcanvas2.DrawCircle((float)(info.Width / 2), (float)(info.Height / 2), (float)(info.Width / 2) - this.OutlineWidth / 2f, skpaint);
                }
                else
                {
                    float num = (this.Design == Design.Native && Device.RuntimePlatform == "UWP") ? 0f : this.OutlineWidth;
                    skcanvas2.DrawRoundRect(this.OutlineWidth, this.OutlineWidth, (float)info.Width - this.OutlineWidth * 2f, (float)info.Height - this.OutlineWidth * 2f, num, num, skpaint);
                }
            }
            using (SKPath skpath = new SKPath())
            {
                if (this.Design == Design.Unified)
                {
                    skpath.MoveTo(0.275f * (float)info.Width, 0.5f * (float)info.Height);
                    skpath.LineTo(0.425f * (float)info.Width, 0.65f * (float)info.Height);
                    skpath.LineTo(0.725f * (float)info.Width, 0.375f * (float)info.Height);
                }
                else
                {
                    string runtimePlatform = Device.RuntimePlatform;
                    if (!(runtimePlatform == "iOS"))
                    {
                        if (!(runtimePlatform == "Android"))
                        {
                            if (runtimePlatform == "UWP")
                            {
                                skpath.MoveTo(0.15f * (float)info.Width, 0.5f * (float)info.Height);
                                skpath.LineTo(0.375f * (float)info.Width, 0.75f * (float)info.Height);
                                skpath.LineTo(0.85f * (float)info.Width, 0.25f * (float)info.Height);
                            }
                        }
                        else
                        {
                            skpath.MoveTo(0.2f * (float)info.Width, 0.5f * (float)info.Height);
                            skpath.LineTo(0.425f * (float)info.Width, 0.7f * (float)info.Height);
                            skpath.LineTo(0.8f * (float)info.Width, 0.275f * (float)info.Height);
                        }
                    }
                    else
                    {
                        skpath.MoveTo(0.2f * (float)info.Width, 0.5f * (float)info.Height);
                        skpath.LineTo(0.375f * (float)info.Width, 0.675f * (float)info.Height);
                        skpath.LineTo(0.75f * (float)info.Width, 0.3f * (float)info.Height);
                    }
                }
                using (SKPaint skpaint2 = new SKPaint
                {
                    Style = SKPaintStyle.Stroke,
                    Color = this.CheckColor.ToSKColor(),
                    StrokeWidth = this.OutlineWidth,
                    IsAntialias = true
                })
                {
                    skpaint2.StrokeCap = ((this.Design == Design.Unified) ? SKStrokeCap.Round : SKStrokeCap.Butt);
                    skcanvas2.DrawPath(skpath, skpaint2);
                }
            }
        }

        // Token: 0x06000493 RID: 1171 RVA: 0x0001F740 File Offset: 0x0001D940
        private void DrawOutline(SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKCanvas skcanvas;
            if (e == null)
            {
                skcanvas = null;
            }
            else
            {
                SKSurface surface = e.Surface;
                skcanvas = ((surface != null) ? surface.Canvas : null);
            }
            SKCanvas skcanvas2 = skcanvas;
            using (SKPaint skpaint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = this.OutlineColor.ToSKColor(),
                StrokeWidth = this.OutlineWidth,
                StrokeJoin = SKStrokeJoin.Round,
                IsAntialias = true
            })
            {
                if (((this.Design == Design.Unified) ? this.Shape : Checkbox.DEFAULT_SHAPE) == Shape.Circle)
                {
                    skcanvas2.DrawCircle((float)(info.Width / 2), (float)(info.Height / 2), (float)(info.Width / 2) - this.OutlineWidth / 2f, skpaint);
                }
                else
                {
                    float num = (this.Design == Design.Native && Device.RuntimePlatform == "UWP") ? 0f : this.OutlineWidth;
                    skcanvas2.DrawRoundRect(this.OutlineWidth, this.OutlineWidth, (float)info.Width - this.OutlineWidth * 2f, (float)info.Height - this.OutlineWidth * 2f, num, num, skpaint);
                }
            }
        }

        // Token: 0x14000003 RID: 3
        // (add) Token: 0x06000494 RID: 1172 RVA: 0x0001F878 File Offset: 0x0001DA78
        // (remove) Token: 0x06000495 RID: 1173 RVA: 0x0001F8B0 File Offset: 0x0001DAB0
        public event EventHandler<TappedEventArgs> IsCheckedChanged;

        // Token: 0x17000153 RID: 339
        // (get) Token: 0x06000496 RID: 1174 RVA: 0x0001F8E5 File Offset: 0x0001DAE5
        // (set) Token: 0x06000497 RID: 1175 RVA: 0x0001F8F8 File Offset: 0x0001DAF8
        public Color OutlineColor
        {
            get
            {
                return (Color)base.GetValue(Checkbox.OutlineColorProperty);
            }
            set
            {
                if (this.OutlineColor == value)
                {
                    return;
                }
                base.SetValue(Checkbox.OutlineColorProperty, value);
                this.OnPropertyChanged("OutlineColor");
            }
        }

        // Token: 0x17000154 RID: 340
        // (get) Token: 0x06000498 RID: 1176 RVA: 0x0001F932 File Offset: 0x0001DB32
        // (set) Token: 0x06000499 RID: 1177 RVA: 0x0001F944 File Offset: 0x0001DB44
        public Color FillColor
        {
            get
            {
                return (Color)base.GetValue(Checkbox.FillColorProperty);
            }
            set
            {
                if (this.FillColor == value)
                {
                    return;
                }
                base.SetValue(Checkbox.FillColorProperty, value);
                this.OnPropertyChanged("FillColor");
            }
        }

        // Token: 0x17000155 RID: 341
        // (get) Token: 0x0600049A RID: 1178 RVA: 0x0001F97E File Offset: 0x0001DB7E
        // (set) Token: 0x0600049B RID: 1179 RVA: 0x0001F990 File Offset: 0x0001DB90
        public Color CheckColor
        {
            get
            {
                return (Color)base.GetValue(Checkbox.CheckColorProperty);
            }
            set
            {
                if (this.CheckColor == value)
                {
                    return;
                }
                base.SetValue(Checkbox.CheckColorProperty, value);
                this.OnPropertyChanged("CheckColor");
            }
        }

        // Token: 0x17000156 RID: 342
        // (get) Token: 0x0600049C RID: 1180 RVA: 0x0001F9CA File Offset: 0x0001DBCA
        // (set) Token: 0x0600049D RID: 1181 RVA: 0x0001F9DC File Offset: 0x0001DBDC
        public float OutlineWidth
        {
            get
            {
                return (float)base.GetValue(Checkbox.OutlineWidthProperty);
            }
            set
            {
                if (this.OutlineWidth == value)
                {
                    return;
                }
                base.SetValue(Checkbox.OutlineWidthProperty, value);
                this.OnPropertyChanged("OutlineWidth");
            }
        }

        // Token: 0x17000157 RID: 343
        // (get) Token: 0x0600049E RID: 1182 RVA: 0x0001FA16 File Offset: 0x0001DC16
        // (set) Token: 0x0600049F RID: 1183 RVA: 0x0001FA28 File Offset: 0x0001DC28
        public Shape Shape
        {
            get
            {
                return (Shape)base.GetValue(Checkbox.ShapeProperty);
            }
            set
            {
                if (this.Shape == value)
                {
                    return;
                }
                base.SetValue(Checkbox.ShapeProperty, value);
                this.OnPropertyChanged("Shape");
            }
        }

        // Token: 0x17000158 RID: 344
        // (get) Token: 0x060004A0 RID: 1184 RVA: 0x0001FA5F File Offset: 0x0001DC5F
        // (set) Token: 0x060004A1 RID: 1185 RVA: 0x0001FA74 File Offset: 0x0001DC74
        public Design Design
        {
            get
            {
                return (Design)base.GetValue(Checkbox.DesignProperty);
            }
            set
            {
                if (this.Design == value)
                {
                    return;
                }
                base.SetValue(Checkbox.DesignProperty, value);
                this.OnPropertyChanged("Design");
            }
        }

        // Token: 0x17000159 RID: 345
        // (get) Token: 0x060004A2 RID: 1186 RVA: 0x0001FAAB File Offset: 0x0001DCAB
        // (set) Token: 0x060004A3 RID: 1187 RVA: 0x0001FAC0 File Offset: 0x0001DCC0
        public new Style Style
        {
            get
            {
                return (Style)base.GetValue(Checkbox.StyleProperty);
            }
            set
            {
                if (object.Equals(this.Style, value))
                {
                    return;
                }
                base.SetValue(Checkbox.StyleProperty, value);
                this.OnPropertyChanged("Style");
            }
        }

        // Token: 0x060004A4 RID: 1188 RVA: 0x0001FAF8 File Offset: 0x0001DCF8
        private static void OnStyleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            Checkbox checkbox;
            if ((checkbox = (bindable as Checkbox)) == null)
            {
                return;
            }
            IList<Setter> setters = ((Style)newValue).Setters;
            Dictionary<string, Color> dictionary = new Dictionary<string, Color>();
            foreach (Setter setter in setters)
            {
                dictionary.Add(setter.Property.PropertyName, (Color)setter.Value);
            }
            checkbox.OutlineColor = dictionary["OutlineColor"];
            checkbox.FillColor = dictionary["FillColor"];
            checkbox.CheckColor = dictionary["CheckColor"];
        }

        // Token: 0x1700015A RID: 346
        // (get) Token: 0x060004A5 RID: 1189 RVA: 0x0001FBA8 File Offset: 0x0001DDA8
        // (set) Token: 0x060004A6 RID: 1190 RVA: 0x0001FBBC File Offset: 0x0001DDBC
        public bool IsChecked
        {
            get
            {
                return (bool)base.GetValue(Checkbox.IsCheckedProperty);
            }
            set
            {
                if (this.IsChecked == value)
                {
                    return;
                }
                base.SetValue(Checkbox.IsCheckedProperty, value);
                this.OnPropertyChanged("IsChecked");
            }
        }

        // Token: 0x060004A7 RID: 1191 RVA: 0x0001FBF4 File Offset: 0x0001DDF4
        private static async void OnIsCheckedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            Checkbox checkbox;
            if ((checkbox = (bindable as Checkbox)) != null)
            {
                EventHandler<TappedEventArgs> isCheckedChanged = checkbox.IsCheckedChanged;
                if (isCheckedChanged != null)
                {
                    isCheckedChanged(checkbox, new TappedEventArgs((bool)newValue));
                }
                await checkbox.AnimateToggle();
            }
        }

        // Token: 0x060004A8 RID: 1192 RVA: 0x0001FC35 File Offset: 0x0001DE35
        public void Dispose()
        {
            this._skiaView.PaintSurface -= this.Handle_PaintSurface;
            base.GestureRecognizers.Clear();
        }

        // Token: 0x04000328 RID: 808
        private bool _isAnimating;

        // Token: 0x04000329 RID: 809
        private SKCanvasView _skiaView;

        // Token: 0x0400032A RID: 810
        private ICommand _toggleCommand;

        // Token: 0x0400032C RID: 812
        public static BindableProperty OutlineColorProperty = BindableProperty.Create("OutlineColor", typeof(Color), typeof(Checkbox), Color.Blue, BindingMode.OneWay, null, null, null, null, null);

        // Token: 0x0400032D RID: 813
        public static BindableProperty FillColorProperty = BindableProperty.Create("FillColor", typeof(Color), typeof(Checkbox), Color.Blue, BindingMode.OneWay, null, null, null, null, null);

        // Token: 0x0400032E RID: 814
        public static BindableProperty CheckColorProperty = BindableProperty.Create("CheckColor", typeof(Color), typeof(Checkbox), Color.White, BindingMode.OneWay, null, null, null, null, null);

        // Token: 0x0400032F RID: 815
        public static BindableProperty OutlineWidthProperty = BindableProperty.Create("OutlineWidth", typeof(float), typeof(Checkbox), Checkbox.DEFAULT_OUTLINE_WIDTH, BindingMode.OneWay, null, null, null, null, null);

        // Token: 0x04000330 RID: 816
        public static BindableProperty ShapeProperty = BindableProperty.Create("Shape", typeof(Shape), typeof(Checkbox), Checkbox.DEFAULT_SHAPE, BindingMode.OneWay, null, null, null, null, null);

        // Token: 0x04000331 RID: 817
        public static BindableProperty DesignProperty = BindableProperty.Create("Design", typeof(Design), typeof(Checkbox), Checkbox.DEFAULT_DESIGN, BindingMode.OneWay, null, null, null, null, null);

        // Token: 0x04000332 RID: 818
        public new static BindableProperty StyleProperty = BindableProperty.Create("Style", typeof(Style), typeof(Checkbox), null, BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(Checkbox.OnStyleChanged), null, null, null);

        // Token: 0x04000333 RID: 819
        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create("IsChecked", typeof(bool), typeof(Checkbox), false, BindingMode.TwoWay, null, new BindableProperty.BindingPropertyChangedDelegate(Checkbox.OnIsCheckedChanged), null, null, null);
    }
}
