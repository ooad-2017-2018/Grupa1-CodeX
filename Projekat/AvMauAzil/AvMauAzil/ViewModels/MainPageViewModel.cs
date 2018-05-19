using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace AvMauAzil.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        ICommand zaPrijavu;
        string validationText, username, password;

        public string Username
        {
            get => username;
            set { username = value; ValidationText = ""; OnPropertyChanged("Username"); }
        }
        public string Password
        {
            get => password;
            set { password = value; ValidationText = "";  OnPropertyChanged("Password"); }
        }
        public string ValidationText
        {
            get => validationText;
            set { validationText = value; OnPropertyChanged("ValidationText"); }
        }
        public ICommand ZaPrijavu
        {
            get => zaPrijavu;
            set => zaPrijavu = value;
        }

        public MainPageViewModel()
        {
            ValidationText = "";
            Username = "";
            Password = "";
            ZaPrijavu = new RelayCommand<object>(funZaPrijavu, boolFunZaPrijavu);
        }

        void funZaPrijavu(object parametar)
        {
            if ((Username.Equals("Ajna") && Password.Equals("ajna")) || (Username.Equals("Avda") && Password.Equals("avda")) || (Username.Equals("Edo") && Password.Equals("edo")))
            {
                ValidationText = " ";
            }
            else
            {
                ValidationText = "Greska u prijavi administratora.";
            }
        }
        bool boolFunZaPrijavu(object parametar)
        {
            return true;
        }
    }
}
