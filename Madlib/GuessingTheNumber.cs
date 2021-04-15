using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madlib
{
    public partial class GuessingTheNumber : Form
    {
        public GuessingTheNumber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EasyNumber easyNumber = new EasyNumber();
            this.Hide();
            easyNumber.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NormalNumber normalNumber = new NormalNumber();
            this.Hide();
            normalNumber.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HardNumber hardNumber = new HardNumber();
            this.Hide();
            hardNumber.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InsaneNumber insaneNumber = new InsaneNumber();
            this.Hide();
            insaneNumber.Show();
        }
    }
}
