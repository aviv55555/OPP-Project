using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProjOOP.Frontend.Forms
{
    public partial class MotorBikeGame : Form
    {
        int a = 590;
        int b = 90;
        int v = 7;
        public MotorBikeGame()
        {
            InitializeComponent();
        }

        private void buttonPlay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.M)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c://Users//Aviv0//Desktop//Projects//FINALPROJECTOOP//musicmotor.wav");
                player.Play();
            }
            if (e.KeyChar == (char)Keys.S)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c://Users//Aviv0//Desktop//Projects//FINALPROJECTOOP//musicmotor.wav");
                player.Stop();
            }

            if (e.KeyChar == (char)Keys.W) //STRIGHT
            {
                b = b - v;
                Console.WriteLine("b=" + b);
                motorBikeP.Location = new Point(a, b);
            }
            if (e.KeyChar == (char)Keys.D) //LEFT
            {
                a -= v;
                Console.WriteLine("a=" + a);
                motorBikeP.Location = new Point(a, b);
            }
            if (e.KeyChar == (char)Keys.A) // RIGHT 
            {
                a += v;
                Console.WriteLine("a=" + a);
                motorBikeP.Location = new Point(a, b);
            }
            if (e.KeyChar == (char)Keys.X) // DOWN 
            {
                b += v;
                Console.WriteLine("b=" + b);
                motorBikeP.Location = new Point(a, b);
            }
            if ((b >= 45 && (a >= 388 && a <= 537)) || b <= -14 || a >= 600 || b >= 114)
            {
                motorBikeP.Visible = false;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c://Users//Aviv0//Desktop//Projects//FINALPROJECTOOP//crashCar.wav");
                player.Play();
                lostPictureBox.Visible = true;
                return;
            }
            if (a <= 1)//win
            {
                winPictureBox.Visible = true;
                buttryP.Visible = false;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c://Users//Aviv0//Desktop//Projects//FINALPROJECTOOP//winning.wav");
                player.Play();
                return;
            }
            if ((a >= 289 && a <= 338) && (b <= 50)) // faster
            {
                buttryP.Visible = false;
                v = 30;
            }
            if ((b <= 60 && (a >= 130 && a <= 287)))
            {
                motorBikeP.Visible = false;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c://Users//Aviv0//Desktop//Projects//FINALPROJECTOOP//crashCar.wav");
                player.Play();
                lostPictureBox.Visible = true;
                return;
            }
        }
    }
}
