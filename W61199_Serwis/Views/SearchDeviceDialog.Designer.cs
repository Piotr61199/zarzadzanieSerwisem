namespace W61199_Serwis.Views
{
	partial class SearchDeviceDialog
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
			this.grid_devices = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_producer = new System.Windows.Forms.TextBox();
			this.textBox_model = new System.Windows.Forms.TextBox();
			this.textBox_SN = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.grid_devices)).BeginInit();
			this.SuspendLayout();
			// 
			// grid_devices
			// 
			this.grid_devices.AllowUserToAddRows = false;
			this.grid_devices.AllowUserToDeleteRows = false;
			this.grid_devices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_devices.Location = new System.Drawing.Point(13, 56);
			this.grid_devices.MultiSelect = false;
			this.grid_devices.Name = "grid_devices";
			this.grid_devices.ReadOnly = true;
			this.grid_devices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_devices.Size = new System.Drawing.Size(405, 323);
			this.grid_devices.TabIndex = 0;
			this.grid_devices.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_devices_CellMouseDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Producent";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(142, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Model";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(276, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Numer seryjny";
			// 
			// textBox_producer
			// 
			this.textBox_producer.Location = new System.Drawing.Point(16, 30);
			this.textBox_producer.Name = "textBox_producer";
			this.textBox_producer.Size = new System.Drawing.Size(100, 20);
			this.textBox_producer.TabIndex = 4;
			this.textBox_producer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox_model
			// 
			this.textBox_model.Location = new System.Drawing.Point(145, 30);
			this.textBox_model.Name = "textBox_model";
			this.textBox_model.Size = new System.Drawing.Size(100, 20);
			this.textBox_model.TabIndex = 5;
			this.textBox_model.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox_SN
			// 
			this.textBox_SN.Location = new System.Drawing.Point(279, 28);
			this.textBox_SN.Name = "textBox_SN";
			this.textBox_SN.Size = new System.Drawing.Size(100, 20);
			this.textBox_SN.TabIndex = 6;
			this.textBox_SN.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// SearchDeviceDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 391);
			this.Controls.Add(this.textBox_SN);
			this.Controls.Add(this.textBox_model);
			this.Controls.Add(this.textBox_producer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.grid_devices);
			this.Name = "SearchDeviceDialog";
			this.Text = "SearchDeviceDialog";
			this.Load += new System.EventHandler(this.SearchDeviceDialog_Load);
			((System.ComponentModel.ISupportInitialize)(this.grid_devices)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView grid_devices;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_producer;
		private System.Windows.Forms.TextBox textBox_model;
		private System.Windows.Forms.TextBox textBox_SN;
	}
}