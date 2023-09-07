using FilesDataBase.Main;
using FilesDataBase.Objects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LevelVisio.Verification
{
    public static class StaffManager
    {
        public static Staff CurrentStaff { get; set; } = DataBase.DefaultStaff;

        private static readonly Dictionary<string, Form> _nextForms = new Dictionary<string, Form>()
        {
            {"охранник",new Forms.MainForms.MonitoringForm()},
            {"директор",new Forms.MainForms.DirectorForm()},
            {"администратор",new Forms.MainForms.DirectorForm()},
        };

        public static void AllowUserEnterAs(Staff current)
        {
            try
            {
                current.LastDateEntered = DateTime.Now;
                DataBase.Staffs.Update(i => i.StaffLogin == current.StaffLogin, current);
                _nextForms[current.UserLevel.ToLower()].Show();
                CurrentStaff = current;
            }
            catch
            {
                MessageBox.Show("Post doesn't exist");
            }
        }
        public static void EnterAsDefault() => AllowUserEnterAs(DataBase.DefaultStaff);

        public static void RememberLast(Staff current) => DataBase.LastStaffEntered = current;

    }
}
