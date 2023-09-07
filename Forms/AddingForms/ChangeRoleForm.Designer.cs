namespace LevelVisio.Forms.AddingForms
{
    partial class ChangeRoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeRoleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.Comments = new System.Windows.Forms.RichTextBox();
            this.AddRole = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наиментования уровня доступа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Комментарии (не обязательно):";
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(31, 67);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(730, 28);
            this.Title.TabIndex = 2;
            // 
            // Comments
            // 
            this.Comments.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Comments.Location = new System.Drawing.Point(31, 153);
            this.Comments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(730, 153);
            this.Comments.TabIndex = 3;
            this.Comments.Text = "";
            // 
            // AddRole
            // 
            this.AddRole.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddRole.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRole.Location = new System.Drawing.Point(31, 335);
            this.AddRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddRole.Name = "AddRole";
            this.AddRole.Size = new System.Drawing.Size(370, 61);
            this.AddRole.TabIndex = 4;
            this.AddRole.Text = "Добавить";
            this.AddRole.UseVisualStyleBackColor = true;
            this.AddRole.Click += new System.EventHandler(this.AddRole_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(409, 335);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(352, 61);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Закрыть окно";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveChanges
            // 
            this.SaveChanges.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveChanges.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChanges.Location = new System.Drawing.Point(31, 335);
            this.SaveChanges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(370, 61);
            this.SaveChanges.TabIndex = 6;
            this.SaveChanges.Text = "Изменить";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // ChangeRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 436);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddRole);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangeRoleForm";
            this.Text = "LevelVisio - Новый уровень доступа (Редактирование уровня доступа)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddRole;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SaveChanges;
        public System.Windows.Forms.TextBox Title;
        public System.Windows.Forms.RichTextBox Comments;
    }
}