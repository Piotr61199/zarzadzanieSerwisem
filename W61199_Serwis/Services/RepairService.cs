using System.Collections.Generic;
using W61199_Serwis.Models;
using System.Linq;
using System.Data.Entity;

namespace W61199_Serwis.Services
{
	/// <summary>
	/// Repair data handling class.
	/// This class is designed to handle insertion, update and deletion of Repair data.
	/// </summary>
	class RepairService
	{
		/// <summary>
		/// Load of private content from SQL database.
		/// </summary>
		public RepairService()
		{
			ctx = new ServiceContext();
		}

		private readonly ServiceContext ctx;

		/// <summary>
		/// A method to add new repair to SQL database.
		/// </summary>
		/// <param name="repair">New repair data set.</param>
		public void AddNewRepair(Repairs repair)
		{
			using (ServiceContext ctx = new ServiceContext())
			{
				ctx.Repairs.Add(repair);
				ctx.SaveChanges();
			}
		}

		/// <summary>
		/// A method to find out repair data into SQL database.
		/// </summary>
		/// <param name="repairId">Repair ID.</param>
		public Repairs FindRepair(int repairId)
		{
			return ctx.Repairs
				.Include(d => d.Devices)
				.First(x=>x.RepairId == repairId);
		}

		/// <summary>
		/// A method to add new repair to SQL database.
		/// </summary>
		/// <param name="repair">Repair data set.</param>
		public void AddRepair(Repairs repair)
		{
			ctx.Repairs.Add(repair);
			ctx.SaveChanges();
		}

		/// <summary>
		/// A method to delete repair data from SQL database.
		/// </summary>
		/// <param name="repairId">Repair ID.</param>
		public void DeleteRepair(int repairId)
		{
			ctx.Repairs.Remove(FindRepair(repairId));
			ctx.SaveChanges();
		}

		/// <summary>
		/// A method to update repair data into SQL database.
		/// </summary>
		/// <param name="repair">Repair new data set.</param>
		public void UpdateRepair(Repairs repair)
		{
			var oldValues = FindRepair(repair.RepairId);

			oldValues.CustomerId = repair.CustomerId;
			oldValues.UserId = repair.UserId;
			oldValues.DeviceId = repair.DeviceId;
			oldValues.Costs = repair.Costs;
			oldValues.Note = repair.Note;
			oldValues.StartDate = repair.StartDate;
			oldValues.EndDate = repair.EndDate;
			oldValues.Status = repair.Status;

			ctx.SaveChanges();
		}

		/// <summary>
		/// A method to create a list of all repairs into SQL database.
		/// </summary>
		public List<Repairs> GetAllRepairs()
		{
			return ctx.Repairs
						.AsNoTracking()
						.Include(c=>c.Customers)
						.Include(u=>u.Users)
						.Include(d=>d.Devices)
						.ToList();
		}
	}
}
