using FilesDataBase.Main;
using FilesDataBase.Objects;
using LevelVisio.Painting;
using System;
using System.Windows.Forms;

namespace LevelVisio.Forms.AddingForms
{
    public partial class AddingDetectorForm : Form
    {
        private bool IsValidData()
        {
            if (Ip.Text == "" || Port.Text == "" || Title.Text == "" || ChannelAmount.Text == "")
            {
                MessageBox.Show("Все данные должны быть введены");
                return false;
            }
            return true;
        }
        private bool _isEnabled;
        public AddingDetectorForm()
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);
            Text = $"LevelVisio - Добавление извещателя";
            Title.Enabled = true;
            _isEnabled = true;
            SaveChanges.Visible = false;
            AddDetector.Visible = true;
            Ip.Text = "192.168.0.100";
            Port.Text = "502";
        }

        public AddingDetectorForm(FireDetector fireDetector)
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);
            Text = $"LevelVisio - Изменение извещателя";
            //TextBoxes
            _isEnabled = fireDetector.IsEnabled;

            if (!fireDetector.IsEnabled)
                ChannelAmount.Enabled = false;

            Ip.Text = fireDetector.Ip;
            Port.Text = fireDetector.Port.ToString();
            Title.Text = fireDetector.Title;
            ChannelAmount.Text = fireDetector.ChannelAmount.ToString();
            Title.Enabled = false;
            //buttons
            SaveChanges.Visible = true;
            AddDetector.Visible = false;
        }

        private FireDetector BuildDetector() => new FireDetector()
        {
            Ip = Ip.Text,
            Port = (ushort)Convert.ToInt32(Port.Text),
            Title = Title.Text,
            ChannelAmount = Convert.ToInt32(ChannelAmount.Text),
            IsEnabled = _isEnabled
        };


        private void AddDetector_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
                return;
            DataBase.Detectors.Add(BuildDetector());

            Hide();
        }
        private void RefuceButton_Click(object sender, EventArgs e) => Hide();

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
                return;

            DataBase.Detectors.Update(i => i.Title == Title.Text, BuildDetector());
            Hide();
        }

        private void RetreiveIP_Click(object sender, EventArgs e)
        {
            if (Title.Enabled && DataBase.Detectors.AsList != null)
                Title.Text = "LevelVisio_" + DataBase.Detectors.Count.ToString();

            ChannelAmount.Text = new Random().Next(1, 4).ToString();
        }
    }
}
