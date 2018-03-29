using Xamarin.Forms;

namespace DesignTimeData
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            //DesignTimeHelper.SwitchOffDesignMode();

            MainPage = new Views.DesignTimeDataPage();
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
