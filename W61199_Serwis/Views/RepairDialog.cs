using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using W61199_Serwis.Models;
using W61199_Serwis.Services;

namespace W61199_Serwis.Views
{
	public partial class RepairDialog : Form
	{
		public RepairDialog(int? _repairId = null)
		{
			InitializeComponent();

			customerService = new CustomerService();
			userService = new UserService();
			repairService = new RepairService();
			deviceService = new DeviceService();

			repairId = _repairId;
		}

		private readonly CustomerService customerService;
		private readonly UserService userService;
		private readonly RepairService repairService;
		private readonly DeviceService deviceService;

		private int? repairId;
		private int? deviceId;

		private void RepairDialog_Load(object sender, EventArgs e)
		{
			customer_combobox.DataSource = customerService.GetAllCustomers();
			user_comboBox.DataSource = userService.GetAllUsers();

			comboBox_status.DisplayMember = "Value";
			comboBox_status.ValueMember = "Key";

			comboBox_status.DataSource = new BindingSource(GetStatusList(), null);

			if (repairId != null)
			{
				search_for_device_button.Visible = false;
				button_add_device.Visible = false;
				var repair = repairService.FindRepair((int)repairId);
				user_comboBox.SelectedValue = repair.UserId;
				customer_combobox.SelectedValue = repair.CustomerId;
				user_comboBox.SelectedValue = repair.UserId;
				note_textBox.Text = repair.Note;
				label_device_producer.Text = repair.Devices.Producer;
				label_device_model.Text = repair.Devices.Model;
				label_device_SN.Text = repair.Devices.SerialNumber;
				comboBox_status.SelectedValue = repair.Status;
				textBox_price.Text = repair.Costs.ToString();

				deviceId = repair.DeviceId;

				customer_combobox.Enabled = false;
			}
		}

		private void customer_combobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			int customerId = (int)customer_combobox.SelectedValue;
			var customer = customerService.FindCustomer(customerId);

			customer_name_label.Text = customer.Name;
			customer_surname_label.Text = customer.Surname;
			customer_phone_label.Text = customer.Phone;
			customer_email_label.Text = customer.Email;
		}

		private void save_button_Click(object sender, EventArgs e)
		{
			var x = (short)comboBox_status.SelectedValue;
			Repairs repair = new Repairs
			{
				CustomerId = (int)customer_combobox.SelectedValue,
				UserId = (int)user_comboBox.SelectedValue,
				Note = note_textBox.Text,
				StartDate = startDate_dateTimePicker.Value,
				EndDate = endDate_dateTimePicker.Value,
				Costs = string.IsNullOrEmpty(textBox_price.Text) ? (decimal) 0.00 : Convert.ToDecimal(textBox_price.Text),
				DeviceId = deviceId ?? 0,
				Status = (short)comboBox_status.SelectedValue
			};

			if (repairId != null)
			{
				repair.RepairId = (int)repairId;
				repair.DeviceId = (int)deviceId;
				repairService.UpdateRepair(repair);
			}
			else
			{
				repairService.AddNewRepair(repair);
			}

			this.Close();
		}

		private void search_for_device_button_Click(object sender, EventArgs e)
		{
			SearchDeviceDialog deviceDialog = new SearchDeviceDialog();
			deviceDialog.ShowDialog();

			if (deviceDialog.deviceId != null)
			{
				var device = deviceService.FindDevice((int)deviceDialog.deviceId);
				deviceId = device.DeviceId;
				label_device_producer.Text = device.Producer;
				label_device_model.Text = device.Model;
				label_device_SN.Text = device.SerialNumber;

				button_add_device.Visible = false;
			}
		}

		private void close_button_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button_add_device_Click(object sender, EventArgs e)
		{
			DeviceDialog deviceDialog = new DeviceDialog();
			deviceDialog.ShowDialog();
			if (deviceDialog.newDeviceId != null)
			{
				var device = deviceService.FindDevice((int)deviceDialog.newDeviceId);
				deviceId = device.DeviceId;
				label_device_producer.Text = device.Producer;
				label_device_model.Text = device.Model;
				label_device_SN.Text = device.SerialNumber;

				button_add_device.Visible = false;
			}
		}

		private Dictionary<short, string> GetStatusList() {

			var dict = new Dictionary<short, string>();

			foreach (RepairStatus foo in Enum.GetValues(typeof(RepairStatus)))
			{
				dict.Add((short)foo, EnumList.GetEnumDescription(foo));
			}

			return dict;
		}

		private void textBox_price_Leave(object sender, EventArgs e)
		{
			textBox_price.Text = String.Format("{0:N2}", double.Parse(textBox_price.Text));
		}
	}
}
