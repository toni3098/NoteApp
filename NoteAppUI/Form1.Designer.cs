using NoteAppUI;
namespace NoteAppUI
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
            NewNote = new Button();
            Deserialize = new Button();
            Serialize = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // NewNote
            // 
            NewNote.Location = new Point(12, 36);
            NewNote.Name = "NewNote";
            NewNote.Size = new Size(94, 29);
            NewNote.TabIndex = 0;
            NewNote.Text = "New Note";
            NewNote.UseVisualStyleBackColor = true;
            NewNote.Click += button1_Click;
            // 
            // Deserialize
            // 
            Deserialize.Location = new Point(12, 106);
            Deserialize.Name = "Deserialize";
            Deserialize.Size = new Size(94, 29);
            Deserialize.TabIndex = 1;
            Deserialize.Text = "Deserialize";
            Deserialize.UseVisualStyleBackColor = true;
            Deserialize.Click += Deserialize_Click;
            // 
            // Serialize
            // 
            Serialize.Location = new Point(12, 71);
            Serialize.Name = "Serialize";
            Serialize.Size = new Size(94, 29);
            Serialize.TabIndex = 2;
            Serialize.Text = "Serialize";
            Serialize.UseVisualStyleBackColor = true;
            Serialize.Click += Serialize_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 36);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 261);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(Serialize);
            Controls.Add(Deserialize);
            Controls.Add(NewNote);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NewNote;
        private Button Deserialize;
        private Button Serialize;
        private TextBox textBox1;
    }
}