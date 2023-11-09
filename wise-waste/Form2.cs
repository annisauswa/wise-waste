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

namespace wise_waste
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=52.249.192.53;port=5432;Username=postgres;Password=Viera_angel29;Database=junpro";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationPage registrationPage = new RegistrationPage();
            registrationPage.Show();
            this.Hide();
        }
        private bool Login(string email, string password)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connstring))
            {
                connection.Open();

                string query = "SELECT password FROM users WHERE email = @Email";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader["password"].ToString();

                            if (storedPassword == password)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false; // Authentication failed
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(Login(tbEmail.Text, tbPassword.Text))
                {
                    MessageBox.Show("Login Berhasil, mengalihkan ke Homepage");
                    NavForm navForm = new NavForm();
                    navForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login gagal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
