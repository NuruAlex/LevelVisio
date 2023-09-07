namespace LevelVisio.Forms.AddingForms
{
    partial class ChangeStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeStaffForm));
            this.SaveChanges = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddRole = new System.Windows.Forms.Button();
            this.StaffLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AccessLevels = new System.Windows.Forms.ComboBox();
            this.Posts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Initials = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StaffPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveChanges
            // 
            this.SaveChanges.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveChanges.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChanges.Location = new System.Drawing.Point(53, 517);
            this.SaveChanges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(290, 60);
            this.SaveChanges.TabIndex = 13;
            this.SaveChanges.Text = "Изменить";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(366, 517);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(201, 60);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Закрыть окно";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddRole
            // 
            this.AddRole.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddRole.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRole.Location = new System.Drawing.Point(53, 517);
            this.AddRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddRole.Name = "AddRole";
            this.AddRole.Size = new System.Drawing.Size(290, 60);
            this.AddRole.TabIndex = 11;
            this.AddRole.Text = "Добавить";
            this.AddRole.UseVisualStyleBackColor = true;
            this.AddRole.Click += new System.EventHandler(this.AddStaff_Click);
            // 
            // StaffLogin
            // 
            this.StaffLogin.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaffLogin.Location = new System.Drawing.Point(53, 69);
            this.StaffLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StaffLogin.Name = "StaffLogin";
            this.StaffLogin.Size = new System.Drawing.Size(514, 28);
            this.StaffLogin.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Уровень доступа:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Логин сотрудника";
            // 
            // AccessLevels
            // 
            this.AccessLevels.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccessLevels.FormattingEnabled = true;
            this.AccessLevels.Location = new System.Drawing.Point(51, 352);
            this.AccessLevels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccessLevels.Name = "AccessLevels";
            this.AccessLevels.Size = new System.Drawing.Size(516, 29);
            this.AccessLevels.TabIndex = 14;
            // 
            // Posts
            // 
            this.Posts.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Posts.FormattingEnabled = true;
            this.Posts.Location = new System.Drawing.Point(51, 438);
            this.Posts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Posts.Name = "Posts";
            this.Posts.Size = new System.Drawing.Size(516, 29);
            this.Posts.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 407);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Должность:";
            // 
            // Initials
            // 
            this.Initials.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Initials.Location = new System.Drawing.Point(51, 166);
            this.Initials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Initials.Name = "Initials";
            this.Initials.Size = new System.Drawing.Size(514, 28);
            this.Initials.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(47, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "ФИО сотрудника";
            // 
            // StaffPassword
            // 
            this.StaffPassword.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaffPassword.Location = new System.Drawing.Point(51, 253);
            this.StaffPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StaffPassword.Name = "StaffPassword";
            this.StaffPassword.Size = new System.Drawing.Size(514, 28);
            this.StaffPassword.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(47, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Пароль:";
            // 
            // ChangeStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 617);
            this.Controls.Add(this.StaffPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Initials);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Posts);
            this.Controls.Add(this.AccessLevels);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddRole);
            this.Controls.Add(this.StaffLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangeStaffForm";
            this.Text = "LevelVisio - Редактирование пользователя";
            this.Load += new System.EventHandler(this.ChangeStaffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddRole;
        public System.Windows.Forms.TextBox StaffLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox AccessLevels;
        public System.Windows.Forms.ComboBox Posts;
        public System.Windows.Forms.TextBox Initials;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox StaffPassword;
        private System.Windows.Forms.Label label5;
    }
}