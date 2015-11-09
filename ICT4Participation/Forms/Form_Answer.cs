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
    public partial class Form_Answer : Form
    {
        Question currentquestion;
        Volunteer currentuser;
        public Form_Answer(Volunteer user, Question question)
        {
            InitializeComponent();

            currentquestion = question;
            currentuser = user;
        }

        private void btn_saveanswer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbox_Answer.Text))
            {
                // Attach Volunteer to question
                currentquestion.Answer = tbox_Answer.Text;
                currentquestion.Solved = "JA";
                currentquestion.Volunteer = currentuser;
                currentquestion.VolunteerID = currentuser.UserID;

                // Update
                DatabaseHandler.UpdateQuestion(currentquestion);
                this.Close();
            }
            else
                MessageBox.Show("U moet een antwoord op geven om te kunnen verzenden.");
        }

        private void tbox_Answer_TextChanged(object sender, EventArgs e)
        {
            if(tbox_Answer.Text.Length > 1023)
            {
                lbl_AnswerTooLong.Visible = true;
                this.Height = 330 ;
            }
            else
            {
                lbl_AnswerTooLong.Visible = false;
                this.Height = 300;
            }
        }
    }
}
