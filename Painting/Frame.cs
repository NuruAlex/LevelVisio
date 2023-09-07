using FilesDataBase.Objects;
using System.Collections.Generic;

namespace LevelVisio.Painting
{
    /// <summary>
    /// class that implements one action of painting
    /// </summary>
    public class Frame
    {
        public PaintingStage Stage { get; set; }
        public List<FireDetector> Detectors { get; set; }

        public Frame(List<FireDetector> detectors, PaintingStage stage)
        {
            Stage = stage;
            Detectors = detectors;
        }
    }
}
