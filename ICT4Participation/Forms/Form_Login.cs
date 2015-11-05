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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isok = false;
            List<User> test = DatabaseHandler.GetUsers();
            foreach(User u in test)
            {
                if (u.Email == tbox_Username.Text && tbox_Password.Text == u.Password)
                    isok = true;
            }

            if(isok)
            {
                MessageBox.Show("Inloggen ok");
            }
            else
            {
                MessageBox.Show(@"Foute email/wachtwoord combinatie");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form_Register registerform = new Form_Register(this);
            registerform.Show();
            this.Hide();
        }
    }
}
