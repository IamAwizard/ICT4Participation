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
    public partial class Form_MainVolunteer : Form
    {
        Volunteer currentuser;
        VolunteerHandler volunteerhandler;
        public Form_MainVolunteer(User loggedinasuser)
        {
            InitializeComponent();
            currentuser = loggedinasuser as Volunteer;
            lbl_UserName.Text = currentuser.Name;
            volunteerhandler = new VolunteerHandler();
            RefreshInterface();
            timer_Refresh.Start();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Form_Profile profiledialog = new Form_Profile(currentuser);
            this.Hide();
            profiledialog.ShowDialog();
            this.Show();
        }

        public void RefreshInterface()
        {
            lbox_Clients.Items.Clear();
            lbox_Questions.Items.Clear();
            try
            { 
                lbox_Questions.Items.AddRange(volunteerhandler.GetQuestions().ToArray());
            }
            catch
            {
                MessageBox.Show("er zijn geen questions");
            }

            try
            {
                lbox_Clients.Items.AddRange(volunteerhandler.GetClients().ToArray());
            }
            catch
            {
                MessageBox.Show("er zijn geen clients");
            }

        }

        private void btn_Respond_Click(object sender, EventArgs e)
        {
            if (lbox_Questions.SelectedIndex != -1)
            {
                var foo = lbox_Questions.SelectedItem;
                Question question = foo as Question;
                Form_AcceptQuestion dialog = new Form_AcceptQuestion(currentuser, question);
                this.Hide();
                dialog.ShowDialog();
                this.Show();
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
                volunteerhandler.DeleteVolunteer(currentuser as Volunteer);
                MessageBox.Show("Account en data verwijderd. De applicatie sluit nu.");
                this.Close();
            }
        }

        private void timer_Refresh_Tick(object sender, EventArgs e)
        {
            RefreshInterface();
        }

        private void Form_MainVolunteer_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_Refresh.Stop();
        }
    }
}
