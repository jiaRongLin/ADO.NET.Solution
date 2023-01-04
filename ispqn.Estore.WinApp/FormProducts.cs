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
		public FormProducts()
		{
			InitializeComponent();
			this.Load += FormProducts_Load;
		}

		private void FormProducts_Load(object sender, EventArgs e)
		{
			var products = new ProductRepository().Search().ToList();
			this.dataGridView1.DataSource = products;
		}
	}
}
