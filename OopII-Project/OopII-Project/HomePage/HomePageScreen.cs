using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OopII_Project
{



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

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count = 0;
            MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            SqlConnection con = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a756f7_oopii;User Id=db_a756f7_oopii_admin;Password=Oop2project");
            con.Open();
            SqlConnection con2 = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a756f7_oopii;User Id=db_a756f7_oopii_admin;Password=Oop2project");
            con2.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from ShoppingCarts where username='" + current + "'", con);
            da.Fill(dt);
            con.Close();
            string item = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            if (dt.Rows[0][1].ToString() == "" || dt.Rows[0][1].ToString() == item)
            {
                SqlCommand com = new SqlCommand("UPDATE  ShoppingCarts " +
                    "set item1='" + item +
                    "', item1amount=" + "item1amount+1" +
                    "where username='" + current + "' ;", con2);

                com.ExecuteNonQuery();
                con2.Close();

            }
            else if (dt.Rows[0][3].ToString() == "" || dt.Rows[0][3].ToString() == item)
            {
                SqlCommand com = new SqlCommand("UPDATE  ShoppingCarts " +
                   "set item2='" + item +
                   "', item2amount=" + "item2amount+1" +
                   "where username='" + current + "' ;", con2);

                com.ExecuteNonQuery();
                con2.Close();
            }
            else if (dt.Rows[0][5].ToString() == "" || dt.Rows[0][5].ToString() == item)
            {
                SqlCommand com = new SqlCommand("UPDATE  ShoppingCarts " +
                   "set item3='" + item +
                   "', item3amount=" + "item3amount+1" +
                   "where username='" + current + "' ;", con2);

                com.ExecuteNonQuery();
                con2.Close();
            }
            else if (dt.Rows[0][7].ToString() == "" || dt.Rows[0][7].ToString() == item)
            {
                SqlCommand com = new SqlCommand("UPDATE  ShoppingCarts " +
                   "set item4='" + item +
                   "', item4amount=" + "item4amount+1" +
                   "where username='" + current + "' ;", con2);

                com.ExecuteNonQuery();
                con2.Close();
            }
            else if (dt.Rows[0][9].ToString() == "" || dt.Rows[0][9].ToString() == item)
            {
                SqlCommand com = new SqlCommand("UPDATE  ShoppingCarts " +
                   "set item5='" + item +
                   "', item5amount=" + "item5amount+1" +
                   "where username='" + current + "' ;", con2);

                com.ExecuteNonQuery();
                con2.Close();
            }
            else
            {
                MessageBox.Show("Your cart is full!");
            }
        }
    }
}