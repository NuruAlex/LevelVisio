namespace LevelVisio.Forms.SettingsForms
{
    partial class ChannelPaintingSettingsForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Radius = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.ChangeColor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(187, 265);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(177, 43);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Назад";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(8, 265);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(173, 43);
            this.Save.TabIndex = 7;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Title);
            this.groupBox1.Controls.Add(this.Radius);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.ChangeColor);
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 228);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки отображения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Толщина линии:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(57, 40);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(87, 21);
            this.Title.TabIndex = 0;
            this.Title.Text = "Название: ";
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(197, 149);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(41, 28);
            this.Radius.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(57, 91);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(98, 21);
            this.label.TabIndex = 1;
            this.label.Text = "Цвет линии:";
            // 
            // ChangeColor
            // 
            this.ChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeColor.Location = new System.Drawing.Point(197, 84);
            this.ChangeColor.Name = "ChangeColor";
            this.ChangeColor.Size = new System.Drawing.Size(41, 28);
            this.ChangeColor.TabIndex = 2;
            this.ChangeColor.UseVisualStyleBackColor = true;
            this.ChangeColor.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // ChannelPaintingSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 341);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChannelPaintingSettingsForm";
            this.Text = "ChannelPaintingSettingsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox Radius;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button ChangeColor;
    }
}