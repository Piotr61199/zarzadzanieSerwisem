using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W61199_Serwis.Models;

namespace W61199_Serwis.Services
{
	class DeviceService
	{
		public DeviceService()
		{
			ctx = new ServiceContext();
		}

		private readonly ServiceContext ctx;


		public int AddNewDevice(Devices device)
		{
			ctx.Devices.Add(device);
			ctx.SaveChanges();

			return device.DeviceId;
		}

		public Devices FindDevice(int deviceId)
		{
			return ctx.Devices.Find(deviceId);
		}

		public List<Devices> GetAllDevices()
		{
			return ctx.Devices.ToList();
		}
	}	
}
