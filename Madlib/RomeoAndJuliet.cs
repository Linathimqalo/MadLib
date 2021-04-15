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
    public partial class RomeoAndJuliet : Form
    {
        public RomeoAndJuliet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Many years ago in Verona, Italy, there were two families.\n\n" +

                "‘We are the "+ textBox3.Text +"s.’\n\n" +

                "‘We are the "+ textBox4.Text +"s.’\n\n" +

                "These families are always fighting. The "+ textBox4.Text +"s have a son, "+ textBox1.Text +". The "+ textBox3.Text +"s\n" +
                "have a daughter, "+ textBox2.Text +".\n\n" +

                "One night the "+ textBox3.Text +"s have a party and "+ textBox1.Text +" goes. He meets "+ textBox2.Text +" and they fall in\n" +
                "love. "+ textBox2.Text +"’s cousin, "+ textBox5.Text +", sees "+ textBox1.Text +" and is very angry.\n\n" +

                "‘He’s a "+ textBox4.Text +"! Get him!’\n\n" +

                "‘Oh "+ textBox1.Text +", why are you a "+ textBox4.Text +"?’\n\n" +

                ""+ textBox1.Text +" and "+ textBox2.Text +" talk and decide to get married.\n\n" +

                "They know that their families will be very angry so they go to Friar Lawrence and are\n" +
                "married in secret.\n\n" +

                "The next day, "+ textBox5.Text +" sees "+ textBox1.Text +". He is still angry with "+ textBox1.Text +" and wants to fight him.\n" +
                ""+ textBox1.Text +" doesn’t want to fight but his best friend, "+ textBox6.Text +", does.\n\n" +

                "‘If you won’t fight him, I will!’\n\n" +

                ""+ textBox6.Text +" fights "+ textBox5.Text +". "+ textBox5.Text +" kills "+ textBox6.Text +"! "+ textBox1.Text +" is so upset he fights "+ textBox5.Text +" and\n" +
                "kills him too!\n\n" +

                "The Prince of Verona is very angry and sends "+ textBox1.Text +" away. "+ textBox2.Text +" goes to Friar\n" +
                "Lawrence for help.\n\n" +

                "‘Here is a special drink. You will sleep for two days. Your family will think you are dead\n" +
                "but you will wake up. Then you and "+ textBox1.Text +" can be free together.’\n\n" +

                "Friar Lawrence sends "+ textBox1.Text +" a letter to tell him the plan. But "+ textBox1.Text +" doesn’t get the\n" +
                "message. He hears that "+ textBox2.Text +" is dead!\n\n" +

                ""+ textBox1.Text +" is so upset he buys some poison and goes to see "+ textBox2.Text +".\n\n" +

                "‘Now I will stay with you forever.’\n\n" +

                "Too late, "+ textBox2.Text +" wakes up! She sees what happened.\n\n" +

                "‘Oh no! You didn’t leave any poison for me but here is your knife.’\n\n" +

                ""+ textBox1.Text +" and "+ textBox2.Text +" are both dead. Friar Lawrence tells the "+ textBox3.Text +"s and "+ textBox4.Text +"s\n" +
                "what happened. They are so sad they agree not to fight any more.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stories stories = new Stories();
            this.Hide();
            stories.Show();
        }
    }
}
