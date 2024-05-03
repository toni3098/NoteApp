using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace NoteAppUI
{

    public partial class NoteForm : Form
    {
        public List<Note> loadNotes = new List<Note>();

        public NoteForm()
        {
            InitializeComponent();
            loadNotes = Serializer.LoadFromFile<List<Note>>("NoteApp.json");

            for (int i = 0; i < loadNotes.Count; i++)
            {
                listBox1.Items.Add(loadNotes[i].Title);
            }
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddEditNote add = new AddEditNote();
            add.Show();
            GlobalIndex.flag = 1;
            GlobalIndex.index = 0;
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < loadNotes.Count; i++)
            {
                if ((listBox1.SelectedItems != null) && (listBox1.SelectedItem == loadNotes[i].Title))
                {
                    GlobalIndex.index = i;
                    AddEditNote modify = new AddEditNote();
                    GlobalIndex.flag = 2;
                    modify.Show();
                    this.Hide();
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = listBox1.SelectedItem.ToString();
            for (int i = 0; i < loadNotes.Count; i++)
            {
                if ((listBox1.SelectedItems != null) && (listBox1.SelectedItem == loadNotes[i].Title))
                {
                    Category.Text = loadNotes[i]._category.Name.ToString();
                    dateTimePicker1.Value = loadNotes[i].DateCreation;
                    dateTimePicker2.Value = loadNotes[i].DateModification;
                    Content.Text = loadNotes[i].Content;
                }


            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < loadNotes.Count; i++)
            {
                if ((listBox1.SelectedItems != null) && (listBox1.SelectedItem == loadNotes[i].Title))
                {
                    GlobalIndex.indexDelete = i;
                    DialogResult result = MessageBox.Show("Do you really want to delete this file ?", "Confirm the suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        loadNotes.Remove(loadNotes[GlobalIndex.indexDelete]);
                        string json = JsonConvert.SerializeObject(loadNotes);
                        File.WriteAllText("NoteApp.json", json);
                        //Console.WriteLine("JSON file created successfully!");
                        Serializer.SaveToFile(loadNotes, filename: "NoteApp.json");
                        MessageBox.Show("The note has been deleted successfully");
                        this.Update();
                        this.Hide();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Canceled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }





        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Только текстовые файлы (*.txt) | *.txt";
            dialog.CheckFileExists = true;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = dialog.FileName;
                if (filename == string.Empty)
                {
                    ProgramSaveOpenFile.OpenFile(filename);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "C:\file.txt";
            DialogResult result = MessageBox.Show("Сохранить файл?\n" + filename,
             "Сохранение файла",
             MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ProgramSaveOpenFile.SaveFile(filename);
            }
        }
    }
}
