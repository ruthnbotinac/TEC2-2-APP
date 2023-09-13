using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class Log_In
    {
        private string email;
        private string password;
        private string alternativeEmail;

        public string e_mail
        {
            get { return email; }
            set { email = value; }
        }
        public string key
        {
            get { return password; }
            set { password = value; }
        }
        public string otherEmail
        {
            get { return alternativeEmail; }
            set { alternativeEmail = value; }
        }
        public string newAccount(string email, string password, string alternativeEmail) { 
            string newAccount = email + "&" + password +"&" + alternativeEmail;
            return newAccount;
        }
        public Boolean CorrectLogin(string email, string password) {
            if (email == null || password == null) { return false; }
            if (email == null || password == null) { }
            return true;
        }
        //public string account() { 
       
        //}
    }
}
