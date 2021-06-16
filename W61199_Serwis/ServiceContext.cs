using System.Data.Entity;
using W61199_Serwis.Models;

namespace W61199_Serwis
{
	class ServiceContext : DbContext
	{
		public ServiceContext() : base("ServiceContext") {

			this.Configuration.LazyLoadingEnabled = true;
		}

		public DbSet<Users> Users { get; set; }
		public DbSet<Customers> Customers { get; set; }
		public DbSet<Devices> Devices { get; set; }
		public DbSet<Repairs> Repairs { get; set; }

	}
}
