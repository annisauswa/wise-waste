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
    public partial class NavForm : Form
    {
        NavigationControl navigationControl;

        public NavForm()
        {
            InitializeComponent();
            InitializeNavigationControl();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width <= 84)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    pnProfile.Width = sidebar.Width;
                    pnSell.Width = sidebar.Width;
                    pnTransHis.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 306)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnProfile.Width = sidebar.Width;
                    pnSell.Width = sidebar.Width;
                    pnTransHis.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                }
            }
        }

        private void NavForm_Load(object sender, EventArgs e)
        {

        }

        public void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new UserControlProfile(), new UserControlSell(), new UserControlCatalogue() };

            navigationControl = new NavigationControl(userControls, panel1);
            navigationControl.Display(0);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            navigationControl.Display(4);
        }
    }
}
