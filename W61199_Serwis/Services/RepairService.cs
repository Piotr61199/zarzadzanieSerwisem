using System.Collections.Generic;
using W61199_Serwis.Models;
using System.Linq;
using System.Data.Entity;

namespace W61199_Serwis.Services
{
	class RepairService
	{
		public RepairService()
		{
			ctx = new ServiceContext();
		}

		private readonly ServiceContext ctx;

		public void AddNewRepair(Repairs repair)
		{
			using (ServiceContext ctx = new ServiceContext())
			{
				ctx.Repairs.Add(repair);
				ctx.SaveChanges();
			}
		}

		public Repairs FindRepair(int repairId)
		{
			return ctx.Repairs
				.Include(d => d.Devices)
				.First(x=>x.RepairId == repairId);
		}

		public void AddRepair(Repairs repair)
		{
			ctx.Repairs.Add(repair);
			ctx.SaveChanges();
		}

		public void DeleteRepair(int repairId)
		{
			ctx.Repairs.Remove(FindRepair(repairId));
			ctx.SaveChanges();
		}

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
