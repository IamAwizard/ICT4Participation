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
        private string name;
        private DateTime dateOfBirth;
        private string gender;
        private string city;
        private string adress;
        private string email;
        private string password;

        //here are the properties of the abstract class User
        public string Name
        { get; set; }

        public DateTime DateOfBirth
        { get; set; }

        public string Gender
        { get; set; }

        public string City
        { get; set; }

        public string Adress
        { get; set; }

        public string Email
        { get; set; }

        public string Password
        { get; set; }

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

        public override string  ToString()
        {
            return "Name " + Name + " Date of birth " + DateOfBirth + " Gender " + Gender + " City " + Adress + " Adress " + Email + " email "
                + Password + " password"; 
        }


    }
}
