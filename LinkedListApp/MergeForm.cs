// MergeForm.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LinkedListApp
{
    public partial class MergeForm : Form
    {
        private SingleLinkedList list1 = new SingleLinkedList();
        private SingleLinkedList list2 = new SingleLinkedList();

        public MergeForm()
        {
            InitializeComponent();
            this.Text = "Объединение списков с чередованием";
        }

        private void btnAddToList1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                list1.AddToEnd(value);
                UpdateListBoxes();
                txtValue.Clear();
                txtValue.Focus();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите целое число");
            }
        }

        private void btnAddToList2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                list2.AddToEnd(value);
                UpdateListBoxes();
                txtValue.Clear();
                txtValue.Focus();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите целое число");
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            try
            {
                // Объединяем списки
                MainForm.MergedList = SingleLinkedList.MergeAlternating(MainForm.List1, MainForm.List2);
                // Обновляем все ListBox
                UpdateListBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void UpdateListBoxes()
        {
            // Обновляем ListBox для каждого списка
            MainForm.List1.Display(lbList1);
            MainForm.List2.Display(lbList2);
            MainForm.MergedList.Display(lbMergedList);
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}