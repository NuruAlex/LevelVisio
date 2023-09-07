using FilesDataBase.Main;
using FilesDataBase.Objects;
using System.Windows.Forms;

namespace LevelVisio.Forms.SettingsForms
{
    public partial class AlarmSettingsForm : Form
    {
        private Building _building;

        private string ConvertToString(bool value)
        {
            if (value)
                return "On";
            else return "Off";
        }
        public bool ConvertToBool(string value) => value == "On";

        public AlarmSettingsForm(Building building)
        {
            InitializeComponent();
            _building = building;
            AlarmTime.Text = _building.AlarmSettings.AlarmTime.ToString();
            IsPlaySound.Text = ConvertToString(_building.AlarmSettings.IsPlaySound);
            IsRipleImage.Text = ConvertToString(_building.AlarmSettings.IsRipleImage);
        }
        private AlarmSettings BuildSettings() => new AlarmSettings
        {
            AlarmTime = int.Parse(AlarmTime.Text),
            IsPlaySound = ConvertToBool(IsPlaySound.Text),
            IsRipleImage = ConvertToBool(IsRipleImage.Text)
        };

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            int result;
            if (!int.TryParse(AlarmTime.Text, out result) || IsPlaySound.SelectedIndex == -1 || IsRipleImage.SelectedIndex == -1)
            {
                MessageBox.Show("Некорректные данные");
                return;
            }
            _building.AlarmSettings = BuildSettings();
            DataBase.Buildings.Update(i => i.Title == _building.Title, _building);
            Hide();
        }

        private void ExitButton_Click(object sender, System.EventArgs e) => Hide();
    }
}
