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

        private void radioBtnEwaste_CheckedChanged(object sender, EventArgs e)
        {
            selectedValue = 1;
        }

        private void radioBtnOrganik_CheckedChanged(object sender, EventArgs e)
        {
            selectedValue = 2;
        }

        private void radioBtnAnorganik_CheckedChanged(object sender, EventArgs e)
        {
            selectedValue = 3;
        }

        private void btnConfirmSell_Click(object sender, EventArgs e)
        {
            
        }

        private void UserControlSell_Load_1(object sender, EventArgs e)
        {


        }
    }
}
