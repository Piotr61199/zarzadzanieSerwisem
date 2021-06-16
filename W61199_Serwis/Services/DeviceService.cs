using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W61199_Serwis.Models;

namespace W61199_Serwis.Services
{
	/// <summary>
	/// Device data handling class.
	/// This class is designed to handle insertion, update and deletion of Device data.
	/// </summary>
	class DeviceService
	{
		/// <summary>
		/// Load of private content from SQL database.
		/// </summary>
		public DeviceService()
		{
			ctx = new ServiceContext();
		}

		private readonly ServiceContext ctx;

		/// <summary>
		/// A method to add new device to SQL database.
		/// </summary>
		/// <param name="device">New device data set.</param>
		public int AddNewDevice(Devices device)
		{
			ctx.Devices.Add(device);
			ctx.SaveChanges();

			return device.DeviceId;
		}

		/// <summary>
		/// A method to find out device data into SQL database.
		/// </summary>
		/// <param name="deviceId">Device ID.</param>
		public Devices FindDevice(int deviceId)
		{
			return ctx.Devices.Find(deviceId);
		}

		/// <summary>
		/// A method to create a list of all devices into SQL database.
		/// </summary>
		public List<Devices> GetAllDevices()
		{
			return ctx.Devices.ToList();
		}
	}	
}
