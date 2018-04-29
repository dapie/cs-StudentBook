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
    public partial class FormEdit : Form
    {
        int index;
        MainForm mainForm;

        public FormEdit(ListViewItem student, MainForm mForm)
        {
            InitializeComponent();
            nameTextBox.Text = student.Text;
            groupTextBox.Text = student.SubItems[1].Text;
            index = student.Index;
            mainForm = mForm;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(groupTextBox.Text))
            {
                var addForm = new FormError("Не все поля заполнены!");
                addForm.ShowDialog();
                return;
            }
            else
            {
                var item = new ListViewItem(nameTextBox.Text);
                item.SubItems.Add(groupTextBox.Text);
                mainForm.studentList.Items[index] = item;
                this.Close();
            }
        }
    }
}
