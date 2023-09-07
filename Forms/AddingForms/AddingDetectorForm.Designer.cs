namespace LevelVisio.Forms.AddingForms
{
    partial class AddingDetectorForm
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
            this.Ip = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.ChannelAmount = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddDetector = new System.Windows.Forms.Button();
            this.RefuceButton = new System.Windows.Forms.Button();
            this.RetreiveIP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ip
            // 
            this.Ip.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ip.Location = new System.Drawing.Point(74, 341);
            this.Ip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(236, 28);
            this.Ip.TabIndex = 0;
            // 
            // Port
            // 
            this.Port.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Port.Location = new System.Drawing.Point(318, 341);
            this.Port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(236, 28);
            this.Port.TabIndex = 1;
            // 
            // ChannelAmount
            // 
            this.ChannelAmount.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChannelAmount.Location = new System.Drawing.Point(318, 471);
            this.ChannelAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChannelAmount.Name = "ChannelAmount";
            this.ChannelAmount.Size = new System.Drawing.Size(236, 28);
            this.ChannelAmount.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(74, 471);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(236, 28);
            this.Title.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(69, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ip адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(69, 445);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(316, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Порт:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(316, 445);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество линий:";
            // 
            // AddDetector
            // 
            this.AddDetector.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddDetector.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDetector.Location = new System.Drawing.Point(74, 560);
            this.AddDetector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddDetector.Name = "AddDetector";
            this.AddDetector.Size = new System.Drawing.Size(238, 37);
            this.AddDetector.TabIndex = 8;
            this.AddDetector.Text = "Добавить";
            this.AddDetector.UseVisualStyleBackColor = true;
            this.AddDetector.Click += new System.EventHandler(this.AddDetector_Click);
            // 
            // RefuceButton
            // 
            this.RefuceButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RefuceButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefuceButton.Location = new System.Drawing.Point(320, 560);
            this.RefuceButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefuceButton.Name = "RefuceButton";
            this.RefuceButton.Size = new System.Drawing.Size(238, 37);
            this.RefuceButton.TabIndex = 9;
            this.RefuceButton.Text = "Отмена";
            this.RefuceButton.UseVisualStyleBackColor = true;
            this.RefuceButton.Click += new System.EventHandler(this.RefuceButton_Click);
            // 
            // RetreiveIP
            // 
            this.RetreiveIP.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RetreiveIP.Location = new System.Drawing.Point(74, 389);
            this.RetreiveIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RetreiveIP.Name = "RetreiveIP";
            this.RetreiveIP.Size = new System.Drawing.Size(236, 32);
            this.RetreiveIP.TabIndex = 10;
            this.RetreiveIP.Text = "Получить";
            this.RetreiveIP.UseVisualStyleBackColor = true;
            this.RetreiveIP.Click += new System.EventHandler(this.RetreiveIP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LevelVisio.Properties.Resources.Detector;
            this.pictureBox1.Location = new System.Drawing.Point(89, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SaveChanges
            // 
            this.SaveChanges.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveChanges.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChanges.Location = new System.Drawing.Point(74, 560);
            this.SaveChanges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(238, 37);
            this.SaveChanges.TabIndex = 12;
            this.SaveChanges.Text = "Сохранить изменения";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // AddingDetectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 628);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RetreiveIP);
            this.Controls.Add(this.RefuceButton);
            this.Controls.Add(this.AddDetector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ChannelAmount);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Ip);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddingDetectorForm";
            this.Text = "AddingDetectorForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ip;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox ChannelAmount;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddDetector;
        private System.Windows.Forms.Button RefuceButton;
        private System.Windows.Forms.Button RetreiveIP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SaveChanges;
    }
}