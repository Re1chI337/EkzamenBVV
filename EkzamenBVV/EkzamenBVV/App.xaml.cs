using EkzamenBVV.Models;
using EkzamenBVV.Services;
using EkzamenBVV.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EkzamenBVV
{
    public partial class App : Application
    {
        static TimeDataBase dataBase;

        // Create the database connection as a singleton.
        internal static TimeDataBase DataBase
        {
            get
            {
                if (dataBase == null)
                {
                    dataBase = new TimeDataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Times.db3"));
                }
                return dataBase;
            }
        }
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
