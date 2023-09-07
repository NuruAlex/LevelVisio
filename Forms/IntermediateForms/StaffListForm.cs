using FilesDataBase.Main;
using LevelVisio.Forms.AddingForms;
using LevelVisio.Verification;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace LevelVisio.Forms.IntermediateForms
{
    public partial class StaffListForm : Form
    {
        public StaffListForm()
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);
        }

        private void StaffListForm_Load(object sender, EventArgs e)
        {
            FormClosed += (s, ev) => Hide();
            ShowChanges();
        }

        private void ClearChanges() => DataBase.TemproraryStaffs.AsList.Clear();


        private void AddStaffButton_Click(object sender, EventArgs e)
        {
            if (new ChangeStaffForm().ShowDialog() == DialogResult.OK)
                MessageBox.Show("Сотрудник добавлен");
            ShowChanges();
        }

        private void ShowChanges() => UIHelper.FillListView(StaffTable, DataBase.TemproraryStaffs.AsDataBaseObjectList);

        private void ChangeStaffButton_Click(object sender, EventArgs e)
        {
            if (!IsCorrectStaffSelected()) return;


            new ChangeStaffForm(DataBase.TemproraryStaffs.AsList[StaffTable.SelectedIndices[0]]).ShowDialog();
            ShowChanges();
        }

        private bool IsCorrectStaffSelected()
        {
            if (StaffTable.SelectedItems.Count != 1)
            {
                MessageBox.Show("Выберите одного пользователя");
                return false;
            }

            
            return true;
        }

        private void DeleteStaffButton_Click(object sender, EventArgs e)
        {
            if (!IsCorrectStaffSelected()) return;

            int index = StaffTable.SelectedIndices[0];
            
            if (StaffManager.CurrentStaff.StaffLogin == DataBase.Staffs[index].StaffLogin)
            {
                MessageBox.Show("Вы не можете удалить себя");
                return;
            }
            DataBase.TemproraryStaffs.RemoveAt(StaffTable.SelectedIndices[0]);
            ShowChanges();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите внести все изменения?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            DataBase.TemproraryStaffs.Save();

            ClearChanges();
            MessageBox.Show("Изменения сохранены");
            Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearChanges();
            Hide();
        }

        private void StaffTable_DoubleClick(object sender, EventArgs e) => ChangeStaffButton_Click(sender, e);
    }
}
