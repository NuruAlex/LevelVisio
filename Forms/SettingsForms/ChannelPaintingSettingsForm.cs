using FilesDataBase.DrawingData;
using FilesDataBase.Objects;
using LevelVisio.Painting;
using System.Windows.Forms;

namespace LevelVisio.Forms.SettingsForms
{
    public partial class ChannelPaintingSettingsForm : Form
    {
        public Building Building;
        FireDetector _fireDetector;
        Channel _channel;

        public ChannelPaintingSettingsForm(Building building, FireDetector fireDetector, Channel channel)
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);
            Building = building;
            _fireDetector = fireDetector;
            _channel = channel;

            Text = "LevelVisio - Настройка отображения";

            Title.Text += $"Канал {_channel.Id}";
            ChangeColor.BackColor = _channel.DrawingData.PaintingSettings.LineColor;
            Radius.Text = _channel.DrawingData.PaintingSettings.LineWidth.ToString();
        }
        private ChannelPaintingSettings BuildSettings() => new ChannelPaintingSettings
        {
            LineColor = ChangeColor.BackColor,
            LineWidth = int.Parse(Radius.Text),
        };

        private void ChangeColor_Click(object sender, System.EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                dialog.AllowFullOpen = true;
                dialog.SolidColorOnly = true;

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Ошибка выбора цвета");
                    return;
                }
                ChangeColor.BackColor = dialog.Color;
            }
        }

        private void ExitButton_Click(object sender, System.EventArgs e) => Hide();

        private void Save_Click(object sender, System.EventArgs e)
        {
            int rad;
            if (Radius.Text == "" || !int.TryParse(Radius.Text, out rad))
            {
                MessageBox.Show("Радиус некорректен");
                return;
            }
            _channel.DrawingData.PaintingSettings = BuildSettings();
            _fireDetector.Channels[_fireDetector.Channels.FindIndex(i => i.Id == _channel.Id)] = _channel;
            Building.Detectors[Building.Detectors.FindIndex(i => i.Title == _fireDetector.Title)] = _fireDetector;
            Hide();
        }
    }
}
