using System;
using System.Collections.Generic;
using System.IO;

namespace Asssignments_C_sharp
{
    class Program
    {
        static void Main()
        {
            try
            {
                int result;
                Console.Write(@"Enter first number: \n");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Enter second number: \n");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Enter the symbol (+,-,*,/):");
                string symbol = Console.ReadLine();


                switch (symbol)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("Addition : {0}", result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("Substraction : {0}", result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("Multiplication : {0}", result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("Division : {0}", result);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
            }
            Console.ReadLine();
        }
    }
}
