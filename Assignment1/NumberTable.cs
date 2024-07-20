using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class NumberTable
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Enter number to print table :");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Using for loop :");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num * i);   
            }

            Console.WriteLine("Using do-while loop :");
            int j = 1;
            do
            {
                Console.WriteLine(num * j);
                j++;
            }while(j<=10);

            Console.WriteLine("Using while loop :");
            int k = 1;
            while (k <= 10)
            {
                Console.WriteLine(num * k);
                k++;
            }
            
        }
    }
}
