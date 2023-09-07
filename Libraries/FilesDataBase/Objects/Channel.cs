using FilesDataBase.DrawingData;
using System;

namespace FilesDataBase.Objects
{
    [Serializable]
    public class Channel
    {
        public int Id { get; set; }
        public string DetectorTitle { get; set; }

        public ChannelDrawingData DrawingData { get; set; }
    }
}
