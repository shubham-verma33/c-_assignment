using System;


namespace ConsoleApp3
{
    class Average
    {
        public static void Main()
        {
            int n1, n2, n3, n4, res;
            Console.WriteLine("Enter First No:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second No:");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third No:");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Fourth No:");
            n4 = Convert.ToInt32(Console.ReadLine());

            res = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine("Average :{0}+{1}+{2}+{3}/4={4}", n1, n2, n3, n4, res);
        }


    }
}