using FilesDataBase.DrawingData;
using FilesDataBase.Objects;
using LevelVisio.Painting;
using System.Windows.Forms;

namespace LevelVisio.Forms.SettingsForms
{
    public partial class DetectorPaintingSettingForm : Form
    {
        FireDetector _detector;
        public Building Building;
        public DetectorPaintingSettingForm(Building b, FireDetector detector)
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);

            Building = b;
            _detector = detector;

            Title.Text += $" {detector.Title}";
            ChangeColor.BackColor = detector.DrawingData.PaintingSettings.Color;
            Radius.Text = detector.DrawingData.PaintingSettings.Radius.ToString();
            button1.Text = UIHelper.GetTextBySigningType(detector.DrawingData.PaintingSettings.SigningType);
        }

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

        private DetectorPaintingSettings BuildSettings() => new DetectorPaintingSettings
        {
            Color = ChangeColor.BackColor,
            Radius = int.Parse(Radius.Text),
            SigningType = SigningTypeForm.SigningType
        };

        private void Save_Click(object sender, System.EventArgs e)
        {
            int rad;
            if (Radius.Text == "" || !int.TryParse(Radius.Text, out rad))
            {
                MessageBox.Show("Радиус некорректен");
                return;
            }
            _detector.DrawingData.PaintingSettings = BuildSettings();
            Building.Detectors[Building.Detectors.FindIndex(i => i.Title == _detector.Title)] = _detector;
            Hide();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            new SigningTypeForm().ShowDialog();
            button1.Text = SigningTypeForm.SigningTypeText;
        }


    }
}
