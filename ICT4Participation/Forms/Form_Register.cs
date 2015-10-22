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
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();

            cbox_Gender.SelectedIndex = 0; 
        }


        /// <summary>
        /// Show and or Hide VOG info based on radiobutton selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtn_Volunteer_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_Volunteer.Checked)
            {
                pnl_VOGInfo.Show();
            }
            else
            {
                pnl_VOGInfo.Hide();
            }
        }

        private User CheckAndReadEverything()
        {
            string email, password, naam, gender, city, address;
            DateTime dateofbirth;

            email = tbox_Email.Text;
            if(!email.Contains('@'))
            {
                MessageBox.Show("Er is geen valide email ingevuld");
                return null;
            }
            return null;
        }

        private void btn_VOGUpload_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == OpenFileDialog.ShowDialog())
            {
                lbl_VOGPath.Text = OpenFileDialog.FileName;
            }
        }
    }
}
