using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using GoldenApp.ViewModel;

namespace GoldenApp
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {

        public static void RunIt()
        {
            var app = new App();
            app.InitializeComponent();
            ((Application) app).Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //var mainwindow = new MainWindow();
            //mainwindow.Show();
            App.Current.DispatcherUnhandledException += AppOnDispatcherUnhandledException;
        }


        private void AppOnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
