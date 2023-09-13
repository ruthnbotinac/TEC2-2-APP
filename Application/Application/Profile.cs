using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class Profile
    {
        private string firstname;
        private string lastname;
        private string email;
        private int iD;
        private int age;
        private string userName;
        private string category;
        private int phoneNumber;
        private string description;
        private int dNi;
        //private (location) location ; //Nota: Cuando pueda reemplazare el dato


        public string firstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string lastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string e_mail
        {
            get { return email; }
            set { email = value; }
        }
        public int customerId
        {
            get { return iD; }
            set { iD = value; }
        }
        public int customerAge
        {
            get { return age; }
            set { age = value; }
        }
        public string CustuserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string customerCategory
        {
            get { return category; }
            set { category = value; }
        }
        public string customDesc
        {
            get { return description; }
            set { description = value; }
        }
        public int customPhone
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public int identificationNumber
        {
            get { return dNi; }
            set { dNi = value; }
        }
        public string profile
        {
            
            get { return $"             Customer Profile                " + 
                    $"\nFull Name:{firstname} {lastname}\n" +
                    $"Email:{email}\n" +
                    $"Age:{age}\n" +
                    $"User Name: {userName}\n" +
                    $"Category: {category}\n" +
                    $"Contact me: {phoneNumber}\n" +
                    $"Description: {description}"; }
        }
        //public string newprofile(Log_In logIn) {
        //    email = logIn.e_mail;
            
        //return profile;
        //}
    }
}

