using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace wise_waste
{
    public partial class RegistrationPage : Form
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        public static NpgsqlCommand cmd;
        public string sql = null;
        private NpgsqlConnection conn;
        string connstring = "Host=52.249.192.53;port=5432;Username=postgres;Password=Viera_angel29;Database=junpro";
        private void linkLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void RegistrationPage_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from register_insert(:_email,:_firstName, :_lastName, :_password)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_email", tbEmail.Text);
                cmd.Parameters.AddWithValue("_firstName", tbFirstName.Text);
                cmd.Parameters.AddWithValue("_lastName", tbLastName.Text);
                cmd.Parameters.AddWithValue("_password", tbPassword.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Anda berhasil mendaftarkan akun Anda!", "Well done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Registration Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
