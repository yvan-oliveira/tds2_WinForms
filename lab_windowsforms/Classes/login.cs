using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_windowsforms.Classes
{
    public class Login
    {
        private int _id;
        private string _userName;
        private string _userLogin;
        private string _userPassword;
        private string _userProfile;

        
        public int Id { get => _id; set => _id = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string UserLogin { get => _userLogin; set => _userLogin = value; }
        public string UserPassword { get => _userPassword; set => _userPassword = value; }
        public string UserProfile { get => _userProfile; set => _userProfile = value; }

        public Login(int id, string userName, string userLogin, string userPassword, string userProfile)
        {
            this._id = id;
            this._userName = userName;
            this._userLogin = userLogin;
            this._userPassword =  userPassword;
            this._userProfile = userProfile;
        }

        public bool Authenticate(string username, string password)
        {
            return username == this._userLogin && password == this._userPassword;
        }

    }
}
