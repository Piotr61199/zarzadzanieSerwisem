namespace W61199_Serwis.Views
{
	partial class DeviceDialog
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
			this.add_button = new System.Windows.Forms.Button();
			this.close_button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.producer_textBox = new System.Windows.Forms.TextBox();
			this.model_textBox = new System.Windows.Forms.TextBox();
			this.SN_textBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// add_button
			// 
			this.add_button.Location = new System.Drawing.Point(199, 113);
			this.add_button.Name = "add_button";
			this.add_button.Size = new System.Drawing.Size(75, 23);
			this.add_button.TabIndex = 0;
			this.add_button.Text = "Dodaj";
			this.add_button.UseVisualStyleBackColor = true;
			this.add_button.Click += new System.EventHandler(this.add_button_Click);
			// 
			// close_button
			// 
			this.close_button.Location = new System.Drawing.Point(280, 113);
			this.close_button.Name = "close_button";
			this.close_button.Size = new System.Drawing.Size(75, 23);
			this.close_button.TabIndex = 1;
			this.close_button.Text = "Zamknij";
			this.close_button.UseVisualStyleBackColor = true;
			this.close_button.Click += new System.EventHandler(this.close_button_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(70, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Producent";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(91, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Model";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(91, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "S/N";
			// 
			// producer_textBox
			// 
			this.producer_textBox.Location = new System.Drawing.Point(132, 35);
			this.producer_textBox.Name = "producer_textBox";
			this.producer_textBox.Size = new System.Drawing.Size(223, 20);
			this.producer_textBox.TabIndex = 5;
			// 
			// model_textBox
			// 
			this.model_textBox.Location = new System.Drawing.Point(132, 61);
			this.model_textBox.Name = "model_textBox";
			this.model_textBox.Size = new System.Drawing.Size(223, 20);
			this.model_textBox.TabIndex = 6;
			// 
			// SN_textBox
			// 
			this.SN_textBox.Location = new System.Drawing.Point(132, 87);
			this.SN_textBox.Name = "SN_textBox";
			this.SN_textBox.Size = new System.Drawing.Size(223, 20);
			this.SN_textBox.TabIndex = 7;
			// 
			// DeviceDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(388, 160);
			this.Controls.Add(this.SN_textBox);
			this.Controls.Add(this.model_textBox);
			this.Controls.Add(this.producer_textBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.close_button);
			this.Controls.Add(this.add_button);
			this.Name = "DeviceDialog";
			this.Text = "DeviceDialog";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button add_button;
		private System.Windows.Forms.Button close_button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox producer_textBox;
		private System.Windows.Forms.TextBox model_textBox;
		private System.Windows.Forms.TextBox SN_textBox;
	}
}