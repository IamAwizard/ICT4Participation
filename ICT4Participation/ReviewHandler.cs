using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    class ReviewHandler
    {
        // Fields
        private List<Review> Reviews;
        // TODO NEEDS DATABASE HANDLER

        // Constructor

        // Properties

        // Methodes
        public bool AddReview(Client reviewer, Volunteer reviewed, int rating, string content)
        {
            Review newReview = new Review(DateTime.Now, reviewer, reviewed, rating, content);
            Reviews.Add(newReview);
            return false;
        }
    }
}
