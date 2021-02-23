using ConsoleDump;
using System;

namespace Chapter4
{
    delegate int Transformer(int x);   // Our delegate type declaration

    public delegate void ProgressReporter(int percentComplete);







    class Program
    {
        static int Square(int x) => x * x;


        static int Cube(int x) => x * x * x;

        static void Main(string[] args)
        {
            Transformer transformer = Square;          // Create delegate instance
            int result = transformer(3);               // Invoke delegate
            Console.WriteLine(result);      // 9


            // WritingPluginsMethods();
            // ProgressReporterDemo();

            // MultiCastDelegateDemo();

            FuncAndActions();

            Console.ReadKey();
        }

        /// <summary>
        ///  With the Func and Action family of delegates in the System namespace, you can avoid the
        ///  need for creating most custom delegate types:
        /// </summary>
        private static void FuncAndActions()
        {
            int[] values = { 1, 2, 3 };
            Util.Transform(values, Square);      // Dynamically hook in Square
            values.Dump();
        }

        private static void MultiCastDelegateDemo()
        {
            ProgressReporter p = WriteProgressToConsole;
            p += WriteProgressToFile;
            Util.HardWork(p);
        }

        static void WriteProgressToConsole(int percentComplete)
        {
            Console.WriteLine(percentComplete);
        }



        static void WriteProgressToFile(int percentComplete)
        {
            System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());
        }



        private static void ProgressReporterDemo()
        {

            MyReporter r = new MyReporter();
            r.Prefix = "%Complete: ";
            ProgressReporter p = r.ReportProgress;
            p(99);                                 // 99
            Console.WriteLine(p.Target == r);     // True
            Console.WriteLine(p.Method);          // Void InstanceProgress(Int32)
            r.Prefix = "";
            p(99);
        }

        private static void WritingPluginsMethods()
        {
            int[] values = { 1, 2, 3 };
            Transform(values, Square);   // Hook in the Square method
            values.Dump();

            values = new int[] { 1, 2, 3 };
            Transform(values, Cube);          // Hook in the Cube method
            values.Dump();
        }

        static void Transform(int[] values, Transformer transformer)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = transformer(values[i]);
        }




    }


    class MyReporter
    {
        public string Prefix = "";
        public void ReportProgress(int percentComplete) => Console.WriteLine(Prefix + percentComplete);
    }
}
