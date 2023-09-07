namespace LevelVisio.Forms.MainForms
{
    partial class MonitoringForm
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
            this.components = new System.ComponentModel.Container();
            this.Scheme = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StopAlarmButton = new System.Windows.Forms.Button();
            this.buildingsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AlarmSettingsButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.detectorsTree = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.Scheme)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Scheme
            // 
            this.Scheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Scheme.Location = new System.Drawing.Point(17, 16);
            this.Scheme.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Scheme.Name = "Scheme";
            this.Scheme.Size = new System.Drawing.Size(840, 600);
            this.Scheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Scheme.TabIndex = 2;
            this.Scheme.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 619);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(841, 147);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лист сообщений";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(296, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Объект не выбран";
            // 
            // StopAlarmButton
            // 
            this.StopAlarmButton.Location = new System.Drawing.Point(10, 26);
            this.StopAlarmButton.Name = "StopAlarmButton";
            this.StopAlarmButton.Size = new System.Drawing.Size(191, 47);
            this.StopAlarmButton.TabIndex = 1;
            this.StopAlarmButton.Text = "Выключить сигнализацию";
            this.StopAlarmButton.UseVisualStyleBackColor = true;
            this.StopAlarmButton.Click += new System.EventHandler(this.StopAlarmButton_Click);
            // 
            // buildingsComboBox
            // 
            this.buildingsComboBox.FormattingEnabled = true;
            this.buildingsComboBox.Location = new System.Drawing.Point(10, 34);
            this.buildingsComboBox.Name = "buildingsComboBox";
            this.buildingsComboBox.Size = new System.Drawing.Size(211, 27);
            this.buildingsComboBox.TabIndex = 5;
            this.buildingsComboBox.SelectedIndexChanged += new System.EventHandler(this.buildingsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выбрать другой объект:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.detectorsTree);
            this.panel1.Controls.Add(this.buildingsComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(869, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 766);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Объекты на схеме:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StopAlarmButton);
            this.groupBox3.Location = new System.Drawing.Point(10, 619);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 144);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Действия";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AlarmSettingsButton);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(10, 480);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 138);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки";
            // 
            // AlarmSettingsButton
            // 
            this.AlarmSettingsButton.Location = new System.Drawing.Point(10, 74);
            this.AlarmSettingsButton.Name = "AlarmSettingsButton";
            this.AlarmSettingsButton.Size = new System.Drawing.Size(191, 48);
            this.AlarmSettingsButton.TabIndex = 8;
            this.AlarmSettingsButton.Text = "Настройки сигнализации";
            this.AlarmSettingsButton.UseVisualStyleBackColor = true;
            this.AlarmSettingsButton.Click += new System.EventHandler(this.AlarmSettingsButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 48);
            this.button3.TabIndex = 9;
            this.button3.Text = "Настройки отображения";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.detectorsTree_DoubleClick);
            // 
            // detectorsTree
            // 
            this.detectorsTree.Location = new System.Drawing.Point(10, 98);
            this.detectorsTree.Name = "detectorsTree";
            this.detectorsTree.Size = new System.Drawing.Size(211, 376);
            this.detectorsTree.TabIndex = 7;
            this.detectorsTree.DoubleClick += new System.EventHandler(this.detectorsTree_DoubleClick);
            // 
            // MonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Scheme);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MonitoringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonitoringForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MonitoringForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Scheme)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Scheme;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StopAlarmButton;
        private System.Windows.Forms.ComboBox buildingsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView detectorsTree;
        private System.Windows.Forms.Button AlarmSettingsButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
    }
}