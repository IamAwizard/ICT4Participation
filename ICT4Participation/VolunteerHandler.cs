using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    class VolunteerHandler
    {
        // Fields
        Volunteer currentuser;

        ChatHandler chathandler;
        QuestionHandler questions;
        UserHandler userhandler;

        // Properties

        // Constructor
        public VolunteerHandler()
        {
            questions = new QuestionHandler();
            userhandler = new UserHandler();
           

        }
        public bool UpdateQuestion(Question questiontoupdate)
        {
            if (questions.UpdateQuestion(questiontoupdate))
                return true;
            else
                return false;
        }

        // Methods
        public bool AnswerQuestion(Question question, string answer)
        {
            questions.QuestionList.Find(x => x.Auteur == question.Auteur).Answer = answer;
            return true;

        }

        public bool UpdateProfile(bool driverslisence, string biography, string pathtophoto)
        {
            currentuser.DrivingLicense = driverslisence;
            currentuser.Biogragphy = biography;
            currentuser.PathToPhoto = pathtophoto;
            return true;
        }

        public Volunteer GetUserInfo()
        {
            return currentuser;
        }

        public List<Question> GetQuestions()
        {

            return questions.GetAllQuestions();
        }

        public List<User> GetClients()
        {
            List<User> returnlist = new List<User>();

            userhandler.Synchronize();
            foreach (User u in userhandler.Users)
            {
                if (u is Client)
                {
                    returnlist.Add(u);
                }
            }
            
                return returnlist.OrderBy(x => x.Name).ToList();
        }

        public Schedule GetSchedule()
        {
            return currentuser.GetSchedule();
        }

        public bool DeleteVolunteer(Volunteer volunteer)
        {
            if (userhandler.DeleteUser(volunteer))
                return true;
            else
                return false;
        }

        public Volunteer ExtendVolunteer(Volunteer volunteer)
        {
            return userhandler.ExtendVolunteer(volunteer);
        }

        public bool UpdateVolunteer(Volunteer volunteer)
        {
            return userhandler.UpdateVolunteer(volunteer);
        }

        public List<Appointment> GetMyAppointments(Volunteer volun)
        {
            return DatabaseHandler.GetMyAppointments(volun);
        }
    }
}
