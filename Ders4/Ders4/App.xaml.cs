using Ders4.Helper;
using Ders4.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ders4
{
    public partial class App : Application
    {
        public static string DbName { get; set; } = "Ders4.db3";
        public App()
        {
            InitializeComponent();
            //string deviceName = DependencyService.Get<IDeviceHelper>()
            //    .GetDeviceName();

            //MainPage = new Page1(deviceName);

            MainPage = new NavigationPage(new ListPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
