using System.Collections.Generic;
using System.Linq;
using W61199_Serwis.Models;
using System.Data.Entity;

namespace W61199_Serwis.Services
{
	/// <summary>
	/// Customer data handling class.
	/// This class is designed to handle insertion, update and deletion of Customer data.
	/// </summary>
	class CustomerService
	{
		/// <summary>
		/// Load of private content from SQL database.
		/// </summary>
		public CustomerService()
		{
			ctx = new ServiceContext();
		}

		private readonly ServiceContext ctx;

		/// <summary>
		/// A method to add new customer to SQL database.
		/// </summary>
		/// <param name="customer">New customer data set.</param>
		public void AddNewCustomer(Customers customer)
		{			
			ctx.Customers.Add(customer);
			ctx.SaveChanges();	
		}

		/// <summary>
		/// A method to update customer data into SQL database.
		/// </summary>
		/// <param name="customer">Customer new data set.</param>
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

		/// <summary>
		/// A method to find out customer data into SQL database.
		/// </summary>
		/// <param name="customerId">Customer ID.</param>
		public Customers FindCustomer(int customerId)
		{
			return ctx.Customers.Find(customerId);
		}

		/// <summary>
		/// A method to create a list of all customers into SQL database.
		/// </summary>
		public List<Customers> GetAllCustomers()
		{
			return ctx.Customers.AsNoTracking().ToList();			
		}

		/// <summary>
		/// A method to delete customer data from SQL database.
		/// </summary>
		/// <param name="customerId">Customer ID.</param>
		public void DeleteCustomer(int customerId)
		{
			ctx.Customers.Remove(FindCustomer(customerId));
			ctx.SaveChanges();
		}

		/// <summary>
		/// A method to find out customer service history into SQL database.
		/// </summary>
		/// <param name="customerId">Customer ID.</param>
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
