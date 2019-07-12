using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Runtime;
using RFID.Droid.Effect;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportEffect(typeof(EntryRemoveLineEffect),nameof(EntryRemoveLineEffect))]
namespace RFID.Droid.Effect
{
    [Preserve(AllMembers =true)]
    public class EntryRemoveLineEffect: PlatformEffect
    {
        protected override void OnAttached()
        {
            var shape = new ShapeDrawable(new RectShape());
            shape.Paint.Color = Android.Graphics.Color.Transparent;
            shape.Paint.StrokeWidth = 0;
            shape.Paint.SetStyle(Paint.Style.Stroke);
            Control.Background = shape;
        }

        protected override void OnDetached()
        {
          
        }
    }
}
