using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kg1A
{
    public partial class Form1 : Form
    {
        int R, G, B;
        double AverageRed, AverageBlue, AverageGreen;
        public int[] RedArray;
        public int[] GreenArray;
        public int[] BlueArray;
        private Image image;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();
            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += BackgroundWorkerFunction;
            backgroundWorker1.RunWorkerCompleted += GraphicsInfo;
        }

        void BackgroundWorkerFunction(object sender, DoWorkEventArgs e)
        {
            R = 0;
            G = 0;
            B = 0;
            OpenFileDialog OpenFileDialog = (OpenFileDialog)e.Argument;
            FileStream fileStream = File.Open(OpenFileDialog.FileName, FileMode.Open);
            image = Image.FromStream(fileStream, false, false);
            CalculateColors(image);
        }

        public void CalculateColors(Image Image)
        {
            if (Image != null)
            {
                Bitmap bitMap = new Bitmap(image);
                RedArray = new int[256];
                GreenArray = new int[256];
                BlueArray = new int[256];
                Color Color;
                for (int i = 0; i < bitMap.Width; ++i)
                {
                    for (int j = 0; j < bitMap.Height; ++j)
                    {
                        Color = bitMap.GetPixel(i, j);
                        ++RedArray[Color.R];
                        ++GreenArray[Color.G];
                        ++BlueArray[Color.B];
                        R += Color.R;
                        B += Color.B;
                        G += Color.G;
                    }
                }
            }
        }

        void GraphicsInfo(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Image = image;
            chartRed.Series["Red"].Points.Clear();
            chartGreen.Series["Green"].Points.Clear();
            chartBlue.Series["Blue"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                chartRed.Series["Red"].Points.AddXY(i, RedArray[i]);
                chartGreen.Series["Green"].Points.AddXY(i, GreenArray[i]);
                chartBlue.Series["Blue"].Points.AddXY(i, BlueArray[i]);
            }
            CalculateAveragesValues();

        }

        void CalculateAveragesValues()
        {
            textBox1.Text = (R / (image.Width * image.Height)).ToString();
            textBox2.Text = (G / (image.Width * image.Height)).ToString();
            textBox3.Text = (B / (image.Width * image.Height)).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.Title = "Выберите картинку:";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                backgroundWorker1.RunWorkerAsync(openFileDialog1);
            }
        }

    }
}
