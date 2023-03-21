using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one person.
    /// </summary>
	public class PersonModel
    {
        /// <summary>
        /// The Id of the Person object in database.
        /// </summary>
		public int Id { get; set; }
		/// <summary>
		/// The first name of the person.
		/// </summary>
		public string FirstName { get; set; }
        /// <summary>
        /// The last name of the person.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The email address of the person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// The cell phone number this person wishes to be contacted via.
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get 
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
