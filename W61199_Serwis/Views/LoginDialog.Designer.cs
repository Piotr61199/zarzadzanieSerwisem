namespace W61199_Serwis.Views
{
	partial class LoginDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.login_button = new System.Windows.Forms.Button();
			this.quit_button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.login_textbox = new System.Windows.Forms.TextBox();
			this.password_textbox = new System.Windows.Forms.TextBox();
			this.error_label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// login_button
			// 
			this.login_button.Location = new System.Drawing.Point(275, 135);
			this.login_button.Name = "login_button";
			this.login_button.Size = new System.Drawing.Size(75, 23);
			this.login_button.TabIndex = 0;
			this.login_button.Text = "Zaloguj";
			this.login_button.UseVisualStyleBackColor = true;
			this.login_button.Click += new System.EventHandler(this.login_button_Click);
			// 
			// quit_button
			// 
			this.quit_button.Location = new System.Drawing.Point(375, 135);
			this.quit_button.Name = "quit_button";
			this.quit_button.Size = new System.Drawing.Size(75, 23);
			this.quit_button.TabIndex = 1;
			this.quit_button.Text = "Zamknij";
			this.quit_button.UseVisualStyleBackColor = true;
			this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(83, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(83, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Hasło";
			// 
			// login_textbox
			// 
			this.login_textbox.Location = new System.Drawing.Point(158, 46);
			this.login_textbox.Name = "login_textbox";
			this.login_textbox.Size = new System.Drawing.Size(292, 20);
			this.login_textbox.TabIndex = 4;
			// 
			// password_textbox
			// 
			this.password_textbox.Location = new System.Drawing.Point(158, 91);
			this.password_textbox.Name = "password_textbox";
			this.password_textbox.PasswordChar = '*';
			this.password_textbox.Size = new System.Drawing.Size(292, 20);
			this.password_textbox.TabIndex = 5;
			// 
			// error_label
			// 
			this.error_label.AutoSize = true;
			this.error_label.ForeColor = System.Drawing.Color.Red;
			this.error_label.Location = new System.Drawing.Point(86, 135);
			this.error_label.Name = "error_label";
			this.error_label.Size = new System.Drawing.Size(123, 13);
			this.error_label.TabIndex = 6;
			this.error_label.Text = "Błędne dane logowania!";
			this.error_label.Visible = false;
			// 
			// LoginDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 188);
			this.ControlBox = false;
			this.Controls.Add(this.error_label);
			this.Controls.Add(this.password_textbox);
			this.Controls.Add(this.login_textbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.quit_button);
			this.Controls.Add(this.login_button);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginDialog";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.LoginDialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button login_button;
		private System.Windows.Forms.Button quit_button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox login_textbox;
		private System.Windows.Forms.TextBox password_textbox;
		private System.Windows.Forms.Label error_label;
	}
}