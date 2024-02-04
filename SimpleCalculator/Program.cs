using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;

            Console.WriteLine("Hello, welcome to the Simple Calculator Program");
            Console.WriteLine("Please, enter a first number: ");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please, enter a second number: ");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter 'a' for addition, 's' fot subtraction, 'm' for multiplication or 'd' for division.");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    while (num2 == 0)
                    {
                        Console.WriteLine("We DON'T divide by zero!!! Enter diffrent number: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }


            Console.WriteLine("Thank you for cooperation ;-)");

            Console.ReadKey();
        }
    }
}
