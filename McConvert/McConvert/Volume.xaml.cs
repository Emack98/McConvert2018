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
	public partial class Volume : ContentPage
	{
		public Volume ()
		{
			InitializeComponent();
		}

        private void VolumeConv1(object sender, EventArgs e)
        {
            double Mil = Convert.ToDouble(Volume1.Text);

            double Litre = Convert.ToDouble(Volume1.Text);

            Litre = (Mil / 1000);

            var outLitre = Litre.ToString();

            Millit.Text = "Litres = " + Litre;
        }

        private void VolumeConv2(object sender, EventArgs e)
        {
            double Mil = Convert.ToDouble(Volume2.Text);

            double Litre = Convert.ToDouble(Volume2.Text);

            Mil = (Litre * 1000);

            var outMil = Mil.ToString();

            LitMil.Text = "Millilitres = " + Mil;
        }

        private void VolumeConv3(object sender, EventArgs e)
        {
            double Gallon = Convert.ToDouble(Volume3.Text);

            double Litre = Convert.ToDouble(Volume3.Text);

            Gallon = (Litre / 3.785);

            var outGal = Gallon.ToString();

            LitGal.Text = "Gallons = " + Gallon;
        }

        private void VolumeConv4(object sender, EventArgs e)
        {
            double Gallon = Convert.ToDouble(Volume4.Text);

            double CubMetres = Convert.ToDouble(Volume4.Text);

            CubMetres = (Gallon / 264.172);

            var outCubMet = CubMetres.ToString();

            GalCub.Text = "Cubic Metres is = " + CubMetres;
        }

        private void VolumeConv5(object sender, EventArgs e)
        {
            double CubYards = Convert.ToDouble(Volume5.Text);

            double CubMetres = Convert.ToDouble(Volume5.Text);

            CubYards = (CubMetres * 1.308);

            var outCubYard = CubYards.ToString();

            CubCub.Text = "Cubic Yards is = " + CubYards;
        }
    }
}