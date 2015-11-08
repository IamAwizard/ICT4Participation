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
    public partial class Form_AcceptAssignment : Form
    {
        Question currentquestion;
        public Form_AcceptAssignment(Question question)
        {
            currentquestion = question;
            InitializeComponent();
            RefreshInterface();
        }

        public void RefreshInterface()
        {


            tb_afstand.Text = (currentquestion.Distance == string.Empty ? "Niet opgegeven" : currentquestion.Distance);

            tb_specialty.Text = (currentquestion.Discrepancy == string.Empty ? "Niet opgegeven" : currentquestion.Discrepancy);
            int i = Convert.ToInt32(tb_afstand.Text) / 50;
            tb_reistijd.Text = i.ToString();
            tb_vervoer.Text = (currentquestion.Transport == string.Empty ? "Niet opgegeven" : currentquestion.Transport);
            
            
            
        }
    }
}
