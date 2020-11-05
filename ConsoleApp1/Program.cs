using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("練習問題 1 - 1");
            Console.WriteLine("Hello World");
            Console.WriteLine("\n");

            int x2 = 11;
            Console.WriteLine("練習問題 1 - 2");
            Console.WriteLine("x={0}", x2); ;
            Console.WriteLine("\n");

            int x3 = 13;
            int y3 = 17;
            Console.WriteLine("練習問題 1 - 3");
            Console.WriteLine("x={0},y={1}", x3, y3);
            Console.WriteLine("\n");


            int x4 = 13 + 17;
            Console.WriteLine("練習問題 1 - 4");
            Console.WriteLine("x={0}" , x4);
            Console.WriteLine("\n");


            Console.WriteLine("練習問題 1 - 5");
            Console.WriteLine(13 * 17);
            Console.WriteLine("\n");

            int x6 = 7;
            x6 = x6 * 3;
            Console.WriteLine("練習問題 1 - 6");
            Console.WriteLine("x={0}" , x6);
            x6 = x6 / 2;
            Console.WriteLine("x={0}" , x6);
            Console.WriteLine("\n");

            int x7 = 3;
            int y7 = 7;
            int z7 = 0;
            z7 = x7;
            x7 = y7;
            y7 = z7;
            Console.WriteLine("練習問題 1 - 7");
            Console.WriteLine("x={0},y={1}", x7, y7);
            Console.WriteLine("\n");

            int x8 = 19;
            int y8 = 23;
            int z8 = 0;
            z8 = x8 * y8;
            Console.WriteLine("練習問題 1 - 8");
            Console.WriteLine("z={0}" , z8);
            Console.WriteLine("\n");

            int x9 = 100;
            Console.WriteLine("練習問題 1 - 9");
            Console.WriteLine("x={0}" , x9);
            int x92;
            x92 = x9 * 2;
            Console.WriteLine("xの2倍={0}", x92);
            int x93;
            x93 = x9 * 3;
            Console.WriteLine("xの3倍={0}", x93);
            int x94;
            x94 = x9 * 4;
            Console.WriteLine("xの3倍={0}", x94);
            Console.WriteLine("\n");

            int x10 = 2;
            Console.WriteLine("練習問題 1 - 10");
            Console.WriteLine("x={0}", x10);
            double x102 = Math.Pow(x10, 2);
            Console.WriteLine("xの2乗={0}", x102);
            double x103 = Math.Pow(x10, 3);
            Console.WriteLine("xの3乗={0}", x103);
            double x104 = Math.Pow(x10, 4);
            Console.WriteLine("xの4乗={0}", x104);
            Console.WriteLine("\n");

            int x11 = 11;
            int y11 = 2;
            Console.WriteLine("練習問題 1 - 11");
            Console.WriteLine("x={0}", x11);
            Console.WriteLine("y={0}", y11);
            int syou = DivRem(x11, y11, out int amari);

            Console.WriteLine("商={0}", syou);
            Console.WriteLine("余り={0}", amari);
            Console.WriteLine("\n");

 
            Console.WriteLine("練習問題 1 - 12");
            int x12 = 1;

            Console.WriteLine("インクリメント開始");
            while (x12 <= 5)
            {
                System.Console.WriteLine("x12 = {0}", x12++);
            }
            Console.WriteLine("インクリメント終了");
            Console.WriteLine("\n");
            Console.WriteLine("デクリメント開始");
  
            x12 = 5;
            while (x12 != 0)
            {
                System.Console.WriteLine("x12 = {0}", x12--);
            }
            Console.WriteLine("デクリメント終了");
            Console.WriteLine("\n");

            Console.ReadKey();

        }

        public static int DivRem(int a, int b, out int result)
        {
            result = a % b;
            return a / b;
        }
    }
}
