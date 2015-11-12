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
        ChatHandler chathandler;
        QuestionHandler questionhandler;
        ReviewHandler reviewhandler;
        UserHandler userhandler;

        // Constructor   
        public ClientHandler(Client activeuser)
        {
            questionhandler = new QuestionHandler();
            reviewhandler = new ReviewHandler();
            userhandler = new UserHandler();
            CurrentUser = activeuser;
        }

        // Properties
        public Client CurrentUser { get; set; }

        // Methods
        public bool AddQuestion(int auteur, string location, string content)
        {
            Question newQuestion = new Question(CurrentUser, auteur, location, content, DateTime.Now);
            if (questionhandler.AddQuestion(newQuestion))
            {
                return true;
            }
            return false;
        }

        public bool AddQuestion(int auteur, string location, string discrepancy, string content)
        {
            Question newQuestion = new Question(CurrentUser, auteur, location, content, DateTime.Now);
            newQuestion.Discrepancy = discrepancy;
            if (questionhandler.AddQuestion(newQuestion))
            {
                return true;
            }
            return false;
        }

        public bool UpdateQuestion(Question questiontoupdate)
        {
            if (questionhandler.UpdateQuestion(questiontoupdate))
                return true;
            else
                return false;
        }

        public bool AddReview(Review review)
        {
            if (reviewhandler.AddReview(review))
            {
                return true;
            }
            return false;
        }

        // TODO: NOT CORRECT
        public bool AddMeeting(Client client, Volunteer volunteer, DateTime date, string location)
        {
            Appointment meeting = new Appointment(client, volunteer, date, location);
            return false; ;
        }

        public List<Question> GetMyQuestions()
        {
            return questionhandler.GetQuestionsByAuthor(CurrentUser);
        }

        public bool DeleteClient(Client client)
        {
            if (userhandler.DeleteUser(client))
                return true;
            else
                return false;
        }

        public List<User> GetVolunteers()
        {
            List<User> returnlist = new List<User>();

            userhandler.Synchronize();
            foreach (User u in userhandler.Users)
            {
                if (u is Volunteer)
                {
                    returnlist.Add(u);
                }
            }
            return returnlist.OrderBy(x => x.Name).ToList();
        }

        public Volunteer ExtendVolunteer(Volunteer volunteer)
        {
            return userhandler.ExtendVolunteer(volunteer);
        }

        public List<Appointment> GetMyAppointments(Client client)
        {
            return DatabaseHandler.GetMyAppointments(client);
        }
    }
}
