using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentBook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addForm = new FormAdd(this);
            addForm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem student in studentList.Items)
            {
                if (student.Selected)
                {
                    return;
                }
            }
            var addForm = new FormError("Ничего не выделено!");
            addForm.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem student in studentList.Items)
            {
                if (student.Selected)
                {
                    studentList.Items.Remove(student);
                }
            }
        }
    }
}
