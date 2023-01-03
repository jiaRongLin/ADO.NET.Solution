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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_getconnectionstring_Click(object sender, EventArgs e)
        {
            string connStr = SQLDb.GetConnectionString("default");
            MessageBox.Show(connStr);
        }
    }
}
