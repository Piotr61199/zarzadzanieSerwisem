using System.Collections.Generic;
using System.Linq;
using W61199_Serwis.Models;
using System.Data.Entity;

namespace W61199_Serwis.Services
{
	class UserService
	{
		public UserService()
		{
			ctx = new ServiceContext();
		}

		private readonly ServiceContext ctx;

		public bool Login(string login, string password)
		{
			var user = ctx.Users.FirstOrDefault(x => x.Login == login && x.Password == password);

			if(user != null)
				return true;
			return false;
		}

		public Users FindUser(int userId)
		{
			return ctx.Users.Find(userId);
		}

		public Users FindUserByLogin(string login)
		{
			return ctx.Users.Single(u=>u.Login == login);
		}

		public void AddUser(Users user)
		{
			ctx.Users.Add(user);
			ctx.SaveChanges();
		}

		public void DeleteUser(int userId)
		{
			ctx.Users.Remove(FindUser(userId));
			ctx.SaveChanges();
		}

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

		public List<Users> GetAllUsers()
		{
			return ctx.Users.AsNoTracking().ToList();
		}

		public List<Repairs> GetHistory(int userId)
		{
			return ctx.Repairs
				.Include(c => c.Customers)
				.Where(u => u.UserId == userId)
				.ToList();
		}		
		
		public bool CheckIfNotEmpty()
		{
			return ctx.Users.Count() > 0 ? false : true;
		}
	}
}
