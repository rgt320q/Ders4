using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ders4.Helper;
using Ders4.iOS.Helper;
using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace Ders4.iOS.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "This is IOS device name.";
        }
    }
}