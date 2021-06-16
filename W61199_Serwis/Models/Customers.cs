using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace W61199_Serwis.Models
{
	/// <summary>
	/// SQL database model class.
	/// Customers model compatible with the database.
	/// </summary>
	public class Customers
	{
		[Key]
		public int CustomerId { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }

		[NotMapped]
		public string FullName
		{
			get { return Name + " " + Surname; }
		}

		public virtual ICollection<Repairs> Repairs { get; set; }
	}
}
