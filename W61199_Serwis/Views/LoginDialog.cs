using System;
using System.Windows.Forms;
using W61199_Serwis.Services;

namespace W61199_Serwis.Views
{
	public partial class LoginDialog : Form
	{
		public LoginDialog()
		{
			InitializeComponent();
			userService = new UserService();
		}

		private readonly UserService userService;

		private void quit_button_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void login_button_Click(object sender, EventArgs e)
		{
			var isUserLogin = userService.Login(login_textbox.Text, password_textbox.Text);

			if (isUserLogin)
			{
				var user = userService.FindUserByLogin(login_textbox.Text);
				Main main = new Main(user);
				main.Show();
				this.Visible = false;
			}
			else
				error_label.Visible = true;
		}

		private void LoginDialog_Load(object sender, EventArgs e)
		{
			if (userService.CheckIfNotEmpty())
			{
				userService.AddUser(new Models.Users
				{
					Login = "admin",
					Password = "admin"
				});

				login_textbox.Text = "admin";
				password_textbox.Text = "admin";
			}
		}
	}
}
