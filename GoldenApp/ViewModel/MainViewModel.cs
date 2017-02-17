using System;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using PropertyChanged;

namespace GoldenApp.ViewModel
{

 


    [ImplementPropertyChanged]
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {

            AboutApplicationCommand = ViewModelLocator.Instance.Second.AboutApplicationCommand;

            var t = new RoutedUICommand();

            ExitApplicationCommand = new RelayCommand(
                execute: () => System.Windows.Application.Current.Shutdown(),
                canExecute: () => !string.IsNullOrWhiteSpace(ViewModelLocator.Instance.Second.AboutText));



            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
        }

      

        public RelayCommand AboutApplicationCommand { get; set; }

        public RelayCommand ExitApplicationCommand { get; set; }


    }
}