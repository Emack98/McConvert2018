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
	public partial class Storage : ContentPage
	{
		public Storage ()
		{
			InitializeComponent ();
		}

        private void StorageClick1(object sender, EventArgs e)
        {
            double Kilo = Convert.ToDouble(StoreConv1.Text);

            double Mega = Convert.ToDouble(StoreConv1.Text);

            Mega = (Kilo / 1000);

            var outMega = Mega.ToString();

            KiloMega.Text = "Megabytes = " + Mega;
        }

        // same for button2
        private void StorageClick2(object sender, EventArgs e)
        {
            double Mega = Convert.ToDouble(StoreConv2.Text);

            double Giga = Convert.ToDouble(StoreConv2.Text);

            Giga = (Mega / 1000);

            var outGiga = Giga.ToString();

            MegaGiga.Text = "Gigabytes = " + Giga;
        }

        //same for button3

        private void StorageClick3(object sender, EventArgs e)
        {
            double Giga = Convert.ToDouble(StoreConv3.Text);

            double Tera = Convert.ToDouble(StoreConv3.Text);

            Tera = (Giga / 1000);

            var outTera = Tera.ToString();

            GigaTera.Text = "Terabytes = " + Tera;
        }

        // same for button 4
        private void StorageClick4(object sender, EventArgs e)
        {
            double Tera = Convert.ToDouble(StoreConv4.Text);

            double Peta = Convert.ToDouble(StoreConv4.Text);

            Peta = (Tera / 1000);

            var outPeta = Peta.ToString();

            TeraPeta.Text = "Petabytes = " + Peta;
        }

        // same for button 5
        private void StorageClick5(object sender, EventArgs e)
        {
            double Peta = Convert.ToDouble(StoreConv5.Text);

            double Zetta = Convert.ToDouble(StoreConv5.Text);

            Zetta = (Peta / 1e+6);

            var outZetta = Zetta.ToString();

            PetaZetta.Text = "Zettabytes = " + Zetta;
        }
    }
}