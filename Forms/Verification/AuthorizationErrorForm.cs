using LevelVisio.Painting;
using System;
using System.Windows.Forms;

namespace LevelVisio.Forms.VerificationForms
{
    public partial class AuthorizationErrorForm : Form
    {
        public AuthorizationErrorForm()
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChosingActionForm.EnterFormShown = false;
            Hide();
        }
    }
}
