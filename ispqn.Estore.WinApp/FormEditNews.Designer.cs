namespace ispqn.Estore.WinApp
{
	partial class FormEditNews
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
			this.textDescription = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textTitle = new System.Windows.Forms.TextBox();
			this.btn_Update = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.labelModified = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Description";
			// 
			// textDescription
			// 
			this.textDescription.Location = new System.Drawing.Point(140, 87);
			this.textDescription.Multiline = true;
			this.textDescription.Name = "textDescription";
			this.textDescription.Size = new System.Drawing.Size(369, 283);
			this.textDescription.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Title";
			// 
			// textTitle
			// 
			this.textTitle.Location = new System.Drawing.Point(140, 34);
			this.textTitle.Name = "textTitle";
			this.textTitle.Size = new System.Drawing.Size(369, 25);
			this.textTitle.TabIndex = 1;
			// 
			// btn_Update
			// 
			this.btn_Update.Location = new System.Drawing.Point(530, 375);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(88, 31);
			this.btn_Update.TabIndex = 2;
			this.btn_Update.Text = "UpDate";
			this.btn_Update.UseVisualStyleBackColor = true;
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 391);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "異動時間:";
			// 
			// labelModified
			// 
			this.labelModified.AutoSize = true;
			this.labelModified.Location = new System.Drawing.Point(94, 391);
			this.labelModified.Name = "labelModified";
			this.labelModified.Size = new System.Drawing.Size(77, 15);
			this.labelModified.TabIndex = 3;
			this.labelModified.Text = "labModified";
			// 
			// FormEditNews
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelModified);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_Update);
			this.Controls.Add(this.textTitle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textDescription);
			this.Controls.Add(this.label1);
			this.Name = "FormEditNews";
			this.Text = "FormEditNews";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textDescription;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textTitle;
		private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelModified;
	}
}