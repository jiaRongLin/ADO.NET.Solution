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
	public partial class FormCreateUser : Form
	{
		public FormCreateUser()
		{
			InitializeComponent();
		}
		private DateTime? DateOfBirth
			=> DateTime.TryParse(txtBirth.Text, out DateTime dt) ? dt : (DateTime?)null;

		private int? UserHeight
			=> int.TryParse (txtHeight.Text,out int height)? height:(int?)null;
		private UserEntity GetModel()
		   => new UserEntity
		   {
			   Name = txtName.Text,
			   Account =txtAccount.Text,
			   Password =txtPassword.Text,
			   DateOfBirth =this.DateOfBirth,
			   Height =this.UserHeight,
			   Email = txtEmail.Text,
		   };
		private void buttonsave_Click(object sender, EventArgs e)
		{
			new UserRepository().Create(GetModel());

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}
	}
}
