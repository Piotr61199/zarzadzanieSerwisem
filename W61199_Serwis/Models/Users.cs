using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace W61199_Serwis.Models
{
	public class Users
	{
		[Key]
		public int UserId { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }

		[NotMapped]
		public string FullName
		{
			get { return Name + " " + Surname; }
		}

		public virtual ICollection<Repairs> Repairs { get; set; }

		public bool isAdmin(string name)
		{
			if (name.ToUpper(new CultureInfo("en-US", false)) == "ADMIN")
			{
				return true;
			}
			else
			{
				return false;
			};
		}
	}
}
