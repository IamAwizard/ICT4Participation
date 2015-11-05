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
        User currentuser;
        public Form_MainVolunteer(User loggedinasuser)
        {
            InitializeComponent();
            currentuser = loggedinasuser;
            lbl_UserName.Text = currentuser.Name;
        }

        private void Form_Volunteer_Load(object sender, EventArgs e)
        {

        }
    }
}
