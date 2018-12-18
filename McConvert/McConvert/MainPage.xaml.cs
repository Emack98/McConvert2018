using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace McConvert
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

            async void Convert_Temperature(object sender, EventArgs args)
            {
                await Navigation.PushAsync(new Temperature());
            }

            async void CurrencyConvert(object sender, EventArgs args)
            {
                await Navigation.PushAsync(new Currency());
            }

            async void SpeedConvert(object sender, EventArgs args)
            {
                await Navigation.PushAsync(new Speed());
            }

            async void StorageConvert(object sender, EventArgs args)
            {
                await Navigation.PushAsync(new Storage());
            }

            async void VolumeConvert(object sender, EventArgs args)
            {
                await Navigation.PushAsync(new Volume());
            }

            async void WeightConvert(object sender, EventArgs args)
            {
                await Navigation.PushAsync(new Temperature());
            }

            async void TimeConvert(object sender, EventArgs args)
            {
                await Navigation.PushAsync(new Temperature());
            }

            async void LengthConvert(object sender, EventArgs args)
            {
                await Navigation.PushAsync(new Length());
            }
        

    }
    }

