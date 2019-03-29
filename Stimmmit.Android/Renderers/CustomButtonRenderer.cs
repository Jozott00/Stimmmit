using Android.Content;
using Android.Support.V7.View;
using Android.Support.V7.Widget;
using App.Droid;
using Stimmmit.CustomRenderer;
using Stimmmit.Droid;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace App.Droid
{
    public class CustomButtonRenderer : Xamarin.Forms.Platform.Android.AppCompat.ButtonRenderer
    {
        public CustomButtonRenderer(Context context) : base(context)
        {
        }

        protected override AppCompatButton CreateNativeControl()
        {
            var context = new ContextThemeWrapper(Context, Resource.Style.Widget_AppCompat_Button_Borderless);
            var button = new AppCompatButton(context, null, Resource.Style.Widget_AppCompat_Button_Borderless);
            return button;
        }
    }
}