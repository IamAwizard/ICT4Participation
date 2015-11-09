using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    class Chats
    {
        // Fields
        private List<Message> messages;

        // Properties
        public List<Message> Messages
        
        {
            get { return messages; }
            set { messages = value; }
        }

        public int BerichtID
        {
            get; set;
        }
        // Constructor
        public Chats()
        {

        }

        // Methods
        public void Synchronize()
        {

        }
    }
}
