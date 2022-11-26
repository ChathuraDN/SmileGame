using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Game.Connetion_Helper;
using Game.Models;

namespace Game
{
    public partial class Createnew : Form
    {
        LoginClient client = new LoginClient();

        public Createnew()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (validaeFormData() == true) {
                createAccount(txt1.Text, txt2.Text, txt3.Text, txt4.Text);
            }
            
        }

        //Back Button(Direct to the Login form)
        private void btn2_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
            f2.Show();
            this.Hide();
        }

        //Create Account
        private void createAccount(String name, String userName, String password, String confirmPassword) {
            try
            {
                Response r = client.createAccount(name, userName, password, confirmPassword);
                if (r.Status == true) {
                    MessageBox.Show(r.Message);
                    cleanForm();
                    direcToLoginForm();
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Failed to create account");
                cleanForm();
            }

        }

        //Clean Form
        private void cleanForm() {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();

        }

        //Direct to Login Form
        private void direcToLoginForm() {
            Login form2 = new Login();
            form2.Show();
            this.Hide();
        }

        //Validate Form Data
        private bool validaeFormData() {
            if (txt1.Text == "")
            {
                MessageBox.Show("Name Required");
                return false;

            }
            
            if (txt2.Text == "")
            {
                MessageBox.Show("Username Required");
                return false;

            }

            if (txt3.Text == "")
            {
                MessageBox.Show("Password Required");
                return false;

            }

            if (txt4.Text == "")
            {
                MessageBox.Show("Retype the Password");
                return false;

            }

            return true;

        }
    }
}
