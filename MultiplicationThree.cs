using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                int s;
                s = 3 * i;

                Console.WriteLine("3" + " * "+ i  + " = " + s);
            }
            Console.ReadLine();
       }
    }
}
