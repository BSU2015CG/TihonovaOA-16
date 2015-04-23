namespace Kg1A
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chartGreen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBlue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Средние значения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Синий:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Зеленый:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Красный:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(383, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(382, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(383, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 57);
            this.button1.TabIndex = 11;
            this.button1.Text = "Выбрать картинку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartGreen
            // 
            chartArea4.Name = "ChartArea1";
            this.chartGreen.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartGreen.Legends.Add(legend4);
            this.chartGreen.Location = new System.Drawing.Point(510, 234);
            this.chartGreen.Name = "chartGreen";
            this.chartGreen.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartGreen.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Green};
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Green";
            this.chartGreen.Series.Add(series4);
            this.chartGreen.Size = new System.Drawing.Size(246, 179);
            this.chartGreen.TabIndex = 12;
            this.chartGreen.Text = "chart3";
            // 
            // chartBlue
            // 
            chartArea5.Name = "ChartArea1";
            this.chartBlue.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartBlue.Legends.Add(legend5);
            this.chartBlue.Location = new System.Drawing.Point(261, 234);
            this.chartBlue.Name = "chartBlue";
            this.chartBlue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartBlue.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))))};
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Blue";
            this.chartBlue.Series.Add(series5);
            this.chartBlue.Size = new System.Drawing.Size(243, 179);
            this.chartBlue.TabIndex = 13;
            this.chartBlue.Text = "chart1";
            // 
            // chartRed
            // 
            chartArea6.Name = "ChartArea1";
            this.chartRed.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartRed.Legends.Add(legend6);
            this.chartRed.Location = new System.Drawing.Point(12, 234);
            this.chartRed.Name = "chartRed";
            this.chartRed.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartRed.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Red";
            this.chartRed.Series.Add(series6);
            this.chartRed.Size = new System.Drawing.Size(243, 179);
            this.chartRed.TabIndex = 14;
            this.chartRed.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 425);
            this.Controls.Add(this.chartRed);
            this.Controls.Add(this.chartBlue);
            this.Controls.Add(this.chartGreen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGreen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBlue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRed;
    }
}

