using Newtonsoft.Json;
using System;
using System.Text.Json;

namespace NoteAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = new Random().Next(1, 100);
                var category = new Category("Work", "For the presentation day");
                var note = new Note(id, "Presentation", "This work was done by the members of the group.", category);
                textBox1.Text = "Note \r\nId : " + note.Id
                    + "\r\nTitle : " + note.Title
                    + "\r\nContent : " + note.Content
                    + "\r\nCategory : " + note._category.Name + "//" + note._category.Description;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void Serialize_Click(object sender, EventArgs e)
        {
            try
            {
                int id = new Random().Next(1, 100);
                var notes = new List<Note>();
                var category = new Category("Work", "For the presentation day");
                var note = new Note(id, "Presentation", "This work was done by the members of the group.", category);
                notes.Add(note);
                string json = JsonConvert.SerializeObject(notes);
                File.WriteAllText("notes.json", json);
                //Console.WriteLine("JSON file created successfully!");
                Serializer.SaveToFile(notes, filename: "notes.json");
                MessageBox.Show("The data serialized\r\nId :" + note.Id +"\r\n" +
                    "\r\nTitle : " + note.Title + "\r\n" +
                    "\r\nContent : " + note.Content + "\r\n" +
                    "\r\nCategory : " + note._category.Name + "\\" + note._category.Description);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void Deserialize_Click(object sender, EventArgs e)
        {
            try
            {
                var loadNotes = new List<Note>();
                loadNotes = Serializer.LoadFromFile<List<Note>>("notes.json");
                MessageBox.Show("The data serialized\r\nId :" + loadNotes[0].Id + "\r\n" +
                    "\r\nTitle : " + loadNotes[0].Title + "\r\n" +
                    "\r\nContent : " + loadNotes[0].Content + "\r\n" +
                    "\r\nCategory : " + loadNotes[0]._category.Name + "\\" + loadNotes[0]._category.Description);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            
        }
    }
}