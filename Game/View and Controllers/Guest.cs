using Game.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }


        //Play Button
        private void btn1_Click(object sender, EventArgs e)
        {
            if (userNameTxt.Text == "")
            {
                MessageBox.Show("Nickname Required");

            }

            else
            {
                UserModel.userName = userNameTxt.Text;
                Game form2 = new Game();
                form2.Show();
                this.Hide();
            }

        }


        //Back Button
        private void btn2_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
            f2.Show();
            //Visible= false;
            this.Hide();
        }

    }

}
