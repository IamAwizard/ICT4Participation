using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ICT4Participation
{
    public partial class Form_Register : Form
    {
        // Fields
        Form_Login formsender;
        string vogpath;
        bool voguploaded;

        // Constructor
        public Form_Register(Form_Login sender)
        {
            InitializeComponent();

            this.formsender = sender;
            cbox_Gender.SelectedIndex = 0;
            vogpath = "";
            bool voguploaded = false;
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
                Height = MaximumSize.Height;
            }
            else
            {
                pnl_VOGInfo.Hide();
                Height = MinimumSize.Height; ;
            }
        }

        /// <summary>
        /// Checks and preocesses all form data.
        /// </summary>
        /// <returns>The volunteer or client if succesfull, otherwise null</returns>
        private User CheckAndReadEverything()
        {
            string email, password, name, gender, city, address;
            DateTime dateofbirth;

            // E-Mail
            email = tbox_Email.Text;
            if(!email.Contains('@'))
            {
                MessageBox.Show("Er is geen valide email ingevuld");
                return null;
            }
            // Password
            password = tbox_Password.Text;
            if(password.Length < 5)
            {
                MessageBox.Show("Lengte van wachtwoord moet minimaal 5 tekens zijn");
                return null;
            }
            // Name
            name = tbox_Name.Text;
            // TODO: Add checks?
            // Gender
            if(cbox_Gender.Text == "Man")
            {
                gender = "M";
            }
            else
            {
                gender = "V";
            }
            // City
            city = tbox_City.Text;
            // Address
            address = tbox_Address.Text;
            // Date of Birth
            dateofbirth = dtp_DateOfBirth.Value;
            if(rbtn_Volunteer.Checked)
            {
                if (voguploaded)
                {
                    Volunteer newVolunteer = new Volunteer(name, dateofbirth, gender, city, address, email, password, false, "", vogpath, "");
                    return newVolunteer;
                }
                else
                {
                    MessageBox.Show("Upload eerst je VOG");
                    return null;
                }
            }
            else
            {
                Client newClient = new Client(name, dateofbirth, gender, city, address, email, password);
                return newClient;
            }
        }

        /// <summary>
        /// Uploads the VOG to a location
        /// TODO: move upload to seperate method?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_VOGUpload_Click(object sender, EventArgs e)
        {
            try {
                if (DialogResult.OK == OpenFileDialog.ShowDialog())
                {
                    lbl_VOGPath.Text = OpenFileDialog.FileName;
                    string destination = @"pdf.pdf";
                    File.Copy(lbl_VOGPath.Text, destination);
                    vogpath = destination;
                    voguploaded = true;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            
                User newUser = CheckAndReadEverything();
            if (newUser != null)
            {
                try
                {
                    DatabaseHandler.AddUser(newUser);
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Account aanmaken gelukt!");
                    formsender.tbox_Username.Text = newUser.Email;
                    formsender.tbox_Password.Text = newUser.Password;
                    this.Close();
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

         
        }

        private void Form_Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            formsender.Show();
        }
    }
}
