using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteAppUI
{
    /// <summary>
    /// Represents note.
    /// </summary>
    public class Note
    {
        private int _id;
        private string _title;
        private string _content;

        /// <summary>
        /// Gets or sets the ID of the Note.
        /// </summary>
        public int Id
        {
            get 
            { 
                return _id; 
            }
            set 
            { 
                _id = value; 
            }
        }

        /// <summary>
        /// Gets or sets the title of notes and checking if it is empty or not.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the value is less than or equal to zero.</exception>
        public string Title
        {
            get 
            { 
                return _title; 
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Название заметки не может быть пустым.");

                _title = value;
            }
        }

        /// <summary>
        /// Gets or sets the content of the Note.
        /// </summary>
        public string Content
        {
            get 
            { 
                return _content; 
            }
            set 
            { 
                _content = value; 
            }
        }

        /// <summary>
        /// Change the title of the Note.
        /// </summary>
        public void ChangeTitle(string newTitle)
        {
            if (string.IsNullOrEmpty(newTitle))
                throw new ArgumentException("Новое название заметки не может быть пустым.");

            _title = newTitle;
        }

        /// <summary>
        /// Add the content of the Note.
        /// </summary>
        public void AppendContent(string additionalContent)
        {
            if (!string.IsNullOrEmpty(additionalContent))
                _content += Environment.NewLine + additionalContent;
        }
    }
}
