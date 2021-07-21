using Project_CellPhone.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project_CellPhone
{
    public partial class App : Application
    {
        public CBindingViewModel bviewModel { get; set; }
        public App()
        {
            InitializeComponent();

            
            MainPage = new NavigationPage(new MainPage());
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
