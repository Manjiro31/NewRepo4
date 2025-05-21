using System;
using System.Windows.Forms;

namespace LinkedListApp
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
            comboBoxOperation.Items.AddRange(new string[]
            {
                "Добавить в начало",
                "Добавить в конец",
                "Добавить по позиции",
                "Удалить с начала",
                "Удалить с конца",
                "Удалить по позиции"
            });
            comboBoxOperation.SelectedIndex = 0;
            MainForm.List1.Display(listBox1);
            MainForm.List2.Display(listBox2);
        }

        private void comboBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isPositionOperation = comboBoxOperation.SelectedItem.ToString().Contains("позиции");
            labelPosition.Visible = textBoxPosition.Visible = isPositionOperation;
            labelValue.Visible = textBoxValue.Visible = comboBoxOperation.SelectedItem.ToString().Contains("Добавить");
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                SingleLinkedList targetList = radioButtonList1.Checked ? MainForm.List1 : MainForm.List2;
                ListBox targetListBox = radioButtonList1.Checked ? listBox1 : listBox2;

                if (!radioButtonList1.Checked && !radioButtonList2.Checked)
                    throw new InvalidOperationException("Выберите список");

                string operation = comboBoxOperation.SelectedItem.ToString();
                if (operation.Contains("Добавить"))
                {
                    if (!int.TryParse(textBoxValue.Text, out int value))
                        throw new ArgumentException("Введите целое число");
                    if (operation == "Добавить в начало")
                        targetList.AddToStart(value);
                    else if (operation == "Добавить в конец")
                        targetList.AddToEnd(value);
                    else if (operation == "Добавить по позиции")
                    {
                        if (!int.TryParse(textBoxPosition.Text, out int position))
                            throw new ArgumentException("Введите корректную позицию");
                        targetList.AddAtPosition(value, position);
                    }
                }
                else if (operation.Contains("Удалить"))
                {
                    if (operation == "Удалить с начала")
                        targetList.DeleteFromStart();
                    else if (operation == "Удалить с конца")
                        targetList.DeleteFromEnd();
                    else if (operation == "Удалить по позиции")
                    {
                        if (!int.TryParse(textBoxPosition.Text, out int position))
                            throw new ArgumentException("Введите корректную позицию");
                        targetList.DeleteAtPosition(position);
                    }
                }

                targetList.Display(targetListBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}