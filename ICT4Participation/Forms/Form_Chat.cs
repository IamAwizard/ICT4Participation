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
    public partial class Form_Chat : Form
    {
        // Fields
        Question activequestion;
        // Constructor
        public Form_Chat(Question question)
        {
            InitializeComponent();

            activequestion = question;
        }
    }
}
