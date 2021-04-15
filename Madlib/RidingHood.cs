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
    public partial class RidingHood : Form
    {
        public RidingHood()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Little "+ textBox3.Text +" Riding Hood\n\n"+
                "Little "+ textBox3.Text +" Riding Hood lived in the woods with her mother.\n" +
                "One day Little "+ textBox3.Text +" Riding Hood went to visit her "+ textBox2.Text +". She had a nice cake in her basket.\n\n" +
                "On her way Little "+ textBox3.Text +" Riding Hood met a "+ textBox1.Text +".\n" +
                "‘Hello!’ said the "+ textBox1.Text +". ‘Where are you going?’\n" +
                "‘I’m going to see "+ textBox2.Text +" up in a house behind those trees.’\n\n" +
                "The "+ textBox1.Text +" ran to "+ textBox2.Text +"’s house and ate "+ textBox2.Text +" up. He got into "+ textBox2.Text +"’s bed. A little\n" +
                "later, Little "+ textBox3.Text +" Riding Hood reached the house. She looked at the "+ textBox1.Text +".\n\n" +
                "‘"+ textBox2.Text +", what big eyes you have!’\n" +
                "‘All the better to see you with!’ said the "+ textBox1.Text +".\n\n" +
                "‘"+ textBox2.Text +", what big ears you have!’\n" +
                "‘All the better to hear you with!’ said the "+ textBox1.Text +".\n\n" +
                "‘"+ textBox2.Text +", what a big nose you have!’\n" +
                "‘All the better to smell you with!’ said the "+ textBox1.Text +".\n\n" +
                "‘"+ textBox2.Text +", what big teeth you have!’\n" +
                "‘All the better to eat you with!’ shouted the "+ textBox1.Text +".\n\n" +
                "A woodcutter was in the woods. He heard a loud scream and ran to the house.\n\n" +
                "The woodcutter hit the "+ textBox1.Text +" over the head. The "+ textBox1.Text +" opened his mouth wide and shouted and "+ textBox2.Text +" jumped out.\n" +
                "The "+ textBox1.Text +" ran away and Little "+ textBox3.Text +" Riding Hood never saw the "+ textBox1.Text +" again.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stories stories = new Stories();
            this.Hide();
            stories.Show();
        }
    }
}
