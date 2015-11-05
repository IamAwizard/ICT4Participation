using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    public class Volunteer : User
    {
        //fields
        Schedule schedule;
        private bool drivingLicense;
        private string biography;
        private string pathToVOG;
        private string pathToPhoto;


        //properties

        public Schedule Schedule
        { get; set; }
        public bool DrivingLicense
        { get; set; }

        public string Biogragphy
        { get; set; }

        public string PathToVOG
        { get; set; }

        public string PathToPhoto
        { get; set; }


        public Volunteer(string name, DateTime dateOfBirth, string gender, string city, string adress, string email, string password,
            bool drivingLicense, string biography, string pathToVOG, string pathToPhoto)
            : base(name, dateOfBirth, gender, city, adress, email, password)
        {
            this.DrivingLicense = drivingLicense;
            this.Biogragphy = biography;
            this.PathToVOG = pathToVOG;
            this.PathToPhoto = pathToPhoto;
        }

        public override string ToString()
        {
            return base.ToString() + " drivinglicense " + DrivingLicense.ToString() + " biography " + Biogragphy + " path to VOG" + PathToVOG + " path to photo " + PathToPhoto;
        }

        public Schedule GetSchedule()
        {

            return schedule;
        }


    }
}
