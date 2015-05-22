//using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Color = System.Windows.Media.Color;
using Brush = System.Windows.Media.Brush;

namespace CG_Lab3
{
    public abstract class LineDrawingAlgorithm
    {
        public abstract void DrawLine(Canvas g, LineEnd Start, LineEnd End);

        public static Rectangle CreateRectangle(Color RectangleColor)
        {
            System.Windows.Shapes.Rectangle rect;
            rect = new System.Windows.Shapes.Rectangle();
            rect.Stroke = new SolidColorBrush(Colors.Black);
            rect.Fill = new SolidColorBrush(RectangleColor);
            rect.Width = Form1.gridStep;
            rect.Height = Form1.gridStep;
            return rect;
        }

        public static Line CreateDefaultLine(int StartX, int StartY, int EndX, int EndY, Brush Color)
        {
            Line line = new Line();
            line.X1 = StartX;
            line.Y1 = StartY;
            line.X2 = EndX;
            line.Y2 = EndY;
            line.Stroke = Color;
            return line;
        }

        public struct LineEnd
        {
            private int x;
            private int y;
            public int X
            {
                get { return x; }
                set { x = (value - value % Form1.gridStep) / Form1.gridStep; }
            }
            public int Y
            {
                get { return y; }
                set { y = (value - value % Form1.gridStep) / Form1.gridStep; }
            }
            public LineEnd(int x, int y)
            {
                this.x = (x - x % Form1.gridStep) / Form1.gridStep;
                this.y = (y - y % Form1.gridStep) / Form1.gridStep;
            }
        }
    }
}
