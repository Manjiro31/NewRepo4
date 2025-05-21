namespace LinkedListApp
{
    partial class AboutForm
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

        private void InitializeComponent()
        {
            labelInfo = new Label();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(30, 30);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(347, 80);
            labelInfo.TabIndex = 0;
            labelInfo.Text = "Лабораторная работа №2: Односвязные списки\nАвтор:Картяев Глеб\nГруппа: 6106 \nВариант:15";
            // 
            // AboutForm
            // 
            ClientSize = new Size(478, 150);
            Controls.Add(labelInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelInfo;
    }
}