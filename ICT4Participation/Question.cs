using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
   public class Question
    {
        // Fields
        Volunteer volunteer;
        private int auteur;
        private DateTime date;
        private string content;
        private string discrepancy;
        private string location;
        private string distance;
        private string transport;
        private string answer;
        private string solved;

        //Properties
        public int ID { get; set; }
        public Volunteer Volunteer { get; set; }
        public Client Client { get; set; }

        public int VolunteerID { get; set; }

        public int Auteur
        {
            get { return auteur; }
            set { auteur = value; }
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
        public string Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public string Transport
        {
            get { return transport; }
            set { transport = value; }
        }

        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        public string Solved
        {
            get { return solved; }
            set { solved = value; }
        }
        // Constructor
        public Question(Client client, int auteur, string location, string content, DateTime date)
        {
            this.Client = client;
            this.Auteur = auteur;
            this.Location = location;
            this.Transport = null;
            this.Content = content;
            this.discrepancy = null;
            this.Date = date;
            this.Solved = "NEE";
            this.Distance = null;
        }

        public Question(Client client, int auteur, string location,string transport,string distance,string Discrepancy,string content,DateTime date,string solved)
        {
            this.Client = client;
            this.Auteur = auteur;
            this.Location = location;
            this.Transport = transport;
            this.Content = content;
            this.discrepancy = Discrepancy;
            this.Date = date;
            this.Solved = solved;
            this.Distance = distance;
        }

        // Methods
        public override string ToString()
        {
            return Client.Name + " op " + Date.ToShortDateString()  +  ": " + ((content.Length > 40) ? content.Substring(0, 40) + "...." : content) + " - Opgelost: " + Solved;
        }

        // Methods
        public string ToStringLong()
        {
            return Client.Name + " op " + Date.ToShortDateString() + ": " + ((content.Length > 40) ? content.Substring(0, 40) + "...." : content) + " - Opgelost: " + Solved;
        }
    }
}
