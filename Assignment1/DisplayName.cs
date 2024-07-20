using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class DisplayName
    {
        static void Main()
        {
            String name = "Nikita";
            for (int i=1;i<=10;i++)
            {
                Console.WriteLine($"{i} : {name}");
            }
        }
    }
}
