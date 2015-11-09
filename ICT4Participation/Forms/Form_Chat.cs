using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT4Participation
{
    public partial class Form_Chat : Form
    {
        // Fields
        ChatHandler chathandler;
        Chat currentchat;
        User currentUser;
        User otherUser;

        // Constructor
        public Form_Chat(User currentuser, User otheruser)
        {
            InitializeComponent();

            chathandler = new ChatHandler();
            currentUser = currentuser;
            otherUser = otheruser;
            currentchat = OpenChat(currentUser, otherUser);
            RefreshInterface();
            Timer_Refresh.Start();
        }

        public Chat OpenChat(User currentuser, User otheruser)
        {
            int chatid = -1;
            if (chathandler.CheckIfChatted(currentuser, otheruser, out chatid))
            {
                // They already have a chat
                return chathandler.GetChat(chatid);
            }
            else
            {
                // They do not yet have a chat
                chathandler.StartChat(currentuser, otheruser);
                chathandler.CheckIfChatted(currentuser, otheruser, out chatid);
                return chathandler.GetChat(chatid);
            }
        }

        public bool SendMessage(int chatid, User author, string content)
        {
            return chathandler.SendMessage(new Message(chatid, currentUser, DateTime.Now, content));
        }

        public void RefreshInterface()
        {
            if (currentchat != null)
            {
                lbl_User1.Text = currentUser.Name;
                lbl_User2.Text = otherUser.Name;
                List<Message> range = chathandler.GetMessages(currentchat.ChatID).OrderBy(x => x.MessageID).ToList();
                
                if(range.Count > lbox_Chat.Items.Count)
                {
                    int a = lbox_Chat.Items.Count;
                    int b = range.Count;
                    for (int i = a; i < b; i++)
                    {
                        lbox_Chat.Items.Add(range[i]);
                    }
                    lbox_Chat.TopIndex = lbox_Chat.Items.Count - 1;
                }
            }
        }

        private void Timer_Refresh_Tick(object sender, EventArgs e)
        {
            RefreshInterface();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbox_Message.Text))
            {
                chathandler.SendMessage(new Message(currentchat.ChatID, currentUser, DateTime.Now, tbox_Message.Text));
                RefreshInterface();
                tbox_Message.Text = "";
            }
        }

        private void Form_Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Timer_Refresh.Stop();
        }
    }
}
