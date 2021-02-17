using System;

namespace Chapter3.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            var logger = new Logger();
            // We can't call the Log method directly:
            //foo.Log ("message")   // Won't compile

            // But we can call it via the interface:
            ((ILogger)logger).Log("message");

            Console.WriteLine(ILogger.ExceptionHeader);

        }
    }


    interface ILogger
    {
        // Let's suppose the interface as always defined this method:
        void Log(string message);

        // Adding a new member to an interface need not break implementors:
        public void Log(Exception ex) => Log(ExceptionHeader + ex.Message);

        static string ExceptionHeader = "Exception: ";
    }
    class Logger : ILogger
    {
        // We don't need to implement anything
        public Logger()
        {
            (this as ILogger).Log("Log called in the constructor!");
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
