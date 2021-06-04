﻿using System;
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
            con = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a756f7_oopii;User Id=db_a756f7_oopii_admin;Password=Oop2project");
            con2 = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a756f7_oopii;User Id=db_a756f7_oopii_admin;Password=Oop2project");
            da = new SqlDataAdapter("Select * From ShoppingCarts Where Username='" + current + "'", con);
            dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            if(dt.Rows[0]["item1"].ToString() == "") {
                item1 = "-";
                item1amount = "0";
            }
            else {
                item1 = dt.Rows[0]["item1"].ToString();
                item1amount = dt.Rows[0]["item1amount"].ToString();
            }
            if (dt.Rows[0]["item2"].ToString() == "") {
                item2 = "-";
                item2amount = "0";
            }
            else {
                item2 = dt.Rows[0]["item2"].ToString();
                item2amount = dt.Rows[0]["item2amount"].ToString();
            }
            if (dt.Rows[0]["item3"].ToString() == "") {
                item3 = "-";
                item3amount = "0";
            }
            else {
                item3 = dt.Rows[0]["item3"].ToString();
                item3amount = dt.Rows[0]["item3amount"].ToString();
            }
            if (dt.Rows[0]["item4"].ToString() == "") {
                item4 = "-";
                item4amount = "0";
            }
            else {
                item4 = dt.Rows[0]["item4"].ToString();
                item4amount = dt.Rows[0]["item4amount"].ToString();
            }
            if (dt.Rows[0]["item5"].ToString() == "") {
                item5 = "-";
                item5amount = "0";
            }
            else {
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
