using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace happy_bird_game
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipeSpeed = 6;
        int gameScore = 0;
        int lifeCount = 3;
        int lifeFreeTime = 0;

        System.Media.SoundPlayer die = new System.Media.SoundPlayer();
        System.Media.SoundPlayer point = new System.Media.SoundPlayer();
        System.Media.SoundPlayer flap = new System.Media.SoundPlayer();
        System.Media.SoundPlayer swoosh = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            die.SoundLocation = "die.wav";
            point.SoundLocation = "point.wav";
            flap.SoundLocation = "flap.wav";
            swoosh.SoundLocation = "swoosh.wav";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void gameTimeTickEvent(object sender, EventArgs e)
        {
            birdFadingEffect();

            lifeFreeTime += 20;
            bird.Top += gravity;
            pipe_bottom.Left -= pipeSpeed;
            pipe_top.Left -= pipeSpeed;
            exlife.Left -= pipeSpeed;


            if(pipe_bottom.Left < -150)
            {
                pipe_bottom.Left = 650;
                gameScore++;
                point.Play();
            }
            if (pipe_top.Left < -80)
            {
                pipe_top.Left = 850;
                gameScore ++;
                point.Play();
            }

            if(bird.Bounds.IntersectsWith(pipe_top.Bounds)|| bird.Bounds.IntersectsWith(pipe_bottom.Bounds)|| bird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            if (bird.Bounds.IntersectsWith(exlife.Bounds) && lifeCount <3 )
            {
                extraLifeFunction();
              
            }
            if(exlife.Left < -10)
            {
                exlife.Left = 1000;
            }

            if(lifeCount == 1)
            {
                life1.Visible = true;
            }


            if (lifeCount == 2)
            {
                life2.Visible = true;
            }


            if (lifeCount == 3)
            {
                life3.Visible = true;
            }

            score_lbl.Text = "Score : " + gameScore;
        }

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void endGame()
        {
            if (lifeCount == 0 && lifeFreeTime > 3000)
            {
                game_time.Stop();
                gameOverLabel.Text = "Game Over!!\nYour Score is : " + gameScore;
                gameOverLabel.Visible = true;
                die.Play();
            }
            else
            {
                switch(lifeCount)
                {
                   case 3:
                        if (lifeFreeTime > 2500)
                        {
                            life3.Visible = false;
                            lifeCount--;
                            lifeFreeTime = 0;
                            flap.Play();
                        }
                     
                     break;
                    case 2:
                        if (lifeFreeTime > 2500)
                        {
                            life2.Visible = false;
                            lifeCount--;
                            lifeFreeTime = 0;
                            flap.Play();
                        }

                        break;
                    case 1:
                        if (lifeFreeTime > 2500)
                        {
                            life1.Visible = false;
                            lifeCount--;
                            lifeFreeTime = 0;
                            flap.Play();
                        }
                        break;
                }

            }
        }

        private void birdFadingEffect()
        {
            if(bird.Visible == true && lifeFreeTime < 2500)
            {
                bird.Visible = false;
            }else if(bird.Visible == false && lifeFreeTime <2500)
            {
                bird.Visible = true;
            }
            else
            {
                bird.Visible = true;
            }
        }

        private void extraLifeFunction()
        {
            if(lifeCount <3)
            {
                lifeCount++;
                exlife.Left= 10000; 
                swoosh.Play();
            }
            
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
