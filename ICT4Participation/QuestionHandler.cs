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
        public bool AddQuestion(Question question)
        {
            return false;
        }
    }
}
