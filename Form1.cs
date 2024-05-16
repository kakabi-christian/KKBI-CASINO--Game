using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JEUX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int a, b, c, move, wins, balance,loss ;

        private void btn_bit_Click(object sender, EventArgs e)
        {
            Ibl_casiino.Text = "casino";
            balance = 0;
            textBox1.Enabled = true;
            textBox1.Text = "";
            textBox1.BackColor = Color.White;
            textBox1.Focus();
            btn_play.Enabled = true;
            btn_play.Text = "play";
            Ibl_balance.Text = "Balance : $";

        }

        void Game_Result()
        {
            if (System.Convert.ToInt32(a & b) != c) 
            {
                wins++;
                Ibl_win.Text = "Wins :" + wins;
                balance += 2;
                Ibl_balance.Text = "Balance : $" + Convert.ToInt32(textBox1.Text) * balance;
                btn_play.Text = "Continue playing..";
                Ibl_casiino.Text = "you won";
            }

            
            
            else
            {
                Ibl_casiino.Text = "try again";
                loss++;
                Ibl_loss.Text = "Loss :"+loss;
                Ibl_balance.Text = "Balance : $ 0";
                balance = 0;
                textBox1.Text = "";
                btn_play.Enabled = false;
                pictureBox1.Image = Properties.Resources.dollar;
                pictureBox2.Image = Properties.Resources.dollar;
                pictureBox3.Image = Properties.Resources.dollar;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move++;
            if(move<30)
            {

                a = rnd.Next(5);
                b = rnd.Next(5);
                c = rnd.Next(5);

                switch (a)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.Silver;
                        break;

                    case 3:
                        pictureBox1  .Image = Properties.Resources.Bronze;
                          break;
                }

                switch (b)
                {
                    case 1:
                        pictureBox2.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.Silver;
                        break;

                    case 3:
                        pictureBox2.Image = Properties.Resources.Bronze;
                        break;
                }
                switch (c)
                {
                    case 1:
                        pictureBox3.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox3.Image = Properties.Resources.Silver;
                        break;

                    case 3:
                        pictureBox3.Image = Properties.Resources.Bronze;
                        break;
                }
            }
            else
            {

              
                timer1.Enabled = false;
                move = 0;
                Game_Result();
            }


              
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter the bid Amount inside the textbox to play..");
            }
            else
            {
                timer1.Enabled = true;
                Ibl_casiino.Text = "Casino";
                textBox1.Enabled = false;
                textBox1.BackColor = Color.Black;
            }
        }
    }
}
