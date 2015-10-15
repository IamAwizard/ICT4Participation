using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    class Appointment
    {

        //fields 
        Client client;
        Volunteer volunteer;
        private DateTime date;
        private string location;

        public DateTime Date
        { get; set; }
        public string Location
        { get; set; }

        public Appointment(Client client, Volunteer volunteer,DateTime date, string location)
        {
            this.client = client;
            this.volunteer = volunteer;
            this.date = date;
            this.location = location;
        }
    }
}
