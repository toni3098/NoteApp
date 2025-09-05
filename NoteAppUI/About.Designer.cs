namespace NoteAppUI
{
    partial class About
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            linkLabel2 = new LinkLabel();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 46);
            label1.TabIndex = 0;
            label1.Text = "NoteApp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 55);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "v. 1.0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 100);
            label3.Name = "label3";
            label3.Size = new Size(189, 20);
            label3.TabIndex = 2;
            label3.Text = "Author: Zafitombo Antonio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 139);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 3;
            label4.Text = "e-mail for feedback:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(170, 139);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(237, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "antoniozafitombo316@gmail.com";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 179);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 5;
            label5.Text = "Git Hub:";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(90, 179);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(284, 20);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "https://github.com/toni3098/NoteApp.git";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 301);
            label6.Name = "label6";
            label6.Size = new Size(190, 20);
            label6.TabIndex = 7;
            label6.Text = "2024 Zafitombo Antonio ©";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 330);
            Controls.Add(label6);
            Controls.Add(linkLabel2);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "About";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label label5;
        private LinkLabel linkLabel2;
        private Label label6;
    }
}