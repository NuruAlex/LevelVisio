using FilesDataBase.Main;
using FilesDataBase.Objects;
using LevelVisio.Forms.VerificationForms;
using System;
using System.Windows.Forms;

namespace LevelVisio
{
    internal static class Program
    {
        static void AddDefaultValues()
        {
            if (DataBase.Staffs.Count == 0)
                DataBase.SaveAsBinary(
                   new System.Collections.Generic.List<Staff>
                   {
                        new Staff
                        {
                            UserLevel = "Администратор",
                            StaffLogin = "alex",
                            StaffPassword = "Password",
                            Initials = "Галустян Алексей",
                            LastDateEntered = DateTime.Now,
                            Post = "Администратор"
                        }
                   },
                   DataCategory.Staffs);

            if (DataBase.Posts.Count == 0)
                DataBase.SaveAsBinary(new System.Collections.Generic.List<Post> { new Post { Title = "Администратор" } }, DataCategory.Posts);
            if (DataBase.AccessLevels.Count == 0)
                DataBase.SaveAsBinary(new System.Collections.Generic.List<UserLevel> { new UserLevel { Title = "Администратор" } }, DataCategory.UserLevels);

        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AddDefaultValues();
            Application.Run(new ChosingActionForm());
        }
    }
}
