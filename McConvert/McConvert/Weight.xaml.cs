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
	public partial class Weight : ContentPage
	{
		public Weight ()
		{
			InitializeComponent ();
		}

        //Button layouts for calculations and conversions in code behind

        private void WeightConv1(object sender, EventArgs e)
        {
            double Ounces = Convert.ToDouble(Weight1.Text);

            double Pounds = Convert.ToDouble(Weight1.Text);

            Pounds = (Ounces / 16);

            var outPounds = Pounds.ToString();

            OuncePound.Text = "Pounds is = " + Pounds;
        }

        private void WeightConv2(object sender, EventArgs e)
        {
            double Stone = Convert.ToDouble(Weight2.Text);

            double Pounds = Convert.ToDouble(Weight2.Text);

            Stone = (Pounds / 14);

            var outStone = Stone.ToString();

            PoundStone.Text = "Stone is = " + Stone;
        }

        private void WeightConv3(object sender, EventArgs e)
        {
            double Stone = Convert.ToDouble(Weight3.Text);

            double Pounds = Convert.ToDouble(Weight3.Text);

            Pounds = (Stone * 14);

            var outPounds1 = Pounds.ToString();

            StonePounds.Text = "Pounds is = " + Pounds;
        }

        private void WeightConv4(object sender, EventArgs e)
        {
            double KG = Convert.ToDouble(Weight4.Text);

            double Tonnes = Convert.ToDouble(Weight4.Text);

            Tonnes = (KG / 1000);

            var outTonnes = Tonnes.ToString();

            KGTon.Text = "Tonnes is = " + Tonnes;
        }

        private void WeightConv5(object sender, EventArgs e)
        {
            double KG = Convert.ToDouble(Weight1.Text);

            double Tonnes = Convert.ToDouble(Weight1.Text);

            KG = (Tonnes * 1000);

            var outKG = KG.ToString();

            TonKG.Text = "KG is = " + KG;
        }
    }
}