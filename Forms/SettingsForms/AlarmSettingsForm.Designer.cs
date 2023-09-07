namespace LevelVisio.Forms.SettingsForms
{
    partial class AlarmSettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AlarmTime = new System.Windows.Forms.TextBox();
            this.Параметры = new System.Windows.Forms.GroupBox();
            this.IsRipleImage = new System.Windows.Forms.ComboBox();
            this.IsPlaySound = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Параметры.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продолжительность:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Звук:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Мирцание:";
            // 
            // AlarmTime
            // 
            this.AlarmTime.Location = new System.Drawing.Point(222, 27);
            this.AlarmTime.Name = "AlarmTime";
            this.AlarmTime.Size = new System.Drawing.Size(100, 28);
            this.AlarmTime.TabIndex = 3;
            // 
            // Параметры
            // 
            this.Параметры.Controls.Add(this.IsRipleImage);
            this.Параметры.Controls.Add(this.IsPlaySound);
            this.Параметры.Controls.Add(this.label4);
            this.Параметры.Controls.Add(this.AlarmTime);
            this.Параметры.Controls.Add(this.label3);
            this.Параметры.Controls.Add(this.label2);
            this.Параметры.Controls.Add(this.label1);
            this.Параметры.Location = new System.Drawing.Point(15, 30);
            this.Параметры.Name = "Параметры";
            this.Параметры.Size = new System.Drawing.Size(377, 222);
            this.Параметры.TabIndex = 6;
            this.Параметры.TabStop = false;
            this.Параметры.Text = "Параметры";
            // 
            // IsRipleImage
            // 
            this.IsRipleImage.FormattingEnabled = true;
            this.IsRipleImage.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.IsRipleImage.Location = new System.Drawing.Point(222, 140);
            this.IsRipleImage.Name = "IsRipleImage";
            this.IsRipleImage.Size = new System.Drawing.Size(100, 29);
            this.IsRipleImage.TabIndex = 8;
            // 
            // IsPlaySound
            // 
            this.IsPlaySound.FormattingEnabled = true;
            this.IsPlaySound.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.IsPlaySound.Location = new System.Drawing.Point(222, 83);
            this.IsPlaySound.Name = "IsPlaySound";
            this.IsPlaySound.Size = new System.Drawing.Size(100, 29);
            this.IsPlaySound.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "с";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(15, 258);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(186, 41);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(207, 258);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(186, 41);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Назад";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AlaramSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 326);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Параметры);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AlaramSettingsForm";
            this.Text = "LevelVisio - Настройки сигнализации";
            this.Параметры.ResumeLayout(false);
            this.Параметры.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AlarmTime;
        private System.Windows.Forms.GroupBox Параметры;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox IsPlaySound;
        private System.Windows.Forms.ComboBox IsRipleImage;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ExitButton;
    }
}