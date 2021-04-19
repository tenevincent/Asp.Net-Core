using ConsoleDump;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4.Events
{
    public static class StringHelper
    {
        //public static bool IsCapitalized(this string s)
        //{
        //    if (string.IsNullOrEmpty(s)) return false;
        //    return char.IsUpper(s[0]);
        //}

        //public static bool IsCapitalized(this string s)
        //{
        //    "StringHelper.IsCapitalized".Dump();
        //    return char.IsUpper(s[0]);
        //}


        public static T First<T>(this IEnumerable<T> sequence)
        {
            foreach (T element in sequence)
                return element;

            throw new InvalidOperationException("No elements!");
        }

        public static string Pluralize(this string s) => s + "s";   // Very naiive implementation!

        public static string Capitalize(this string s) => s.ToUpper();
         
    }

    public static class Extensions
    {
        public static void Foo(this object t, int x) => "Extension".Dump();
    }



}
