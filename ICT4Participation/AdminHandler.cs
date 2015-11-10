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
            return questionhandler.DeleteQuestion(helprequest);
        }

        public bool DeleteReview(Review review)
        {
            return reviewhandler.DeleteReview(review);
        }

        public List<Review> GetReviews()
        {
            return reviewhandler.GetAllReviews();
        }

        public List<Question> GetQuestions()
        {
            return questionhandler.GetAllQuestions();
        }
    }
}
