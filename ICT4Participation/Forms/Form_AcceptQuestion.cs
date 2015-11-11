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
    public partial class Form_AcceptQuestion : Form
    {
        Question currentquestion;
        VolunteerHandler volunteerhandler;
        Volunteer currentuser;
        public Form_AcceptQuestion(Volunteer user, Question question)
        {
            InitializeComponent();
            volunteerhandler = new VolunteerHandler();
            currentquestion = question;
            currentuser = user;
            RefreshInterface();
        }

        public void RefreshInterface()
        {
            lbl_ClientName.Text = currentquestion.Client.Name;
            tbox_Question.Text = (currentquestion.Content == string.Empty ? "Niet opgegeven" : currentquestion.Content);
            tbox_Discrepancy.Text = (currentquestion.Discrepancy == string.Empty ? "Niet opgegeven" : currentquestion.Discrepancy);
            tbox_Location.Text = (currentquestion.Location == string.Empty ? "Niet opgegeven" : currentquestion.Location);
            tbox_Distance.Text = (currentquestion.Distance == string.Empty ? "Niet opgegeven" : currentquestion.Distance);
            tbox_Transport.Text = (currentquestion.Transport == string.Empty ? "Niet opgegeven" : currentquestion.Transport);
        }

        private void btn_acceptassignment_Click(object sender, EventArgs e)
        {
            Form_Answer answer = new Form_Answer(currentuser, currentquestion);
            answer.ShowDialog();
            this.Show();
        }
    }
}
