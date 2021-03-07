using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3.Section1.Classes
{

    public class Deconstructors
    {
        static void Main(string[] args)
        {
            // To call the deconstructor, we use the following special syntax:
            var rect = new DeconstructorsDemo(3, 4,3);

            // Deconstruction
            (float width, float height, float init) = rect;          
            
            
            Console.WriteLine(width + " " + height);    // 3 4

            // We can also use implicit typing:  
            var (x, y, z) = rect;          // Deconstruction
            Console.WriteLine(x + " " + y);

            // If the variables already exist, we can do a *deconstructing assignment*:
            (x, y, z) = rect;
            Console.WriteLine(x + " " + y);


            Class1 c1 = Class1.Create();  // OK
            //Class1 c2 = new Class1();    // Error: Will not compile

            DeconstructorDemo();


            ObjectInitializer();



            IndexerDemo();


        }

        private static void IndexerDemo()
        {
            Sentence s = new Sentence();
            Console.WriteLine(s[3]);       // fox
            s[3] = "kangaroo";
            Console.WriteLine(s[3]);       // kangaroo

            // Test the indexers that use C#'s Indices and Ranges:
            Console.WriteLine(s[^1]);                // fox  
            //string[] firstTwoWords = s[..2].Dump();   // (The, quick)
        }

        private static void ObjectInitializer()
        {

            Bunny b1 = new Bunny{ Name = "Bo", LikesCarrots = true, LikesHumans = false };
            Bunny b2 = new Bunny("Bo") { LikesCarrots = true, LikesHumans = false };

            b1.Dump(); b2.Dump();
        }

        private static void DeconstructorDemo()
        {
            var rect = new Rectangle(3, 4);
            (float width, float height) = rect;          // Deconstruction
            Console.WriteLine(width + " " + height);    // 3 4

            // We can also use implicit typing:  
            var (x, y) = rect;          // Deconstruction
            Console.WriteLine(x + " " + y);

            // If the variables already exist, we can do a *deconstructing assignment*:
            (x, y) = rect;
            Console.WriteLine(x + " " + y);
        }
    }


    class Sentence
    {
        string[] words = "The quick brown fox".Split();

        public string this[int wordNum]      // indexer
        {
            get { return words[wordNum]; }
            set { words[wordNum] = value; }
        }

        // In C# 8, we can also define indexers that use the Index & Range types:
        public string this[Index index] => words[index];
        public string[] this[Range range] => words[range];

    }





    class Rectangle
    {
        public readonly float Width, Height;

        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public void Deconstruct(out float width, out float height)
        {
            width = Width;
            height = Height;
        }
    }


    public class Bunny
    {
        public string Name;
        public bool LikesCarrots;
        public bool LikesHumans;

        public Bunny() { }
        public Bunny(string n) { Name = n; }
    }



    public class Class1
    {
         Class1() { }    // Private constructor

        public static Class1 Create()
        {
            // Perform custom logic here to create & configure an instance of Class1
            /* ... */
            return new Class1();
        }
    }
 


    public class DeconstructorsDemo
    {
        public readonly float Width, Height, Init;

        public DeconstructorsDemo(float width, float height, float init)
        {
            Width = width;
            Height = height;
            Init = init;
        }

        public void Deconstruct(out float width, out float height, out float init)
        {
            width = Width;
            height = Height;
            init = Init;
        }
    }
}
