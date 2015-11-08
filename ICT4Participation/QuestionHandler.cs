using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    class QuestionHandler
    {
        // Fields
        private List<Question> questions;

        // Constructor   
        public QuestionHandler()
        {

        }

        // Properties
        public List<Question> QuestionList
        {
           
           get { return questions; }
        }

        // Methods
        public void Synchronize()
        {
            questions = DatabaseHandler.GetAllQuestions();
        }

        public bool AddQuestion(Question question)
        {
            if (DatabaseHandler.AddQuestion(question))
                return true;
            else
                return false;

        }

        public bool UpdateQuestion(Question questiontoupdate)
        {
            if (DatabaseHandler.UpdateQuestion(questiontoupdate))
                return true;
            else
                return false;
        }

        public List<Question> GetQuestionsByAuthor(User author)
        {
            Synchronize();
            try
            {
                return questions.FindAll(x => x.Auteur == author.UserID);
            }
            catch (NullReferenceException ex)
            {
                return null;
            }
        }

        public List<Question> GetAllQuestions()
        {
            Synchronize();
            return QuestionList;
        }


    }
}
