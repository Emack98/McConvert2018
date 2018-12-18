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
	public partial class Length : ContentPage
	{
		public Length ()
		{
			InitializeComponent ();
		}

        // button specifications and calculations for each different button

        private void LengthClick1(object sender, EventArgs e)
        {
            double Meters = Convert.ToDouble(LengthConv1.Text);

            double Feet = Convert.ToDouble(LengthConv1.Text);

            Meters = (Feet / 3.281);

            var outMet = Meters.ToString();

            FtMeters.Text = "Meters = " + Meters;
        }

        // same for button2
        private void LengthClick2(object sender, EventArgs e)
        {
            double Meters = Convert.ToDouble(LengthConv2.Text);

            double Feet = Convert.ToDouble(LengthConv2.Text);

            Feet = (Meters * 3.281);

            var outFt = Feet.ToString();

            FtMeters.Text = "Feet = " + Feet;
        }

        //same for button3

        private void LengthClick3(object sender, EventArgs e)
        {
            double Inches = Convert.ToDouble(LengthConv3.Text);

            double CM = Convert.ToDouble(LengthConv3.Text);

            CM = (Inches * 2.54);

            var outCM = CM.ToString();

            InchCM.Text = "Centimeters = " + CM;
        }

        // same for button 4
        private void LengthClick4(object sender, EventArgs e)
        {
            double Inches = Convert.ToDouble(LengthConv4.Text);

            double CM = Convert.ToDouble(LengthConv4.Text);

            Inches = (CM / 2.54);

            var outEuro2 = Inches.ToString();

            CMInch.Text = "Inches = " + Inches;
        }
    }
}