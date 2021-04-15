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
    public partial class Stories : Form
    {
        public Stories()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                RidingHood ridingHood = new RidingHood();
                this.Hide();
                ridingHood.Show();
            }
            else if (radioButton2.Checked == true)
            {
                ThreeLittlePigs threeLittlePigs = new ThreeLittlePigs();
                this.Hide();
                threeLittlePigs.Show();
            }
            else if (radioButton3.Checked == true)
            {
                GoldilocksAndTheThreeBears goldilocksAndTheThreeBears = new GoldilocksAndTheThreeBears();
                this.Hide();
                goldilocksAndTheThreeBears.Show();
            }
            else if (radioButton4.Checked == true)
            {
                JackAndTheBeanStalk jackAndTheBeanStalk = new JackAndTheBeanStalk();
                this.Hide();
                jackAndTheBeanStalk.Show();
            }
            else if (radioButton5.Checked == true)
            {
                RomeoAndJuliet romeoAndJuliet = new RomeoAndJuliet();
                this.Hide();
                romeoAndJuliet.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
