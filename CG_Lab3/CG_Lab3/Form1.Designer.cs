namespace CG_Lab3
{
    partial class Form1
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.rbDDA = new System.Windows.Forms.RadioButton();
            this.rbBresenham = new System.Windows.Forms.RadioButton();
            this.rbStepByStep = new System.Windows.Forms.RadioButton();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearBtn.Location = new System.Drawing.Point(26, 445);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(73, 24);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.TabStop = false;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // rbDDA
            // 
            this.rbDDA.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbDDA.AutoSize = true;
            this.rbDDA.Checked = true;
            this.rbDDA.Location = new System.Drawing.Point(26, 422);
            this.rbDDA.Name = "rbDDA";
            this.rbDDA.Size = new System.Drawing.Size(49, 17);
            this.rbDDA.TabIndex = 2;
            this.rbDDA.TabStop = true;
            this.rbDDA.Text = "ЦДА";
            this.rbDDA.UseVisualStyleBackColor = true;
            this.rbDDA.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbBresenham
            // 
            this.rbBresenham.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbBresenham.AutoSize = true;
            this.rbBresenham.Location = new System.Drawing.Point(26, 376);
            this.rbBresenham.Name = "rbBresenham";
            this.rbBresenham.Size = new System.Drawing.Size(87, 17);
            this.rbBresenham.TabIndex = 3;
            this.rbBresenham.Text = "Брезенхема";
            this.rbBresenham.UseVisualStyleBackColor = true;
            this.rbBresenham.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbStepByStep
            // 
            this.rbStepByStep.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbStepByStep.AutoSize = true;
            this.rbStepByStep.Location = new System.Drawing.Point(26, 399);
            this.rbStepByStep.Name = "rbStepByStep";
            this.rbStepByStep.Size = new System.Drawing.Size(84, 17);
            this.rbStepByStep.TabIndex = 4;
            this.rbStepByStep.Text = "Пошаговый";
            this.rbStepByStep.UseVisualStyleBackColor = true;
            this.rbStepByStep.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // elementHost1
            // 
            this.elementHost1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost1.Location = new System.Drawing.Point(26, 17);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(702, 353);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(277, 399);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 56);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(403, 399);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 56);
            this.listBox2.TabIndex = 8;
            // 
            // listBox3
            // 
            this.listBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(529, 399);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 56);
            this.listBox3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Брезенхема";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Пошаговый";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ЦДА";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Location = new System.Drawing.Point(277, 461);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "--";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox2.Location = new System.Drawing.Point(403, 461);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "--";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox3.Location = new System.Drawing.Point(529, 461);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "--";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 490);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.rbStepByStep);
            this.Controls.Add(this.rbBresenham);
            this.Controls.Add(this.rbDDA);
            this.Controls.Add(this.clearBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.RadioButton rbDDA;
        private System.Windows.Forms.RadioButton rbBresenham;
        private System.Windows.Forms.RadioButton rbStepByStep;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

