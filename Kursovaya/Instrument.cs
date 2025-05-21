using System.Drawing;
using System.Windows.Forms;
using System;

namespace Kursovaya
{
    public class Instrument
    {
        public PictureBox PictureBox { get; private set; }
        public Label Description { get; private set; }
        public bool IsFixed { get; set; }
        private readonly int verticalOffset;

        public Instrument(
            string imagePath,
            string description,
            int x,
            int y,
            int size,
            Color backColor,
            Color foreColor,
            Font font,
            Padding padding,
            int verticalOffset,
            int maxWidth)
        {
            this.verticalOffset = verticalOffset;

            PictureBox = new PictureBox
            {
                Size = new Size(size, size),
                Location = new Point(x, y),
                SizeMode = PictureBoxSizeMode.Zoom,
                TabStop = false,
                Anchor = AnchorStyles.None
            };

            Description = new Label
            {
                Text = description,
                AutoSize = true,
                Visible = false,
                BackColor = backColor,
                ForeColor = foreColor,
                Font = font,
                Padding = padding,
                MaximumSize = new Size(maxWidth, 0)
            };

            try { PictureBox.Image = Image.FromFile(imagePath); }
            catch { PictureBox.Image = CreateBlackSquare(size); }
        }

        private Image CreateBlackSquare(int size)
        {
            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);
            }
            return bmp;
        }

        public void UpdateDescriptionPosition(Point containerOffset)
        {
            Description.Location = new Point(
                PictureBox.Location.X + containerOffset.X,
                PictureBox.Location.Y + containerOffset.Y - Description.Height - verticalOffset
            );
            Description.BringToFront();
        }

        public void AddToContainer(Control container, Control form)
        {
            container.Controls.Add(PictureBox);
            form.Controls.Add(Description);
            PictureBox.SendToBack();
            Description.BringToFront();
        }

        public void SetupEvents(int index, Action<int> onClick, Action<int> onMouseHover, Action<int> onMouseLeave)
        {
            PictureBox.MouseHover += (s, e) => {
                onMouseHover(index);
                Description.BringToFront();
            };
            PictureBox.MouseLeave += (s, e) => onMouseLeave(index);
            PictureBox.Click += (s, e) => {
                onClick(index);
                Description.BringToFront();
            };
        }
    }
}