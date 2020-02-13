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

[assembly: ExportRenderer(typeof(CustomDatePicker),
    typeof(CustomDatePickerRenderer))]
namespace Ders4.Droid.CutomRenderers
{
    public class CustomDatePickerRenderer:DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.DatePicker> e)
        {
            base.OnElementChanged(e);

            CustomDatePicker datePicker = (CustomDatePicker)Element;

            if (datePicker!=null)
            {
                Control.SetTextColor(datePicker.TextColor.ToAndroid());
            }

        }
    }
}