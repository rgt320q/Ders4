using Xamarin.Forms;

namespace Ders4.CustomControls
{
    public class CustomDatePicker : DatePicker
    {
        public static readonly BindableProperty TextColorProperty = BindableProperty
            .Create<CustomDatePicker, Color>(p => p.TextColor, Color.Black);

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }
    }
}
