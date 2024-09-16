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
    public partial class MarineGame1 : Form
    {
        int a = 0;
        int b = 195;
        public MarineGame1()
        {
            InitializeComponent();
        }

        private void buttonPlay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.M)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c://Users//Aviv0//Desktop//Projects//FINALPROJECTOOP//musicmarine.wav");
                player.Play();
            }
            if (e.KeyChar == (char)Keys.S)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c://Users//Aviv0//Desktop//Projects//FINALPROJECTOOP//musicmarine.wav");
                player.Stop();
            }

            if (e.KeyChar == (char)Keys.W) //STRIGHT
            {
                b = b - 6;
                Console.WriteLine("b=" + b);
                boatPanel.Location = new Point(a, b);
            }
            if (e.KeyChar == (char)Keys.D) //LEFT
            {
                a -= 6;
                Console.WriteLine("a=" + a);
                boatPanel.Location = new Point(a, b);
            }
            if (e.KeyChar == (char)Keys.A) // RIGHT 
            {
                a += 6;
                Console.WriteLine("a=" + a);
                boatPanel.Location = new Point(a, b);
            }
            if (e.KeyChar == (char)Keys.X) // DOWN 
            {
                b += 6;
                Console.WriteLine("b=" + b);
                boatPanel.Location = new Point(a, b);
            }
            if ((b <= 291 && (a >= 189 && a < 351)) || b <= 160 || a <= -10 || b >= 335)
            {
                boatPanel.Visible = false;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c://Users//Aviv0//Desktop//Projects//FINALPROJECTOOP//crashShip.wav");
                player.Play();
                lostPictureBox.Visible = true;
                return;
            }
            if (a >= 539)//win
            {
                winPictureBox.Visible = true;
                boatPanel.Visible = false;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c://Users//Aviv0//Desktop//Projects//FINALPROJECTOOP//winning.wav");
                player.Play();
                return;
            }
            if (((a >= -10 && a <= 9) || (a >= -45 && a <= 99)) && (b >= 261 && b <= 285))
            {
                TruserePanel.Visible = false;
                boatPanel.Width = 100;
                boatPanel.Height = 100;
            }
        }
    }
}
