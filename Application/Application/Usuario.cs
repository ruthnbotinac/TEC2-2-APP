using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Usuario
    {
        private string_firstName;
        private string_lastName; 
        private int_code;

       public string FirstName
        {
            get { return_firstName; }
            set { _firstName = value; }

        }
        public string LastName
        {
            get { return_lastName; }
            set { _lastName =}
        }
        public string FullName
        {
            get { return $"{_firstName} {_lastName}"; }
        }

    }
}
