using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Ders4.CustomControls;
using Ders4.Droid.CutomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof (CustomEntry), typeof(CustomEntryRenderer))]
namespace Ders4.Droid.CutomRenderers
{
    
    public class CustomEntryRenderer:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            //Control.SetBackgroundColor(Android.Graphics.Color.Red);
            //Control.SetTextColor(Android.Graphics.Color.Black);

        }
    }
}