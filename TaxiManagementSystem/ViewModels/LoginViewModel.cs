using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TaxiManagementSystem.Interface;

namespace TaxiManagementSystem.ViewModels
{
   public class LoginViewModel : Caliburn.Micro.PropertyChangedBase, ILogin
    {
        private string userName;
        private string password;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => UserNameCanToLogin);
            }
        }

        public bool UserNameCanToLogin
        {
            get
            {
                    return !string.IsNullOrEmpty(userName);  
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
                password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => PasswordCanToLogin);
            }
        }

        public bool PasswordCanToLogin {
            get
            {
                return !string.IsNullOrEmpty(password);
            }
        }

        public void toLogin()
        {
            if (UserNameCanToLogin && PasswordCanToLogin)
            {
                MessageBox.Show("登录成功");
            }
        }
    }
}
