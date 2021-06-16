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
	public partial class DeviceDialog : Form
	{
		public DeviceDialog()
		{
			InitializeComponent();
			deviceService = new DeviceService();

		}

		private readonly DeviceService deviceService;
		public int? newDeviceId = null;

		private void close_button_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void add_button_Click(object sender, EventArgs e)
		{
			Devices device = new Devices
			{
				Model = model_textBox.Text,
				Producer = producer_textBox.Text,
				SerialNumber = SN_textBox.Text
			};

			newDeviceId = deviceService.AddNewDevice(device);

			this.Close();
		}
	}
}
