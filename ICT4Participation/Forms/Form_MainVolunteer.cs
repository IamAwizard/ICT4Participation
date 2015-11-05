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
        public Form_MainVolunteer()
        {
            InitializeComponent();
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
    }
}
