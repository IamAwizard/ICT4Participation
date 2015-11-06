using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    class AdminHandler
    {
        // Fields
        Admin currentuser;
        QuestionHandler questionhandler;
        ReviewHandler reviewhandler;
        // Constructor   
        public AdminHandler()
        {
            questionhandler = new QuestionHandler();
            reviewhandler = new ReviewHandler();
        }

        // Properties

        // Methods
        public bool DeleteQuestion(Question helprequest)
        {
            /// TODO: IMPLEMENT
            return false;
        }

        public bool DeleteReview(Review review)
        {
            // TODO: IMPLEMENT
            return false;
        }

        public List<Review> GetReviews()
        {
            // TODO: IMPLEMENT
            return null;
        }

        public List<Question> GetQuestions()
        {
            // TODO: IMPLEMENT
            return questionhandler.GetAllQuestions();
        }
    }
}
