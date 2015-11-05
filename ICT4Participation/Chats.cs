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
        private List<Chat> chats;

        // Properties
        public List<Chat> ChatList
        
        {
            get { return chats; }
            set { chats = value; }
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
