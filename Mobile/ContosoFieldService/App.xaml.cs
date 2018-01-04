﻿using ContosoFieldService.PageModels;
using FreshMvvm;
using Xamarin.Forms;

namespace ContosoFieldService
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

#if DEBUG
            Helpers.Settings.UserIsLoggedIn = false;
#endif
            var tabbedNavigation = new FreshTabbedFONavigationContainer("Dashboard");
            tabbedNavigation.AddTab<JobsPageModel>("Dashboard", null);
            tabbedNavigation.AddTab<JobsPageModel>("Jobs", null);
            tabbedNavigation.AddTab<JobsPageModel>("Parts", null);
            tabbedNavigation.AddTab<JobsPageModel>("Log", null);

            tabbedNavigation.BarBackgroundColor = Color.FromHex("#222E38");
            tabbedNavigation.BarTextColor = Color.White;
            tabbedNavigation.BackgroundColor = Color.FromHex("#222E38");
            MainPage = tabbedNavigation;
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