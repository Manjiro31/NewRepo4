using System;
using System.Windows.Forms;

namespace LinkedListApp
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
            MainForm.List1.Display(listBox1);
            MainForm.List2.Display(listBox2);
        }

        private void btnAddToList1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxValue.Text, out int value))
                    throw new ArgumentException("Введите целое число");
                MainForm.List1.AddToEnd(value);
                MainForm.List1.Display(listBox1);
                textBoxValue.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void btnAddToList2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxValue.Text, out int value))
                    throw new ArgumentException("Введите целое число");
                MainForm.List2.AddToEnd(value);
                MainForm.List2.Display(listBox2);
                textBoxValue.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}