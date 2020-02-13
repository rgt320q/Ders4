﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Ders4.Droid.Helper;
using Ders4.Helper;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace Ders4.Droid.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "This is android device name.";
        }
    }
}