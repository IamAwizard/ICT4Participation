using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    class ClientHandler
    {
        // Fields
        Client currentuser;

        UserHandler users;
        QuestionHandler questions;
        ReviewHandler reviews;

        // Constructor   
        public ClientHandler()
        {
            questions = new QuestionHandler();
            reviews = new ReviewHandler();
        }

        // Properties

        // Methods
        public bool AddQuestion(int auteur, string location, string transport, string distance, string discrepancy, string content)
        {
            Question newQuestion = new Question(currentuser, auteur, location, transport, distance, discrepancy, content, DateTime.UtcNow, "NEE");
            if (questions.AddQuestion(newQuestion))
            {
                return true;
            }
            return false;
        }

        public bool AddReview(string volunteername, int rating, string content)
        {
            //Volunteer target = (Volunteer)users.FindUser(volunteername);
            //if (reviews.AddReview(currentuser, target, rating, content))
            //{
            //    return true;
            //}
            return false;
        }

        // TODO: NOT CORRECT
        public bool AddMeeting(Client client, Volunteer volunteer, DateTime date, string location)
        {
            Appointment meeting = new Appointment(client, volunteer, date, location);
            return false; ;
        }

        public List<Question> GetQuestions()
        {
            return questions.QuestionList;
        }
    }
}
