using ConsoleDump;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Chapter4.Events
{
    class ProgramExceptions
    {
        static void Main(string[] args)
        {
           // ExceptionsFilters();

            File.WriteAllText("file.txt", "test");
            ReadFile();

            if (File.Exists("file.txt"))
            {
                using var reader = File.OpenText("file.txt");
                Console.WriteLine(reader.ReadLine());
            }

            try
            {
                Display(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Caught the exception");
            }


        }

        static void Display(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            Console.WriteLine(name);
        }



        private static void ExceptionsFilters()
        {
            try
            {
                new WebClient().DownloadString("http://thisDoesNotExist");
            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.Timeout)
            {
                "Timeout!".Dump();
            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.NameResolutionFailure)
            {
                "Name resolution failure!".Dump();
            }
            catch (WebException ex)
            {
                $"Some other failure: {ex.Status}".Dump();
            }
        }

        static void ReadFile()
        {
            using (StreamReader reader = File.OpenText("file.txt"))
            {
                if (reader.EndOfStream) return;

                Console.WriteLine(reader.ReadToEnd());
            }
        }


    }
}
