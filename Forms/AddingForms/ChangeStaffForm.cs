using FilesDataBase.Main;
using FilesDataBase.Objects;
using System;
using System.Windows.Forms;

namespace LevelVisio.Forms.AddingForms
{
    public partial class ChangeStaffForm : Form
    {
        public ChangeStaffForm()
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);

            StaffLogin.Enabled = true;
            StaffPassword.Enabled = true;
            Initials.Enabled = true;
            AccessLevels.Enabled = true;
            Posts.Enabled = true;
            AddRole.Visible = true;
            SaveChanges.Visible = false;
        }
        public ChangeStaffForm(Staff staff)
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);

            StaffLogin.Enabled = false;
            StaffPassword.Enabled = false;
            Initials.Enabled = false;
            AccessLevels.Enabled = true;
            Posts.Enabled = false;
            AddRole.Visible = false;
            SaveChanges.Visible = true;
            LoadStaff(staff);
        }

        private void LoadStaff(Staff staff)
        {
            StaffLogin.Text = staff.StaffLogin;
            StaffPassword.Text = staff.StaffPassword;
            Initials.Text = staff.Initials;
            AccessLevels.Text = staff.UserLevel;
            Posts.Text = staff.Post;
        }

        private void ChangeStaffForm_Load(object sender, EventArgs e)
        {
            foreach (Post post in DataBase.Posts.AsList)
                Posts.Items.Add(post.Title);

            foreach (UserLevel role in DataBase.AccessLevels.AsList)
                AccessLevels.Items.Add(role.Title);
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            DataBase.TemproraryStaffs.Update(i => i.StaffLogin == StaffLogin.Text, BuildStaff());
            Hide();
        }
        private Staff BuildStaff() => new Staff
        {
            StaffLogin = StaffLogin.Text,
            Initials = Initials.Text,
            StaffPassword = StaffPassword.Text,
            Post = Posts.Text,
            UserLevel = AccessLevels.Text
        };
        private void ExitButton_Click(object sender, EventArgs e) => Hide();

        private void AddStaff_Click(object sender, EventArgs e)
        {
            if (StaffLogin.Text == "" || Initials.Text == "" || StaffPassword.Text == "" || AccessLevels.SelectedItem == null || Posts.SelectedItem == null)
            {
                MessageBox.Show("Все данные нужно ввести");
                return;
            }

            if (DataBase.Staffs.Find(i => i.StaffLogin == StaffLogin.Text) == null)
            {
                DataBase.TemproraryStaffs.Add(BuildStaff());
                Hide();
            }
            else
            {

                MessageBox.Show("Такой персонал уже существует");
                return;
            }
        }
    }
}
