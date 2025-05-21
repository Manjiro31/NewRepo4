
namespace LinkedListApp
{
    partial class MergeForm
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
            lbList1 = new ListBox();
            lbList2 = new ListBox();
            lbMergedList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtValue = new TextBox();
            btnAddToList1 = new Button();
            btnAddToList2 = new Button();
            btnMerge = new Button();
            SuspendLayout();
            // 
            // lbList1
            // 
            lbList1.FormattingEnabled = true;
            lbList1.Location = new Point(20, 40);
            lbList1.Name = "lbList1";
            lbList1.Size = new Size(120, 144);
            lbList1.TabIndex = 0;
           
            // lbList2
            
            lbList2.FormattingEnabled = true;
            lbList2.Location = new Point(160, 40);
            lbList2.Name = "lbList2";
            lbList2.Size = new Size(120, 144);
            lbList2.TabIndex = 1;
           
            lbMergedList.FormattingEnabled = true;
            lbMergedList.Location = new Point(300, 40);
            lbMergedList.Name = "lbMergedList";
            lbMergedList.Size = new Size(120, 144);
            lbMergedList.TabIndex = 2;
           
            label1.AutoSize = true;
            label1.Location = new Point(37, 17);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 3;
            label1.Text = "Список 1";
           
            label2.AutoSize = true;
            label2.Location = new Point(177, 17);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 4;
            label2.Text = "Список 2";
            
            label3.AutoSize = true;
            label3.Location = new Point(300, 20);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 5;
            label3.Text = "Результат";
           
            txtValue.Location = new Point(20, 220);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(100, 27);
            txtValue.TabIndex = 6;
            txtValue.TextChanged += txtValue_TextChanged;
           
            btnAddToList1.Location = new Point(130, 220);
            btnAddToList1.Name = "btnAddToList1";
            btnAddToList1.Size = new Size(104, 40);
            btnAddToList1.TabIndex = 7;
            btnAddToList1.Text = "Добавить в 1";
            btnAddToList1.Click += btnAddToList1_Click;
          
            btnAddToList2.Location = new Point(240, 220);
            btnAddToList2.Name = "btnAddToList2";
            btnAddToList2.Size = new Size(104, 40);
            btnAddToList2.TabIndex = 8;
            btnAddToList2.Text = "Добавить в 2";
            btnAddToList2.Click += btnAddToList2_Click;
            
            btnMerge.Location = new Point(350, 220);
            btnMerge.Name = "btnMerge";
            btnMerge.Size = new Size(115, 40);
            btnMerge.TabIndex = 9;
            btnMerge.Text = "Объединить";
            btnMerge.Click += btnMerge_Click;
           
            ClientSize = new Size(938, 533);
            Controls.Add(lbList1);
            Controls.Add(lbList2);
            Controls.Add(lbMergedList);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtValue);
            Controls.Add(btnAddToList1);
            Controls.Add(btnAddToList2);
            Controls.Add(btnMerge);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MergeForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ListBox lbList1;
        private System.Windows.Forms.ListBox lbList2;
        private System.Windows.Forms.ListBox lbMergedList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnAddToList1;
        private System.Windows.Forms.Button btnAddToList2;
        private System.Windows.Forms.Button btnMerge;
    }
}