using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class IndicesAndRanges
    {

        static void Main(string[] args)
        {

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            {
                char lastElement = vowels[^1]; // 'u'
                char secondToLast = vowels[^2]; // 'o'
                Console.WriteLine($"First: {lastElement} Second: {secondToLast}");
            }

            {
                Index first = 0;
                Index last = ^1;
                char firstElement = vowels[0]; // 'a'
                char lastElement = vowels[last]; // 'u'
                Console.WriteLine($"First: {firstElement} Second: {lastElement}");
            }

        }
    }
}
