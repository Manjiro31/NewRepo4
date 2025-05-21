using System;
using System.Windows.Forms;

namespace LinkedListApp
{
    public partial class MainForm : Form
    {
        public static SingleLinkedList List1 { get; set; }
        public static SingleLinkedList List2 { get;  set; }
        public static SingleLinkedList MergedList { get;  set; }

        public MainForm()
        {
            InitializeComponent();
            List1 = new SingleLinkedList();
            List2 = new SingleLinkedList();
            MergedList = new SingleLinkedList();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            createForm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.ShowDialog();
        }

        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessForm processForm = new ProcessForm();
            processForm.ShowDialog();
        }

        private void destroyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List1.Destroy();
            List2.Destroy();
            MergedList.Destroy();
            MessageBox.Show("Все списки разрушены", "Разрушение списков");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}