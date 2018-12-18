using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace McConvert
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Temperature : ContentPage
	{
		public Temperature ()
		{
			InitializeComponent ();
		}

        //button clicks for calculations on temperature change 
        private void Button_Clicked(object sender, EventArgs e)
        {
            double Celcius = Convert.ToDouble(Temp.Text);

            double Fahrenheit = Convert.ToDouble(Temp.Text);

            Fahrenheit = (Celcius * 9 / 5) + 32;

            FahrOut.Text = "Fahrenheit = " + Fahrenheit;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            double Celcius = Convert.ToDouble(Temp2.Text);
            double Fahrenheit = Convert.ToDouble(Temp2.Text);

            Celcius = (Fahrenheit - 32) * 5 / 9;

            CelcOut.Text = "Celcius = " + Celcius;
        }

       
    }
}