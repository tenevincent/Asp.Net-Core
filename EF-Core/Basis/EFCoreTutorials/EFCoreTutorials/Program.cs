using System;

namespace EFCoreTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            // AddEntity();

        //    QueryingData();

            Console.WriteLine("Hello World!");
            Console.Read();
        }

        //private static void QueryingData()
        //{
        //    var context = new SchoolContext();
        //    var studentsWithSameName = context.Students
        //                                      .Where(s => s.Name.StartsWith("Vincent"))
        //                                      .ToList();
        //    Console.WriteLine(studentsWithSameName.Dump());
        //}

        //private static void AddEntity()
        //{
        //    using (var context = new SchoolContext())
        //    {
        //        for (int i = 0; i < 5; i++)
        //        {
        //            var std = new Student()
        //            {
        //                Name = $"Vincent {i}"
        //            };

        //            context.Students.Add(std);
        //        }

        //        context.SaveChanges();
        //    }
        //}


        public static string GetName()
        {
            return "Bill";
        }

    }
}
