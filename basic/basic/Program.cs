using System;

namespace project1
{
    class calculator
    {
        public static void calplus (int a, int b)
        {
            Console.WriteLine("足し算の結果は{0}です。", a + b);
            Console.WriteLine("引き算の結果は{0}です。", a - b);
            Console.WriteLine("掛け算の結果は{0}です。", a * b);
            Console.WriteLine("割り算の結果は{0}です。", (float)a / (float)b);
        }
    }

    class testout
    {
        public static void outtest (int a, int b, out int c, out int d)
        {
            c = a / b;
            d = a & b;
        }
    }

    class swap
    {
        public static void abtoba (ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("関数内で変換されたAの値：{0},Bの値：{1}\n", a, b);
        }
    }

    class project1
    {
        static void Main (string[] args)
        {
            const string blink = "\n";
            int first = 1;
            int plus;
            int i, j = 1;
            string F_gugudan;
            int R_gugudan;
            int roof;
            string temp;
            int a, b, c, d;

            Console.WriteLine("数字を入力してください：");
            temp = Console.ReadLine();
            i = Convert.ToInt32(temp);

            Console.WriteLine("数字を入力してください：");
            temp = Console.ReadLine();
            j = Convert.ToInt32(temp);

            Console.WriteLine("");

            Console.Write("プロジェクト１{0}", blink);

            for (plus = 0; plus <= first; plus++)
            {
                Console.Write("現在の数値は：{0} {1}", plus, blink);
            }

            for (i = 5; i >= 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (;;)
            {
                Console.Write("出力してほしいgugudanは？（０入力し終了）：");
                F_gugudan = Console.ReadLine();
                R_gugudan = Convert.ToInt32(F_gugudan);

                if (R_gugudan == 0)
                {
                    break;
                }
                for (i = R_gugudan; j <= 9;)
                {
                    for (j = 1; j <= 9; j++)
                    {
                        Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                    }
                }
                j = 1;
            }

            for (;;)
            {
                Console.Write("繰り返す回数を入力（０以下を入力し終了）：");
                temp = Console.ReadLine();
                roof = Convert.ToInt32(temp);

                if (roof <= 0)
                {
                    Console.Write("\n");
                    break;
                }

                for (i = 0; i <= roof; i++)
                {
                    for (j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }

            Console.Write("四則演算する数字の中、最初の数字を入力してください：");
            temp = Console.ReadLine();
            i = Convert.ToInt32(temp);

            Console.Write("四則演算する数字の中、二番目の数字を入力してください：");
            temp = Console.ReadLine();
            j = Convert.ToInt32(temp);

            calculator.calplus(i, j);

            Console.Write("数字一個を入力してください：");
            temp = Console.ReadLine();
            i = Convert.ToInt32(temp);

            Console.Write("数字一個を入力してください：");
            temp = Console.ReadLine();
            j = Convert.ToInt32(temp);

            Console.WriteLine("Mainクラス内での変化値A：{0},B：{1}{2}",i, j, blink);

            Console.WriteLine("数字二つを入力してください(1)：");
            temp = Console.ReadLine();
            a = Convert.ToInt32(temp);

            Console.WriteLine("数字二つを入力してください(2)：");
            temp =Console.ReadLine();
            b = Convert.ToInt32(temp);

            testout.outtest(a, b, out c, out d);

            Console.WriteLine("割り算：{0}, 商：{1}", c, d);

        }
    }
}