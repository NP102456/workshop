using Microsoft.Data.SqlClient;
using System.Data;

namespace workshop
{
    public partial class Form1 : Form
    {
        internal class DBConnect
        {
            public static SqlConnection connectNorthwind()
            {
                string server = "LAPTOP-IQ8TJ0SI\\SQLEXPRESS";
                string db = "Northwind";
                string strCon = string.Format(@"Data Source={0}; Initial catalog={1};
            Integrated Security=True; Encrypt=False;", server, db);
                SqlConnection conn = new SqlConnection(strCon);
                conn.Open();

                return conn;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Connected to Northwind database Successfully!");

            }
            conn.Close();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
