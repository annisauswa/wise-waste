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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User(tbEmail.Text, tbPassword.Text);
            if (user.Login(user.Email, user.Password))
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
    }
}
