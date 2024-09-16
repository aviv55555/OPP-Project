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
    public partial class CarGame : Form
    {
        int a = 272;
        int b = 406;
        public CarGame()
        {
            InitializeComponent();
        }
        private void buttonPlay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.M)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c://Users//Aviv0//Desktop//Projects//FINALPROJECTOOP//musiccar.wav");
                player.Play();
            }
            if (e.KeyChar == (char)Keys.S)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c://Users//Aviv0//Desktop//Projects//FINALPROJECTOOP//musiccar.wav");
                player.Stop();
            }

            if (e.KeyChar == (char)Keys.W) //STRIGHT
            {
                b = b - 5;
                Console.WriteLine("b=" + b);
                carPanel.Location = new Point(a, b);
            }
            if (e.KeyChar == (char)Keys.D) //LEFT
            {
                a -= 5;
                Console.WriteLine("a=" + a);
                carPanel.Location = new Point(a, b);
            }
            if (e.KeyChar == (char)Keys.A) // RIGHT 
            {
                a += 5;
                Console.WriteLine("a=" + a);
                carPanel.Location = new Point(a, b);
            }
            if (e.KeyChar == (char)Keys.X) // DOWN 
            {
                b += 5;
                Console.WriteLine("b=" + b);
                carPanel.Location = new Point(a, b);
            }
            if ((b >= 241 && b <= 370) && (a >= 208 && a < 327) || a <= 229 || a >= 381)
            {
                carPanel.Visible = false;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c://Users//Aviv0//Desktop//Projects//FINALPROJECTOOP//crashCar.wav");
                player.Play();
                lostPictureBox.Visible = true;
                return;
            }
            if (b <= 0)
            {
                winPictureBox.Visible = true;
                carPanel.Visible = false;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c://Users//Aviv0//Desktop//Projects//FINALPROJECTOOP//winning.wav");
                player.Play();
                return;
            }
            if ((a >= 250 && a <= 296) && (b >= 200 && b <= 245))
            {
                plusPictureBox.Visible = false;
                carPanel.Width = 60;
                carPanel.Height = 60;
            }
            if ((b >= 39 && b <= 99) && (a >= 254 && a < 360) || a <= 229 || a >= 381)
            {
                carPanel.Visible = false;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c://Users//Aviv0//Desktop//Projects//FINALPROJECTOOP//crashCar.wav");
                player.Play();
                lostPictureBox.Visible = true;
                return;
            }
        }
    }
}
