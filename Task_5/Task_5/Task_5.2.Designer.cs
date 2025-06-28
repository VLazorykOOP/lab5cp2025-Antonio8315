namespace Task_5
{
    partial class Task_5_2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            drawingPanel = new Panel();
            SuspendLayout();
            // 
            // drawingPanel
            // 
            drawingPanel.Location = new Point(12, 21);
            drawingPanel.Name = "drawingPanel";
            drawingPanel.Size = new Size(476, 467);
            drawingPanel.TabIndex = 0;
            drawingPanel.Paint += drawingPanel_Paint;
            // 
            // Task_5_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 500);
            Controls.Add(drawingPanel);
            Name = "Task_5_2";
            Text = "Koch Fractal";
            ResumeLayout(false);
        }

        #endregion

        private Panel drawingPanel;
    }
}