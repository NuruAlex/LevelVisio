using FilesDataBase.DrawingData;
using System;
using System.Collections.Generic;

namespace FilesDataBase.Objects
{
    [Serializable]
    public class FireDetector : IDataBaseObject
    {
        public string Title { get; set; }
        public string Ip { get; set; }
        public int Port { get; set; }
        public int ChannelAmount { get; set; }

        public bool IsEnabled { get; set; }

        public DetectorDrawingData DrawingData { get; set; }

        public List<Channel> Channels { get; set; }

        public string[] AsStringArray() => new string[] { Title, Ip.ToString(), Port.ToString(), ChannelAmount.ToString() };
    }
}
