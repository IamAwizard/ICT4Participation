using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    public class Volunteer : User
    {
        // Fields


        // Properties

        public Schedule Schedule { get; set; }
        public bool DrivingLicense { get; set; }
        public string Biogragphy { get; set; }
        public string PathToVOG { get; set; }
        public string PathToPhoto { get; set; }
        public decimal Rating { get; set; }

        // Constructor
        public Volunteer(string name, DateTime dateOfBirth, string gender, string city, string adress, string email, string password,
            bool drivingLicense, string biography, string pathToVOG, string pathToPhoto)
            : base(name, dateOfBirth, gender, city, adress, email, password)
        {
            this.Schedule = new Schedule();
            this.DrivingLicense = drivingLicense;
            this.Biogragphy = biography;
            this.PathToVOG = pathToVOG;
            this.PathToPhoto = pathToPhoto;

        }

        public override string ToString()
        {
            return Name;        }

        public Schedule GetSchedule()
        {

            return Schedule;
        }


    }
}
