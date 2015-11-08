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
    public partial class Form_Question : Form
    {
        Question currentquestion;
   
        public Form_Question(Question questiontoshow)
        {
            currentquestion = questiontoshow;
            InitializeComponent();
            RefreshInterface();
        }


        public void RefreshInterface()
        {
            tb_assignment.Text = currentquestion.Content;
            tb_specialty.Text = (currentquestion.Discrepancy == string.Empty ? "Niet opgegeven" : currentquestion.Discrepancy);
        }
        private void btn_accept_Click(object sender, EventArgs e)
        {
            Form_AcceptAssignment  assignmentdialog = new Form_AcceptAssignment(currentquestion);
            this.Hide();
            assignmentdialog.ShowDialog();
            this.Show();
        }
    }
}
