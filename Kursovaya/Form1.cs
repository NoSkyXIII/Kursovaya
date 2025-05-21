using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void goTo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Question question = new Question();
            question.Show();
        }

        private void outMed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

