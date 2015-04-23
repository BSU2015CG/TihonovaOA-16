using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kg_Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double R, G, B;
        private double H, S, V;
        private double X, YY, Z;
        private bool scroll = true;
        private double C, M, Y, K = 100;

        private void R_Scroll(object sender, EventArgs e)
        {
            if (scroll)
            {
                scroll = false;
                R = tbR.Value;
                t1.Text = Convert.ToString((int)R);
                RGBtoHSV(R, G, B);
                RGBtoCMYK(R, G, B);
                RGBtoXYZ(R, G, B);
                panel1.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                panel2.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                scroll = true;
            }
        }

        private void G_Scroll(object sender, EventArgs e)
        {
            if (scroll)
            {
                scroll = false;
                G = tbG.Value;
                t2.Text = Convert.ToString((int)G);
                RGBtoHSV(R, G, B);
                RGBtoCMYK(R, G, B);
                RGBtoXYZ(R, G, B);
                panel1.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                panel2.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                scroll = true;
            }
        }

        private void B_Scroll(object sender, EventArgs e)
        {
            if (scroll)
            {
                scroll = false;
                B = tbB.Value;
                t3.Text = Convert.ToString((int)B);
                RGBtoHSV(R, G, B);
                RGBtoCMYK(R, G, B);
                RGBtoXYZ(R, G, B);
                panel1.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                panel2.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                scroll = true;
            }
        }

        private void RGBtoHSV(double R, double G, double B)
        {
            double r = R / 255, g = G / 255, b = B / 255;
            double H = this.H, S = this.S, V = this.V;
            double min = Math.Min(Math.Min(r, g), b),
                   max = Math.Max(Math.Max(r, g), b),
                   delta = max - min;

            if (min == max)
                H = 0;
            else
                if (max == r && g >= b)
                    H = 60 * (g - b) / delta;
                else
                    if (max == r && g < b)
                        H = 60 * (g - b) / delta + 360;
                    else
                        if (max == g)
                            H = 60 * (b - r) / delta + 120;
                        else
                            if (max == b)
                                H = 60 * (r - g) / delta + 240;

            t4.Text = Convert.ToString((int)H);
            tbH.Value = (int)H;

            if (max == 0)
                S = 0;
            else
                S = (1 - min / max) * 100;

            t5.Text = Convert.ToString((int)S);
            tbS.Value = (int)S;

            V = max * 100;

            t6.Text = Convert.ToString((int)V);
            tbV.Value = (int)V;

            this.H = H;
            this.S = S;
            this.V = V;
        }

        private void tbH_Scroll(object sender, EventArgs e)
        {
            if (scroll)
            {
                scroll = false;
                H = tbH.Value;
                t4.Text = Convert.ToString((int)H);
                HSVtoRGB(H, S, V);
                RGBtoCMYK(R, G, B);
                RGBtoXYZ(R, G, B);
                panel1.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                panel2.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                scroll = true;
            }
        }

        private void tbS_Scroll(object sender, EventArgs e)
        {
            if (scroll)
            {
                scroll = false;
                S = tbS.Value;
                t5.Text = Convert.ToString((int)S);
                HSVtoRGB(H, S, V);
                RGBtoCMYK(R, G, B);
                RGBtoXYZ(R, G, B);
                panel1.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                panel2.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                scroll = true;
            }
        }

        private void tbV_Scroll(object sender, EventArgs e)
        {
            if (scroll)
            {
                scroll = false;
                V = tbV.Value;
                t6.Text = Convert.ToString((int)V);
                HSVtoRGB(H, S, V);
                RGBtoCMYK(R, G, B);
                RGBtoXYZ(R, G, B);
                panel1.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                panel2.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                scroll = true;
            }
        }

        private void HSVtoRGB(double H, double S, double V)
        {
            double R = this.R, G = this.G, B = this.B;
            int Hi = (int)(H / 60);
            double Vmin = (100 - S) * V / 100,
                   a = (V - Vmin) * (H % 60) / 60,
                   Vinc = Vmin + a,
                   Vdec = V - a;

            switch (Hi)
            {
                case 0: { R = V; G = Vinc; B = Vmin; break; }
                case 1: { R = Vdec; G = V; B = Vmin; break; }
                case 2: { R = Vmin; G = V; B = Vinc; break; }
                case 3: { R = Vmin; G = Vdec; B = V; break; }
                case 4: { R = Vinc; G = Vmin; B = V; break; }
                case 5: { R = V; G = Vmin; B = Vdec; break; }
            }

            if (R < 0) { R = 0; label7.Text = "R < 0"; }
            else label7.Text = "";
            if (R > 255) { R = 255; label7.Text = "R > 255"; }
            else label7.Text = "";
            if (G < 0) { G = 0; label8.Text = "G < 0"; }
            else label8.Text = "";
            if (G > 255) { G = 255; label8.Text = "G > 255"; }
            else label8.Text = "";
            if (B < 0) { B = 0; label9.Text = "B < 0"; }
            else label9.Text = "";
            if (B > 255) { B = 255; label9.Text = "B > 255"; }
            else label9.Text = "";

            R = R * 2.55 + 0.000000001;
            G = G * 2.55 + 0.000000001;
            B = B * 2.55 + 0.000000001;

            t1.Text = Convert.ToString((int)R);
            tbR.Value = (int)R;
            t2.Text = Convert.ToString((int)G);
            tbG.Value = (int)G;
            t3.Text = Convert.ToString((int)B);
            tbB.Value = (int)B;

            this.R = R; this.G = G; this.B = B;
        }

        private void tbX_Scroll(object sender, EventArgs e)
        {
            if (scroll)
            {
                scroll = false;
                X = (1.0 * tbX.Value) / 100 * 95.047;
                tX.Text = Convert.ToString(Math.Round(X));
                XYZtoRGB(X, YY, Z);
                RGBtoHSV(R, G, B);
                RGBtoCMYK(R, G, B);
                panel1.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                panel2.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                scroll = true;
            }
        }

        private void tbY_Scroll(object sender, EventArgs e)
        {
            if (scroll)
            {
                scroll = false;
                YY = tbY.Value;
                tY.Text = Convert.ToString((int)YY);
                XYZtoRGB(X, YY, Z);
                RGBtoHSV(R, G, B);
                RGBtoCMYK(R, G, B);
                panel1.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                panel2.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                scroll = true;
            }
        }

        private void tbZ_Scroll(object sender, EventArgs e)
        {
            if (scroll)
            {
                scroll = false;
                Z = (1.0 * tbZ.Value) / 100 * 108.883;
                tZ.Text = Convert.ToString(Math.Round(Z));
                XYZtoRGB(X, YY, Z);
                RGBtoHSV(R, G, B);
                RGBtoCMYK(R, G, B);
                panel1.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                panel2.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                scroll = true;
            }
        }

        private void RGBtoXYZ(double R, double G, double B)
        {
            double X, Y, Z;
            double r = R / 255.0,
                   g = G / 255.0,
                   b = B / 255.0;

            if (r > 0.04045) r = Math.Pow((r + 0.055) / 1.055, 2.4);
            else r /= 12.92;
            if (g > 0.04045) g = Math.Pow((g + 0.055) / 1.055, 2.4);
            else g /= 12.92;
            if (b > 0.04045) b = Math.Pow((b + 0.055) / 1.055, 2.4);
            else b /= 12.92;

            r *= 100;
            g *= 100;
            b *= 100;

            X = r * 0.4124 + g * 0.3576 + b * 0.1805;
            Y = r * 0.2126 + g * 0.7152 + b * 0.0722;
            Z = r * 0.0193 + g * 0.1192 + b * 0.9502;

            tX.Text = Convert.ToString(Math.Round(X));
            tY.Text = Convert.ToString(Math.Round(Y));
            tZ.Text = Convert.ToString(Math.Round(Z));
            tbX.Value = (int)(Math.Round(X / 95.047 * 100));
            tbY.Value = (int)Y;
            tbZ.Value = (int)(Math.Round(Z / 108.883 * 100));

            this.X = X; this.YY = Y; this.Z = Z;
        }

        private void XYZtoRGB(double X, double Y, double Z)
        {
            double R, G, B;
            double x = X / 100,
                   y = Y / 100,
                   z = Z / 100,
                   r = x * 3.2406 - y * 1.5372 - z * 0.4986,
                   g = -x * 0.9689 + y * 1.8758 + z * 0.0415,
                   b = x * 0.0557 - y * 0.2040 + z * 1.0570;

            if (r > 0.0031308) r = 1.055 * Math.Pow(r, 1.0 / 2.4) - 0.055;
            else r *= 12.92;
            if (g > 0.0031308) g = 1.055 * Math.Pow(g, 1.0 / 2.4) - 0.055;
            else g *= 12.92;
            if (b > 0.0031308) b = 1.055 * Math.Pow(b, 1.0 / 2.4) - 0.055;
            else b *= 12.92;

            R = r * 255;
            G = g * 255;
            B = b * 255;

            if (R < 0) { R = 0; label7.Text = "R < 0"; }
            else label7.Text = "";
            if (R > 255) { R = 255; label7.Text = "R > 255"; }
            else label7.Text = "";
            if (G < 0) { G = 0; label8.Text = "G < 0"; }
            else label8.Text = "";
            if (G > 255) { G = 255; label8.Text = "G > 255"; }
            else label8.Text = "";
            if (B < 0) { B = 0; label9.Text = "B < 0"; }
            else label9.Text = "";
            if (B > 255) { B = 255; label9.Text = "B > 255"; }
            else label9.Text = "";

            t1.Text = Convert.ToString(Math.Round(R));
            tbR.Value = (int)R;
            t2.Text = Convert.ToString(Math.Round(G));
            tbG.Value = (int)G;
            t3.Text = Convert.ToString(Math.Round(B));
            tbB.Value = (int)B;

            this.R = R; this.G = G; this.B = B;
        }

        private void tbC_Scroll(object sender, EventArgs e)
        {
            if (scroll)
            {
                scroll = false;
                C = tbC.Value;
                tC.Text = Convert.ToString((int)C);
                CMYKtoRGB(C, M, Y, K);
                RGBtoHSV(R, G, B);
                RGBtoXYZ(R, G, B);
                panel1.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                panel2.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                scroll = true;
            }
        }

        private void tbM_Scroll(object sender, EventArgs e)
        {
            if (scroll)
            {
                scroll = false;
                M = tbM.Value;
                tM.Text = Convert.ToString((int)C);
                CMYKtoRGB(C, M, Y, K);
                RGBtoHSV(R, G, B);
                RGBtoXYZ(R, G, B);
                panel1.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                panel2.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                scroll = true;
            }
        }

        private void tbY1_Scroll(object sender, EventArgs e)
        {
            if (scroll)
            {
                scroll = false;
                Y = tbY1.Value;
                tY1.Text = Convert.ToString((int)C);
                CMYKtoRGB(C, M, Y, K);
                RGBtoHSV(R, G, B);
                RGBtoXYZ(R, G, B);
                panel1.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                panel2.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                scroll = true;
            }
        }

        private void tbK_Scroll(object sender, EventArgs e)
        {
            if (scroll)
            {
                scroll = false;
                K = tbK.Value;
                tK.Text = Convert.ToString((int)K);
                CMYKtoRGB(C, M, Y, K);
                RGBtoHSV(R, G, B);
                RGBtoXYZ(R, G, B);
                panel1.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                panel2.BackColor = Color.FromArgb((int)R, (int)G, (int)B);
                scroll = true;
            }
        }

        private void RGBtoCMYK(double R, double G, double B)
        {
            double C, M, Y, K;
            double r = R / 255,
                   g = G / 255,
                   b = B / 255;

            if (r == 0 && g == 0 && b == 0)
            {
                C = M = Y = 0;
                K = 100;
            }
            else
            {
                K = Math.Min(Math.Min(1 - r, 1 - g), 1 - b);
                C = (1 - r - K) / (1 - K) * 100;
                M = (1 - g - K) / (1 - K) * 100;
                Y = (1 - b - K) / (1 - K) * 100;
                K = K * 100;
            }

            tC.Text = Convert.ToString((int)C);
            tbC.Value = (int)C;
            tM.Text = Convert.ToString((int)M);
            tbM.Value = (int)M;
            tY1.Text = Convert.ToString((int)Y);
            tbY1.Value = (int)Y;
            tK.Text = Convert.ToString((int)K);
            tbK.Value = (int)K;

            this.C = C;
            this.M = M;
            this.Y = Y;
            this.K = K;
        }

        private void CMYKtoRGB(double C, double M, double Y, double K)
        {
            double c = C / 100,
                   m = M / 100,
                   y = Y / 100,
                   k = K / 100;

            double R = 255 * (1 - c) * (1 - k),
                   G = 255 * (1 - m) * (1 - k),
                   B = 255 * (1 - y) * (1 - k);

            t1.Text = Convert.ToString((int)R);
            tbR.Value = (int)R;
            t2.Text = Convert.ToString((int)G);
            tbG.Value = (int)G;
            t3.Text = Convert.ToString((int)B);
            tbB.Value = (int)B;

            this.R = R; this.G = G; this.B = B;
        }
    }
}
