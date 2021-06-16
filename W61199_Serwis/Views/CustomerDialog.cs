using System;
using System.Data;
using System.Windows.Forms;
using W61199_Serwis.Models;
using W61199_Serwis.Services;

namespace W61199_Serwis.Views
{
	public partial class CustomerDialog : Form
	{
		public CustomerDialog(int? _customerId = null)
		{
			InitializeComponent();
			customerId = _customerId;
			customerService = new CustomerService();
		}		

		private readonly CustomerService customerService;
		private int? customerId = null;
		private DataTable repairTable = new DataTable();

		private void add_user_button_Click(object sender, EventArgs e)
		{
			Customers customer = new Customers
			{
				Name = name_textbox.Text,
				Surname = surname_textbox.Text,
				Phone = phone_textbox.Text,
				Email = email_textbox.Text,
				Address = address_textbox.Text
			};
			
			if(customerId != null)
			{
				customer.CustomerId = (int)customerId;
				customerService.UpdateCustomer(customer);
			}
			else
				customerService.AddNewCustomer(customer);

			this.Close();
		}

		private void close_button_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CustomerDialog_Load(object sender, EventArgs e)
		{
			if (customerId != null)
			{
				var customer = customerService.FindCustomer((int)customerId);

				name_textbox.Text = customer.Name;
				surname_textbox.Text = customer.Surname;
				phone_textbox.Text = customer.Phone;
				email_textbox.Text = customer.Email;
				address_textbox.Text = customer.Address;

				initTable();
				LoadTable();
			}
			else
			{
				customer_tabControl.TabPages.Remove(customerHistory_tab);
				delete_button.Visible = false;
			}
				
		}

		private void customer_delete_Click(object sender, EventArgs e)
		{
			var confirmResult = MessageBox.Show("Czy napewno chcesz usunąć tego klienta?",
									 "usuwanie klienta",
									 MessageBoxButtons.YesNo);
			if (confirmResult == DialogResult.Yes)
			{
				customerService.DeleteCustomer((int)customerId);
				this.Close();
			}			
		}

		private void grid_History_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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
			var repairs = customerService.GetHistory((int)customerId);
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
