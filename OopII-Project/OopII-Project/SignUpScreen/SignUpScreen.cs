using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace OopII_Project {
    public partial class SignUp : Form {
        public SignUp() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void SignUpScreen_Load(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void lblUsername_Click(object sender, EventArgs e) {

        }

        private void btnSignUp_Click(object sender, EventArgs e) {
            Customer newc = new Customer();
            if (tbName.Text.Length < 1 || tbEmail.Text.Length < 1 || tbUsername.Text.Length < 1 || tbPassword.Text.Length < 1 || tbAdress.Text.Length <1) {
                MessageBox.Show(" Please fill all the fields.");
            }
            else {
                newc.Name = tbName.Text.ToString();
                newc.Email = tbEmail.Text.ToString();
                newc.Username = tbUsername.Text.ToString();
                newc.Password = tbPassword.Text.ToString();
                newc.Address = tbAdress.Text.ToString();

                SqlConnection con = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a756f7_oopii;User Id=db_a756f7_oopii_admin;Password=Oop2project");
                SqlConnection con2 = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a756f7_oopii;User Id=db_a756f7_oopii_admin;Password=Oop2project");
             
                if (con.State == ConnectionState.Closed) {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Customer Where username='" + newc.Username + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        MessageBox.Show("Username in use.. Choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        con2.Open();
                        string command = "insert into Customer(Name,Adress,Email,Username,Password) values (@name,@adress,@email,@username,@password)";
                        SqlCommand com = new SqlCommand(command, con2);
                        com.Parameters.AddWithValue("@name", newc.Name);
                        com.Parameters.AddWithValue("@adress", newc.Address);
                        com.Parameters.AddWithValue("@email", newc.Email);
                        com.Parameters.AddWithValue("@username", newc.Username);
                        com.Parameters.AddWithValue("@password", newc.Password);
                        com.ExecuteNonQuery();

                        MessageBox.Show("Success", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        con2.Close();

                    }
                    this.Close();
                }
               
            }
        }
    }
}
