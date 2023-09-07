using System.Collections.Generic;

namespace FilesDataBase.Main
{
    internal static class FileManager
    {
        private static string _resourceDirectory = "Resources\\";

        private static Dictionary<DataCategory, string> _files = new Dictionary<DataCategory, string>()
        {
            {DataCategory.Detectors,_resourceDirectory + "Detectors.bin" },
            {DataCategory.Staffs,_resourceDirectory + "Staffs.bin" },
            {DataCategory.UserLevels,_resourceDirectory + "AccessLevels.bin" },
            {DataCategory.Buildings,_resourceDirectory + "Buildings.bin" },
            {DataCategory.Posts,_resourceDirectory + "Posts.bin" },
            {DataCategory.LastStaffEntered, _resourceDirectory + "LastStaffEntered.bin" },
            {DataCategory.DetectorMeasure,_resourceDirectory +"EventLog.bin" },
            {DataCategory.AlarmSettings,_resourceDirectory +"Alarm.bin" }
        };

        public static string FileByCategory(DataCategory category) => _files[category];

    }
}
