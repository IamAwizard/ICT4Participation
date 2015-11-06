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
            RefreshScreen();
        }

        public void RefreshScreen()
        {
            List<Question> questions = new List<Question>();
            lb_Reviews.Items.Clear();
            lb_Questions.Items.Clear();

            lb_Questions.Items.AddRange(adminhandler.GetQuestions().ToArray());
        }
    }
}
