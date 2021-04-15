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
    public partial class JackAndTheBeanStalk : Form
    {
        public JackAndTheBeanStalk()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = textBox1.Text + " and the " + textBox2.Text;
            MessageBox.Show("Once upon a time there was a boy called "+ textBox1.Text +". He lived with his\n" +
                "mother. They were very poor. All they had was a "+ textBox3.Text +".\n\n" +

                "One morning, "+ textBox1.Text +"’s mother told "+ textBox1.Text +" to take their "+ textBox3.Text +" to market\n" +
                "and sell her. On the way, "+ textBox1.Text +" met a man. He gave "+ textBox1.Text +" some magic\n" +
                ""+ textBox2.Text +"s for the "+ textBox3.Text +".\n\n" +

                ""+ textBox1.Text +" took the "+ textBox2.Text +"s and went back home. When "+ textBox1.Text +"’s mother saw the "+ textBox2.Text +"s she was very angry.\n" +
                "She threw the "+ textBox2.Text +"s out of the window.\n\n" +

                "The next morning, "+ textBox1.Text +" looked out of the window. There was a giant "+ textBox2.Text +"stalk. He went outside and\n" +
                "started to climb the "+ textBox2.Text +"stalk.\n\n" +

                "He climbed up to the sky through the clouds. "+ textBox1.Text +" saw a beautiful castle. He went inside.\n\n" +

                ""+ textBox1.Text +" heard a voice. ‘Fee, fi, fo, fum!’ "+ textBox1.Text +" ran into a cupboard.\n\n" +

                "An enormous giant came into the room and sat down. On the table there was a "+ textBox4.Text +" and a golden\n" +
                ""+ textBox5.Text +".\n\n" +

                "‘Lay!’ said the giant. The "+ textBox4.Text +" laid an egg. It was made of gold. ‘Sing!’ said the giant. The "+ textBox5.Text +" began to\n" + 
                "sing. Soon the giant was asleep.\n\n" +

                ""+ textBox1.Text +" jumped out of the cupboard. He took the "+ textBox4.Text +" and the "+ textBox5.Text +". Suddenly, the "+ textBox5.Text +" sang, ‘Help,\n" +
                "master!’\n\n" +

                "The giant woke up and shouted, ‘Fee, fi, fo, fum!’ "+ textBox1.Text +" ran and started climbing down the "+ textBox2.Text +"stalk.\n" +
                "The giant came down after him.\n\n" +

                ""+ textBox1.Text +" shouted, ‘Mother! Help!’ "+ textBox1.Text +"’s mother took an axe and chopped down the "+ textBox2.Text +"stalk. The giant\n" +
                "fell and crashed to the ground. Nobody ever saw him again.\n\n" +

                "With the golden eggs and the magic "+ textBox5.Text +", "+ textBox1.Text +" and his mother lived happily ever after.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stories stories = new Stories();
            this.Hide();
            stories.Show();
        }
    }
}
