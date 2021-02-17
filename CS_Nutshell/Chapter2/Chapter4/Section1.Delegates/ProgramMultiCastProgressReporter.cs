using System;
using System.Collections.Generic;
using System.Text;

namespace Section1.Delegates
{
    public delegate void ProgressReporter(int percentComplete);


    class ProgramMultiCastProgressReporter
    {

        static void Main(string[] args)
        {
            ProgressReporter p = WriteProgressToConsole;
            p += WriteProgressToFile;
            Utilities.HardWork(p);

        }


        static void WriteProgressToConsole(int percentComplete)
        {
            Console.WriteLine(percentComplete);
        }

        static void WriteProgressToFile(int percentComplete)
        {
            System.IO.File.AppendAllText("progress.txt", percentComplete.ToString()+ "\n");
        }


    }


    public class Utilities
    {
        public static void HardWork(ProgressReporter p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10);                           // Invoke delegate
                System.Threading.Thread.Sleep(100);  // Simulate hard work
            }
        }
    }
}
