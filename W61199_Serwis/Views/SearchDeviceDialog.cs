using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W61199_Serwis.Models;
using W61199_Serwis.Services;

namespace W61199_Serwis.Views
{
	public partial class SearchDeviceDialog : Form
	{
		public SearchDeviceDialog()
		{
			InitializeComponent();
			deviceService = new DeviceService();
		}

		private readonly DeviceService deviceService;
		private DataTable deviceTabel = new DataTable();
		public int? deviceId = null;
		
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			LoadTable();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			LoadTable();
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			LoadTable();
		}

		private void SearchDeviceDialog_Load(object sender, EventArgs e)
		{
			initTable();
			LoadTable();
		}

		private void initTable()
		{
			deviceTabel.Columns.Add("deviceId");
			deviceTabel.Columns.Add("Producent");
			deviceTabel.Columns.Add("Model");
			deviceTabel.Columns.Add("Numer seryjny");
		}

		private void LoadTable()
		{
			var devices = FilterDevicessList(deviceService.GetAllDevices());
			deviceTabel.Clear();

			foreach (var device in devices)
			{
				deviceTabel.Rows.Add(
					device.DeviceId,
					device.Producer,
					device.Model,
					device.SerialNumber);
			}

			grid_devices.DataSource = null;
			grid_devices.DataSource = deviceTabel;
			grid_devices.Columns[0].Visible = false;
		}

		private List<Devices> FilterDevicessList(List<Devices> devices)
		{
			var query = devices.AsQueryable();

			if (!string.IsNullOrEmpty(textBox_producer.Text))
				query = query.Where(d => d.Producer.Contains(textBox_producer.Text));

			if (!string.IsNullOrEmpty(textBox_model.Text))
				query = query.Where(d => d.Model.Contains(textBox_model.Text));

			if (!string.IsNullOrEmpty(textBox_SN.Text))
				query = query.Where(d => d.SerialNumber.Contains(textBox_SN.Text));

			return query.ToList();
		}

		private void grid_devices_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			deviceId = Convert.ToInt32(grid_devices.SelectedRows[0].Cells[0].Value);
			this.Close();
		}
	}
}
