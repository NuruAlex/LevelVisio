namespace LevelVisio.Forms.IntermediateForms
{
    partial class ImportInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportInformationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.EditShemeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.realHeight = new System.Windows.Forms.TextBox();
            this.realWidth = new System.Windows.Forms.TextBox();
            this.AddSchemeFileButton = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.Label();
            this.FileSize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перед загрузкой схемы, убедитесь, что границы стен находятся на границах изображе" +
    "ния";
            // 
            // EditShemeButton
            // 
            this.EditShemeButton.Location = new System.Drawing.Point(22, 370);
            this.EditShemeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditShemeButton.Name = "EditShemeButton";
            this.EditShemeButton.Size = new System.Drawing.Size(207, 37);
            this.EditShemeButton.TabIndex = 4;
            this.EditShemeButton.Text = "Разметить схему";
            this.EditShemeButton.UseVisualStyleBackColor = true;
            this.EditShemeButton.Click += new System.EventHandler(this.EditShemeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ширина(м):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Длина (м):";
            // 
            // realHeight
            // 
            this.realHeight.Location = new System.Drawing.Point(300, 314);
            this.realHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.realHeight.Name = "realHeight";
            this.realHeight.Size = new System.Drawing.Size(297, 28);
            this.realHeight.TabIndex = 3;
            this.realHeight.TextChanged += new System.EventHandler(this.realHeight_TextChanged);
            // 
            // realWidth
            // 
            this.realWidth.Location = new System.Drawing.Point(22, 314);
            this.realWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.realWidth.Name = "realWidth";
            this.realWidth.Size = new System.Drawing.Size(270, 28);
            this.realWidth.TabIndex = 2;
            this.realWidth.TextChanged += new System.EventHandler(this.realWidth_TextChanged);
            // 
            // AddSchemeFileButton
            // 
            this.AddSchemeFileButton.Location = new System.Drawing.Point(22, 85);
            this.AddSchemeFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddSchemeFileButton.Name = "AddSchemeFileButton";
            this.AddSchemeFileButton.Size = new System.Drawing.Size(164, 37);
            this.AddSchemeFileButton.TabIndex = 0;
            this.AddSchemeFileButton.Text = "Выбор файла";
            this.AddSchemeFileButton.UseVisualStyleBackColor = true;
            this.AddSchemeFileButton.Click += new System.EventHandler(this.AddSchemeFileButton_Click);
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(18, 138);
            this.FileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(52, 21);
            this.FileName.TabIndex = 22;
            this.FileName.Text = "label4";
            // 
            // FileSize
            // 
            this.FileSize.AutoSize = true;
            this.FileSize.Location = new System.Drawing.Point(18, 170);
            this.FileSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileSize.Name = "FileSize";
            this.FileSize.Size = new System.Drawing.Size(52, 21);
            this.FileSize.TabIndex = 23;
            this.FileSize.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Название объекта/этажа:";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(22, 255);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(575, 28);
            this.Title.TabIndex = 1;
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // ImportInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 438);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FileSize);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.AddSchemeFileButton);
            this.Controls.Add(this.EditShemeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.realHeight);
            this.Controls.Add(this.realWidth);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ImportInformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditShemeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox realHeight;
        private System.Windows.Forms.TextBox realWidth;
        private System.Windows.Forms.Button AddSchemeFileButton;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Label FileSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Title;
    }
}