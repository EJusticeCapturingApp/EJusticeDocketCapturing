using E_Justice_Dockect_Capturing.Services;
using E_Justice_Dockect_Capturing.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace E_Justice_Dockect_Capturing
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
