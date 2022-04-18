using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VladickLoh.View;

namespace VladickLoh
{
    public partial class App : Application
    {
        public static EntryManager EntryManager { get; private set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EntryModelList());
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
