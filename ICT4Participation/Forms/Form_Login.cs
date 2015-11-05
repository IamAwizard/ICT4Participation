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
        // Fields
        LoginHandler loginhandler;

        // Constructor
        public Form_Login()
        {
            InitializeComponent();
            loginhandler = new LoginHandler();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginhandler.Authenticate(tbox_Username.Text, tbox_Password.Text))
            {
                User authenticateduser = loginhandler.GetUser(tbox_Username.Text);

                // ^ Above user is logged in, put Form code below inside this if-statement

                // Client
                if (authenticateduser is Client)
                {
                    Form_MainClient MainScreen = new Form_MainClient();
                    this.Hide();
                    tbox_Password.Text = string.Empty;
                    tbox_Username.Text = string.Empty;
                    MainScreen.ShowDialog();
                    this.Show();
                }
                // Volunteer
                if (authenticateduser is Volunteer)
                {
                    Form_MainVolunteer MainScreen = new Form_MainVolunteer();
                    this.Hide();
                    tbox_Password.Text = string.Empty;
                    tbox_Username.Text = string.Empty;
                    MainScreen.ShowDialog();
                    this.Show();
                }
                // Admin
                if (authenticateduser is Admin)
                {
                    Form_MainAdmin MainScreen = new Form_MainAdmin();
                    this.Hide();
                    tbox_Password.Text = string.Empty;
                    tbox_Username.Text = string.Empty;
                    MainScreen.ShowDialog();
                    this.Show();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form_Register registerform = new Form_Register(this);
            this.Hide();
            registerform.ShowDialog();
            this.Show();
        }
    }
}
