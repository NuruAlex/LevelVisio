using System;
using System.Collections.Generic;

namespace FilesDataBase.DrawingData
{
    [Serializable]
    public class ChannelDrawingData
    {
        public ChannelPaintingSettings PaintingSettings { get; set; }
        public List<Position> Points { get; set; }

    }
}
