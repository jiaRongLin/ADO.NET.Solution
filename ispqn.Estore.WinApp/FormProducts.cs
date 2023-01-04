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
	public partial class FormProducts : Form
	{
		private readonly int? categoryId;
		private readonly string prodName; //只有在建構函數才可以改值
		public FormProducts(int? categoryId,string prodName)
		{
			InitializeComponent();
			this.Load += FormProducts_Load;

			this.categoryId = categoryId; //這裡才能改
			this.prodName = prodName;
		}

		private void FormProducts_Load(object sender, EventArgs e)
		{
			var products = new ProductRepository().Search(categoryId,prodName).ToList();
			this.dataGridView1.DataSource = products;
		}
	}
}
