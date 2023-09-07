using FilesDataBase.Main;
using FilesDataBase.Objects;
using LevelVisio.Verification;
using System;
using System.Windows.Forms;

namespace LevelVisio.Forms.SettingsForms
{
    public partial class PersonalSettingForm : Form
    {
        public PersonalSettingForm()
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);
        }

        private void PrsonalSettingForm_Load(object sender, EventArgs e)
        {
            FormClosed += (s, ev) => Hide();

            foreach (Post post in DataBase.Posts.AsList)
                Posts.Items.Add(post.Title);

            InitialsTextBox.Text = StaffManager.CurrentStaff.Initials;
            Posts.Text = StaffManager.CurrentStaff.Post;
            Posts.SelectedItem = StaffManager.CurrentStaff.Post;
            InitialsTextBox.Enabled = false;
            Posts.Enabled = false;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (InitialsTextBox.Text == "" || Posts.SelectedItem == null || NewPassword.Text == "" || RepeatedPassword.Text == "")
            {
                MessageBox.Show("Все данные должны быть введены!");
                return;
            }
            if (InitialsTextBox.Text != StaffManager.CurrentStaff.Initials || Posts.SelectedItem.ToString() != StaffManager.CurrentStaff.Post)
            {
                MessageBox.Show("Вы неверно ввели свои личный данные");
                return;
            }
            if (NewPassword.Text != RepeatedPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            DataBase.Staffs.Update(i => i.StaffLogin == StaffManager.CurrentStaff.StaffLogin, StaffManager.CurrentStaff);
            MessageBox.Show("Пароль успешно обновлен");
            Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e) => Hide();
    }
}
