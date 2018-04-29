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
        public FormEdit()
        {
            InitializeComponent();
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
                //mainForm.studentList.Items.Add(item);
                this.Close();
            }
        }
    }
}
