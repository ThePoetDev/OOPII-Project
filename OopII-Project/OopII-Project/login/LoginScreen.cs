using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace OopII_Project {
    public partial class LoginScreen : Form {



        SqlDataReader dr;
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        SqlCommand command;

        public LoginScreen() {
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e) {
            if (usernameTextBox.Text != null || usernameTextBox.Text != null) {
                con = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a756f7_oopii;User Id=db_a756f7_oopii_admin;Password=Oop2project");
                da = new SqlDataAdapter("Select * From Customer Where Username='" + usernameTextBox.Text.Trim()
                    + "' and Password='" + passwordTextBox.Text.Trim() + "'", con);
                dt = new DataTable();
            }
            try {
                con.Open();
                da.Fill(dt);
                con.Close();

                if (dt.Rows.Count == 0) {
                    MessageBox.Show("Kayıtlı kullanıcı bulunamadı!", "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else {
                    Form homepageScreen = new HomePageScreen(usernameTextBox.Text);
                    this.Hide();
                    homepageScreen.ShowDialog();
                    this.Close();
                }


            }
            catch (Exception a) {
                MessageBox.Show(a.ToString());
            }







        }

        private void signupButton_Click(object sender, EventArgs e) {
            Form signup = new SignUp();
            signup.ShowDialog();
        }
    }
}
