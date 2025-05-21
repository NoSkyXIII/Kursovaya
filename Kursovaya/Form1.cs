using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            UpdateControlPositions(); // Центрирование при загрузке
        }

        private void UpdateControlPositions()
        {
            // Центрирование label1
            label1.Location = new Point((ClientSize.Width - label1.Width) / 2, 80);

            // Центрирование кнопок
            goTo.Location = new Point((ClientSize.Width - goTo.Width) / 2, 180);
            outMed.Location = new Point((ClientSize.Width - outMed.Width) / 2, 250);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Пустой обработчик, можно добавить логику загрузки
        }

        private void goTo_Click(object sender, EventArgs e)
        {
            // Логика для кнопки "Далее" (например, переход к Kabin1)
            new Kabin1().Show();
            this.Hide();
        }

        private void outMed_Click(object sender, EventArgs e)
        {
            // Логика для кнопки "Выход"
            Application.Exit();
        }

        private void goTo_MouseEnter(object sender, EventArgs e)
        {
            goTo.BackColor = Color.FromArgb(30, 144, 255); // Светлее при наведении
        }

        private void goTo_MouseLeave(object sender, EventArgs e)
        {
            goTo.BackColor = Color.FromArgb(0, 120, 215); // Исходный цвет
        }

        private void outMed_MouseEnter(object sender, EventArgs e)
        {
            outMed.BackColor = Color.FromArgb(255, 77, 77); // Светлее при наведении
        }

        private void outMed_MouseLeave(object sender, EventArgs e)
        {
            outMed.BackColor = Color.FromArgb(220, 53, 69); // Исходный цвет
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            UpdateControlPositions(); // Обновление позиций при изменении размера
        }
    }
}