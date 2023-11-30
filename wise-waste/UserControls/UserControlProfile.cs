using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wise_waste
{
    public partial class UserControlProfile : UserControl
    {
        List<string> listKota = new List<string>();
        public UserControlProfile()
        {
            InitializeComponent();
            listKota = Profile.GetKotaList();
            foreach (string kota in listKota)
            {
                tbAddress.AutoCompleteCustomSource.Add(kota);
                tbAddress.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbAddress.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        public NpgsqlConnection conn;
        string connstring = "Host=52.249.192.53;port=5432;Username=postgres;Password=Viera_angel29;Database=junpro";
        public static NpgsqlCommand cmd;
        public string sql = null;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from register_update(:_register_id, :_address, :_phonenumber)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_register_id", register_id);
                cmd.Parameters.AddWithValue("_address", tbAddress.Text);
                cmd.Parameters.AddWithValue("_phonenumber", tbPhoneNumber.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Profile Berhasil Diupdate!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Update FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

        }

        private int register_id = UserSession.Instance.UserId;
        private void UserControlProfile_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);

            try
            {
                conn.Open();
                sql = "select firstname, lastname, address, phonenumber from register where register_id=@register_id";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@register_id", register_id);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                // Check if there are rows returned
                if (reader.Read())
                {
                    // Read the value from the "firstname" column and assign it to the TextBox
                    string firstName = reader["firstname"].ToString();
                    string lastName = reader["lastname"].ToString();
                    tbName.Text = $"{firstName} {lastName}";
                    tbAddress.Text = reader["address"].ToString();
                    tbPhoneNumber.Text = reader["phonenumber"].ToString();
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


    }
}
