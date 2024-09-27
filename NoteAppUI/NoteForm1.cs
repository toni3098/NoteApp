using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoteAppUI
{
    public partial class NoteForm1 : Form
    {
        public List<Note> loadNotes = new List<Note>();
        public NoteForm1()
        {
            InitializeComponent();
            try
            {
                loadNotes = Serializer.LoadFromFile<List<Note>>("NoteApp.json");
            }
            catch (Exception ex)
            {

            }


            for (int i = 0; i < loadNotes.Count; i++)
            {
                listBox_Categories.Items.Add(loadNotes[i].Title);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Name_label.Text = listBox_Categories.SelectedItem.ToString();
            for (int i = 0; i < loadNotes.Count; i++)
            {
                if ((listBox_Categories.SelectedItems != null) && (listBox_Categories.SelectedItem == loadNotes[i].Title))
                {
                    Item_Category_label.Text = loadNotes[i]._category.Name.ToString();
                    Creation_dateTimePicker.Value = loadNotes[i].DateCreation;
                    Modification_dateTimePicker.Value = loadNotes[i].DateModification;
                    Content_richBox.Text = loadNotes[i].Content;
                }


            }

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditNote add = new AddEditNote();
            add.Show();
            GlobalIndex.flag = 1;
            GlobalIndex.index = 0;
            this.Hide();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < loadNotes.Count; i++)
            {
                if ((listBox_Categories.SelectedItems != null) && (listBox_Categories.SelectedItem == loadNotes[i].Title))
                {
                    GlobalIndex.index = i;
                    AddEditNote modify = new AddEditNote();
                    GlobalIndex.flag = 2;
                    modify.Show();
                    this.Hide();
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < loadNotes.Count; i++)
            {
                if ((listBox_Categories.SelectedItems != null) && (listBox_Categories.SelectedItem == loadNotes[i].Title))
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gmail : antoniozafitombo316@gmail.com ");
        }


        private void TrierEtAfficherNoms(bool trierParDate = false)
        {
            // Trier la liste d'objets
            if (trierParDate)
            {
                loadNotes.Sort((x, y) => x.DateCreation.CompareTo(y.DateCreation));
            }
            else
            {
                loadNotes.Sort((x, y) => x.Title.CompareTo(y.Title));
            }

            // Vider le ListBox
            listBox_Categories.Items.Clear();

            // Ajouter les noms triés au ListBox
            foreach (Note obj in loadNotes)
            {
                listBox_Categories.Items.Add(obj.Title);
            }
        }

        private void comboBox_Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Récupérer l'élément sélectionné dans le ComboBox
            string selectedItem = comboBox_Sort.SelectedItem.ToString();

            // Vérifier quel élément a été sélectionné et effectuer une action en conséquence
            switch (selectedItem)
            {
                case "All":
                    Name_label.Text = listBox_Categories.SelectedItem.ToString();
                    for (int i = 0; i < loadNotes.Count; i++)
                    {
                        if ((listBox_Categories.SelectedItems != null) && (listBox_Categories.SelectedItem == loadNotes[i].Title))
                        {
                            Item_Category_label.Text = loadNotes[i]._category.Name.ToString();
                            Creation_dateTimePicker.Value = loadNotes[i].DateCreation;
                            Modification_dateTimePicker.Value = loadNotes[i].DateModification;
                            Content_richBox.Text = loadNotes[i].Content;
                        }
                    }
                    break;
                case "By creation date":
                    TrierEtAfficherNoms(true);
                    break;
                case "By name":
                    TrierEtAfficherNoms();
                    break;
            }
        }
    }

}
