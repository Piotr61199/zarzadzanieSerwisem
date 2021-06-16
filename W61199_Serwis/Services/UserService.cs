using System.Collections.Generic;
using System.Linq;
using W61199_Serwis.Models;
using System.Data.Entity;

namespace W61199_Serwis.Services
{
	/// <summary>
	/// Users data handling class.
	/// This class is designed to handle insertion, update and deletion of Users data.
	/// </summary>
	class UserService
	{
		/// <summary>
		/// Load of private content from SQL database.
		/// </summary>
		public UserService()
		{
			ctx = new ServiceContext();
		}

		private readonly ServiceContext ctx;

		/// <summary>
		/// A method to update customer data into SQL database.
		/// </summary>
		/// <param name="login">User login.</param>
		/// <param name="password">User password.</param>
		public bool Login(string login, string password)
		{
			var user = ctx.Users.FirstOrDefault(x => x.Login == login && x.Password == password);

			if(user != null)
				return true;
			return false;
		}

		/// <summary>
		/// A method to find out user data into SQL database.
		/// </summary>
		/// <param name="userId">User ID.</param>
		public Users FindUser(int userId)
		{
			return ctx.Users.Find(userId);
		}

		/// <summary>
		/// A method to find out user by login.
		/// </summary>
		/// <param name="login">User login.</param>
		public Users FindUserByLogin(string login)
		{
			return ctx.Users.Single(u=>u.Login == login);
		}

		/// <summary>
		/// A method to add new user to SQL database.
		/// </summary>
		/// <param name="user">New user data set.</param>
		public void AddUser(Users user)
		{
			ctx.Users.Add(user);
			ctx.SaveChanges();
		}

		/// <summary>
		/// A method to delete user data from SQL database.
		/// </summary>
		/// <param name="userId">User ID.</param>
		public void DeleteUser(int userId)
		{
			ctx.Users.Remove(FindUser(userId));
			ctx.SaveChanges();
		}

		/// <summary>
		/// A method to update user data into SQL database.
		/// </summary>
		/// <param name="user">User new data set.</param>
		public void UpdateUser(Users user)
		{
			var oldValues = FindUser(user.UserId);

			oldValues.Name = user.Name;
			oldValues.Surname = user.Surname;
			oldValues.Phone = user.Phone;
			oldValues.Address = user.Address;
			oldValues.Email = user.Email;
			oldValues.Password = user.Password;

			ctx.SaveChanges();
		}

		/// <summary>
		/// A method to create a list of all users into SQL database.
		/// </summary>
		public List<Users> GetAllUsers()
		{
			return ctx.Users.AsNoTracking().ToList();
		}

		/// <summary>
		/// A method to find out user service history into SQL database.
		/// </summary>
		/// <param name="userId">User ID.</param>
		public List<Repairs> GetHistory(int userId)
		{
			return ctx.Repairs
				.Include(c => c.Customers)
				.Where(u => u.UserId == userId)
				.ToList();
		}

		/// <summary>
		/// A method to check if user field is not empty.
		/// </summary>
		public bool CheckIfNotEmpty()
		{
			return ctx.Users.Count() > 0 ? false : true;
		}
	}
}
