using LevelVisio.Painting;
using System;
using System.Windows.Forms;

namespace LevelVisio.Forms.VerificationForms
{
    public partial class ChosingActionForm : Form
    {
        public ChosingActionForm() => InitializeComponent();
        public static bool EnterFormShown = false;
        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            if (!EnterFormShown)
            {
                new StaffEnterForm().Show();
                EnterFormShown = true;
            }
        }
        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void ChosingActionForm_Load(object sender, EventArgs e)
        {
            FormClosed += (s, ev) => Application.Exit();
            UIHelper.SetDefaultFormProperties(this);
        }
    }
}
