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
    public partial class Form_Meeting : Form
    {
        // Fields
        User currentuser;
        User targetuser;

        // Constructor
        public Form_Meeting(User client, User volunteer)
        {
            InitializeComponent();

            currentuser = client;
            targetuser = volunteer;

            lbl_VolunName.Text = targetuser.Name;
        }

        public Form_Meeting(Appointment meeting)
        {
            InitializeComponent();

            label1.Text = meeting.Client.Name;
            lbl_VolunName.Text = "Geholpen door: " + meeting.Volunteer.Name;
            dtp_Date.Value = meeting.Date;
            tbox_Location.Text = meeting.Location;

            dtp_Date.Enabled = false;
            tbox_Location.Enabled = false;
            btn_AddMeeting.Visible = false;
        }

        private void btn_AddMeeting_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbox_Location.Text))
            {
                MessageBox.Show("Locatie invullen is verplicht");
            }
            else
            {
                DatabaseHandler.AddAppointment(new Appointment(currentuser as Client, targetuser as Volunteer, dtp_Date.Value, tbox_Location.Text));
                this.Close();
            }
        }
    }
}
