using ispan.Estore.SqlData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispqn.Estore.WinApp
{
    public partial class FormEditCategory : Form
    {
        private readonly int categroyId;

        public FormEditCategory(int categroyId)
        {
            InitializeComponent();
            this.categroyId = categroyId;

            this.Load += FormEditCategory_Load;
        }

        private void FormEditCategory_Load(object sender, EventArgs e)
        {
            Category category = new CategoryRepository().GetCategory(categroyId);
            if(category == null)
            {
                MessageBox.Show("record not found.");
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            else
            {
                txtName.Text =category.Name;
                txtDisplayOrder.Text = category.DisplayOrder.ToString();
            }
            //using (var conn = SQLDb.GetConnection())
            //{
            //    string sql = $"select * from Categories where id ={categroyId}";
            //    using (var commad =new SqlCommand(sql, conn))
            //    {
            //        conn.Open();
            //        var reader = commad.ExecuteReader();
            //        if (reader.Read())
            //        {
            //            txtName.Text = reader["Name"].ToString();
            //            txtDisplayOrder.Text = reader["DisplayOrder"].ToString();  
            //        }
            //        else
            //        {
            //            MessageBox.Show("record not found.");
            //            this.DialogResult = DialogResult.Cancel;
            //            return;
            //        }
            //    }
            //}
        }
    }
}
