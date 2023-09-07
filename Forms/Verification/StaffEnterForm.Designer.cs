namespace LevelVisio.Forms.VerificationForms
{
    partial class StaffEnterForm
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
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.rememberMe = new System.Windows.Forms.CheckBox();
            this.lockPicture = new System.Windows.Forms.PictureBox();
            this.unlockPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unlockPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(53, 204);
            this.password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(547, 28);
            this.password.TabIndex = 67;
            this.password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 66;
            this.label1.Text = "Логин:";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(53, 67);
            this.login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(588, 28);
            this.login.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(47, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 64;
            this.label5.Text = "Пароль:";
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.Location = new System.Drawing.Point(53, 264);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(288, 60);
            this.EnterButton.TabIndex = 78;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(348, 264);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(295, 60);
            this.ExitButton.TabIndex = 79;
            this.ExitButton.Text = "Закрыть окно";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // rememberMe
            // 
            this.rememberMe.AutoSize = true;
            this.rememberMe.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rememberMe.Location = new System.Drawing.Point(53, 119);
            this.rememberMe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rememberMe.Name = "rememberMe";
            this.rememberMe.Size = new System.Drawing.Size(167, 25);
            this.rememberMe.TabIndex = 80;
            this.rememberMe.Text = " - Запомнить логин";
            this.rememberMe.UseVisualStyleBackColor = true;
            // 
            // lockPicture
            // 
            this.lockPicture.Image = global::LevelVisio.Properties.Resources.crossed_eye;
            this.lockPicture.Location = new System.Drawing.Point(611, 201);
            this.lockPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lockPicture.Name = "lockPicture";
            this.lockPicture.Size = new System.Drawing.Size(32, 32);
            this.lockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockPicture.TabIndex = 81;
            this.lockPicture.TabStop = false;
            this.lockPicture.Click += new System.EventHandler(this.unlockPicture_Click);
            // 
            // unlockPicture
            // 
            this.unlockPicture.Image = global::LevelVisio.Properties.Resources.eye;
            this.unlockPicture.Location = new System.Drawing.Point(611, 200);
            this.unlockPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unlockPicture.Name = "unlockPicture";
            this.unlockPicture.Size = new System.Drawing.Size(32, 32);
            this.unlockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.unlockPicture.TabIndex = 82;
            this.unlockPicture.TabStop = false;
            this.unlockPicture.Click += new System.EventHandler(this.unlockPicture_Click);
            // 
            // StaffEnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 355);
            this.Controls.Add(this.unlockPicture);
            this.Controls.Add(this.lockPicture);
            this.Controls.Add(this.rememberMe);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.login);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "StaffEnterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelVisio - Авторизация";
            this.Load += new System.EventHandler(this.StaffEnterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unlockPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox rememberMe;
        private System.Windows.Forms.PictureBox lockPicture;
        private System.Windows.Forms.PictureBox unlockPicture;
    }
}