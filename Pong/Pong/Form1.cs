using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    //920 x 1080 
    public partial class Form1 : Form
    {
        int vspeed = 5;
        int hspeed = 5;
        Label[] score = new Label[14];
        int tripointcol = 0;
        int tripointbat = 0;
        int tripointball = 0;
        int myscore = 0;
        int aiscore = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Rbat_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && Lbat.Top >= topBar.Bottom)
            {
                Lbat.Top -= 30;
            }
            else if (e.KeyCode == Keys.S && Lbat.Bottom <= botBar.Top)
            {
                Lbat.Top += 30;
            }
        }

        private void TMRup_Tick(object sender, EventArgs e)
        {
            ball.Top += vspeed;
            ball.Left += hspeed;
            if ( ball.Right >= Form1.ActiveForm.Right | HitBat() == true | HitRbat() == true)
            {
                hspeed *= -1;
                

            }
            if (ball.Top <= topBar.Bottom | ball.Top >= botBar.Top)
            {
                vspeed *= -1;
                tripointball = ball.Top;
                //TriCol.Top = ball.Top;
            }
            if (ball.Left < 0)
            {
                ball.Left = 960;
                aiscore += 1;
                Random rnd = new Random();
                ball.Top = rnd.Next(1, 600) + 240;
                scoredisplay(ScoreString(aiscore), 7);
                hspeed *= -1;

            }

        }

        

        

        bool HitBat()
        {
            //collision if statement
            if (ball.Left >= Lbat.Left + Lbat.Width / 2 & ball.Left <= Lbat.Right & ball.Top + ball.Height / 2 >= Lbat.Top & ball.Top + ball.Height / 2 <= Lbat.Bottom)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        bool HitRbat()
        {
            if (ball.Right <= Rbat.Left + Rbat.Width / 2 & ball.Right >= Rbat.Left & ball.Top + ball.Height / 2 <= Rbat.Top & ball.Top<= Rbat.Bottom)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int pos = 40;
            TMRup.Enabled = true;
            TMRai.Enabled = true;
            int vPos = 0;
            int hPos = 50;

            for (int i = 0; i < 7; i += 3)
            {
                score[i] = new Label();
                score[i].Top = 75 + vPos;
                vPos += 63;
                score[i].Width = 50;
                score[i].Height = 10;
                score[i].Left = Form1.ActiveForm.Width / 2 - 100;
                score[i].BackColor = Color.White;
                Controls.Add(score[i]);
            }
            vPos = 0;
            for (int i = 7; i < 14; i += 3)
            {
                score[i] = new Label();
                score[i].Top = 75 + vPos;
                vPos += 63;
                score[i].Width = 50;
                score[i].Height = 10;
                score[i].Left = Form1.ActiveForm.Width / 2 + 50;
                score[i].BackColor = Color.White;
                Controls.Add(score[i]);
            }
            vPos = 85;
            for (int i = 1; i < 5; i += 3)
            {
                score[i] = new Label();
                score[i].Top = 0 + vPos;
                // vPos += 60;
                score[i].Width = 10;
                score[i].Height = 50;
                score[i].Left = Form1.ActiveForm.Width / 2 - hPos;
                hPos += 60;
                score[i].BackColor = Color.White;
                Controls.Add(score[i]);
            }
            hPos = 50;
            for (int i = 2; i < 6; i += 3)
            {
                score[i] = new Label();
                score[i].Top = 150;
                // vPos += 60;
                score[i].Width = 10;
                score[i].Height = 50;
                score[i].Left = Form1.ActiveForm.Width / 2 - hPos;
                hPos += 60;
                score[i].BackColor = Color.White;
                Controls.Add(score[i]);
            }
            hPos = 40;
            for (int i = 8; i < 12; i += 3)
            {
                score[i] = new Label();
                score[i].Top = 85;
                // vPos += 60;
                score[i].Width = 10;
                score[i].Height = 50;
                score[i].Left = Form1.ActiveForm.Width / 2 + hPos;
                hPos += 60;
                score[i].BackColor = Color.White;
                Controls.Add(score[i]);
            }
            hPos = 40;
            for (int i = 9; i < 13; i += 3)
            {
                score[i] = new Label();
                score[i].Top = 150;
                // vPos += 60;
                score[i].Width = 10;
                score[i].Height = 50;
                score[i].Left = Form1.ActiveForm.Width / 2 + hPos;
                hPos += 60;
                score[i].BackColor = Color.White;
                Controls.Add(score[i]);

            }

            scoredisplay(ScoreString(myscore), 0);
            scoredisplay(ScoreString(aiscore), 7);


        }

        private void TMRai_Tick(object sender, EventArgs e)

        {
            //BallTrack.Visible = false;

            int aivspeed = 0;
            int ballx = ball.Location.X;
            int bally = ball.Location.Y;
            int balltrky = BallTrack.Location.Y;
            
            if (ballx >= 900)
            {
                if (balltrky >= 513)
                {
                    //up
                    bool moveup = true;
                    while (moveup == true)
                    {
                        if (Rbat.Top == BallTrack.Top)
                        {
                            moveup = false;
                        }
                        Rbat.Top += 1;
                    }
                }
                else
                {
                    //down
                    bool movedown = true;
                    while (movedown == true)
                    {
                        if (Rbat.Top == BallTrack.Top)
                        {
                            movedown = false;
                        }
                        Rbat.Top -= 1;
                    }
                }
            }
            else
            {
                aivspeed = 0;
            }

            BallTrack.Top = ball.Top;
            
        }

        private string ScoreString(int actualscore)
        {
            string lines = "";
            switch (actualscore)
            {
                case (0):
                    lines = "1110111";
                    break;
                case (1):
                    lines = "0110000";
                    break;
                case (2):
                    lines = "1011101";
                    break;
                case (3):
                    lines = "1001111";
                    break;
                case (4):
                    lines = "0101110";
                    break;
                case (5):
                    lines = "1101011";
                    break;
                case (6):
                    lines = "1111011";
                    break;
                case (7):
                    lines = "1000110";
                    break;
                case (8):
                    lines = "1111111";
                    break;
                case (9):
                    lines = "1101111";
                    break;
                default:
                    lines = "1110111";
                    break;

            }
            return lines;
        }

        private void scoredisplay(string scores, int offset)
        {
            for (int i = 0; i < 7; i++)
            {
                if (scores[i].ToString() == "1")
                {
                    score[i + offset].Visible = true;
                }
                else
                {
                    score[i + offset].Visible = false;
                }

            }
        }


    }
}
