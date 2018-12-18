using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace McConvert
{
	
	public partial class Currency : ContentPage
	{
		public Currency ()
		{
			InitializeComponent ();
		}

        // button specifications and calculations for each different button

        private void ButtonClicked(object sender, EventArgs e)
        {
            double Euro = Convert.ToDouble(Currency1.Text);

            double Pound = Convert.ToDouble(Currency1.Text);

            Pound = (Euro / 1.11);

            var outPound = Pound.ToString();

            EuroPound.Text = "Pounds = " + Pound;
        }

        // same for button2
        private void ButtonClicked2(object sender, EventArgs e)
        {
            double Pound = Convert.ToDouble(Currency2.Text);

            double Euro = Convert.ToDouble(Currency2.Text);

            Euro = (Pound * 1.11);

            var outEuro = Euro.ToString();

            PoundEuro.Text = "Euro = " + Euro;
        }

        //same for button3

        private void ButtonClicked3(object sender, EventArgs e)
        {
            double Euro = Convert.ToDouble(Currency3.Text);

            double Dollar = Convert.ToDouble(Currency3.Text);

            Dollar = (Euro * 0.88);

            var outDollar = Dollar.ToString();

            EuroDollar.Text = "Dollars = " + Dollar;
        }

        // same for button 4
        private void ButtonClicked4(object sender, EventArgs e)
        {
            double Euro = Convert.ToDouble(Currency4.Text);

            double Dollar = Convert.ToDouble(Currency4.Text);

            Dollar = (Euro / 0.88);

            var outEuro2 = Euro.ToString();

            DollarEuro.Text = "Euro = " + Euro;
        }
    }
}