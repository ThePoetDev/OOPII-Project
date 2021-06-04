using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OopII_Project
{
    public partial class OrderScreen : Form
    {
        string current;
        public OrderScreen(string _current)
        {
            InitializeComponent();
            current = _current;
        }

        private void backButton_Click(object sender, EventArgs e) {
            Form shoppingCartScreen = new ShoppingCartScreen(current);
            this.Hide();
            shoppingCartScreen.ShowDialog();
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
