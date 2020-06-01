//#define debug

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_program
{
    public partial class Subtraction : Form
    {
        int numtop, numbot, streak;
        public int highstreak;
        public int topmax, botmax, topmin, botmin;
        public int menuflag = 2;
        public int mathexit;
        public bool exitflag = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public Subtraction(int aTopmin, int aTopmax, int aBotmin, int aBotmax)
        {

            topmin = aTopmin;
            topmax = aTopmax;
            botmin = aBotmin;
            botmax = aBotmax;

            Random rnd = new Random();
            numtop = rnd.Next(topmin, topmax);
            numbot = rnd.Next(botmin, botmax);

            if (numbot > numtop)
            {
                int temp;
                temp = numtop;
                numtop = numbot;
                numbot = temp;
            }

            streak = 0;
            InitializeComponent();
            label3.Text = numtop.ToString();
            label3.ForeColor = Color.Blue;
            label4.Text = "- " + numbot.ToString();
            label4.ForeColor = Color.Blue;
            label5.Text = streak.ToString();
            label5.ForeColor = Color.Red;
            button1.ForeColor = Color.Blue;
            label1.Hide();
            label6.Hide();
            //textBox3.Text = "Hello World";
            #if debug
            {
                label6.Show();
                label6.Text = (numtop - numbot).ToString();
            }
            #endif
        }

        private void Subtraction_Load(object sender, EventArgs e)
        {
            exitflag = true;
            mathexit = menuflag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                compute();
                Random rnd = new Random();
                numtop = rnd.Next(topmin, topmax);
                numbot = rnd.Next(botmin, botmax);

                if (numbot > numtop)
                {
                    int temp;
                    temp = numtop;
                    numtop = numbot;
                    numbot = temp;
                }

                label3.Text = numtop.ToString();
                label3.ForeColor = Color.Blue;
                label4.Text = "- " + numbot.ToString();
                label4.ForeColor = Color.Blue;
                textBox3.Text = "";
#if debug
            {
                textBox3.Text = (numtop - numbot).ToString();
                label6.Show();
                label6.Text = (numtop - numbot).ToString();
            }
#endif
            }
            catch { textBox3.Text = "";}
        }
        public void compute()
        {
            int ans, entry;
            ans = numtop - numbot;
            entry = int.Parse(textBox3.Text);

#if debug
            {
                label1.Show();
                label1.Text = entry.ToString();
            }
#endif

            if (entry == ans)
            {
                streak++;
                label5.Text = streak.ToString();
                if (streak > highstreak) { highstreak = streak; }
            }
            else
            {
                streak = 0;
                label5.Text = streak.ToString();

                string filepath;
                int selection;
                int min, max;
                min = 0;
                max = 5;
                Random rnd = new Random();
                selection = rnd.Next(min, max);

                mp3player one = new mp3player();
                switch (selection)
                {


                    case 0:

                        one.stop();
                        filepath = @".\\fart1.mp3";
                        one.open(filepath);
                        Console.WriteLine(filepath);
                        one.play();
                        break;
                    case 1:

                        one.stop();
                        filepath = @".\\fart2.mp3";
                        one.open(filepath);
                        Console.WriteLine(filepath);
                        one.play();
                        break;
                    case 2:

                        one.stop();
                        filepath = @".\\fart3.mp3";
                        one.open(filepath);
                        Console.WriteLine(filepath);
                        one.play();
                        break;
                    case 3:

                        one.stop();
                        filepath = @".\\fart4.mp3";
                        one.open(filepath);
                        Console.WriteLine(filepath);
                        one.play();
                        break;
                    case 4:

                        one.stop();
                        filepath = @".\\fart5.mp3";
                        one.open(filepath);
                        Console.WriteLine(filepath);
                        one.play();
                        break;
                    case 5:
                        one.stop();
                        filepath = @".\\fart6.mp3";
                        one.open(filepath);
                        Console.WriteLine(filepath);
                        one.play();
                        break;
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuflag = 0;
            exitflag = false;
            this.Hide();
        }
    }
}
