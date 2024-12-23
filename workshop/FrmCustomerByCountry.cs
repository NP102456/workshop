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
    public partial class FrmCustomerByCountry : Form
    {
        public FrmCustomerByCountry()
        {
            InitializeComponent();
        }

        private void FrmCustomerByCountry_Load(object sender, EventArgs e)
        {
            showCountry();
            showCustomer();
        }
        public void showCountry()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string query = "Select Distinct Country From Customers Order By Country ASC";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow row = dt.NewRow();
            row[0] = "------ แสดงทั้งหมด ------";
            dt.Rows.InsertAt(row, 0);

            cboCountry.DataSource = dt;
            cboCountry.ValueMember = "Country";
            cboCountry.DisplayMember = "Country";

            conn.Close();
        }
        public void showCustomer()
        {
            SqlConnection conn = DBConnect.connectNorthwind();

            string country = cboCountry.SelectedValue.ToString();

            string query = string.Format("Select * From Customers Where country = '{0}'", country);

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dvgResult.DataSource = dt;
            conn.Close();

        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            showCustomer();
        }
    }
}
