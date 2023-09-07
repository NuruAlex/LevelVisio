namespace LevelVisio.Forms.SettingsForms
{
    partial class PersonalSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalSettingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InitialsTextBox = new System.Windows.Forms.TextBox();
            this.Posts = new System.Windows.Forms.ComboBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RepeatedPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваше ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите должность";
            // 
            // InitialsTextBox
            // 
            this.InitialsTextBox.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InitialsTextBox.Location = new System.Drawing.Point(17, 65);
            this.InitialsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InitialsTextBox.Name = "InitialsTextBox";
            this.InitialsTextBox.Size = new System.Drawing.Size(692, 28);
            this.InitialsTextBox.TabIndex = 1;
            // 
            // Posts
            // 
            this.Posts.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Posts.FormattingEnabled = true;
            this.Posts.Location = new System.Drawing.Point(17, 149);
            this.Posts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Posts.Name = "Posts";
            this.Posts.Size = new System.Drawing.Size(692, 29);
            this.Posts.TabIndex = 2;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChangesButton.Location = new System.Drawing.Point(17, 351);
            this.SaveChangesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(347, 41);
            this.SaveChangesButton.TabIndex = 5;
            this.SaveChangesButton.Text = "Сохранить изменения";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(375, 351);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(334, 41);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Отменить";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewPassword
            // 
            this.NewPassword.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPassword.Location = new System.Drawing.Point(21, 289);
            this.NewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(343, 28);
            this.NewPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите новый пароль";
            // 
            // RepeatedPassword
            // 
            this.RepeatedPassword.Location = new System.Drawing.Point(372, 289);
            this.RepeatedPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RepeatedPassword.Name = "RepeatedPassword";
            this.RepeatedPassword.Size = new System.Drawing.Size(337, 28);
            this.RepeatedPassword.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(368, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Повторите новый пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Изменить пароль:";
            // 
            // PersonalSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 433);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.RepeatedPassword);
            this.Controls.Add(this.Posts);
            this.Controls.Add(this.InitialsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PersonalSettingForm";
            this.Text = "LevelVisio - Персональные настройки";
            this.Load += new System.EventHandler(this.PrsonalSettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InitialsTextBox;
        private System.Windows.Forms.ComboBox Posts;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RepeatedPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}