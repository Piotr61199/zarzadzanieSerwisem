namespace W61199_Serwis.Views
{
	partial class CustomerDialog
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
			this.phone_textbox = new System.Windows.Forms.TextBox();
			this.surname_textbox = new System.Windows.Forms.TextBox();
			this.name_textbox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.close_button = new System.Windows.Forms.Button();
			this.add_user_button = new System.Windows.Forms.Button();
			this.address_textbox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.email_textbox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.customer_tabControl = new System.Windows.Forms.TabControl();
			this.customerData_tab = new System.Windows.Forms.TabPage();
			this.customerHistory_tab = new System.Windows.Forms.TabPage();
			this.delete_button = new System.Windows.Forms.Button();
			this.grid_History = new System.Windows.Forms.DataGridView();
			this.customer_tabControl.SuspendLayout();
			this.customerData_tab.SuspendLayout();
			this.customerHistory_tab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_History)).BeginInit();
			this.SuspendLayout();
			// 
			// phone_textbox
			// 
			this.phone_textbox.Location = new System.Drawing.Point(134, 67);
			this.phone_textbox.Name = "phone_textbox";
			this.phone_textbox.Size = new System.Drawing.Size(241, 20);
			this.phone_textbox.TabIndex = 15;
			// 
			// surname_textbox
			// 
			this.surname_textbox.Location = new System.Drawing.Point(134, 41);
			this.surname_textbox.Name = "surname_textbox";
			this.surname_textbox.Size = new System.Drawing.Size(241, 20);
			this.surname_textbox.TabIndex = 14;
			// 
			// name_textbox
			// 
			this.name_textbox.Location = new System.Drawing.Point(134, 15);
			this.name_textbox.Name = "name_textbox";
			this.name_textbox.Size = new System.Drawing.Size(241, 20);
			this.name_textbox.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Numer telefonu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Nazwisko";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Imię";
			// 
			// close_button
			// 
			this.close_button.Location = new System.Drawing.Point(385, 308);
			this.close_button.Name = "close_button";
			this.close_button.Size = new System.Drawing.Size(75, 23);
			this.close_button.TabIndex = 9;
			this.close_button.Text = "Zamknij";
			this.close_button.UseVisualStyleBackColor = true;
			this.close_button.Click += new System.EventHandler(this.close_button_Click);
			// 
			// add_user_button
			// 
			this.add_user_button.Location = new System.Drawing.Point(304, 308);
			this.add_user_button.Name = "add_user_button";
			this.add_user_button.Size = new System.Drawing.Size(75, 23);
			this.add_user_button.TabIndex = 8;
			this.add_user_button.Text = "Zapisz";
			this.add_user_button.UseVisualStyleBackColor = true;
			this.add_user_button.Click += new System.EventHandler(this.add_user_button_Click);
			// 
			// address_textbox
			// 
			this.address_textbox.Location = new System.Drawing.Point(134, 119);
			this.address_textbox.Name = "address_textbox";
			this.address_textbox.Size = new System.Drawing.Size(241, 20);
			this.address_textbox.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Adres";
			// 
			// email_textbox
			// 
			this.email_textbox.Location = new System.Drawing.Point(134, 93);
			this.email_textbox.Name = "email_textbox";
			this.email_textbox.Size = new System.Drawing.Size(241, 20);
			this.email_textbox.TabIndex = 19;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 100);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "e-mail";
			// 
			// customer_tabControl
			// 
			this.customer_tabControl.Controls.Add(this.customerData_tab);
			this.customer_tabControl.Controls.Add(this.customerHistory_tab);
			this.customer_tabControl.Location = new System.Drawing.Point(12, 12);
			this.customer_tabControl.Name = "customer_tabControl";
			this.customer_tabControl.SelectedIndex = 0;
			this.customer_tabControl.Size = new System.Drawing.Size(452, 294);
			this.customer_tabControl.TabIndex = 20;
			// 
			// customerData_tab
			// 
			this.customerData_tab.Controls.Add(this.label1);
			this.customerData_tab.Controls.Add(this.email_textbox);
			this.customerData_tab.Controls.Add(this.label2);
			this.customerData_tab.Controls.Add(this.label5);
			this.customerData_tab.Controls.Add(this.label3);
			this.customerData_tab.Controls.Add(this.address_textbox);
			this.customerData_tab.Controls.Add(this.name_textbox);
			this.customerData_tab.Controls.Add(this.label4);
			this.customerData_tab.Controls.Add(this.surname_textbox);
			this.customerData_tab.Controls.Add(this.phone_textbox);
			this.customerData_tab.Location = new System.Drawing.Point(4, 22);
			this.customerData_tab.Name = "customerData_tab";
			this.customerData_tab.Padding = new System.Windows.Forms.Padding(3);
			this.customerData_tab.Size = new System.Drawing.Size(444, 268);
			this.customerData_tab.TabIndex = 0;
			this.customerData_tab.Text = "Dane";
			this.customerData_tab.UseVisualStyleBackColor = true;
			// 
			// customerHistory_tab
			// 
			this.customerHistory_tab.Controls.Add(this.grid_History);
			this.customerHistory_tab.Location = new System.Drawing.Point(4, 22);
			this.customerHistory_tab.Name = "customerHistory_tab";
			this.customerHistory_tab.Padding = new System.Windows.Forms.Padding(3);
			this.customerHistory_tab.Size = new System.Drawing.Size(444, 268);
			this.customerHistory_tab.TabIndex = 1;
			this.customerHistory_tab.Text = "Historia napraw";
			this.customerHistory_tab.UseVisualStyleBackColor = true;
			// 
			// delete_button
			// 
			this.delete_button.Location = new System.Drawing.Point(223, 308);
			this.delete_button.Name = "delete_button";
			this.delete_button.Size = new System.Drawing.Size(75, 23);
			this.delete_button.TabIndex = 21;
			this.delete_button.Text = "Usuń";
			this.delete_button.UseVisualStyleBackColor = true;
			this.delete_button.Click += new System.EventHandler(this.customer_delete_Click);
			// 
			// grid_History
			// 
			this.grid_History.AllowUserToAddRows = false;
			this.grid_History.AllowUserToDeleteRows = false;
			this.grid_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_History.Location = new System.Drawing.Point(7, 17);
			this.grid_History.Name = "grid_History";
			this.grid_History.ReadOnly = true;
			this.grid_History.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_History.Size = new System.Drawing.Size(431, 245);
			this.grid_History.TabIndex = 0;
			this.grid_History.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_History_CellContentDoubleClick);
			// 
			// CustomerDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 354);
			this.Controls.Add(this.delete_button);
			this.Controls.Add(this.customer_tabControl);
			this.Controls.Add(this.close_button);
			this.Controls.Add(this.add_user_button);
			this.Name = "CustomerDialog";
			this.Text = "AddCustomer";
			this.Load += new System.EventHandler(this.CustomerDialog_Load);
			this.customer_tabControl.ResumeLayout(false);
			this.customerData_tab.ResumeLayout(false);
			this.customerData_tab.PerformLayout();
			this.customerHistory_tab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid_History)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox phone_textbox;
		private System.Windows.Forms.TextBox surname_textbox;
		private System.Windows.Forms.TextBox name_textbox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button close_button;
		private System.Windows.Forms.Button add_user_button;
		private System.Windows.Forms.TextBox address_textbox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox email_textbox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TabControl customer_tabControl;
		private System.Windows.Forms.TabPage customerData_tab;
		private System.Windows.Forms.TabPage customerHistory_tab;
		private System.Windows.Forms.Button delete_button;
		private System.Windows.Forms.DataGridView grid_History;
	}
}