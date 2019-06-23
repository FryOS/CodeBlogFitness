using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBlogFitness.BL.Models
{
    [Serializable]
    /// <summary>
    /// Gender
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// Summary
        /// </summary>
        
        public String Name { get; }
        /// <summary>
        /// Create new gender
        /// </summary>
        /// <param name="name">Name of gender</param>
        public Gender(string name) 
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым или null", nameof(name));
            }

            Name = name;
        }
        //comment 2
        public override string ToString()
        {
            return Name;
        }
    }
}
