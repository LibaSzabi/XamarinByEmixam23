﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MapPolylineProject
{
    public class App : Application
    {
        public static readonly string GOOGLE_MAP_API_KEY = "Your Key";

        public App()
        {
            // The root page of your application
            MainPage = new MapPolylinePage();
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
