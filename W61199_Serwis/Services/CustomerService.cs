using System.Collections.Generic;
using System.Linq;
using W61199_Serwis.Models;
using System.Data.Entity;

namespace W61199_Serwis.Services
{
	class CustomerService
	{
		public CustomerService()
		{
			ctx = new ServiceContext();
		}

		private readonly ServiceContext ctx;

		public void AddNewCustomer(Customers customer)
		{			
			ctx.Customers.Add(customer);
			ctx.SaveChanges();	
		}

		public void UpdateCustomer(Customers customer)
		{
			var oldValues = FindCustomer(customer.CustomerId);

			oldValues.Name = customer.Name;
			oldValues.Surname = customer.Surname;
			oldValues.Phone = customer.Phone;
			oldValues.Address = customer.Address;
			oldValues.Email = customer.Email;

			ctx.SaveChanges();
		}

		public Customers FindCustomer(int customerId)
		{
			return ctx.Customers.Find(customerId);
		}

		public List<Customers> GetAllCustomers()
		{
			return ctx.Customers.AsNoTracking().ToList();			
		}

		public void DeleteCustomer(int customerId)
		{
			ctx.Customers.Remove(FindCustomer(customerId));
			ctx.SaveChanges();
		}

		public List<Repairs> GetHistory(int customerId)
		{
			return ctx.Repairs
				.Include(u => u.Users)
				.Include(c => c.Customers)
				.Where(c=>c.CustomerId == customerId)
				.ToList();
		}
	}
}
