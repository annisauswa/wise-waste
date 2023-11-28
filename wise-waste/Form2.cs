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
        public NpgsqlConnection conn;
        string connstring = "Host=52.249.192.53;port=5432;Username=postgres;Password=Viera_angel29;Database=junpro";
        public static NpgsqlCommand cmd;
        public string sql = null;
        public void Form2_Load(object sender, EventArgs e)
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
        public bool Login(string Email, string Password)
        {
            // suppose we have a dummy data
            if (Email == "user" & Password == "user123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from login(:_email, :_password)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_email", txtEmail.Text);
                cmd.Parameters.AddWithValue("_password", txtPassword.Text);

                int result = (int)cmd.ExecuteScalar();
                conn.Close();

                if(result == 1)
                {
                    MessageBox.Show("Login Berhasil, mengalihkan ke Homepage");
                    NavForm navForm = new NavForm();
                    navForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login gagal", "Tolong cek email dan password anda!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
