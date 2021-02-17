using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            timer1.Start();
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
                MessageBox.Show("Help box for Pixcheck and fix\nLeft arrow - make box wider\nRight arrow - make box thinner\nUp arrow - make box taller\nDown arrow - make box smaller\nR - set box colour to red\nG-set box colour to green\nB - set box color to blue\nW - set box to white\nEsc - Exit application\nQ - attempt repair \nO - repair frame counter\nH - help box");
            }
            if (e.KeyCode == Keys.B)
            {
                pictureBox1.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.W)
            {
                pictureBox1.BackColor = Color.White;
            }
            if (e.KeyCode == Keys.Q)
            {
                MessageBox.Show("REPAIR MODE THIS WILL CAUSE FLASHING LOOK AWAY AFTER HITTING OK YOU HAVE BEEN WARNED", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(num == 360000000)
            {
                timer2.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
