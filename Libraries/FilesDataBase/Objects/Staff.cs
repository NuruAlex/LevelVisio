using System;

namespace FilesDataBase.Objects
{
    [Serializable]
    public class Staff : IDataBaseObject
    {
        public string StaffLogin { get; set; }
        public string Initials { get; set; }
        public string StaffPassword { get; set; }
        public string Post { get; set; }
        public string UserLevel { get; set; }
        public DateTime LastDateEntered { get; set; }

      
        public string[] AsStringArray() => new string[] { StaffLogin, UserLevel, LastDateEntered.ToString("G") };

    }
}
