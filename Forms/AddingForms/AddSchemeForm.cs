using FilesDataBase.DrawingData;
using FilesDataBase.Main;
using FilesDataBase.Objects;
using LevelVisio.Forms.SettingsForms;
using LevelVisio.Painting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LevelVisio.Forms.AddingForms
{
    public partial class AddSchemeForm : Form
    {
        private PaintingStage _currentPaintingStage = PaintingStage.Start;
        private PaintingStage _was;
        private FireDetector _previous;
        private Building _building;
        private FireDetector _currentDetector = null;
        private TreeNode _detectorNode;
        private int _SelectedId;
        private int _selectedPointIndex = byte.MaxValue;
        private bool _paint = false;
        private bool _pointCaptured = false;

        #region Inizialization

        public void InitializeChannels(FireDetector detector)
        {
            detector.Channels = new List<Channel>();
            ChannelsComboBox.Items.Clear();

            for (int i = 1; i < detector.ChannelAmount + 1; ++i)
            {
                Channel ch = new Channel
                {
                    DrawingData = new ChannelDrawingData(),
                    Id = i,
                    DetectorTitle = detector.Title
                };
                ch.DrawingData.Points = new List<Position>();

                ch.DrawingData.PaintingSettings = new ChannelPaintingSettings
                {
                    LineColor = Palette.GetRandomColor(),
                };
                detector.Channels.Add(ch);
                ChannelsComboBox.Items.Add(ch.Id);
            }
        }

        private void ShowDetectors()
        {
            foreach (FireDetector detector in DataBase.Detectors.AsList)
                if (detector.IsEnabled)
                    detectors.Items.Add(detector.Title);
        }

        private void ShowRealSize()
        {
            realLenght.Text = _building.Width.ToString() + "м";
            realWidth.RotatedText = _building.Height.ToString() + "м";
            realWidth1.RotatedText = _building.Height.ToString() + "м";
        }

        private void InitalizePictureData()
        {
            if (_building.Original != null)
            {
                Scheme.Image = PaintingField.ScaleImage(_building.Original, Scheme.Size);
                PaintingField.CellSize = Geometry.CountCellSize(Scheme.Image.Size, _building.Width, _building.Height);
                PaintingField.DrawAll(_building.Detectors, true);
                return;
            }
            _building.Scheme = PaintingField.ScaleImage(_building.Scheme, Scheme.Size);
            _building.Original = new Bitmap(_building.Scheme, _building.Scheme.Size);
            Scheme.Image = PaintingField.ScaleImage(_building.Original, Scheme.Size);
            PaintingField.CellSize = Geometry.CountCellSize(Scheme.Image.Size, _building.Width, _building.Height);

        }

        private void UpdateScheme(bool withCorrection)
        {
            Scheme.Image = PaintingField.ScaleImage(_building.Original, Scheme.Size);
            PaintingField.DrawAll(_building.Detectors, withCorrection);
        }

        private void UpdateTree()
        {
            if (_building.Detectors == null)
                return;

            detectorsTree.Nodes.Clear();

            foreach (FireDetector detector in _building.Detectors)
            {
                _detectorNode = detectorsTree.Nodes.Add(detector.Title);
                foreach (Channel channel in detector.Channels)
                    if (channel != null && channel.DrawingData != null && channel.DrawingData.Points.Count > 1)
                        _detectorNode.Nodes.Add("Канал_" + channel.Id.ToString());
            }
            detectorsTree.ExpandAll();
        }

        private void InizializeBuilding(Building b)
        {
            _building = b;

            if (_building.Detectors == null)
                _building.Detectors = new List<FireDetector>();
            if (_building.AlarmSettings == null)
                _building.AlarmSettings = new AlarmSettings();
        }


        public AddSchemeForm(Building b)
        {
            InizializeBuilding(b);
            InitializeComponent();
            InitalizePictureData();
            ShowDetectors();
            ShowRealSize();
            UpdateTree();
            SetStageVisible();
            UIHelper.SetDefaultFormProperties(this);
        }

        #endregion

        #region Paint

 

        private void Scheme_MouseDown(object sender, MouseEventArgs e)
        {
            if (_currentPaintingStage == PaintingStage.ChannelPainting ||
                _currentPaintingStage == PaintingStage.EditDetector ||
                _currentPaintingStage == PaintingStage.EditChannel)
                _paint = true;

            if (_currentPaintingStage == PaintingStage.ChannelPainting)
                _currentDetector.Channels[_SelectedId].DrawingData.Points.Add(Geometry.ConvertToOffsets(e.Location));

        }


        private void Scheme_MouseUp(object sender, MouseEventArgs e)
        {
            if (_currentPaintingStage == PaintingStage.DetectorPlanting)
            {
                PaintingField.StartPoint = Geometry.CountDetectorPosition(e.Location);

                _currentDetector.DrawingData.Position = Geometry.ConvertToOffsets(PaintingField.StartPoint);

                foreach (Channel channel in _currentDetector.Channels)
                    channel.DrawingData.Points.Add(_currentDetector.DrawingData.Position);


                _currentPaintingStage = PaintingStage.ChannelSelection;

            }

            if (_currentPaintingStage == PaintingStage.EditDetector)
                _currentPaintingStage = _was;

            _pointCaptured = false;
            _paint = false;


            UpdateAll();
        }

        private void UpdateAll()
        {
            UpdateTree();
            UpdateScheme(true);
            PaintingField.ScaledImage = Scheme.Image;
            SetStageVisible();
        }

        private void Scheme_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = e.Location;
            point.X -= PaintingField.SchemeStartPosition.X;
            point.Y -= PaintingField.SchemeStartPosition.Y;

            if (_currentPaintingStage == PaintingStage.DetectorPlanting)
                _currentDetector.DrawingData.Position = Geometry.ConvertToOffsets(point);


            if (_currentPaintingStage == PaintingStage.ChannelPainting && _paint)
            {
                Channel channel = _currentDetector.Channels[_SelectedId];

                channel.DrawingData.Points[channel.DrawingData.Points.Count - 1] = Geometry.ConvertToOffsets(point);
            }

            if (_currentPaintingStage == PaintingStage.EditDetector && _paint)
                PaintingField.ChangeDetectorPosition(_currentDetector, point);

            if (_currentPaintingStage == PaintingStage.EditChannel && _paint)
            {
                Channel channel = _currentDetector.Channels[_SelectedId];

                if (_pointCaptured)
                {
                    channel.DrawingData.Points[_selectedPointIndex] = Geometry.ConvertToOffsets(point);

                    if (_selectedPointIndex == channel.DrawingData.Points.Count - 1)
                        PaintingField.StartPoint = point;
                    return;
                }

                _selectedPointIndex = Geometry.FindNearestChannelPointIndex(point, channel);

                if (_selectedPointIndex != 0)// if not first
                    _pointCaptured = true;
            }
            Scheme.Refresh();
        }

        private void Scheme_Paint(object sender, PaintEventArgs e) => UpdateScheme(false);

        #endregion

        #region ClicksAndSelecting

        private void SetStageVisible() => SetStageVisible(_currentPaintingStage);
        private void SetStageVisible(PaintingStage stage)
        {
            _currentPaintingStage = stage;

            switch (_currentPaintingStage)
            {
                case PaintingStage.Start:
                    Cancel.Visible = false;
                    EndEditButton.Visible = false;
                    SetDetector.Visible = true;
                    detectorsLabel.Visible = false;
                    detectors.Visible = false;
                    break;
                case PaintingStage.DetectorSelection://

                    detectorsLabel.Visible = true;
                    detectors.Visible = true;
                    SetDetector.Visible = false;
                    SaveButton.Enabled = false;
                    endPaintChannel.Visible = false;
                    EndEditButton.Visible = false;
                    EditButton.Visible = true;
                    Cancel.Visible = true;
                    break;

                case PaintingStage.DetectorPlanting:
                    detectorsLabel.Visible = false;
                    detectors.Visible = false;
                    Cancel.Visible = false;
                    break;

                case PaintingStage.ChannelSelection:
                    channelsHint.Visible = true;
                    ChannelsComboBox.Visible = true;
                    endPaintChannel.Visible = false;
                    break;

                case PaintingStage.ChannelPainting:
                    channelsHint.Visible = false;
                    ChannelsComboBox.Visible = false;
                    endPaintChannel.Visible = true;
                    break;

                case PaintingStage.EndPainting:
                    SaveButton.Enabled = true;
                    SetDetector.Visible = true;
                    endPaintChannel.Visible = false;
                    break;

                case PaintingStage.EditDetector:
                    EndEditButton.Visible = true;
                    EditButton.Visible = false;
                    break;
                case PaintingStage.EditChannel:
                    EndEditButton.Visible = true;
                    EditButton.Visible = false;
                    break;
            }
            hint.Text = UIHelper.GetHintText(_currentPaintingStage);
        }

        private void SelectDetector_Click(object sender, EventArgs e) => SetStageVisible(PaintingStage.DetectorSelection);

        private void Cancel_Click(object sender, EventArgs e) => SetStageVisible(PaintingStage.Start);

        private void Detectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (detectors.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите извещатель");
                return;
            }

            _currentDetector = DataBase.Detectors.Find(i => i.Title == detectors.Text);
            _currentDetector.DrawingData = new DetectorDrawingData
            {
                PaintingSettings = new DetectorPaintingSettings(),
                Position = new Position()
            };

            InitializeChannels(_currentDetector);
            _building.Detectors.Add(_currentDetector);
            detectors.Items.RemoveAt(detectors.SelectedIndex);


            SetStageVisible(PaintingStage.DetectorPlanting);
        }

        private void EndPaintChannel_Click(object sender, EventArgs e)
        {
            if (ChannelsComboBox.Items.Count == 0)
                _currentPaintingStage = PaintingStage.EndPainting;
            else
                _currentPaintingStage = PaintingStage.ChannelSelection;

            if (detectors.Items.Count == 0)
                SetDetector.Enabled = false;

            SetStageVisible();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.Buildings.Find(i => i.Title == _building.Title) != null)
                    DataBase.Buildings.Update(i => i.Title == _building.Title, _building);
                else if (DataBase.Buildings.AsList != null)
                    DataBase.Buildings.Add(_building);

                foreach (FireDetector detector in _building.Detectors)
                    DataBase.Detectors.Update(i => i.Title == detector.Title, detector);

                MessageBox.Show("Изображение сохранено");
                Hide();
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Channels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChannelsComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите канал");
                return;
            }

            _SelectedId = Convert.ToInt32(ChannelsComboBox.SelectedItem.ToString()) - 1;
            PaintingField.StartPoint = Geometry.ConvertToPoint(_currentDetector.DrawingData.Position);

            ChannelsComboBox.Items.RemoveAt(ChannelsComboBox.SelectedIndex);
            SetStageVisible(PaintingStage.ChannelPainting);
        }

        private void DetectorsTree_DoubleClick(object sender, EventArgs e)
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

            UpdateScheme(true);
        }


        #endregion

        #region Editing
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (detectorsTree.SelectedNode == null)
            {
                MessageBox.Show("Выберите объект");
                return;
            }

            _was = _currentPaintingStage;
            SaveButton.Enabled = false;

            if (detectorsTree.SelectedNode.Text.ToLower().Contains("канал_"))   //if channel....
            {
                _currentDetector = _building.Detectors.Find(i => i.Title == detectorsTree.SelectedNode.Parent.Text);
                _SelectedId = _currentDetector.Channels.FindIndex(i => i.Id == Convert.ToInt32(detectorsTree.SelectedNode.Text.Replace("Канал_", "")));
                _currentPaintingStage = PaintingStage.EditChannel;
            }
            else            //if detector...
            {
                _currentDetector = _building.Detectors.Find(i => i.Title == detectorsTree.SelectedNode.Text);
                _currentPaintingStage = PaintingStage.EditDetector;
            }
            SetStageVisible();
        }

        private void EndEditButton_Click(object sender, EventArgs e)
        {
            _currentPaintingStage = _was;
            EditButton.Visible = true;
            EndEditButton.Visible = false;

            if (_currentPaintingStage == PaintingStage.EndPainting || _currentPaintingStage == PaintingStage.Start || _currentPaintingStage == PaintingStage.ChannelSelection)
                SaveButton.Enabled = true;
            SetStageVisible();
        }
        #endregion

    }
}

