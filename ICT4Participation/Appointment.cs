using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    class Appointment
    {
        // Fields 
        Client client;
        Volunteer volunteer;
        private DateTime date;
        private string location;

        // Properties
        public string DateString
        {
            get { return date.ToString(); }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Location
        {
            get { return location; }

            set { location = value; }
        }
        public Client Client
        {
            get { return client; }
            set { client = value; }
        }
        public Volunteer Volunteer
        {
            get { return volunteer; }
            set { volunteer = value; }
        }

        // Constructors
        public Appointment(Client client, Volunteer volunteer,DateTime date, string location)
        {
            this.client = client;
            this.volunteer = volunteer;
            this.date = date;
            this.location = location;
        }
    }
}
