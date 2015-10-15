using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    class Chat
    {
        private User author;
        private DateTime date;
        private string content;

        public User Author
            {
            get { return author; }
            set { author = value; }
                
            }
        public DateTime Date
        {
            get { return date; }
            set {date = value; }

        }

        public string Content
        {
            get { return content; }
            set { content = value; }

        }

        public Chat(User author, DateTime date,string content)
        {
            this.Author = this.author;
            this.Content = this.content;
            this.Date = this.date;
        }

    }
}
