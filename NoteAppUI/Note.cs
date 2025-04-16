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
        private DateTime _dateCreation;
        private DateTime _dateModification;
        public Category _category;

        /// <summary>
        /// Gets or sets the ID of the Note.
        /// </summary>
        /// /// <exception cref="ArgumentException">Thrown when the value is less than or equal to zero.</exception>
        

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("The identifier must be a positive number.");

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

        public DateTime DateCreation
        {
            get 
            { 
                return _dateCreation; 
            }
            set 
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Дата модификации не может быть в будущем.");
                }
                _dateCreation = value; 
            }
        }

        public DateTime DateModification
        {
            get 
            { 
                return _dateModification; 
            }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Дата модификации не может быть в будущем.");
                }
                _dateModification = value;
            }
        }

        /// <summary>
        /// Constructor function of the Note.
        /// </summary>

        
        public Note(int id,string title, string content, Category category, DateTime creationDate, DateTime modificationDate) 
        {
            Id = id;
            Title = title; 
            Content = content;
            _category = category;
            _dateCreation = creationDate;
            _dateModification = modificationDate;
        }
        public Note(){ }
    }
}
