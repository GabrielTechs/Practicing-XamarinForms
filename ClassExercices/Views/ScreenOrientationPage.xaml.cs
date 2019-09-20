using ClassExercices.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClassExercices.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScreenOrientationPage : ContentPage
    {
        public ScreenOrientationPage()
        {
            InitializeComponent();
            BindingContext = new ScreenOrientationPageViewModel();

        }
    }
}