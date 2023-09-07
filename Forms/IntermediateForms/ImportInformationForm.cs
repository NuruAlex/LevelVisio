using FilesDataBase.Objects;
using LevelVisio.Forms.AddingForms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LevelVisio.Forms.IntermediateForms
{
    public partial class ImportInformationForm : Form
    {
        bool fileImpoted = false;
        Building building;


        public ImportInformationForm(Building b)
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);

            building = b;
            ShowFileInfo(b.SchemePath);
            AddSchemeFileButton.Visible = false;

            EditShemeButton.Text = "Редактировать схему";

            fileImpoted = true;


            realHeight.Text = b.Height.ToString();
            realWidth.Text = b.Width.ToString();
            Title.Text = b.Title;

            realWidth.Enabled = false;
            realHeight.Enabled = false;
            Title.Enabled = false;

            TryUnlockEditButton();
        }


        public ImportInformationForm()
        {
            InitializeComponent();
            UIHelper.SetDefaultFormProperties(this);

            building = new Building();
            FileName.Text = "";
            FileSize.Text = "";
            EditShemeButton.Enabled = false;
            EditShemeButton.Text = "Разметить схему";
        }

        private void ShowFileInfo(string filePath)
        {
            double Lenght = new FileInfo(building.SchemePath).Length;
            double fileSize = Lenght / 1048576.0;
            building.SchemeTitle = Path.GetFileNameWithoutExtension(filePath) + Path.GetExtension(filePath);
            FileName.Text = "Название файла: " + building.SchemeTitle;
            FileSize.Text = "Размер файла: " + Math.Round(fileSize, 2).ToString() + " Mбайт";
        }

        private void AddSchemeFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Импорт схемы";
                dialog.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                dialog.Multiselect = false;

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Ошбика выбора файла");
                    return;
                }

                building.ResponsiblePeople = "Дмитрий Дмитриевич";
                building.Scheme = Image.FromFile(dialog.FileName);
                building.SchemePath = dialog.FileName;
                ShowFileInfo(dialog.FileName);
                fileImpoted = true;

                TryUnlockEditButton();
            }
        }
        private void TryUnlockEditButton()
        {
            double r = 0.0;
            if (Title.Text != "" &&
                realWidth.Text != "" && double.TryParse(realWidth.Text, out r) &&
                realHeight.Text != "" && double.TryParse(realHeight.Text, out r) && fileImpoted
                && double.Parse(realWidth.Text) > 0.0 && double.Parse(realHeight.Text) > 0.0)
            {
                EditShemeButton.Enabled = true;
                building.Title = Title.Text;
                building.Width = double.Parse(realWidth.Text);
                building.Height = double.Parse(realHeight.Text);
            }
            else
                EditShemeButton.Enabled = false;
        }

        private void EditShemeButton_Click(object sender, EventArgs e)
        {
            DialogResult = new AddSchemeForm(building).ShowDialog();
        }
        private void Title_TextChanged(object sender, EventArgs e) => TryUnlockEditButton();
        private void realWidth_TextChanged(object sender, EventArgs e) => TryUnlockEditButton();
        private void realHeight_TextChanged(object sender, EventArgs e) => TryUnlockEditButton();
    }
}
