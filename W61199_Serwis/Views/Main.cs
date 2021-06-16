using System;
using System.Globalization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using W61199_Serwis.Models;
using W61199_Serwis.Services;
using W61199_Serwis.Views;

namespace W61199_Serwis
{
	public partial class Main : Form
	{
		public Main(Users _user)
		{
			InitializeComponent();

			customerService = new CustomerService();
			userService = new UserService();
			repairService = new RepairService();
			user = _user;
		}

		private readonly CustomerService customerService;
		private readonly UserService userService;
		private readonly RepairService repairService;
		public Users user;

		private DataTable repairTable = new DataTable();
		private DataTable customerTable = new DataTable();
		private DataTable userTable = new DataTable();

		private void add_user_button_Click(object sender, EventArgs e)
		{
			CustomerDialog newCustomer = new CustomerDialog();
			newCustomer.ShowDialog();

			LoadCustomerGrid();
		}	

		private void Main_Load(object sender, EventArgs e)
		{
			initTables();

			LoadCustomerGrid();
			LoadUserGrid();
			LoadRepairsGrid();

			label_loggedUser.Text = string.IsNullOrWhiteSpace(user.FullName) ? user.Login : user.FullName;

			string name = user.Login.ToString();
			if (name.ToUpper(new CultureInfo("en-US", false)) == "ADMIN")
			{
				addUser_button.Visible = true;
			}
			else
            {
				addUser_button.Visible = false;
			};

			comboBox_statusForRepair.DataSource = new BindingSource(GetStatusList(), null);
		}

		private void add_repair_button_Click(object sender, EventArgs e)
		{
			RepairDialog repair = new RepairDialog();
			repair.ShowDialog();

			LoadRepairsGrid();
		}

		private void Main_Shown(object sender, EventArgs e)
		{
			
		}		

		private void customer_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var selectedClientId = Convert.ToInt32(grid_customer.SelectedRows[0].Cells[0].Value);
			CustomerDialog newCustomer = new CustomerDialog(selectedClientId);
			newCustomer.ShowDialog();
			LoadCustomerGrid();
		}

		private void addUser_button_Click(object sender, EventArgs e)
		{
			UserDialog userDialog = new UserDialog();
			userDialog.ShowDialog();

			LoadUserGrid();
		}

		private void user_dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string name = user.Login.ToString();
			if (name.ToUpper(new CultureInfo("en-US", false)) == "ADMIN")
			{
				var selectedUserId = Convert.ToInt32(grid_user.SelectedRows[0].Cells[0].Value);
				UserDialog editUser = new UserDialog(selectedUserId);
				editUser.ShowDialog();

				LoadUserGrid();
			}
		}

		private void LoadUserGrid()
		{
			var users = FilterUsersList(userService.GetAllUsers());
			userTable.Clear();

			foreach (var user in users)
			{
				userTable.Rows.Add(user.UserId, user.Name, user.Surname,user.Login, user.Phone, user.Email, user.Address);
			}

			grid_user.DataSource = null;
			grid_user.DataSource = userTable;
			grid_user.Columns[0].Visible = false;
		}

		private void LoadCustomerGrid()
		{			
			var customers = FilterCustomerList(customerService.GetAllCustomers());
			customerTable.Clear();

			foreach (var customer in customers)
			{
				customerTable.Rows.Add(customer.CustomerId, customer.Name, customer.Surname, customer.Phone, customer.Email, customer.Address);
			}

			grid_customer.DataSource = null;
			grid_customer.DataSource = customerTable;
			grid_customer.Columns[0].Visible = false;
		}

		private void LoadRepairsGrid()
		{
			var repairs = FilterRepairList(repairService.GetAllRepairs());
			repairTable.Clear();
			
			foreach (var repair in repairs)
			{
				repairTable.Rows.Add(repair.RepairId,
					repair.Customers.FullName,
					repair.Users.FullName,
					EnumList.GetEnumDescription((RepairStatus)repair.Status),
					repair.Devices.Producer,
					repair.Devices.Model,
					repair.StartDate.ToShortDateString(), 
					repair.EndDate.ToShortDateString(), 
					repair.Costs);
			}

			grid_repairs.DataSource = null;
			grid_repairs.DataSource = repairTable;
			grid_repairs.Columns[0].Visible = false;
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void initTables()
		{
			repairTable.Columns.Add("repairId");
			repairTable.Columns.Add("Klient");
			repairTable.Columns.Add("Serwisant");
			repairTable.Columns.Add("Status");
			repairTable.Columns.Add("Producent");
			repairTable.Columns.Add("Model");
			repairTable.Columns.Add("Rozpoczęcie");
			repairTable.Columns.Add("Zakończenie");
			repairTable.Columns.Add("Cena");			

			customerTable.Columns.Add("customerId");
			customerTable.Columns.Add("Imię");
			customerTable.Columns.Add("Nazwisko");
			customerTable.Columns.Add("Telefon");
			customerTable.Columns.Add("Email");
			customerTable.Columns.Add("Adres");

			userTable.Columns.Add("userId");
			userTable.Columns.Add("Imię");
			userTable.Columns.Add("Nazwisko");
			userTable.Columns.Add("Login");
			userTable.Columns.Add("Telefon");
			userTable.Columns.Add("Email");
			userTable.Columns.Add("Adres");

		}

		private void grid_repairs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var selectedRepairId = Convert.ToInt32(grid_repairs.SelectedRows[0].Cells[0].Value);
			RepairDialog repair = new RepairDialog(selectedRepairId);
			repair.ShowDialog();

			LoadRepairsGrid();
		}

		
		private List<Repairs> FilterRepairList(List<Repairs> repairs)
		{
			var query = repairs.AsQueryable();

			if (!string.IsNullOrEmpty(textBox_searchCustomerForRepair.Text))
				query = query.Where(d => d.Customers.FullName.Contains(textBox_searchCustomerForRepair.Text));

			if (!string.IsNullOrEmpty(textBox_searchUserForRepair.Text))
				query = query.Where(d => d.Users.FullName.Contains(textBox_searchUserForRepair.Text));

			if (((short?)comboBox_statusForRepair.SelectedValue ?? -1) != -1 )

				query = query.Where(d => d.Status == (short)comboBox_statusForRepair.SelectedValue);

			return query.ToList();
		}

		private List<Customers> FilterCustomerList(List<Customers> customers)
		{
			var query = customers.AsQueryable();

			if (!string.IsNullOrEmpty(textBox_searchCustomerForCustomer.Text))
				query = query.Where(d => d.FullName.Contains(textBox_searchCustomerForCustomer.Text));

			if (!string.IsNullOrEmpty(textBox_searchPhoneForCustomer.Text))
				query = query.Where(d => d.Phone.Contains(textBox_searchPhoneForCustomer.Text));

			if (!string.IsNullOrEmpty(textBox_searchMailForCustomer.Text))
				query = query.Where(d => d.Email.Contains(textBox_searchMailForCustomer.Text));

			return query.ToList();
		}

		private List<Users> FilterUsersList(List<Users> customers)
		{
			var query = customers.AsQueryable();

			if (!string.IsNullOrEmpty(textBox_searchUserForUser.Text))
				query = query.Where(d => d.FullName.Contains(textBox_searchUserForUser.Text));

			if (!string.IsNullOrEmpty(textBox_searchPhoneForUser.Text))
				query = query.Where(d => d.Phone.Contains(textBox_searchPhoneForUser.Text));

			if (!string.IsNullOrEmpty(textBox_searchMailForUser.Text))
				query = query.Where(d => d.Email.Contains(textBox_searchMailForUser.Text));

			return query.ToList();
		}


		private void button_searchRepair_Click(object sender, EventArgs e)
		{
			LoadRepairsGrid();
		}

		private Dictionary<short?, string> GetStatusList()
		{

			var dict = new Dictionary<short?, string>();
			dict.Add(-1, null);

			foreach (RepairStatus foo in Enum.GetValues(typeof(RepairStatus)))
			{
				dict.Add((short)foo, EnumList.GetEnumDescription(foo));
			}

			return dict;
		}

		private void button_searchCustomer_Click(object sender, EventArgs e)
		{
			LoadCustomerGrid();
		}

		private void button_searchUser_Click(object sender, EventArgs e)
		{
			LoadUserGrid();
		}
	}
}
