namespace Piazza_05
{
    partial class GettingStartedWithGDIPlus
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
            this.eRB = new System.Windows.Forms.RadioButton();
            this.rRB = new System.Windows.Forms.RadioButton();
            this.heightTB = new System.Windows.Forms.TrackBar();
            this.widthTB = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xCoordTB = new System.Windows.Forms.TrackBar();
            this.yCoordTB = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.heightTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoordTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoordTB)).BeginInit();
            this.SuspendLayout();
            // 
            // eRB
            // 
            this.eRB.AutoSize = true;
            this.eRB.Location = new System.Drawing.Point(543, 38);
            this.eRB.Name = "eRB";
            this.eRB.Size = new System.Drawing.Size(55, 17);
            this.eRB.TabIndex = 0;
            this.eRB.Text = "Ellipse";
            this.eRB.UseVisualStyleBackColor = true;
            // 
            // rRB
            // 
            this.rRB.AutoSize = true;
            this.rRB.Checked = true;
            this.rRB.Location = new System.Drawing.Point(543, 15);
            this.rRB.Name = "rRB";
            this.rRB.Size = new System.Drawing.Size(74, 17);
            this.rRB.TabIndex = 1;
            this.rRB.TabStop = true;
            this.rRB.Text = "Rectangle";
            this.rRB.UseVisualStyleBackColor = true;
            this.rRB.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // heightTB
            // 
            this.heightTB.Location = new System.Drawing.Point(592, 127);
            this.heightTB.Maximum = 500;
            this.heightTB.Name = "heightTB";
            this.heightTB.Size = new System.Drawing.Size(104, 45);
            this.heightTB.TabIndex = 2;
            this.heightTB.Value = 250;
            this.heightTB.Scroll += new System.EventHandler(this.displace);
            // 
            // widthTB
            // 
            this.widthTB.Location = new System.Drawing.Point(592, 76);
            this.widthTB.Maximum = 500;
            this.widthTB.Name = "widthTB";
            this.widthTB.Size = new System.Drawing.Size(104, 45);
            this.widthTB.TabIndex = 3;
            this.widthTB.Value = 250;
            this.widthTB.Scroll += new System.EventHandler(this.displace);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "X:";
            // 
            // xCoordTB
            // 
            this.xCoordTB.Location = new System.Drawing.Point(592, 178);
            this.xCoordTB.Maximum = 500;
            this.xCoordTB.Name = "xCoordTB";
            this.xCoordTB.Size = new System.Drawing.Size(104, 45);
            this.xCoordTB.TabIndex = 8;
            this.xCoordTB.Value = 50;
            this.xCoordTB.Scroll += new System.EventHandler(this.displace);
            // 
            // yCoordTB
            // 
            this.yCoordTB.Location = new System.Drawing.Point(592, 229);
            this.yCoordTB.Maximum = 500;
            this.yCoordTB.Name = "yCoordTB";
            this.yCoordTB.Size = new System.Drawing.Size(104, 45);
            this.yCoordTB.TabIndex = 7;
            this.yCoordTB.Value = 50;
            this.yCoordTB.Scroll += new System.EventHandler(this.displace);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.chooseColorForFigure);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(543, 309);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Fill figure";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.Fill_Figure);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(543, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Text Animation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.startTextAnimation);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.startToCreateTheMasterpiece);
            // 
            // GettingStartedWithGDIPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 528);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xCoordTB);
            this.Controls.Add(this.yCoordTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthTB);
            this.Controls.Add(this.heightTB);
            this.Controls.Add(this.rRB);
            this.Controls.Add(this.eRB);
            this.Name = "GettingStartedWithGDIPlus";
            this.Text = "GettingStartedWithGDIPlus";
            ((System.ComponentModel.ISupportInitialize)(this.heightTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoordTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoordTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton eRB;
        private System.Windows.Forms.RadioButton rRB;
        private System.Windows.Forms.TrackBar heightTB;
        private System.Windows.Forms.TrackBar widthTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar xCoordTB;
        private System.Windows.Forms.TrackBar yCoordTB;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}