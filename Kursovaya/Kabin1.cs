using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Kabin1 : Form
    {
        private Instrument[] instruments;
        private int instrumentCount = 3; // Количество инструментов

        public Kabin1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Инициализация инструментов
            instruments = new Instrument[instrumentCount];
            UpdateInstrumentPositions();

            // Обеспечиваем видимость left1 при старте
            left1.Visible = true;
            right1.Visible = false;

            // Обновление позиций при изменении размера формы или SupIns
            SupIns.SizeChanged += (s, e) => UpdateInstrumentPositions();
            this.SizeChanged += (s, e) => UpdateInstrumentPositions();
            this.Load += (s, e) =>
            {
                Kabinet1.SendToBack(); // Фон на задний план
                left1.BringToFront(); // Кнопки поверх всех объектов
                right1.BringToFront();
            };
        }

        private void UpdateInstrumentPositions()
        {
            int supInsWidth = SupIns.ClientSize.Width;
            int instrumentSize = 100;
            int spacing = Math.Max(10, (supInsWidth - 3 * instrumentSize) / 4); // Равномерное распределение

            // Данные инструментов
            (string path, string description)[] toolData = new[]
            {
                ("C:/Users/nosky/Desktop/CrissKursach/pincet.png", "Пинцет: Для захвата и удержания тканей или мелких объектов"),
                ("C:/Users/nosky/Desktop/CrissKursach/pngwing.com.png", "Зажим: Для временного пережатия сосудов или тканей"),
                ("C:/Users/nosky/Desktop/CrissKursach/skalpel.png", "Скальпель: Для точных разрезов тканей")
            };

            for (int i = 0; i < 3; i++)
            {
                int x = spacing + i * (instrumentSize + spacing);
                if (instruments[i] == null)
                {
                    instruments[i] = new Instrument(toolData[i].path, toolData[i].description, x, 10, instrumentSize);
                    instruments[i].AddToContainer(SupIns, this); // Передаем форму для Description
                    instruments[i].SetupEvents(i,
                        index => // Click
                        {
                            instruments[index].IsFixed = !instruments[index].IsFixed;
                            instruments[index].Description.Visible = instruments[index].IsFixed;
                            instruments[index].Description.BringToFront(); // Текст поверх всех объектов
                            left1.BringToFront(); // Кнопки остаются кликабельными
                            right1.BringToFront();
                        },
                        index => // MouseHover
                        {
                            instruments[index].Description.Visible = true;
                            instruments[index].UpdateDescriptionPosition(SupIns.Location); // Обновляем позицию
                            instruments[index].Description.BringToFront(); // Текст поверх всех объектов
                            left1.BringToFront(); // Кнопки остаются кликабельными
                            right1.BringToFront();
                        },
                        index => // MouseLeave
                        {
                            if (!instruments[index].IsFixed)
                            {
                                instruments[index].Description.Visible = false;
                            }
                        });
                    instruments[i].UpdateDescriptionPosition(SupIns.Location); // Устанавливаем начальную позицию
                }
                else
                {
                    instruments[i].PictureBox.Location = new Point(x, 10);
                    instruments[i].UpdateDescriptionPosition(SupIns.Location); // Обновляем позицию с учетом SupIns
                }
            }
        }

        private void left1_Click(object sender, EventArgs e)
        {
            try
            {
                Kabinet1.Image = Image.FromFile("C:/Users/nosky/Desktop/CrissKursach/hirurgi-na-pacienta-obsuzdaut-rentgena-v-komnate-operacii.jpg");
                SupIns.Visible = true;
                right1.Visible = true;
                left1.Visible = false;
                UpdateInstrumentPositions(); // Обновление позиций при показе SupIns
                Kabinet1.SendToBack(); // Фон на задний план
                right1.BringToFront(); // Кнопка поверх всех объектов
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void right1_Click(object sender, EventArgs e)
        {
            try
            {
                Kabinet1.Image = Image.FromFile("C:/Users/nosky/Desktop/CrissKursach/vnutrennii-vid-operacionnoi1.jpg");
                right1.Visible = false;
                left1.Visible = true;
                SupIns.Visible = false;

                // Скрытие всех описаний и сброс закрепленных состояний
                for (int i = 0; i < 3; i++)
                {
                    if (instruments[i] != null)
                    {
                        instruments[i].Description.Visible = false;
                        instruments[i].IsFixed = false;
                    }
                }
                Kabinet1.SendToBack(); // Фон на задний план
                left1.BringToFront(); // Кнопка поверх всех объектов
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void right1_MouseHover(object sender, EventArgs e)
        {
            right1.BackColor = Color.FromArgb(60, 187, 89); // Светлее при наведении
        }

        private void right1_MouseLeave(object sender, EventArgs e)
        {
            right1.BackColor = Color.Transparent; // Исходный прозрачный фон
        }

        private void left1_MouseHover(object sender, EventArgs e)
        {
            left1.BackColor = Color.FromArgb(60, 187, 89); // Светлее при наведении
        }

        private void left1_MouseLeave(object sender, EventArgs e)
        {
            left1.BackColor = Color.Transparent; // Исходный прозрачный фон
        }
    }
}