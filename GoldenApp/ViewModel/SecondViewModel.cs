using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using PropertyChanged;

namespace WpfApp2.ViewModel
{
    [ImplementPropertyChanged]
    public class SecondViewModel :ViewModelBase
    {
        public SecondViewModel()
        {
            BtnText1 = "hello";
            BtnText2 = "world";
        }

        public string AboutText { get; set; }
        public string BtnText1 { get; set; }
        public string BtnText2 { get; set; }

        public RelayCommand AboutApplicationCommand => new RelayCommand(
                 execute: () => AboutText = "Dennis Müller");
    }
}
