using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            
            if (a > 0)
            {
                Console.WriteLine("a는 양수입니다.");
                if (a > 30)
                {
                    Console.WriteLine("a is bigger than 30");
                }
            }
            else
                Console.WriteLine("a는 양수가 아닙니다.");
        }
    }
}