using System;
using System.Drawing;

namespace FilesDataBase.DrawingData
{
    [Serializable]
    public class DetectorPaintingSettings
    {
        public Color Color { get; set; } = Color.Red;

        public int Radius { get; set; } = 15;

        public SigningType SigningType { get; set; } = SigningType.Top;
    }
}
