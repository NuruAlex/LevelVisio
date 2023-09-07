using System;

namespace FilesDataBase.Objects
{
    [Serializable]
    public class Post : IDataBaseObject
    {
        public string Title { get; set; }

        public string[] AsStringArray() => new string[] { Title };
    }
}
