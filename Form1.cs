using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird
{
    public partial class Form1 : Form
    {
        int boruHızı = 8;
        int yercekimi = 7;
            
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += yercekimi;
            boruAlt.Left -= boruHızı;
            boruUst.Left -= boruHızı;
            scoreText.Text = "Score: " + score;
            if (boruAlt.Left<-150)
            {
                boruAlt.Left = 800;
                score++;
            }
            if (boruUst.Left < -180)
            {
                boruAlt.Left = 950;
                score++;
            }
            if (flappyBird.Bounds.IntersectsWith(boruAlt.Bounds) || flappyBird.Bounds.IntersectsWith(boruUst.Bounds) || flappyBird.Bounds.IntersectsWith(zemin.Bounds))
            {
                endGame();
            }
            if (flappyBird.Top<-20)
            {
                endGame();
            }

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                yercekimi = -7;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yercekimi = 7;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game Over !!!";
        }

        private void boruUst_Click(object sender, EventArgs e)
        {

        }
    }
}
