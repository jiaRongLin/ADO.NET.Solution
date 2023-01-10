﻿using System;
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
	public partial class FormMain : Form
	{
		private readonly bool isMdi;
		public FormMain(bool isMdi)
		{
			InitializeComponent();

			this.isMdi = isMdi;

			if (isMdi) this.IsMdiContainer = true;
		}

		private void maintainNewsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm =new FormNews();
			if (isMdi) frm.MdiParent = this;
			frm.Show();
		}

		private void maintainUsersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new FormUser();
			if(isMdi)frm.MdiParent = this;
			frm.Show();
		}

		private static FormProducts _frmProducts;
		private void maintainProductsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//只出現一個FORM
			if(_frmProducts ==null || IsClosed("FormProducts"))
			{
				_frmProducts = new FormProducts(null, null);
				if (isMdi) _frmProducts.MdiParent = this;
				
			}
			var frm = _frmProducts;

			frm.Show();

		}
		/// <summary>
		/// 判斷已開啟的表單裡，有沒有指定名稱的表單
		/// </summary>
		/// <param name="formName"></param>
		/// <returns></returns>

		private bool IsClosed(string formName)
		{
			return !Application.OpenForms.Cast<Form>().Any(f => f.Name == formName);
			//foreach(var item in Application.OpenForms)
			//{
			//	var frm = item as Form;
			//	if (frm != null && frm.Name == formName) return false;
			//}
			//return true;
		}

		private void maintainCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new FormCategory();
			if (isMdi) frm.MdiParent = this;

			frm.Show();
		}

		private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new Form1();
			if (isMdi) frm.MdiParent = this;

			frm.Show();
		}

		private void usersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new FormUser();
			if (isMdi) frm.MdiParent = this;
			frm.Show();
		}

		private void newsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new FormNews();
			if (isMdi) frm.MdiParent = this;
			frm.Show();
		}

		private void productsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_frmProducts == null || IsClosed("FormProducts"))
			{
				_frmProducts = new FormProducts(null, null);
				if (isMdi) _frmProducts.MdiParent = this;

			}
			var frm = _frmProducts;

			frm.Show();
		}

		private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new FormCategory();
			if (isMdi) frm.MdiParent = this;

			frm.Show();
		}
		
		private void FormMain_FormClosing(object sender,FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
