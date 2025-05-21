namespace LinkedListApp
{
    partial class ProcessForm
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBoxMerged = new ListBox();
            labelList1 = new Label();
            labelList2 = new Label();
            labelMerged = new Label();
            btnMerge = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(20, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 160);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(160, 40);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 160);
            listBox2.TabIndex = 1;
            // 
            // listBoxMerged
            // 
            listBoxMerged.FormattingEnabled = true;
            listBoxMerged.Location = new Point(300, 40);
            listBoxMerged.Name = "listBoxMerged";
            listBoxMerged.Size = new Size(120, 160);
            listBoxMerged.TabIndex = 2;
            // 
            // labelList1
            // 
            labelList1.AutoSize = true;
            labelList1.Location = new Point(20, 17);
            labelList1.Name = "labelList1";
            labelList1.Size = new Size(71, 20);
            labelList1.TabIndex = 3;
            labelList1.Text = "Список 1";
            // 
            // labelList2
            // 
            labelList2.AutoSize = true;
            labelList2.Location = new Point(160, 17);
            labelList2.Name = "labelList2";
            labelList2.Size = new Size(71, 20);
            labelList2.TabIndex = 4;
            labelList2.Text = "Список 2";
            // 
            // labelMerged
            // 
            labelMerged.AutoSize = true;
            labelMerged.Location = new Point(300, 17);
            labelMerged.Name = "labelMerged";
            labelMerged.Size = new Size(75, 20);
            labelMerged.TabIndex = 5;
            labelMerged.Text = "Результат";
            // 
            // btnMerge
            // 
            btnMerge.Location = new Point(160, 220);
            btnMerge.Name = "btnMerge";
            btnMerge.Size = new Size(120, 40);
            btnMerge.TabIndex = 6;
            btnMerge.Text = "Объединить";
            btnMerge.Click += btnMerge_Click;
            // 
            // ProcessForm
            // 
            ClientSize = new Size(450, 300);
            Controls.Add(listBox1);
            Controls.Add(listBox2);
            Controls.Add(listBoxMerged);
            Controls.Add(labelList1);
            Controls.Add(labelList2);
            Controls.Add(labelMerged);
            Controls.Add(btnMerge);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProcessForm";
            Text = "Объединение списков";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBoxMerged;
        private Label labelList1;
        private Label labelList2;
        private Label labelMerged;
        private Button btnMerge;
    }
}