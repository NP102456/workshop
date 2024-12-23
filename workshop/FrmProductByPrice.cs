using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static workshop.Form1;

namespace workshop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string startPrice = txtStart.Text;
            string endPrice = txtEnd.Text;
            string query = string.Format("Select * From Products Where UnitPrice Between {0} And {1}",startPrice ,endPrice);
            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvResult.DataSource = dt;

            conn.Close();
        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
