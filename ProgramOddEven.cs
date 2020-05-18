using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing the even number :");
            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i +" ");                    
                }

            }
            Console.WriteLine('\n' + "Printing the odd number :");
            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
        
    }
}
