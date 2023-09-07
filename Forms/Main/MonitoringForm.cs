using FilesDataBase.Main;
using FilesDataBase.Objects;
using LevelVisio.Forms.SettingsForms;
using LevelVisio.Painting;
using ModBus;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace LevelVisio.Forms.MainForms
{
    public partial class MonitoringForm : Form
    {
        private Building _building;
        private Alert _alert = new Alert(null);
        private SoundPlayer _player;
        private List<Point> _meters = new List<Point>();
        private List<Master> _servers = new List<Master>();

        public void InitializeConnection()
        {
            foreach (FireDetector detector in _building.Detectors)
                _servers.Add(new Master(detector));

            foreach (Master master in _servers)
            {
                master.OnException += MBmaster_OnException;
                master.OnResponseData += MBmaster_OnResponseData;
            }
            _player = new SoundPlayer("Resources\\Alarm.wav");
            timer1.Interval = 100;
            timer1.Start();
        }

        private void InitializeScheme()
        {
            Scheme.Image = PaintingField.ScaleImage(_building.Original, Scheme.Size);
            PaintingField.CellSize = Geometry.CountCellSize(PaintingField.ScaledImage.Size, _building.Width, _building.Height);
            PaintingField.DrawAll(_building.Detectors, true);


            _meters = PaintingField.MarkUpChannel(_building.Detectors[0].Channels[0]);
        }
        private void UpdateScheme(bool withCorrection)
        {
            Scheme.Image = PaintingField.ScaleImage(_building.Original, Scheme.Size);
            PaintingField.DrawAll(_building.Detectors, withCorrection);
        }
        private void InizializeTree()
        {
            detectorsTree.Nodes.Clear();

            foreach (FireDetector detector in _building.Detectors)
            {
                TreeNode d = detectorsTree.Nodes.Add(detector.Title);

                foreach (Channel channel in detector.Channels)
                    d.Nodes.Add("Канал_" + channel.Id.ToString());
            }

            detectorsTree.ExpandAll();
        }
        public void InitializeAll()
        {
            InitializeScheme();
            InitializeConnection();
            InizializeTree();
        }

        public MonitoringForm(Building building)
        {
            _building = building;
            InitializeComponent();
            InitializeAll();
            UIHelper.SetDefaultFormProperties(this);
            UIHelper.WriteCurrentStaff(this);
            groupBox3.Visible = false;

            foreach (Building b in DataBase.Buildings.AsList)
                buildingsComboBox.Items.Add(b.Title);

        }
        public MonitoringForm()
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);
            UIHelper.WriteCurrentStaff(this);

            groupBox3.Visible = false;

            foreach (Building b in DataBase.Buildings.AsList)
                buildingsComboBox.Items.Add(b.Title);
        }

        #region Monitoring
        private void MBmaster_OnException(byte exception)
        {
            timer1.Stop();
            string exc = "";

            switch (exception)
            {
                case (byte)ModBusExceptions.ExceptionConnectionLost: exc = "Соединени прервано!"; break;
            }

            MessageBox.Show(exc, "К сожалению произошла ошибка");
            Hide();
        }
        private void MBmaster_OnResponseData(ushort ID, byte unit, byte function, byte[] values)
        {
            timer1.Stop();
            // ------------------------------------------------------------------
            // Seperate calling threads
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Master.ResponseData(MBmaster_OnResponseData), new object[] { ID, unit, function, values });
                return;
            }

            ModBusFrame frame;
            // ------------------------------------------------------------------------
            // Identify requested data
            switch (ID)
            {
                case 1:
                    frame = new ModBusFrame(values);
                    break;
                case 2:
                    frame = new ModBusFrame(values);
                    break;
                case 3:
                    frame = new ModBusFrame(values);
                    break;
                case 4:
                    frame = new ModBusFrame(values);
                    break;
                default:
                    frame = new ModBusFrame();
                    break;
            }

            _alert = new Alert(frame);

            if (_alert.IsAlarm && _building.AlarmSettings.IsPlaySound)
            {
                groupBox3.Visible = true;
                _player.Play();
            }

            label1.Text = _alert.Message;
            timer1.Start();
        }



        private void RippleImage(Point position)
        {
            if (counter % 2 == 0 || counter == _building.AlarmSettings.AlarmTime)
                DrawAlarm(position);
            else if (_building.AlarmSettings.IsRipleImage)
                UpdateScheme(true);
        }

        private void DrawAlarm(Point position)
        {
            int radius = 15;
            Point labelPoint = new Point(position.X - 10, position.Y + radius);
            string message = $"{_alert.Position} м ";
            using (Graphics g = Graphics.FromImage(Scheme.Image))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.FillEllipse(Brushes.Red, position.X - radius / 2, position.Y - radius, radius, radius);
                g.DrawString(message, new Font("Calibry", 13f), Brushes.Red, labelPoint);
            }
            Scheme.Refresh();
        }

        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!_alert.IsAlarm)
            {
                timer1.Interval = 100;
                ReadHoldinRegisters(sender, e);
            }
            if (_alert.IsAlarm)
            {
                timer1.Interval = 1000;

                if (counter <= _building.AlarmSettings.AlarmTime)
                {
                    try
                    {
                        RippleImage(_meters[Convert.ToInt32(_alert.Position - 2)]);
                    }
                    catch
                    {
                        timer1.Stop();
                        MessageBox.Show("Кажется вы недорисовали кабель, нарушение за границей кабеля \n Вам необходимо перерисовать схему");
                    }
                }
            }
            counter++;

            if (counter > _building.AlarmSettings.AlarmTime)
            {
                counter = 0;
                _alert = new Alert(null);
            }
        }

        private void ReadHoldinRegisters(object sender, EventArgs e)
        {
            ushort ID = 3;
            byte unit = Convert.ToByte(1);
            ushort StartAddress = 0;
            UInt16 Length = 100;
            foreach (Master master in _servers)
                master.ReadHoldingRegister(ID, unit, StartAddress, Length);
        }
        #endregion

        private void StopAlarmButton_Click(object sender, EventArgs e) => _player.Stop();
        private void buildingsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buildingsComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите объект");
                return;
            }

            _building = DataBase.Buildings[buildingsComboBox.SelectedIndex];

            InitializeAll();
        }

        private void detectorsTree_DoubleClick(object sender, EventArgs e)
        {
            if (detectorsTree.SelectedNode == null)
            {
                MessageBox.Show("Выберите объект");
                return;
            }


            //if channel....
            if (detectorsTree.SelectedNode.Text.ToLower().Contains("канал_"))
            {
                FireDetector detectorParent = _building.Detectors.Find(i => i.Title == detectorsTree.SelectedNode.Parent.Text);
                string text = detectorsTree.SelectedNode.Text.Replace("Канал_", "");
                int id = Convert.ToInt32(text);

                Channel ch = detectorParent.Channels.Find(i => i.Id == id);
                if (ch != null)
                {
                    var form = new ChannelPaintingSettingsForm(_building, detectorParent, ch);
                    form.ShowDialog();
                    _building = form.Building;
                }
            }
            else            //if detector...
            {
                FireDetector detector = _building.Detectors.Find(i => i.Title == detectorsTree.SelectedNode.Text);

                if (detector != null)
                {
                    var form = new DetectorPaintingSettingForm(_building, detector);
                    form.ShowDialog();
                    _building = form.Building;
                }
            }

            DataBase.Buildings.Update(i => i.Title == _building.Title, _building);
            InitializeScheme();
        }

        private void AlarmSettingsButton_Click(object sender, EventArgs e) => new AlarmSettingsForm(_building).ShowDialog();

        private void MonitoringForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_player != null)
            {
                _player.Stop();
                _player.Dispose();
            }

            if (_servers.Count > 0)
                foreach (Master master in _servers)
                    master.Dispose();
        }
    }
}
