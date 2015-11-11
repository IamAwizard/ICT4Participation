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
    public partial class Form_Profile : Form
    {
        // Fields
        Volunteer volunteer;
        bool isChanged;

        // Constructor
        public Form_Profile(Volunteer volun)
        {
            InitializeComponent();
            volunteer = volun;

            isChanged = false;
            InitializeInterface();
        }
        
        private void InitializeInterface()
        {
            lbl_Name.Text = volunteer.Name;
            lbl_Score.Text = volunteer.Rating.ToString("0.#");
            lbl_leeftijd.Text = (DateTime.Now.Year - volunteer.DateOfBirth.Year).ToString();
            cbox_License.Checked = volunteer.DrivingLicense;
            tbox_Biography.Text = volunteer.Biogragphy;

            tbox_Monday.Text = volunteer.Schedule.Monday;
            tbox_Tuesday.Text = volunteer.Schedule.Tuesday;
            tbox_Wednesday.Text = volunteer.Schedule.Wednesday;
            tbox_Thursday.Text = volunteer.Schedule.Thursday;
            tbox_Friday.Text = volunteer.Schedule.Friday;
            tbox_Saturday.Text = volunteer.Schedule.Saturday;
            tbox_Sunday.Text = volunteer.Schedule.Sunday;

            pnl_Schedule.Hide();
            pnl_Profile.Show();

            isChanged = false;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            pnl_Schedule.Hide();
            pnl_Profile.Show();
        }

        private void btn_Schedule_Click(object sender, EventArgs e)
        {
            pnl_Schedule.Show();
            pnl_Profile.Hide();
        }

        private void tbox_Biography_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }

        private void Form_Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isChanged)
            {
                volunteer.DrivingLicense = cbox_License.Checked;
                volunteer.Biogragphy = tbox_Biography.Text;

                volunteer.Schedule.Monday = tbox_Monday.Text;
                volunteer.Schedule.Tuesday = tbox_Tuesday.Text;
                volunteer.Schedule.Wednesday = tbox_Wednesday.Text;
                volunteer.Schedule.Thursday = tbox_Thursday.Text;
                volunteer.Schedule.Friday = tbox_Friday.Text;
                volunteer.Schedule.Saturday = tbox_Saturday.Text;
                volunteer.Schedule.Sunday = tbox_Sunday.Text;

                DatabaseHandler.UpdateVolunteer(volunteer);
            }
        }
    }
}
