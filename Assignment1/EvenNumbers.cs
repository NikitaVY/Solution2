using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class EvenNumbers
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Enter number :");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Using for loop :");
            for (int j=1;j<=num;j++)
            {
                if(j%2 == 0)
                {
                    Console.WriteLine(j);
                }
            }

            Console.WriteLine("Using do-while loop");
            int i = 1;
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }while (i<=num);

            Console.WriteLine("Using while loop");
            int k = 1;
            while (k <= num)
            {
                if(k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
                k++;
            }
        }
    }
}
