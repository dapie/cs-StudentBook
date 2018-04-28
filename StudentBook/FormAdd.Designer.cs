namespace StudentBook
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(115, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя студента";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 42);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(211, 26);
            this.nameTextBox.TabIndex = 1;
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(229, 42);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(211, 26);
            this.groupTextBox.TabIndex = 3;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(229, 9);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(61, 20);
            this.labelGroup.TabIndex = 2;
            this.labelGroup.Text = "Группа";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(312, 87);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(128, 42);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 145);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление студента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Button addButton;
    }
}