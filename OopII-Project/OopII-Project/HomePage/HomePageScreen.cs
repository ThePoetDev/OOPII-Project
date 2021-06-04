using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OopII_Project {



        public partial class HomePageScreen : Form
        {
            string current;
            SqlDataReader dr;
            SqlConnection con;
            SqlDataAdapter da;
            DataTable dt;
            DataSet ds;
            SqlCommand command;

            public HomePageScreen(string _current)
            {
                InitializeComponent();
                current = _current;

            }

            private void LoginScreen_Load(object sender, EventArgs e)
            {
                con = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a756f7_oopii;User Id=db_a756f7_oopii_admin;Password=Oop2project");
                da = new SqlDataAdapter("Select * From Products", con);
                var ds = new DataSet();
                con.Open();
                da.Fill(ds);
                con.Close();
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
