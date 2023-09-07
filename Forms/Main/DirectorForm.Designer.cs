namespace LevelVisio.Forms.MainForms
{
    partial class DirectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorForm));
            this.ExitButton = new System.Windows.Forms.Button();
            this.StaffList = new System.Windows.Forms.Button();
            this.AccessLevelSettings = new System.Windows.Forms.Button();
            this.FireDetectorSettings = new System.Windows.Forms.Button();
            this.PersonalSettings = new System.Windows.Forms.Button();
            this.OpenSchemeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(74, 445);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(432, 57);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход ";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StaffList
            // 
            this.StaffList.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaffList.Location = new System.Drawing.Point(74, 208);
            this.StaffList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StaffList.Name = "StaffList";
            this.StaffList.Size = new System.Drawing.Size(432, 57);
            this.StaffList.TabIndex = 2;
            this.StaffList.Text = "Список пользователей";
            this.StaffList.UseVisualStyleBackColor = true;
            this.StaffList.Click += new System.EventHandler(this.StaffList_Click);
            // 
            // AccessLevelSettings
            // 
            this.AccessLevelSettings.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccessLevelSettings.Location = new System.Drawing.Point(74, 124);
            this.AccessLevelSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccessLevelSettings.Name = "AccessLevelSettings";
            this.AccessLevelSettings.Size = new System.Drawing.Size(432, 57);
            this.AccessLevelSettings.TabIndex = 1;
            this.AccessLevelSettings.Text = "Настройки уровней доступа (ролей)";
            this.AccessLevelSettings.UseVisualStyleBackColor = true;
            this.AccessLevelSettings.Click += new System.EventHandler(this.AccessLevelSettings_Click);
            // 
            // FireDetectorSettings
            // 
            this.FireDetectorSettings.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FireDetectorSettings.Location = new System.Drawing.Point(74, 292);
            this.FireDetectorSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FireDetectorSettings.Name = "FireDetectorSettings";
            this.FireDetectorSettings.Size = new System.Drawing.Size(432, 57);
            this.FireDetectorSettings.TabIndex = 3;
            this.FireDetectorSettings.Text = "Настройки объекта и извещателей";
            this.FireDetectorSettings.UseVisualStyleBackColor = true;
            this.FireDetectorSettings.Click += new System.EventHandler(this.FireDetectorSettings_Click);
            // 
            // PersonalSettings
            // 
            this.PersonalSettings.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalSettings.Location = new System.Drawing.Point(74, 44);
            this.PersonalSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PersonalSettings.Name = "PersonalSettings";
            this.PersonalSettings.Size = new System.Drawing.Size(432, 57);
            this.PersonalSettings.TabIndex = 0;
            this.PersonalSettings.Text = "Персональные настройки";
            this.PersonalSettings.UseVisualStyleBackColor = true;
            this.PersonalSettings.Click += new System.EventHandler(this.PersonalSettings_Click);
            // 
            // OpenSchemeButton
            // 
            this.OpenSchemeButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenSchemeButton.Location = new System.Drawing.Point(74, 369);
            this.OpenSchemeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpenSchemeButton.Name = "OpenSchemeButton";
            this.OpenSchemeButton.Size = new System.Drawing.Size(432, 57);
            this.OpenSchemeButton.TabIndex = 5;
            this.OpenSchemeButton.Text = "Открыть схему";
            this.OpenSchemeButton.UseVisualStyleBackColor = true;
            this.OpenSchemeButton.Click += new System.EventHandler(this.OpenSchemeButton_Click);
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 596);
            this.Controls.Add(this.OpenSchemeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AccessLevelSettings);
            this.Controls.Add(this.PersonalSettings);
            this.Controls.Add(this.FireDetectorSettings);
            this.Controls.Add(this.StaffList);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DirectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelVisio -";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StaffList;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AccessLevelSettings;
        private System.Windows.Forms.Button FireDetectorSettings;
        private System.Windows.Forms.Button PersonalSettings;
        private System.Windows.Forms.Button OpenSchemeButton;
    }
}