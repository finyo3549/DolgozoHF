namespace Dolgozo
{
    partial class NewForm
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
            label1 = new Label();
            Newform_textbox_Name = new TextBox();
            NewForm_textbox_Position = new TextBox();
            label2 = new Label();
            label3 = new Label();
            NewForm_numericUpDown_Salary = new NumericUpDown();
            NewForm_button_Save = new Button();
            NewForm_Button_Cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)NewForm_numericUpDown_Salary).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 89);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // Newform_textbox_Name
            // 
            Newform_textbox_Name.Location = new Point(330, 90);
            Newform_textbox_Name.Name = "Newform_textbox_Name";
            Newform_textbox_Name.Size = new Size(275, 23);
            Newform_textbox_Name.TabIndex = 1;
            // 
            // NewForm_textbox_Position
            // 
            NewForm_textbox_Position.Location = new Point(330, 134);
            NewForm_textbox_Position.Name = "NewForm_textbox_Position";
            NewForm_textbox_Position.Size = new Size(275, 23);
            NewForm_textbox_Position.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 137);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 188);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Salary";
            // 
            // NewForm_numericUpDown_Salary
            // 
            NewForm_numericUpDown_Salary.Location = new Point(331, 186);
            NewForm_numericUpDown_Salary.Name = "NewForm_numericUpDown_Salary";
            NewForm_numericUpDown_Salary.Size = new Size(274, 23);
            NewForm_numericUpDown_Salary.TabIndex = 5;
            // 
            // NewForm_button_Save
            // 
            NewForm_button_Save.Location = new Point(355, 302);
            NewForm_button_Save.Name = "NewForm_button_Save";
            NewForm_button_Save.Size = new Size(75, 23);
            NewForm_button_Save.TabIndex = 6;
            NewForm_button_Save.Text = "Save";
            NewForm_button_Save.UseVisualStyleBackColor = true;
            NewForm_button_Save.Click += NewForm_button_Save_Click;
            // 
            // NewForm_Button_Cancel
            // 
            NewForm_Button_Cancel.Location = new Point(457, 302);
            NewForm_Button_Cancel.Name = "NewForm_Button_Cancel";
            NewForm_Button_Cancel.Size = new Size(75, 23);
            NewForm_Button_Cancel.TabIndex = 7;
            NewForm_Button_Cancel.Text = "Cancel";
            NewForm_Button_Cancel.UseVisualStyleBackColor = true;
            NewForm_Button_Cancel.Click += NewForm_Button_Cancel_Click;
            // 
            // NewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NewForm_Button_Cancel);
            Controls.Add(NewForm_button_Save);
            Controls.Add(NewForm_numericUpDown_Salary);
            Controls.Add(label3);
            Controls.Add(NewForm_textbox_Position);
            Controls.Add(label2);
            Controls.Add(Newform_textbox_Name);
            Controls.Add(label1);
            Name = "NewForm";
            Text = "NewForm";
            Load += NewForm_Load;
            ((System.ComponentModel.ISupportInitialize)NewForm_numericUpDown_Salary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Newform_textbox_Name;
        private TextBox NewForm_textbox_Position;
        private Label label2;
        private Label label3;
        private NumericUpDown NewForm_numericUpDown_Salary;
        private Button NewForm_button_Save;
        private Button NewForm_Button_Cancel;
    }
}