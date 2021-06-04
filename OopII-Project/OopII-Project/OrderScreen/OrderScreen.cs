using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace OopII_Project {
    public partial class OrderScreen : Form {
        string current, item1, item2, price, isbn, author, publisher, page, amount;
        SqlDataReader dr;
        SqlConnection con, con2;
        SqlDataAdapter da,da2;
        DataTable dt,dt2;
        DataSet ds;
        SqlCommand command;

        public OrderScreen(string _current) {
            InitializeComponent();
            current = _current;
        }

        private void cancelButton1_Click(object sender, EventArgs e) {
            MessageBox.Show("This item already delivered or there's no such item.");
        }

        private void cancelButton2_Click(object sender, EventArgs e) {
            MessageBox.Show("This item already delivered or there's no such item.");
        }


        private void OrderScreen_Load(object sender, EventArgs e) {
            con = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a756f7_oopii;User Id=db_a756f7_oopii_admin;Password=Oop2project");
            da = new SqlDataAdapter("SELECT * FROM ShoppingCarts Where username='" + current + "'", con);
            dt = new DataTable();
            dt2 = new DataTable();
            con.Open();
            da.Fill(dt);
            item1 = dt.Rows[0]["item1"].ToString();
            item2 = dt.Rows[0]["item2"].ToString();
            orderNameLabel1.Text = item1;
            orderNameLabel2.Text = item2;

            dt.Clear();
            da = new SqlDataAdapter("SELECT * FROM Products Where name='" + item1 + "'", con);
            da2 = new SqlDataAdapter("SELECT * FROM ShoppingCarts Where username='" + current + "'", con);
            da.Fill(dt);
            da2.Fill(dt2);
            con.Close();

            try {
                price = dt.Rows[0]["price"].ToString();
                isbn = dt.Rows[0]["ISBN"].ToString();
                author = dt.Rows[0]["author"].ToString();
                publisher = dt.Rows[0]["publisher"].ToString();
                page = dt.Rows[0]["page"].ToString();
                amount = dt2.Rows[0]["item1amount"].ToString();


                contentLabel1.Text = "ISBN: " + isbn + Environment.NewLine + "Author: " + author + Environment.NewLine + "Publisher: " + publisher + Environment.NewLine + "Page: " + page;
                costLabel1.Text = "Cost: " + price + "x" + amount + "=" + (Int32.Parse(price) * Int32.Parse(amount));
                deliveryInformationLabel1.Text = "Delivered";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }

            con.Open();
            dt.Clear();
            da = new SqlDataAdapter("SELECT * FROM Products Where name='" + item2 + "'", con);
            da.Fill(dt);
            con.Close();

            try {
                price = dt.Rows[0]["price"].ToString();
                isbn = dt.Rows[0]["ISBN"].ToString();
                author = dt.Rows[0]["author"].ToString();
                publisher = dt.Rows[0]["publisher"].ToString();
                page = dt.Rows[0]["page"].ToString();
                amount = dt2.Rows[0]["item2amount"].ToString();

                contentLabel2.Text = "ISBN: " + isbn + Environment.NewLine + "Author: " + author + Environment.NewLine + "Publisher: " + publisher + Environment.NewLine + "Page: " + page;
                costLabel2.Text = "Cost: " + price + "x" + amount + "=" + (Int32.Parse(price) * Int32.Parse(amount));
                deliveryInformationLabel2.Text = "Delivered";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }



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
