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
    public partial class FormAdd : Form
    {
        MainForm mainForm;
        public FormAdd(MainForm mForm)
        {
            InitializeComponent();
            mainForm = mForm;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(groupTextBox.Text))
            {
                var addForm = new FormError();
                addForm.ShowDialog();
                return;
            }
            else
            {
                var item = new ListViewItem(nameTextBox.Text);
                item.SubItems.Add(groupTextBox.Text);
                mainForm.studentList.Items.Add(item);
                this.Close();
            }
        }

        private void groupTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addButton_Click(this, new EventArgs());
            }
        }
    }
}
