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
            currentuser = volunteerhandler.ExtendVolunteer(currentuser);
            Form_Profile profiledialog = new Form_Profile(currentuser, true);
            timer_Refresh.Stop();
            profiledialog.ShowDialog();
            timer_Refresh.Start();
        }

        public void RefreshInterface()
        {
            lbox_Clients.Items.Clear();
            lbox_Questions.Items.Clear();
            lbox_Appointments.Items.Clear();
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
            try
            {
                lbox_Appointments.Items.AddRange(volunteerhandler.GetMyAppointments(currentuser as Volunteer).ToArray());
            }
            catch
            {
                MessageBox.Show("U heeft geen afspraken");
            }
        }

        private void btn_Respond_Click(object sender, EventArgs e)
        {
            if (lbox_Questions.SelectedIndex != -1)
            {
                var foo = lbox_Questions.SelectedItem;
                Question question = foo as Question;
                Form_AcceptQuestion dialog = new Form_AcceptQuestion(currentuser, question);
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

        private void btn_Chat_Click(object sender, EventArgs e)
        {
            if (lbox_Clients.SelectedIndex != -1)
            {
                User selecteduser = lbox_Clients.SelectedItem as User;
                Form_Chat chatdialog = new Form_Chat(currentuser, selecteduser);
                this.Hide();
                timer_Refresh.Stop();
                chatdialog.ShowDialog();
                this.Show();
                timer_Refresh.Start();
            }
        }

        private void lbox_Appointments_DoubleClick(object sender, EventArgs e)
        {
            if(lbox_Appointments.SelectedIndex != -1)
            {
                Form_Meeting dialog = new Form_Meeting(lbox_Appointments.SelectedItem as Appointment);
                timer_Refresh.Stop();
                    dialog.Show();
                RefreshInterface();
                timer_Refresh.Start();
            }
        }
    }
}
