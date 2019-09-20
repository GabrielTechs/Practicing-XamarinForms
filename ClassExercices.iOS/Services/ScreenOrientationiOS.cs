using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassExercices.iOS.Services;
using ClassExercices.Services;
using Foundation;
using UIKit;
using Xamarin.Forms.Internals;

[assembly: Xamarin.Forms.Dependency(typeof(ScreenOrientationiOS))]
namespace ClassExercices.iOS.Services
{
    public class ScreenOrientationiOS : IScreenOrientation
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
                orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}