using System;
using System.Collections.Generic;
using System.Drawing;

namespace FilesDataBase.Objects
{
    [Serializable]
    public class Building : IDataBaseObject
    {
        public string Title { get; set; }
        public int DetectorAmount { get => Detectors.Count; }
        public double Width { get; set; }
        public double Height { get; set; }
        public string ResponsiblePeople { get; set; }
        public string SchemePath { get; set; }
        public string SchemeTitle { get; set; }
        public Image Scheme { get; set; }
        public Image Original { get; set; }
        public List<FireDetector> Detectors { get; set; }
        public AlarmSettings AlarmSettings { get; set; }

        public string[] AsStringArray() => new string[] { Title, (Width * Height).ToString(), DetectorAmount.ToString(), ResponsiblePeople };

    }
}
