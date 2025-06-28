using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button btnBezier = new Button
            {
                Text = "Show Bezier Curve",
                Location = new Point(50, 460),
                Size = new Size(150, 30)
            };
            btnBezier.Click += (s, e) => { new Task_5_1().Show(); };
            this.Controls.Add(btnBezier);

            Button btnKoch = new Button
            {
                Text = "Show Koch Fractal",
                Location = new Point(210, 460),
                Size = new Size(150, 30)
            };
            btnKoch.Click += (s, e) => { new Task_5_2().Show(); };
            this.Controls.Add(btnKoch);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(500, 550);
        }
    }
}