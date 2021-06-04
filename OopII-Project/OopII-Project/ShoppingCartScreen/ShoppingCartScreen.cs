using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace OopII_Project
{
    public partial class ShoppingCartScreen : Form
    {

        SqlDataReader dr;
        SqlConnection con, con2;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        SqlCommand command;
        String item1, item2, item3, item4, item5, item1amount, item2amount, item3amount, item4amount, item5amount;

        private void nupPrdQuantity2_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a756f7_oopii;User Id=db_a756f7_oopii_admin;Password=Oop2project");
            con2.Open();

            SqlCommand com = new SqlCommand("UPDATE  ShoppingCarts " +
                    "set item2amount=" + nupPrdQuantity2.Value +
                    "where item2='" + item2 + "' ;", con2);

            com.ExecuteNonQuery();
            con2.Close();
            item2amount = nupPrdQuantity2.Value.ToString();
            TotalPriceChange();

        }

        private void nupPrdQuantity3_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a756f7_oopii;User Id=db_a756f7_oopii_admin;Password=Oop2project");
            con2.Open();

            SqlCommand com = new SqlCommand("UPDATE  ShoppingCarts " +
                    "set item3amount=" + nupPrdQuantity3.Value +
                    "where item3='" + item3 + "' ;", con2);

            com.ExecuteNonQuery();
            con2.Close();
            item3amount = nupPrdQuantity3.Value.ToString();
            TotalPriceChange();


        }

        private void nupPrdQuantity4_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a756f7_oopii;User Id=db_a756f7_oopii_admin;Password=Oop2project");
            con2.Open();

            SqlCommand com = new SqlCommand("UPDATE  ShoppingCarts " +
                    "set item4amount=" + nupPrdQuantity4.Value +
                    "where item4='" + item4 + "' ;", con2);

            com.ExecuteNonQuery();
            con2.Close();
            item4amount = nupPrdQuantity4.Value.ToString();
            TotalPriceChange();



        }

        private void nupPrdQuantity5_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a756f7_oopii;User Id=db_a756f7_oopii_admin;Password=Oop2project");
            con2.Open();

            SqlCommand com = new SqlCommand("UPDATE  ShoppingCarts " +
                    "set item5amount=" + nupPrdQuantity5.Value +
                    "where item5='" + item5 + "' ;", con2);

            com.ExecuteNonQuery();
            con2.Close();
            item5amount = nupPrdQuantity5.Value.ToString();
            TotalPriceChange();


        }

        private void nupPrdQuantity1_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a756f7_oopii;User Id=db_a756f7_oopii_admin;Password=Oop2project");
            con2.Open();

            SqlCommand com = new SqlCommand("UPDATE  ShoppingCarts " +
                    "set item1amount=" + nupPrdQuantity1.Value +
                    "where item1='" + item1 + "' ;", con2);

            com.ExecuteNonQuery();
            con2.Close();
            item1amount = nupPrdQuantity1.Value.ToString();
            TotalPriceChange();


        }







        private void tlpCart1_Paint(object sender, PaintEventArgs e)
        {

        }

        string current;
        public ShoppingCartScreen(string _current)
        {
            InitializeComponent();
            current = _current;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ShoppingCartScreen_Load(object sender, EventArgs e)
        {
            load();

        }


        public void load() {
            con = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a756f7_oopii;User Id=db_a756f7_oopii_admin;Password=Oop2project");
            con2 = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a756f7_oopii;User Id=db_a756f7_oopii_admin;Password=Oop2project");
            da = new SqlDataAdapter("Select * From ShoppingCarts Where Username='" + current + "'", con);
            dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            if (dt.Rows[0]["item1"].ToString() == "")
            {
                item1 = "-";
                item1amount = "0";
            }
            else
            {
                item1 = dt.Rows[0]["item1"].ToString();
                item1amount = dt.Rows[0]["item1amount"].ToString();
            }
            if (dt.Rows[0]["item2"].ToString() == "")
            {
                item2 = "-";
                item2amount = "0";
            }
            else
            {
                item2 = dt.Rows[0]["item2"].ToString();
                item2amount = dt.Rows[0]["item2amount"].ToString();
            }
            if (dt.Rows[0]["item3"].ToString() == "")
            {
                item3 = "-";
                item3amount = "0";
            }
            else
            {
                item3 = dt.Rows[0]["item3"].ToString();
                item3amount = dt.Rows[0]["item3amount"].ToString();
            }
            if (dt.Rows[0]["item4"].ToString() == "")
            {
                item4 = "-";
                item4amount = "0";
            }
            else
            {
                item4 = dt.Rows[0]["item4"].ToString();
                item4amount = dt.Rows[0]["item4amount"].ToString();
            }
            if (dt.Rows[0]["item5"].ToString() == "")
            {
                item5 = "-";
                item5amount = "0";
            }
            else
            {
                item5 = dt.Rows[0]["item5"].ToString();
                item5amount = dt.Rows[0]["item5amount"].ToString();
            }


            da = new SqlDataAdapter("Select * From Products where name='" + item1 + "'", con2);
            dt.Clear();
            con2.Open();
            da.Fill(dt);
            lblPrdPrice1.Text = dt.Rows[0]["price"].ToString();


            da = new SqlDataAdapter("Select * From Products where name='" + item2 + "'", con2);
            dt.Clear();
            da.Fill(dt);
            lblPrdPrice2.Text = dt.Rows[0]["price"].ToString();

            da = new SqlDataAdapter("Select * From Products where name='" + item3 + "'", con2);
            dt.Clear();
            da.Fill(dt);
            lblPrdPrice3.Text = dt.Rows[0]["price"].ToString();

            da = new SqlDataAdapter("Select * From Products where name='" + item4 + "'", con2);
            dt.Clear();
            da.Fill(dt);
            lblPrdPrice4.Text = dt.Rows[0]["price"].ToString();

            da = new SqlDataAdapter("Select * From Products where name='" + item5 + "'", con2);
            dt.Clear();
            da.Fill(dt);
            lblPrdPrice5.Text = dt.Rows[0]["price"].ToString();

            con2.Close();



            lblPrdName1.Text = item1;
            lblPrdName2.Text = item2;
            lblPrdName3.Text = item3;
            lblPrdName4.Text = item4;
            lblPrdName5.Text = item5;
            nupPrdQuantity1.Value = Convert.ToInt32(item1amount);
            nupPrdQuantity2.Value = Convert.ToInt32(item2amount);
            nupPrdQuantity3.Value = Convert.ToInt32(item3amount);
            nupPrdQuantity4.Value = Convert.ToInt32(item4amount);
            nupPrdQuantity5.Value = Convert.ToInt32(item5amount);

       
            TotalPriceChange();
           

        }


        public void TotalPriceChange(){

           int at = Convert.ToInt32(lblPrdPrice1.Text) * Convert.ToInt32(item1amount) +
                            Convert.ToInt32(lblPrdPrice2.Text) * Convert.ToInt32(item2amount) +
                            Convert.ToInt32(lblPrdPrice3.Text) * Convert.ToInt32(item3amount) +
                            Convert.ToInt32(lblPrdPrice4.Text) * Convert.ToInt32(item4amount) +
                            Convert.ToInt32(lblPrdPrice5.Text) * Convert.ToInt32(item5amount);

            lblTotalPrice.Text = "Total:" + at.ToString() + "₺";
        }



        private void msMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSipariş_Click(object sender, EventArgs e) {
            Form orderScreen = new OrderScreen( current);
            this.Hide();
            orderScreen.ShowDialog();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e) {
            Form homepageScreen = new HomePageScreen(current);
            this.Hide();
            homepageScreen.ShowDialog();
            this.Close();
        }
    }
}
