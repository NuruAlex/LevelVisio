using FilesDataBase.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace FilesDataBase.Main
{
    /// <summary>
    /// This class implements saving and retrieveing data by data category
    /// </summary>
    public static class DataBase
    {
        private static BinaryFormatter _formatter = new BinaryFormatter();


        #region DefaultCollections
        public static DataBaseObjectCollection<FireDetector> Detectors => RetrieveAll<FireDetector>(DataCategory.Detectors);

        public static DataBaseObjectCollection<UserLevel> AccessLevels => RetrieveAll<UserLevel>(DataCategory.UserLevels);

        public static DataBaseObjectCollection<Building> Buildings => RetrieveAll<Building>(DataCategory.Buildings);

        public static DataBaseObjectCollection<Post> Posts => RetrieveAll<Post>(DataCategory.Posts);

        public static DataBaseObjectCollection<Staff> Staffs => RetrieveAll<Staff>(DataCategory.Staffs);

        #endregion

        #region NoAutoSaveCollections

        private static DataBaseObjectCollection<Staff> _staffs = null;
        private static DataBaseObjectCollection<UserLevel> _levels = null;

        public static DataBaseObjectCollection<Staff> TemproraryStaffs
        {
            get
            {
                if (_staffs == null || _staffs.Count == 0)
                    _staffs = Staffs;
                return _staffs;
            }
        }
        public static DataBaseObjectCollection<UserLevel> TemproraryAccessLevels
        {
            get
            {
                if (_levels == null || _levels.Count == 0)
                    _levels = AccessLevels;
                return _levels;
            }
        }

        #endregion

        #region DefaultProperties

        public static Staff LastStaffEntered
        {
            get
            {
                List<Staff> st = RetrieveAll<Staff>(DataCategory.LastStaffEntered).AsList;
                if (st != null && st.Count == 1)
                    return st[0];
                return null;
            }
            set
            {
                Staff st = value;
                st.LastDateEntered = DateTime.Now;
                Staffs.Update(i => i.StaffLogin == st.StaffLogin, st);
                SaveAsBinary(new List<Staff> { st }, DataCategory.LastStaffEntered);
            }
        }
        public static Staff DefaultStaff
        {
            get => Staffs.Find(i => i.StaffLogin == "alex");
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method saves list of data in the special binary file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">list of data to save</param>
        /// <param name="dataCategory">category helps to figure out in which file save the list</param>
        public static void SaveAsBinary<T>(List<T> data, DataCategory dataCategory)
        {
            try
            {
                using (FileStream stream = new FileStream(FileManager.FileByCategory(dataCategory), FileMode.OpenOrCreate))
                    _formatter.Serialize(stream, data);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка сохранения данных", "Кажется произошка ошибка сохрания данных", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public static void SaveAsBinary<T>(DataBaseObjectCollection<T> data)
        {
            try
            {
                using (FileStream stream = new FileStream(FileManager.FileByCategory(data.Category), FileMode.OpenOrCreate))
                    _formatter.Serialize(stream, data.AsList);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка сохранения данных", "Кажется произошка ошибка сохрания данных", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method retrieves the all data from file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataCategory">Category helps to figure out from which file get data</param>
        /// <returns>Method returns list of the data base objects</returns>

        public static DataBaseObjectCollection<T> RetrieveAll<T>(DataCategory dataCategory)
        {
            using (FileStream stream = new FileStream(FileManager.FileByCategory(dataCategory), FileMode.OpenOrCreate))
            {
                List<T> data = new List<T>();

                try { data = _formatter.Deserialize(stream) as List<T>; }

                catch { data = new List<T>(); }

                return new DataBaseObjectCollection<T>(dataCategory, data);
            }
        }

        #endregion


    }
}
