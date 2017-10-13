using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MovieSaleApp
{
    public partial class App : Application
    {
        static MovieDatabase database;

        public App()
        {
            InitializeComponent();

            MainPage = new MovieSaleApp.MainPage();
        }

        public static MovieDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new MovieDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("MovieSQLite.db3"));
                }
                return database;
            }
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
