using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //String variable 
            string name;
            Console.WriteLine("Enter the customer name ");
            name = Console.ReadLine();// at run time getting the input from the 
            Console.WriteLine("the customer name is " + name);
            //int variable
            int age = 20;
            Console.WriteLine("Age of the user is " + age);
            //long variable 
            long SanctionNumber = 100005841584;
            Console.WriteLine("The Sanction no of the user is " + SanctionNumber);
            // to store a byte in a variable an to print 
            byte NoOfActiveLoan = 1;
            Console.WriteLine("No of active loans available for the user is " + NoOfActiveLoan);
            //short variable 
            short ExistingLoans = 10;
            Console.WriteLine("No of existing loan for the user " + ExistingLoans);
            //float variable
            float CurrentEmi = 3000.50f;
            Console.WriteLine("The current emi of the user per month in Rs." + CurrentEmi);
            //decimal   (m represents a decimal)
            decimal AmountInAccount = 1654614.20m;
            Console.WriteLine("The ammount available in the user account is " + AmountInAccount);
            //boolean value
            Boolean UserStatus = true;
            Console.WriteLine("verified current status of the user is Active or Not" + UserStatus);
            // to print the data and time 
            Console.WriteLine("current data and time " + DateTime.Now);

            System.Console.WriteLine("Happy Learning !!! code successfully executed");

            Console.Read();
        }
    }
}
