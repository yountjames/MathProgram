using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace math_program
{
    static class RecordLog
    {
        public static void Record(int topmin, int topmax, int botmin, int botmax, string function, int highstreak, string filepath)
        {
            string timestamp = DateTime.Now.ToString("MMM d yyyy  HH:mm tt");
            string filePath = @filepath; //adjust path as necessary
            List<string> lines = new List<string>();

            if (filepath == null) { }
            else
            {
                lines = File.ReadAllLines(filePath).ToList();
                lines.Add(timestamp + "     Settings:  " + function + "      Top (" + topmin + "-" + topmax + ")  Bottom (" + botmin + "-" + botmax + ")" + "      Best streak: " + highstreak);
                File.WriteAllLines(filePath, lines);
            }
        }
    }
}
