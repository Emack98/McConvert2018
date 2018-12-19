using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace McConvert
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //Setting Page1 as the first page to show when the app opens

            MainPage = new NavigationPage(new Page1());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
