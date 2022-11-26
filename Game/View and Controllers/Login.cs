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
using System.Data.Sql;
using Game.Models;
using Game.Connetion_Helper;

namespace Game
{
    public partial class Login : Form
    {

        LoginClient client = new LoginClient();
        
        public Login()
        {
            InitializeComponent();
        }
        
        //Login Button> Defualt Login----(un-Admin pw-Admin@123)
        private void btn1_Click(object sender, EventArgs e)
        {
            if (validateFormData())
            {
                String userName, password;

                userName = txt1.Text;
                password = txt2.Text;
                loginUser(userName, password);
            }
        }

        private void loginUser(String userName, String password)
        {
            try
            {
                Response r = client.loginToAccount(userName, password);
                if (r.Status == true)
                {
                    //MessageBox.Show(r.Message);
                    UserModel.userName = userName;
                    cleanForm();
                    directToGameForm();
                }
                else
                {
                    MessageBox.Show(r.Message);
                    cleanForm();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Failed to create account");
                cleanForm();
            }
        }

        //Validation
        private bool validateFormData()
        {
            if (txt1.Text == "")
            {
                MessageBox.Show("Username Required");
                return false;
            }

            if (txt2.Text == "")
            {
                MessageBox.Show("Password Required");
                return false;
            }

            return true;
        }

        // Exit Button
        private void btn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        // Create new account Button
        private void btn3_Click(object sender, EventArgs e)
        {
            Createnew form2 = new Createnew();
            form2.Show();
            this.Hide();
        }
        
        //Guest login Button
        private void btn4_Click(object sender, EventArgs e)
        {
            Guest form2 = new Guest();
            form2.Show();
            this.Hide();
        }

        //Next Form(Game)
        private void directToGameForm()
        {
            Game form2 = new Game();
            form2.Show();
            this.Hide();
        }

        //Clean Form
        private void cleanForm()
        {
            txt1.Clear();
            txt2.Clear();
        }

    }

}
