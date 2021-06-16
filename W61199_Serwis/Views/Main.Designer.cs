namespace W61199_Serwis
{
	partial class Main
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label_loggedUser = new System.Windows.Forms.Label();
			this.addUser_button = new System.Windows.Forms.Button();
			this.add_repair_button = new System.Windows.Forms.Button();
			this.add_user_button = new System.Windows.Forms.Button();
			this.users_Tab = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.comboBox_statusForRepair = new System.Windows.Forms.ComboBox();
			this.button_searchRepair = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_searchUserForRepair = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_searchCustomerForRepair = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.grid_repairs = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button_searchCustomer = new System.Windows.Forms.Button();
			this.textBox_searchMailForCustomer = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox_searchPhoneForCustomer = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_searchCustomerForCustomer = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.grid_customer = new System.Windows.Forms.DataGridView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button_searchUser = new System.Windows.Forms.Button();
			this.textBox_searchMailForUser = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox_searchPhoneForUser = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox_searchUserForUser = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.grid_user = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.users_Tab.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_repairs)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_customer)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_user)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label_loggedUser);
			this.groupBox1.Controls.Add(this.addUser_button);
			this.groupBox1.Controls.Add(this.add_repair_button);
			this.groupBox1.Controls.Add(this.add_user_button);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(958, 74);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// label_loggedUser
			// 
			this.label_loggedUser.AutoSize = true;
			this.label_loggedUser.Location = new System.Drawing.Point(835, 16);
			this.label_loggedUser.Name = "label_loggedUser";
			this.label_loggedUser.Size = new System.Drawing.Size(10, 13);
			this.label_loggedUser.TabIndex = 3;
			this.label_loggedUser.Text = "-";
			// 
			// addUser_button
			// 
			this.addUser_button.Location = new System.Drawing.Point(151, 19);
			this.addUser_button.Name = "addUser_button";
			this.addUser_button.Size = new System.Drawing.Size(71, 48);
			this.addUser_button.TabIndex = 2;
			this.addUser_button.Text = "Pracownik";
			this.addUser_button.UseVisualStyleBackColor = true;
			this.addUser_button.Click += new System.EventHandler(this.addUser_button_Click);
			// 
			// add_repair_button
			// 
			this.add_repair_button.Location = new System.Drawing.Point(78, 19);
			this.add_repair_button.Name = "add_repair_button";
			this.add_repair_button.Size = new System.Drawing.Size(67, 48);
			this.add_repair_button.TabIndex = 1;
			this.add_repair_button.Text = "Naprawa";
			this.add_repair_button.UseVisualStyleBackColor = true;
			this.add_repair_button.Click += new System.EventHandler(this.add_repair_button_Click);
			// 
			// add_user_button
			// 
			this.add_user_button.Location = new System.Drawing.Point(19, 20);
			this.add_user_button.Name = "add_user_button";
			this.add_user_button.Size = new System.Drawing.Size(53, 48);
			this.add_user_button.TabIndex = 0;
			this.add_user_button.Text = "Klient";
			this.add_user_button.UseVisualStyleBackColor = true;
			this.add_user_button.Click += new System.EventHandler(this.add_user_button_Click);
			// 
			// users_Tab
			// 
			this.users_Tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.users_Tab.Controls.Add(this.tabPage1);
			this.users_Tab.Controls.Add(this.tabPage2);
			this.users_Tab.Controls.Add(this.tabPage3);
			this.users_Tab.Location = new System.Drawing.Point(13, 94);
			this.users_Tab.Name = "users_Tab";
			this.users_Tab.SelectedIndex = 0;
			this.users_Tab.Size = new System.Drawing.Size(958, 449);
			this.users_Tab.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.comboBox_statusForRepair);
			this.tabPage1.Controls.Add(this.button_searchRepair);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.textBox_searchUserForRepair);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.textBox_searchCustomerForRepair);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.grid_repairs);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(950, 423);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Naprawy";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// comboBox_statusForRepair
			// 
			this.comboBox_statusForRepair.DisplayMember = "Value";
			this.comboBox_statusForRepair.FormattingEnabled = true;
			this.comboBox_statusForRepair.Location = new System.Drawing.Point(269, 19);
			this.comboBox_statusForRepair.Name = "comboBox_statusForRepair";
			this.comboBox_statusForRepair.Size = new System.Drawing.Size(103, 21);
			this.comboBox_statusForRepair.TabIndex = 10;
			this.comboBox_statusForRepair.ValueMember = "Key";
			// 
			// button_searchRepair
			// 
			this.button_searchRepair.Location = new System.Drawing.Point(869, 17);
			this.button_searchRepair.Name = "button_searchRepair";
			this.button_searchRepair.Size = new System.Drawing.Size(75, 23);
			this.button_searchRepair.TabIndex = 7;
			this.button_searchRepair.Text = "Szukaj";
			this.button_searchRepair.UseVisualStyleBackColor = true;
			this.button_searchRepair.Click += new System.EventHandler(this.button_searchRepair_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(269, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Status";
			// 
			// textBox_searchUserForRepair
			// 
			this.textBox_searchUserForRepair.Location = new System.Drawing.Point(138, 20);
			this.textBox_searchUserForRepair.Name = "textBox_searchUserForRepair";
			this.textBox_searchUserForRepair.Size = new System.Drawing.Size(125, 20);
			this.textBox_searchUserForRepair.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(135, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Serwisant";
			// 
			// textBox_searchCustomerForRepair
			// 
			this.textBox_searchCustomerForRepair.Location = new System.Drawing.Point(7, 20);
			this.textBox_searchCustomerForRepair.Name = "textBox_searchCustomerForRepair";
			this.textBox_searchCustomerForRepair.Size = new System.Drawing.Size(125, 20);
			this.textBox_searchCustomerForRepair.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Klient";
			// 
			// grid_repairs
			// 
			this.grid_repairs.AllowUserToAddRows = false;
			this.grid_repairs.AllowUserToDeleteRows = false;
			this.grid_repairs.AllowUserToOrderColumns = true;
			this.grid_repairs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grid_repairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_repairs.Location = new System.Drawing.Point(6, 49);
			this.grid_repairs.Name = "grid_repairs";
			this.grid_repairs.ReadOnly = true;
			this.grid_repairs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_repairs.Size = new System.Drawing.Size(938, 371);
			this.grid_repairs.TabIndex = 0;
			this.grid_repairs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_repairs_CellDoubleClick);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button_searchCustomer);
			this.tabPage2.Controls.Add(this.textBox_searchMailForCustomer);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.textBox_searchPhoneForCustomer);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.textBox_searchCustomerForCustomer);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.grid_customer);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(950, 423);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Klienci";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button_searchCustomer
			// 
			this.button_searchCustomer.Location = new System.Drawing.Point(869, 22);
			this.button_searchCustomer.Name = "button_searchCustomer";
			this.button_searchCustomer.Size = new System.Drawing.Size(75, 23);
			this.button_searchCustomer.TabIndex = 11;
			this.button_searchCustomer.Text = "Szukaj";
			this.button_searchCustomer.UseVisualStyleBackColor = true;
			this.button_searchCustomer.Click += new System.EventHandler(this.button_searchCustomer_Click);
			// 
			// textBox_searchMailForCustomer
			// 
			this.textBox_searchMailForCustomer.Location = new System.Drawing.Point(268, 25);
			this.textBox_searchMailForCustomer.Name = "textBox_searchMailForCustomer";
			this.textBox_searchMailForCustomer.Size = new System.Drawing.Size(125, 20);
			this.textBox_searchMailForCustomer.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(265, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "E-Mail";
			// 
			// textBox_searchPhoneForCustomer
			// 
			this.textBox_searchPhoneForCustomer.Location = new System.Drawing.Point(137, 25);
			this.textBox_searchPhoneForCustomer.Name = "textBox_searchPhoneForCustomer";
			this.textBox_searchPhoneForCustomer.Size = new System.Drawing.Size(125, 20);
			this.textBox_searchPhoneForCustomer.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(134, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Telefon";
			// 
			// textBox_searchCustomerForCustomer
			// 
			this.textBox_searchCustomerForCustomer.Location = new System.Drawing.Point(6, 25);
			this.textBox_searchCustomerForCustomer.Name = "textBox_searchCustomerForCustomer";
			this.textBox_searchCustomerForCustomer.Size = new System.Drawing.Size(125, 20);
			this.textBox_searchCustomerForCustomer.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Klient";
			// 
			// grid_customer
			// 
			this.grid_customer.AllowUserToAddRows = false;
			this.grid_customer.AllowUserToDeleteRows = false;
			this.grid_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grid_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_customer.Location = new System.Drawing.Point(6, 51);
			this.grid_customer.Name = "grid_customer";
			this.grid_customer.ReadOnly = true;
			this.grid_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_customer.Size = new System.Drawing.Size(938, 366);
			this.grid_customer.TabIndex = 0;
			this.grid_customer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_grid_CellDoubleClick);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.button_searchUser);
			this.tabPage3.Controls.Add(this.textBox_searchMailForUser);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.textBox_searchPhoneForUser);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Controls.Add(this.textBox_searchUserForUser);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.grid_user);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(950, 423);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Pracownicy";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// button_searchUser
			// 
			this.button_searchUser.Location = new System.Drawing.Point(868, 27);
			this.button_searchUser.Name = "button_searchUser";
			this.button_searchUser.Size = new System.Drawing.Size(75, 23);
			this.button_searchUser.TabIndex = 18;
			this.button_searchUser.Text = "Szukaj";
			this.button_searchUser.UseVisualStyleBackColor = true;
			this.button_searchUser.Click += new System.EventHandler(this.button_searchUser_Click);
			// 
			// textBox_searchMailForUser
			// 
			this.textBox_searchMailForUser.Location = new System.Drawing.Point(267, 30);
			this.textBox_searchMailForUser.Name = "textBox_searchMailForUser";
			this.textBox_searchMailForUser.Size = new System.Drawing.Size(125, 20);
			this.textBox_searchMailForUser.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(264, 14);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "E-Mail";
			// 
			// textBox_searchPhoneForUser
			// 
			this.textBox_searchPhoneForUser.Location = new System.Drawing.Point(136, 30);
			this.textBox_searchPhoneForUser.Name = "textBox_searchPhoneForUser";
			this.textBox_searchPhoneForUser.Size = new System.Drawing.Size(125, 20);
			this.textBox_searchPhoneForUser.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(133, 14);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Telefon";
			// 
			// textBox_searchUserForUser
			// 
			this.textBox_searchUserForUser.Location = new System.Drawing.Point(5, 30);
			this.textBox_searchUserForUser.Name = "textBox_searchUserForUser";
			this.textBox_searchUserForUser.Size = new System.Drawing.Size(125, 20);
			this.textBox_searchUserForUser.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(4, 14);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(33, 13);
			this.label9.TabIndex = 12;
			this.label9.Text = "Klient";
			// 
			// grid_user
			// 
			this.grid_user.AllowUserToAddRows = false;
			this.grid_user.AllowUserToDeleteRows = false;
			this.grid_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grid_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_user.Location = new System.Drawing.Point(6, 56);
			this.grid_user.Name = "grid_user";
			this.grid_user.ReadOnly = true;
			this.grid_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_user.Size = new System.Drawing.Size(938, 361);
			this.grid_user.TabIndex = 0;
			this.grid_user.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_dataGrid_CellDoubleClick);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(983, 555);
			this.Controls.Add(this.users_Tab);
			this.Controls.Add(this.groupBox1);
			this.Name = "Main";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.users_Tab.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_repairs)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_customer)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_user)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button add_user_button;
		private System.Windows.Forms.TabControl users_Tab;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView grid_customer;
		private System.Windows.Forms.Button add_repair_button;
		private System.Windows.Forms.Button addUser_button;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.DataGridView grid_user;
		private System.Windows.Forms.DataGridView grid_repairs;
		private System.Windows.Forms.DataGridViewTextBoxColumn repairIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn deviceIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn costsDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label_loggedUser;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_searchUserForRepair;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_searchCustomerForRepair;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_searchRepair;
		private System.Windows.Forms.ComboBox comboBox_statusForRepair;
		private System.Windows.Forms.TextBox textBox_searchMailForCustomer;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox_searchPhoneForCustomer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_searchCustomerForCustomer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button_searchCustomer;
		private System.Windows.Forms.Button button_searchUser;
		private System.Windows.Forms.TextBox textBox_searchMailForUser;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox_searchPhoneForUser;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox_searchUserForUser;
		private System.Windows.Forms.Label label9;
	}
}

