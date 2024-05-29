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
    public partial class AddEditNote : Form
    {

        public List<Note> notes = new List<Note>();
        public AddEditNote()
        {
            InitializeComponent();
            try
            {
                notes = Serializer.LoadFromFile<List<Note>>("NoteApp.json");
            }
            catch (Exception)
            {
                throw;
            }

            textBox1.Text = notes[GlobalIndex.index].Title.ToString();
            textBox2.Text = notes[GlobalIndex.index].Content.ToString();
            comboBox1.SelectedItem = notes[GlobalIndex.index]._category.Name.ToString();

            if (string.IsNullOrEmpty(textBox1.Text) & string.IsNullOrEmpty(textBox2.Text))
            {
                textBox1.BackColor = Color.Pink;
                textBox2.BackColor = Color.Pink;
                button1.Enabled = false;
            }
            else if (comboBox1.Text != null && textBox1.Text != null && textBox2.Text != null)

            {
                button1.Enabled = true;
            }

        }

        private void textBox1_TextChanged(Object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(textBox1.Text);
        }

        private void textBox2_TextChanged(Object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(textBox2.Text);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm();
            this.Close();
            noteForm.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GlobalIndex.flag == 1)
            {
                try
                {
                    int id = new Random().Next(1, 100);
                    var category = new Category(comboBox1.Text);
                    DateTime creation = dateTimePicker1.Value = DateTime.Now;
                    DateTime modification = dateTimePicker2.Value = DateTime.Now;
                    Note createdNote = new Note(id, textBox1.Text, textBox2.Text, category, creation, modification);
                    notes.Add(createdNote);
                    string json = JsonConvert.SerializeObject(notes);
                    File.WriteAllText("NoteApp.json", json);
                    //Console.WriteLine("JSON file created successfully!");
                    Serializer.SaveToFile(notes, filename: "NoteApp.json");
                    MessageBox.Show("The note has been added successfully");
                    NoteForm main = new NoteForm();
                    main.Update();
                    main.Show();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                NoteForm noteForm = new NoteForm();
                this.Close();
                noteForm.Update();
            }
            else if (GlobalIndex.flag == 2)
            {
                try
                {
                    notes[GlobalIndex.index].Title = textBox1.Text;
                    notes[GlobalIndex.index]._category.Name = comboBox1.Text;
                    notes[GlobalIndex.index].Content = textBox2.Text;
                    notes[GlobalIndex.index].DateModification = dateTimePicker2.Value = DateTime.Now;
                    string json = JsonConvert.SerializeObject(notes);
                    File.WriteAllText("NoteApp.json", json);
                    //Console.WriteLine("JSON file created successfully!");
                    Serializer.SaveToFile(notes, filename: "NoteApp.json");
                    MessageBox.Show("The note has been modified successfully");
                    NoteForm main = new NoteForm();
                    main.Update();
                    main.Show();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                NoteForm noteForm = new NoteForm();
                this.Close();
                noteForm.Update();
            }
        }
       
    }
}
