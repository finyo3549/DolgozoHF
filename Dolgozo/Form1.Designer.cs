namespace Dolgozo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listBox_workers = new ListBox();
            label2 = new Label();
            textBox_Name = new TextBox();
            textbox_Position = new TextBox();
            label3 = new Label();
            label4 = new Label();
            numericUpDown_Salary = new NumericUpDown();
            button_New = new Button();
            button_Update = new Button();
            button_Delete = new Button();
            label5 = new Label();
            numericUpDown_ID = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Salary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ID).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 27);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Workers";
            label1.Click += label1_Click;
            // 
            // listBox_workers
            // 
            listBox_workers.FormattingEnabled = true;
            listBox_workers.ItemHeight = 15;
            listBox_workers.Location = new Point(27, 57);
            listBox_workers.Name = "listBox_workers";
            listBox_workers.Size = new Size(312, 319);
            listBox_workers.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 110);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(484, 107);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(204, 23);
            textBox_Name.TabIndex = 3;
            // 
            // textbox_Position
            // 
            textbox_Position.Location = new Point(484, 194);
            textbox_Position.Name = "textbox_Position";
            textbox_Position.Size = new Size(204, 23);
            textbox_Position.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 197);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 150);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "Salary";
            // 
            // numericUpDown_Salary
            // 
            numericUpDown_Salary.Location = new Point(486, 152);
            numericUpDown_Salary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown_Salary.Name = "numericUpDown_Salary";
            numericUpDown_Salary.Size = new Size(202, 23);
            numericUpDown_Salary.TabIndex = 7;
            numericUpDown_Salary.TextAlign = HorizontalAlignment.Right;
            // 
            // button_New
            // 
            button_New.Location = new Point(438, 339);
            button_New.Name = "button_New";
            button_New.Size = new Size(75, 23);
            button_New.TabIndex = 8;
            button_New.Text = "New";
            button_New.UseVisualStyleBackColor = true;
            button_New.Click += button_New_Click;
            // 
            // button_Update
            // 
            button_Update.Location = new Point(558, 339);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(75, 23);
            button_Update.TabIndex = 9;
            button_Update.Text = "Update";
            button_Update.UseVisualStyleBackColor = true;
            button_Update.Click += button_Update_Click;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(675, 339);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(75, 23);
            button_Delete.TabIndex = 10;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(412, 69);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 11;
            label5.Text = "ID";
            // 
            // numericUpDown_ID
            // 
            numericUpDown_ID.Location = new Point(484, 64);
            numericUpDown_ID.Name = "numericUpDown_ID";
            numericUpDown_ID.ReadOnly = true;
            numericUpDown_ID.Size = new Size(204, 23);
            numericUpDown_ID.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown_ID);
            Controls.Add(label5);
            Controls.Add(button_Delete);
            Controls.Add(button_Update);
            Controls.Add(button_New);
            Controls.Add(numericUpDown_Salary);
            Controls.Add(label4);
            Controls.Add(textbox_Position);
            Controls.Add(label3);
            Controls.Add(textBox_Name);
            Controls.Add(label2);
            Controls.Add(listBox_workers);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Salary).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox_workers;
        private Label label2;
        private TextBox textBox_Name;
        private TextBox textbox_Position;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown_Salary;
        private Button button_New;
        private Button button_Update;
        private Button button_Delete;
        private Label label5;
        private NumericUpDown numericUpDown_ID;
    }
}
