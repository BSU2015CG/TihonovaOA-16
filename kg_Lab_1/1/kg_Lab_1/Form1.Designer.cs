namespace kg_Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tbR = new System.Windows.Forms.TrackBar();
            this.tbG = new System.Windows.Forms.TrackBar();
            this.tbB = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbH = new System.Windows.Forms.TrackBar();
            this.tbS = new System.Windows.Forms.TrackBar();
            this.tbV = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.t6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TrackBar();
            this.tbY = new System.Windows.Forms.TrackBar();
            this.tbZ = new System.Windows.Forms.TrackBar();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tX = new System.Windows.Forms.TextBox();
            this.tY = new System.Windows.Forms.TextBox();
            this.tZ = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbC = new System.Windows.Forms.TrackBar();
            this.tC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbM = new System.Windows.Forms.TrackBar();
            this.tbY1 = new System.Windows.Forms.TrackBar();
            this.tK = new System.Windows.Forms.TextBox();
            this.tY1 = new System.Windows.Forms.TextBox();
            this.tM = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbY1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 66);
            this.panel1.TabIndex = 0;
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(56, 11);
            this.tbR.Margin = new System.Windows.Forms.Padding(2);
            this.tbR.Maximum = 255;
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(150, 45);
            this.tbR.TabIndex = 1;
            this.tbR.Scroll += new System.EventHandler(this.R_Scroll);
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(56, 59);
            this.tbG.Margin = new System.Windows.Forms.Padding(2);
            this.tbG.Maximum = 255;
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(150, 45);
            this.tbG.TabIndex = 2;
            this.tbG.Scroll += new System.EventHandler(this.G_Scroll);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(56, 109);
            this.tbB.Margin = new System.Windows.Forms.Padding(2);
            this.tbB.Maximum = 255;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(150, 45);
            this.tbB.TabIndex = 3;
            this.tbB.Scroll += new System.EventHandler(this.B_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Tag = "panel1";
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Tag = "panel1";
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Tag = "panel1";
            this.label3.Text = "B";
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(332, 11);
            this.tbH.Margin = new System.Windows.Forms.Padding(2);
            this.tbH.Maximum = 359;
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(150, 45);
            this.tbH.TabIndex = 7;
            this.tbH.Scroll += new System.EventHandler(this.tbH_Scroll);
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(332, 59);
            this.tbS.Margin = new System.Windows.Forms.Padding(2);
            this.tbS.Maximum = 100;
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(150, 45);
            this.tbS.TabIndex = 8;
            this.tbS.Scroll += new System.EventHandler(this.tbS_Scroll);
            // 
            // tbV
            // 
            this.tbV.Location = new System.Drawing.Point(332, 109);
            this.tbV.Margin = new System.Windows.Forms.Padding(2);
            this.tbV.Maximum = 100;
            this.tbV.Name = "tbV";
            this.tbV.Size = new System.Drawing.Size(150, 45);
            this.tbV.TabIndex = 9;
            this.tbV.Scroll += new System.EventHandler(this.tbV_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 10;
            this.label4.Tag = "panel1";
            this.label4.Text = "H";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Tag = "panel1";
            this.label5.Text = "S";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 12;
            this.label6.Tag = "panel1";
            this.label6.Text = "V";
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(211, 11);
            this.t1.Name = "t1";
            this.t1.ReadOnly = true;
            this.t1.Size = new System.Drawing.Size(27, 20);
            this.t1.TabIndex = 13;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(211, 59);
            this.t2.Name = "t2";
            this.t2.ReadOnly = true;
            this.t2.Size = new System.Drawing.Size(27, 20);
            this.t2.TabIndex = 14;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(211, 108);
            this.t3.Name = "t3";
            this.t3.ReadOnly = true;
            this.t3.Size = new System.Drawing.Size(27, 20);
            this.t3.TabIndex = 15;
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(487, 13);
            this.t4.Name = "t4";
            this.t4.ReadOnly = true;
            this.t4.Size = new System.Drawing.Size(27, 20);
            this.t4.TabIndex = 16;
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(487, 60);
            this.t5.Name = "t5";
            this.t5.ReadOnly = true;
            this.t5.Size = new System.Drawing.Size(27, 20);
            this.t5.TabIndex = 17;
            // 
            // t6
            // 
            this.t6.Location = new System.Drawing.Point(487, 109);
            this.t6.Name = "t6";
            this.t6.ReadOnly = true;
            this.t6.Size = new System.Drawing.Size(27, 20);
            this.t6.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "   ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "   ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "   ";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(561, 11);
            this.tbX.Margin = new System.Windows.Forms.Padding(2);
            this.tbX.Maximum = 100;
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(150, 45);
            this.tbX.TabIndex = 44;
            this.tbX.Scroll += new System.EventHandler(this.tbX_Scroll);
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(561, 59);
            this.tbY.Margin = new System.Windows.Forms.Padding(2);
            this.tbY.Maximum = 100;
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(150, 45);
            this.tbY.TabIndex = 45;
            this.tbY.Scroll += new System.EventHandler(this.tbY_Scroll);
            // 
            // tbZ
            // 
            this.tbZ.Location = new System.Drawing.Point(561, 108);
            this.tbZ.Margin = new System.Windows.Forms.Padding(2);
            this.tbZ.Maximum = 100;
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(150, 45);
            this.tbZ.TabIndex = 46;
            this.tbZ.Scroll += new System.EventHandler(this.tbZ_Scroll);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(543, 20);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 56;
            this.label21.Text = "X";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(543, 67);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 57;
            this.label22.Text = "Y";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(543, 116);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 58;
            this.label23.Text = "Z";
            // 
            // tX
            // 
            this.tX.Location = new System.Drawing.Point(716, 13);
            this.tX.Name = "tX";
            this.tX.ReadOnly = true;
            this.tX.Size = new System.Drawing.Size(27, 20);
            this.tX.TabIndex = 59;
            // 
            // tY
            // 
            this.tY.Location = new System.Drawing.Point(716, 60);
            this.tY.Name = "tY";
            this.tY.ReadOnly = true;
            this.tY.Size = new System.Drawing.Size(27, 20);
            this.tY.TabIndex = 60;
            // 
            // tZ
            // 
            this.tZ.Location = new System.Drawing.Point(716, 109);
            this.tZ.Name = "tZ";
            this.tZ.ReadOnly = true;
            this.tZ.Size = new System.Drawing.Size(27, 20);
            this.tZ.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 197);
            this.panel2.TabIndex = 62;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(561, 206);
            this.tbC.Margin = new System.Windows.Forms.Padding(2);
            this.tbC.Maximum = 100;
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(150, 45);
            this.tbC.TabIndex = 63;
            this.tbC.Scroll += new System.EventHandler(this.tbC_Scroll);
            // 
            // tC
            // 
            this.tC.Location = new System.Drawing.Point(716, 206);
            this.tC.Name = "tC";
            this.tC.ReadOnly = true;
            this.tC.Size = new System.Drawing.Size(27, 20);
            this.tC.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(543, 213);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(543, 268);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "M";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(545, 315);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "Y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(543, 368);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 68;
            this.label13.Text = "K";
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(561, 255);
            this.tbM.Margin = new System.Windows.Forms.Padding(2);
            this.tbM.Maximum = 100;
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(150, 45);
            this.tbM.TabIndex = 69;
            this.tbM.Scroll += new System.EventHandler(this.tbM_Scroll);
            // 
            // tbY1
            // 
            this.tbY1.Location = new System.Drawing.Point(561, 315);
            this.tbY1.Margin = new System.Windows.Forms.Padding(2);
            this.tbY1.Maximum = 100;
            this.tbY1.Name = "tbY1";
            this.tbY1.Size = new System.Drawing.Size(150, 45);
            this.tbY1.TabIndex = 70;
            this.tbY1.Scroll += new System.EventHandler(this.tbY1_Scroll);
            // 
            // tK
            // 
            this.tK.Location = new System.Drawing.Point(561, 365);
            this.tK.Margin = new System.Windows.Forms.Padding(2);
            this.tK.Name = "tK";
            this.tK.ReadOnly = true;
            this.tK.Size = new System.Drawing.Size(150, 20);
            this.tK.TabIndex = 72;
            // 
            // tY1
            // 
            this.tY1.Location = new System.Drawing.Point(716, 315);
            this.tY1.Margin = new System.Windows.Forms.Padding(2);
            this.tY1.Name = "tY1";
            this.tY1.ReadOnly = true;
            this.tY1.Size = new System.Drawing.Size(28, 20);
            this.tY1.TabIndex = 73;
            this.tY1.Text = "0";
            // 
            // tM
            // 
            this.tM.Location = new System.Drawing.Point(716, 261);
            this.tM.Margin = new System.Windows.Forms.Padding(2);
            this.tM.Name = "tM";
            this.tM.ReadOnly = true;
            this.tM.Size = new System.Drawing.Size(28, 20);
            this.tM.TabIndex = 74;
            this.tM.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 478);
            this.Controls.Add(this.tM);
            this.Controls.Add(this.tY1);
            this.Controls.Add(this.tK);
            this.Controls.Add(this.tbY1);
            this.Controls.Add(this.tbM);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tC);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tZ);
            this.Controls.Add(this.tY);
            this.Controls.Add(this.tX);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tbZ);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbV);
            this.Controls.Add(this.tbS);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbY1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar tbR;
        private System.Windows.Forms.TrackBar tbG;
        private System.Windows.Forms.TrackBar tbB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbH;
        private System.Windows.Forms.TrackBar tbS;
        private System.Windows.Forms.TrackBar tbV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tbX;
        private System.Windows.Forms.TrackBar tbY;
        private System.Windows.Forms.TrackBar tbZ;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tX;
        private System.Windows.Forms.TextBox tY;
        private System.Windows.Forms.TextBox tZ;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar tbC;
        private System.Windows.Forms.TextBox tC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar tbM;
        private System.Windows.Forms.TrackBar tbY1;
        private System.Windows.Forms.TextBox tK;
        private System.Windows.Forms.TextBox tY1;
        private System.Windows.Forms.TextBox tM;
    }
}

