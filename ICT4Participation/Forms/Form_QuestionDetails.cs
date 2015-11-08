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
    public partial class Form_QuestionDetails : Form
    {
        // Fields
        Question currentquestion;
        ClientHandler clienthandler;

        // Constructor
        public Form_QuestionDetails(Question questiontoshow)
        {
            InitializeComponent();
            currentquestion = questiontoshow;
            RefreshInterface();
            this.ActiveControl = lbl_Info1;
        }


        // Methods
        public void RefreshInterface()
        {
            lbl_QuestionAnswered.Text = (currentquestion.Solved == "JA" ? "Beantwoord!" : "Onbeantwoord");
            lbl_Date.Text = currentquestion.Date.ToShortDateString();
            lbl_ClientName.Text = currentquestion.Client.Name;
            tbox_Question.Text = currentquestion.Content;
            tbox_Location.Text = currentquestion.Location;
            tbox_Discrepancy.Text = (currentquestion.Discrepancy == string.Empty ? "Niet opgegeven" : currentquestion.Discrepancy);
            tbox_Transport.Text = (currentquestion.Transport == string.Empty ? "Niet opgegeven" : currentquestion.Transport);
            tbox_Distance.Text = (currentquestion.Distance == string.Empty ? "Niet opgegeven" : currentquestion.Distance);

            if (!string.IsNullOrWhiteSpace(currentquestion.Answer))
            {
                try
                {
                    gbox_Answer.Visible = true;
                    gbox_NoAnswer.Visible = false;
                    tbox_Answer.Text = currentquestion.Answer;
                    lbl_AnswerAuthorName.Text = currentquestion.Volunteer.Name;
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                gbox_Answer.Visible = false;
                gbox_NoAnswer.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
