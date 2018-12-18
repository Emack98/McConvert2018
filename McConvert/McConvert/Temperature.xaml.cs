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

        private void Button_Clicked(object sender, EventArgs e)
        {
            double C = Convert.ToDouble(Celcius.Text);
            double F = Convert.ToDouble(Fahrenheit.Text);

            F = (C * 9/5) + 32;

            FahrOut.Text = "The temperature is: " + F;
        }
    }
}