using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    public class Message
    {
        // Fields

        // Properties
        public int ChatID { get; }
        public int MessageID { get; }
        public User Author { get; set; }
        public int AuthorID { get; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        // Constructor

        public Message(int chatid, User author, DateTime date, string content)
        {
            ChatID = chatid;
            Author = author;
            Content = content;
            Date = date;
            AuthorID = author.UserID;
        }

        public Message(int chatid, int messageid, int authorid, DateTime date,string content)
        {
            ChatID = chatid;
            MessageID = messageid;
            AuthorID = authorid;
            Content = content;
            Date = date;
        }

        public override string ToString()
        {
            return Author.Name + ": " + Content;
        }

    }
}
