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
    public partial class Question : Form
    {
        public Question()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Yap_Click(object sender, EventArgs e)
        {
            this.Close();
            Info info = new Info();
            info.Show();
        }

        private void Nope_Click(object sender, EventArgs e)
        {
            this.Close();
            Kabin1 kabin1 = new Kabin1();
            kabin1.Show();
        }
    }
}
