using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    public class Review
    {
        // Fields

        // Properties
         
        public int ReviewID { get; set; }
        public DateTime Date { get; set; }
        public Client Client { get; set; }
        public int ClientID { get; set; }
        public Volunteer Targetuser { get; set; }
        public int VolunteerID { get; set; }
        public int Rating { get; set; }
        public string Content { get; set; }

        // Constructor
        public Review(DateTime date, Client client,Volunteer targetuser,int rating, string content)
        {
            Rating = rating;
            Targetuser = targetuser;
            Client = client;
            Content = content;
            Date = date;
        }

        public Review(DateTime date, int client, int targetuser, int rating, string content)
        {
            Rating = rating;
            VolunteerID = targetuser;
            ClientID = client;
            Content = content;
            Date = date;
        }


        // Methods
        public override string ToString()
        {
            return ReviewID + "::  " + "Client: " + Client.Name + " over " + Targetuser.Name + " op " + Date.ToShortDateString();
        }
    }
}
