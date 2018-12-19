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
	public partial class Time : ContentPage
	{
		public Time ()
		{
			InitializeComponent ();
		}

        //Button layouts for calculations and conversions in code behind
        private void TimeConv1(object sender, EventArgs e)
        {
            double Seconds = Convert.ToDouble(Time1.Text);

            double Minutes = Convert.ToDouble(Time1.Text);

            Minutes = (Seconds / 60);

            var outMin = Minutes.ToString();

            SecMin.Text = "Minutes is = " + Minutes;
        }

        private void TimeConv2(object sender, EventArgs e)
        {
            double Hours = Convert.ToDouble(Time2.Text);

            double Minutes = Convert.ToDouble(Time2.Text);

            Hours = (Minutes / 60);

            var outHour = Minutes.ToString();

            MinHour.Text = "Hours is = " + Hours;
        }

        private void TimeConv3(object sender, EventArgs e)
        {
            double Hours = Convert.ToDouble(Time3.Text);

            double Days = Convert.ToDouble(Time3.Text);

            Days = (Hours / 24);

            var outDay = Days.ToString();

            HourDay.Text = "Days is = " + Days;
        }

        private void TimeConv4(object sender, EventArgs e)
        {
            double Days = Convert.ToDouble(Time4.Text);

            double Weeks = Convert.ToDouble(Time4.Text);

            Weeks = (Days / 7);

            var outWeek = Weeks.ToString();

            DayWeek.Text = "Weeks is = " + Weeks;
        }

        private void TimeConv5(object sender, EventArgs e)
        {
            double Weeks = Convert.ToDouble(Time5.Text);

            double Months = Convert.ToDouble(Time5.Text);

            Months = (Weeks / 4);

            var outMonth = Months.ToString();

            WeekMonth.Text = "Months is = " + Months;
        }

        private void TimeCon6(object sender, EventArgs e)
        {
            double Months = Convert.ToDouble(Time6.Text);

            double Years = Convert.ToDouble(Time6.Text);

            Years = (Months / 12);

            var outYear = Years.ToString();

            MonthYear.Text = "Years is = " + Years;
        }
    }
}