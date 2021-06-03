using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OopII_Project {
    public partial class LoginScreen : Form {
        public LoginScreen() {
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e) {
            Form homepageScreen = new HomePageScreen();
            this.Hide();
            homepageScreen.ShowDialog();
            this.Close();
        }

        private void signupButton_Click(object sender, EventArgs e) {
            Form signup = new SignUp();
            signup.ShowDialog();
        }
    }
}
