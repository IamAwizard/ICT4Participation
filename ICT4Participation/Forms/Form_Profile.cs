using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
        bool hasPicture;
        String uriString = @"ftp://i259530@athena.fhict.nl/PROFILE";
        string imgpath;

        // Constructor
        public Form_Profile(Volunteer volun)
        {
            InitializeComponent();
            volunteer = volun;

            hasPicture = false;
            isChanged = false;
            InitializeInterface();
        }
        
        private void InitializeInterface()
        {
            lbl_Name.Text = volunteer.Name;
            lbl_Score.Text = volunteer.Rating.ToString("0.#");
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (volunteer.DateOfBirth.Year * 100 + volunteer.DateOfBirth.Month) * 100 + volunteer.DateOfBirth.Day;

            int i = (a - b) / 10000;
            lbl_leeftijd.Text = Convert.ToString(i);
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
            if(hasPicture)
            {
                File.Delete(imgpath);
            }
        }

        private void link_VOG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DownloadVOG(volunteer);
        }

        private void btn_UploadPhoto_Click(object sender, EventArgs e)
        {
            UploadPhoto(volunteer);
            Form_Profile_Load(null, null);
        }

        private bool DownloadVOG(Volunteer volun)
        {
            try
            {
                // Create a new WebClient instance.
                string serverpath = volun.PathToVOG;
                string tempfilename = "VOG" + volun.UserID + ".pdf";

                WebClient myWebClient = new WebClient();
                myWebClient.Credentials = new NetworkCredential("i259530", "temppass1");
                myWebClient.DownloadFile(serverpath, tempfilename);

                if(DialogResult.OK == saveFileDialog.ShowDialog())
                {
                    string newfilename = saveFileDialog.FileName;
                    File.Copy(tempfilename, newfilename);
                }
                File.Delete(tempfilename);
                return true;
            }
            catch
            {
                MessageBox.Show("Download Failed.");
                return false;
            }
        }

        private bool UploadPhoto(Volunteer volun)
        {
            try
            {
                // Create a new WebClient instance.
                if (DialogResult.OK == openFileDialog.ShowDialog())
                {
                    string fileName = openFileDialog.FileName;
                    string filetype = fileName.Substring(fileName.LastIndexOf('.'), fileName.Length - fileName.LastIndexOf('.'));
                    string tempcopy = "IMG" + volun.UserID + filetype;
                    string destination = uriString + @"/" + tempcopy;
                    if (hasPicture)
                        File.Delete(imgpath);
                    File.Copy(fileName, tempcopy);

                    WebClient myWebClient = new WebClient();
                    myWebClient.Credentials = new NetworkCredential("i259530", "temppass1");
                    byte[] responseArray = myWebClient.UploadFile(destination, tempcopy);

                    DatabaseHandler.UpdatePhoto(destination, volun.UserID);
                    File.Delete(tempcopy);

                    volun.PathToPhoto = destination;
                    return true;
                }
                return false;
            }
            catch
            {
                MessageBox.Show("Upload Failed.");
                return false;
            }
        }

        private string DownloadPhoto(Volunteer volun)
        {
            try
            {
                // Create a new WebClient instance.
                string serverpath = volun.PathToPhoto;
                int postslash = volun.PathToPhoto.LastIndexOf('/') + 1;
                int length = volun.PathToPhoto.Length;
                string tempfilename = volun.PathToPhoto.Substring(postslash, length - postslash);

                WebClient myWebClient = new WebClient();
                myWebClient.Credentials = new NetworkCredential("i259530", "temppass1");
                myWebClient.DownloadFile(serverpath, tempfilename);
                return tempfilename;
            }
            catch
            {
                return string.Empty;
            }
        }

        private void Form_Profile_Load(object sender, EventArgs e)
        {
            imgpath = DownloadPhoto(volunteer);
            if(imgpath != string.Empty)
            {
                pbox_ProfilePicture.ImageLocation = imgpath;
                hasPicture = true;
            }
        }

        private void lbl_leeftijd_Click(object sender, EventArgs e)
        {

        }
    }
}
