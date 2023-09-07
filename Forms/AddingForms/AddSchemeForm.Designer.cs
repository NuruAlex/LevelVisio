namespace LevelVisio.Forms.AddingForms
{
    partial class AddSchemeForm
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
            this.realLenght = new System.Windows.Forms.Label();
            this.SetDetector = new System.Windows.Forms.Button();
            this.detectors = new System.Windows.Forms.ComboBox();
            this.hint = new System.Windows.Forms.Label();
            this.realWidth = new CustomControls.RotatedLabel();
            this.realWidth1 = new CustomControls.RotatedLabel();
            this.detectorsLabel = new System.Windows.Forms.Label();
            this.ChannelsComboBox = new System.Windows.Forms.ComboBox();
            this.channelsHint = new System.Windows.Forms.Label();
            this.endPaintChannel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.VisualSettingsButton = new System.Windows.Forms.GroupBox();
            this.EndEditButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.detectorsTree = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.Scheme)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.VisualSettingsButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // Scheme
            // 
            this.Scheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Scheme.Location = new System.Drawing.Point(41, 35);
            this.Scheme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Scheme.Name = "Scheme";
            this.Scheme.Size = new System.Drawing.Size(733, 514);
            this.Scheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Scheme.TabIndex = 1;
            this.Scheme.TabStop = false;
            this.Scheme.Paint += new System.Windows.Forms.PaintEventHandler(this.Scheme_Paint);
            this.Scheme.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Scheme_MouseDown);
            this.Scheme.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Scheme_MouseMove);
            this.Scheme.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Scheme_MouseUp);
            // 
            // realLenght
            // 
            this.realLenght.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.realLenght.AutoSize = true;
            this.realLenght.Location = new System.Drawing.Point(396, 9);
            this.realLenght.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.realLenght.Name = "realLenght";
            this.realLenght.Size = new System.Drawing.Size(23, 21);
            this.realLenght.TabIndex = 4;
            this.realLenght.Text = "1 ";
            // 
            // SetDetector
            // 
            this.SetDetector.Location = new System.Drawing.Point(30, 26);
            this.SetDetector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetDetector.Name = "SetDetector";
            this.SetDetector.Size = new System.Drawing.Size(269, 37);
            this.SetDetector.TabIndex = 6;
            this.SetDetector.Text = "Расположить извещатель";
            this.SetDetector.UseVisualStyleBackColor = true;
            this.SetDetector.Click += new System.EventHandler(this.SelectDetector_Click);
            // 
            // detectors
            // 
            this.detectors.FormattingEnabled = true;
            this.detectors.Location = new System.Drawing.Point(30, 96);
            this.detectors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detectors.Name = "detectors";
            this.detectors.Size = new System.Drawing.Size(269, 29);
            this.detectors.TabIndex = 7;
            this.detectors.Visible = false;
            this.detectors.SelectedIndexChanged += new System.EventHandler(this.Detectors_SelectedIndexChanged);
            // 
            // hint
            // 
            this.hint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hint.AutoSize = true;
            this.hint.Enabled = false;
            this.hint.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hint.Location = new System.Drawing.Point(37, 554);
            this.hint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(85, 21);
            this.hint.TabIndex = 8;
            this.hint.Text = "Подсказка";
            // 
            // realWidth
            // 
            this.realWidth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.realWidth.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realWidth.Location = new System.Drawing.Point(-13, 255);
            this.realWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.realWidth.Name = "realWidth";
            this.realWidth.RotatedText = "100";
            this.realWidth.RotationAngle = -90;
            this.realWidth.Size = new System.Drawing.Size(46, 62);
            this.realWidth.StartTextPosition = new System.Drawing.Point(20, 50);
            this.realWidth.TabIndex = 11;
            this.realWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // realWidth1
            // 
            this.realWidth1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.realWidth1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realWidth1.Location = new System.Drawing.Point(782, 244);
            this.realWidth1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.realWidth1.Name = "realWidth1";
            this.realWidth1.RotatedText = "100";
            this.realWidth1.RotationAngle = 90;
            this.realWidth1.Size = new System.Drawing.Size(37, 73);
            this.realWidth1.StartTextPosition = new System.Drawing.Point(20, 20);
            this.realWidth1.TabIndex = 10;
            this.realWidth1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // detectorsLabel
            // 
            this.detectorsLabel.AutoSize = true;
            this.detectorsLabel.Location = new System.Drawing.Point(26, 70);
            this.detectorsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detectorsLabel.Name = "detectorsLabel";
            this.detectorsLabel.Size = new System.Drawing.Size(246, 21);
            this.detectorsLabel.TabIndex = 12;
            this.detectorsLabel.Text = "Выберите извещатель из списка:\r\n";
            this.detectorsLabel.Visible = false;
            // 
            // ChannelsComboBox
            // 
            this.ChannelsComboBox.FormattingEnabled = true;
            this.ChannelsComboBox.Location = new System.Drawing.Point(42, 52);
            this.ChannelsComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChannelsComboBox.Name = "ChannelsComboBox";
            this.ChannelsComboBox.Size = new System.Drawing.Size(298, 29);
            this.ChannelsComboBox.TabIndex = 13;
            this.ChannelsComboBox.Visible = false;
            this.ChannelsComboBox.SelectedIndexChanged += new System.EventHandler(this.Channels_SelectedIndexChanged);
            // 
            // channelsHint
            // 
            this.channelsHint.AutoSize = true;
            this.channelsHint.Location = new System.Drawing.Point(14, 26);
            this.channelsHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.channelsHint.Name = "channelsHint";
            this.channelsHint.Size = new System.Drawing.Size(343, 21);
            this.channelsHint.TabIndex = 14;
            this.channelsHint.Text = "Выберите линию для проведения/изменения:";
            this.channelsHint.Visible = false;
            // 
            // endPaintChannel
            // 
            this.endPaintChannel.Location = new System.Drawing.Point(42, 138);
            this.endPaintChannel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endPaintChannel.Name = "endPaintChannel";
            this.endPaintChannel.Size = new System.Drawing.Size(300, 37);
            this.endPaintChannel.TabIndex = 15;
            this.endPaintChannel.Text = "Завершить";
            this.endPaintChannel.UseVisualStyleBackColor = true;
            this.endPaintChannel.Visible = false;
            this.endPaintChannel.Click += new System.EventHandler(this.EndPaintChannel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.Cancel);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.SetDetector);
            this.groupBox1.Controls.Add(this.detectors);
            this.groupBox1.Controls.Add(this.detectorsLabel);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(41, 580);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(333, 190);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(30, 138);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(269, 37);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(30, 138);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(269, 37);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChannelsComboBox);
            this.groupBox2.Controls.Add(this.channelsHint);
            this.groupBox2.Controls.Add(this.endPaintChannel);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(382, 580);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(392, 190);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.VisualSettingsButton);
            this.panel1.Controls.Add(this.detectorsTree);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(826, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 786);
            this.panel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Объекты на схеме:";
            // 
            // VisualSettingsButton
            // 
            this.VisualSettingsButton.Controls.Add(this.EndEditButton);
            this.VisualSettingsButton.Controls.Add(this.EditButton);
            this.VisualSettingsButton.Controls.Add(this.button3);
            this.VisualSettingsButton.Location = new System.Drawing.Point(10, 580);
            this.VisualSettingsButton.Name = "VisualSettingsButton";
            this.VisualSettingsButton.Size = new System.Drawing.Size(225, 190);
            this.VisualSettingsButton.TabIndex = 10;
            this.VisualSettingsButton.TabStop = false;
            this.VisualSettingsButton.Text = "Действия";
            // 
            // EndEditButton
            // 
            this.EndEditButton.Location = new System.Drawing.Point(10, 123);
            this.EndEditButton.Name = "EndEditButton";
            this.EndEditButton.Size = new System.Drawing.Size(201, 37);
            this.EndEditButton.TabIndex = 10;
            this.EndEditButton.Text = "Завешить";
            this.EndEditButton.UseVisualStyleBackColor = true;
            this.EndEditButton.Visible = false;
            this.EndEditButton.Click += new System.EventHandler(this.EndEditButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(10, 138);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(201, 37);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Настройки отображения";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DetectorsTree_DoubleClick);
            // 
            // detectorsTree
            // 
            this.detectorsTree.Location = new System.Drawing.Point(10, 35);
            this.detectorsTree.Name = "detectorsTree";
            this.detectorsTree.Size = new System.Drawing.Size(225, 514);
            this.detectorsTree.TabIndex = 7;
            this.detectorsTree.DoubleClick += new System.EventHandler(this.DetectorsTree_DoubleClick);
            // 
            // AddSchemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 786);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.realWidth);
            this.Controls.Add(this.realWidth1);
            this.Controls.Add(this.realLenght);
            this.Controls.Add(this.Scheme);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddSchemeForm";
            this.Text = "LevelVisio- Разметка схемы";
            ((System.ComponentModel.ISupportInitialize)(this.Scheme)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.VisualSettingsButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox Scheme;
    private System.Windows.Forms.Label realLenght;
    private System.Windows.Forms.Button SetDetector;
    private System.Windows.Forms.ComboBox detectors;
    private System.Windows.Forms.Label hint;
    private CustomControls.RotatedLabel realWidth1;
    private CustomControls.RotatedLabel realWidth;
    private System.Windows.Forms.Label detectorsLabel;
    private System.Windows.Forms.ComboBox ChannelsComboBox;
    private System.Windows.Forms.Label channelsHint;
    private System.Windows.Forms.Button endPaintChannel;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox VisualSettingsButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TreeView detectorsTree;
        private System.Windows.Forms.Button EndEditButton;
        private System.Windows.Forms.Button Cancel;
    }
}