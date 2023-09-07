using FilesDataBase;
using System.Windows.Forms;

namespace LevelVisio.Forms.SettingsForms
{
    public partial class SigningTypeForm : Form
    {
        public static SigningType SigningType = SigningType.Top;
        public static string SigningTypeText;
        public SigningTypeForm() => InitializeComponent();

        private void SetSgningType(SigningType signingType, string text)
        {
            SigningType = signingType;
            SigningTypeText = text;
            Hide();
        }

        private void button1_Click(object sender, System.EventArgs e) => SetSgningType(SigningType.TopLeft, button1.Text);

        private void button2_Click(object sender, System.EventArgs e) => SetSgningType(SigningType.Top, button2.Text);

        private void button3_Click(object sender, System.EventArgs e) => SetSgningType(SigningType.TopRight, button3.Text);

        private void button4_Click(object sender, System.EventArgs e) => SetSgningType(SigningType.MidleLeft, button4.Text);

        private void button5_Click(object sender, System.EventArgs e) => SetSgningType(SigningType.MidleRight, button5.Text);

        private void button6_Click(object sender, System.EventArgs e) => SetSgningType(SigningType.UnderLeft, button6.Text);

        private void button7_Click(object sender, System.EventArgs e) => SetSgningType(SigningType.Under, button7.Text);

        private void button8_Click(object sender, System.EventArgs e) => SetSgningType(SigningType.UnderRight, button8.Text);
    }
}
