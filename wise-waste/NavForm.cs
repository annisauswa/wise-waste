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

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new UserControlProfile(), new UserControlSell(), new UserControlCatalogue};
        }
    }
}
