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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_getconnectionstring_Click(object sender, EventArgs e)
        {
            SQLDb.ApplicationName = "Test";
            SQLDb.ConnectTimeout = 66;
            SQLDb.Pooling = false;
            string connStr = SQLDb.GetConnectionString("default");
            MessageBox.Show(connStr);
        }

        private void btn_getconnection_Click(object sender, EventArgs e)
        {
            //SQLDb.ApplicationName = "conn test";
            //SQLDb.Pooling = this.checkBox_pooling.Checked;
            //SqlConnection conn =SQLDb.GetConnection("default");
            //conn.Open();

            //var commad = new SqlCommand("select * from Categories" , conn);
            //var reader = commad.ExecuteReader();
            //reader.Close();

            //conn.Close();
            //conn.Dispose();

            //用using以免忘記close
            SQLDb.ApplicationName = "conn test";
            SQLDb.Pooling = this.checkBox_pooling.Checked;

            using( SqlConnection conn = SQLDb.GetConnection("default"))
            {
                using (var commad = new SqlCommand("select * from Categories", conn))
                {
                    conn.Open();

                    var reader = commad.ExecuteReader();
                    reader.Close();
                }
            }
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {

            bool isInt = int.TryParse(text_categoryid.Text, out int categroyId);
            if(isInt == false)
            {
                MessageBox.Show("請輸入正確 categroy Id");
                return;
            }
            var frm = new FormEditCategory(categroyId);
            frm.ShowDialog();
        }
    }
}
