﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    class ChatHandler
    {
        // Properties

        // Constructor
        public ChatHandler()
        {
        }

        public bool CheckIfChatted(User currentuser, User otheruser, out int gesprekid)
        {
            return DatabaseHandler.CheckIfHaveChat(currentuser, otheruser, out gesprekid);
        }

        // Methods
        public bool StartChat(User currentuser, User otheruser)
        {
            int chatid;
            if(!CheckIfChatted(currentuser, otheruser, out chatid))
            {
                return DatabaseHandler.StartChat(currentuser, otheruser);
            }
            System.Windows.Forms.MessageBox.Show("Gebruikers hebben al een gesprek");
            return false;
        }

        public int GetChatID(User currentuser, User otheruser)
        {
            int chatid = -1;
            if(CheckIfChatted(currentuser, otheruser, out chatid))
            {
                return chatid;
            }
            System.Windows.Forms.MessageBox.Show("Er bestaat geen chat tussen de gebruikers");
            return -1;
        }

        public List<Message> GetMessages(int ChatID)
        {
            return DatabaseHandler.GetChat(ChatID).Messages;
        }

        public Chat GetChat(int ChatID)
        {
            return DatabaseHandler.GetChat(ChatID);
        }

        public bool SendMessage(Message message)
        {
            return DatabaseHandler.AddMessage(message);
        }

        public List<Message> GetNewMessages(int ChatID, int MessageID)
        {
            return DatabaseHandler.GetNewMessages(ChatID, MessageID);
        }
    }
}
