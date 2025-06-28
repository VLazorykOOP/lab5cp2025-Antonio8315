namespace Task_5
{
    partial class Task_5_1
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            drawingPanel = new Panel();
            SuspendLayout();
            // 
            // drawingPanel
            // 
            drawingPanel.Location = new Point(50, 50);
            drawingPanel.Name = "drawingPanel";
            drawingPanel.Size = new Size(400, 400);
            drawingPanel.TabIndex = 0;
            drawingPanel.Paint += drawingPanel_Paint;
            // 
            // Task_5_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 500);
            Controls.Add(drawingPanel);
            Name = "Task_5_1";
            Text = "Bezier Curve";
            ResumeLayout(false);
        }

        private Panel drawingPanel;
    }
}