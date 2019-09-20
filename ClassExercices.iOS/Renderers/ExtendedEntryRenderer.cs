using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassExercices.Controls;
using ClassExercices.iOS.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]

namespace ClassExercices.iOS.Renderers
{
    public class ExtendedEntryRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BackgroundColor = UIColor.FromRGB(3, 63, 99);
                Control.BorderStyle = UITextBorderStyle.Line;
                Control.TextColor = UIColor.White;
            }
        }
    }
}