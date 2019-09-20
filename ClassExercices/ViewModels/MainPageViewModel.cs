using ClassExercices.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ClassExercices.ViewModels
{
    public class MainPageViewModel
    {
        public ICommand ScreenOrientationCommand { get; set; }
        public ICommand EntryRendererCommand { get; set; }
        public MainPageViewModel()
        {
            ScreenOrientationCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new ScreenOrientationPage());
            });
            EntryRendererCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new CustomsEntryPage());
            });
        }
    }
}
