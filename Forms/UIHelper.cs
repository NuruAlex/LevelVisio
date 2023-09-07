using FilesDataBase;
using FilesDataBase.Objects;
using LevelVisio.Painting;
using LevelVisio.Verification;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LevelVisio.Forms
{
    public static class UIHelper
    {
        public static void SetDefaultFormProperties(Form form)
        {
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Icon = Properties.Resources.Icon;
        }

        public static void WriteCurrentStaff(Form form)
        {
            form.Text = $"LevelVisio - {StaffManager.CurrentStaff.Initials} ({StaffManager.CurrentStaff.Post})";
        }
        public static string GetTextBySigningType(SigningType signingType)
        {
            switch (signingType)
            {
                case SigningType.Top: return "Сверху";
                case SigningType.Under: return "Снизу";
                case SigningType.MidleLeft: return "Слева";
                case SigningType.MidleRight: return "Справа";
                case SigningType.TopLeft: return "Сверху - слева";
                case SigningType.TopRight: return "Сверху - справа";
                case SigningType.UnderLeft: return "Снизу - слева";
                case SigningType.UnderRight: return "Снизу - справа";
                default: return "";
            }

        }

        public static string GetHintText(PaintingStage stage)
        {
            switch (stage)
            {
                case PaintingStage.DetectorPlanting: return "1. Укажите место расположения извещателя на плане объекта/этажа";
                case PaintingStage.ChannelSelection: return "2. К извещателю проведены 1-4 линии";
                case PaintingStage.ChannelPainting: return "Начинайте проводить линию";
                case PaintingStage.EditDetector: return "Укажите новое местоположение извещателя, зажав левую кнопку мыши на схеме";
                case PaintingStage.EditChannel: return "Укажите расположение кабеля";
                default: return "";
            }
        }
        public static void FillListView(ListView listView, List<IDataBaseObject> data)
        {
            if (data == null || data.Count == 0)
                return;

            listView.Items.Clear();
            foreach (IDataBaseObject item in data)
                listView.Items.Add(new ListViewItem(item.AsStringArray()));
        }

    }
}
