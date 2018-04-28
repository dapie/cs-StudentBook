using System.Drawing;

namespace StudentBook
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentList = new System.Windows.Forms.ListView();
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.AutoArrange = false;
            this.studentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentName,
            this.studentGroup});
            this.studentList.GridLines = true;
            this.studentList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.studentList.Location = new System.Drawing.Point(12, 77);
            this.studentList.MultiSelect = false;
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(722, 699);
            this.studentList.TabIndex = 0;
            this.studentList.UseCompatibleStateImageBehavior = false;
            this.studentList.View = System.Windows.Forms.View.Details;
            // 
            // studentName
            // 
            this.studentName.Text = "Имя студента";
            this.studentName.Width = 222;
            // 
            // studentGroup
            // 
            this.studentGroup.Text = "Группа";
            this.studentGroup.Width = 500;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(13, 13);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 58);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(746, 788);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.studentList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Список студентов";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView studentList;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentGroup;
        private System.Windows.Forms.Button buttonAdd;
    }
}

