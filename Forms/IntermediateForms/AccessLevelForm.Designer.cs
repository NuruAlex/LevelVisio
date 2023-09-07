namespace LevelVisio.Forms.IntermediateForms
{
    partial class AccessLevelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessLevelForm));
            this.label1 = new System.Windows.Forms.Label();
            this.AddRoleButton = new System.Windows.Forms.Button();
            this.ChangeRoleButton = new System.Windows.Forms.Button();
            this.DeleteRoleButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RolesList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список ролей:";
            // 
            // AddRoleButton
            // 
            this.AddRoleButton.Location = new System.Drawing.Point(18, 435);
            this.AddRoleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddRoleButton.Name = "AddRoleButton";
            this.AddRoleButton.Size = new System.Drawing.Size(236, 55);
            this.AddRoleButton.TabIndex = 2;
            this.AddRoleButton.Text = "Добавить новую роль";
            this.AddRoleButton.UseVisualStyleBackColor = true;
            this.AddRoleButton.Click += new System.EventHandler(this.AddRoleButton_Click);
            // 
            // ChangeRoleButton
            // 
            this.ChangeRoleButton.Location = new System.Drawing.Point(262, 435);
            this.ChangeRoleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChangeRoleButton.Name = "ChangeRoleButton";
            this.ChangeRoleButton.Size = new System.Drawing.Size(236, 55);
            this.ChangeRoleButton.TabIndex = 3;
            this.ChangeRoleButton.Text = "Изменить роль";
            this.ChangeRoleButton.UseVisualStyleBackColor = true;
            this.ChangeRoleButton.Click += new System.EventHandler(this.ChangeRoleButton_Click);
            // 
            // DeleteRoleButton
            // 
            this.DeleteRoleButton.Location = new System.Drawing.Point(508, 435);
            this.DeleteRoleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteRoleButton.Name = "DeleteRoleButton";
            this.DeleteRoleButton.Size = new System.Drawing.Size(236, 55);
            this.DeleteRoleButton.TabIndex = 4;
            this.DeleteRoleButton.Text = "Удалить роль";
            this.DeleteRoleButton.UseVisualStyleBackColor = true;
            this.DeleteRoleButton.Click += new System.EventHandler(this.DeleteRoleButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(18, 500);
            this.SaveChangesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(341, 55);
            this.SaveChangesButton.TabIndex = 5;
            this.SaveChangesButton.Text = "Сохранить изменения";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // CancelButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(367, 500);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "CancelButton";
            this.ExitButton.Size = new System.Drawing.Size(377, 55);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Отменить";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RolesTable
            // 
            this.RolesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.RolesList.FullRowSelect = true;
            this.RolesList.GridLines = true;
            this.RolesList.HideSelection = false;
            this.RolesList.HoverSelection = true;
            this.RolesList.Location = new System.Drawing.Point(20, 48);
            this.RolesList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RolesList.MultiSelect = false;
            this.RolesList.Name = "RolesTable";
            this.RolesList.Size = new System.Drawing.Size(724, 358);
            this.RolesList.TabIndex = 9;
            this.RolesList.UseCompatibleStateImageBehavior = false;
            this.RolesList.View = System.Windows.Forms.View.Details;
            this.RolesList.DoubleClick += new System.EventHandler(this.RolesTable_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Наименование уровня доступа";
            this.columnHeader1.Width = 719;
            // 
            // AccessLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 573);
            this.Controls.Add(this.RolesList);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.DeleteRoleButton);
            this.Controls.Add(this.ChangeRoleButton);
            this.Controls.Add(this.AddRoleButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AccessLevelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelVisio - Настройка уровня доступа";
            this.Load += new System.EventHandler(this.AccessLevelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddRoleButton;
        private System.Windows.Forms.Button ChangeRoleButton;
        private System.Windows.Forms.Button DeleteRoleButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListView RolesList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}