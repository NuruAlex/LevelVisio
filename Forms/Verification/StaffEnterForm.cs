using FilesDataBase.Main;
using FilesDataBase.Objects;
using LevelVisio.Verification;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LevelVisio.Forms.VerificationForms
{
    public partial class StaffEnterForm : Form
    {
        public StaffEnterForm() => InitializeComponent();

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (login.Text == "" && password.Text == "")
            {
                StaffManager.EnterAsDefault();
                Hide();
                return;
            }


            if (login.Text == "" || password.Text == "")
            {
                new AuthorizationErrorForm().ShowDialog();
                if (!Application.OpenForms.OfType<ChosingActionForm>().Any())
                    new ChosingActionForm().Show();
                Hide();
                return;
            }


            if (DataBase.Staffs.Find(i => i.StaffLogin == login.Text && i.StaffPassword == password.Text) == null)
            {
                new AuthorizationErrorForm().ShowDialog();
                if (!Application.OpenForms.OfType<ChosingActionForm>().Any())
                    new ChosingActionForm().Show();

                Hide();
                return;
            }

            Staff current = DataBase.Staffs.Find(i => i.StaffLogin == login.Text && i.StaffPassword == password.Text); 

            if (rememberMe.Checked)
                StaffManager.RememberLast(current);

            StaffManager.AllowUserEnterAs(current);

            Hide();
        }

        private void StaffEnterForm_Load(object sender, EventArgs e)
        {
            unlockPicture.Visible = false;
            lockPicture.Visible = true;

            FormClosed += (s, ev) => Application.Exit();
            UIHelper.SetDefaultFormProperties(this);
        }
        private void ExitButton_Click(object sender, EventArgs e) => Hide();

        private void unlockPicture_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !password.UseSystemPasswordChar;
            unlockPicture.Visible = !unlockPicture.Visible;
            lockPicture.Visible = !lockPicture.Visible;
        }
    }
}
