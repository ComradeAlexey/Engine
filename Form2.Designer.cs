namespace Ikos
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SetRotZ = new System.Windows.Forms.TextBox();
            this.SetRotY = new System.Windows.Forms.TextBox();
            this.SetRotX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PositionPanel = new System.Windows.Forms.GroupBox();
            this.SetPosZ = new System.Windows.Forms.TextBox();
            this.SetPosY = new System.Windows.Forms.TextBox();
            this.SetPosX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SetSclZ = new System.Windows.Forms.TextBox();
            this.SetSclY = new System.Windows.Forms.TextBox();
            this.SetSclX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.PositionPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(0, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип объекта";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Куб";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(302, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Икосаэдр";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.PositionPanel);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(0, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 305);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transform";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SetRotZ);
            this.groupBox3.Controls.Add(this.SetRotY);
            this.groupBox3.Controls.Add(this.SetRotX);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(6, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поворот объекта";
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
            // PositionPanel
            // 
            this.PositionPanel.Controls.Add(this.SetPosZ);
            this.PositionPanel.Controls.Add(this.SetPosY);
            this.PositionPanel.Controls.Add(this.SetPosX);
            this.PositionPanel.Controls.Add(this.label8);
            this.PositionPanel.Controls.Add(this.label7);
            this.PositionPanel.Controls.Add(this.label6);
            this.PositionPanel.Location = new System.Drawing.Point(6, 19);
            this.PositionPanel.Name = "PositionPanel";
            this.PositionPanel.Size = new System.Drawing.Size(163, 68);
            this.PositionPanel.TabIndex = 2;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SetSclZ);
            this.groupBox4.Controls.Add(this.SetSclY);
            this.groupBox4.Controls.Add(this.SetSclX);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(6, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 100);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Размер объекта";
            // 
            // SetSclZ
            // 
            this.SetSclZ.Location = new System.Drawing.Point(112, 52);
            this.SetSclZ.Name = "SetSclZ";
            this.SetSclZ.Size = new System.Drawing.Size(44, 20);
            this.SetSclZ.TabIndex = 11;
            // 
            // SetSclY
            // 
            this.SetSclY.Location = new System.Drawing.Point(50, 52);
            this.SetSclY.Name = "SetSclY";
            this.SetSclY.Size = new System.Drawing.Size(41, 20);
            this.SetSclY.TabIndex = 10;
            // 
            // SetSclX
            // 
            this.SetSclX.Location = new System.Drawing.Point(6, 52);
            this.SetSclX.Name = "SetSclX";
            this.SetSclX.Size = new System.Drawing.Size(31, 20);
            this.SetSclX.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(125, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(75, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(20, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 430);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Создание объекта";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.PositionPanel.ResumeLayout(false);
            this.PositionPanel.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox SetSclZ;
        private System.Windows.Forms.TextBox SetSclY;
        private System.Windows.Forms.TextBox SetSclX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox SetRotZ;
        private System.Windows.Forms.TextBox SetRotY;
        private System.Windows.Forms.TextBox SetRotX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox PositionPanel;
        private System.Windows.Forms.TextBox SetPosZ;
        private System.Windows.Forms.TextBox SetPosY;
        private System.Windows.Forms.TextBox SetPosX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}