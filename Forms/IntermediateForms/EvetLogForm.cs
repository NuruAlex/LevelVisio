using FilesDataBase.Main;
using FilesDataBase.Objects;
using LevelVisio.Forms.AddingForms;
using System;
using System.Windows.Forms;

namespace LevelVisio.Forms.IntermediateForms
{
    public partial class EventLogForm : Form
    {
        public EventLogForm()
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);
        }

        private void EvetLogForm_Load(object sender, EventArgs e)
        {
            FormClosed += (s, ev) => Hide();
            ShowAllDetectors();
            ShowAllBuildings();
        }

        #region Detectors

        public bool IsValidSelectedDetector()
        {
            if (DetectorsList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Выберите 1 извещатель");
                return false;
            }
            return true;
        }


        public void ShowAllDetectors() => UIHelper.FillListView(DetectorsList, DataBase.Detectors.AsDataBaseObjectList);





        private void AddDetector_Click(object sender, EventArgs e)
        {
            if (new AddingDetectorForm().ShowDialog() == DialogResult.OK)
                MessageBox.Show("Извещатель добавлен");
            ShowAllDetectors();
        }

        private void ChangeDetectorButton_Click(object sender, EventArgs e)
        {
            if (!IsValidSelectedDetector())
                return;
            int index = DetectorsList.SelectedIndices[0];

            if (new AddingDetectorForm(DataBase.Detectors[DetectorsList.SelectedIndices[0]]).ShowDialog() == DialogResult.OK)
                MessageBox.Show("Извещатель изменен");

            ShowAllDetectors();
        }

        private void DeleteDetectorButton_Click(object sender, EventArgs e)
        {
            if (!IsValidSelectedDetector())
                return;

            int index = DetectorsList.SelectedIndices[0];

            if (!DataBase.Detectors[index].IsEnabled)
            {
                MessageBox.Show("Извещатель занят");
                return;
            }

            if (MessageBox.Show("Действительно ли вы хотите удалить извещатель?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;


            DataBase.Detectors.RemoveAt(index);
            ShowAllDetectors();
            MessageBox.Show("Извещатель удален");
        }

        #endregion

        #region Buildings

        public bool IsValidSelectedBuilding()
        {
            if (BuildingList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Выберите 1 объект");
                return false;
            }
            return true;
        }
        private void ShowAllBuildings() => UIHelper.FillListView(BuildingList, DataBase.Buildings.AsDataBaseObjectList);

        private void AddObject_Click(object sender, EventArgs e)
        {
            if (DataBase.Detectors.Count == 0)
            {
                MessageBox.Show("Ни одного извещателя не найдено");
                return;
            }


            if (DataBase.Detectors.Find(i => i.IsEnabled == true) == null)
            {
                MessageBox.Show("Все извещатели заняты");
                return;
            }

            if (new ImportInformationForm().ShowDialog() == DialogResult.OK)
                MessageBox.Show("Объект добавлен");
            ShowAllBuildings();
        }

        private void ChangeObject_Click(object sender, EventArgs e)
        {
            if (!IsValidSelectedBuilding())
                return;

            if (new ImportInformationForm(DataBase.Buildings[BuildingList.SelectedIndices[0]]).ShowDialog() == DialogResult.OK)
                MessageBox.Show("Объект изменен");
            ShowAllBuildings();
        }

        private void deleteObject_Click(object sender, EventArgs e)
        {
            if (!IsValidSelectedBuilding())
                return;

            Building b = DataBase.Buildings[BuildingList.SelectedIndices[0]];

            foreach (FireDetector fireDetector in b.Detectors)
            {
                fireDetector.IsEnabled = true;
                DataBase.Detectors.Update(i => i.Title == fireDetector.Title, fireDetector);
            }

            DataBase.Buildings.RemoveAt(BuildingList.SelectedIndices[0]);

            ShowAllBuildings();
            MessageBox.Show("Объект удален");
        }
        #endregion
    }
}
