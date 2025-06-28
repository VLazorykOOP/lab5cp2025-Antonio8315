using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Task_5_1 : Form
    {
        public Task_5_1()
        {
            InitializeComponent();
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Green, 2);

            PointF P1 = new PointF(50, 300);
            PointF P2 = new PointF(150, 50);
            PointF P3 = new PointF(250, 100);
            PointF P4 = new PointF(350, 300);

            g.FillEllipse(Brushes.Red, P1.X - 5, P1.Y - 5, 10, 10);
            g.FillEllipse(Brushes.Blue, P2.X - 5, P2.Y - 5, 10, 10);
            g.FillEllipse(Brushes.Blue, P3.X - 5, P3.Y - 5, 10, 10);
            g.FillEllipse(Brushes.Red, P4.X - 5, P4.Y - 5, 10, 10);

            g.DrawLine(pen, P1, P2);
            g.DrawLine(pen, P3, P4);
            g.DrawLine(pen, P2, P3);

            PointF[] points = CalculateBezierCurve(P1, P2, P3, P4, 20);
            if (points.Length > 1)
            {
                g.DrawLines(pen, points);
            }

            pen.Dispose();
        }

        private PointF[] CalculateBezierCurve(PointF P1, PointF P2, PointF P3, PointF P4, int segments)
        {
            PointF[] points = new PointF[segments + 1];
            for (int i = 0; i <= segments; i++)
            {
                float t = i / (float)segments;
                float mt = 1 - t;
                float mt2 = mt * mt;
                float mt3 = mt2 * mt;
                float t2 = t * t;
                float t3 = t2 * t;

                float x = mt3 * P1.X + 3 * mt2 * t * P2.X + 3 * mt * t2 * P3.X + t3 * P4.X;
                float y = mt3 * P1.Y + 3 * mt2 * t * P2.Y + 3 * mt * t2 * P3.Y + t3 * P4.Y;

                points[i] = new PointF(x, y);
            }
            return points;
        }
    }
}