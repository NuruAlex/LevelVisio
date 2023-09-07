using FilesDataBase.Main;
using System;
using System.Windows.Forms;

namespace LevelVisio.Forms.MainForms
{
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);
            UIHelper.WriteCurrentStaff(this);
            FormClosed += (s, ev) => Application.Exit();
        }

        private void PersonalSettings_Click(object sender, EventArgs e) => new SettingsForms.PersonalSettingForm().ShowDialog();

        private void FireDetectorSettings_Click(object sender, EventArgs e) => new IntermediateForms.EventLogForm().ShowDialog();

        private void AccessLevelSettings_Click(object sender, EventArgs e) => new IntermediateForms.AccessLevelForm().ShowDialog();

        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void StaffList_Click(object sender, EventArgs e) => new IntermediateForms.StaffListForm().ShowDialog();

        private void OpenSchemeButton_Click(object sender, EventArgs e)
        {
            if (DataBase.Buildings.AsList != null)
            {
                if (DataBase.Buildings.Count == 0)
                {
                    MessageBox.Show("Не найдено ни одной схемы");
                    return;
                }

                try
                {
                    new MonitoringForm(DataBase.Buildings.AsList[0]).ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
