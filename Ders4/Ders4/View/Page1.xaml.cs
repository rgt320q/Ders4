using Ders4.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders4.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(string deviceName)
        {
            InitializeComponent();
            

            Label lbl1 = new Label
            {
                Text = deviceName
            };

            CustomEntry myEntry = new CustomEntry();
            DatePicker datePicker = new DatePicker();

            datePicker.TextColor = Color.Black;


            Content = new StackLayout
            {
                Children =
                {
                    lbl1,
                    myEntry,
                    datePicker
                }
            };
        }
    }
}