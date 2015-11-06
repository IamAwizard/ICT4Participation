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
        public Form_MainVolunteer(User loggedinasuser)
        {
            InitializeComponent();
            currentuser = loggedinasuser as Volunteer;
            lbl_UserName.Text = currentuser.Name;
        }

        private void Form_Volunteer_Load(object sender, EventArgs e)
        {

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Form_Profile profiledialog = new Form_Profile(currentuser);
            this.Hide();
            profiledialog.ShowDialog();
            this.Show();
        }
    }
}
