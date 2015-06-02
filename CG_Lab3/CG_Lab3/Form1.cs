using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using Brushes = System.Windows.Media.Brushes;
using HorizontalAlignment = System.Windows.HorizontalAlignment;
using MessageBox = System.Windows.Forms.MessageBox;
using MouseEventArgs = System.Windows.Input.MouseEventArgs;
using RadioButton = System.Windows.Forms.RadioButton;


namespace CG_Lab3
{
    public partial class Form1 : Form
    {
        public static int gridStep = 40;
        private int gridSize = 1600;

        private double prevTransformX = 0;
        private double prevTransformY = 0;

        private float zmLevel = 1.1f;
        private double maxZoom = 2;
        private double curZoom = 1;

        private LineDrawingAlgorithm lineDrawingAlgorithm = new DigitalDifferentialAnalyzer();
        private int startX = -1;
        private int startY = -1;

        private double DDATotalTime = 0.0;
        private double StepByStepTotalTime = 0.0;
        private double BresenhamTotalTime = 0.0;
        private int BresenhamCounter = 0, DDACounter = 0, StepByStepCounter = 0;

        Canvas canvas = new Canvas();

        Stopwatch stopWatch = new Stopwatch();

        TransformGroup group = new TransformGroup();

        private bool isDragging;
        private Point clickPosition;

        public Form1()
        {
            InitializeComponent();

            canvas.Width = elementHost1.Width;
            canvas.Height = elementHost1.Height;

            canvas.MouseDown += coordinateSystem_MouseDown;
            canvas.MouseUp += coordinateSystem_MouseUp;
            canvas.MouseLeave += coordinateSystem_MouseLeave;
            canvas.MouseMove += Control_MouseMove;
            canvas.MouseWheel += MouseWheelEvent;
            MouseWheel += MouseWheelSetFocusEvent;


            elementHost1.Child = canvas;

            group.Children.Add(new MatrixTransform());
            group.Children.Add(new TranslateTransform());

            DrawGrid();
        }

        private void DrawBackground()
        {
            Rectangle rect = new Rectangle();
            rect.Stroke = new SolidColorBrush(Colors.White);
            rect.Fill = new SolidColorBrush(Colors.White);
            rect.Width = gridSize;
            rect.Height = gridSize;
            canvas.Children.Add(rect);
        }

        private void DrawGrid()
        {
            canvas.Children.Clear();
            DrawBackground();

            bool drawOY = false;
            bool drawOX = false;
            for (int i = 0; i < gridSize; i += gridStep)
            {
                if (!drawOY && i > gridSize / 2)
                {
                    for (int j = 0; j < gridSize; j += gridStep)
                    {
                        int numRow = (gridSize / 2 - j) / gridStep;
                        if ((double)gridSize / 2 - j > 0)
                            ++numRow;
                        TextBlock tb = new TextBlock();
                        tb.Text = numRow.ToString();
                        canvas.Children.Add(tb);
                        tb.Margin = new Thickness(i, j, i + 20, j + 20);
                    }
                    drawOY = true;
                }
                canvas.Children.Add(LineDrawingAlgorithm.CreateDefaultLine(i, 0, i, gridSize, Brushes.Red));
            }

            for (int i = 0; i < gridSize; i += gridStep)
            {
                if (!drawOX && i > gridSize / 2)
                {
                    for (int j = 0; j < gridSize; j += gridStep)
                    {
                        int numRow = (gridSize / 2 - j) / gridStep;
                        if ((double)gridSize / 2 - j > 0)
                            ++numRow;
                        numRow *= -1;
                        TextBlock tb = new TextBlock();
                        tb.Text = numRow.ToString();
                        canvas.Children.Add(tb);
                        tb.Margin = new Thickness(j, i, j + 20, i + 20);
                    }
                    drawOX = true;
                }
                canvas.Children.Add(LineDrawingAlgorithm.CreateDefaultLine(0, i, gridSize, i, Brushes.Red));
            }

            canvas.Children.Add(LineDrawingAlgorithm.CreateDefaultLine(0, ((gridSize / 2) / gridStep + 1) * gridStep,
                                                           gridSize, ((gridSize / 2) / gridStep + 1) * gridStep, Brushes.Black));
            canvas.Children.Add(LineDrawingAlgorithm.CreateDefaultLine(((gridSize / 2) / gridStep + 1) * gridStep,
                                                            gridSize, ((gridSize / 2) / gridStep + 1) * gridStep, 0, Brushes.Black));
        }

        private void MouseWheelSetFocusEvent(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            elementHost1.Focus();
        }

        private void MouseWheelEvent(object sender, MouseWheelEventArgs e)
        {
            isDragging = false;

            var position = e.GetPosition(canvas);

            var matrix = (group.Children[0] as MatrixTransform).Matrix;
            var scale = e.Delta >= 0 ? zmLevel : (1.0 / zmLevel);

            if (curZoom * scale > maxZoom)
                scale = 1;
            if (curZoom * scale < 1 / maxZoom)
                scale = 1;

            curZoom *= scale;

            matrix.ScaleAtPrepend(scale, scale, position.X, position.Y);

            group.Children[0] = new MatrixTransform(matrix);
            canvas.RenderTransform = group;
        }

        private void clearBtn_Click(object sender, System.EventArgs e)
        {
            DrawGrid();
            listBox1.Items.Clear();
            BresenhamCounter = 0;
            BresenhamTotalTime = 0.0;
            textBox1.Text = "--";
            listBox2.Items.Clear();
            StepByStepCounter = 0;
            StepByStepTotalTime = 0.0;
            textBox2.Text = "--";
            listBox3.Items.Clear();
            DDACounter = 0;
            DDATotalTime = 0.0;
            textBox3.Text = "--";
        }

        private void coordinateSystem_MouseDown(object sender, MouseButtonEventArgs mEventArgs)
        {
            String Time;
            TimeSpan ts;
            if (mEventArgs.LeftButton == MouseButtonState.Pressed)
            {
                isDragging = true;
                clickPosition = mEventArgs.GetPosition(canvas.Parent as UIElement);
              //  canvas.CaptureMouse();
            }
            else
            {
                Point e = mEventArgs.GetPosition(canvas);

                if (startX == -1 && startY == -1)
                {
                    startX = (int)e.X;
                    startY = (int)e.Y;
                }
                else
                {
                    stopWatch.Start();
                    
                    lineDrawingAlgorithm.DrawLine(canvas, new LineDrawingAlgorithm.LineEnd(startX, startY), new LineDrawingAlgorithm.LineEnd((int)e.X, (int)e.Y));
                    canvas.Children.Add(LineDrawingAlgorithm.CreateDefaultLine(startX, startY, (int)e.X, (int)e.Y, Brushes.Orange));
                    stopWatch.Stop();
                    ts = stopWatch.Elapsed;
                    Time = ts.TotalSeconds + " с.";

                    if (lineDrawingAlgorithm.GetType().Name.Equals("DigitalDifferentialAnalyzer"))
                    {
                        listBox3.Items.Add(Time);
                        DDATotalTime += ts.TotalSeconds;
                        DDACounter++;
                        textBox3.Text = DDATotalTime / DDACounter + " c.";
                    }
                    if (lineDrawingAlgorithm.GetType().Name.Equals("BresenhamAlgorithm"))
                    {
                        listBox1.Items.Add(Time);
                        BresenhamTotalTime += ts.TotalSeconds;
                        BresenhamCounter++;
                        textBox1.Text = BresenhamTotalTime / BresenhamCounter + " c.";
                    }
                    if (lineDrawingAlgorithm.GetType().Name.Equals("StepByStepAlgorithm"))
                    {
                        listBox2.Items.Add(Time);
                        StepByStepTotalTime += ts.TotalSeconds;
                        StepByStepCounter++;
                        textBox2.Text = StepByStepTotalTime / StepByStepCounter + " c.";
                    }
                    startX = -1;
                    startY = -1;
                }
            }
        }

        private void coordinateSystem_MouseUp(object sender, MouseButtonEventArgs e)
        {

            isDragging = false;
            canvas.ReleaseMouseCapture();
        }

        private void coordinateSystem_MouseLeave(object sender, MouseEventArgs e)
        {

            isDragging = false;
            canvas.ReleaseMouseCapture();
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && canvas != null)
            {
                var transform = group.Children[1] as TranslateTransform;

                Point currentPosition = e.GetPosition(canvas.Parent as UIElement);

                prevTransformX += currentPosition.X - clickPosition.X;
                prevTransformY += currentPosition.Y - clickPosition.Y;

                transform.X = prevTransformX;
                transform.Y = prevTransformY;

                group.Children[1] = transform;

                canvas.RenderTransform = group;
                clickPosition.X = currentPosition.X;
                clickPosition.Y = currentPosition.Y;
                //lineDrawingAlgorithm.DrawLine();
            }
        }

        private void rb_CheckedChanged(object sender, System.EventArgs e)
        {
            if (sender as RadioButton == rbDDA && rbDDA.Checked)
                lineDrawingAlgorithm = new DigitalDifferentialAnalyzer();
            if (sender as RadioButton == rbBresenham && rbBresenham.Checked)
                lineDrawingAlgorithm = new BresenhamAlgorithm();
            if (sender as RadioButton == rbStepByStep && rbStepByStep.Checked)
                lineDrawingAlgorithm = new StepByStepAlgorithm();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
