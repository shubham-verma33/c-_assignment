using System;
using System.Collections.Generic;

namespace Asssignments_C_sharp
{
    class SwapNum
    {
        public static void Main()
        {
            Swapping();
        }
        public static void Swapping()
        {
            Console.Write("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Before swapping num1 = {0} and num2 = {1}", num1, num2);
            num1 = num1 * num2; //5 * 2 = 10
            num2 = num1 / num2; //10 / 2 = 5
            num1 = num1 / num2; //10 / 5 = 2
            Console.WriteLine();
            Console.WriteLine("After Swapping num1 = {0} and num2 = {1}", num1, num2);
        }
    }
}
