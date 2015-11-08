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
    public partial class Form_Answer : Form
    {
        Question currentquestion;
        public Form_Answer(Question question)
        {
            currentquestion = question;
            InitializeComponent();
        }

        private void btn_saveanswer_Click(object sender, EventArgs e)
        {
            currentquestion.Answer = tb_answer.Text;
            DatabaseHandler.UpdateQuestion(currentquestion);
            this.Close();
        }
    }
}
