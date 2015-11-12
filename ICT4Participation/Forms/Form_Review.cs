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
    public partial class Form_Review : Form
    {
        // Fields
        Question currentquestion;

        // Constructor
        public Form_Review(Question question)
        {
            InitializeComponent();
            currentquestion = question;
        }

        public Form_Review(Review review)
        {
            InitializeComponent();
            cbox_Rating.SelectedIndex = review.Rating - 1;
            tbox_ReviewContent.Text = review.Content;
            cbox_Rating.Enabled = false;
            tbox_ReviewContent.Enabled = false;
            btn_SendReview.Visible = false;
            lbl_ReviewUserInfo.Text = string.Format("Review van {0} op {1}", review.Client.Name, review.Targetuser.Name);
            lbl_ReviewUserInfo.Visible = true;
        }

        private void btn_SendReview_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(cbox_Rating.SelectedText))
                {
                    Review newReview = new Review(DateTime.Now, currentquestion.Client, currentquestion.Volunteer, Convert.ToInt32(cbox_Rating.SelectedItem), tbox_ReviewContent.Text);
                    DatabaseHandler.AddReview(newReview);
                    MessageBox.Show("Review verzonden");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("U moet een waardering opgegeven hebben");
                }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
