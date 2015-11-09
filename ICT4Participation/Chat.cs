using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    public class Chat
    {
        // Fields

        // Properties
        public int ChatID { get; }
        public List<Message> Messages { get; set; }

        // Constructor
        public Chat(int chatid)
        {
            ChatID = chatid;
        }
    }
}
