using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GoldenApp;
using GoldenApp.ViewModel;
using System.Windows.Threading;

namespace GoldenAppMain
{
    class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [STAThread]
        static void Main(string[] args)
        {
            AllocConsole();

            //Create an instance of your window.
            MainWindow _window = new MainWindow();

            //Create an instance of a new Application
            System.Windows.Application _wpfApplication = new System.Windows.Application();
            
            App.RunIt();



        }


      
    }
}
