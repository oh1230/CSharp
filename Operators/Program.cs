using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 55;
            int b = 4;

            Console.WriteLine("a = {0}\nb = {1}", a, b);

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("{0} % {1} = {2}", a, b, a % b);

            Console.WriteLine("\n");

            a = 1;

            Console.WriteLine("a = {0}", a);

            Console.WriteLine("++a = {0}", ++a);
            Console.WriteLine("a++ = {0}", a++);
            Console.WriteLine("--a = {0}", --a);
            Console.WriteLine("a-- = {0}", a--);
        }
    }
}