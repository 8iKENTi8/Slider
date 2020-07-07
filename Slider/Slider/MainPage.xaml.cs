using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Slider
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Editor1.FontSize = Slider1.Value;

            BackgroundColor = Color.FromHex("b0bec5");
        }
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0)
                Editor1.FontSize = e.NewValue;

            Stepper1.Value = e.NewValue;
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0)
                Editor1.FontSize = e.NewValue;

            Slider1.Value = e.NewValue;
        }
    }
}
