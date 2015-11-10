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
    public partial class Form_MainAdmin : Form
    {
        //fields
        AdminHandler adminhandler;
        public Form_MainAdmin(User loggedinasuser)
        {
            InitializeComponent();
            adminhandler = new AdminHandler();
            lbl_Name.Text = loggedinasuser.Name;
            RefreshScreen();
        }

        public void RefreshScreen()
        {
            List<Question> questions = new List<Question>();
            lbox_Reviews.Items.Clear();
            lbox_Questions.Items.Clear();

            lbox_Questions.Items.AddRange(adminhandler.GetQuestions().ToArray());
            lbox_Reviews.Items.AddRange(adminhandler.GetReviews().ToArray());
        }

        private void btn_DeleteReview_Click(object sender, EventArgs e)
        {
            if(lbox_Reviews.SelectedIndex != -1)
            {
                if (DialogResult.OK == MessageBox.Show("Weet je zeker dat je de review wilt verwijderen?\nDeze kan niet meer hersteld worden!", "Let op!", MessageBoxButtons.OKCancel))
                    {
                    adminhandler.DeleteReview(lbox_Reviews.SelectedItem as Review);
                    lbox_Reviews.Items.Remove(lbox_Reviews.SelectedItem);
                    MessageBox.Show("Verwijderd.");
                }
            }
        }

        private void btn_DeleteQuestion_Click(object sender, EventArgs e)
        {
            if (lbox_Questions.SelectedIndex != -1)
            {
                if (DialogResult.OK == MessageBox.Show("Weet je zeker dat je de vraag wilt verwijderen?\nDeze kan niet meer hersteld worden!", "Let op!", MessageBoxButtons.OKCancel))
                {
                    adminhandler.DeleteQuestion(lbox_Questions.SelectedItem as Question);
                    lbox_Questions.Items.Remove(lbox_Questions.SelectedItem);
                    MessageBox.Show("Verwijderd.");
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
