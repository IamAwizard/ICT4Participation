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
    public partial class Form_MainClient : Form
    {
        User currentuser;
        ClientHandler clienthandler;
        public Form_MainClient(User loggedinasuser)
        {
            InitializeComponent();
            currentuser = loggedinasuser;
            lbl_UserName.Text = currentuser.Name;
            clienthandler = new ClientHandler(currentuser as Client);
            RefreshInterface();
        }

        public void RefreshInterface()
        {
            lbox_MyQuestions.Items.Clear();
            try
            {
                lbox_MyQuestions.Items.AddRange(clienthandler.GetMyQuestions().ToArray());
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_AddQuestion_Click(object sender, EventArgs e)
        {
            if (tbox_Question.Text != string.Empty || tbox_Location.Text != string.Empty)
            {
                if (!string.IsNullOrWhiteSpace(tbox_Discrepancy.Text))
                {
                    clienthandler.AddQuestion(currentuser.UserID, tbox_Location.Text, tbox_Discrepancy.Text, tbox_Question.Text);
                }
                else
                {
                    clienthandler.AddQuestion(currentuser.UserID, tbox_Location.Text, tbox_Question.Text);
                }
            }
            RefreshInterface();
        }

        private void btn_QuestionDetails_Click(object sender, EventArgs e)
        {
            if (lbox_MyQuestions.SelectedIndex != -1)
            {
                var foo = lbox_MyQuestions.SelectedItem;
                Question question = foo as Question;
                Form_QuestionDetails dialog = new Form_QuestionDetails(question, currentuser as Client);
                this.Hide();
                dialog.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("U heeft geen vraag gekozen");
            }
        }
    }
}
