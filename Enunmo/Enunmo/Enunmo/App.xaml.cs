﻿namespace Enunmo
{
    using Xamarin.Forms;
    using Views;
        public partial class App : Application
    {
        public App()
        #region Constructors
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }

        #endregion
        #region Methods
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
        #endregion
    }
}
