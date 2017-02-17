using System.Collections.Generic;
using System.Windows.Input;
using GoldenApp.ViewModel;

namespace GoldenApp
{
    public static class  KeyGestures
    {
        public static Dictionary<ICommand, KeyGesture> Shortcuts = new Dictionary<ICommand, KeyGesture>
        {
            {ViewModelLocator.Instance.Main.ExitApplicationCommand, ExitGesture},
            {ViewModelLocator.Instance.Second.AboutApplicationCommand, AboutGesture},
        };


        public static string ToStringKey(this KeyGesture keyGesture)
        {
            return keyGesture.Modifiers.ToString() + "-" + keyGesture.Key.ToString();
        }

        public static KeyGesture ExitGesture => new KeyGesture(Key.F1);
        public static KeyGesture AboutGesture => new KeyGesture(Key.F2);
    }
}
