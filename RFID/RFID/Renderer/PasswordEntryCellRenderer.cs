  using Android.Content;
  using Android.Text.Method;
  using Android.Views;
  using Android.Widget;
  using Xamarin.Forms;
using RFID.Layout;
using RFID.Droid.Renderer;
  using Xamarin.Forms.Platform.Android;
  using View = Android.Views.View;

[assembly: ExportRenderer(typeof(PasswordEntryCell), typeof(PasswordEntryCellRenderer))]
namespace RFID.Droid.Renderer
{
    
        public class PasswordEntryCellRenderer : EntryCellRenderer
     {
         protected override View GetCellCore(Cell item, View convertView, ViewGroup parent, Context context)
         {
             var cell = base.GetCellCore(item, convertView, parent, context);
             var textField = (cell as EntryCellView)?.EditText as TextView;
 
             if (textField != null && textField.TransformationMethod != PasswordTransformationMethod.Instance)
             {
                textField.TransformationMethod = PasswordTransformationMethod.Instance;
             }
             return cell;
         }
     }
    }
