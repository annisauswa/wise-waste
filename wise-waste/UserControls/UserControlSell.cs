using Npgsql;
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
using System.Data.SqlClient;
using System.Net;
using System.Xml.Linq;

namespace wise_waste
{
    public partial class UserControlSell : UserControl
    {
        public int selectedValue;

        public UserControlSell()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=52.249.192.53;port=5432;Username=postgres;Password=Viera_angel29;Database=junpro";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private void UserControlSell_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }


        private void btnConfirmSell_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = "insert into sell(register_id, category_id, prod_name, amount) values (@register_id, @category_id, @prod_name, @amount)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@register_id", register_id);
                cmd.Parameters.AddWithValue("@category_id", category_id);
                cmd.Parameters.AddWithValue("@prod_name", tbProdName.Text);
                cmd.Parameters.AddWithValue("@amount", Convert.ToInt32(tbAmount.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Sale data has been successfully added to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Failed to add sale data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private int register_id = UserSession.Instance.UserId;
        private void UserControlSell_Load_1(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = "select address from register where register_id=@register_id";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@register_id", register_id);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                // Check if there are rows returned
                if (reader.Read())
                {
                    // Read the value from the "firstname" column and assign it to the TextBox
                    tbSellAddress.Text = reader["address"].ToString();
                }

                // Close the data reader and the connection
                reader.Close();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Load FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

        }

        int category_id = 0;
        private void totalAmount_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "select address from register where register_id=@register_id";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@register_id", register_id);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            // Check if there are rows returned
            if (reader.Read())
            {
                // Read the value from the "firstname" column and assign it to the TextBox
                tbSellAddress.Text = reader["address"].ToString();
            }

            // Close the data reader and the connection
            reader.Close();

            conn.Close();
            float harga_waste = 0;

            if (radioBtnEwaste.Checked)
            {
                harga_waste = 15000;
                category_id = 1;
            }
            else if (radioBtnOrganik.Checked)
            {
                harga_waste = 9000;
                category_id = 2;
            }
                
            else if (radioBtnAnorganik.Checked)
            {
                harga_waste = 12500;
                category_id = 2;
            }

            try
            {
                if(tbWeight.Text.Length > 0)
                {
                    harga_waste *= float.Parse(tbWeight.Text);
                    tbAmount.Text = harga_waste.ToString();
                }
                else
                {
                    MessageBox.Show("Mohon pilih kategori dan masukkan total berat sampah", "UNCOMPLETE FORM!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbProdName.Text = String.Empty;
            tbWeight.Text = String.Empty;
            tbSellAddress.Text = String.Empty;
            tbAmount.Text = String.Empty;
            radioBtnEwaste.Checked = false;
            radioBtnAnorganik.Checked = false;
            radioBtnOrganik.Checked = false;
        }
    }
}
