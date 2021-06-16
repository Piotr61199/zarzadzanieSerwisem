using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace W61199_Serwis.Models
{
	/// <summary>
	/// SQL database model class.
	/// Repairs model compatible with the database.
	/// </summary>
	public class Repairs
	{
		[Key]
		public int RepairId { get; set; }
		[ForeignKey("Devices")]
		public int DeviceId { get; set; }
		[ForeignKey("Users")]
		public int UserId { get; set; }
		[ForeignKey("Customers")]
		public int CustomerId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string Note { get; set; }
		public decimal Costs { get; set; }
		public short Status { get; set; }

		public virtual Customers Customers { get; set; }
		public virtual Devices Devices { get; set; }
		public virtual Users Users { get; set; }

	}
}
