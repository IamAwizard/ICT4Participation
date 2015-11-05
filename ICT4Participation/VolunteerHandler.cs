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

        QuestionHandler questions;


        // Properties

        // Constructor

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
            return questions.QuestionList;
        }

        public Schedule GetSchedule()
        {
            return currentuser.GetSchedule();
        }
    }
}
