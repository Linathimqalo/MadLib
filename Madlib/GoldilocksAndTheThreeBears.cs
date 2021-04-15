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
    public partial class GoldilocksAndTheThreeBears : Form
    {
        public GoldilocksAndTheThreeBears()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Once upon a time there was a little girl. Her name was Goldilocks. She" +
                "had golden hair.\n\n" +
                
                "One day Goldilocks was walking in the forest. She saw a house and" +
                "knocked on the door. She went inside. Nobody was there.\n\n" +
                
                "Goldilocks saw three bowls on the table. She was hungry.\n\n" +
                
                "‘This "+ textBox2.Text +" is too hot! This "+ textBox2.Text +" is too cold! This "+ textBox2.Text +" is just right!’ Goldilocks ate all the" +
                ""+ textBox2.Text +".\n\n" +
                
                "Goldilocks was tired now. ‘This "+ textBox3.Text +" is too big! This "+ textBox3.Text +" is too big, too! This "+ textBox3.Text +" is just right!’ But the" +
                ""+ textBox3.Text +" broke!\n\n" +
                
                "Goldilocks was very tired. She went upstairs. ‘This "+ textBox4.Text +" is too hard! This "+ textBox4.Text +" is too soft! This "+ textBox4.Text +" is just" +
                "right!’\n\n" +
                
                "Soon, the "+ textBox1.Text +"s came home.\n\n" +
                
                "‘Someone’s been eating my "+ textBox2.Text +"!’ said Daddy "+ textBox1.Text +".\n" +
                "‘Someone’s been eating my "+ textBox2.Text +"!’ said Mummy "+ textBox1.Text +".\n" +
                "‘Someone’s been eating my "+ textBox2.Text +" - and it’s all gone!’ said Baby "+ textBox1.Text +".\n\n" +
                
                "‘Someone’s been sitting on my "+ textBox3.Text +"!’ said Daddy "+ textBox1.Text +".\n" +
                "‘Someone’s been sitting on my "+ textBox3.Text +"!’ said Mummy "+ textBox1.Text +".\n" +
                "‘Someone’s been sitting on my "+ textBox3.Text +" - and it’s broken!’ said Baby "+ textBox1.Text +".\n\n" +

                "‘Someone’s been sleeping in my "+ textBox4.Text +"!’ said Daddy "+ textBox1.Text +".\n" +
                "‘Someone’s been sleeping in my "+ textBox4.Text +"!’ said Mummy "+ textBox1.Text +".\n" +
                "‘Someone’s been sleeping in my "+ textBox4.Text +" - and she’s still there!’ said Baby "+ textBox1.Text +".\n\n" +

                "Goldilocks woke up and saw the three "+ textBox1.Text +"s. ‘Help!’ She ran downstairs and into the forest. She never" +
                "came back again.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stories stories = new Stories();
            this.Hide();
            stories.Show();
        }
    }
}
