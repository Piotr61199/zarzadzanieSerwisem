using System;
using System.Windows.Forms;
using W61199_Serwis.Views;

namespace W61199_Serwis
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoginDialog());
		}
	}
}
