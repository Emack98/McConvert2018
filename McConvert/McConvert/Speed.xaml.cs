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
	public partial class Speed : ContentPage
	{
		public Speed ()
		{
			InitializeComponent ();
		}

        //button clicks for calculations on temperature change 
        private void SpeedConv1(object sender, EventArgs e)
        {
            double MPH = Convert.ToDouble(Speed1.Text);
            double KMH = Convert.ToDouble(Speed1.Text);

            MPH = (KMH / 1.609);

            MPHout.Text = "Miles = " + MPH;
        }

        private void SpeedConv2(object sender, EventArgs e)
        {
            double MPH = Convert.ToDouble(Speed2.Text);
            double KMH = Convert.ToDouble(Speed2.Text);

            KMH = (MPH * 1.609);

            KMHout.Text = "Kilometers = " + KMH;
        }
    }
}