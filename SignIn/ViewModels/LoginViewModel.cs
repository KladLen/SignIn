using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SignIn.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        //Fields
        private string _username;
        private string _password;
        private string _errorMsg;

        //Properties
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string ErrorMsg
        {
            get
            {
                return _errorMsg;
            }
            set
            {
                _errorMsg = value;
                OnPropertyChanged(nameof(ErrorMsg));
            }
        }
        //Commands
        public ICommand LoginCommand { get; }

        //Constructor
        public LoginViewModel()
        {
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
        }
        private void ExecuteLoginCommand(object obj)
        {
            throw new NotImplementedException();
        }
        private bool CanExecuteLoginCommand(object obj)
        {
            if (String.IsNullOrWhiteSpace(Username) || String.IsNullOrWhiteSpace(Password) || Username.Length < 3)
                return false;
            else
                return true;
        }
    }
}
