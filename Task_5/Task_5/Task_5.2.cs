using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Task_5_2 : Form
    {
        private int order = 4;

        public Task_5_2()
        {
            InitializeComponent();
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Orange, 1);

            PointF P1 = new PointF(100, 350);
            PointF P2 = new PointF(350, 350);
            PointF P3 = new PointF(225, 100);

            g.DrawLine(pen, P1, P2);
            g.DrawLine(pen, P2, P3);
            g.DrawLine(pen, P3, P1);

            DrawKochFractal(g, pen, P1, P2, order);
            DrawKochFractal(g, pen, P2, P3, order);
            DrawKochFractal(g, pen, P3, P1, order);

            pen.Dispose();
        }

        private void DrawKochFractal(Graphics g, Pen pen, PointF start, PointF end, int currentOrder)
        {
            if (currentOrder == 0)
            {
                g.DrawLine(pen, start, end);
                return;
            }

            float dx = (end.X - start.X) / 3;
            float dy = (end.Y - start.Y) / 3;
            PointF p1 = new PointF(start.X + dx, start.Y + dy);
            PointF p2 = new PointF(start.X + dx * 2, start.Y + dy * 2);
            PointF p3 = new PointF(start.X + dx, start.Y + dy);
            p3.X += (float)(dx * Math.Cos(Math.PI / 3) - dy * Math.Sin(Math.PI / 3));
            p3.Y += (float)(dx * Math.Sin(Math.PI / 3) + dy * Math.Cos(Math.PI / 3));

            DrawKochFractal(g, pen, start, p1, currentOrder - 1);
            DrawKochFractal(g, pen, p1, p3, currentOrder - 1);
            DrawKochFractal(g, pen, p3, p2, currentOrder - 1);
            DrawKochFractal(g, pen, p2, end, currentOrder - 1);
        }

        private void Task_5_2_Load(object sender, EventArgs e)
        {
            drawingPanel.Invalidate();
        }
    }
}