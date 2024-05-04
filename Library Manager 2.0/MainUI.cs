using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manager
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            home1.BringToFront();

            panelNavBarHome.Show();
            panelNavBarBooks.Hide();
            panelNavBarTransaction.Hide();
            panelNavBarSchedule.Hide();
            panelNavBarHelp.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            home1.BringToFront();

            panelNavBarHome.Show();
            panelNavBarBooks.Hide();
            panelNavBarTransaction.Hide();
            panelNavBarSchedule.Hide();
            panelNavBarHelp.Hide();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            books1.BringToFront();

            panelNavBarHome.Hide();
            panelNavBarBooks.Show();
            panelNavBarTransaction.Hide();
            panelNavBarSchedule.Hide();
            panelNavBarHelp.Hide();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            transaction1.BringToFront();

            panelNavBarHome.Hide();
            panelNavBarBooks.Hide();
            panelNavBarTransaction.Show();
            panelNavBarSchedule.Hide();
            panelNavBarHelp.Hide();
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            shift1.BringToFront();

            panelNavBarHome.Hide();
            panelNavBarBooks.Hide();
            panelNavBarTransaction.Hide();
            panelNavBarSchedule.Show();
            panelNavBarHelp.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            help1.BringToFront();

            panelNavBarHome.Hide();
            panelNavBarBooks.Hide();
            panelNavBarTransaction.Hide();
            panelNavBarSchedule.Hide();
            panelNavBarHelp.Show();
        }
    }
}
