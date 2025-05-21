namespace LinkedListApp
{
    partial class MainForm
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
            menuStrip = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            taskToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            processToolStripMenuItem = new ToolStripMenuItem();
            destroyToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, taskToolStripMenuItem, exitToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(80, 20);
            aboutToolStripMenuItem.Text = "О программе";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // taskToolStripMenuItem
            // 
            taskToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                createToolStripMenuItem, editToolStripMenuItem, processToolStripMenuItem, destroyToolStripMenuItem });
            taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            taskToolStripMenuItem.Size = new Size(60, 20);
            taskToolStripMenuItem.Text = "Задание";
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(180, 22);
            createToolStripMenuItem.Text = "Создание списков";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Редактирование списков";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // processToolStripMenuItem
            // 
            processToolStripMenuItem.Name = "processToolStripMenuItem";
            processToolStripMenuItem.Size = new Size(180, 22);
            processToolStripMenuItem.Text = "Обработка списков";
            processToolStripMenuItem.Click += processToolStripMenuItem_Click;
            // 
            // destroyToolStripMenuItem
            // 
            destroyToolStripMenuItem.Name = "destroyToolStripMenuItem";
            destroyToolStripMenuItem.Size = new Size(180, 22);
            destroyToolStripMenuItem.Text = "Разрушение списков";
            destroyToolStripMenuItem.Click += destroyToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(50, 20);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Односвязные списки";
            StartPosition = FormStartPosition.CenterScreen;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem taskToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem processToolStripMenuItem;
        private ToolStripMenuItem destroyToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}