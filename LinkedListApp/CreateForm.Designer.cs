namespace LinkedListApp
{
    partial class CreateForm
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
            labelList1 = new Label();
            labelList2 = new Label();
            textBoxValue = new TextBox();
            btnAddToList1 = new Button();
            btnAddToList2 = new Button();
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
            // labelList1
            // 
            labelList1.AutoSize = true;
            labelList1.Location = new Point(20, 17);
            labelList1.Name = "labelList1";
            labelList1.Size = new Size(71, 20);
            labelList1.TabIndex = 2;
            labelList1.Text = "Список 1";
            // 
            // labelList2
            // 
            labelList2.AutoSize = true;
            labelList2.Location = new Point(160, 17);
            labelList2.Name = "labelList2";
            labelList2.Size = new Size(71, 20);
            labelList2.TabIndex = 3;
            labelList2.Text = "Список 2";
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(20, 220);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(100, 27);
            textBoxValue.TabIndex = 4;
            // 
            // btnAddToList1
            // 
            btnAddToList1.Location = new Point(130, 220);
            btnAddToList1.Name = "btnAddToList1";
            btnAddToList1.Size = new Size(104, 40);
            btnAddToList1.TabIndex = 5;
            btnAddToList1.Text = "Добавить в 1";
            btnAddToList1.Click += btnAddToList1_Click;
            // 
            // btnAddToList2
            // 
            btnAddToList2.Location = new Point(240, 220);
            btnAddToList2.Name = "btnAddToList2";
            btnAddToList2.Size = new Size(104, 40);
            btnAddToList2.TabIndex = 6;
            btnAddToList2.Text = "Добавить в 2";
            btnAddToList2.Click += btnAddToList2_Click;
            // 
            // CreateForm
            // 
            ClientSize = new Size(400, 300);
            Controls.Add(listBox1);
            Controls.Add(listBox2);
            Controls.Add(labelList1);
            Controls.Add(labelList2);
            Controls.Add(textBoxValue);
            Controls.Add(btnAddToList1);
            Controls.Add(btnAddToList2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CreateForm";
            Text = "Создание списков";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        private ListBox listBox1;
        private ListBox listBox2;
        private Label labelList1;
        private Label labelList2;
        private TextBox textBoxValue;
        private Button btnAddToList1;
        private Button btnAddToList2;
    }
}