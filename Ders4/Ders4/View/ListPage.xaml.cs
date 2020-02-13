using Ders4.Helper;
using Ders4.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders4.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        List<Student> students = new List<Student>();
        SQLiteManager manager = new SQLiteManager();

        public ListPage()
        {
            InitializeComponent();
           
            students = manager.GetAll();

            lstStudents.BindingContext = students;

        }

        private void onMenuInsert(object sender, EventArgs e )
        {
            Navigation.PushAsync(new InsertPage());
        }

        private void onMenuRefresh(object sender, EventArgs e)
        {
            students = manager.GetAll();

            lstStudents.BindingContext = students;
        }

        private void onMenuDelete(object sender, EventArgs e)
        {
            var selectedMenuItem = (MenuItem)sender;
        }
    }
}