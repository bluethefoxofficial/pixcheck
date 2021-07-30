using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixcheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Hide();
        }
        int num;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left = Cursor.Position.X;
          
            pictureBox1.Top = Cursor.Position.Y;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Width--;
                pictureBox1.Width--;
                pictureBox1.Width--;

            }
            if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Width++;
                pictureBox1.Width++;
                pictureBox1.Width++;

            }
            if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Height++;
                pictureBox1.Height++;
                pictureBox1.Height++;
            }
            if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Height--;
                pictureBox1.Height--;
                pictureBox1.Height--;
            }
            if (e.KeyCode == Keys.R)
            {
                pictureBox1.BackColor = Color.Red;
            }
            if (e.KeyCode == Keys.G)
            {
                pictureBox1.BackColor = Color.Green;
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.H)
            {
                MessageBox.Show("Help box for Pixcheck and fix\nLeft arrow - make box wider\nRight arrow - make box thinner\nUp arrow - make box taller\nDown arrow - make box smaller\nR - set box colour to red\nG-set box colour to green\nB - set box color to blue\nW - set box to white\nEsc - Exit application\nQ - attempt repair \nO - repair frame counter\nH - help box\n A - autotest");
            }
            if (e.KeyCode == Keys.B)
            {
                pictureBox1.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.Delete)
            {
                MessageBox.Show("You cant delete the colour-box sorry :(");
            }
            if (e.KeyCode == Keys.A)
            {
                autotest();
            }
            if(e.KeyCode == Keys.Z)
            {
                autotestandfix();
            }
            if (e.KeyCode == Keys.W)
            {
                pictureBox1.BackColor = Color.White;
            }

            //Repair mode
            if (e.KeyCode == Keys.Q)
            {
                //label2.Show();
                label2.Text = "3";
                MessageBox.Show("REPAIR MODE THIS WILL CAUSE FLASHING YOU WILL HAVE 3 SECONDS TO LOOK AWAY IF YOU ARE AT RISK OF A SEIZURE.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Thread.Sleep(1000);
                label2.Text = "2";
                Thread.Sleep(1000);
            
                label2.Text = "1";
                Thread.Sleep(1000);
               // label2.Hide();
                timer2.Start();
                timer1.Stop();
                pictureBox1.Visible = false;
                pictureBox1.Hide();
                this.BackColor = Color.Red;
            }
            if (e.KeyCode == Keys.O)
            {
                if(pictureBox1.Visible == true)
                {

                }
                else
                {
                    label1.Visible = true;


                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

         
            if (this.BackColor == Color.Red)
            {
                this.BackColor = Color.Green;
            }
            else if (this.BackColor == Color.Green)
            {
                this.BackColor = Color.Blue;
            }
            else if (this.BackColor == Color.Blue)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.Magenta;
            }
            num++;
            label1.Text = num.ToString();
            if(num == 3601)
            {
                timer2.Stop();
                MessageBox.Show("REPAIR COMPLETE PLEASE CHECK TO SEE IF THE ISSUE IS RESOLVED IF NOT TRY AGAIN AND IF THE ISSUE ISNT GONE CALL THE MANUFACTURE.");
                MessageBox.Show("Pixcheck will now close.");
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Does something.
            pictureBox1.Hide();
            if (Properties.Settings.Default.welcome)
            {
                if (new Welcome().ShowDialog() == DialogResult.OK)
                {
                    Cursor.Hide();
                    timer1.Start();
                    pictureBox1.Show();
                }
                else
                {
                    Cursor.Hide();
                    timer1.Start();
                    pictureBox1.Show();
                }
            }
        

        }
        //
        // Autotest script
        //
        protected private void autotest()
        {
            int sleep = 500;
            MessageBox.Show("Autotest start Please follow the instructions carefully.");
            timer1.Stop();
            this.BackColor = Color.Black;
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(0,0);
            pictureBox1.Width = this.Width;
            pictureBox1.Height = 40;
            Thread.Sleep(sleep);
            MessageBox.Show("if you see a white bar on top and no other pixels are showing another colour then this part of the test is complete we will now do it for all 3 colours.");
            pictureBox1.BackColor = Color.Red;
            Thread.Sleep(sleep);
            MessageBox.Show("If you see a red bar with no issues then the screen is working properly when displaying that colour.");
            pictureBox1.BackColor = Color.Green;
            Thread.Sleep(sleep);
            MessageBox.Show("If you see a green bar with no issues then the screen is working properly when displaying that colour.");
            pictureBox1.BackColor = Color.Blue;
            Thread.Sleep(sleep);
            MessageBox.Show("If you see a blue bar with no issues then the screen is working properly when displaying that colour.");
            pictureBox1.Height = this.Height;
            pictureBox1.Width = 40;
            pictureBox1.BackColor = Color.White;
            Thread.Sleep(sleep);
            MessageBox.Show("if you see a white bar on the side and no other pixels are showing another colour then this part of the test is complete we will now do it for all 3 colours.");
            pictureBox1.BackColor = Color.Red;
            Thread.Sleep(sleep);
            MessageBox.Show("If you see a red bar with no issues then the screen is working properly when displaying that colour.");
            pictureBox1.BackColor = Color.Green;
            Thread.Sleep(sleep);
            MessageBox.Show("If you see a green bar with no issues then the screen is working properly when displaying that colour.");
            pictureBox1.BackColor = Color.Blue;
            Thread.Sleep(sleep);
            MessageBox.Show("If you see a blue bar with no issues then the screen is working properly when displaying that colour.");
            pictureBox1.BackColor = Color.White;
            Thread.Sleep(300);
            MessageBox.Show("move the square with your mouse and when youre done you can fix with Q or quit with escape, testing the whole screen with a mouse and press R to set it to red G to set it to green and B to get it to blue and W to set it to white to get help press H on your keyboard.");
            pictureBox1.Location = new Point(this.Width / 2, this.Height / 2);
            pictureBox1.Height = 40;
            //Cursor.Show();
            timer1.Start();
        }
        //
        // Autotest & fix script
        //
        protected private void autotestandfix()
        {
            //redundent.
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
        }
    }
}
