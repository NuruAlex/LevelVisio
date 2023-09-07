using FilesDataBase.Main;
using LevelVisio.Forms.AddingForms;
using System;
using System.Windows.Forms;

namespace LevelVisio.Forms.IntermediateForms
{
    public partial class AccessLevelForm : Form
    {
        //Добавление
        //Изменение
        //Удаление
        //Сохранение изменений
        //Выход

        public AccessLevelForm()
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);
        }


        private void AccessLevelForm_Load(object sender, EventArgs e)
        {
            FormClosed += (s, ev) => Hide();
            ShowChages();
        }

        public void ShowChages() => UIHelper.FillListView(RolesList, DataBase.TemproraryAccessLevels.AsDataBaseObjectList);
      
        private void ClearALlChanges() => DataBase.TemproraryAccessLevels.AsList.Clear();

        private void AddRoleButton_Click(object sender, EventArgs e)
        {
            if (new ChangeRoleForm().ShowDialog() == DialogResult.OK)
                MessageBox.Show("Уровень доступа добавлен");
            ShowChages();
        }

        public bool IsValidSelectedLevel()
        {
            if (RolesList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Выберите одну роль");
                return false;
            }
            return true;
        }

        private void ChangeRoleButton_Click(object sender, EventArgs e)
        {
            if (!IsValidSelectedLevel())
                return;
            if (new ChangeRoleForm(DataBase.TemproraryAccessLevels.AsList[RolesList.SelectedIndices[0]]).ShowDialog() == DialogResult.OK)
                MessageBox.Show("Уровень доступа извенен");
        }

        private void DeleteRoleButton_Click(object sender, EventArgs e)
        {
            if (!IsValidSelectedLevel())
                return;
            DataBase.TemproraryAccessLevels.RemoveAt(RolesList.SelectedIndices[0]);
            ShowChages();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите внести все изменения?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            DataBase.TemproraryAccessLevels.Save();
            MessageBox.Show("Изменения сохранены");
            ClearALlChanges();
            Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearALlChanges();
            Hide();
        }

        private void RolesTable_DoubleClick(object sender, EventArgs e) => ChangeRoleButton_Click(sender, e);
    }
}
