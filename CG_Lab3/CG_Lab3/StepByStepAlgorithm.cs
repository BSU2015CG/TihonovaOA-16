using System;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media;

namespace CG_Lab3
{
    public class StepByStepAlgorithm : LineDrawingAlgorithm
    {
        public override void DrawLine(Canvas canvas, LineEnd Start, LineEnd End)
        {
            if (Start.X == End.X && Start.Y == End.Y)
            {
                var Rectangle = CreateRectangle(Colors.LightCoral);
                Canvas.SetLeft(Rectangle, Start.X * Form1.gridStep);
                Canvas.SetTop(Rectangle, Start.Y * Form1.gridStep);
                canvas.Children.Add(Rectangle);
                return;
            }
            
            if (Math.Abs(End.X - Start.X) > Math.Abs(End.Y - Start.Y))
            {
                if (Start.X > End.X)
                {
                    LineEnd Temporary = Start;
                    Start = End;
                    End = Temporary;
                }

                float k = ((float)(End.Y - Start.Y) / (End.X - Start.X));
                float y = Start.Y;

                for (float x = Start.X; x <= End.X; ++x)
                {
                    y = k * x + (float)(End.X * Start.Y - Start.X * End.Y) / (End.X - Start.X);

                    var Rectangle = CreateRectangle(Colors.LightCoral);
                    Canvas.SetLeft(Rectangle, x * Form1.gridStep);
                    int tmpy = (int) Math.Round(y);
                    Canvas.SetTop(Rectangle, tmpy * Form1.gridStep);
                    canvas.Children.Add(Rectangle);
                }
            }
            else
            {
                if (Start.Y > End.Y)
                {
                    LineEnd Temporary = Start;
                    Start = End;
                    End = Temporary;
                }

                float k = ((float)(Start.X - End.X) / (Start.Y - End.Y));
                float x = Start.X;

                for (float y = Start.Y; y <= End.Y; ++y )
                {
                    x = k * y + (float)(End.X * Start.Y - Start.X * End.Y) / (Start.Y - End.Y);

                    var Rectangle = CreateRectangle(Colors.LightCoral);
                    int tmpx = (int)Math.Round(x);
                    Canvas.SetLeft(Rectangle, tmpx * Form1.gridStep);
                    Canvas.SetTop(Rectangle, y * Form1.gridStep);
                    canvas.Children.Add(Rectangle);
                }
            }
        }
    }
}