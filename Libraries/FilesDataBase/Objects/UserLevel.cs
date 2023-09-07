using System;

namespace FilesDataBase.Objects
{
    [Serializable]
    public class UserLevel :IDataBaseObject
    {
        public string Title { get; set; }
        public string Comments { get; set; }

        public string[] AsStringArray() => new string[] { Title };
    }
}

