namespace NoteAppUI
{
    partial class NoteForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem1 = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contactUsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            Show_Categories_label = new Label();
            comboBox_Sort = new ComboBox();
            listBox_Categories = new ListBox();
            Name_label = new Label();
            Category_label = new Label();
            Item_Category_label = new Label();
            DateCreation_label = new Label();
            Creation_dateTimePicker = new DateTimePicker();
            DateModification_label = new Label();
            Modification_dateTimePicker = new DateTimePicker();
            Content_richBox = new RichTextBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1076, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, deleteToolStripMenuItem, editToolStripMenuItem1, saveAsToolStripMenuItem, openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Image = Properties.Resources.Files_Add_File_icon;
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(141, 26);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.delete_icon_black_add_file_icon_11553453003dpxmig6xbh;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(141, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.Image = Properties.Resources.notes__1_;
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(141, 26);
            editToolStripMenuItem1.Text = "Edit";
            editToolStripMenuItem1.Click += editToolStripMenuItem1_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Image = Properties.Resources.save_1024x1024;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(141, 26);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = Properties.Resources.folder_open_1024x830;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(141, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contactUsToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // contactUsToolStripMenuItem
            // 
            contactUsToolStripMenuItem.Image = Properties.Resources.email_1024x731;
            contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            contactUsToolStripMenuItem.Size = new Size(161, 26);
            contactUsToolStripMenuItem.Text = "Contact us";
            contactUsToolStripMenuItem.Click += contactUsToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Show_Categories_label
            // 
            Show_Categories_label.AutoSize = true;
            Show_Categories_label.Location = new Point(12, 49);
            Show_Categories_label.Name = "Show_Categories_label";
            Show_Categories_label.Size = new Size(131, 20);
            Show_Categories_label.TabIndex = 1;
            Show_Categories_label.Text = "Show Categories : ";
            Show_Categories_label.Click += label1_Click;
            // 
            // comboBox_Sort
            // 
            comboBox_Sort.FormattingEnabled = true;
            comboBox_Sort.Items.AddRange(new object[] { "All", "By creation date", "By name" });
            comboBox_Sort.Location = new Point(149, 46);
            comboBox_Sort.Name = "comboBox_Sort";
            comboBox_Sort.Size = new Size(151, 28);
            comboBox_Sort.TabIndex = 2;
            comboBox_Sort.SelectedIndexChanged += comboBox_Sort_SelectedIndexChanged;
            // 
            // listBox_Categories
            // 
            listBox_Categories.FormattingEnabled = true;
            listBox_Categories.ItemHeight = 20;
            listBox_Categories.Location = new Point(12, 89);
            listBox_Categories.Name = "listBox_Categories";
            listBox_Categories.Size = new Size(288, 504);
            listBox_Categories.TabIndex = 3;
            listBox_Categories.SelectedIndexChanged += listBox_Categories_SelectedIndexChanged;
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Name_label.Location = new Point(306, 9);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(201, 81);
            Name_label.TabIndex = 4;
            Name_label.Text = "Name";
            // 
            // Category_label
            // 
            Category_label.AutoSize = true;
            Category_label.Location = new Point(319, 89);
            Category_label.Name = "Category_label";
            Category_label.Size = new Size(80, 20);
            Category_label.TabIndex = 5;
            Category_label.Text = "Category : ";
            // 
            // Item_Category_label
            // 
            Item_Category_label.AutoSize = true;
            Item_Category_label.Location = new Point(405, 90);
            Item_Category_label.Name = "Item_Category_label";
            Item_Category_label.Size = new Size(41, 20);
            Item_Category_label.TabIndex = 6;
            Item_Category_label.Text = "Here";
            // 
            // DateCreation_label
            // 
            DateCreation_label.AutoSize = true;
            DateCreation_label.Location = new Point(319, 123);
            DateCreation_label.Name = "DateCreation_label";
            DateCreation_label.Size = new Size(68, 20);
            DateCreation_label.TabIndex = 7;
            DateCreation_label.Text = "Created :";
            // 
            // Creation_dateTimePicker
            // 
            Creation_dateTimePicker.Location = new Point(393, 118);
            Creation_dateTimePicker.Name = "Creation_dateTimePicker";
            Creation_dateTimePicker.Size = new Size(250, 27);
            Creation_dateTimePicker.TabIndex = 8;
            // 
            // DateModification_label
            // 
            DateModification_label.AutoSize = true;
            DateModification_label.Location = new Point(659, 123);
            DateModification_label.Name = "DateModification_label";
            DateModification_label.Size = new Size(77, 20);
            DateModification_label.TabIndex = 9;
            DateModification_label.Text = "Modified :";
            // 
            // Modification_dateTimePicker
            // 
            Modification_dateTimePicker.Location = new Point(742, 118);
            Modification_dateTimePicker.Name = "Modification_dateTimePicker";
            Modification_dateTimePicker.Size = new Size(250, 27);
            Modification_dateTimePicker.TabIndex = 10;
            // 
            // Content_richBox
            // 
            Content_richBox.Location = new Point(319, 163);
            Content_richBox.Name = "Content_richBox";
            Content_richBox.Size = new Size(743, 431);
            Content_richBox.TabIndex = 11;
            Content_richBox.Text = "";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 595);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1076, 27);
            toolStrip1.TabIndex = 12;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.Files_Add_File_icon;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.notes__1_;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.delete_icon_black_add_file_icon_11553453003dpxmig6xbh;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // NoteForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 622);
            Controls.Add(toolStrip1);
            Controls.Add(Content_richBox);
            Controls.Add(Modification_dateTimePicker);
            Controls.Add(DateModification_label);
            Controls.Add(Creation_dateTimePicker);
            Controls.Add(DateCreation_label);
            Controls.Add(Item_Category_label);
            Controls.Add(Category_label);
            Controls.Add(Name_label);
            Controls.Add(listBox_Categories);
            Controls.Add(comboBox_Sort);
            Controls.Add(Show_Categories_label);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "NoteForm1";
            Text = "NoteApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contactUsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label Show_Categories_label;
        private ComboBox comboBox_Sort;
        private ListBox listBox_Categories;
        private Label Name_label;
        private Label Category_label;
        private Label Item_Category_label;
        private Label DateCreation_label;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private DateTimePicker Creation_dateTimePicker;
        private Label DateModification_label;
        private DateTimePicker Modification_dateTimePicker;
        private RichTextBox Content_richBox;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
    }
}