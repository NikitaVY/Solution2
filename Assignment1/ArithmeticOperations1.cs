using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ArithmeticOperations1
    {
        static void Main()
        {
            int x = 20, y = 2, ch;
            Console.WriteLine(" 0 : Addition");
            Console.WriteLine(" 1 : Subtraction");
            Console.WriteLine(" 2 : Product");
            Console.WriteLine(" 3 : Quotient");
            Console.WriteLine("Enter your choice :");
            ch = int.Parse(Console.ReadLine());
            Console.WriteLine("Using if-else statement ");
            if (ch == 0)
            {
                Console.WriteLine($"Addition of {x} and {y} is {x + y}");
            }
            else if (ch == 1)
            {
                Console.WriteLine($"Subtraction of {x} and {y} is {x - y}");
            }
            else if (ch == 2)
            {
                Console.WriteLine($"Product of {x} and {y} is {x * y}");
            }
            else if (ch ==3)
            {
                Console.WriteLine($"Quotient of {x} and {y} is {x / y}");
            }
            else
            {
                Console.WriteLine("Invalid Choice..");
            }

            Console.WriteLine("Using Switch Case Statements :");
            switch (ch)
            {
                case 0: Console.WriteLine($"Addition of {x} and {y} is {x + y}");
                    break;

                case 1: Console.WriteLine($"Subtraction of {x} and {y} is {x - y}");
                    break;

                case 2: Console.WriteLine($"Product of {x} and {y} is {x * y}");
                    break;

                case 3: Console.WriteLine($"Quotient of {x} and {y} is {x / y}");
                    break;

                default: Console.WriteLine("Invalid Choice..");
                    break;
            }
        }
    }
}
