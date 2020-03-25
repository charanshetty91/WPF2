using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPFBasics.ViewModel
{
    internal class MainWindowViewModel
    {
        private ICommand btnIcommand;
        public ICommand ButtonCommand
        {
            get { return btnIcommand; }
            set { btnIcommand = value; }
        }

        public MainWindowViewModel()
        {
            ButtonCommand = new RelayCommand(new Action<object> (ShowMessage));
        }

        public void ShowMessage(object obj)
        {
            MessageBox.Show(obj.ToString());
        }
    }
}
