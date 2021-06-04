using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OopII_Project {
    public partial class HomePageScreen : Form {
        string current;
        public HomePageScreen(string _current) {
            InitializeComponent();
            current = _current;
            
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnLogInOut_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {

        }

        private void btnCd_Click(object sender, EventArgs e)
        {

        }

        private void btnMagazine_Click(object sender, EventArgs e)
        {

        }

        private void btnBasket_Click(object sender, EventArgs e)
        {
            Form shoppingCartScreen = new ShoppingCartScreen(current);
            this.Hide();
            shoppingCartScreen.ShowDialog();
            this.Close();
        }

        private void picBook1_Click(object sender, EventArgs e)
        {

        }

        private void picBook2_Click(object sender, EventArgs e)
        {

        }

        private void picBook3_Click(object sender, EventArgs e)
        {

        }

        private void picCd1_Click(object sender, EventArgs e)
        {

        }

        private void picCd2_Click(object sender, EventArgs e)
        {

        }

        private void picCd3_Click(object sender, EventArgs e)
        {

        }

        private void picMag1_Click(object sender, EventArgs e)
        {

        }

        private void picMag2_Click(object sender, EventArgs e)
        {

        }

        private void picMag3_Click(object sender, EventArgs e)
        {

        }

        private void picLogo_Click(object sender, EventArgs e) {
            
        }
    }
}
