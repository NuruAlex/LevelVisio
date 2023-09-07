namespace LevelVisio.Forms.IntermediateForms
{
    partial class EventLogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventLogForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.DetectorsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteObject = new System.Windows.Forms.Button();
            this.ChangeObject = new System.Windows.Forms.Button();
            this.AddObject = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BuildingList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 599);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.DetectorsList);
            this.tabPage3.Controls.Add(this.deleteObject);
            this.tabPage3.Controls.Add(this.ChangeObject);
            this.tabPage3.Controls.Add(this.AddObject);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(828, 565);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Извещатели";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Список извещателей:";
            // 
            // DetectorsList
            // 
            this.DetectorsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader9});
            this.DetectorsList.FullRowSelect = true;
            this.DetectorsList.GridLines = true;
            this.DetectorsList.HideSelection = false;
            this.DetectorsList.Location = new System.Drawing.Point(31, 71);
            this.DetectorsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DetectorsList.Name = "DetectorsList";
            this.DetectorsList.Size = new System.Drawing.Size(766, 362);
            this.DetectorsList.TabIndex = 3;
            this.DetectorsList.UseCompatibleStateImageBehavior = false;
            this.DetectorsList.View = System.Windows.Forms.View.Details;
            this.DetectorsList.DoubleClick += new System.EventHandler(this.ChangeDetectorButton_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IP адрес";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 162;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Порт";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 262;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Количество линий";
            this.columnHeader9.Width = 184;
            // 
            // deleteObject
            // 
            this.deleteObject.Location = new System.Drawing.Point(547, 443);
            this.deleteObject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteObject.Name = "deleteObject";
            this.deleteObject.Size = new System.Drawing.Size(250, 52);
            this.deleteObject.TabIndex = 2;
            this.deleteObject.Text = "Удалить";
            this.deleteObject.UseVisualStyleBackColor = true;
            this.deleteObject.Click += new System.EventHandler(this.DeleteDetectorButton_Click);
            // 
            // ChangeObject
            // 
            this.ChangeObject.Location = new System.Drawing.Point(289, 443);
            this.ChangeObject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChangeObject.Name = "ChangeObject";
            this.ChangeObject.Size = new System.Drawing.Size(250, 52);
            this.ChangeObject.TabIndex = 1;
            this.ChangeObject.Text = "Изменить";
            this.ChangeObject.UseVisualStyleBackColor = true;
            this.ChangeObject.Click += new System.EventHandler(this.ChangeDetectorButton_Click);
            // 
            // AddObject
            // 
            this.AddObject.Location = new System.Drawing.Point(31, 443);
            this.AddObject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddObject.Name = "AddObject";
            this.AddObject.Size = new System.Drawing.Size(250, 52);
            this.AddObject.TabIndex = 0;
            this.AddObject.Text = "Добавить ";
            this.AddObject.UseVisualStyleBackColor = true;
            this.AddObject.Click += new System.EventHandler(this.AddDetector_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.BuildingList);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(828, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Объекты наблюдения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(168, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(365, 28);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "Москва ул. Вавилова д.19";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Адрес объекта:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(168, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 28);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Организация №1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Название объекта:";
            // 
            // BuildingTable
            // 
            this.BuildingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.BuildingList.FullRowSelect = true;
            this.BuildingList.GridLines = true;
            this.BuildingList.HideSelection = false;
            this.BuildingList.Location = new System.Drawing.Point(21, 128);
            this.BuildingList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuildingList.Name = "BuildingTable";
            this.BuildingList.Size = new System.Drawing.Size(776, 363);
            this.BuildingList.TabIndex = 16;
            this.BuildingList.UseCompatibleStateImageBehavior = false;
            this.BuildingList.View = System.Windows.Forms.View.Details;
            this.BuildingList.DoubleClick += new System.EventHandler(this.ChangeObject_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Название";
            this.columnHeader5.Width = 132;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Площадь";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 145;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Количество извещателей";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 337;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ответственные";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 157;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 501);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 52);
            this.button3.TabIndex = 15;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deleteObject_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(281, 501);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(252, 52);
            this.button6.TabIndex = 14;
            this.button6.Text = "Изменить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ChangeObject_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(21, 501);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(252, 52);
            this.button7.TabIndex = 13;
            this.button7.Text = "Добавить ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.AddObject_Click);
            // 
            // EvetLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(836, 599);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EvetLogForm";
            this.Text = "LevelVisio - Журнал событий";
            this.Load += new System.EventHandler(this.EvetLogForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button deleteObject;
        private System.Windows.Forms.Button ChangeObject;
        private System.Windows.Forms.Button AddObject;
        private System.Windows.Forms.ListView DetectorsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListView BuildingList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}