using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteAppUI
{
    /// <summary>
    /// Represents a category for notes.
    /// </summary>
    
    public class Category
    {

        private string _name;
        //private string _description;

        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the value is null or empty.</exception>
       
        public string Name
        {
            get 
            { 
                return _name; 
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("The name cannot be null or empty.");

                _name = value;
            }
        }
        /*
        /// <summary>
        /// Gets or sets the description of the category.
        /// </summary>
        public string Description
        {
            get 
            {
                return _description; 
            }
            set 
            { 
                _description = value; 
            }
        }
        */
        public Category(string name) 
        {
            Name = name;
            //Description = description;
        }
        public Category() { }
    }
}
