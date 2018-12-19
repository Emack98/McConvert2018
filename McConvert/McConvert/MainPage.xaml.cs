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

            //Navigation settings in the code behind so the app knows what page to locate to when the button is clicked

            async void Convert_Temperature(object sender, EventArgs args)
            {
                await Navigation.PushAsync(new Temperature());
            }
        //Currency page
            async void CurrencyConvert(object sender, EventArgs args)
            {
                await Navigation.PushAsync(new Currency());
            }
        //Speed/distance page
            async void SpeedConvert(object sender, EventArgs args)
            {
                await Navigation.PushAsync(new Speed());
            }
        //Storage page
            async void StorageConvert(object sender, EventArgs args)
            {
                await Navigation.PushAsync(new Storage());
            }
        //Volume page
            async void VolumeConvert(object sender, EventArgs args)
            {
                await Navigation.PushAsync(new Volume());
            }
        //Weight page
            async void WeightConvert(object sender, EventArgs args)
            {
                await Navigation.PushAsync(new Weight());
            }
        //Time page
            async void TimeConvert(object sender, EventArgs args)
            {
                await Navigation.PushAsync(new Time());
            }
        //Length page
            async void LengthConvert(object sender, EventArgs args)
            {
                await Navigation.PushAsync(new Length());
            }
        

    }
    }

