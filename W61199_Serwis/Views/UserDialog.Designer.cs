namespace W61199_Serwis.Views
{
	partial class UserDialog
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
			this.customer_tabControl = new System.Windows.Forms.TabControl();
			this.userData_tab = new System.Windows.Forms.TabPage();
			this.textBox_password = new System.Windows.Forms.TextBox();
			this.textBox_login = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.email_textbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.address_textbox = new System.Windows.Forms.TextBox();
			this.textbox_name = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textbox_surname = new System.Windows.Forms.TextBox();
			this.phone_textbox = new System.Windows.Forms.TextBox();
			this.userHistory_tab = new System.Windows.Forms.TabPage();
			this.grid_History = new System.Windows.Forms.DataGridView();
			this.close_button = new System.Windows.Forms.Button();
			this.add_user_button = new System.Windows.Forms.Button();
			this.delete_button = new System.Windows.Forms.Button();
			this.customer_tabControl.SuspendLayout();
			this.userData_tab.SuspendLayout();
			this.userHistory_tab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_History)).BeginInit();
			this.SuspendLayout();
			// 
			// customer_tabControl
			// 
			this.customer_tabControl.Controls.Add(this.userData_tab);
			this.customer_tabControl.Controls.Add(this.userHistory_tab);
			this.customer_tabControl.Location = new System.Drawing.Point(12, 12);
			this.customer_tabControl.Name = "customer_tabControl";
			this.customer_tabControl.SelectedIndex = 0;
			this.customer_tabControl.Size = new System.Drawing.Size(452, 294);
			this.customer_tabControl.TabIndex = 24;
			// 
			// userData_tab
			// 
			this.userData_tab.Controls.Add(this.textBox_password);
			this.userData_tab.Controls.Add(this.textBox_login);
			this.userData_tab.Controls.Add(this.label7);
			this.userData_tab.Controls.Add(this.label6);
			this.userData_tab.Controls.Add(this.label1);
			this.userData_tab.Controls.Add(this.email_textbox);
			this.userData_tab.Controls.Add(this.label2);
			this.userData_tab.Controls.Add(this.label5);
			this.userData_tab.Controls.Add(this.label3);
			this.userData_tab.Controls.Add(this.address_textbox);
			this.userData_tab.Controls.Add(this.textbox_name);
			this.userData_tab.Controls.Add(this.label4);
			this.userData_tab.Controls.Add(this.textbox_surname);
			this.userData_tab.Controls.Add(this.phone_textbox);
			this.userData_tab.Location = new System.Drawing.Point(4, 22);
			this.userData_tab.Name = "userData_tab";
			this.userData_tab.Padding = new System.Windows.Forms.Padding(3);
			this.userData_tab.Size = new System.Drawing.Size(444, 268);
			this.userData_tab.TabIndex = 0;
			this.userData_tab.Text = "Dane";
			this.userData_tab.UseVisualStyleBackColor = true;
			// 
			// textBox_password
			// 
			this.textBox_password.Location = new System.Drawing.Point(134, 93);
			this.textBox_password.Name = "textBox_password";
			this.textBox_password.PasswordChar = '*';
			this.textBox_password.Size = new System.Drawing.Size(241, 20);
			this.textBox_password.TabIndex = 23;
			// 
			// textBox_login
			// 
			this.textBox_login.Location = new System.Drawing.Point(134, 67);
			this.textBox_login.Name = "textBox_login";
			this.textBox_login.Size = new System.Drawing.Size(241, 20);
			this.textBox_login.TabIndex = 22;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(27, 96);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 13);
			this.label7.TabIndex = 21;
			this.label7.Text = "Hasło";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(27, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "Login";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Imię";
			// 
			// email_textbox
			// 
			this.email_textbox.Location = new System.Drawing.Point(134, 145);
			this.email_textbox.Name = "email_textbox";
			this.email_textbox.Size = new System.Drawing.Size(241, 20);
			this.email_textbox.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Nazwisko";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(27, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "e-mail";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Numer telefonu";
			// 
			// address_textbox
			// 
			this.address_textbox.Location = new System.Drawing.Point(134, 171);
			this.address_textbox.Name = "address_textbox";
			this.address_textbox.Size = new System.Drawing.Size(241, 20);
			this.address_textbox.TabIndex = 17;
			// 
			// textbox_name
			// 
			this.textbox_name.Location = new System.Drawing.Point(134, 15);
			this.textbox_name.Name = "textbox_name";
			this.textbox_name.Size = new System.Drawing.Size(241, 20);
			this.textbox_name.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Adres";
			// 
			// textbox_surname
			// 
			this.textbox_surname.Location = new System.Drawing.Point(134, 41);
			this.textbox_surname.Name = "textbox_surname";
			this.textbox_surname.Size = new System.Drawing.Size(241, 20);
			this.textbox_surname.TabIndex = 14;
			// 
			// phone_textbox
			// 
			this.phone_textbox.Location = new System.Drawing.Point(134, 119);
			this.phone_textbox.Name = "phone_textbox";
			this.phone_textbox.Size = new System.Drawing.Size(241, 20);
			this.phone_textbox.TabIndex = 15;
			// 
			// userHistory_tab
			// 
			this.userHistory_tab.Controls.Add(this.grid_History);
			this.userHistory_tab.Location = new System.Drawing.Point(4, 22);
			this.userHistory_tab.Name = "userHistory_tab";
			this.userHistory_tab.Padding = new System.Windows.Forms.Padding(3);
			this.userHistory_tab.Size = new System.Drawing.Size(444, 268);
			this.userHistory_tab.TabIndex = 1;
			this.userHistory_tab.Text = "Historia napraw";
			this.userHistory_tab.UseVisualStyleBackColor = true;
			// 
			// grid_History
			// 
			this.grid_History.AllowUserToAddRows = false;
			this.grid_History.AllowUserToDeleteRows = false;
			this.grid_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_History.Location = new System.Drawing.Point(7, 7);
			this.grid_History.Name = "grid_History";
			this.grid_History.ReadOnly = true;
			this.grid_History.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_History.Size = new System.Drawing.Size(431, 255);
			this.grid_History.TabIndex = 0;
			this.grid_History.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_history_CellContentDoubleClick);
			// 
			// close_button
			// 
			this.close_button.Location = new System.Drawing.Point(385, 308);
			this.close_button.Name = "close_button";
			this.close_button.Size = new System.Drawing.Size(75, 23);
			this.close_button.TabIndex = 23;
			this.close_button.Text = "Zamknij";
			this.close_button.UseVisualStyleBackColor = true;
			this.close_button.Click += new System.EventHandler(this.close_button_Click);
			// 
			// add_user_button
			// 
			this.add_user_button.Location = new System.Drawing.Point(304, 308);
			this.add_user_button.Name = "add_user_button";
			this.add_user_button.Size = new System.Drawing.Size(75, 23);
			this.add_user_button.TabIndex = 22;
			this.add_user_button.Text = "Zapisz";
			this.add_user_button.UseVisualStyleBackColor = true;
			this.add_user_button.Click += new System.EventHandler(this.add_user_button_Click);
			// 
			// delete_button
			// 
			this.delete_button.Location = new System.Drawing.Point(223, 308);
			this.delete_button.Name = "delete_button";
			this.delete_button.Size = new System.Drawing.Size(75, 23);
			this.delete_button.TabIndex = 25;
			this.delete_button.Text = "Usuń";
			this.delete_button.UseVisualStyleBackColor = true;
			this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
			// 
			// UserDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 340);
			this.Controls.Add(this.customer_tabControl);
			this.Controls.Add(this.close_button);
			this.Controls.Add(this.add_user_button);
			this.Controls.Add(this.delete_button);
			this.Name = "UserDialog";
			this.Text = "UserDialog";
			this.Load += new System.EventHandler(this.UserDialog_Load);
			this.customer_tabControl.ResumeLayout(false);
			this.userData_tab.ResumeLayout(false);
			this.userData_tab.PerformLayout();
			this.userHistory_tab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid_History)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl customer_tabControl;
		private System.Windows.Forms.TabPage userData_tab;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox email_textbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox address_textbox;
		private System.Windows.Forms.TextBox textbox_name;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textbox_surname;
		private System.Windows.Forms.TextBox phone_textbox;
		private System.Windows.Forms.TabPage userHistory_tab;
		private System.Windows.Forms.Button close_button;
		private System.Windows.Forms.Button add_user_button;
		private System.Windows.Forms.Button delete_button;
		private System.Windows.Forms.DataGridView grid_History;
		private System.Windows.Forms.TextBox textBox_password;
		private System.Windows.Forms.TextBox textBox_login;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
	}
}