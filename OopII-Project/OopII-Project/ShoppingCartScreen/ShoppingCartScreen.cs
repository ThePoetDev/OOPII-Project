using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OopII_Project
{
    public partial class ShoppingCartScreen : Form
    {
        public ShoppingCartScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    }

        private void ShoppingCartScreen_Load(object sender, EventArgs e)
        {

        }

        private void msMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSipariş_Click(object sender, EventArgs e) {
            Form orderScreen = new OrderScreen();
            this.Hide();
            orderScreen.ShowDialog();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e) {
            Form homepageScreen = new HomePageScreen();
            this.Hide();
            homepageScreen.ShowDialog();
            this.Close();
        }
    }
}
