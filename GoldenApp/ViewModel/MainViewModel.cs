using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using PropertyChanged;

namespace GoldenApp.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    [ImplementPropertyChanged]
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ExitApplicationCommand = new RelayCommand(() => App.Current.Shutdown(), 
                canExecute: () => !string.IsNullOrWhiteSpace(AboutText));

            AboutApplicationCommand = new RelayCommand(() => AboutText = "Dennis Müller");


            BtnText1 = "hello";
            BtnText2 = "world";
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        public RelayCommand AboutApplicationCommand { get; private set; }

        public string AboutText { get; set; }

        public string BtnText1 { get; set; }
        public string BtnText2 { get; set; }
        public RelayCommand ExitApplicationCommand { get; private set; }
    }
}