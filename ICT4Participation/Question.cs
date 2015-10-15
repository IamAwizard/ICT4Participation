using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
   public class Question
    {
        //fields
        Client client;
        Volunteer volunteer;
        private string name;
        private DateTime date;
        private string content;
        private string discrepancy;
        private string location;
        private int distance;
        private string transport;
        private bool solved;
        //properties

        public Volunteer Volunteer
        { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public string Discrepancy
        {
            get { return discrepancy; }
            set { discrepancy = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public string Transport
        {
            get { return transport; }
            set { transport = value; }
        }
        public bool Solved
        {
            get { return solved; }
            set { solved = value; }
        }
        //constructor
        public Question(Client client, string name, string location,string transport,int distance,string Discrepancy,string content,DateTime date,bool solved)
        {
            this.client = client;
            this.Name = this.name;
            this.Location = this.location;
            this.Transport = this.transport;
            this.Content = this.content;
            this.Discrepancy = this.discrepancy;
            this.Date = this.date;
            this.Solved = this.solved;
            this.Distance = this.distance;
        }
        
        public override string ToString()
        {
            return "naam" + Name + "locatie" + location + "vervoersmiddel" + Transport+"afstand" +Distance + "inhoud" + Content + "Bijzonderheden" + Discrepancy + "Datum" + Date + "Geaccepteerd?" + Solved;
        }
    }
}
