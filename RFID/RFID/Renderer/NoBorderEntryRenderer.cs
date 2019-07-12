using Android.Graphics.Drawables;
using RFID.Layout;
using Android.Content;
using RFID.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
 
[assembly: ExportRenderer(typeof(NoBorderEntry), typeof(NoBorderEntryRenderer))]
namespace  RFID.Renderer
{
    public class NoBorderEntryRenderer : EntryRenderer
    {
        public NoBorderEntryRenderer(Context context):base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
            }
        }
         
    }
}