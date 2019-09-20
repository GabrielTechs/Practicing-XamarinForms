using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms.Internals;

namespace ClassExercices.Services
{
    public interface IScreenOrientation
    {
        DeviceOrientation GetOrientation();
    }
}
