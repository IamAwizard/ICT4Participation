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
        Volunteer volunteer;
        public Form_Profile(Volunteer user)
        {
            int leeftijd = DateTime.Now.Year - user.DateOfBirth.Year;
            InitializeComponent();
            volunteer = user;
            lbl_Name.Text = user.Name;
            lbl_leeftijd.Text = Convert.ToString(leeftijd);
        }

        private void pnl_profiel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            var formschedule = new Form_Shedule();
            formschedule.Show();
        }

        private void lbl_namevolunteer_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_uploadavatar_Click(object sender, EventArgs e)
        {

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
    }
}
