using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Game.Models;
using Game.Api_Helper;

namespace Game
{
    public partial class Game : Form
    {
        Smile smile;
        int score = 0;
        int health = 3;

        public Game()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            gameOver();
        }

        private async void getSmileData()
        {
            string path = ApiRouter.smileRoute;

            try {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                Smile smile = ApiSmile.GetSmileData(HTTPMETHOD.Get);
                this.smile = smile;
                setImage();
                Console.WriteLine("***************************************");
                Console.WriteLine(smile.Solution);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }


        }

        private void setImage()
        {
            this.imgView.Load(smile.Question.ToString());
        }

        //Check user Answer
        private void checkUserAnswer() {
            long userSolution = Convert.ToInt64(solutionPicker.Value);
            solutionPicker.Value = 0;
            if (this.smile.Solution == userSolution)
            {
                score += 10;
                DialogResult res = MessageBox.Show("+++++ You Won!!! +++++", "Congratulations!!", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (res == DialogResult.OK)
                {
                    scoreLB.Text = this.score.ToString();
                   getSmileData();
                }
            }
            else
            {
                health -= 1;

                DialogResult res = MessageBox.Show("!!!!! Incorrect answer !!!!", "Ohhhhh!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.Cancel)
                {
                    gameOver();
                }
            }
        }

        //Check Health of User
        private bool checkHealth()
        {
            switch (this.health) {
                case 0:
                    health1.Visible = true;
                    health2.Visible = true;
                    health3.Visible = true;
                    break;
                case 1:
                    health2.Visible = false;
                    health3.Visible = false;
                    break;
                case 2:
                    health3.Visible = false;
                    break;
                default:
                    health1.Visible = true;
                    health2.Visible = true;
                    health3.Visible = true;
                    break;
            }

            return health == 0 ? false : true;
        }

        //Validate User try
        private void validateUserTry()
        {
            checkUserAnswer();

            switch (checkHealth()) {
                case true:
                    break;
                case false:
                    this.score = 0;
                    scoreLB.Text = "0";
                    DialogResult res = MessageBox.Show("!!!!! Game Over !!!!", "Game Over!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (res == DialogResult.OK)
                    {
                        gameOver();
                    }
                    break;
            }
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            validateUserTry();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            userLb.Text = "Hi " + UserModel.userName;
            getSmileData();
        }

        private void gameOver()
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
    }
}
