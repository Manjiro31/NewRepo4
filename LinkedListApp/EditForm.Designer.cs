namespace LinkedListApp
{
    partial class EditForm
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
            radioButtonList1 = new RadioButton();
            radioButtonList2 = new RadioButton();
            comboBoxOperation = new ComboBox();
            labelOperation = new Label();
            textBoxValue = new TextBox();
            labelValue = new Label();
            textBoxPosition = new TextBox();
            labelPosition = new Label();
            btnApply = new Button();
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
            // radioButtonList1
            // 
            radioButtonList1.AutoSize = true;
            radioButtonList1.Location = new Point(20, 210);
            radioButtonList1.Name = "radioButtonList1";
            radioButtonList1.Size = new Size(80, 24);
            radioButtonList1.TabIndex = 4;
            radioButtonList1.Text = "Список 1";
            // 
            // radioButtonList2
            // 
            radioButtonList2.AutoSize = true;
            radioButtonList2.Location = new Point(160, 210);
            radioButtonList2.Name = "radioButtonList2";
            radioButtonList2.Size = new Size(80, 24);
            radioButtonList2.TabIndex = 5;
            radioButtonList2.Text = "Список 2";
            // 
            // comboBoxOperation
            // 
            comboBoxOperation.FormattingEnabled = true;
            comboBoxOperation.Location = new Point(300, 40);
            comboBoxOperation.Name = "comboBoxOperation";
            comboBoxOperation.Size = new Size(150, 28);
            comboBoxOperation.TabIndex = 6;
            comboBoxOperation.SelectedIndexChanged += comboBoxOperation_SelectedIndexChanged;
            // 
            // labelOperation
            // 
            labelOperation.AutoSize = true;
            labelOperation.Location = new Point(300, 17);
            labelOperation.Name = "labelOperation";
            labelOperation.Size = new Size(80, 20);
            labelOperation.TabIndex = 7;
            labelOperation.Text = "Операция";
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(300, 100);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(100, 27);
            textBoxValue.TabIndex = 8;
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(300, 80);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(80, 20);
            labelValue.TabIndex = 9;
            labelValue.Text = "Значение";
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(300, 160);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(100, 27);
            textBoxPosition.TabIndex = 10;
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Location = new Point(300, 140);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(80, 20);
            labelPosition.TabIndex = 11;
            labelPosition.Text = "Позиция";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(300, 210);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(100, 40);
            btnApply.TabIndex = 12;
            btnApply.Text = "Применить";
            btnApply.Click += btnApply_Click;
            // 
            // EditForm
            // 
            ClientSize = new Size(500, 300);
            Controls.Add(listBox1);
            Controls.Add(listBox2);
            Controls.Add(labelList1);
            Controls.Add(labelList2);
            Controls.Add(radioButtonList1);
            Controls.Add(radioButtonList2);
            Controls.Add(comboBoxOperation);
            Controls.Add(labelOperation);
            Controls.Add(textBoxValue);
            Controls.Add(labelValue);
            Controls.Add(textBoxPosition);
            Controls.Add(labelPosition);
            Controls.Add(btnApply);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EditForm";
            Text = "Редактирование списков";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        private ListBox listBox1;
        private ListBox listBox2;
        private Label labelList1;
        private Label labelList2;
        private RadioButton radioButtonList1;
        private RadioButton radioButtonList2;
        private ComboBox comboBoxOperation;
        private Label labelOperation;
        private TextBox textBoxValue;
        private Label labelValue;
        private TextBox textBoxPosition;
        private Label labelPosition;
        private Button btnApply;
    }
}