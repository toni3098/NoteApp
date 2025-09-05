namespace NoteAppUI
{
    partial class AddEditNote
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
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(687, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Catogery:";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Work", "Study", "Tasks", "Others" });
            comboBox1.Location = new Point(101, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(435, 91);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(352, 94);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 13;
            label6.Text = "Modified: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(101, 91);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(245, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 96);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 11;
            label4.Text = "Created: ";
            // 
            // button1
            // 
            button1.Location = new Point(591, 643);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(694, 643);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 17;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 134);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(769, 503);
            textBox2.TabIndex = 18;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // AddEditNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 684);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AddEditNote";
            Text = "Add/Edit Note";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
    }
}