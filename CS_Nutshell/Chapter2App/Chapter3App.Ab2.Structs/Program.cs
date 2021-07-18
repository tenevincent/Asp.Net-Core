using ConsoleDump;
using System;

namespace Chapter3App.Ab2.Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();       // p1.x and p1.y will be 0
            p1.Dump();

            Point p2 = new Point(1, 1);   // p1.x and p1.y will be 1
            p2.Dump();

            var points = new Point[100];    // Error: will not compile!


            Console.ReadKey();
        }
    }



    public struct Point
    {
        int x ;           // Illegal: cannot initialize field
        int y;
        //public Point() { }   // Illegal: cannot have parameterless constructor  
        public Point(int x, int y) { this.y = y; this.x = x; }  // Illegal: must assign field y
    }


}
