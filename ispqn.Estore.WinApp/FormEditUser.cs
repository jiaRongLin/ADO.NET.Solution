using ispan.Estore.SqlData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispqn.Estore.WinApp
{
	public partial class FormEditUser : Form
	{
		private readonly int userId;
		public FormEditUser(int userId)
		{
			InitializeComponent();

			this.userId = userId;
			this.Load += FormEditUser_Load;
		}

		private void FormEditUser_Load(object sender, EventArgs e)
		{
			var user = new UserRepository().GetUser(userId);
			BindForm(user);
		}
		private void BindForm(UserEntity user)
		{
			txtName.Text = user.Name;
			txtAccount.Text = user.Account;
			txtPassword.Text = user.Password;
			txtEmail.Text = user.Email;
			txtBirth.Text = user.DateOfBirth.HasValue
							? user.DateOfBirth.Value.ToString("yyyy/MM/dd") : String.Empty;
			txtHeight.Text = user.Height.HasValue ? user.Height.Value.ToString() : String.Empty;
		}
		private DateTime? DateOfBirth
			=> DateTime.TryParse(txtBirth.Text, out DateTime dt) ? dt : (DateTime?)null;

		private int? UserHeight
			=> int.TryParse(txtHeight.Text, out int height) ? height : (int?)null;
		private UserEntity GetModel()
		   => new UserEntity
		   {
			   Id = this.userId,
			   Name = txtName.Text,
			   Account = txtAccount.Text,
			   Password = txtPassword.Text,
			   DateOfBirth = this.DateOfBirth,
			   Height = this.UserHeight,
			   Email = txtEmail.Text,
		   };
		private void buttonupdate_Click(object sender, EventArgs e)
		{
			new UserRepository().Update(GetModel());
			NotifyOwner();
		}
		private void NotifyOwner()
		{
			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}

		private void buttonDdelete_Click(object sender, EventArgs e)
		{
			new UserRepository().Delete(this.userId);
			NotifyOwner();
		}
	}
}
