namespace Icosahedron
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MyPictureBox = new System.Windows.Forms.PictureBox();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lengthOfTriangle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.CubeRadiobutton = new System.Windows.Forms.RadioButton();
            this.Icosahedron = new System.Windows.Forms.RadioButton();
            this.LeftGroupBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.RightBelowGroupBox = new System.Windows.Forms.GroupBox();
            this.RotationRadioButton = new System.Windows.Forms.RadioButton();
            this.MoveRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColorBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PositionPanel = new System.Windows.Forms.GroupBox();
            this.SetPosZ = new System.Windows.Forms.TextBox();
            this.SetPosY = new System.Windows.Forms.TextBox();
            this.SetPosX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SetRotZ = new System.Windows.Forms.TextBox();
            this.SetRotY = new System.Windows.Forms.TextBox();
            this.SetRotX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.LeftGroupBox.SuspendLayout();
            this.RightBelowGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PositionPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyPictureBox
            // 
            this.MyPictureBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MyPictureBox.Location = new System.Drawing.Point(0, 30);
            this.MyPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.MyPictureBox.Name = "MyPictureBox";
            this.MyPictureBox.Size = new System.Drawing.Size(601, 414);
            this.MyPictureBox.TabIndex = 0;
            this.MyPictureBox.TabStop = false;
            this.MyPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.MyPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.MyPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.MyPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(8, 99);
            this.trackBarX.Maximum = 30;
            this.trackBarX.Minimum = -30;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(154, 45);
            this.trackBarX.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(8, 272);
            this.trackBarSpeed.Maximum = 200;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(154, 45);
            this.trackBarSpeed.TabIndex = 6;
            this.trackBarSpeed.ValueChanged += new System.EventHandler(this.trackBarSpeed_ValueChanged);
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(5, 162);
            this.trackBarY.Maximum = 30;
            this.trackBarY.Minimum = -30;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(157, 45);
            this.trackBarY.TabIndex = 7;
            // 
            // trackBarZ
            // 
            this.trackBarZ.Location = new System.Drawing.Point(8, 221);
            this.trackBarZ.Maximum = 30;
            this.trackBarZ.Minimum = -30;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(154, 45);
            this.trackBarZ.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Угловая скорость";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Остановить вращение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lengthOfTriangle
            // 
            this.lengthOfTriangle.Location = new System.Drawing.Point(5, 54);
            this.lengthOfTriangle.Name = "lengthOfTriangle";
            this.lengthOfTriangle.Size = new System.Drawing.Size(72, 20);
            this.lengthOfTriangle.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Длина грани";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpen,
            this.FileSave});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // FileOpen
            // 
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.Size = new System.Drawing.Size(132, 22);
            this.FileOpen.Text = "Открыть";
            // 
            // FileSave
            // 
            this.FileSave.Name = "FileSave";
            this.FileSave.Size = new System.Drawing.Size(132, 22);
            this.FileSave.Text = "Сохранить";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // CubeRadiobutton
            // 
            this.CubeRadiobutton.AutoSize = true;
            this.CubeRadiobutton.Location = new System.Drawing.Point(16, 23);
            this.CubeRadiobutton.Name = "CubeRadiobutton";
            this.CubeRadiobutton.Size = new System.Drawing.Size(43, 17);
            this.CubeRadiobutton.TabIndex = 19;
            this.CubeRadiobutton.Text = "Куб";
            this.CubeRadiobutton.UseVisualStyleBackColor = true;
            this.CubeRadiobutton.CheckedChanged += new System.EventHandler(this.Cube_CheckedChanged);
            // 
            // Icosahedron
            // 
            this.Icosahedron.AutoSize = true;
            this.Icosahedron.Location = new System.Drawing.Point(17, 46);
            this.Icosahedron.Name = "Icosahedron";
            this.Icosahedron.Size = new System.Drawing.Size(75, 17);
            this.Icosahedron.TabIndex = 20;
            this.Icosahedron.Tag = "1";
            this.Icosahedron.Text = "Икосаэдр";
            this.Icosahedron.UseVisualStyleBackColor = true;
            this.Icosahedron.CheckedChanged += new System.EventHandler(this.Icosahedron_CheckedChanged);
            // 
            // LeftGroupBox
            // 
            this.LeftGroupBox.Controls.Add(this.button2);
            this.LeftGroupBox.Controls.Add(this.label5);
            this.LeftGroupBox.Controls.Add(this.lengthOfTriangle);
            this.LeftGroupBox.Controls.Add(this.button1);
            this.LeftGroupBox.Controls.Add(this.trackBarX);
            this.LeftGroupBox.Controls.Add(this.trackBarSpeed);
            this.LeftGroupBox.Controls.Add(this.label4);
            this.LeftGroupBox.Controls.Add(this.label1);
            this.LeftGroupBox.Controls.Add(this.label3);
            this.LeftGroupBox.Controls.Add(this.trackBarY);
            this.LeftGroupBox.Controls.Add(this.trackBarZ);
            this.LeftGroupBox.Controls.Add(this.label2);
            this.LeftGroupBox.Location = new System.Drawing.Point(621, 30);
            this.LeftGroupBox.Name = "LeftGroupBox";
            this.LeftGroupBox.Size = new System.Drawing.Size(195, 407);
            this.LeftGroupBox.TabIndex = 21;
            this.LeftGroupBox.TabStop = false;
            this.LeftGroupBox.Text = "Параметры:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(81, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 44);
            this.button2.TabIndex = 18;
            this.button2.Text = "Создать объект";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RightBelowGroupBox
            // 
            this.RightBelowGroupBox.Controls.Add(this.RotationRadioButton);
            this.RightBelowGroupBox.Controls.Add(this.MoveRadioButton);
            this.RightBelowGroupBox.Location = new System.Drawing.Point(822, 210);
            this.RightBelowGroupBox.Name = "RightBelowGroupBox";
            this.RightBelowGroupBox.Size = new System.Drawing.Size(115, 86);
            this.RightBelowGroupBox.TabIndex = 22;
            this.RightBelowGroupBox.TabStop = false;
            this.RightBelowGroupBox.Text = "Тип указателя:";
            // 
            // RotationRadioButton
            // 
            this.RotationRadioButton.AutoSize = true;
            this.RotationRadioButton.Location = new System.Drawing.Point(17, 44);
            this.RotationRadioButton.Name = "RotationRadioButton";
            this.RotationRadioButton.Size = new System.Drawing.Size(77, 17);
            this.RotationRadioButton.TabIndex = 23;
            this.RotationRadioButton.Text = "Вращение";
            this.RotationRadioButton.UseVisualStyleBackColor = true;
            this.RotationRadioButton.CheckedChanged += new System.EventHandler(this.RotationRadioButton_CheckedChanged);
            // 
            // MoveRadioButton
            // 
            this.MoveRadioButton.AutoSize = true;
            this.MoveRadioButton.Checked = true;
            this.MoveRadioButton.Location = new System.Drawing.Point(17, 19);
            this.MoveRadioButton.Name = "MoveRadioButton";
            this.MoveRadioButton.Size = new System.Drawing.Size(98, 17);
            this.MoveRadioButton.TabIndex = 0;
            this.MoveRadioButton.TabStop = true;
            this.MoveRadioButton.Text = "Перемещение";
            this.MoveRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MoveRadioButton.UseVisualStyleBackColor = true;
            this.MoveRadioButton.CheckedChanged += new System.EventHandler(this.MoveRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CubeRadiobutton);
            this.groupBox1.Controls.Add(this.Icosahedron);
            this.groupBox1.Location = new System.Drawing.Point(822, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 90);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип фигуры:";
            // 
            // ColorBox
            // 
            this.ColorBox.AutoSize = true;
            this.ColorBox.Location = new System.Drawing.Point(838, 139);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(51, 17);
            this.ColorBox.TabIndex = 24;
            this.ColorBox.Text = "Цвет";
            this.ColorBox.UseVisualStyleBackColor = true;
            this.ColorBox.CheckedChanged += new System.EventHandler(this.ColorBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.PositionPanel);
            this.panel1.Location = new System.Drawing.Point(943, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 414);
            this.panel1.TabIndex = 25;
            // 
            // PositionPanel
            // 
            this.PositionPanel.Controls.Add(this.SetPosZ);
            this.PositionPanel.Controls.Add(this.SetPosY);
            this.PositionPanel.Controls.Add(this.SetPosX);
            this.PositionPanel.Controls.Add(this.label8);
            this.PositionPanel.Controls.Add(this.label7);
            this.PositionPanel.Controls.Add(this.label6);
            this.PositionPanel.Location = new System.Drawing.Point(3, 3);
            this.PositionPanel.Name = "PositionPanel";
            this.PositionPanel.Size = new System.Drawing.Size(163, 60);
            this.PositionPanel.TabIndex = 0;
            this.PositionPanel.TabStop = false;
            this.PositionPanel.Text = "Позиция объекта";
            // 
            // SetPosZ
            // 
            this.SetPosZ.Location = new System.Drawing.Point(112, 40);
            this.SetPosZ.Name = "SetPosZ";
            this.SetPosZ.Size = new System.Drawing.Size(44, 20);
            this.SetPosZ.TabIndex = 5;
            // 
            // SetPosY
            // 
            this.SetPosY.Location = new System.Drawing.Point(50, 40);
            this.SetPosY.Name = "SetPosY";
            this.SetPosY.Size = new System.Drawing.Size(41, 20);
            this.SetPosY.TabIndex = 4;
            // 
            // SetPosX
            // 
            this.SetPosX.Location = new System.Drawing.Point(6, 40);
            this.SetPosX.Name = "SetPosX";
            this.SetPosX.Size = new System.Drawing.Size(31, 20);
            this.SetPosX.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(125, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(75, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(20, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(823, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "label9";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SetRotZ);
            this.groupBox2.Controls.Add(this.SetRotY);
            this.groupBox2.Controls.Add(this.SetRotX);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(3, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поворот объекта";
            // 
            // SetRotZ
            // 
            this.SetRotZ.Location = new System.Drawing.Point(112, 52);
            this.SetRotZ.Name = "SetRotZ";
            this.SetRotZ.Size = new System.Drawing.Size(44, 20);
            this.SetRotZ.TabIndex = 11;
            // 
            // SetRotY
            // 
            this.SetRotY.Location = new System.Drawing.Point(50, 52);
            this.SetRotY.Name = "SetRotY";
            this.SetRotY.Size = new System.Drawing.Size(41, 20);
            this.SetRotY.TabIndex = 10;
            // 
            // SetRotX
            // 
            this.SetRotX.Location = new System.Drawing.Point(6, 52);
            this.SetRotX.Name = "SetRotX";
            this.SetRotX.Size = new System.Drawing.Size(31, 20);
            this.SetRotX.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(125, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Z";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(75, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(20, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 449);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RightBelowGroupBox);
            this.Controls.Add(this.LeftGroupBox);
            this.Controls.Add(this.MyPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LeftGroupBox.ResumeLayout(false);
            this.LeftGroupBox.PerformLayout();
            this.RightBelowGroupBox.ResumeLayout(false);
            this.RightBelowGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.PositionPanel.ResumeLayout(false);
            this.PositionPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MyPictureBox;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.TrackBar trackBarZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lengthOfTriangle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileOpen;
        private System.Windows.Forms.ToolStripMenuItem FileSave;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.RadioButton CubeRadiobutton;
        private System.Windows.Forms.RadioButton Icosahedron;
        private System.Windows.Forms.GroupBox LeftGroupBox;
        private System.Windows.Forms.GroupBox RightBelowGroupBox;
        private System.Windows.Forms.RadioButton RotationRadioButton;
        private System.Windows.Forms.RadioButton MoveRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ColorBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox PositionPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SetPosZ;
        private System.Windows.Forms.TextBox SetPosY;
        private System.Windows.Forms.TextBox SetPosX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SetRotZ;
        private System.Windows.Forms.TextBox SetRotY;
        private System.Windows.Forms.TextBox SetRotX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

