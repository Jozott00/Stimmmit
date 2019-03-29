using System;
using System.Diagnostics;
using System.Linq;
using CoreGraphics;
using Stimmmit.CustomRenderer;
using Stimmmit.iOS;
using StimmmitAlphaUI.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CusEntryRenderer), typeof(CusEntryRendererIos))]
namespace StimmmitAlphaUI.iOS
{
    public class CusEntryRendererIos : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.Layer.CornerRadius = 30;
                Control.Layer.BorderWidth = 2f;
                Control.Layer.BorderColor = Color.White.ToCGColor();
                Control.Layer.BackgroundColor = Color.Transparent.ToCGColor();

                Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 8, 0));
                Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;
            }
        }
    }
}
