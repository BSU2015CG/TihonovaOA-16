using System;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media;
using Brush = System.Drawing.Brush;
using Brushes = System.Drawing.Brushes;

namespace CG_Lab3
{
    public class BresenhamAlgorithm : LineDrawingAlgorithm
    {
        public override void DrawLine(Canvas canvas, LineEnd start, LineEnd end)
        {
            int Octant;
            int Dx = end.X - start.X;
            int Dy = end.Y - start.Y;
            if (Math.Abs(Dy) > Math.Abs(Dx))
            {
                if (Dx > 0)
                {
                    Octant = Dy > 0 ? 1 : 6;
                }
                else 
                {
                    Octant = Dy > 0 ? 2 : 5;
                }
            }
            else
            {
                if (Dx > 0)
                {
                    Octant = Dy > 0 ? 0 : 7;
                }
                else
                {
                    Octant = Dy > 0 ? 3 : 4;
                }
            }

            Point endT = ToZeroOctant(Octant, new Point(Dx, Dy));

            if (Octant == 2)
            {
                Octant = 6;
            }
            else
            {
                if (Octant == 6)
                {
                    Octant = 2;
                }
            }
            Dx = endT.X;
            Dy = endT.Y;
            int D = 2 * Dy - Dx;
            for (int x = 1, y = 0; x < endT.X; x++)
            {
                if (D > 0)
                {
                    y++;
                    D += 2 * Dy - 2 * Dx;
                }
                else
                {
                    D += 2 * Dy;
                }

                Point p = ToZeroOctant(Octant, new Point(x, y));
                int tmpx = p.X + start.X;
                int tmpy = p.Y + start.Y;
                var rect = CreateRectangle(Colors.LightGreen);
                Canvas.SetLeft(rect, tmpx * Form1.gridStep);
                Canvas.SetTop(rect, tmpy * Form1.gridStep);
                canvas.Children.Add(rect);
            }
            var r = CreateRectangle(Colors.LightGreen);
            Canvas.SetLeft(r, start.X * Form1.gridStep);
            Canvas.SetTop(r, start.Y * Form1.gridStep);
            canvas.Children.Add(r);
            r = CreateRectangle(Colors.LightGreen);
            Canvas.SetLeft(r, end.X * Form1.gridStep);
            Canvas.SetTop(r, end.Y * Form1.gridStep);
            canvas.Children.Add(r);
        }


        Point ToZeroOctant(int octant, Point p)
        {
            switch (octant)
            {
                case 0:
                    return new Point(p.X, p.Y);
                case 1:
                    return new Point(p.Y, p.X);
                case 2:
                    return new Point(p.Y, -p.X);
                case 3:
                    return new Point(-p.X, p.Y);
                case 4:
                    return new Point(-p.X, -p.Y);
                case 5:
                    return new Point(-p.Y, -p.X);
                case 6:
                    return new Point(-p.Y, p.X);
                case 7:
                    return new Point(p.X, -p.Y);
                default:
                    return p;
            }
        }
    }
}