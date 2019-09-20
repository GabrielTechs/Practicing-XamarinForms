using ClassExercices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ClassExercices.ViewModels
{
    public class ScreenOrientationPageViewModel : INotifyPropertyChanged
    {
        public string txtScreenOrientation { get; set; }
        public ScreenOrientationPageViewModel()
        {
            IScreenOrientation service = DependencyService.Get<IScreenOrientation>();
            DeviceOrientation orientation = service.GetOrientation();
            txtScreenOrientation = orientation.ToString();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
