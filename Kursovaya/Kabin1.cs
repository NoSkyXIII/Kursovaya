using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Kabin1 : Form
    {
        // Конфигурационные константы
        private const int INSTRUMENT_COUNT = 4;
        private const int INSTRUMENT_SIZE = 150;
        private const int TOP_MARGIN = 10;
        private const int MIN_SPACING = 10;
        private const int SPACING_MULTIPLIER = 4;
        private readonly Color HOVER_COLOR = Color.FromArgb(60, 187, 89);
        private readonly Color DEFAULT_BUTTON_COLOR = Color.Transparent;

        // Настройки описания инструментов
        private static readonly Color DESCRIPTION_BACK_COLOR = Color.FromArgb(200, 0, 0, 0);
        private static readonly Color DESCRIPTION_FORE_COLOR = Color.White;
        private static readonly Font DESCRIPTION_FONT = new Font("Arial", 20, FontStyle.Regular);
        private static readonly Padding DESCRIPTION_PADDING = new Padding(5);
        private const int DESCRIPTION_VERTICAL_OFFSET = 5;
        private const int DESCRIPTION_MAX_WIDTH = 150;

        // Пути к изображениям
        private readonly string BACKGROUND_IMAGE_1 = "C:\\Users\\nosky\\source\\repos\\Krit88888\\Kursovaya\\Photos\\hirurgi-na-pacienta-obsuzdaut-rentgena-v-komnate-operacii.jpg";
        private readonly string BACKGROUND_IMAGE_2 = "C:\\Users\\nosky\\source\\repos\\Krit88888\\Kursovaya\\Photos\\vnutrennii-vid-operacionnoi1.jpg";
        private readonly string[] TOOL_PATHS =
        {
            "C:\\Users\\nosky\\source\\repos\\Krit88888\\Kursovaya\\Photos\\pincet.png",
            "C:\\Users\\nosky\\source\\repos\\Krit88888\\Kursovaya\\Photos\\pngwing.com.png",
            "C:\\Users\\nosky\\source\\repos\\Krit88888\\Kursovaya\\Photos\\skalpel.png"
        };

        private readonly string[] TOOL_DESCRIPTIONS =
        {
            "Пинцет: Для захвата и удержания тканей или мелких объектов",
            "Зажим: Для временного пережатия сосудов или тканей",
            "Скальпель: Для точных разрезов тканей"
        };

        private Instrument[] instruments;

        public Kabin1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            instruments = new Instrument[INSTRUMENT_COUNT];
            UpdateInstrumentPositions();

            left1.Visible = true;
            right1.Visible = false;

            SupIns.SizeChanged += (s, e) => UpdateInstrumentPositions();
            this.SizeChanged += (s, e) => UpdateInstrumentPositions();
            this.Load += (s, e) =>
            {
                Kabinet1.SendToBack();
                left1.BringToFront();
                right1.BringToFront();
            };
        }

        private void UpdateInstrumentPositions()
        {
            int supInsWidth = SupIns.ClientSize.Width;
            int spacing = Math.Max(MIN_SPACING, (supInsWidth - INSTRUMENT_COUNT * INSTRUMENT_SIZE) / (INSTRUMENT_COUNT + 1));

            if (instruments == null || instruments.Length != INSTRUMENT_COUNT)
            {
                if (instruments != null)
                {
                    foreach (var instrument in instruments)
                    {
                        instrument?.PictureBox.Dispose();
                        instrument?.Description.Dispose();
                    }
                }
                instruments = new Instrument[INSTRUMENT_COUNT];
            }

            for (int i = 0; i < INSTRUMENT_COUNT; i++)
            {
                int x = spacing + i * (INSTRUMENT_SIZE + spacing);
                string toolPath = i < TOOL_PATHS.Length ? TOOL_PATHS[i] : "";
                string toolDesc = i < TOOL_DESCRIPTIONS.Length ? TOOL_DESCRIPTIONS[i] : "";

                if (instruments[i] == null)
                {
                    instruments[i] = new Instrument(
                        toolPath,
                        toolDesc,
                        x,
                        TOP_MARGIN,
                        INSTRUMENT_SIZE,
                        DESCRIPTION_BACK_COLOR,
                        DESCRIPTION_FORE_COLOR,
                        DESCRIPTION_FONT,
                        DESCRIPTION_PADDING,
                        DESCRIPTION_VERTICAL_OFFSET,
                        DESCRIPTION_MAX_WIDTH
                    );

                    instruments[i].AddToContainer(SupIns, this);
                    instruments[i].SetupEvents(
                        i,
                        index => HandleInstrumentClick(index),
                        index => HandleInstrumentHover(index),
                        index => HandleInstrumentLeave(index)
                    );
                    instruments[i].UpdateDescriptionPosition(SupIns.Location);
                }
                else
                {
                    instruments[i].PictureBox.Location = new Point(x, TOP_MARGIN);
                    instruments[i].UpdateDescriptionPosition(SupIns.Location);
                }
            }
        }

        private void HandleInstrumentClick(int index)
        {
            instruments[index].IsFixed = !instruments[index].IsFixed;
            instruments[index].Description.Visible = instruments[index].IsFixed;
            instruments[index].Description.BringToFront();
            left1.BringToFront();
            right1.BringToFront();
        }

        private void HandleInstrumentHover(int index)
        {
            instruments[index].Description.Visible = true;
            instruments[index].UpdateDescriptionPosition(SupIns.Location);
            instruments[index].Description.BringToFront();
            left1.BringToFront();
            right1.BringToFront();
        }

        private void HandleInstrumentLeave(int index)
        {
            if (!instruments[index].IsFixed)
            {
                instruments[index].Description.Visible = false;
            }
        }

        private void left1_Click(object sender, EventArgs e)
        {
            try
            {
                Kabinet1.Image = Image.FromFile(BACKGROUND_IMAGE_1);
                SupIns.Visible = true;
                right1.Visible = true;
                left1.Visible = false;
                UpdateInstrumentPositions();
                Kabinet1.SendToBack();
                right1.BringToFront();
            }
            catch (Exception ex)
            {
                ShowErrorDialog($"Ошибка загрузки изображения: {ex.Message}");
            }
        }

        private void right1_Click(object sender, EventArgs e)
        {
            try
            {
                Kabinet1.Image = Image.FromFile(BACKGROUND_IMAGE_2);
                right1.Visible = false;
                left1.Visible = true;
                SupIns.Visible = false;

                for (int i = 0; i < INSTRUMENT_COUNT; i++)
                {
                    if (instruments[i] != null)
                    {
                        instruments[i].Description.Visible = false;
                        instruments[i].IsFixed = false;
                    }
                }
                Kabinet1.SendToBack();
                left1.BringToFront();
            }
            catch (Exception ex)
            {
                ShowErrorDialog($"Ошибка загрузки изображения: {ex.Message}");
            }
        }

        private void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            (sender as Control).BackColor = HOVER_COLOR;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = DEFAULT_BUTTON_COLOR;
        }

        // Обработчики событий для кнопок
        private void right1_MouseHover(object sender, EventArgs e) => Button_MouseHover(sender, e);
        private void right1_MouseLeave(object sender, EventArgs e) => Button_MouseLeave(sender, e);
        private void left1_MouseHover(object sender, EventArgs e) => Button_MouseHover(sender, e);
        private void left1_MouseLeave(object sender, EventArgs e) => Button_MouseLeave(sender, e);
    }
}