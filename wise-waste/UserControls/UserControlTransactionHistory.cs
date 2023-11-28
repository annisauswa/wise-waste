using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wise_waste.UserControls
{
    public partial class UserControlTransactionHistory : UserControl
    {
        public UserControlTransactionHistory()
        {
            InitializeComponent();
        }

       
        // string connstring = "Host=52.249.192.53;port=5432;Username=postgres;Password=Viera_angel29;Database=junpro";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private NpgsqlConnection conn;
        private void UserControlTransactionHistory_Load(object sender, EventArgs e)
        {
            var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var dotenv = System.IO.Path.Combine(root, ".env");
            DotEnv.Load(dotenv);
            string host = Environment.GetEnvironmentVariable("Host");
            string port = Environment.GetEnvironmentVariable("Port");
            string username = Environment.GetEnvironmentVariable("Username");
            string password = Environment.GetEnvironmentVariable("Password");
            string database = Environment.GetEnvironmentVariable("Database");

            string connstring = string.Format("Host={0};Port={1};Username={2};Password={3};Database={4}", host, port, username, password, database);

        ///conn = new NpgsqlConnection(connstring);

            
            conn = new NpgsqlConnection(connstring);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvDataTransaksi.DataSource = null;
                sql = "select * from sell_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvDataTransaksi.DataSource = dt;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
