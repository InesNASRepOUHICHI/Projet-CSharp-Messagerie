using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WpfProject.View;
using WpfProject.Commands.WpfProject.Commands;
using System;

namespace WpfProject.ViewModel
{
    class Autentification : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ICommand submitButtonCommand;
        private ICommand registerButtonCommand;

        private string username;
        private string password;


        public Autentification()
        {
            registerButtonCommand = new RelayCommand(register);
           Console.WriteLine("========================  auth");
        }

        public void NotifyPropertyChanged([CallerMemberName] string str = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(str));
            }
        }

        public bool NotifyPropertyChanged<T>(ref T variable, T valeur, string nomPropriete = null)
        {
            if (object.Equals(variable, valeur)) return false;

            variable = valeur;
            NotifyPropertyChanged(nomPropriete);
            return true;
        }

        public void register()
        {
           Register register = new Register();
            register.register(Username, Password);

            Console.WriteLine("=========== "+ Username + " password " + Password);

        }

        public void login()
        {

        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (username != value)
                {
                    username = value;
                }

            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (password != value)
                {
                    password = value;
                }

            }
        }
        public ICommand RegisterButtonComand
        {
            get
            {
                return registerButtonCommand;
            }
            set
            {
                registerButtonCommand = value;
            }
        }





    }
}
