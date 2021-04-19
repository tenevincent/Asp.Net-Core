using ConsoleDump;
using System;
using System.Collections.Generic;

namespace Chapter4.DynamicBindings
{
    class Program
    {
        static void Main(string[] args)
        {
            // CustomBinding();

            //LanguageBinding();
            //RuntimeRepresentationofDynamic();

              RuntimeBinderException();

           // VarVsDynamic();

            DynamicExpressions();


            Console.ReadKey();
        }

        private static void DynamicExpressions()
        {
            // Trying to consume the result of a dynamic expression with a void return type is
                // prohibited — just as with a statically typed expression. However, the error occurs at runtime:

            dynamic list = new List<int>();
            //var result = list.Add(5);         // RuntimeBinderException thrown

            // Expressions involving dynamic operands are typically themselves dynamic:
            dynamic x = 2;
            var y = x * 3;       // Static type of y is dynamic

            // However, casting a dynamic expression to a static type yields a static expression:
            dynamic a = 2;
            var b = (int)2;      // Static type of b is int

            // And constructor invocations always yield static expressions:
            dynamic capacity = 10;
            var sb = new System.Text.StringBuilder(capacity);
            int len = sb.Length;
        }

        private static void VarVsDynamic()
        {
            // var says, “let the compiler figure out the type”.
            // dynamic says, “let the runtime figure out the type”.

            dynamic x = "hello";  // Static type is dynamic, runtime type is string
            var y = "hello";      // Static type is string, runtime type is string
            int i = x;            // Run-time error
            //int j = y;            // Compile-time error
        }

        private static void RuntimeBinderException()
        {
            Action hello = () => Console.WriteLine("Say Hello");

            // Runtime Binder exception
            dynamic d = 5;
            d.Hello = hello;


            d.Hello();                  // throws RuntimeBinderException
        }

        private static void RuntimeRepresentationofDynamic()
        {
            // The following expression is true, although the compiler does not permit it:
            // typeof (dynamic) == typeof (object)

            // This principle extends to constructed types and array types:
            (typeof(List<dynamic>) == typeof(List<object>)).Dump();    // True

            (typeof(dynamic[]) == typeof(object[])).Dump();    // True

            // Like an object reference, a dynamic reference can point to an object of any type (except pointer types):
            dynamic x = "hello";
            Console.WriteLine(x.GetType().Name);  // String

            x = 123;  // No error (despite same variable)
            Console.WriteLine(x.GetType().Name);  // Int32

            // You can convert from object to dynamic to perform any dynamic operation you want on an object:
            object o = new System.Text.StringBuilder();
            dynamic d = o;
            d.Append("hello");
            Console.WriteLine(o);   // hello
        }

        private static void LanguageBinding()
        {
            // Language binding occurs when a dynamic object does not implement IDynamicMetaObjectProvider:
            string x = "d", y = "d";
            Console.WriteLine(Mean(x, y));
        }

        private static void CustomBinding()
        {
            dynamic d = new Duck();
            d.Quack();                  // Quack method was called
            d.Waddle();                 // Waddle method was called
        }

        static dynamic Mean(dynamic x, dynamic y) => (x + y)  ;

    }
}
