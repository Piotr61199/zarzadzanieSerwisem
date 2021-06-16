using System;
using System.Data;
using System.Windows.Forms;
using W61199_Serwis.Models;
using W61199_Serwis.Services;

namespace W61199_Serwis.Views
{
	public partial class UserDialog : Form
	{
		public UserDialog(int? _userId = null)
		{
			InitializeComponent();

			userService = new UserService();
			userId = _userId;
		}

		private readonly UserService userService;
		private int? userId = null;
		private DataTable repairTable = new DataTable();

		private void close_button_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void add_user_button_Click(object sender, EventArgs e)
		{
			Users user = new Users
			{
				Name = textbox_name.Text,
				Surname = textbox_surname.Text,
				Login = textBox_login.Text,
				Password = textBox_password.Text,
				Phone = phone_textbox.Text,
				Email = email_textbox.Text,
				Address = address_textbox.Text
			};

			if (userId != null)
			{
				user.UserId = (int)userId;
				userService.UpdateUser(user);				
			}
			else
				userService.AddUser(user);
			this.Close();
		}

		private void delete_button_Click(object sender, EventArgs e)
		{
			var confirmResult = MessageBox.Show("Czy napewno chcesz usunąć tego pracownika?",
									 "Usuwanie pracownika",
									 MessageBoxButtons.YesNo);
			if (confirmResult == DialogResult.Yes)
			{
				userService.DeleteUser((int)userId);
				this.Close();
			}
		}

		private void UserDialog_Load(object sender, EventArgs e)
		{
			if (userId != null)
			{
				var customer = userService.FindUser((int)userId);

				textbox_name.Text = customer.Name;
				textbox_surname.Text = customer.Surname;
				phone_textbox.Text = customer.Phone;
				email_textbox.Text = customer.Email;
				address_textbox.Text = customer.Address;
				textBox_login.Text = customer.Login;
				textBox_password.Text = customer.Password;

				textBox_login.Enabled = false;

				initTable();
				LoadTable();
			}
			else
			{
				customer_tabControl.TabPages.Remove(userHistory_tab);
				delete_button.Visible = false;
			}
		}

		private void grid_history_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var selectedRepairId = Convert.ToInt32(grid_History.SelectedRows[0].Cells[0].Value);
			RepairDialog repair = new RepairDialog(selectedRepairId);
			repair.ShowDialog();
		}

		private void initTable()
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
		}

		private void LoadTable()
		{
			var repairs = userService.GetHistory((int)userId);
			repairTable.Clear();

			foreach (var repair in repairs)
			{
				repairTable.Rows.Add(
					repair.RepairId,
					repair.Customers.FullName,
					repair.Users.FullName,
					EnumList.GetEnumDescription((RepairStatus)repair.Status),
					repair.Devices.Producer,
					repair.Devices.Model,
					repair.StartDate.ToShortDateString(),
					repair.EndDate.ToShortDateString(),
					repair.Costs);
			}

			grid_History.DataSource = null;
			grid_History.DataSource = repairTable;
			grid_History.Columns[0].Visible = false;

		}
	}
}
