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
using System.IO;


namespace math_program
{
    public partial class menu : Form
    {
        public int menuchoice = 0;
        public string filepath;
        public bool resetfilelocation = false;
        public bool exitflag = false;
        public int uppermax, uppermin, lowermax, lowermin;
        public menu()
        {
            InitializeComponent();

            try
            {
                

                string directorypath = ".\\logpath.txt";
                string directory = File.ReadAllLines(directorypath).First();
                label17.Text = directory;
            }
            catch
            { }
            finally
            {

#if debug
                {
                    textBoxUpperMin.Text = "1";
                    textBoxUpperMax.Text = "100";
                    textBoxLowerMin.Text = "1";
                    textBoxLowerMax.Text = "100";
                }
#endif
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                uppermin = int.Parse(textBoxUpperMin.Text);
                uppermax = int.Parse(textBoxUpperMax.Text);
                lowermin = int.Parse(textBoxLowerMin.Text);
                lowermax = int.Parse(textBoxLowerMax.Text);

                string directorypath = ".\\logpath.txt";
                filepath = File.ReadAllLines(directorypath).First();
                label17.Text = filepath;


                if (lowermin < 0 || lowermax < lowermin || uppermax < uppermin)
                {
                    textBoxUpperMin.Text = "";
                    textBoxUpperMax.Text = "";
                    textBoxLowerMin.Text = "";
                    textBoxLowerMax.Text = "";

                }

                else
                {
                    menuchoice = 1;
                    exitflag = false;
                    this.Hide();
                }
            }
            catch(InvalidOperationException)
            {
                string title = "Noob Error";
                string message = "Check your parameters and make sure you have a path assigned for streak logs";
                MessageBox.Show(message, title);
            }
            catch
            {
                textBoxUpperMin.Text = "";
                textBoxUpperMax.Text = "";
                textBoxLowerMin.Text = "";
                textBoxLowerMax.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                uppermin = int.Parse(textBoxUpperMin.Text);
                uppermax = int.Parse(textBoxUpperMax.Text);
                lowermin = int.Parse(textBoxLowerMin.Text);
                lowermax = int.Parse(textBoxLowerMax.Text);

                string directorypath = ".\\logpath.txt";
                filepath = File.ReadAllLines(directorypath).First();
                label17.Text = filepath;


                if (lowermin < 0 || lowermax < lowermin || uppermax < uppermin)
                {
                    textBoxUpperMin.Text = "";
                    textBoxUpperMax.Text = "";
                    textBoxLowerMin.Text = "";
                    textBoxLowerMax.Text = "";

                }

                else
                {
                    menuchoice = 2;
                    exitflag = false;
                    this.Hide();
                }
            }
            catch (InvalidOperationException)
            {
                string title = "Noob Error";
                string message = "Check your parameters and make sure you have a path assigned for streak logs";
                MessageBox.Show(message, title);
            }
            catch
            {
                textBoxUpperMin.Text = "";
                textBoxUpperMax.Text = "";
                textBoxLowerMin.Text = "";
                textBoxLowerMax.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                uppermin = int.Parse(textBoxUpperMin.Text);
                uppermax = int.Parse(textBoxUpperMax.Text);
                lowermin = int.Parse(textBoxLowerMin.Text);
                lowermax = int.Parse(textBoxLowerMax.Text);

                string directorypath = ".\\logpath.txt";
                filepath = File.ReadAllLines(directorypath).First();
                label17.Text = filepath;


                if (lowermin < 0 || lowermax < lowermin || uppermax < uppermin)
                {
                    textBoxUpperMin.Text = "";
                    textBoxUpperMax.Text = "";
                    textBoxLowerMin.Text = "";
                    textBoxLowerMax.Text = "";

                }

                else
                {
                    menuchoice = 3;
                    exitflag = false;
                    this.Hide();
                }
            }
            catch (InvalidOperationException)
            {
                string title = "Noob Error";
                string message = "Check your parameters and make sure you have a path assigned for streak logs";
                MessageBox.Show(message, title);
            }
            catch
            {
                textBoxUpperMin.Text = "";
                textBoxUpperMax.Text = "";
                textBoxLowerMin.Text = "";
                textBoxLowerMax.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                uppermin = int.Parse(textBoxUpperMin.Text);
                uppermax = int.Parse(textBoxUpperMax.Text);
                lowermin = int.Parse(textBoxLowerMin.Text);
                lowermax = int.Parse(textBoxLowerMax.Text);

                string directorypath = ".\\logpath.txt";
                filepath = File.ReadAllLines(directorypath).First();
                label17.Text = filepath;


                if (lowermin < 1 || lowermax < lowermin || uppermax < uppermin)
                {
                    textBoxUpperMin.Text = "";
                    textBoxUpperMax.Text = "";
                    textBoxLowerMin.Text = "";
                    textBoxLowerMax.Text = "";

                }

                else
                {
                    menuchoice = 4;
                    exitflag = false;
                    this.Hide();
                }
            }
            catch (InvalidOperationException)
            {
                string title = "Noob Error";
                string message = "Check your parameters and make sure you have a path assigned for streak logs";
                MessageBox.Show(message, title);
            }
            catch
            {
                textBoxUpperMin.Text = "";
                textBoxUpperMax.Text = "";
                textBoxLowerMin.Text = "";
                textBoxLowerMax.Text = "";
            }
        }

        private void menu_Load(object sender, EventArgs e)
        {
            exitflag = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxLowerMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {

                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filepath = ofd.FileName;

                    label17.Text = filepath;
                    resetfilelocation = true;
                }
                else { resetfilelocation = false; }



                ///////test write to project folder

                
                string directorypath = ".\\logpath.txt"; 
                List<string> lines = new List<string>();

                
                
                
                    //lines = File.ReadAllLines(directorypath).ToList();
                    lines.Add(filepath);
                    File.WriteAllLines(directorypath, lines);
                
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
