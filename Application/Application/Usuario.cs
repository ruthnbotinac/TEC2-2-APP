using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Usuario
    {
        private string _firstName;
        private string _lastName; 
        private int _code;
        private object return_firstName;
        private string return_lastName;

        public string FirstName
        {
            get { return _firstName; } 
            set { _firstName = value; }

        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string FullName
        {
            get { return $"{_firstName} {_lastName}"; }
        }

    }
}
