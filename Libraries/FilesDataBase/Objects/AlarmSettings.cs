using System;

namespace FilesDataBase.Objects
{
    [Serializable]
    public class AlarmSettings
    {
        public int AlarmTime { get; set; } = 10;
        public bool IsPlaySound { get; set; } = true;
        public bool IsRipleImage { get; set; } = true;
    }
}
