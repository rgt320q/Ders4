using Ders4.Helper;
using Ders4.Models;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders4.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsertPage : ContentPage
    {
        public InsertPage()
        {
            InitializeComponent();
        }

        private void onSaveClicked(object sender, EventArgs e)
        {
            SQLiteManager manager = new SQLiteManager();
            Student _student = new Student();
            _student.Name = txtName.Text;
            _student.Surname = txtSurname.Text;
            _student.RegisterDate = DateTime.Now;

            int isInserted = manager.Insert(_student);
            if (isInserted>0)
            {
                //DisplayAlert("Success", _student.Name + " added!", "OK");
                Navigation.PushAsync(new ListPage());
            }
            else
            {
                DisplayAlert("Fail!", _student.Name + " is not added!", "OK");
            }

        }
    }
}