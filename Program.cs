using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();

            Console.WriteLine($"This is {name} from Scuf Testing ");
            Console.WriteLine("Current date and time is : ");
            Console.Write(DateTime.Now);
            Console.ReadKey();
            //Console.Write("\npress any key to exit.....");  -- always print statment should be above the .ReadKey() method
             


            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
