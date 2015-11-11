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
    public partial class Form_MainClient : Form
    {
        User currentuser;
        ClientHandler clienthandler;
        public Form_MainClient(User loggedinasuser)
        {
            InitializeComponent();
            currentuser = loggedinasuser;
            lbl_UserName.Text = currentuser.Name;
            clienthandler = new ClientHandler(currentuser as Client);
            RefreshInterface();
        
            timer_Refresh.Start();
        }

        public void RefreshInterface()
        {
            lbox_Volunteers.Items.Clear();
            lbox_MyQuestions.Items.Clear();
            try
            {
                lbox_MyQuestions.Items.AddRange(clienthandler.GetMyQuestions().ToArray());
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                lbox_Volunteers.Items.AddRange(clienthandler.GetVolunteers().ToArray());
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_AddQuestion_Click(object sender, EventArgs e)
        {
            if (tbox_Question.Text != string.Empty)
            {
                if (tbox_Question.Text.Length >= 10)
                {
                    clienthandler.AddQuestion(currentuser.UserID, "Niet opgegeven", tbox_Question.Text);
                }
                else
                {
                    MessageBox.Show(" de vraag moet minimaal 10 tekens bevatten");
                
                }
            }
            RefreshInterface();
            tbox_Question.Clear();
        }

        private void btn_QuestionDetails_Click(object sender, EventArgs e)
        {
            if (lbox_MyQuestions.SelectedIndex != -1)
            {
                var foo = lbox_MyQuestions.SelectedItem;
                Question question = foo as Question;
                Review review = foo as Review;
                Form_QuestionDetails dialog = new Form_QuestionDetails(question, currentuser as Client,review);
                dialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("U heeft geen vraag gekozen");
            }
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Weet je zeker dat u het account wil verwijderen?", "Let op!", MessageBoxButtons.YesNo))
            {
                clienthandler.DeleteClient(currentuser as Client);
                MessageBox.Show("Account en data verwijderd. De applicatie sluit nu.");
                this.Close();
            }
        }

        private void timer_Refresh_Tick(object sender, EventArgs e)
        {
            RefreshInterface();
        }

        private void Form_MainClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_Refresh.Stop();
        }

        private void btn_Chat_Click(object sender, EventArgs e)
        {
            if(lbox_Volunteers.SelectedIndex != -1)
            {
                User selecteduser = lbox_Volunteers.SelectedItem as User;
                Form_Chat chatdialog = new Form_Chat(currentuser, selecteduser);
                timer_Refresh.Stop();
                chatdialog.ShowDialog();
                timer_Refresh.Start();
            }
        }
    }
}
