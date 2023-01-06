namespace ispqn.Estore.WinApp
{
	partial class FormCreateProduct
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtImage = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "CategoryId";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(157, 41);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(204, 30);
			this.txtId.TabIndex = 0;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(260, 328);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(101, 46);
			this.buttonSave.TabIndex = 7;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Name";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(157, 77);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(204, 30);
			this.txtName.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "Description";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(157, 113);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(204, 30);
			this.txtDescription.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(40, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 19);
			this.label4.TabIndex = 0;
			this.label4.Text = "Price";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(157, 149);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(204, 30);
			this.txtPrice.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 185);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 19);
			this.label5.TabIndex = 0;
			this.label5.Text = "Status";
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(157, 185);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(204, 30);
			this.txtStatus.TabIndex = 4;
			this.txtStatus.Text = "True";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(40, 221);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 19);
			this.label6.TabIndex = 0;
			this.label6.Text = "ProductImage";
			// 
			// txtImage
			// 
			this.txtImage.Location = new System.Drawing.Point(157, 221);
			this.txtImage.Name = "txtImage";
			this.txtImage.Size = new System.Drawing.Size(204, 30);
			this.txtImage.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(40, 257);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 19);
			this.label7.TabIndex = 0;
			this.label7.Text = "Stock";
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(157, 257);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(204, 30);
			this.txtStock.TabIndex = 6;
			// 
			// FormCreateProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 393);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtImage);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtStatus);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label1);
			this.Name = "FormCreateProduct";
			this.Text = "FormCreateProduct";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtImage;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtStock;
	}
}