using System;

namespace FilesDataBase.DrawingData
{
    [Serializable]
    public class DetectorDrawingData
    {
        public Position Position { get; set; }
        public DetectorPaintingSettings PaintingSettings { get; set; }
    }
}
