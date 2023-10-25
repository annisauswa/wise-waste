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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RegBtn(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.FirstName = tbFirstName.Text;
            registration.LastName = tbLastName.Text;
            registration.Password = tbPassword.Text;
            registration.RegisterDate = DateTime.Now;
        }
        private void CloseBtn(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
