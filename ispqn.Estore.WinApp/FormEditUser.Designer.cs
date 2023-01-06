namespace ispqn.Estore.WinApp
{
	partial class FormEditUser
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
			this.buttonupdate = new System.Windows.Forms.Button();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtHeight = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBirth = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAccount = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonDdelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonupdate
			// 
			this.buttonupdate.Location = new System.Drawing.Point(125, 242);
			this.buttonupdate.Name = "buttonupdate";
			this.buttonupdate.Size = new System.Drawing.Size(103, 39);
			this.buttonupdate.TabIndex = 19;
			this.buttonupdate.Text = "Update";
			this.buttonupdate.UseVisualStyleBackColor = true;
			this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(94, 197);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(218, 25);
			this.txtEmail.TabIndex = 18;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 15);
			this.label6.TabIndex = 7;
			this.label6.Text = "Email";
			// 
			// txtHeight
			// 
			this.txtHeight.Location = new System.Drawing.Point(94, 166);
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.Size = new System.Drawing.Size(218, 25);
			this.txtHeight.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 169);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "Height";
			// 
			// txtBirth
			// 
			this.txtBirth.Location = new System.Drawing.Point(94, 135);
			this.txtBirth.Name = "txtBirth";
			this.txtBirth.Size = new System.Drawing.Size(218, 25);
			this.txtBirth.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "DateOfBitth";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(94, 104);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '●';
			this.txtPassword.Size = new System.Drawing.Size(218, 25);
			this.txtPassword.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "Password";
			// 
			// txtAccount
			// 
			this.txtAccount.Location = new System.Drawing.Point(94, 73);
			this.txtAccount.Name = "txtAccount";
			this.txtAccount.Size = new System.Drawing.Size(218, 25);
			this.txtAccount.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 15);
			this.label2.TabIndex = 11;
			this.label2.Text = "Account";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(94, 42);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(218, 25);
			this.txtName.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 15);
			this.label1.TabIndex = 13;
			this.label1.Text = "Name:";
			// 
			// buttonDdelete
			// 
			this.buttonDdelete.Location = new System.Drawing.Point(253, 242);
			this.buttonDdelete.Name = "buttonDdelete";
			this.buttonDdelete.Size = new System.Drawing.Size(103, 39);
			this.buttonDdelete.TabIndex = 20;
			this.buttonDdelete.Text = "Delete";
			this.buttonDdelete.UseVisualStyleBackColor = true;
			this.buttonDdelete.Click += new System.EventHandler(this.buttonDdelete_Click);
			// 
			// FormEditUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 289);
			this.Controls.Add(this.buttonDdelete);
			this.Controls.Add(this.buttonupdate);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtHeight);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtBirth);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAccount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Name = "FormEditUser";
			this.Text = "FormEditUser";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonupdate;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtHeight;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtBirth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAccount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonDdelete;
	}
}