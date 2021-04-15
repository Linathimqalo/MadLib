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
    public partial class ThreeLittlePigs : Form
    {
        public ThreeLittlePigs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One "+ textBox2.Text +" built a house of "+ textBox3.Text +" while the second "+ textBox2.Text +" built his house with "+ textBox4.Text +"s.\n" +
                "They built their houses very quickly and then sang and danced all day because they were lazy.\n" +
                "The third little "+ textBox2.Text +" worked hard all day and built his house with "+ textBox5.Text +"s.\n\n" +
                
                "A big bad "+ textBox1.Text +" saw the two little "+ textBox2.Text +"s while they danced and played and thought,\n" +
                "“What juicy tender meals they will make!” He chased the two "+ textBox2.Text +"s and they ran and hid in their houses.\n" +
                "The big bad "+ textBox1.Text +" went to the first house and huffed and puffed and blew the house down in minutes.\n" +
                "The frightened little "+ textBox2.Text +" ran to the second "+ textBox2.Text +"’s house that was made of "+ textBox4.Text +"s.\n" +
                "The big bad "+ textBox1.Text +" now came to this house and huffed and puffed and blew the house down in hardly any time.\n" +
                "Now, the two little "+ textBox2.Text +"s were terrified and ran to the third "+ textBox2.Text +"’s house that was made of "+ textBox5.Text +"s.\n\n" +
                
                "The big bad "+ textBox1.Text +" tried to huff and puff and blow the house down, but he could not.\n" +
                "He kept trying for hours but the house was very strong and the little "+ textBox2.Text +"s were safe inside.\n" +
                "He tried to enter through the chimney but the third little "+ textBox2.Text +" boiled a big pot of water and kept it below the chimney.\n" +
                "The "+ textBox1.Text +" fell into it and died.\n\n" + 
                
                "The two little "+ textBox2.Text +"s now felt sorry for having been so lazy.\n" +
                "They too built their houses with "+ textBox5.Text +"s and lived happily ever after.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stories stories = new Stories();
            this.Hide();
            stories.Show();
        }
    }
}
