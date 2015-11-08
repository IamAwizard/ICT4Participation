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
    public partial class Form_AcceptAssignment : Form
    {
        Question currentquestion;
        VolunteerHandler volunteerhandler;
        public Form_AcceptAssignment(Question question)
        {
           
            volunteerhandler = new VolunteerHandler();
            currentquestion = question;
            InitializeComponent();
            RefreshInterface();
        }

        public void RefreshInterface()
        {


            tb_afstand.Text = (currentquestion.Distance == string.Empty ? "Niet opgegeven" : currentquestion.Distance);

            tb_specialty.Text = (currentquestion.Discrepancy == string.Empty ? "Niet opgegeven" : currentquestion.Discrepancy);
           
          
            tb_vervoer.Text = (currentquestion.Transport == string.Empty ? "Niet opgegeven" : currentquestion.Transport);
            
            
            
        }

        private void btn_acceptassignment_Click(object sender, EventArgs e)
        {
            Form_Answer answer = new Form_Answer();
            this.Hide();
            answer.ShowDialog();
            this.Show();
            currentquestion.Solved = "JA";
           
            volunteerhandler.UpdateQuestion(currentquestion);
            
        }

        private void btn_backassignment_Click(object sender, EventArgs e)
        {
            //Form_Question questiondialog = new Form_Question(question);
            //this.Hide();
            //question.ShowDialog();
            //this.Show();
        }
    }
}
