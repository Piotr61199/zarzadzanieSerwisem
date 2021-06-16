using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace W61199_Serwis.Models
{
	/// <summary>
	/// SQL database model class.
	/// Devices model compatible with the database.
	/// </summary>
	public class Devices
	{
		[Key]
		public int DeviceId { get; set; }
		public string Producer { get; set; }
		public string Model { get; set; }
		public string SerialNumber { get; set; }

		public virtual ICollection<Repairs> Repairs { get; set; }

	}
}
