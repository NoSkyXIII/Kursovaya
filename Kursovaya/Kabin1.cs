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
    public partial class Kabin1 : Form
    {
        public Kabin1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void right1_Click(object sender, EventArgs e)
        {
            Kabinet1.Image = Image.FromFile("C:/Users/Admin/Desktop/картинки курсовой/vnutrennii-vid-operacionnoi1.jpg");
            right1.Visible = false;
            left1.Visible = true;
            SupIns.Visible = false;
        }

        private void left1_Click(object sender, EventArgs e)
        {
            Kabinet1.Image = Image.FromFile("C:/Users/Admin/Desktop/картинки курсовой/hirurgi-na-pacienta-obsuzdaut-rentgena-v-komnate-operacii.jpg");
            SupIns.Visible = true;
            right1.Visible = true;
            left1.Visible = false;
        }

        private void right1_MouseHover(object sender, EventArgs e)
        {
            right1.BackColor = Color.Red;
        }

        private void left1_MouseHover(object sender, EventArgs e)
        {
            left1.BackColor = Color.Red;
        }

        private void right1_MouseLeave(object sender, EventArgs e)
        {
            right1.BackColor = Color.Turquoise;
        }

        private void left1_MouseLeave(object sender, EventArgs e)
        {
            left1.BackColor = Color.Turquoise;
        }
    }
}
