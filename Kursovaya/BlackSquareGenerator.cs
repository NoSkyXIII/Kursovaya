using System.Drawing;

namespace Kursovaya
{
    public static class BlackSquareGenerator
    {
        public static Bitmap CreateBlackSquare(int size)
        {
            Bitmap bitmap = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillRectangle(Brushes.Black, 0, 0, size, size);
            }
            return bitmap;
        }
    }
}