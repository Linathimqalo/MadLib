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
    public partial class EasyNumber : Form
    {
        // class-level vars (field)
        const int highnum = 10; // highnum number
        int numguess;    // the number randomly generated that the user must guess
        int countup = 0; // counts time in seconds
        public EasyNumber()
        {
            InitializeComponent();
            label1.Text = TimeOutput(0); // show timer as 0
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create new random object
            Random random = new Random();

            // get a number between 1-highnum
            numguess = random.Next(1, highnum + 1);

            // adjust controls to start anew
            this.BackColor = Color.White;
            button2.Enabled = true;
            button1.Enabled = false;
            countup = 0;
            textBox1.Enabled = true;
            textBox1.Focus();
            textBox1.SelectAll();
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int guess;
            bool ok;
            try
            {
                // parse the input AND see if it is ok
                ok = int.TryParse(textBox1.Text, out guess);
                if (ok == true)
                {
                    // range check
                    if (guess > highnum || guess < 1)
                    {
                        MessageBox.Show("Guess is OUT OF RANGE. Guess must be between 1 and " + highnum);
                        textBox1.Clear();
                    }
                    // guess too big
                    else if (guess > numguess)
                    {
                        MessageBox.Show("Guess is too big. Smaller!");
                        textBox1.Clear();
                    }
                    // guess too small
                    else if (guess < numguess)
                    {
                        MessageBox.Show("Guess is too small. Bigger!");
                        textBox1.Clear();
                    }
                    // RIGHT!
                    else
                    {
                        // reset to play again
                        timer1.Enabled = false;
                        MessageBox.Show(numguess + " is CORRECT: " + TimeOutput(countup));
                        button2.Enabled = false;
                        textBox1.Clear();
                        textBox1.Enabled = false;
                        label1.Text = TimeOutput(0);
                        button1.Enabled = true;
                    }
                }
                // try parse fails
                else
                {
                    MessageBox.Show(textBox1.Text + " is the incorrect type.");
                }
            }
            catch (Exception ex)
            {
                // inform user of exception
                MessageBox.Show(ex.Message);
            }
        }
        private string TimeOutput(int secs)
        {
            string output;
            if (secs <= 59)
                output = "Seconds: " + secs;
            else
                output = "Minutes: " + secs / 60 + Environment.NewLine + "Seconds: " + secs % 60;
            return output;
            // throw new NotImplementedException();         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countup++; // seconds
            label1.Text = TimeOutput(countup);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GuessingTheNumber theNumber = new GuessingTheNumber();
            this.Hide();
            theNumber.Show();
        }
    }
}

