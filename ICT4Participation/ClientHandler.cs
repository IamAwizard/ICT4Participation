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
        QuestionHandler questions;
        Client currentuser;

        // Constructor   
        public ClientHandler()
        {
            questions = new QuestionHandler();
        }

        // Properties

        // Methods
        public bool AddQuestion(string name, string location, string transport,int distance, string discrepancy, string content)
        {
            Question newQuestion = new Question(currentuser, name, location, transport, distance, discrepancy, content, DateTime.UtcNow, false);
            if(questions.AddQuestion(newQuestion))
            {
                return true;
            }
            return false;
        }
        
}
