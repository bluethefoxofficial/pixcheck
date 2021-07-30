using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixcheck
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening in browser dont worry you can return to pixcheck at anytime the application has not been closed.");
            Process.Start("https://paypal.me/bluethefox");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    Properties.Settings.Default.welcome = false;
                    Properties.Settings.Default.Save();
                }

                this.Close();
            }
            catch
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Typesofpixels().ShowDialog();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
