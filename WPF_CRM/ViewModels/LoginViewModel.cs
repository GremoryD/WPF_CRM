using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_CRM.Models;

namespace WPF_CRM.ViewModels
{
    public class LoginViewModel : IViewModel, INotifyPropertyChanged
    {
        public String LoginText { set; get; }
        public String PasswordText { set; get; }

        public ICommand LoginInCommand { set; get; }

        public LoginViewModel()
        {
            LoginInCommand = new SimpleCommand(LoginIn);


        }

        private void LoginIn()
        {
            DataBaseHandler.Connect();
            if(LoginText=="student" && PasswordText == "student")
            { 
                NavigationService.Instance.Navigate(new StudentPanelViewModel());
            }
             
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
