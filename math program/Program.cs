using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

//dragon

namespace math_program
{
    
    

    class Program
    {
        

        static int SW_SHOW = 5;
        static int SW_HIDE = 0;
        [STAThread]
        static void Main(string[] args)
        {
            IntPtr myWindow = GetConsoleWindow();
            ShowWindow(myWindow, SW_HIDE);
            //Console.Read();

            int selection;
            int highstreak = 0;
            int counter = 0;
            int mathexit = 0;
            
            bool exitflag = false;
            menu frm1 = new menu();
            
            frm1.ShowDialog();
            selection = frm1.menuchoice;
            exitflag = frm1.exitflag;


            while (exitflag == false)
            {
                switch (selection)
                {
                    case 0:
                        {

                            frm1.ShowDialog();
                            selection = frm1.menuchoice;
                            exitflag = frm1.exitflag;
                            break;
                        }

                    case 1:
                        {

                            addition frm2 = new addition(frm1.uppermin, frm1.uppermax, frm1.lowermin, frm1.lowermax);
                            frm2.ShowDialog();
                            selection = frm2.menuflag;
                            exitflag = frm2.exitflag;
                            mathexit = frm2.mathexit;
                            highstreak = frm2.highstreak;
                            counter = 0;
                            break;
                        }
                        

                    case 2:
                        {
                            Subtraction frm3 = new Subtraction(frm1.uppermin, frm1.uppermax, frm1.lowermin, frm1.lowermax);
                            frm3.ShowDialog();
                            selection = frm3.menuflag;
                            exitflag = frm3.exitflag;
                            mathexit = frm3.mathexit;
                            highstreak = frm3.highstreak;

                            counter = 0;
                            break;
                        }

                    case 3:
                        {
                            Multiplication frm4 = new Multiplication(frm1.uppermin, frm1.uppermax, frm1.lowermin, frm1.lowermax);
                            frm4.ShowDialog();
                            selection = frm4.menuflag;
                            exitflag = frm4.exitflag;
                            mathexit = frm4.mathexit;
                            highstreak = frm4.highstreak;


                            counter = 0;
                            break;
                        }

                    case 4:
                        {
                            Division frm5 = new Division(frm1.uppermin, frm1.uppermax, frm1.lowermin, frm1.lowermax);
                            frm5.ShowDialog();
                            selection = frm5.menuflag;
                            exitflag = frm5.exitflag;
                            mathexit = frm5.mathexit;
                            highstreak = frm5.highstreak;


                            counter = 0;
                            break;
                        }

                }
                int topmin, topmax, botmin, botmax;
                string filepath;
                topmin = frm1.uppermin;
                topmax = frm1.uppermax;
                botmin = frm1.lowermin;
                botmax = frm1.lowermax;
                filepath = frm1.filepath;


                if (mathexit ==1 && counter <1)
                {
                    string function = "ADDITION      ";
                    RecordLog.Record(topmin, topmax, botmin, botmax, function, highstreak, filepath);
                    counter++;  
                }

                else if (mathexit == 2 && counter < 1)
                {
                    string function = "SUBTRACTION   ";
                    RecordLog.Record(topmin, topmax, botmin, botmax, function, highstreak, filepath);
                    counter++;

                }

                else if (mathexit == 3 && counter < 1)
                {
                    string function = "MULTIPLICATION";
                    RecordLog.Record(topmin, topmax, botmin, botmax, function, highstreak, filepath);
                    counter++;

                }

                else if (mathexit == 4 && counter < 1)
                {
                    string function = "DIVISION      ";
                    RecordLog.Record(topmin, topmax, botmin, botmax, function, highstreak, filepath);
                    counter++;

                }
                else { }

            }
            //Console.ReadLine();
        }

        //part of code to hide console
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
    }
}
