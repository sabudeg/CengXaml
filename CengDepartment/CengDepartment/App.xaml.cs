using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CengDepartment
{
    public partial class App : Application
    {
        //public App()
        //{
        //    InitializeComponent();

        //    MainPage = new MainPage();
        //}

        public static bool IsUserLoggedIn { get; set; }

        public App()
        {
            if (!IsUserLoggedIn)
            {
                //MainPage = new Login();
                // MainPage = new TabbedPage(new Login());
                MainPage = new NavigationPage(new Login());

            }
            else
            {
                MainPage = new NavigationPage(new CengDepartment.MainPage());
                //MainPage = new MainPage();
            }
        }

        //public App()
        //{
        //    InitializeComponent();

        //    MainPage = new MainPage();
        //}

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
