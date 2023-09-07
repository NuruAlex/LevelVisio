using FilesDataBase.Main;
using FilesDataBase.Objects;
using LevelVisio.Painting;
using System;
using System.Windows.Forms;

namespace LevelVisio.Forms.AddingForms
{
    public partial class ChangeRoleForm : Form
    {
        public ChangeRoleForm()
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);
            Title.ReadOnly = false;
            AddRole.Visible = true;
            SaveChanges.Visible = false;
        }

        public ChangeRoleForm(UserLevel accessLevel)
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);

            Title.Text = accessLevel.Title;
            Title.ReadOnly = true;
            Title.Text = accessLevel.Title;
            Comments.Text = accessLevel.Comments;
            AddRole.Visible = false;
            SaveChanges.Visible = true;
        }

        private UserLevel BuildRole() => new UserLevel
        {
            Title = Title.Text,
            Comments = Comments.Text
        };

        private void AddRole_Click(object sender, EventArgs e)
        {
            if (Title.Text == "")
            {
                MessageBox.Show("Введите наименование роли доступа");
                return;
            }

            if (DataBase.AccessLevels.Find(i => i.Title == Title.Text) != null)
            {
                MessageBox.Show("Уровень доступа с таким наименованием уже существует");
                return;
            }

            DataBase.TemproraryAccessLevels.Add(BuildRole());
            Hide();
        }
        private void SaveChanges_Click(object sender, EventArgs e)
        {
            DataBase.TemproraryAccessLevels.Update(i => i.Title == Title.Text, BuildRole());
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e) => Hide();

    }
}
