using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    public abstract class User
    {

        //here are the fields of the abstract class User
        private int id;
        private string name;
        private DateTime dateOfBirth;
        private string gender;
        private string city;
        private string adress;
        private string email;
        private string password;

        //here are the properties of the abstract class User
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        //constructor
        public User(string name, DateTime dateOfBirth, string gender, string city, string adress, string email, string password)
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.City = city;
            this.Adress = adress;
            this.Email = email;
            this.Password = password;
        }

        public override string ToString()
        {
            return "Name " + Name + " Date of birth " + DateOfBirth.ToString() + " Gender " + Gender + " City " + Adress + " Adress " + Email + " email "
                + Password + " password";
        }


    }
}
