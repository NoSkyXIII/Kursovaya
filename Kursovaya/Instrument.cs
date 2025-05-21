using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kursovaya
{
    public class Instrument
    {
        public PictureBox PictureBox { get; private set; }
        public Label Description { get; private set; }
        public bool IsFixed { get; set; }

        public Instrument(string imagePath, string description, int x, int y, int size)
        {
            PictureBox = new PictureBox
            {
                Size = new Size(size, size),
                Location = new Point(x, y),
                SizeMode = PictureBoxSizeMode.Zoom,
                TabStop = false,
                Anchor = AnchorStyles.None // Отключаем анкоры для точного позиционирования
            };

            Description = new Label
            {
                Text = description,
                AutoSize = true,
                Visible = false,
                BackColor = Color.FromArgb(200, 0, 0, 0), // Полупрозрачный черный фон
                ForeColor = Color.White, // Белый текст
                Padding = new Padding(5),
                MaximumSize = new Size(size, 0) // Ограничение ширины текста
            };

            // Попытка загрузки изображения
            try
            {
                PictureBox.Image = Image.FromFile(imagePath);
            }
            catch
            {
                PictureBox.Image = BlackSquareGenerator.CreateBlackSquare(size);
            }
        }

        public void UpdateDescriptionPosition(Point containerOffset)
        {
            // Позиционируем Description относительно формы, учитывая SupIns
            Description.Location = new Point(
                PictureBox.Location.X + containerOffset.X,
                PictureBox.Location.Y + containerOffset.Y - Description.Height - 5 // Текст над PictureBox
            );
            Description.BringToFront(); // Гарантирует, что текст поверх всех объектов
        }

        public void AddToContainer(Control container, Control form)
        {
            container.Controls.Add(PictureBox); // PictureBox в SupIns
            form.Controls.Add(Description); // Description на уровень формы
            PictureBox.SendToBack(); // Изображение инструмента на задний план в SupIns
            Description.BringToFront(); // Текст поверх всех объектов
        }

        public void SetupEvents(int index, Action<int> onClick, Action<int> onMouseHover, Action<int> onMouseLeave)
        {
            PictureBox.MouseHover += (sender, e) =>
            {
                onMouseHover(index);
                Description.BringToFront(); // Текст поверх всех объектов при наведении
            };
            PictureBox.MouseLeave += (sender, e) => onMouseLeave(index);
            PictureBox.Click += (sender, e) =>
            {
                onClick(index);
                Description.BringToFront(); // Текст поверх всех объектов при клике
            };
        }
    }
}