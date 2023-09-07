namespace LevelVisio.Forms.IntermediateForms
{
    partial class StaffListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffListForm));
            this.AddStaffButton = new System.Windows.Forms.Button();
            this.ChangeStaffButton = new System.Windows.Forms.Button();
            this.DeleteStaffButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // AddStaffButton
            // 
            this.AddStaffButton.Location = new System.Drawing.Point(18, 381);
            this.AddStaffButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddStaffButton.Name = "AddStaffButton";
            this.AddStaffButton.Size = new System.Drawing.Size(230, 55);
            this.AddStaffButton.TabIndex = 2;
            this.AddStaffButton.Text = "Добавить пользователя";
            this.AddStaffButton.UseVisualStyleBackColor = true;
            this.AddStaffButton.Click += new System.EventHandler(this.AddStaffButton_Click);
            // 
            // ChangeStaffButton
            // 
            this.ChangeStaffButton.Location = new System.Drawing.Point(256, 381);
            this.ChangeStaffButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChangeStaffButton.Name = "ChangeStaffButton";
            this.ChangeStaffButton.Size = new System.Drawing.Size(243, 55);
            this.ChangeStaffButton.TabIndex = 3;
            this.ChangeStaffButton.Text = "Изменить";
            this.ChangeStaffButton.UseVisualStyleBackColor = true;
            this.ChangeStaffButton.Click += new System.EventHandler(this.ChangeStaffButton_Click);
            // 
            // DeleteStaffButton
            // 
            this.DeleteStaffButton.Location = new System.Drawing.Point(507, 381);
            this.DeleteStaffButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteStaffButton.Name = "DeleteStaffButton";
            this.DeleteStaffButton.Size = new System.Drawing.Size(230, 55);
            this.DeleteStaffButton.TabIndex = 4;
            this.DeleteStaffButton.Text = "Удалить";
            this.DeleteStaffButton.UseVisualStyleBackColor = true;
            this.DeleteStaffButton.Click += new System.EventHandler(this.DeleteStaffButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(18, 446);
            this.SaveChangesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(359, 55);
            this.SaveChangesButton.TabIndex = 5;
            this.SaveChangesButton.Text = "Сохранить изменения";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(385, 446);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(352, 55);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Отменить";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Список пользователей:";
            // 
            // StaffTable
            // 
            this.StaffTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.StaffTable.FullRowSelect = true;
            this.StaffTable.GridLines = true;
            this.StaffTable.HideSelection = false;
            this.StaffTable.HoverSelection = true;
            this.StaffTable.Location = new System.Drawing.Point(18, 73);
            this.StaffTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StaffTable.MultiSelect = false;
            this.StaffTable.Name = "StaffTable";
            this.StaffTable.Size = new System.Drawing.Size(719, 284);
            this.StaffTable.TabIndex = 8;
            this.StaffTable.UseCompatibleStateImageBehavior = false;
            this.StaffTable.View = System.Windows.Forms.View.Details;
            this.StaffTable.DoubleClick += new System.EventHandler(this.StaffTable_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Логин";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Уровень доступа";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 224;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Последний вход";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 350;
            // 
            // StaffListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 537);
            this.Controls.Add(this.StaffTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.DeleteStaffButton);
            this.Controls.Add(this.ChangeStaffButton);
            this.Controls.Add(this.AddStaffButton);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StaffListForm";
            this.Text = "LevelVisio - Список пользователей";
            this.Load += new System.EventHandler(this.StaffListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddStaffButton;
        private System.Windows.Forms.Button ChangeStaffButton;
        private System.Windows.Forms.Button DeleteStaffButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView StaffTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}