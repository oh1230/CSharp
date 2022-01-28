using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String day = "水";

            switch (day)
            {
                case "日":
                    Console.WriteLine("日曜日");
                    break;
                case "月":
                    Console.WriteLine("月曜日");
                    break;
                case "火":
                    Console.WriteLine("火曜日");
                    break;
                case "水":
                    Console.WriteLine("水曜日");
                    break;
                case "木":
                    Console.WriteLine("木曜日");
                    break;
                case "金":
                    Console.WriteLine("金曜日");
                    break;
                case "土":
                    Console.WriteLine("土曜日");
                    break;
                default:
                    Console.WriteLine("どんな曜日にも該当しません。");
                    break;
            }
        }
    }
}