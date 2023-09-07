using System;
using System.Drawing;

namespace FilesDataBase.DrawingData
{
    [Serializable]
    public class ChannelPaintingSettings
    {
        public Color LineColor { get; set; }
        public float LineWidth { get; set; } = 3f;
    }
}
