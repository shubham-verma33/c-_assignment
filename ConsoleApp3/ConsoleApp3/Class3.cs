using System;

namespace ConsoleApp3
{
    class Table
    {
        public static void Main(string[] args)
        {
            int x, res;
            Console.WriteLine("Enter no to multiply");
            x = Convert.ToInt32(Console.ReadLine());
            res = x * 1;
            Console.WriteLine("The table is {0}*{1}={2}", x, 1, res);
            res = x * 2;
            Console.WriteLine("             {0}*{1}={2}", x, 2, res);
            res = x * 3;
            Console.WriteLine("             {0}*{1}={2}", x, 3, res);
            res = x * 4;
            Console.WriteLine("             {0}*{1}={2}", x, 4, res);
            res = x * 5;
            Console.WriteLine("             {0}*{1}={2}", x, 5, res);
            res = x * 6;
            Console.WriteLine("             {0}*{1}={2}", x, 6, res);
            res = x * 7;
            Console.WriteLine("             {0}*{1}={2}", x, 7, res);
            res = x * 8;
            Console.WriteLine("             {0}*{1}={2}", x, 8, res);
            res = x * 9;
            Console.WriteLine("             {0}*{1}={2}", x, 9, res);
            res = x * 10;
            Console.WriteLine("             {0}*{1}={2}", x, 10, res);
        }
    }
}