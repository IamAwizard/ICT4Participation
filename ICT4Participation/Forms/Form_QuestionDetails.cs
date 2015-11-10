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
        User currentuser;
        User volunteer;
        ClientHandler clienthandler;
        bool isChanged;
        Review currentreview;
        // Constructor
        public Form_QuestionDetails(Question questiontoshow, Client currentuser,Review reviewtoshow)
        {
            
            InitializeComponent();
            this.currentuser = currentuser;
            reviewtoshow = new Review(DateTime.Now, currentuser, null, currentreview.Rating, currentreview.Content);
            this.currentreview = reviewtoshow;
            
            

            clienthandler = new ClientHandler(this.currentuser as Client);
            
            currentquestion = questiontoshow;
            RefreshInterface();
            this.ActiveControl = lbl_Info1;
            isChanged = false;
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
            cb_volunteerrating.Text = Convert.ToString(currentreview.Rating);
           
            

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
            if(currentquestion.Solved == "JA")
            {
                lbl_volunteerrating.Visible = true;
                cb_volunteerrating.Visible = true;
            }
            else if(currentquestion.Solved == "NEE")
            {
                currentreview.Rating = 0;
                lbl_volunteerrating.Visible = false;
                cb_volunteerrating.Visible = false;
            }
            if(cb_volunteerrating.Text != null)
            {
                cb_volunteerrating.Enabled = false;
            }
           else if(cb_volunteerrating.Text == null)
            {
                cb_volunteerrating.Enabled = true;
            }

            if (currentreview.Rating == 1)
            {
                cb_volunteerrating.Text = "1";
            }




        }

        private void tbox_Question_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }

        private void Form_QuestionDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isChanged)
            {
                currentquestion.Content = tbox_Question.Text;
                currentquestion.Location = tbox_Location.Text;
                currentquestion.Discrepancy = tbox_Discrepancy.Text;
                currentquestion.Transport = tbox_Transport.Text;
                currentquestion.Distance = tbox_Distance.Text;
                currentreview.Rating = Convert.ToInt32(cb_volunteerrating.Text);

                clienthandler.AddReview(volunteer.Name,Convert.ToInt32(cb_volunteerrating.Text),null);
                clienthandler.UpdateQuestion(currentquestion);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
