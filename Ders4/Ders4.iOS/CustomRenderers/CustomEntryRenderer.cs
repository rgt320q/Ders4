using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ders4.CustomControls;
using Ders4.iOS.CustomRenderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(CustomEntry),typeof(CustomEntryRenderer))]
namespace Ders4.iOS.CustomRenderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            //if (Control !=null)
            //{
            //    Control.BackgroundColor = UIKit.UIColor.Brown;
            //    Control.TextColor = UIKit.UIColor.Orange;
            //}

        }
    }
}