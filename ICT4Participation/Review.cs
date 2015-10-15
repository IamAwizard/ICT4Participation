using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    class Review
    {
        // Fields
        private DateTime date;
        private Client client;
        private Volunteer targetuser;
        private int rating;
        private string content;

        // Properties
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public Client Client
        {
            get { return client; }
            set { client = value; }
        }
        public Volunteer Targetuser
        {
            get { return targetuser; }
            set { targetuser = value; }
        }
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        // Constructor
        public Review(DateTime date, Client client,Volunteer targetuser,int rating, string content)
        {
            this.Rating = rating;
            this.Targetuser = this.targetuser;
            this.Client = this.client;
            this.Content = this.content;
            this.Date = this.date;
        }

        // Methods
        public override string ToString()
        {
            return "Datum:" + Date + "Client:" + Client + "Volunteer" + Targetuser + "Inhoud" + Content + "rating" + Rating;
        }
    }
}
