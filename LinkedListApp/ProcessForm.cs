using System;
using System.Windows.Forms;

namespace LinkedListApp
{
    public partial class ProcessForm : Form
    {
        public ProcessForm()
        {
            InitializeComponent();
            MainForm.List1.Display(listBox1);
            MainForm.List2.Display(listBox2);
            MainForm.MergedList.Display(listBoxMerged);
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.MergedList = SingleLinkedList.MergeAlternating(MainForm.List1, MainForm.List2);
                MainForm.List1.Display(listBox1);
                MainForm.List2.Display(listBox2);
                MainForm.MergedList.Display(listBoxMerged);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}